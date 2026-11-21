using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EF3 RID: 3827
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssEntranceView : UiTickViewBase, IUiViewCameraBehavior
{
	// Token: 0x0600994D RID: 39245 RVA: 0x002D6F57 File Offset: 0x002D5157
	public DangoAbyssEntranceView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600994E RID: 39246 RVA: 0x002D6F60 File Offset: 0x002D5160
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

	// Token: 0x0600994F RID: 39247 RVA: 0x002D7178 File Offset: 0x002D5378
	public override bool GetBgmSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x06009950 RID: 39248 RVA: 0x002D7188 File Offset: 0x002D5388
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssEntranceView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssEntranceView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009951 RID: 39249 RVA: 0x002D71CC File Offset: 0x002D53CC
	private void OnCloseBtnClick()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		IReadOnlyList<int> smallWorldInsIdList = DangoAbyssConfig.Instance.GetSmallWorldInsIdList();
		bool? flag = null;
		if (smallWorldInsIdList != null)
		{
			flag = new bool?(false);
			for (int i = 0; i < smallWorldInsIdList.Count; i++)
			{
				if (smallWorldInsIdList[i] == instanceId)
				{
					flag = new bool?(true);
					break;
				}
			}
		}
		if (!flag.GetValueOrDefault())
		{
			base.CloseMe(null);
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DangoQuitWorld);
		confirmBoxDataNew.FunctionMap.Add(2, new Action(DangoAbyssEntranceView.<OnCloseBtnClick>g__callBack|15_0));
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06009952 RID: 39250 RVA: 0x002D726A File Offset: 0x002D546A
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
		UiCameraController.Instance.PushCameraHandleByOpenView((EUiViewName)"DangoAbyssStart", viewId, operationType);
		UiCameraModel.Instance.PushCameraHandleByHandleName("DangoAbyssLoop", true, true, "1001", false, null);
	}

	// Token: 0x06009953 RID: 39251 RVA: 0x002D729B File Offset: 0x002D549B
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		UiCameraController.Instance.PopCameraHandleByCloseView((EUiViewName)"DangoAbyssStart", nextViewName, closeViewId, operationType);
	}

	// Token: 0x06009954 RID: 39252 RVA: 0x002D72B8 File Offset: 0x002D54B8
	protected override void OnHandleLoadScene()
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("Ani_Tuanzi_Start0");
		this.PlaySceneLevelSequence(resourcePath, false, delegate
		{
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("Ani_Tuanzi_Loop");
			this.PlaySceneLevelSequence(resourcePath2, true, null);
		});
	}

	// Token: 0x06009955 RID: 39253 RVA: 0x002D72EC File Offset: 0x002D54EC
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

	// Token: 0x06009956 RID: 39254 RVA: 0x002D73B0 File Offset: 0x002D55B0
	private void OnAbyssInsEntranceBtnClick()
	{
		int activityId = this.CurrentData.ActivityId;
		DangoAbyssController.Instance.OpenAbyssSelectViewByActivityId(activityId);
	}

	// Token: 0x06009957 RID: 39255 RVA: 0x002D73D4 File Offset: 0x002D55D4
	protected override void OnBeforeShow()
	{
		this.PushCameraHandleByOpenView((EUiViewName)"DangoAbyssLoop", base.GetViewId(), EUiCameraHandleOperationType.Blend);
		DangoAbyssActivityData activityData = this.GetActivityData();
		this.RefreshSceneNiagaraByCurrentChallenge(activityData);
		this.RefreshView();
		this.RefreshRedDot();
		this.RefreshDangaoShowState(activityData);
		this.RefreshBtns();
	}

	// Token: 0x06009958 RID: 39256 RVA: 0x002D7420 File Offset: 0x002D5620
	private void RefreshBtns()
	{
		bool dangoUpAvailable = DangoAbyssModel.Instance.GetDangoUpAvailable();
		this.DangoUpItem.SetUiActive(dangoUpAvailable);
		bool shopAvailable = DangoAbyssModel.Instance.GetShopAvailable();
		this.ShopItem.SetUiActive(shopAvailable);
	}

	// Token: 0x06009959 RID: 39257 RVA: 0x002D745C File Offset: 0x002D565C
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

	// Token: 0x0600995A RID: 39258 RVA: 0x002D7510 File Offset: 0x002D5710
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

	// Token: 0x0600995B RID: 39259 RVA: 0x002D7560 File Offset: 0x002D5760
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

	// Token: 0x0600995C RID: 39260 RVA: 0x002D75DB File Offset: 0x002D57DB
	protected override void OnBeforeHide()
	{
		this.UnbindRedDot();
	}

	// Token: 0x0600995D RID: 39261 RVA: 0x002D75E4 File Offset: 0x002D57E4
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

	// Token: 0x0600995E RID: 39262 RVA: 0x002D765C File Offset: 0x002D585C
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

	// Token: 0x0600995F RID: 39263 RVA: 0x002D76A4 File Offset: 0x002D58A4
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

	// Token: 0x06009960 RID: 39264 RVA: 0x002D7721 File Offset: 0x002D5921
	private DangoAbyssActivityData GetActivityData()
	{
		return ActivityModel.Instance.GetActivityById(this.CurrentData.ActivityId) as DangoAbyssActivityData;
	}

	// Token: 0x06009961 RID: 39265 RVA: 0x002D7740 File Offset: 0x002D5940
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

	// Token: 0x06009962 RID: 39266 RVA: 0x002D77CC File Offset: 0x002D59CC
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

	// Token: 0x06009963 RID: 39267 RVA: 0x002D7808 File Offset: 0x002D5A08
	private void RefreshCurrentTargetText(DangoAbyssActivityData data)
	{
	}

	// Token: 0x06009964 RID: 39268 RVA: 0x002D780C File Offset: 0x002D5A0C
	private void RefreshWorldProgressText(DangoAbyssActivityData data)
	{
		string abyssWorldProgressText = data.GetAbyssWorldProgressText();
		base.GetText(2).SetText(abyssWorldProgressText, true);
	}

	// Token: 0x06009965 RID: 39269 RVA: 0x002D7830 File Offset: 0x002D5A30
	private void RefreshAbyssInsProgressText(DangoAbyssActivityData data)
	{
		string abyssProgressText = data.GetAbyssProgressText();
		base.GetText(4).SetText(abyssProgressText, true);
	}

	// Token: 0x06009966 RID: 39270 RVA: 0x002D7854 File Offset: 0x002D5A54
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

	// Token: 0x06009967 RID: 39271 RVA: 0x002D7879 File Offset: 0x002D5A79
	private void OnClickDangoUp()
	{
		if (!DangoAbyssModel.Instance.GetDangoUpAvailable())
		{
			return;
		}
		DangoAbyssActivityController.Instance.OpenCurrentRoleUpView();
	}

	// Token: 0x06009968 RID: 39272 RVA: 0x002D7892 File Offset: 0x002D5A92
	private void OnClickShop()
	{
		if (!DangoAbyssModel.Instance.GetShopAvailable())
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssShopView, null, null);
	}

	// Token: 0x06009969 RID: 39273 RVA: 0x002D78B2 File Offset: 0x002D5AB2
	protected override void OnTick(float delta)
	{
		DangoWorldQuestItem dangoWorldQuestItem = this.DangoWorldQuestItem;
		if (dangoWorldQuestItem == null)
		{
			return;
		}
		dangoWorldQuestItem.Tick();
	}

	// Token: 0x0600996A RID: 39274 RVA: 0x002D78C4 File Offset: 0x002D5AC4
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

	// Token: 0x04005BBC RID: 23484
	[Nullable(2)]
	private DangoAbyssEntraceViewData CurrentData;

	// Token: 0x04005BBD RID: 23485
	[Nullable(2)]
	private AbyssButtonItem LimitRewadItem;

	// Token: 0x04005BBE RID: 23486
	[Nullable(2)]
	private AbyssButtonItem ActivityRewardItem;

	// Token: 0x04005BBF RID: 23487
	[Nullable(2)]
	private AbyssButtonItem DangoUpItem;

	// Token: 0x04005BC0 RID: 23488
	[Nullable(2)]
	private AbyssButtonItem ShopItem;

	// Token: 0x04005BC1 RID: 23489
	[Nullable(2)]
	private ULevelSequencePlayer SequencePlayer;

	// Token: 0x04005BC2 RID: 23490
	[Nullable(2)]
	private ALevelSequenceActor SequenceActor;

	// Token: 0x04005BC3 RID: 23491
	[Nullable(2)]
	private DangoWorldQuestItem DangoWorldQuestItem;

	// Token: 0x04005BC4 RID: 23492
	private const string STARTCAMERAPOS = "DangoAbyssStart";

	// Token: 0x04005BC5 RID: 23493
	private const string ENTRANCELOOP = "DangoAbyssLoop";

	// Token: 0x02007109 RID: 28937
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024D11 RID: 150801
		CloseBtn,
		// Token: 0x04024D12 RID: 150802
		WorldEntranceBtn,
		// Token: 0x04024D13 RID: 150803
		WorldProgressText,
		// Token: 0x04024D14 RID: 150804
		AbyssInsEntranceBtn,
		// Token: 0x04024D15 RID: 150805
		AbyssInsProgressText,
		// Token: 0x04024D16 RID: 150806
		LimitRewardItem,
		// Token: 0x04024D17 RID: 150807
		ActivityRewardItem,
		// Token: 0x04024D18 RID: 150808
		DangoUpItem,
		// Token: 0x04024D19 RID: 150809
		ShopItem,
		// Token: 0x04024D1A RID: 150810
		GoalScroller,
		// Token: 0x04024D1B RID: 150811
		GoalItem
	}
}
