using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using CSharpScript.Game.Common;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Render;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001674 RID: 5748
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class LordGymModel : ModelBase
{
	// Token: 0x0600DFBD RID: 57277 RVA: 0x0041ACD4 File Offset: 0x00418ED4
	protected override bool OnInit()
	{
		this.LordId2EntranceIdMap = new Dictionary<int, int>();
		foreach (LordGymEntrance lordGymEntrance in LordGymConfig.Instance.GetLordGymEntranceAllConfig())
		{
			foreach (int key in lordGymEntrance.LordGymList())
			{
				this.LordId2EntranceIdMap.Add(key, lordGymEntrance.Id);
			}
		}
		return true;
	}

	// Token: 0x0600DFBE RID: 57278 RVA: 0x0041AD5C File Offset: 0x00418F5C
	public bool GetLordGymIsUnLock(int lordId)
	{
		return this.UnLockLordGym.Contains(lordId);
	}

	// Token: 0x0600DFBF RID: 57279 RVA: 0x0041AD6C File Offset: 0x00418F6C
	public bool IsLordGymUnlockedByGroup(int lordId)
	{
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(lordId);
		int num;
		return lordGymConfig != null && this.LordGymGroupPassDiff.TryGetValue(lordGymConfig.Value.FilterType, out num) && lordGymConfig.Value.Difficulty <= num + 1;
	}

	// Token: 0x0600DFC0 RID: 57280 RVA: 0x0041ADC8 File Offset: 0x00418FC8
	public void UpdateLordGymGroupInfos([Nullable(new byte[]
	{
		2,
		1
	})] List<LordGymGroupInfo> infos)
	{
		this.LordGymGroupPassDiff.Clear();
		if (infos == null)
		{
			return;
		}
		foreach (LordGymGroupInfo lordGymGroupInfo in infos)
		{
			this.LordGymGroupPassDiff[lordGymGroupInfo.GroupId] = lordGymGroupInfo.PassDiff;
		}
	}

	// Token: 0x0600DFC1 RID: 57281 RVA: 0x0041AE38 File Offset: 0x00419038
	public bool GetLordGymHasRead(int lordId)
	{
		return this.ReadLoadGymIds.Contains(lordId);
	}

	// Token: 0x0600DFC2 RID: 57282 RVA: 0x0041AE46 File Offset: 0x00419046
	public void ReadLordGym(int lordId)
	{
		this.ReadLoadGymIds.Add(lordId);
	}

	// Token: 0x0600DFC3 RID: 57283 RVA: 0x0041AE54 File Offset: 0x00419054
	[NullableContext(2)]
	public int[] GetLordGymEntranceList(int lordEntranceId)
	{
		return LordGymConfig.Instance.GetLordGymEntranceLordList(lordEntranceId);
	}

	// Token: 0x0600DFC4 RID: 57284 RVA: 0x0041AE64 File Offset: 0x00419064
	public bool GetLastGymFinish(int lordId)
	{
		LordGym value = LordGymConfig.Instance.GetLordGymConfig(lordId).Value;
		if (value.Difficulty <= 1)
		{
			return true;
		}
		if (this.IsLordGymUnlockedByGroup(lordId))
		{
			return true;
		}
		foreach (LordGym lordGym in LordGymConfig.Instance.GetLordGymAllConfigByDifficulty(value.Difficulty - 1))
		{
			if (lordGym.PlayId == value.PlayId)
			{
				return this.LordGymRecord.ContainsKey(lordGym.Id);
			}
		}
		return false;
	}

	// Token: 0x0600DFC5 RID: 57285 RVA: 0x0041AF0C File Offset: 0x0041910C
	public int? GetNextGymId(int lordId)
	{
		LordGym value = LordGymConfig.Instance.GetLordGymConfig(lordId).Value;
		IReadOnlyList<LordGym> lordGymAllConfigByDifficulty = LordGymConfig.Instance.GetLordGymAllConfigByDifficulty(value.Difficulty + 1);
		if (lordGymAllConfigByDifficulty == null)
		{
			return null;
		}
		foreach (LordGym lordGym in lordGymAllConfigByDifficulty)
		{
			if (lordGym.PlayId == value.PlayId)
			{
				return new int?(lordGym.Id);
			}
		}
		return null;
	}

	// Token: 0x0600DFC6 RID: 57286 RVA: 0x0041AFB4 File Offset: 0x004191B4
	public bool GetLordGymIsFinish(int lordId)
	{
		if (lordId == 0)
		{
			return false;
		}
		if (this.LordGymRecord.ContainsKey(lordId))
		{
			return true;
		}
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(lordId);
		if (lordGymConfig == null)
		{
			return false;
		}
		foreach (int lordId2 in this.LordGymRecord.Keys)
		{
			LordGym? lordGymConfig2 = LordGymConfig.Instance.GetLordGymConfig(lordId2);
			if (lordGymConfig2 != null && lordGymConfig2.Value.PlayId == lordGymConfig.Value.PlayId && lordGymConfig2.Value.Difficulty >= lordGymConfig.Value.Difficulty)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600DFC7 RID: 57287 RVA: 0x0041B094 File Offset: 0x00419294
	public int? GetMarkIdByLordGymId(int gymId)
	{
		int lordEntranceId;
		if (!this.LordId2EntranceIdMap.TryGetValue(gymId, out lordEntranceId))
		{
			return null;
		}
		LordGymEntrance? lordGymEntranceConfig = LordGymConfig.Instance.GetLordGymEntranceConfig(lordEntranceId);
		if (lordGymEntranceConfig == null)
		{
			return null;
		}
		return new int?(lordGymEntranceConfig.GetValueOrDefault().MarkId);
	}

	// Token: 0x0600DFC8 RID: 57288 RVA: 0x0041B0F0 File Offset: 0x004192F0
	public int GetEntranceIdByLordId(int lordId)
	{
		int result;
		if (this.LordId2EntranceIdMap != null && this.LordId2EntranceIdMap.TryGetValue(lordId, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x0600DFC9 RID: 57289 RVA: 0x0041B118 File Offset: 0x00419318
	[NullableContext(2)]
	public string GetLordGymEntranceFinish(int gymEntranceId)
	{
		int? gymCanFightMaxLevelWithoutLockCondition = this.GetGymCanFightMaxLevelWithoutLockCondition(gymEntranceId);
		string str = this.GetHasFinishLord(gymEntranceId).ToString();
		string str2 = "/";
		int? num = gymCanFightMaxLevelWithoutLockCondition;
		return str + str2 + num.ToString();
	}

	// Token: 0x0600DFCA RID: 57290 RVA: 0x0041B158 File Offset: 0x00419358
	public int GetHasFinishLord(int gymEntranceId)
	{
		LordGymEntrance? lordGymEntranceConfig = LordGymConfig.Instance.GetLordGymEntranceConfig(gymEntranceId);
		if (lordGymEntranceConfig == null)
		{
			return 0;
		}
		int[] array = lordGymEntranceConfig.Value.LordGymList();
		int num = 0;
		foreach (int lordId in array)
		{
			if (this.GetLordGymIsFinish(lordId))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x0600DFCB RID: 57291 RVA: 0x0041B1B8 File Offset: 0x004193B8
	public int? GetMaxDifficultyLordGymEntrance(int gymEntranceId)
	{
		LordGymEntrance? lordGymEntranceConfig = LordGymConfig.Instance.GetLordGymEntranceConfig(gymEntranceId);
		if (lordGymEntranceConfig == null)
		{
			return null;
		}
		int num = 0;
		foreach (int lordId in lordGymEntranceConfig.Value.LordGymList())
		{
			LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(lordId);
			if (this.GetLordGymIsUnLock(lordId) && lordGymConfig.Value.Difficulty > num)
			{
				num = lordGymConfig.Value.Difficulty;
			}
		}
		return new int?(num);
	}

	// Token: 0x0600DFCC RID: 57292 RVA: 0x0041B254 File Offset: 0x00419454
	public int? GetMaxDifficultyLordGymEntranceCanFight(int gymEntranceId)
	{
		LordGymEntrance? lordGymEntranceConfig = LordGymConfig.Instance.GetLordGymEntranceConfig(gymEntranceId);
		if (lordGymEntranceConfig == null)
		{
			return null;
		}
		int num = 1;
		foreach (int num2 in lordGymEntranceConfig.Value.LordGymList())
		{
			LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(num2);
			if (lordGymConfig.Value.Difficulty > 1 && this.GetLordGymIsUnLock(num2) && this.GetLordGymIsFinish(num2 - 1) && lordGymConfig.Value.Difficulty > num)
			{
				num = lordGymConfig.Value.Difficulty;
			}
		}
		return new int?(num);
	}

	// Token: 0x0600DFCD RID: 57293 RVA: 0x0041B310 File Offset: 0x00419510
	public int GetCanFightLordGym(bool isNewLordGym = false)
	{
		foreach (int num in this.UnLockLordGym)
		{
			LordGym value = LordGymConfig.Instance.GetLordGymConfig(num).Value;
			bool lordGymIsUnLock = this.GetLordGymIsUnLock(num);
			bool flag = value.Difficulty == 1 || this.GetLordGymIsFinish(num - 1);
			bool lordGymIsFinish = this.GetLordGymIsFinish(num);
			if (lordGymIsUnLock && flag && !lordGymIsFinish)
			{
				return num;
			}
		}
		return 0;
	}

	// Token: 0x0600DFCE RID: 57294 RVA: 0x0041B3AC File Offset: 0x004195AC
	public bool GetGymEntranceAllFinish(int gymEntranceId)
	{
		LordGymEntrance? lordGymEntranceConfig = LordGymConfig.Instance.GetLordGymEntranceConfig(gymEntranceId);
		if (lordGymEntranceConfig == null)
		{
			return false;
		}
		foreach (int lordId in lordGymEntranceConfig.Value.LordGymList())
		{
			if (!this.GetLordGymIsFinish(lordId))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600DFCF RID: 57295 RVA: 0x0041B400 File Offset: 0x00419600
	public int? GetGymCanFightMaxLevelWithoutLockCondition(int gymEntranceId)
	{
		LordGymEntrance? lordGymEntranceConfig = LordGymConfig.Instance.GetLordGymEntranceConfig(gymEntranceId);
		if (lordGymEntranceConfig == null)
		{
			return null;
		}
		int num = 1;
		foreach (int lordId in lordGymEntranceConfig.Value.LordGymList())
		{
			LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(lordId);
			if (lordGymConfig.Value.Difficulty > 1 && this.GetLordGymIsUnLock(lordId) && lordGymConfig.Value.Difficulty > num)
			{
				num = lordGymConfig.Value.Difficulty;
			}
		}
		return new int?(num);
	}

	// Token: 0x0600DFD0 RID: 57296 RVA: 0x0041B4B0 File Offset: 0x004196B0
	public int? GetGymCanFightMaxLevel(int gymEntranceId)
	{
		LordGymEntrance? lordGymEntranceConfig = LordGymConfig.Instance.GetLordGymEntranceConfig(gymEntranceId);
		if (lordGymEntranceConfig == null)
		{
			return null;
		}
		int num = 1;
		foreach (int lordId in lordGymEntranceConfig.Value.LordGymList())
		{
			LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(lordId);
			if (lordGymConfig.Value.Difficulty > 1 && lordGymConfig.Value.Difficulty > num)
			{
				num = lordGymConfig.Value.Difficulty;
			}
		}
		return new int?(num);
	}

	// Token: 0x0600DFD1 RID: 57297 RVA: 0x0041B554 File Offset: 0x00419754
	[NullableContext(0)]
	public ValueTuple<int, int> GetLordGymCurrencyRewardAndTotalCount(int gymEntranceSetId)
	{
		int[] array = ConfigLordGymEntranceSetById.GetConfig(gymEntranceSetId, true).Value.LordEntranceList();
		int num = 0;
		int num2 = 0;
		LordGymConfig instance = LordGymConfig.Instance;
		ExchangeRewardConfig instance2 = ExchangeRewardConfig.Instance;
		foreach (int lordEntranceId in array)
		{
			foreach (int lordId in instance.GetLordGymEntranceConfig(lordEntranceId).Value.LordGymList())
			{
				int rewardId = instance.GetLordGymConfig(lordId).Value.RewardId;
				List<TItem> exchangeRewardPreviewRewardList = instance2.GetExchangeRewardPreviewRewardList(rewardId, null);
				bool lordGymIsFinish = this.GetLordGymIsFinish(lordId);
				foreach (TItem titem in exchangeRewardPreviewRewardList)
				{
					if (titem.ItemData.ItemId == 34 || titem.ItemData.ItemId == 63 || titem.ItemData.ItemId == 11 || titem.ItemData.ItemId == 82)
					{
						if (lordGymIsFinish)
						{
							num += titem.Count;
						}
						num2 += titem.Count;
					}
				}
			}
		}
		return new ValueTuple<int, int>(num, num2);
	}

	// Token: 0x0600DFD2 RID: 57298 RVA: 0x0041B6BC File Offset: 0x004198BC
	public bool IsChallenging()
	{
		return this.CurrentChallengeLordGymId > 0;
	}

	// Token: 0x0600DFD3 RID: 57299 RVA: 0x0041B6C7 File Offset: 0x004198C7
	public void InitNewLordGymEntranceIdRecord()
	{
		this.NewLordGymEntranceIdRecord = (LocalStorage.GetPlayer<List<int>>(ELocalStoragePlayerKey.NewLordGymEntranceIdRecord, null) ?? new List<int>());
	}

	// Token: 0x0600DFD4 RID: 57300 RVA: 0x0041B6E0 File Offset: 0x004198E0
	public void RecordNewLordGymEntrance(int entranceId)
	{
		if (this.NewLordGymEntranceIdRecord == null || this.IsNewLordGymEntranceRecord(entranceId))
		{
			return;
		}
		this.NewLordGymEntranceIdRecord.Add(entranceId);
		LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.NewLordGymEntranceIdRecord, this.NewLordGymEntranceIdRecord);
	}

	// Token: 0x0600DFD5 RID: 57301 RVA: 0x0041B70E File Offset: 0x0041990E
	public bool IsNewLordGymEntranceRecord(int entranceId)
	{
		List<int> newLordGymEntranceIdRecord = this.NewLordGymEntranceIdRecord;
		return newLordGymEntranceIdRecord != null && newLordGymEntranceIdRecord.Contains(entranceId);
	}

	// Token: 0x0600DFD6 RID: 57302 RVA: 0x0041B724 File Offset: 0x00419924
	public void PhraseEntranceInfo(List<Aki.Protocol.LordGymEntranceInfo> info)
	{
		if (info == null)
		{
			return;
		}
		this.LordGymEntranceInfo.Clear();
		foreach (Aki.Protocol.LordGymEntranceInfo info2 in info)
		{
			global::LordGymEntranceInfo lordGymEntranceInfo = new global::LordGymEntranceInfo();
			lordGymEntranceInfo.Phrase(info2);
			this.LordGymEntranceInfo.Add(lordGymEntranceInfo);
		}
	}

	// Token: 0x0600DFD7 RID: 57303 RVA: 0x0041B794 File Offset: 0x00419994
	public List<int> GetLordGymEntranceWithNewTag()
	{
		this.LordGymEntrancesWithNewTag.Clear();
		foreach (global::LordGymEntranceInfo lordGymEntranceInfo in this.LordGymEntranceInfo)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			if (serverTime >= lordGymEntranceInfo.EffectBeginTime && serverTime <= lordGymEntranceInfo.EffectEndTime)
			{
				this.LordGymEntrancesWithNewTag.Add(lordGymEntranceInfo.Id);
			}
		}
		return this.LordGymEntrancesWithNewTag;
	}

	// Token: 0x0600DFD8 RID: 57304 RVA: 0x0041B820 File Offset: 0x00419A20
	[NullableContext(2)]
	public ALevelSequenceActor GetLordGymThirdBossSequenceActor()
	{
		return this.LordGymThirdBossSequenceActor;
	}

	// Token: 0x0600DFD9 RID: 57305 RVA: 0x0041B828 File Offset: 0x00419A28
	public void DestroyLordGymThirdBossSequenceActor()
	{
		if (this.LordGymThirdBossSequenceActor != null && this.LordGymThirdBossSequenceActor.IsValid())
		{
			ULevelSequencePlayer sequencePlayer = this.LordGymThirdBossSequenceActor.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Stop();
			}
			this.LordGymThirdBossSequenceActor.K2_DestroyActor();
			this.LordGymThirdBossSequenceActor = null;
		}
	}

	// Token: 0x0600DFDA RID: 57306 RVA: 0x0041B868 File Offset: 0x00419A68
	protected void PlaybackPosition(bool isStart)
	{
		if (this.LordGymThirdBossSequenceActor == null || !this.LordGymThirdBossSequenceActor.IsValid())
		{
			return;
		}
		UKuroSceneInteractionActorSystem ukuroSceneInteractionActorSystem = UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroSceneInteractionActorSystem.StaticClass()) as UKuroSceneInteractionActorSystem;
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("MonsterCase").Value, ECollectActorType.UI);
		if (actorWithTag != null && actorWithTag.IsValid() && ukuroSceneInteractionActorSystem != null)
		{
			ukuroSceneInteractionActorSystem.SetSequenceWithTargetLevelActor(this.LordGymThirdBossSequenceActor, this.LordGymThirdBossSequenceActor.GetSequence(), actorWithTag);
		}
		UKuroSequenceRuntimeFunctionLibrary.SetSequenceInUiScene(this.LordGymThirdBossSequenceActor.GetSequence(), true);
		this.LordGymThirdBossSequenceActor.bOverrideInstanceData = true;
		UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.LordGymThirdBossSequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
		FTransform transformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(RenderModuleController.Instance.GetKuroCurrentUiSceneTransform().Value);
		udefaultLevelSequenceInstanceData.TransformOrigin = transformOrigin;
		FFrameTime fframeTime;
		if (!isStart)
		{
			ALevelSequenceActor lordGymThirdBossSequenceActor = this.LordGymThirdBossSequenceActor;
			if (lordGymThirdBossSequenceActor == null)
			{
				fframeTime = null;
			}
			else
			{
				ULevelSequencePlayer sequencePlayer = lordGymThirdBossSequenceActor.SequencePlayer;
				fframeTime = ((sequencePlayer != null) ? sequencePlayer.GetEndTime().Time : null);
			}
		}
		else
		{
			ALevelSequenceActor lordGymThirdBossSequenceActor2 = this.LordGymThirdBossSequenceActor;
			if (lordGymThirdBossSequenceActor2 == null)
			{
				fframeTime = null;
			}
			else
			{
				ULevelSequencePlayer sequencePlayer2 = lordGymThirdBossSequenceActor2.SequencePlayer;
				fframeTime = ((sequencePlayer2 != null) ? sequencePlayer2.GetStartTime().Time : null);
			}
		}
		FFrameTime fframeTime2 = fframeTime;
		if (fframeTime2 != null)
		{
			FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams
			{
				Frame = fframeTime2,
				PositionType = EMovieScenePositionType.Frame,
				UpdateMethod = EUpdatePositionMethod.Play
			};
			ALevelSequenceActor lordGymThirdBossSequenceActor3 = this.LordGymThirdBossSequenceActor;
			if (lordGymThirdBossSequenceActor3 == null)
			{
				return;
			}
			ULevelSequencePlayer sequencePlayer3 = lordGymThirdBossSequenceActor3.SequencePlayer;
			if (sequencePlayer3 == null)
			{
				return;
			}
			sequencePlayer3.SetPlaybackPosition(playbackPosition);
		}
	}

	// Token: 0x0600DFDB RID: 57307 RVA: 0x0041B9C0 File Offset: 0x00419BC0
	private UniTask CreateLordGymThirdBossSequence(bool isStart)
	{
		LordGymModel.<CreateLordGymThirdBossSequence>d__54 <CreateLordGymThirdBossSequence>d__;
		<CreateLordGymThirdBossSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateLordGymThirdBossSequence>d__.<>4__this = this;
		<CreateLordGymThirdBossSequence>d__.isStart = isStart;
		<CreateLordGymThirdBossSequence>d__.<>1__state = -1;
		<CreateLordGymThirdBossSequence>d__.<>t__builder.Start<LordGymModel.<CreateLordGymThirdBossSequence>d__54>(ref <CreateLordGymThirdBossSequence>d__);
		return <CreateLordGymThirdBossSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFDC RID: 57308 RVA: 0x0041BA0C File Offset: 0x00419C0C
	public UniTask EnterLordGymThirdBossScene(bool isStart)
	{
		LordGymModel.<EnterLordGymThirdBossScene>d__55 <EnterLordGymThirdBossScene>d__;
		<EnterLordGymThirdBossScene>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EnterLordGymThirdBossScene>d__.<>4__this = this;
		<EnterLordGymThirdBossScene>d__.isStart = isStart;
		<EnterLordGymThirdBossScene>d__.<>1__state = -1;
		<EnterLordGymThirdBossScene>d__.<>t__builder.Start<LordGymModel.<EnterLordGymThirdBossScene>d__55>(ref <EnterLordGymThirdBossScene>d__);
		return <EnterLordGymThirdBossScene>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFDD RID: 57309 RVA: 0x0041BA58 File Offset: 0x00419C58
	public void ExitLordGymThirdBossScene()
	{
		UKuroGISystem kuroGISystem = UKuroGISystem.GetKuroGISystem(GlobalData.World);
		if (kuroGISystem == null)
		{
			return;
		}
		BP_GlobalGI_C bp_GlobalGI_C = kuroGISystem.GetKuroGlobalGIActor() as BP_GlobalGI_C;
		bp_GlobalGI_C.UINeedLerpData = false;
		if (bp_GlobalGI_C.GlobalUiScenePostProcess != null)
		{
			bp_GlobalGI_C.GlobalUiScenePostProcess.bEnabled = true;
		}
		if (bp_GlobalGI_C.GlobalPostProcessVolume != null)
		{
			bp_GlobalGI_C.GlobalPostProcessVolume.bIsUISceneRendering = false;
		}
	}

	// Token: 0x0600DFDE RID: 57310 RVA: 0x0041BAB0 File Offset: 0x00419CB0
	public void PreloadThird5SceneEffect(int entranceId)
	{
		LordGymEntrance? config = ConfigLordGymEntranceById.GetConfig(entranceId, true);
		if (config == null || string.IsNullOrEmpty(config.Value.LordUISceneEffect))
		{
			return;
		}
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = new FTransformDouble?(this.Third5SceneEffectTransform);
		instance.SpawnEffect(world, ftransformDouble, config.Value.LordUISceneEffect, "LordGymSceneEffect", null, EEffectType.UiScene3D, null, null, null, true, false);
	}

	// Token: 0x0600DFDF RID: 57311 RVA: 0x0041BB20 File Offset: 0x00419D20
	public void PlayThird5SceneEffect(int entranceId)
	{
		if (EffectSystem.Instance.IsValid(this.Third5SceneEffectHandle))
		{
			EffectSystem.Instance.StopEffectById(this.Third5SceneEffectHandle, "[LordGymModel.PlayThird5SceneEffect]", true, null);
			this.Third5SceneEffectHandle = 0;
		}
		LordGymEntrance? config = ConfigLordGymEntranceById.GetConfig(entranceId, true);
		if (config == null || string.IsNullOrEmpty(config.Value.LordUISceneEffect))
		{
			return;
		}
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = new FTransformDouble?(this.Third5SceneEffectTransform);
		this.Third5SceneEffectHandle = instance.SpawnEffect(world, ftransformDouble, config.Value.LordUISceneEffect, "LordGymSceneEffect", null, EEffectType.UiScene3D, null, null, null, false, false);
		AudioSystem.Instance.PostEvent("play_ui_daoguan_3_5_efx_scene");
	}

	// Token: 0x0600DFE0 RID: 57312 RVA: 0x0041BBDC File Offset: 0x00419DDC
	public void EnterLordGymThird5BossScene()
	{
		UKuroGISystem kuroGISystem = UKuroGISystem.GetKuroGISystem(GlobalData.World);
		if (kuroGISystem == null)
		{
			return;
		}
		BP_GlobalGI_C bp_GlobalGI_C = kuroGISystem.GetKuroGlobalGIActor() as BP_GlobalGI_C;
		bp_GlobalGI_C.UINeedLerpData = true;
		if (bp_GlobalGI_C.GlobalUiScenePostProcess != null)
		{
			bp_GlobalGI_C.GlobalUiScenePostProcess.bEnabled = false;
		}
		if (bp_GlobalGI_C.GlobalPostProcessVolume != null)
		{
			bp_GlobalGI_C.GlobalPostProcessVolume.bIsUISceneRendering = true;
		}
	}

	// Token: 0x0600DFE1 RID: 57313 RVA: 0x0041BC34 File Offset: 0x00419E34
	public void ExitLordGymThird5BossScene()
	{
		UKuroGISystem kuroGISystem = UKuroGISystem.GetKuroGISystem(GlobalData.World);
		if (kuroGISystem == null)
		{
			return;
		}
		BP_GlobalGI_C bp_GlobalGI_C = kuroGISystem.GetKuroGlobalGIActor() as BP_GlobalGI_C;
		bp_GlobalGI_C.UINeedLerpData = false;
		if (bp_GlobalGI_C.GlobalUiScenePostProcess != null)
		{
			bp_GlobalGI_C.GlobalUiScenePostProcess.bEnabled = true;
		}
		if (bp_GlobalGI_C.GlobalPostProcessVolume != null)
		{
			bp_GlobalGI_C.GlobalPostProcessVolume.bIsUISceneRendering = false;
		}
		if (EffectSystem.Instance.IsValid(this.Third5SceneEffectHandle))
		{
			EffectSystem.Instance.StopEffectById(this.Third5SceneEffectHandle, "[LordGymModel.ExitLordGymThird5BossScene]", true, null);
			this.Third5SceneEffectHandle = 0;
		}
	}

	// Token: 0x0600DFE2 RID: 57314 RVA: 0x0041BCC4 File Offset: 0x00419EC4
	public void EnterLordGymFirstBossScene()
	{
		UKuroGISystem kuroGISystem = UKuroGISystem.GetKuroGISystem(GlobalData.World);
		if (kuroGISystem == null)
		{
			return;
		}
		BP_GlobalGI_C bp_GlobalGI_C = kuroGISystem.GetKuroGlobalGIActor() as BP_GlobalGI_C;
		bp_GlobalGI_C.UINeedLerpData = true;
		if (bp_GlobalGI_C.GlobalUiScenePostProcess != null)
		{
			bp_GlobalGI_C.GlobalUiScenePostProcess.bEnabled = false;
		}
		if (bp_GlobalGI_C.GlobalPostProcessVolume != null)
		{
			bp_GlobalGI_C.GlobalPostProcessVolume.bIsUISceneRendering = true;
		}
	}

	// Token: 0x0600DFE3 RID: 57315 RVA: 0x0041BD1C File Offset: 0x00419F1C
	public void ExitLordGymFirstBossScene()
	{
		UKuroGISystem kuroGISystem = UKuroGISystem.GetKuroGISystem(GlobalData.World);
		if (kuroGISystem == null)
		{
			return;
		}
		BP_GlobalGI_C bp_GlobalGI_C = kuroGISystem.GetKuroGlobalGIActor() as BP_GlobalGI_C;
		bp_GlobalGI_C.UINeedLerpData = false;
		if (bp_GlobalGI_C.GlobalUiScenePostProcess != null)
		{
			bp_GlobalGI_C.GlobalUiScenePostProcess.bEnabled = true;
		}
		if (bp_GlobalGI_C.GlobalPostProcessVolume != null)
		{
			bp_GlobalGI_C.GlobalPostProcessVolume.bIsUISceneRendering = false;
		}
	}

	// Token: 0x17001562 RID: 5474
	// (get) Token: 0x0600DFE4 RID: 57316 RVA: 0x0041BD73 File Offset: 0x00419F73
	public static LordGymModel Instance
	{
		get
		{
			return LordGymModel._Instance;
		}
	}

	// Token: 0x0600DFE5 RID: 57317 RVA: 0x0041BD7A File Offset: 0x00419F7A
	public static LordGymModel GetOrCreateInstance()
	{
		if (LordGymModel._Instance == null)
		{
			LordGymModel.CreateInstance();
		}
		return LordGymModel._Instance;
	}

	// Token: 0x0600DFE6 RID: 57318 RVA: 0x0041BD8E File Offset: 0x00419F8E
	public static bool CreateInstance()
	{
		if (LordGymModel._Instance != null)
		{
			return true;
		}
		LordGymModel._Instance = new LordGymModel();
		return true;
	}

	// Token: 0x0600DFE7 RID: 57319 RVA: 0x0041BDA4 File Offset: 0x00419FA4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DFE8 RID: 57320 RVA: 0x0041BDA6 File Offset: 0x00419FA6
	public static void ResetStaticDefaultValue()
	{
		LordGymModel._Instance = null;
	}

	// Token: 0x0600DFE9 RID: 57321 RVA: 0x0041BDAE File Offset: 0x00419FAE
	static LordGymModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LordGymModel.CreateStaticDefaultValue), new Action(LordGymModel.ResetStaticDefaultValue));
	}

	// Token: 0x0600DFEA RID: 57322 RVA: 0x0041BDD0 File Offset: 0x00419FD0
	public LordGymModel()
	{
		FRotator frotator = new FRotator(0f, 0f, 0f);
		FVectorDouble fvectorDouble = new FVectorDouble(0.0, 0.0, 0.0);
		FVectorDouble fvectorDouble2 = new FVectorDouble(1.0, 1.0, 1.0);
		FVector fvector = fvectorDouble2;
		this.Third5SceneEffectTransform = new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
		base..ctor();
	}

	// Token: 0x0400806E RID: 32878
	[Nullable(2)]
	protected Dictionary<int, int> LordId2EntranceIdMap;

	// Token: 0x0400806F RID: 32879
	public List<int> UnLockLordGym = new List<int>();

	// Token: 0x04008070 RID: 32880
	public List<int> ReadLoadGymIds = new List<int>();

	// Token: 0x04008071 RID: 32881
	public List<int> FirstUnLockLordGym = new List<int>();

	// Token: 0x04008072 RID: 32882
	public int EntranceEntityId;

	// Token: 0x04008073 RID: 32883
	public int EntranceSetId;

	// Token: 0x04008074 RID: 32884
	public int EntryChallengeId;

	// Token: 0x04008075 RID: 32885
	public int LastChallengeLordEntranceId;

	// Token: 0x04008076 RID: 32886
	public int CurrentChallengeLordGymId;

	// Token: 0x04008077 RID: 32887
	public bool IsDeadInChallenge;

	// Token: 0x04008078 RID: 32888
	public int LastChallengeLordId;

	// Token: 0x04008079 RID: 32889
	public bool SkipBossSelectInFlow;

	// Token: 0x0400807A RID: 32890
	public bool LastChallengeEntryFromGuide;

	// Token: 0x0400807B RID: 32891
	public bool IsCurrentChallengeFromGuide;

	// Token: 0x0400807C RID: 32892
	public Dictionary<int, LordGymPassRecord> LordGymRecord = new Dictionary<int, LordGymPassRecord>();

	// Token: 0x0400807D RID: 32893
	public Dictionary<int, int> LordGymGroupPassDiff = new Dictionary<int, int>();

	// Token: 0x0400807E RID: 32894
	public List<global::LordGymEntranceInfo> LordGymEntranceInfo = new List<global::LordGymEntranceInfo>();

	// Token: 0x0400807F RID: 32895
	public List<int> LordGymEntrancesWithNewTag = new List<int>();

	// Token: 0x04008080 RID: 32896
	[Nullable(2)]
	public List<int> NewLordGymEntranceIdRecord;

	// Token: 0x04008081 RID: 32897
	public FTransform CacheTransform;

	// Token: 0x04008082 RID: 32898
	public FVector CacheLocation;

	// Token: 0x04008083 RID: 32899
	public FRotator CacheRotator;

	// Token: 0x04008084 RID: 32900
	public FVector CacheScale;

	// Token: 0x04008085 RID: 32901
	[Nullable(2)]
	private ALevelSequenceActor LordGymThirdBossSequenceActor;

	// Token: 0x04008086 RID: 32902
	private int Third5SceneEffectHandle;

	// Token: 0x04008087 RID: 32903
	private readonly FTransformDouble Third5SceneEffectTransform;

	// Token: 0x04008088 RID: 32904
	[Nullable(2)]
	private static LordGymModel _Instance;
}
