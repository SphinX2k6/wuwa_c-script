using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A34 RID: 6708
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssEntranceView : UiTickViewBase, IUiCameraBehavior
{
	// Token: 0x0600C53D RID: 50493 RVA: 0x002CBE3B File Offset: 0x002CA03B
	public DangoAbyssEntranceView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C53E RID: 50494 RVA: 0x002CBE44 File Offset: 0x002CA044
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnAbyssInsEntranceBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnWorldEntranceBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C53F RID: 50495 RVA: 0x002CC05C File Offset: 0x002CA25C
	public override bool GetLoopAudioEventSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x0600C540 RID: 50496 RVA: 0x002CC06C File Offset: 0x002CA26C
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssEntranceView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssEntranceView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C541 RID: 50497 RVA: 0x002CC0B0 File Offset: 0x002CA2B0
	private void OnCloseBtnClick()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		IReadOnlyList<int> smallWorldInsIdList = DangoAbyssConfig.Instance.GetSmallWorldInsIdList();
		if (!((smallWorldInsIdList != null) ? new bool?(smallWorldInsIdList.Contains(instanceId)) : null).GetValueOrDefault())
		{
			base.CloseMe(null);
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DangoQuitWorld);
		confirmBoxDataNew.FunctionMap.Add(2, new Action(DangoAbyssEntranceView.<OnCloseBtnClick>g__callBack|15_0));
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600C542 RID: 50498 RVA: 0x002CC130 File Offset: 0x002CA330
	public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
	{
		UiCameraAnimationController.Instance.PushCameraHandle((EUiViewName)"DangoAbyssStart", new int?(viewId), isBlend);
		UiCameraAnimationManager.Instance.PushCameraHandleByHandleName("DangoAbyssLoop", true, true, "1001", false, null, null);
	}

	// Token: 0x0600C543 RID: 50499 RVA: 0x002CC17A File Offset: 0x002CA37A
	[NullableContext(2)]
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
	{
		UiCameraAnimationController.Instance.PopCameraHandle((EUiViewName)"DangoAbyssStart", stackTopInfo, closeViewId, popOrDelete);
	}

	// Token: 0x0600C544 RID: 50500 RVA: 0x002CC194 File Offset: 0x002CA394
	protected override void OnHandleLoadScene()
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("Ani_Tuanzi_Start0");
		this.PlaySceneLevelSequence(resourcePath, false, delegate
		{
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("Ani_Tuanzi_Loop");
			this.PlaySceneLevelSequence(resourcePath2, true, null);
		});
	}

	// Token: 0x0600C545 RID: 50501 RVA: 0x002CC1C8 File Offset: 0x002CA3C8
	private void OnWorldEntranceBtnClick()
	{
		if (DangoAbyssModel.Instance.CheckIfInSmallWorldInstance())
		{
			base.CloseMe(null);
			return;
		}
		if (GameModeController.Instance.IsInInstance())
		{
			base.CloseMe(null);
			return;
		}
		int? teleportId = DangoAbyssConfig.Instance.GetWorldTeleportId();
		if (teleportId != null)
		{
			int? teleportId2 = teleportId;
			int num = 0;
			if (!(teleportId2.GetValueOrDefault() == num & teleportId2 != null))
			{
				if (QuestNewModel.Instance.IsInFocusMode())
				{
					ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CloseFocusQuestTips);
					confirmBoxDataNew.FunctionMap.Add(2, delegate
					{
						TeleportMisc.SendTeleportTransferRequest(teleportId.Value);
					});
					ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
					return;
				}
				TeleportMisc.SendTeleportTransferRequest(teleportId.Value);
				return;
			}
		}
	}

	// Token: 0x0600C546 RID: 50502 RVA: 0x002CC28C File Offset: 0x002CA48C
	private void OnAbyssInsEntranceBtnClick()
	{
		int activityId = this.CurrentData.ActivityId;
		DangoAbyssController.Instance.OpenAbyssSelectViewByActivityId(activityId);
	}

	// Token: 0x0600C547 RID: 50503 RVA: 0x002CC2B0 File Offset: 0x002CA4B0
	protected override void OnBeforeShow()
	{
		this.PushCameraHandle((EUiViewName)"DangoAbyssLoop", base.GetViewId(), true);
		DangoAbyssActivityData activityData = this.GetActivityData();
		this.RefreshSceneNiagaraByCurrentChallenge(activityData);
		this.RefreshView();
		this.RefreshRedDot();
		this.RefreshDangaoShowState(activityData);
		this.RefreshBtns();
	}

	// Token: 0x0600C548 RID: 50504 RVA: 0x002CC2FC File Offset: 0x002CA4FC
	private void RefreshBtns()
	{
		bool dangoUpAvailable = DangoAbyssModel.Instance.GetDangoUpAvailable();
		this.DangoUpItem.SetUiActive(dangoUpAvailable);
		bool shopAvailable = DangoAbyssModel.Instance.GetShopAvailable();
		this.ShopItem.SetUiActive(shopAvailable);
	}

	// Token: 0x0600C549 RID: 50505 RVA: 0x002CC338 File Offset: 0x002CA538
	public void RefreshRedDot()
	{
		AbyssButtonItem limitRewadItem = this.LimitRewadItem;
		if (limitRewadItem != null)
		{
			ERedDotName redDotName = ERedDotName.RedDotDangoLimitReward;
			DangoAbyssEntraceViewData currentData = this.CurrentData;
			limitRewadItem.BindRedDot(redDotName, (currentData != null) ? new int?(currentData.ActivityId) : null);
		}
		AbyssButtonItem activityRewardItem = this.ActivityRewardItem;
		if (activityRewardItem != null)
		{
			ERedDotName redDotName2 = ERedDotName.RedDotDangoCommonReward;
			DangoAbyssEntraceViewData currentData2 = this.CurrentData;
			activityRewardItem.BindRedDot(redDotName2, (currentData2 != null) ? new int?(currentData2.ActivityId) : null);
		}
		AbyssButtonItem shopItem = this.ShopItem;
		if (shopItem != null)
		{
			shopItem.BindRedDot(ERedDotName.RedDotDangoPayShop, null);
		}
		AbyssButtonItem dangoUpItem = this.DangoUpItem;
		if (dangoUpItem == null)
		{
			return;
		}
		dangoUpItem.BindRedDot(ERedDotName.RedDotDangoDevelop, null);
	}

	// Token: 0x0600C54A RID: 50506 RVA: 0x002CC3EC File Offset: 0x002CA5EC
	private void UnbindRedDot()
	{
		AbyssButtonItem limitRewadItem = this.LimitRewadItem;
		if (limitRewadItem != null)
		{
			limitRewadItem.UnBindRedDot();
		}
		AbyssButtonItem activityRewardItem = this.ActivityRewardItem;
		if (activityRewardItem != null)
		{
			activityRewardItem.UnBindRedDot();
		}
		AbyssButtonItem shopItem = this.ShopItem;
		if (shopItem != null)
		{
			shopItem.UnBindRedDot();
		}
		AbyssButtonItem dangoUpItem = this.DangoUpItem;
		if (dangoUpItem == null)
		{
			return;
		}
		dangoUpItem.UnBindRedDot();
	}

	// Token: 0x0600C54B RID: 50507 RVA: 0x002CC43C File Offset: 0x002CA63C
	private void PlaySceneLevelSequence(string levelSequencePath, bool needLoop, [Nullable(2)] Action finishCallBack = null)
	{
		string[] sceneActors = DangoAbyssConfig.Instance.GetAbyssActivityData(this.CurrentData.ActivityId).Value.SceneActor.Split(',', StringSplitOptions.None);
		Action <>9__1;
		ResourceSystem.Instance.LoadAsync<ULevelSequence>(levelSequencePath, delegate(ULevelSequence levelSequence, string _)
		{
			if (!ObjectUtils.IsValid(levelSequence))
			{
				return;
			}
			if (this.SequenceActor == null)
			{
				ALevelSequenceActor sequenceActor = ActorSystem.Instance.Spawn(ALevelSequenceActor.StaticClass(), new FTransformDouble(), null) as ALevelSequenceActor;
				this.SequenceActor = sequenceActor;
			}
			this.SequenceActor.SetSequence(levelSequence);
			string[] sceneActors = sceneActors;
			for (int i = 0; i < sceneActors.Length; i++)
			{
				FName value = FNameUtil.GetDynamicFName(sceneActors[i]).Value;
				AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(value, ECollectActorType.UI);
				if (actorWithTag != null)
				{
					ALevelSequenceActor sequenceActor2 = this.SequenceActor;
					if (sequenceActor2 != null)
					{
						sequenceActor2.AddBindingByTag(value, actorWithTag, false, false);
					}
				}
			}
			FMovieSceneSequencePlaybackSettings fmovieSceneSequencePlaybackSettings = new FMovieSceneSequencePlaybackSettings();
			fmovieSceneSequencePlaybackSettings.bRestoreState = true;
			fmovieSceneSequencePlaybackSettings.bPauseAtEnd = true;
			this.SequenceActor.PlaybackSettings = fmovieSceneSequencePlaybackSettings;
			this.SequenceActor.SetTickableWhenPaused(true);
			UKuroSequenceRuntimeFunctionLibrary.SetSequenceInUiScene(levelSequence, true);
			this.SequencePlayer = this.SequenceActor.SequencePlayer;
			this.SequenceActor.bOverrideInstanceData = true;
			UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.SequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
			FTransform transformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(RenderModuleController.Instance.GetKuroCurrentUiSceneTransform().Value);
			udefaultLevelSequenceInstanceData.TransformOrigin = transformOrigin;
			FOnMovieSceneSequencePlayerEvent onFinished = this.SequencePlayer.OnFinished;
			Action callback;
			if ((callback = <>9__1) == null)
			{
				callback = (<>9__1 = delegate()
				{
					Action finishCallBack2 = finishCallBack;
					if (finishCallBack2 == null)
					{
						return;
					}
					finishCallBack2();
				});
			}
			onFinished.Add(callback);
			if (needLoop)
			{
				this.SequencePlayer.PlayLooping(-1);
				return;
			}
			this.SequencePlayer.Play();
		}, 100, this.MemoryTag);
	}

	// Token: 0x0600C54C RID: 50508 RVA: 0x002CC4B7 File Offset: 0x002CA6B7
	protected override void OnBeforeHide()
	{
		this.UnbindRedDot();
	}

	// Token: 0x0600C54D RID: 50509 RVA: 0x002CC4C0 File Offset: 0x002CA6C0
	protected override void OnBeforeDestroy()
	{
		ULevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null && sequencePlayer.IsValid())
		{
			ULevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 != null)
			{
				sequencePlayer2.Stop();
			}
			this.SequencePlayer = null;
		}
		ALevelSequenceActor sequenceActor = this.SequenceActor;
		if (sequenceActor != null && sequenceActor.IsValid())
		{
			ALevelSequenceActor sequenceActor2 = this.SequenceActor;
			if (sequenceActor2 != null)
			{
				sequenceActor2.K2_DestroyActor();
			}
			this.SequenceActor = null;
		}
		DangoWorldQuestItem dangoWorldQuestItem = this.DangoWorldQuestItem;
		if (dangoWorldQuestItem == null)
		{
			return;
		}
		dangoWorldQuestItem.Clear();
	}

	// Token: 0x0600C54E RID: 50510 RVA: 0x002CC538 File Offset: 0x002CA738
	private void RefreshView()
	{
		DangoWorldQuestItem dangoWorldQuestItem = this.DangoWorldQuestItem;
		if (dangoWorldQuestItem != null)
		{
			dangoWorldQuestItem.Refresh();
		}
		DangoAbyssActivityData activityData = this.GetActivityData();
		this.RefreshCurrentTargetText(activityData);
		this.RefreshWorldProgressText(activityData);
		this.RefreshAbyssInsProgressText(activityData);
		this.RefreshLimitItemShowState(activityData);
		this.RefreshRewardProgressText(activityData);
	}

	// Token: 0x0600C54F RID: 50511 RVA: 0x002CC580 File Offset: 0x002CA780
	private void RefreshDangaoShowState(DangoAbyssActivityData data)
	{
		int currentLastFinishChallengeId = data.GetCurrentLastFinishChallengeId();
		if (currentLastFinishChallengeId == 0)
		{
			return;
		}
		string[] array = DangoAbyssConfig.Instance.GetDangoAbyssInstById(currentLastFinishChallengeId).Value.AbyssShowCake.Split(',', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(array[i]).Value, ECollectActorType.UI);
			if (actorWithTag != null && actorWithTag.IsValid())
			{
				actorWithTag.SetActorHiddenInGame(false);
			}
		}
	}

	// Token: 0x0600C550 RID: 50512 RVA: 0x002CC5FD File Offset: 0x002CA7FD
	private DangoAbyssActivityData GetActivityData()
	{
		return ActivityModel.Instance.GetActivityById(this.CurrentData.ActivityId) as DangoAbyssActivityData;
	}

	// Token: 0x0600C551 RID: 50513 RVA: 0x002CC61C File Offset: 0x002CA81C
	private void RefreshSceneNiagaraByCurrentChallenge(DangoAbyssActivityData data)
	{
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("shenyuan").Value, ECollectActorType.UI);
		if (actorWithTag != null && actorWithTag.IsValid())
		{
			int firstUnlockChallengeId = data.GetFirstUnlockChallengeId();
			if (firstUnlockChallengeId == 0)
			{
				return;
			}
			FColor fcolor = FColor.FromHex(DangoAbyssConfig.Instance.GetDangoAbyssInstById(firstUnlockChallengeId).Value.AbyssColor);
			FLinearColor flinearColor = FLinearColor.FromSRGBColor(fcolor);
			(actorWithTag.GetComponentByClass(UNiagaraComponent.StaticClass()) as UNiagaraComponent).SetNiagaraVariableLinearColor("Color", flinearColor);
		}
	}

	// Token: 0x0600C552 RID: 50514 RVA: 0x002CC6A8 File Offset: 0x002CA8A8
	private void RefreshLimitItemShowState(DangoAbyssActivityData data)
	{
		bool flag = data.CheckInLimitTime();
		base.GetItem(5).SetUIActive(flag);
		if (flag)
		{
			string remainTimeText = data.GetRemainTimeText();
			AbyssButtonItem limitRewadItem = this.LimitRewadItem;
			if (limitRewadItem == null)
			{
				return;
			}
			limitRewadItem.SetNumText(remainTimeText);
		}
	}

	// Token: 0x0600C553 RID: 50515 RVA: 0x002CC6E4 File Offset: 0x002CA8E4
	private void RefreshCurrentTargetText(DangoAbyssActivityData data)
	{
	}

	// Token: 0x0600C554 RID: 50516 RVA: 0x002CC6E8 File Offset: 0x002CA8E8
	private void RefreshWorldProgressText(DangoAbyssActivityData data)
	{
		string abyssWorldProgressText = data.GetAbyssWorldProgressText();
		base.GetText(2).SetText(abyssWorldProgressText, true);
	}

	// Token: 0x0600C555 RID: 50517 RVA: 0x002CC70C File Offset: 0x002CA90C
	private void RefreshAbyssInsProgressText(DangoAbyssActivityData data)
	{
		string abyssProgressText = data.GetAbyssProgressText();
		base.GetText(4).SetText(abyssProgressText, true);
	}

	// Token: 0x0600C556 RID: 50518 RVA: 0x002CC730 File Offset: 0x002CA930
	private void RefreshRewardProgressText(DangoAbyssActivityData data)
	{
		string rewardFinishProgressText = data.GetRewardFinishProgressText();
		AbyssButtonItem activityRewardItem = this.ActivityRewardItem;
		if (activityRewardItem == null)
		{
			return;
		}
		activityRewardItem.SetNumText(rewardFinishProgressText);
	}

	// Token: 0x0600C557 RID: 50519 RVA: 0x002CC755 File Offset: 0x002CA955
	private void OnClickDangoUp()
	{
		if (!DangoAbyssModel.Instance.GetDangoUpAvailable())
		{
			return;
		}
		DangoAbyssActivityController.Instance.OpenCurrentRoleUpView();
	}

	// Token: 0x0600C558 RID: 50520 RVA: 0x002CC76E File Offset: 0x002CA96E
	private void OnClickShop()
	{
		if (!DangoAbyssModel.Instance.GetShopAvailable())
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssShopView, null, null);
	}

	// Token: 0x0600C559 RID: 50521 RVA: 0x002CC78E File Offset: 0x002CA98E
	protected override void OnTick(float delta)
	{
		DangoWorldQuestItem dangoWorldQuestItem = this.DangoWorldQuestItem;
		if (dangoWorldQuestItem == null)
		{
			return;
		}
		dangoWorldQuestItem.Tick();
	}

	// Token: 0x0600C55A RID: 50522 RVA: 0x002CC7A0 File Offset: 0x002CA9A0
	[CompilerGenerated]
	internal static void <OnCloseBtnClick>g__callBack|15_0()
	{
		BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
		if (childViewData != null)
		{
			childViewData.SetChildVisible(EBattleUiVisibleReason.UiControl, EBattleUiChild.Mission, true, true, 0);
		}
		BattleUiChildViewData childViewData2 = BattleUiModel.Instance.ChildViewData;
		if (childViewData2 != null)
		{
			childViewData2.SetChildVisible(EBattleUiVisibleReason.UiControl, EBattleUiChild.Formation, true, true, 0);
		}
		BattleUiChildViewData childViewData3 = BattleUiModel.Instance.ChildViewData;
		if (childViewData3 != null)
		{
			childViewData3.SetChildVisible(EBattleUiVisibleReason.UiControl, EBattleUiChild.GamepadFormation, true, true, 0);
		}
		InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
	}

	// Token: 0x04005AED RID: 23277
	[Nullable(2)]
	private DangoAbyssEntraceViewData CurrentData;

	// Token: 0x04005AEE RID: 23278
	[Nullable(2)]
	private AbyssButtonItem LimitRewadItem;

	// Token: 0x04005AEF RID: 23279
	[Nullable(2)]
	private AbyssButtonItem ActivityRewardItem;

	// Token: 0x04005AF0 RID: 23280
	[Nullable(2)]
	private AbyssButtonItem DangoUpItem;

	// Token: 0x04005AF1 RID: 23281
	[Nullable(2)]
	private AbyssButtonItem ShopItem;

	// Token: 0x04005AF2 RID: 23282
	[Nullable(2)]
	private ULevelSequencePlayer SequencePlayer;

	// Token: 0x04005AF3 RID: 23283
	[Nullable(2)]
	private ALevelSequenceActor SequenceActor;

	// Token: 0x04005AF4 RID: 23284
	[Nullable(2)]
	private DangoWorldQuestItem DangoWorldQuestItem;

	// Token: 0x04005AF5 RID: 23285
	private const string STARTCAMERAPOS = "DangoAbyssStart";

	// Token: 0x04005AF6 RID: 23286
	private const string ENTRANCELOOP = "DangoAbyssLoop";

	// Token: 0x02007F7A RID: 32634
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040299D4 RID: 170452
		CloseBtn,
		// Token: 0x040299D5 RID: 170453
		WorldEntranceBtn,
		// Token: 0x040299D6 RID: 170454
		WorldProgressText,
		// Token: 0x040299D7 RID: 170455
		AbyssInsEntranceBtn,
		// Token: 0x040299D8 RID: 170456
		AbyssInsProgressText,
		// Token: 0x040299D9 RID: 170457
		LimitRewardItem,
		// Token: 0x040299DA RID: 170458
		ActivityRewardItem,
		// Token: 0x040299DB RID: 170459
		DangoUpItem,
		// Token: 0x040299DC RID: 170460
		ShopItem,
		// Token: 0x040299DD RID: 170461
		GoalScroller,
		// Token: 0x040299DE RID: 170462
		GoalItem
	}
}
