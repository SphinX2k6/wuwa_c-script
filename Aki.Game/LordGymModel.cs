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

// Token: 0x02002190 RID: 8592
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class LordGymModel : ModelBase
{
	// Token: 0x06010B2C RID: 68396 RVA: 0x0040E3F4 File Offset: 0x0040C5F4
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

	// Token: 0x06010B2D RID: 68397 RVA: 0x0040E47C File Offset: 0x0040C67C
	public bool GetLordGymIsUnLock(int lordId)
	{
		return this.UnLockLordGym.Contains(lordId);
	}

	// Token: 0x06010B2E RID: 68398 RVA: 0x0040E48C File Offset: 0x0040C68C
	public bool IsLordGymUnlockedByGroup(int lordId)
	{
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(lordId);
		int num;
		return lordGymConfig != null && this.LordGymGroupPassDiff.TryGetValue(lordGymConfig.Value.FilterType, out num) && lordGymConfig.Value.Difficulty <= num + 1;
	}

	// Token: 0x06010B2F RID: 68399 RVA: 0x0040E4E8 File Offset: 0x0040C6E8
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

	// Token: 0x06010B30 RID: 68400 RVA: 0x0040E558 File Offset: 0x0040C758
	public bool GetLordGymHasRead(int lordId)
	{
		return this.ReadLoadGymIds.Contains(lordId);
	}

	// Token: 0x06010B31 RID: 68401 RVA: 0x0040E566 File Offset: 0x0040C766
	public void ReadLordGym(int lordId)
	{
		this.ReadLoadGymIds.Add(lordId);
	}

	// Token: 0x06010B32 RID: 68402 RVA: 0x0040E574 File Offset: 0x0040C774
	[NullableContext(2)]
	public int[] GetLordGymEntranceList(int lordEntranceId)
	{
		return LordGymConfig.Instance.GetLordGymEntranceLordList(lordEntranceId);
	}

	// Token: 0x06010B33 RID: 68403 RVA: 0x0040E584 File Offset: 0x0040C784
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

	// Token: 0x06010B34 RID: 68404 RVA: 0x0040E62C File Offset: 0x0040C82C
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

	// Token: 0x06010B35 RID: 68405 RVA: 0x0040E6D4 File Offset: 0x0040C8D4
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

	// Token: 0x06010B36 RID: 68406 RVA: 0x0040E7B4 File Offset: 0x0040C9B4
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

	// Token: 0x06010B37 RID: 68407 RVA: 0x0040E810 File Offset: 0x0040CA10
	public int GetEntranceIdByLordId(int lordId)
	{
		int result;
		if (this.LordId2EntranceIdMap != null && this.LordId2EntranceIdMap.TryGetValue(lordId, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x06010B38 RID: 68408 RVA: 0x0040E838 File Offset: 0x0040CA38
	[NullableContext(2)]
	public string GetLordGymEntranceFinish(int gymEntranceId)
	{
		int? gymCanFightMaxLevelWithoutLockCondition = this.GetGymCanFightMaxLevelWithoutLockCondition(gymEntranceId);
		string str = this.GetHasFinishLord(gymEntranceId).ToString();
		string str2 = "/";
		int? num = gymCanFightMaxLevelWithoutLockCondition;
		return str + str2 + num.ToString();
	}

	// Token: 0x06010B39 RID: 68409 RVA: 0x0040E878 File Offset: 0x0040CA78
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

	// Token: 0x06010B3A RID: 68410 RVA: 0x0040E8D8 File Offset: 0x0040CAD8
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

	// Token: 0x06010B3B RID: 68411 RVA: 0x0040E974 File Offset: 0x0040CB74
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

	// Token: 0x06010B3C RID: 68412 RVA: 0x0040EA30 File Offset: 0x0040CC30
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

	// Token: 0x06010B3D RID: 68413 RVA: 0x0040EACC File Offset: 0x0040CCCC
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

	// Token: 0x06010B3E RID: 68414 RVA: 0x0040EB20 File Offset: 0x0040CD20
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

	// Token: 0x06010B3F RID: 68415 RVA: 0x0040EBD0 File Offset: 0x0040CDD0
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

	// Token: 0x06010B40 RID: 68416 RVA: 0x0040EC74 File Offset: 0x0040CE74
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

	// Token: 0x06010B41 RID: 68417 RVA: 0x0040EDDC File Offset: 0x0040CFDC
	public bool IsChallenging()
	{
		return this.CurrentChallengeLordGymId > 0;
	}

	// Token: 0x06010B42 RID: 68418 RVA: 0x0040EDE7 File Offset: 0x0040CFE7
	public void InitNewLordGymEntranceIdRecord()
	{
		this.NewLordGymEntranceIdRecord = (LocalStorage.GetPlayer<List<int>>(ELocalStoragePlayerKey.NewLordGymEntranceIdRecord, null) ?? new List<int>());
	}

	// Token: 0x06010B43 RID: 68419 RVA: 0x0040EE00 File Offset: 0x0040D000
	public void RecordNewLordGymEntrance(int entranceId)
	{
		if (this.NewLordGymEntranceIdRecord == null || this.IsNewLordGymEntranceRecord(entranceId))
		{
			return;
		}
		this.NewLordGymEntranceIdRecord.Add(entranceId);
		LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.NewLordGymEntranceIdRecord, this.NewLordGymEntranceIdRecord);
	}

	// Token: 0x06010B44 RID: 68420 RVA: 0x0040EE2E File Offset: 0x0040D02E
	public bool IsNewLordGymEntranceRecord(int entranceId)
	{
		List<int> newLordGymEntranceIdRecord = this.NewLordGymEntranceIdRecord;
		return newLordGymEntranceIdRecord != null && newLordGymEntranceIdRecord.Contains(entranceId);
	}

	// Token: 0x06010B45 RID: 68421 RVA: 0x0040EE44 File Offset: 0x0040D044
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

	// Token: 0x06010B46 RID: 68422 RVA: 0x0040EEB4 File Offset: 0x0040D0B4
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

	// Token: 0x06010B47 RID: 68423 RVA: 0x0040EF40 File Offset: 0x0040D140
	[NullableContext(2)]
	public ALevelSequenceActor GetLordGymThirdBossSequenceActor()
	{
		return this.LordGymThirdBossSequenceActor;
	}

	// Token: 0x06010B48 RID: 68424 RVA: 0x0040EF48 File Offset: 0x0040D148
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

	// Token: 0x06010B49 RID: 68425 RVA: 0x0040EF88 File Offset: 0x0040D188
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
			FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams(fframeTime2, 0f, "", EMovieScenePositionType.Frame, EUpdatePositionMethod.Play);
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

	// Token: 0x06010B4A RID: 68426 RVA: 0x0040F0D8 File Offset: 0x0040D2D8
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

	// Token: 0x06010B4B RID: 68427 RVA: 0x0040F124 File Offset: 0x0040D324
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

	// Token: 0x06010B4C RID: 68428 RVA: 0x0040F170 File Offset: 0x0040D370
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

	// Token: 0x06010B4D RID: 68429 RVA: 0x0040F1C8 File Offset: 0x0040D3C8
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

	// Token: 0x06010B4E RID: 68430 RVA: 0x0040F238 File Offset: 0x0040D438
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

	// Token: 0x06010B4F RID: 68431 RVA: 0x0040F2F4 File Offset: 0x0040D4F4
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

	// Token: 0x06010B50 RID: 68432 RVA: 0x0040F34C File Offset: 0x0040D54C
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

	// Token: 0x06010B51 RID: 68433 RVA: 0x0040F3DC File Offset: 0x0040D5DC
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

	// Token: 0x06010B52 RID: 68434 RVA: 0x0040F434 File Offset: 0x0040D634
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

	// Token: 0x1700152B RID: 5419
	// (get) Token: 0x06010B53 RID: 68435 RVA: 0x0040F48B File Offset: 0x0040D68B
	public static LordGymModel Instance
	{
		get
		{
			return LordGymModel._Instance;
		}
	}

	// Token: 0x06010B54 RID: 68436 RVA: 0x0040F492 File Offset: 0x0040D692
	public static LordGymModel GetOrCreateInstance()
	{
		if (LordGymModel._Instance == null)
		{
			LordGymModel.CreateInstance();
		}
		return LordGymModel._Instance;
	}

	// Token: 0x06010B55 RID: 68437 RVA: 0x0040F4A6 File Offset: 0x0040D6A6
	public static bool CreateInstance()
	{
		if (LordGymModel._Instance != null)
		{
			return true;
		}
		LordGymModel._Instance = new LordGymModel();
		return true;
	}

	// Token: 0x06010B56 RID: 68438 RVA: 0x0040F4BC File Offset: 0x0040D6BC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010B57 RID: 68439 RVA: 0x0040F4BE File Offset: 0x0040D6BE
	public static void ResetStaticDefaultValue()
	{
		LordGymModel._Instance = null;
	}

	// Token: 0x06010B58 RID: 68440 RVA: 0x0040F4C6 File Offset: 0x0040D6C6
	static LordGymModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LordGymModel.CreateStaticDefaultValue), new Action(LordGymModel.ResetStaticDefaultValue));
	}

	// Token: 0x06010B59 RID: 68441 RVA: 0x0040F4E8 File Offset: 0x0040D6E8
	public LordGymModel()
	{
		FRotator frotator = new FRotator(0f, 0f, 0f);
		FVectorDouble fvectorDouble = new FVectorDouble(0.0, 0.0, 0.0);
		FVectorDouble fvectorDouble2 = new FVectorDouble(1.0, 1.0, 1.0);
		FVector fvector = fvectorDouble2;
		this.Third5SceneEffectTransform = new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
		base..ctor();
	}

	// Token: 0x04007F27 RID: 32551
	[Nullable(2)]
	protected Dictionary<int, int> LordId2EntranceIdMap;

	// Token: 0x04007F28 RID: 32552
	public List<int> UnLockLordGym = new List<int>();

	// Token: 0x04007F29 RID: 32553
	public List<int> ReadLoadGymIds = new List<int>();

	// Token: 0x04007F2A RID: 32554
	public List<int> FirstUnLockLordGym = new List<int>();

	// Token: 0x04007F2B RID: 32555
	public int EntranceEntityId;

	// Token: 0x04007F2C RID: 32556
	public int EntranceSetId;

	// Token: 0x04007F2D RID: 32557
	public int EntryChallengeId;

	// Token: 0x04007F2E RID: 32558
	public int LastChallengeLordEntranceId;

	// Token: 0x04007F2F RID: 32559
	public int CurrentChallengeLordGymId;

	// Token: 0x04007F30 RID: 32560
	public bool IsDeadInChallenge;

	// Token: 0x04007F31 RID: 32561
	public int LastChallengeLordId;

	// Token: 0x04007F32 RID: 32562
	public bool SkipBossSelectInFlow;

	// Token: 0x04007F33 RID: 32563
	public bool LastChallengeEntryFromGuide;

	// Token: 0x04007F34 RID: 32564
	public bool IsCurrentChallengeFromGuide;

	// Token: 0x04007F35 RID: 32565
	public Dictionary<int, LordGymPassRecord> LordGymRecord = new Dictionary<int, LordGymPassRecord>();

	// Token: 0x04007F36 RID: 32566
	public Dictionary<int, int> LordGymGroupPassDiff = new Dictionary<int, int>();

	// Token: 0x04007F37 RID: 32567
	public List<global::LordGymEntranceInfo> LordGymEntranceInfo = new List<global::LordGymEntranceInfo>();

	// Token: 0x04007F38 RID: 32568
	public List<int> LordGymEntrancesWithNewTag = new List<int>();

	// Token: 0x04007F39 RID: 32569
	[Nullable(2)]
	public List<int> NewLordGymEntranceIdRecord;

	// Token: 0x04007F3A RID: 32570
	public FTransform CacheTransform;

	// Token: 0x04007F3B RID: 32571
	public FVector CacheLocation;

	// Token: 0x04007F3C RID: 32572
	public FRotator CacheRotator;

	// Token: 0x04007F3D RID: 32573
	public FVector CacheScale;

	// Token: 0x04007F3E RID: 32574
	[Nullable(2)]
	private ALevelSequenceActor LordGymThirdBossSequenceActor;

	// Token: 0x04007F3F RID: 32575
	private int Third5SceneEffectHandle;

	// Token: 0x04007F40 RID: 32576
	private readonly FTransformDouble Third5SceneEffectTransform;

	// Token: 0x04007F41 RID: 32577
	[Nullable(2)]
	private static LordGymModel _Instance;
}
