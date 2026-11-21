using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.NPC.Tuanzi;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006F7 RID: 1783
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyResultView : DangoMonopolyViewBase
{
	// Token: 0x17000ADD RID: 2781
	// (get) Token: 0x0600523D RID: 21053 RVA: 0x001B5F26 File Offset: 0x001B4126
	[Nullable(2)]
	public new DangoMonopolyResultViewParams OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as DangoMonopolyResultViewParams;
		}
	}

	// Token: 0x0600523E RID: 21054 RVA: 0x001B5F34 File Offset: 0x001B4134
	public DangoMonopolyResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.MoveInTime = (float)ActivityDangoMonopolyConfig.Instance.GetDangoMoveInTime();
		this.MoveOutTime = (float)ActivityDangoMonopolyConfig.Instance.GetDangoMoveOutTime();
		this.MoveOutDelayTime = (float)ActivityDangoMonopolyConfig.Instance.GetDangoMoveOutDelayTime();
		this.MoveChangeCheckTime = (float)ActivityDangoMonopolyConfig.Instance.GetDangoChangeCheckTime();
	}

	// Token: 0x0600523F RID: 21055 RVA: 0x001B5FE0 File Offset: 0x001B41E0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose))
		};
	}

	// Token: 0x06005240 RID: 21056 RVA: 0x001B6126 File Offset: 0x001B4326
	private void InitDataParam()
	{
	}

	// Token: 0x06005241 RID: 21057 RVA: 0x001B6128 File Offset: 0x001B4328
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.DangoMonopolyEnterNextRound, new Action(this.EventEnterNextRound));
	}

	// Token: 0x06005242 RID: 21058 RVA: 0x001B6146 File Offset: 0x001B4346
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.DangoMonopolyEnterNextRound, new Action(this.EventEnterNextRound));
	}

	// Token: 0x06005243 RID: 21059 RVA: 0x001B6164 File Offset: 0x001B4364
	private void EventEnterNextRound()
	{
		this.ActivityData.UpdateBoardGridUiInfoShow(false).Forget();
	}

	// Token: 0x06005244 RID: 21060 RVA: 0x001B6178 File Offset: 0x001B4378
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyResultView.<OnBeforeStartAsync>d__41 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyResultView.<OnBeforeStartAsync>d__41>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005245 RID: 21061 RVA: 0x001B61BB File Offset: 0x001B43BB
	protected override void OnStart()
	{
		this.UpdateMoveParam();
		this.ActivityData.UpdateBoardGridUiInfoShow(false).Forget();
		this.InitCurve().Forget();
		this.UpdateData();
	}

	// Token: 0x06005246 RID: 21062 RVA: 0x001B61E5 File Offset: 0x001B43E5
	protected override void OnBeforeShow()
	{
		DangoMonopolyResultViewParams openParam = this.OpenParam;
		if (((openParam != null) ? openParam.ShowPromise : null) != null && this.OpenParam.ShowPromise.IsPending)
		{
			this.OpenParam.ShowPromise.SetResult();
		}
	}

	// Token: 0x06005247 RID: 21063 RVA: 0x001B621D File Offset: 0x001B441D
	protected override void OnAfterShow()
	{
	}

	// Token: 0x06005248 RID: 21064 RVA: 0x001B621F File Offset: 0x001B441F
	protected override void OnBeforeDestroy()
	{
		this.ActivityData.UpdateBoardGridUiInfoShow(true).Forget();
		this.DestroyDangoActor().Forget();
		DangoMonopolyResultViewParams openParam = this.OpenParam;
		if (openParam == null)
		{
			return;
		}
		CustomPromise closePromise = openParam.ClosePromise;
		if (closePromise == null)
		{
			return;
		}
		closePromise.SetResult();
	}

	// Token: 0x06005249 RID: 21065 RVA: 0x001B6257 File Offset: 0x001B4457
	private void OnClickClose()
	{
		if (this.ActivityData.IsShowRoundWelcome(false))
		{
			base.CloseMe(null);
			return;
		}
		this.ActivityData.OpenViewDangoMonopolyTransition(delegate
		{
			DangoMonopolyResultView.<<OnClickClose>b__46_0>d <<OnClickClose>b__46_0>d;
			<<OnClickClose>b__46_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnClickClose>b__46_0>d.<>4__this = this;
			<<OnClickClose>b__46_0>d.<>1__state = -1;
			<<OnClickClose>b__46_0>d.<>t__builder.Start<DangoMonopolyResultView.<<OnClickClose>b__46_0>d>(ref <<OnClickClose>b__46_0>d);
			return <<OnClickClose>b__46_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x0600524A RID: 21066 RVA: 0x001B6286 File Offset: 0x001B4486
	private DangoMonopolyResultRoundItem CreateRoundItem()
	{
		return new DangoMonopolyResultRoundItem
		{
			ClickCallBack = new Action<DangoMonopolyBoardData>(this.OnClickRoundItem)
		};
	}

	// Token: 0x0600524B RID: 21067 RVA: 0x001B62A0 File Offset: 0x001B44A0
	private void OnClickRoundItem(DangoMonopolyBoardData data)
	{
		this.LastBoardData = this.ShowBoardData;
		this.ShowBoardData = data;
		bool flag = this.ShowBoardData.IsFinish();
		List<RewardItemData> data2 = flag ? this.ShowBoardData.GetAllGridRewardItemList() : new List<RewardItemData>();
		GenericLayout<RewardSmallItemGrid, RewardItemData> rewardScrollView = this.RewardScrollView;
		if (rewardScrollView != null)
		{
			rewardScrollView.RefreshByData(data2, null, false);
		}
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		if (flag)
		{
			UUIText text = base.GetText(4);
			string finishTitle = this.ShowBoardData.FinishTitle;
			LguiUtil.Instance.SetLocalTextNew(text, finishTitle, new <>z__ReadOnlySingleElementList<object>(data.GetPosition()));
			UUIText text2 = base.GetText(5);
			string finishDesc = this.ShowBoardData.FinishDesc;
			List<IDangoMonopolyRoundBuffData> dangoBuffShowList = this.ShowBoardData.GetDangoBuffShowList();
			List<string> list = new List<string>();
			foreach (IDangoMonopolyRoundBuffData dangoMonopolyRoundBuffData in dangoBuffShowList)
			{
				list.Add(dangoMonopolyRoundBuffData.DangoName);
			}
			List<string> list2 = new List<string>();
			foreach (string text3 in list)
			{
				string item3 = ConfigMultiTextLang.GetLocalTextNew(text3, null) ?? text3;
				list2.Add(item3);
			}
			string item4 = this.ShowBoardData.RecordRollDiceTimes.ToString();
			string item5 = this.ShowBoardData.GetRecordTriggerBuffTotalTimes().ToString();
			List<object> list3 = new List<object>();
			foreach (string item6 in list2)
			{
				list3.Add(item6);
			}
			list3.Add(item4);
			list3.Add(item5);
			LguiUtil.Instance.SetLocalTextNew(text2, finishDesc, list3.ToArray());
		}
		else
		{
			UUIText text4 = base.GetText(11);
			if (text4 != null)
			{
				text4.ShowTextNew(this.GetEmptyTipsKey());
			}
		}
		if (this.LastBoardData == this.ShowBoardData)
		{
			this.LoadDangoActorList().Forget();
		}
		else
		{
			this.IsMoveChangeCheck = true;
			this.MoveChangeCheckDelta = 0f;
		}
		if (base.IsShow)
		{
			base.PlaySequence("Switch", null, false);
		}
	}

	// Token: 0x0600524C RID: 21068 RVA: 0x001B6518 File Offset: 0x001B4718
	private string GetEmptyTipsKey()
	{
		DangoMonopolyBoardData showBoardData = this.ShowBoardData;
		if (showBoardData == null || !showBoardData.IsRunning())
		{
			return "DangoMonopoly_title_13";
		}
		DangoMonopolyBoardData showBoardData2 = this.ShowBoardData;
		if (showBoardData2 != null && showBoardData2.IsLock())
		{
			return "DangoMonopoly_title_17";
		}
		return "DangoMonopoly_title_12";
	}

	// Token: 0x0600524D RID: 21069 RVA: 0x001B6553 File Offset: 0x001B4753
	private RewardSmallItemGrid CreateRewardItem()
	{
		RewardSmallItemGrid rewardSmallItemGrid = new RewardSmallItemGrid();
		rewardSmallItemGrid.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		rewardSmallItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
		return rewardSmallItemGrid;
	}

	// Token: 0x0600524E RID: 21070 RVA: 0x001B6594 File Offset: 0x001B4794
	private void OnClickedRewardItem(MediumItemGridExtendCallback info)
	{
		RewardItemData rewardItemData = info.Data as RewardItemData;
		int itemId = (rewardItemData != null) ? rewardItemData.ConfigId : 0;
		ItemController.Instance.OpenItemTipsByItemId(itemId, true, null, false);
	}

	// Token: 0x0600524F RID: 21071 RVA: 0x001B65C8 File Offset: 0x001B47C8
	public void UpdateData()
	{
		DangoMonopolyResultViewParams openParam = this.OpenParam;
		int key = (openParam != null) ? openParam.BoardId : 1;
		DangoMonopolyBoardData showBoardData;
		if (!this.ActivityData.BoardMap.TryGetValue(key, out showBoardData))
		{
			showBoardData = null;
		}
		this.ShowBoardData = showBoardData;
		List<DangoMonopolyBoardData> data = this.ActivityData.BoardList ?? new List<DangoMonopolyBoardData>();
		LoopScrollView<DangoMonopolyResultRoundItem, DangoMonopolyBoardData> roundScrollView = this.RoundScrollView;
		if (roundScrollView != null)
		{
			roundScrollView.RefreshByData(data, false, delegate
			{
				LoopScrollView<DangoMonopolyResultRoundItem, DangoMonopolyBoardData> roundScrollView2 = this.RoundScrollView;
				if (roundScrollView2 != null)
				{
					roundScrollView2.DeselectCurrentGridProxy(false);
				}
				DangoMonopolyBoardData showBoardData2 = this.ShowBoardData;
				int gridIndex = (showBoardData2 != null) ? showBoardData2.Index : 0;
				LoopScrollView<DangoMonopolyResultRoundItem, DangoMonopolyBoardData> roundScrollView3 = this.RoundScrollView;
				if (roundScrollView3 != null)
				{
					roundScrollView3.ScrollToGridIndex(gridIndex, true);
				}
				LoopScrollView<DangoMonopolyResultRoundItem, DangoMonopolyBoardData> roundScrollView4 = this.RoundScrollView;
				if (roundScrollView4 == null)
				{
					return;
				}
				roundScrollView4.SelectGridProxy(gridIndex, false);
			}, false);
		}
		DangoMonopolyResultViewParams openParam2 = this.OpenParam;
		bool uiactive = openParam2 != null && openParam2.ShowType == EDangoMonopolyResultType.Record;
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(1);
		if (loopScrollViewComponent == null)
		{
			return;
		}
		loopScrollViewComponent.RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06005250 RID: 21072 RVA: 0x001B6674 File Offset: 0x001B4874
	public UniTask LoadDangoActorList()
	{
		DangoMonopolyResultView.<LoadDangoActorList>d__53 <LoadDangoActorList>d__;
		<LoadDangoActorList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadDangoActorList>d__.<>4__this = this;
		<LoadDangoActorList>d__.<>1__state = -1;
		<LoadDangoActorList>d__.<>t__builder.Start<DangoMonopolyResultView.<LoadDangoActorList>d__53>(ref <LoadDangoActorList>d__);
		return <LoadDangoActorList>d__.<>t__builder.Task;
	}

	// Token: 0x06005251 RID: 21073 RVA: 0x001B66B8 File Offset: 0x001B48B8
	[NullableContext(0)]
	public UniTask<bool> MoveDangoActorList()
	{
		DangoMonopolyResultView.<MoveDangoActorList>d__54 <MoveDangoActorList>d__;
		<MoveDangoActorList>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<MoveDangoActorList>d__.<>4__this = this;
		<MoveDangoActorList>d__.<>1__state = -1;
		<MoveDangoActorList>d__.<>t__builder.Start<DangoMonopolyResultView.<MoveDangoActorList>d__54>(ref <MoveDangoActorList>d__);
		return <MoveDangoActorList>d__.<>t__builder.Task;
	}

	// Token: 0x06005252 RID: 21074 RVA: 0x001B66FC File Offset: 0x001B48FC
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public UniTask<List<TsUiSceneDangoActor>> GetShowDangoActorList()
	{
		DangoMonopolyResultView.<GetShowDangoActorList>d__55 <GetShowDangoActorList>d__;
		<GetShowDangoActorList>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<TsUiSceneDangoActor>>.Create();
		<GetShowDangoActorList>d__.<>4__this = this;
		<GetShowDangoActorList>d__.<>1__state = -1;
		<GetShowDangoActorList>d__.<>t__builder.Start<DangoMonopolyResultView.<GetShowDangoActorList>d__55>(ref <GetShowDangoActorList>d__);
		return <GetShowDangoActorList>d__.<>t__builder.Task;
	}

	// Token: 0x06005253 RID: 21075 RVA: 0x001B6740 File Offset: 0x001B4940
	public void UpdateShowDangoIdList()
	{
		int dangoId = this.ActivityData.GetDangoId();
		List<int> list = new List<int>();
		if (this.ShowBoardData != null)
		{
			foreach (IDangoMonopolyRoundBuffData dangoMonopolyRoundBuffData in this.ShowBoardData.GetDangoBuffShowList())
			{
				list.Add(dangoMonopolyRoundBuffData.DangoId);
			}
			list.Reverse();
		}
		list.Add(dangoId);
		this.ShowDangoIdList = list.ToArray();
	}

	// Token: 0x06005254 RID: 21076 RVA: 0x001B67D0 File Offset: 0x001B49D0
	public void UpdateDangoFadeIn([Nullable(new byte[]
	{
		2,
		1
	})] List<TsUiSceneDangoActor> list = null)
	{
		foreach (TsUiSceneDangoActor roleActor in (list ?? this.ShowDangoActorList))
		{
			UiModelUtil.Instance.DangoFadeOut(roleActor, null, null);
		}
	}

	// Token: 0x06005255 RID: 21077 RVA: 0x001B6838 File Offset: 0x001B4A38
	public void UpdateDangoFadeOut([Nullable(new byte[]
	{
		2,
		1
	})] List<TsUiSceneDangoActor> list = null)
	{
		foreach (TsUiSceneDangoActor actor in (list ?? this.LastDangoActorList))
		{
			UiModelUtil.Instance.DangoFadeIn(actor, null, null);
		}
	}

	// Token: 0x06005256 RID: 21078 RVA: 0x001B68A0 File Offset: 0x001B4AA0
	public UniTask MoveOutLastDangoList()
	{
		DangoMonopolyResultView.<MoveOutLastDangoList>d__59 <MoveOutLastDangoList>d__;
		<MoveOutLastDangoList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoveOutLastDangoList>d__.<>4__this = this;
		<MoveOutLastDangoList>d__.<>1__state = -1;
		<MoveOutLastDangoList>d__.<>t__builder.Start<DangoMonopolyResultView.<MoveOutLastDangoList>d__59>(ref <MoveOutLastDangoList>d__);
		return <MoveOutLastDangoList>d__.<>t__builder.Task;
	}

	// Token: 0x06005257 RID: 21079 RVA: 0x001B68E4 File Offset: 0x001B4AE4
	public UniTask MoveInShowDangoList()
	{
		DangoMonopolyResultView.<MoveInShowDangoList>d__60 <MoveInShowDangoList>d__;
		<MoveInShowDangoList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoveInShowDangoList>d__.<>4__this = this;
		<MoveInShowDangoList>d__.<>1__state = -1;
		<MoveInShowDangoList>d__.<>t__builder.Start<DangoMonopolyResultView.<MoveInShowDangoList>d__60>(ref <MoveInShowDangoList>d__);
		return <MoveInShowDangoList>d__.<>t__builder.Task;
	}

	// Token: 0x06005258 RID: 21080 RVA: 0x001B6928 File Offset: 0x001B4B28
	public void UpdateDangoAttach()
	{
		this.TempVec.Set(0.0, 0.0, 0.0);
		for (int i = 1; i < this.ShowDangoActorList.Count; i++)
		{
			TsUiSceneDangoActor tsUiSceneDangoActor = this.ShowDangoActorList[i];
			UiModelBase model = this.ShowDangoActorList[i - 1].Model;
			UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
			USkeletalMeshComponent uskeletalMeshComponent = (uiModelActorComponent != null) ? uiModelActorComponent.MainMeshComponent : null;
			if (uskeletalMeshComponent != null)
			{
				this.TempVec.Z = (double)DangoManager.Instance.GetDangoData(this.ShowDangoIdList[i - 1]).ModelHeight;
				EAttachmentRule eattachmentRule = EAttachmentRule.SnapToTarget;
				FName socketName = new FName("Root");
				tsUiSceneDangoActor.K2_AttachToComponent(uskeletalMeshComponent, socketName, eattachmentRule, eattachmentRule, eattachmentRule, false, true);
				FHitResult fhitResult = new FHitResult();
				tsUiSceneDangoActor.D_K2_AddActorLocalOffset(this.TempVec, true, ref fhitResult, false);
				tsUiSceneDangoActor.SetActorHiddenInGame(false);
			}
		}
		if (this.ShowDangoActorList.Count > 0)
		{
			TsUiSceneDangoActor tsUiSceneDangoActor2 = this.ShowDangoActorList[0];
			int num = 1000;
			this.TempVec.Set((double)num, (double)num, (double)num);
			FHitResult fhitResult2 = new FHitResult();
			tsUiSceneDangoActor2.D_K2_AddActorLocalOffset(this.TempVec, true, ref fhitResult2, false);
			tsUiSceneDangoActor2.SetActorHiddenInGame(false);
		}
	}

	// Token: 0x06005259 RID: 21081 RVA: 0x001B6A64 File Offset: 0x001B4C64
	public UniTask DestroyDangoActor()
	{
		DangoMonopolyResultView.<DestroyDangoActor>d__62 <DestroyDangoActor>d__;
		<DestroyDangoActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DestroyDangoActor>d__.<>4__this = this;
		<DestroyDangoActor>d__.<>1__state = -1;
		<DestroyDangoActor>d__.<>t__builder.Start<DangoMonopolyResultView.<DestroyDangoActor>d__62>(ref <DestroyDangoActor>d__);
		return <DestroyDangoActor>d__.<>t__builder.Task;
	}

	// Token: 0x0600525A RID: 21082 RVA: 0x001B6AA8 File Offset: 0x001B4CA8
	public void UpdateMoveParam()
	{
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(this.ShowCase).Value, ECollectActorType.UI);
		if (actorWithTag != null)
		{
			FVectorDouble location = actorWithTag.D_GetTransform().GetLocation();
			this.ShowVec.Set(location.X, location.Y, location.Z);
		}
	}

	// Token: 0x0600525B RID: 21083 RVA: 0x001B6B00 File Offset: 0x001B4D00
	public UniTask InitCurve()
	{
		DangoMonopolyResultView.<InitCurve>d__64 <InitCurve>d__;
		<InitCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCurve>d__.<>4__this = this;
		<InitCurve>d__.<>1__state = -1;
		<InitCurve>d__.<>t__builder.Start<DangoMonopolyResultView.<InitCurve>d__64>(ref <InitCurve>d__);
		return <InitCurve>d__.<>t__builder.Task;
	}

	// Token: 0x0600525C RID: 21084 RVA: 0x001B6B44 File Offset: 0x001B4D44
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<UCurveFloat> LoadCurveFloat(string resId)
	{
		DangoMonopolyResultView.<LoadCurveFloat>d__65 <LoadCurveFloat>d__;
		<LoadCurveFloat>d__.<>t__builder = AsyncUniTaskMethodBuilder<UCurveFloat>.Create();
		<LoadCurveFloat>d__.resId = resId;
		<LoadCurveFloat>d__.<>1__state = -1;
		<LoadCurveFloat>d__.<>t__builder.Start<DangoMonopolyResultView.<LoadCurveFloat>d__65>(ref <LoadCurveFloat>d__);
		return <LoadCurveFloat>d__.<>t__builder.Task;
	}

	// Token: 0x0600525D RID: 21085 RVA: 0x001B6B88 File Offset: 0x001B4D88
	[NullableContext(2)]
	public float GetTotalDistance(UCurveFloat curve)
	{
		if (curve == null)
		{
			return 0f;
		}
		int num = curve.FloatCurve.Keys.Num();
		if (num > 0)
		{
			FRichCurveKey frichCurveKey = curve.FloatCurve.Keys.Get(num - 1);
			return frichCurveKey.Time;
		}
		return 0f;
	}

	// Token: 0x0600525E RID: 21086 RVA: 0x001B6BD4 File Offset: 0x001B4DD4
	[NullableContext(2)]
	public float GetTotalHeight(UCurveFloat curve)
	{
		if (curve == null)
		{
			return 0f;
		}
		if (curve.FloatCurve.Keys.Num() > 1)
		{
			FRichCurveKey frichCurveKey = curve.FloatCurve.Keys.Get(1);
			return frichCurveKey.Value;
		}
		return 0f;
	}

	// Token: 0x0600525F RID: 21087 RVA: 0x001B6C1C File Offset: 0x001B4E1C
	private void SetDangoMoveProgress(float percent, bool isIn, [Nullable(2)] UCurveFloat curve, List<TsUiSceneDangoActor> list)
	{
		float num = MathUtils.Instance.Clamp(percent, 0f, 1f);
		float totalDistance = this.GetTotalDistance(curve);
		float num2 = isIn ? (1f - num) : num;
		float num3 = totalDistance * num2;
		float num4 = (curve != null) ? curve.GetFloatValue(num3) : 0f;
		float num5 = isIn ? num3 : (-num3);
		if (list.Count > 0)
		{
			TsUiSceneDangoActor tsUiSceneDangoActor = list[0];
			this.TempVec.Set(this.ShowVec.X, (double)num5 + this.ShowVec.Y, (double)num4 + this.ShowVec.Z);
			FHitResult fhitResult = new FHitResult();
			if (tsUiSceneDangoActor != null)
			{
				tsUiSceneDangoActor.D_K2_SetActorLocation(this.TempVec, true, ref fhitResult, false);
			}
		}
		if (this.ShowLog)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Percent: ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(num2);
			defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	// Token: 0x06005260 RID: 21088 RVA: 0x001B6D06 File Offset: 0x001B4F06
	public void SetDangoMoveInProgress(float percent)
	{
		this.SetDangoMoveProgress(percent, true, this.MoveInCurve, this.ShowDangoActorList);
	}

	// Token: 0x06005261 RID: 21089 RVA: 0x001B6D1C File Offset: 0x001B4F1C
	public void SetDangoMoveOutProgress(float percent)
	{
		this.SetDangoMoveProgress(percent, false, this.MoveOutCurve, this.LastDangoActorList);
	}

	// Token: 0x06005262 RID: 21090 RVA: 0x001B6D32 File Offset: 0x001B4F32
	protected override void OnBeforeShowImplementImplement()
	{
		UiManager.Instance.AddTickView(this);
	}

	// Token: 0x06005263 RID: 21091 RVA: 0x001B6D3F File Offset: 0x001B4F3F
	protected override void OnAfterHideImplementImplement()
	{
		UiManager.Instance.RemoveTickView(this);
		this.MoveInEnd();
		this.MoveOutEnd();
	}

	// Token: 0x06005264 RID: 21092 RVA: 0x001B6D5A File Offset: 0x001B4F5A
	protected override void OnTick(float delta)
	{
		this.UpdateMoveInTick(delta);
		this.UpdateMoveOutTick(delta);
		this.UpdateMoveChangeCheckTick(delta);
	}

	// Token: 0x06005265 RID: 21093 RVA: 0x001B6D74 File Offset: 0x001B4F74
	protected void OnAfterTick()
	{
	}

	// Token: 0x06005266 RID: 21094 RVA: 0x001B6D78 File Offset: 0x001B4F78
	public bool MoveInStart()
	{
		if (this.IsMovingIn)
		{
			return false;
		}
		this.IsMovingIn = true;
		this.MoveInDelta = 0f;
		this.MoveInPromise = new CustomPromise();
		this.SetActorListHidden(false, this.ShowDangoActorList);
		this.PlayJumpAni(this.ShowDangoActorList, this.MoveInCurve);
		return true;
	}

	// Token: 0x06005267 RID: 21095 RVA: 0x001B6DCC File Offset: 0x001B4FCC
	public bool MoveOutStart()
	{
		if (this.IsMovingOut)
		{
			return false;
		}
		this.IsMovingOut = true;
		this.MoveOutDelta = 0f;
		this.MoveOutDelayDelta = 0f;
		this.MoveOutPromise = new CustomPromise();
		this.SetDangoMoveOutProgress(0f);
		this.SetActorListHidden(false, this.LastDangoActorList);
		this.PlayJumpAni(this.LastDangoActorList, this.MoveOutCurve);
		return true;
	}

	// Token: 0x06005268 RID: 21096 RVA: 0x001B6E36 File Offset: 0x001B5036
	public bool MoveInEnd()
	{
		if (!this.IsMovingIn)
		{
			return false;
		}
		this.ResetMoveInRecord();
		return true;
	}

	// Token: 0x06005269 RID: 21097 RVA: 0x001B6E49 File Offset: 0x001B5049
	public bool MoveOutEnd()
	{
		if (!this.IsMovingOut)
		{
			return false;
		}
		this.ReturnStand(this.LastDangoActorList, "MoveOutEnd");
		this.SetActorListHidden(true, this.LastDangoActorList);
		this.ResetMoveOutRecord();
		return true;
	}

	// Token: 0x0600526A RID: 21098 RVA: 0x001B6E7C File Offset: 0x001B507C
	public bool UpdateMoveInTick(float delta)
	{
		if (!this.IsMovingIn)
		{
			return false;
		}
		if (this.MoveInDelta >= this.MoveInTime)
		{
			this.MoveInEnd();
			return true;
		}
		this.MoveInDelta += delta;
		float dangoMoveInProgress = this.MoveInDelta / this.MoveInTime;
		this.SetDangoMoveInProgress(dangoMoveInProgress);
		return true;
	}

	// Token: 0x0600526B RID: 21099 RVA: 0x001B6ED0 File Offset: 0x001B50D0
	public bool UpdateMoveOutTick(float delta)
	{
		if (!this.IsMovingOut)
		{
			return false;
		}
		if (this.UpdateMoveOutDelayTick(delta))
		{
			return true;
		}
		if (this.MoveOutDelta >= this.MoveOutTime)
		{
			this.MoveOutEnd();
			return true;
		}
		this.MoveOutDelta += delta;
		float dangoMoveOutProgress = this.MoveOutDelta / this.MoveOutTime;
		this.SetDangoMoveOutProgress(dangoMoveOutProgress);
		return true;
	}

	// Token: 0x0600526C RID: 21100 RVA: 0x001B6F2D File Offset: 0x001B512D
	public bool UpdateMoveOutDelayTick(float delta)
	{
		if (!this.IsMovingOut)
		{
			return false;
		}
		if (this.MoveOutDelayDelta >= this.MoveOutDelayTime)
		{
			return false;
		}
		this.MoveOutDelayDelta += delta;
		return true;
	}

	// Token: 0x0600526D RID: 21101 RVA: 0x001B6F58 File Offset: 0x001B5158
	public void ResetMoveInRecord()
	{
		this.IsMovingIn = false;
		this.MoveInDelta = 0f;
		CustomPromise moveInPromise = this.MoveInPromise;
		if (moveInPromise == null)
		{
			return;
		}
		moveInPromise.SetResult();
	}

	// Token: 0x0600526E RID: 21102 RVA: 0x001B6F7C File Offset: 0x001B517C
	public void ResetMoveOutRecord()
	{
		this.IsMovingOut = false;
		this.MoveOutDelta = 0f;
		this.MoveOutDelayDelta = 0f;
		CustomPromise moveOutPromise = this.MoveOutPromise;
		if (moveOutPromise == null)
		{
			return;
		}
		moveOutPromise.SetResult();
	}

	// Token: 0x0600526F RID: 21103 RVA: 0x001B6FAC File Offset: 0x001B51AC
	public void SetActorListHidden(bool hide, List<TsUiSceneDangoActor> list)
	{
		foreach (TsUiSceneDangoActor tsUiSceneDangoActor in list)
		{
			tsUiSceneDangoActor.SetActorHiddenInGame(hide);
		}
	}

	// Token: 0x06005270 RID: 21104 RVA: 0x001B6FF8 File Offset: 0x001B51F8
	public bool UpdateMoveChangeCheckTick(float delta)
	{
		if (!this.IsMoveChangeCheck)
		{
			return false;
		}
		if (this.MoveChangeCheckDelta >= this.MoveChangeCheckTime)
		{
			this.IsMoveChangeCheck = false;
			this.MoveChangeCheckDelta = 0f;
			this.LoadDangoActorList().Forget();
			return true;
		}
		this.MoveChangeCheckDelta += delta;
		return true;
	}

	// Token: 0x06005271 RID: 21105 RVA: 0x001B704C File Offset: 0x001B524C
	public void PlayJumpAni(List<TsUiSceneDangoActor> list, [Nullable(2)] UCurveFloat curve)
	{
		float totalDistance = this.GetTotalDistance(curve);
		float totalHeight = this.GetTotalHeight(curve);
		this.PlayJumpAniParam(list, totalDistance, totalHeight);
	}

	// Token: 0x06005272 RID: 21106 RVA: 0x001B7074 File Offset: 0x001B5274
	public void PlayJumpAniParam(List<TsUiSceneDangoActor> list, float dis = 0f, float height = 0f)
	{
		foreach (TsUiSceneDangoActor tsUiSceneDangoActor in list)
		{
			tsUiSceneDangoActor.SetState(EDangoState.MoveJump, dis, height);
		}
	}

	// Token: 0x06005273 RID: 21107 RVA: 0x001B70C4 File Offset: 0x001B52C4
	public void ReturnStand(List<TsUiSceneDangoActor> list, string title = "")
	{
		foreach (TsUiSceneDangoActor tsUiSceneDangoActor in list)
		{
			UiDangoStateMachineComponent stateMachine = tsUiSceneDangoActor.GetStateMachine();
			if (stateMachine != null)
			{
				ABP_TuanziNPC_C dangoBp = stateMachine.GetDangoBp();
				if (dangoBp != null)
				{
					dangoBp.ReturnStand();
				}
			}
		}
	}

	// Token: 0x06005274 RID: 21108 RVA: 0x001B7128 File Offset: 0x001B5328
	[Conditional("DEBUG")]
	public void LogDangoAniState(TsUiSceneDangoActor actor, string title = "")
	{
	}

	// Token: 0x06005275 RID: 21109 RVA: 0x001B712A File Offset: 0x001B532A
	[Conditional("DEBUG")]
	public void LogMoveIn(string title)
	{
	}

	// Token: 0x06005276 RID: 21110 RVA: 0x001B712C File Offset: 0x001B532C
	[Conditional("DEBUG")]
	public void LogMoveOut(string title)
	{
	}

	// Token: 0x06005277 RID: 21111 RVA: 0x001B712E File Offset: 0x001B532E
	[Conditional("DEBUG")]
	public void LogMoveChangeCheck(string title)
	{
	}

	// Token: 0x06005278 RID: 21112 RVA: 0x001B7130 File Offset: 0x001B5330
	public void LogInfo()
	{
		string title = "Sum";
		this.LogMovingProcessState(title);
	}

	// Token: 0x06005279 RID: 21113 RVA: 0x001B714A File Offset: 0x001B534A
	public void LogMovingProcessState(string title)
	{
	}

	// Token: 0x04003A46 RID: 14918
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public LoopScrollView<DangoMonopolyResultRoundItem, DangoMonopolyBoardData> RoundScrollView;

	// Token: 0x04003A47 RID: 14919
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public GenericLayout<RewardSmallItemGrid, RewardItemData> RewardScrollView;

	// Token: 0x04003A48 RID: 14920
	[Nullable(2)]
	public DangoMonopolyBoardData ShowBoardData;

	// Token: 0x04003A49 RID: 14921
	[Nullable(2)]
	public DangoMonopolyBoardData LastBoardData;

	// Token: 0x04003A4A RID: 14922
	public List<TsUiSceneDangoActor> ShowDangoActorList = new List<TsUiSceneDangoActor>();

	// Token: 0x04003A4B RID: 14923
	public List<TsUiSceneDangoActor> LastDangoActorList = new List<TsUiSceneDangoActor>();

	// Token: 0x04003A4C RID: 14924
	public Dictionary<int, List<TsUiSceneDangoActor>> DangoActorListMap = new Dictionary<int, List<TsUiSceneDangoActor>>();

	// Token: 0x04003A4D RID: 14925
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public UniTaskCompletionSource<List<TsUiSceneDangoActor>> DangoActorPromise;

	// Token: 0x04003A4E RID: 14926
	public int[] ShowDangoIdList;

	// Token: 0x04003A4F RID: 14927
	[Nullable(2)]
	public CustomPromise MoveDangoPromise;

	// Token: 0x04003A50 RID: 14928
	public readonly float MoveInTime;

	// Token: 0x04003A51 RID: 14929
	public readonly float MoveOutTime;

	// Token: 0x04003A52 RID: 14930
	public readonly float MoveOutDelayTime;

	// Token: 0x04003A53 RID: 14931
	public readonly float MoveChangeCheckTime;

	// Token: 0x04003A54 RID: 14932
	[Nullable(2)]
	public UCurveFloat MoveInCurve;

	// Token: 0x04003A55 RID: 14933
	[Nullable(2)]
	public UCurveFloat MoveOutCurve;

	// Token: 0x04003A56 RID: 14934
	public FVectorDouble TempVec = new FVectorDouble(0.0);

	// Token: 0x04003A57 RID: 14935
	public FVectorDouble ShowVec = new FVectorDouble(0.0);

	// Token: 0x04003A58 RID: 14936
	public readonly string ShowCase = "DangoMonopolyCase";

	// Token: 0x04003A59 RID: 14937
	public bool IsMovingIn;

	// Token: 0x04003A5A RID: 14938
	public bool IsMovingOut;

	// Token: 0x04003A5B RID: 14939
	public bool IsMoveChangeCheck;

	// Token: 0x04003A5C RID: 14940
	public float MoveInDelta;

	// Token: 0x04003A5D RID: 14941
	public float MoveOutDelta;

	// Token: 0x04003A5E RID: 14942
	public float MoveOutDelayDelta;

	// Token: 0x04003A5F RID: 14943
	public float MoveChangeCheckDelta;

	// Token: 0x04003A60 RID: 14944
	[Nullable(2)]
	public CustomPromise MoveInPromise;

	// Token: 0x04003A61 RID: 14945
	[Nullable(2)]
	public CustomPromise MoveOutPromise;

	// Token: 0x04003A62 RID: 14946
	public bool ShowLog;

	// Token: 0x04003A63 RID: 14947
	public int LastChangeId;

	// Token: 0x04003A64 RID: 14948
	public int ShowChangeId;

	// Token: 0x04003A65 RID: 14949
	public bool IsMovingChange;

	// Token: 0x020069D1 RID: 27089
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022D5F RID: 142687
		BtnClose,
		// Token: 0x04022D60 RID: 142688
		LoopScrollRoundList,
		// Token: 0x04022D61 RID: 142689
		ItemRound,
		// Token: 0x04022D62 RID: 142690
		ItemRight,
		// Token: 0x04022D63 RID: 142691
		TxtTitle,
		// Token: 0x04022D64 RID: 142692
		TxtDesc,
		// Token: 0x04022D65 RID: 142693
		GridLayoutRewardList,
		// Token: 0x04022D66 RID: 142694
		ItemReward,
		// Token: 0x04022D67 RID: 142695
		TxtTips,
		// Token: 0x04022D68 RID: 142696
		BtnEmpty,
		// Token: 0x04022D69 RID: 142697
		ItemRewardEmpty,
		// Token: 0x04022D6A RID: 142698
		TxtEmptyTips
	}
}
