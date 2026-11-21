using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.World.Define;
using UnrealEngine;

// Token: 0x02002384 RID: 9092
[NullableContext(2)]
[Nullable(0)]
public class AnimalPerformBornState : AnimalPerformStateBase
{
	// Token: 0x0601670B RID: 91915 RVA: 0x0068FF7D File Offset: 0x0068E17D
	[NullableContext(1)]
	public AnimalPerformBornState(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x0601670C RID: 91916 RVA: 0x0068FF88 File Offset: 0x0068E188
	protected override void OnStart()
	{
		Entity owner = this.Owner;
		this.PerformComp = ((owner != null) ? owner.GetComponent<BasePerformComponent>() : null);
		Entity owner2 = this.Owner;
		this.TagComp = ((owner2 != null) ? owner2.GetComponent<BaseTagComponent>() : null);
		Entity owner3 = this.Owner;
		this.AnimComp = ((owner3 != null) ? owner3.GetComponent<CharacterAnimationComponent>() : null);
		Entity owner4 = this.Owner;
		this.CreatureData = ((owner4 != null) ? owner4.GetComponent<CreatureDataComponent>() : null);
		if (!this.PerformComp || !this.TagComp)
		{
			return;
		}
		this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.出生表现"]));
		this.InitBornMontageInfo();
		if (this.BornMontageInfo == null)
		{
			this.FinishBornPerformance();
		}
	}

	// Token: 0x0601670D RID: 91917 RVA: 0x00690044 File Offset: 0x0068E244
	protected override void OnExit(EAnimalPerformState nextState)
	{
		this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.交互.站起"]));
		this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.出生表现"]));
		this.AbortBornMontage();
	}

	// Token: 0x0601670E RID: 91918 RVA: 0x00690098 File Offset: 0x0068E298
	protected void InitBornMontageInfo()
	{
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp == null || !tagComp.HasTag(GameplayTagDefine.EGameplayTagId["动物.Common.状态标识.休闲"]))
		{
			return;
		}
		CreatureDataComponent creatureData = this.CreatureData;
		string text;
		if (creatureData == null)
		{
			text = null;
		}
		else
		{
			SModelConfig modelConfig = creatureData.GetModelConfig();
			text = ((modelConfig != null) ? modelConfig.蓝图.ToAssetPathName() : null);
		}
		string text2 = text;
		if (text2 == null || text2.Length < 2)
		{
			return;
		}
		string bpPath = text2.Substring(0, text2.Length - 2);
		List<AnimalStandbyMontage> animalStandbyMontageData = AnimalStandbyMontageConfig.Instance.GetAnimalStandbyMontageData(bpPath);
		if (animalStandbyMontageData == null || animalStandbyMontageData.Count == 0)
		{
			return;
		}
		foreach (AnimalStandbyMontage config in animalStandbyMontageData)
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName(config.Tag);
			BaseTagComponent tagComp2 = this.TagComp;
			if (tagComp2 != null && tagComp2.HasTag(tagIdByName))
			{
				AnimalBornMontageInfo animalBornMontageInfo = new AnimalBornMontageInfo();
				animalBornMontageInfo.Init(config);
				if (animalBornMontageInfo.IsConfigValid())
				{
					this.BornMontageInfo = animalBornMontageInfo;
					break;
				}
				break;
			}
		}
		if (this.BornMontageInfo == null)
		{
			return;
		}
		this.TryLoadBornMontageAsset(this.BornMontageInfo.StartPath, AnimalPerformBornState.EAnimalBornMontagePhase.Start);
		this.TryLoadBornMontageAsset(this.BornMontageInfo.LoopPath, AnimalPerformBornState.EAnimalBornMontagePhase.Loop);
		this.TryLoadBornMontageAsset(this.BornMontageInfo.EndPath, AnimalPerformBornState.EAnimalBornMontagePhase.End);
		this.TryLoadBornBranchMontageAssets(this.BornMontageInfo.BranchPathList);
	}

	// Token: 0x0601670F RID: 91919 RVA: 0x006901F8 File Offset: 0x0068E3F8
	protected void TryLoadBornMontageAsset(string path, AnimalPerformBornState.EAnimalBornMontagePhase phase)
	{
		if (path2 == null || path2 == "" || path2 == "None")
		{
			this.MarkAssetLoadedComplete(null, phase);
			this.WaitAssetLoadedComplete();
			return;
		}
		ResourceSystem.Instance.LoadAsync<UAnimMontage>(path2, delegate([Nullable(2)] UAnimMontage asset, string path)
		{
			this.MarkAssetLoadedComplete(asset, phase);
			this.WaitAssetLoadedComplete();
		}, 100, "js_undefined");
	}

	// Token: 0x06016710 RID: 91920 RVA: 0x0069026C File Offset: 0x0068E46C
	[NullableContext(1)]
	protected void TryLoadBornBranchMontageAssets(List<string> paths)
	{
		if (paths.Count == 0)
		{
			return;
		}
		Action<UAnimMontage, string> <>9__0;
		foreach (string text in paths)
		{
			if (text == "" || text == "None")
			{
				this.BornMontageInfo.BranchLoadedCount++;
				if (this.BornMontageInfo.BranchLoadedCount == paths.Count)
				{
					this.MarkAssetLoadedComplete(null, AnimalPerformBornState.EAnimalBornMontagePhase.Branch);
					this.WaitAssetLoadedComplete();
				}
			}
			else
			{
				ResourceSystem instance = ResourceSystem.Instance;
				string path2 = text;
				Action<UAnimMontage, string> callback;
				if ((callback = <>9__0) == null)
				{
					callback = (<>9__0 = delegate([Nullable(2)] UAnimMontage asset, string path)
					{
						if (this.BornMontageInfo == null)
						{
							return;
						}
						this.BornMontageInfo.BranchLoadedCount++;
						if (asset != null && asset.IsValid())
						{
							this.BornMontageInfo.BranchList.Add(asset);
						}
						if (this.BornMontageInfo.BranchLoadedCount == paths.Count)
						{
							this.MarkAssetLoadedComplete(asset, AnimalPerformBornState.EAnimalBornMontagePhase.Branch);
							this.WaitAssetLoadedComplete();
						}
					});
				}
				instance.LoadAsync<UAnimMontage>(path2, callback, 100, "js_undefined");
			}
		}
	}

	// Token: 0x06016711 RID: 91921 RVA: 0x00690368 File Offset: 0x0068E568
	protected void MarkAssetLoadedComplete(UAnimMontage asset, AnimalPerformBornState.EAnimalBornMontagePhase phase)
	{
		switch (phase)
		{
		case AnimalPerformBornState.EAnimalBornMontagePhase.Start:
			this.BornMontageInfo.Start = asset;
			this.BornMontageInfo.StartReady = true;
			return;
		case AnimalPerformBornState.EAnimalBornMontagePhase.Loop:
			this.BornMontageInfo.Loop = asset;
			this.BornMontageInfo.LoopReady = true;
			return;
		case AnimalPerformBornState.EAnimalBornMontagePhase.Branch:
			this.BornMontageInfo.BranchReady = true;
			return;
		case AnimalPerformBornState.EAnimalBornMontagePhase.End:
			this.BornMontageInfo.End = asset;
			this.BornMontageInfo.EndReady = true;
			return;
		default:
			return;
		}
	}

	// Token: 0x06016712 RID: 91922 RVA: 0x006903E5 File Offset: 0x0068E5E5
	protected void WaitAssetLoadedComplete()
	{
		AnimalBornMontageInfo bornMontageInfo = this.BornMontageInfo;
		if (bornMontageInfo == null || !bornMontageInfo.IsAssetReady())
		{
			return;
		}
		if (this.TryPlayBornMontageStart())
		{
			return;
		}
		if (this.TryPlayBornMontageLoop())
		{
			return;
		}
		this.FinishBornPerformance();
	}

	// Token: 0x06016713 RID: 91923 RVA: 0x00690418 File Offset: 0x0068E618
	protected bool TryPlayBornMontageStart()
	{
		if (this.BornMontagePhase == AnimalPerformBornState.EAnimalBornMontagePhase.Finish)
		{
			return false;
		}
		if (this.BornMontagePhase == AnimalPerformBornState.EAnimalBornMontagePhase.End)
		{
			return false;
		}
		AnimalBornMontageInfo bornMontageInfo = this.BornMontageInfo;
		bool flag;
		if (bornMontageInfo == null)
		{
			flag = true;
		}
		else
		{
			UAnimMontage start = bornMontageInfo.Start;
			flag = !((start != null) ? new bool?(start.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			return false;
		}
		this.BornMontagePhase = AnimalPerformBornState.EAnimalBornMontagePhase.Start;
		this.PlayBornMontage(this.BornMontageInfo.Start, 0f, new Action<UAnimMontage, bool>(this.OnStartSectionFinished));
		return true;
	}

	// Token: 0x06016714 RID: 91924 RVA: 0x006904A0 File Offset: 0x0068E6A0
	protected bool TryPlayBornMontageLoop()
	{
		if (this.BornMontagePhase == AnimalPerformBornState.EAnimalBornMontagePhase.Finish)
		{
			return false;
		}
		if (this.BornMontagePhase == AnimalPerformBornState.EAnimalBornMontagePhase.End)
		{
			return false;
		}
		AnimalBornMontageInfo bornMontageInfo = this.BornMontageInfo;
		bool flag;
		if (bornMontageInfo == null)
		{
			flag = true;
		}
		else
		{
			UAnimMontage loop = bornMontageInfo.Loop;
			flag = !((loop != null) ? new bool?(loop.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			return false;
		}
		this.BornMontagePhase = AnimalPerformBornState.EAnimalBornMontagePhase.Loop;
		AnimalBornMontageInfo bornMontageInfo2 = this.BornMontageInfo;
		if (bornMontageInfo2 != null && bornMontageInfo2.BranchList.Count == 0)
		{
			this.PlayBornMontage(this.BornMontageInfo.Loop, -1f, new Action<UAnimMontage, bool>(this.OnLoopSectionFinished));
		}
		else
		{
			int num = 15;
			float sequenceLength = this.BornMontageInfo.Loop.SequenceLength;
			float playTime = (float)Math.Min(1.0, Math.Floor((double)((float)num / sequenceLength))) * sequenceLength;
			this.PlayBornMontage(this.BornMontageInfo.Loop, playTime, new Action<UAnimMontage, bool>(this.OnLoopSectionFinished));
		}
		return true;
	}

	// Token: 0x06016715 RID: 91925 RVA: 0x00690594 File Offset: 0x0068E794
	protected bool TryPlayBornMontageBranch()
	{
		if (this.BornMontagePhase == AnimalPerformBornState.EAnimalBornMontagePhase.Finish)
		{
			return false;
		}
		if (this.BornMontagePhase == AnimalPerformBornState.EAnimalBornMontagePhase.End)
		{
			return false;
		}
		if (this.BornMontageInfo == null || this.BornMontageInfo.BranchList.Count == 0)
		{
			return false;
		}
		int count = this.BornMontageInfo.BranchList.Count;
		int index = (int)Math.Floor(MathUtils.Instance.GetRandomRange(0.0, (double)count));
		this.BornMontageInfo.Branch = this.BornMontageInfo.BranchList[index];
		AnimalBornMontageInfo bornMontageInfo = this.BornMontageInfo;
		bool flag;
		if (bornMontageInfo == null)
		{
			flag = true;
		}
		else
		{
			UAnimMontage branch = bornMontageInfo.Branch;
			flag = !((branch != null) ? new bool?(branch.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			return false;
		}
		this.BornMontagePhase = AnimalPerformBornState.EAnimalBornMontagePhase.Branch;
		this.PlayBornMontage(this.BornMontageInfo.Branch, 0f, new Action<UAnimMontage, bool>(this.OnBranchSectionFinished));
		return true;
	}

	// Token: 0x06016716 RID: 91926 RVA: 0x00690680 File Offset: 0x0068E880
	[NullableContext(1)]
	protected bool TryPlayBornMontageEnd(Action callback)
	{
		if (this.BornMontagePhase == AnimalPerformBornState.EAnimalBornMontagePhase.Finish)
		{
			return false;
		}
		if (this.BornMontagePhase == AnimalPerformBornState.EAnimalBornMontagePhase.End)
		{
			return false;
		}
		this.BornEndMontageCallback = callback;
		AnimalBornMontageInfo bornMontageInfo = this.BornMontageInfo;
		bool flag;
		if (bornMontageInfo == null)
		{
			flag = true;
		}
		else
		{
			UAnimMontage end = bornMontageInfo.End;
			flag = !((end != null) ? new bool?(end.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			AnimalBornMontageInfo bornMontageInfo2 = this.BornMontageInfo;
			this.OnEndSectionFinished((bornMontageInfo2 != null) ? bornMontageInfo2.End : null, false);
			return false;
		}
		this.BornMontagePhase = AnimalPerformBornState.EAnimalBornMontagePhase.End;
		this.PlayBornMontage(this.BornMontageInfo.End, 0f, new Action<UAnimMontage, bool>(this.OnEndSectionFinished));
		return true;
	}

	// Token: 0x06016717 RID: 91927 RVA: 0x00690728 File Offset: 0x0068E928
	[NullableContext(1)]
	public void InterruptBornPerformance(Action callback)
	{
		if (this.TryPlayBornMontageEnd(callback))
		{
			return;
		}
		if (this.AbortBornMontage())
		{
			TimerSystem.Instance.Delay(delegate(float _)
			{
				callback();
			}, 500f, null, null, true, 1f);
			return;
		}
		callback();
	}

	// Token: 0x06016718 RID: 91928 RVA: 0x0069078C File Offset: 0x0068E98C
	protected void FinishBornPerformance()
	{
		EAnimalPerformState? currentState = this.StateMachine.CurrentState;
		EAnimalPerformState eanimalPerformState = EAnimalPerformState.Born;
		if (!(currentState.GetValueOrDefault() == eanimalPerformState & currentState != null))
		{
			return;
		}
		this.AbortBornMontage();
		this.BornMontagePhase = AnimalPerformBornState.EAnimalBornMontagePhase.Finish;
		this.StateMachine.Switch(EAnimalPerformState.Stand);
		base.AnimalEcologicalInterface.StateMachineInitializationComplete();
	}

	// Token: 0x06016719 RID: 91929 RVA: 0x006907E4 File Offset: 0x0068E9E4
	protected bool AbortBornMontage()
	{
		if (this.BornMontageInfo == null)
		{
			return false;
		}
		if (this.BornMontagePhase == AnimalPerformBornState.EAnimalBornMontagePhase.Finish)
		{
			return false;
		}
		UAnimMontage uanimMontage = null;
		switch (this.BornMontagePhase)
		{
		case AnimalPerformBornState.EAnimalBornMontagePhase.Start:
			uanimMontage = this.BornMontageInfo.Start;
			break;
		case AnimalPerformBornState.EAnimalBornMontagePhase.Loop:
			uanimMontage = this.BornMontageInfo.Loop;
			break;
		case AnimalPerformBornState.EAnimalBornMontagePhase.Branch:
			uanimMontage = this.BornMontageInfo.Branch;
			break;
		case AnimalPerformBornState.EAnimalBornMontagePhase.End:
			uanimMontage = this.BornMontageInfo.End;
			break;
		}
		this.BornMontagePhase = AnimalPerformBornState.EAnimalBornMontagePhase.Finish;
		if (uanimMontage == null || !uanimMontage.IsValid())
		{
			return false;
		}
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null)
		{
			UAnimInstance mainAnimInstance = animComp.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.Montage_Stop(0.5f, uanimMontage);
			}
		}
		return true;
	}

	// Token: 0x0601671A RID: 91930 RVA: 0x0069089C File Offset: 0x0068EA9C
	protected void OnStartSectionFinished(UAnimMontage montage, bool bInterrupted)
	{
		if (this.BornMontageInfo == null || this.BornMontageInfo.Start != montage)
		{
			return;
		}
		BasePerformComponent performComp = this.PerformComp;
		if (performComp == null || !performComp.Valid)
		{
			return;
		}
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null)
		{
			UAnimInstance mainAnimInstance = animComp.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.OnMontageEnded.Remove(new Action<UAnimMontage, bool>(this.OnStartSectionFinished));
			}
		}
		if (this.BornMontagePhase != AnimalPerformBornState.EAnimalBornMontagePhase.Start)
		{
			return;
		}
		if (this.TimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
		}
		this.TimerHandle = null;
		if (!this.TryPlayBornMontageLoop())
		{
			this.FinishBornPerformance();
		}
	}

	// Token: 0x0601671B RID: 91931 RVA: 0x00690940 File Offset: 0x0068EB40
	protected void OnLoopSectionFinished(UAnimMontage montage, bool bInterrupted)
	{
		if (this.BornMontageInfo == null || this.BornMontageInfo.Loop != montage)
		{
			return;
		}
		BasePerformComponent performComp = this.PerformComp;
		if (performComp == null || !performComp.Valid)
		{
			return;
		}
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null)
		{
			UAnimInstance mainAnimInstance = animComp.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.OnMontageEnded.Remove(new Action<UAnimMontage, bool>(this.OnLoopSectionFinished));
			}
		}
		if (this.BornMontagePhase != AnimalPerformBornState.EAnimalBornMontagePhase.Loop)
		{
			return;
		}
		if (this.TimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
		}
		this.TimerHandle = null;
		if (!this.TryPlayBornMontageBranch())
		{
			this.FinishBornPerformance();
		}
	}

	// Token: 0x0601671C RID: 91932 RVA: 0x006909E4 File Offset: 0x0068EBE4
	protected void OnBranchSectionFinished(UAnimMontage montage, bool bInterrupted)
	{
		if (this.BornMontageInfo == null || this.BornMontageInfo.Branch != montage)
		{
			return;
		}
		BasePerformComponent performComp = this.PerformComp;
		if (performComp == null || !performComp.Valid)
		{
			return;
		}
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null)
		{
			UAnimInstance mainAnimInstance = animComp.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.OnMontageEnded.Remove(new Action<UAnimMontage, bool>(this.OnBranchSectionFinished));
			}
		}
		if (this.BornMontagePhase != AnimalPerformBornState.EAnimalBornMontagePhase.Branch)
		{
			return;
		}
		if (this.TimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
		}
		this.TimerHandle = null;
		if (!this.TryPlayBornMontageLoop())
		{
			this.FinishBornPerformance();
		}
	}

	// Token: 0x0601671D RID: 91933 RVA: 0x00690A88 File Offset: 0x0068EC88
	protected void OnEndSectionFinished(UAnimMontage montage, bool bInterrupted)
	{
		if (this.BornMontageInfo == null || this.BornMontageInfo.End != montage)
		{
			return;
		}
		Action bornEndMontageCallback = this.BornEndMontageCallback;
		if (bornEndMontageCallback != null)
		{
			bornEndMontageCallback();
		}
		BasePerformComponent performComp = this.PerformComp;
		if (performComp == null || !performComp.Valid)
		{
			return;
		}
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null)
		{
			UAnimInstance mainAnimInstance = animComp.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.OnMontageEnded.Remove(new Action<UAnimMontage, bool>(this.OnEndSectionFinished));
			}
		}
		if (this.BornMontagePhase != AnimalPerformBornState.EAnimalBornMontagePhase.End)
		{
			return;
		}
		if (this.TimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
		}
		this.TimerHandle = null;
		this.FinishBornPerformance();
	}

	// Token: 0x0601671E RID: 91934 RVA: 0x00690B34 File Offset: 0x0068ED34
	[NullableContext(1)]
	protected void PlayBornMontage(UAnimMontage montage, float playTime, [Nullable(new byte[]
	{
		1,
		2
	})] Action<UAnimMontage, bool> callback)
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null)
		{
			UAnimInstance mainAnimInstance = animComp.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.Montage_Play(montage, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
			}
		}
		CharacterAnimationComponent animComp2 = this.AnimComp;
		if (animComp2 != null)
		{
			UAnimInstance mainAnimInstance2 = animComp2.MainAnimInstance;
			if (mainAnimInstance2 != null)
			{
				mainAnimInstance2.OnMontageEnded.Add(callback);
			}
		}
		CharacterAnimationComponent animComp3 = this.AnimComp;
		if (animComp3 != null)
		{
			UAnimInstance mainAnimInstance3 = animComp3.MainAnimInstance;
			if (mainAnimInstance3 != null)
			{
				mainAnimInstance3.Montage_SetNextSection(CharacterNameDefines.Instance.DEFAULT_SECTION_NAME, CharacterNameDefines.Instance.DEFAULT_SECTION_NAME, montage);
			}
		}
		if (this.TimerHandle != null)
		{
			TimerSystem.Instance.Remove(this.TimerHandle);
		}
		this.TimerHandle = null;
		if (playTime != -1f)
		{
			float num = (playTime != 0f) ? playTime : montage.SequenceLength;
			float num2 = (num < 0.5f) ? num : (num - 0.5f);
			this.TimerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				callback(montage, false);
			}, num2 * 1000f, null, null, true, 1f);
		}
	}

	// Token: 0x0400BE5B RID: 48731
	private const float DEFAULT_BLEND_OUT_TIME = 0.5f;

	// Token: 0x0400BE5C RID: 48732
	protected BasePerformComponent PerformComp;

	// Token: 0x0400BE5D RID: 48733
	protected BaseTagComponent TagComp;

	// Token: 0x0400BE5E RID: 48734
	protected CharacterAnimationComponent AnimComp;

	// Token: 0x0400BE5F RID: 48735
	protected CreatureDataComponent CreatureData;

	// Token: 0x0400BE60 RID: 48736
	protected AnimalBornMontageInfo BornMontageInfo;

	// Token: 0x0400BE61 RID: 48737
	protected AnimalPerformBornState.EAnimalBornMontagePhase BornMontagePhase;

	// Token: 0x0400BE62 RID: 48738
	protected TimerHandle TimerHandle;

	// Token: 0x0400BE63 RID: 48739
	protected Action BornEndMontageCallback;

	// Token: 0x02008571 RID: 34161
	[NullableContext(0)]
	protected enum EAnimalBornMontagePhase
	{
		// Token: 0x0402AFBC RID: 176060
		None,
		// Token: 0x0402AFBD RID: 176061
		Start,
		// Token: 0x0402AFBE RID: 176062
		Loop,
		// Token: 0x0402AFBF RID: 176063
		Branch,
		// Token: 0x0402AFC0 RID: 176064
		End,
		// Token: 0x0402AFC1 RID: 176065
		Finish
	}
}
