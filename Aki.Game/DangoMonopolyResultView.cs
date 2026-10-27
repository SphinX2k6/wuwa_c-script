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

// Token: 0x02001243 RID: 4675
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyResultView : DangoMonopolyViewBase
{
	// Token: 0x17000ABD RID: 2749
	// (get) Token: 0x06007EA6 RID: 32422 RVA: 0x001AD26E File Offset: 0x001AB46E
	[Nullable(2)]
	public new DangoMonopolyResultViewParams OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as DangoMonopolyResultViewParams;
		}
	}

	// Token: 0x06007EA7 RID: 32423 RVA: 0x001AD27C File Offset: 0x001AB47C
	public DangoMonopolyResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.MoveInTime = (float)ActivityDangoMonopolyConfig.Instance.GetDangoMoveInTime();
		this.MoveOutTime = (float)ActivityDangoMonopolyConfig.Instance.GetDangoMoveOutTime();
		this.MoveOutDelayTime = (float)ActivityDangoMonopolyConfig.Instance.GetDangoMoveOutDelayTime();
		this.MoveChangeCheckTime = (float)ActivityDangoMonopolyConfig.Instance.GetDangoChangeCheckTime();
	}

	// Token: 0x06007EA8 RID: 32424 RVA: 0x001AD328 File Offset: 0x001AB528
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

	// Token: 0x06007EA9 RID: 32425 RVA: 0x001AD46E File Offset: 0x001AB66E
	private void InitDataParam()
	{
	}

	// Token: 0x06007EAA RID: 32426 RVA: 0x001AD470 File Offset: 0x001AB670
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.DangoMonopolyEnterNextRound, new Action(this.EventEnterNextRound));
	}

	// Token: 0x06007EAB RID: 32427 RVA: 0x001AD48E File Offset: 0x001AB68E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.DangoMonopolyEnterNextRound, new Action(this.EventEnterNextRound));
	}

	// Token: 0x06007EAC RID: 32428 RVA: 0x001AD4AC File Offset: 0x001AB6AC
	private void EventEnterNextRound()
	{
		this.ActivityData.UpdateBoardGridUiInfoShow(false).Forget();
	}

	// Token: 0x06007EAD RID: 32429 RVA: 0x001AD4C0 File Offset: 0x001AB6C0
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyResultView.<OnBeforeStartAsync>d__41 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyResultView.<OnBeforeStartAsync>d__41>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007EAE RID: 32430 RVA: 0x001AD503 File Offset: 0x001AB703
	protected override void OnStart()
	{
		this.UpdateMoveParam();
		this.ActivityData.UpdateBoardGridUiInfoShow(false).Forget();
		this.InitCurve().Forget();
		this.UpdateData();
	}

	// Token: 0x06007EAF RID: 32431 RVA: 0x001AD52D File Offset: 0x001AB72D
	protected override void OnBeforeShow()
	{
		DangoMonopolyResultViewParams openParam = this.OpenParam;
		if (((openParam != null) ? openParam.ShowPromise : null) != null && this.OpenParam.ShowPromise.IsPending)
		{
			this.OpenParam.ShowPromise.SetResult();
		}
	}

	// Token: 0x06007EB0 RID: 32432 RVA: 0x001AD565 File Offset: 0x001AB765
	protected override void OnAfterShow()
	{
	}

	// Token: 0x06007EB1 RID: 32433 RVA: 0x001AD567 File Offset: 0x001AB767
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

	// Token: 0x06007EB2 RID: 32434 RVA: 0x001AD59F File Offset: 0x001AB79F
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

	// Token: 0x06007EB3 RID: 32435 RVA: 0x001AD5CE File Offset: 0x001AB7CE
	private DangoMonopolyResultRoundItem CreateRoundItem()
	{
		return new DangoMonopolyResultRoundItem
		{
			ClickCallBack = new Action<DangoMonopolyBoardData>(this.OnClickRoundItem)
		};
	}

	// Token: 0x06007EB4 RID: 32436 RVA: 0x001AD5E8 File Offset: 0x001AB7E8
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

	// Token: 0x06007EB5 RID: 32437 RVA: 0x001AD860 File Offset: 0x001ABA60
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

	// Token: 0x06007EB6 RID: 32438 RVA: 0x001AD89B File Offset: 0x001ABA9B
	private RewardSmallItemGrid CreateRewardItem()
	{
		RewardSmallItemGrid rewardSmallItemGrid = new RewardSmallItemGrid();
		rewardSmallItemGrid.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		rewardSmallItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickedRewardItem));
		return rewardSmallItemGrid;
	}

	// Token: 0x06007EB7 RID: 32439 RVA: 0x001AD8DC File Offset: 0x001ABADC
	private void OnClickedRewardItem(MediumItemGridExtendCallback info)
	{
		RewardItemData rewardItemData = info.Data as RewardItemData;
		int itemId = (rewardItemData != null) ? rewardItemData.ConfigId : 0;
		ItemController.Instance.OpenItemTipsByItemId(itemId, true, null);
	}

	// Token: 0x06007EB8 RID: 32440 RVA: 0x001AD910 File Offset: 0x001ABB10
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

	// Token: 0x06007EB9 RID: 32441 RVA: 0x001AD9BC File Offset: 0x001ABBBC
	public UniTask LoadDangoActorList()
	{
		DangoMonopolyResultView.<LoadDangoActorList>d__53 <LoadDangoActorList>d__;
		<LoadDangoActorList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadDangoActorList>d__.<>4__this = this;
		<LoadDangoActorList>d__.<>1__state = -1;
		<LoadDangoActorList>d__.<>t__builder.Start<DangoMonopolyResultView.<LoadDangoActorList>d__53>(ref <LoadDangoActorList>d__);
		return <LoadDangoActorList>d__.<>t__builder.Task;
	}

	// Token: 0x06007EBA RID: 32442 RVA: 0x001ADA00 File Offset: 0x001ABC00
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

	// Token: 0x06007EBB RID: 32443 RVA: 0x001ADA44 File Offset: 0x001ABC44
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

	// Token: 0x06007EBC RID: 32444 RVA: 0x001ADA88 File Offset: 0x001ABC88
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

	// Token: 0x06007EBD RID: 32445 RVA: 0x001ADB18 File Offset: 0x001ABD18
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

	// Token: 0x06007EBE RID: 32446 RVA: 0x001ADB80 File Offset: 0x001ABD80
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

	// Token: 0x06007EBF RID: 32447 RVA: 0x001ADBE8 File Offset: 0x001ABDE8
	public UniTask MoveOutLastDangoList()
	{
		DangoMonopolyResultView.<MoveOutLastDangoList>d__59 <MoveOutLastDangoList>d__;
		<MoveOutLastDangoList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoveOutLastDangoList>d__.<>4__this = this;
		<MoveOutLastDangoList>d__.<>1__state = -1;
		<MoveOutLastDangoList>d__.<>t__builder.Start<DangoMonopolyResultView.<MoveOutLastDangoList>d__59>(ref <MoveOutLastDangoList>d__);
		return <MoveOutLastDangoList>d__.<>t__builder.Task;
	}

	// Token: 0x06007EC0 RID: 32448 RVA: 0x001ADC2C File Offset: 0x001ABE2C
	public UniTask MoveInShowDangoList()
	{
		DangoMonopolyResultView.<MoveInShowDangoList>d__60 <MoveInShowDangoList>d__;
		<MoveInShowDangoList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoveInShowDangoList>d__.<>4__this = this;
		<MoveInShowDangoList>d__.<>1__state = -1;
		<MoveInShowDangoList>d__.<>t__builder.Start<DangoMonopolyResultView.<MoveInShowDangoList>d__60>(ref <MoveInShowDangoList>d__);
		return <MoveInShowDangoList>d__.<>t__builder.Task;
	}

	// Token: 0x06007EC1 RID: 32449 RVA: 0x001ADC70 File Offset: 0x001ABE70
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

	// Token: 0x06007EC2 RID: 32450 RVA: 0x001ADDAC File Offset: 0x001ABFAC
	public UniTask DestroyDangoActor()
	{
		DangoMonopolyResultView.<DestroyDangoActor>d__62 <DestroyDangoActor>d__;
		<DestroyDangoActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DestroyDangoActor>d__.<>4__this = this;
		<DestroyDangoActor>d__.<>1__state = -1;
		<DestroyDangoActor>d__.<>t__builder.Start<DangoMonopolyResultView.<DestroyDangoActor>d__62>(ref <DestroyDangoActor>d__);
		return <DestroyDangoActor>d__.<>t__builder.Task;
	}

	// Token: 0x06007EC3 RID: 32451 RVA: 0x001ADDF0 File Offset: 0x001ABFF0
	public void UpdateMoveParam()
	{
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(this.ShowCase).Value, ECollectActorType.UI);
		if (actorWithTag != null)
		{
			FVectorDouble location = actorWithTag.D_GetTransform().GetLocation();
			this.ShowVec.Set(location.X, location.Y, location.Z);
		}
	}

	// Token: 0x06007EC4 RID: 32452 RVA: 0x001ADE48 File Offset: 0x001AC048
	public UniTask InitCurve()
	{
		DangoMonopolyResultView.<InitCurve>d__64 <InitCurve>d__;
		<InitCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCurve>d__.<>4__this = this;
		<InitCurve>d__.<>1__state = -1;
		<InitCurve>d__.<>t__builder.Start<DangoMonopolyResultView.<InitCurve>d__64>(ref <InitCurve>d__);
		return <InitCurve>d__.<>t__builder.Task;
	}

	// Token: 0x06007EC5 RID: 32453 RVA: 0x001ADE8C File Offset: 0x001AC08C
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

	// Token: 0x06007EC6 RID: 32454 RVA: 0x001ADED0 File Offset: 0x001AC0D0
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

	// Token: 0x06007EC7 RID: 32455 RVA: 0x001ADF1C File Offset: 0x001AC11C
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

	// Token: 0x06007EC8 RID: 32456 RVA: 0x001ADF64 File Offset: 0x001AC164
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

	// Token: 0x06007EC9 RID: 32457 RVA: 0x001AE04E File Offset: 0x001AC24E
	public void SetDangoMoveInProgress(float percent)
	{
		this.SetDangoMoveProgress(percent, true, this.MoveInCurve, this.ShowDangoActorList);
	}

	// Token: 0x06007ECA RID: 32458 RVA: 0x001AE064 File Offset: 0x001AC264
	public void SetDangoMoveOutProgress(float percent)
	{
		this.SetDangoMoveProgress(percent, false, this.MoveOutCurve, this.LastDangoActorList);
	}

	// Token: 0x06007ECB RID: 32459 RVA: 0x001AE07A File Offset: 0x001AC27A
	protected override void OnBeforeShowImplementImplement()
	{
		UiManager.Instance.AddTickView(this);
	}

	// Token: 0x06007ECC RID: 32460 RVA: 0x001AE087 File Offset: 0x001AC287
	protected override void OnAfterHideImplementImplement()
	{
		UiManager.Instance.RemoveTickView(this);
		this.MoveInEnd();
		this.MoveOutEnd();
	}

	// Token: 0x06007ECD RID: 32461 RVA: 0x001AE0A2 File Offset: 0x001AC2A2
	protected override void OnTick(float delta)
	{
		this.UpdateMoveInTick(delta);
		this.UpdateMoveOutTick(delta);
		this.UpdateMoveChangeCheckTick(delta);
	}

	// Token: 0x06007ECE RID: 32462 RVA: 0x001AE0BC File Offset: 0x001AC2BC
	protected void OnAfterTick()
	{
	}

	// Token: 0x06007ECF RID: 32463 RVA: 0x001AE0C0 File Offset: 0x001AC2C0
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

	// Token: 0x06007ED0 RID: 32464 RVA: 0x001AE114 File Offset: 0x001AC314
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

	// Token: 0x06007ED1 RID: 32465 RVA: 0x001AE17E File Offset: 0x001AC37E
	public bool MoveInEnd()
	{
		if (!this.IsMovingIn)
		{
			return false;
		}
		this.ResetMoveInRecord();
		return true;
	}

	// Token: 0x06007ED2 RID: 32466 RVA: 0x001AE191 File Offset: 0x001AC391
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

	// Token: 0x06007ED3 RID: 32467 RVA: 0x001AE1C4 File Offset: 0x001AC3C4
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

	// Token: 0x06007ED4 RID: 32468 RVA: 0x001AE218 File Offset: 0x001AC418
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

	// Token: 0x06007ED5 RID: 32469 RVA: 0x001AE275 File Offset: 0x001AC475
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

	// Token: 0x06007ED6 RID: 32470 RVA: 0x001AE2A0 File Offset: 0x001AC4A0
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

	// Token: 0x06007ED7 RID: 32471 RVA: 0x001AE2C4 File Offset: 0x001AC4C4
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

	// Token: 0x06007ED8 RID: 32472 RVA: 0x001AE2F4 File Offset: 0x001AC4F4
	public void SetActorListHidden(bool hide, List<TsUiSceneDangoActor> list)
	{
		foreach (TsUiSceneDangoActor tsUiSceneDangoActor in list)
		{
			tsUiSceneDangoActor.SetActorHiddenInGame(hide);
		}
	}

	// Token: 0x06007ED9 RID: 32473 RVA: 0x001AE340 File Offset: 0x001AC540
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

	// Token: 0x06007EDA RID: 32474 RVA: 0x001AE394 File Offset: 0x001AC594
	public void PlayJumpAni(List<TsUiSceneDangoActor> list, [Nullable(2)] UCurveFloat curve)
	{
		float totalDistance = this.GetTotalDistance(curve);
		float totalHeight = this.GetTotalHeight(curve);
		this.PlayJumpAniParam(list, totalDistance, totalHeight);
	}

	// Token: 0x06007EDB RID: 32475 RVA: 0x001AE3BC File Offset: 0x001AC5BC
	public void PlayJumpAniParam(List<TsUiSceneDangoActor> list, float dis = 0f, float height = 0f)
	{
		foreach (TsUiSceneDangoActor tsUiSceneDangoActor in list)
		{
			tsUiSceneDangoActor.SetState(EDangoState.MoveJump, dis, height);
		}
	}

	// Token: 0x06007EDC RID: 32476 RVA: 0x001AE40C File Offset: 0x001AC60C
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

	// Token: 0x06007EDD RID: 32477 RVA: 0x001AE470 File Offset: 0x001AC670
	[Conditional("DEBUG")]
	public void LogDangoAniState(TsUiSceneDangoActor actor, string title = "")
	{
	}

	// Token: 0x06007EDE RID: 32478 RVA: 0x001AE472 File Offset: 0x001AC672
	[Conditional("DEBUG")]
	public void LogMoveIn(string title)
	{
	}

	// Token: 0x06007EDF RID: 32479 RVA: 0x001AE474 File Offset: 0x001AC674
	[Conditional("DEBUG")]
	public void LogMoveOut(string title)
	{
	}

	// Token: 0x06007EE0 RID: 32480 RVA: 0x001AE476 File Offset: 0x001AC676
	[Conditional("DEBUG")]
	public void LogMoveChangeCheck(string title)
	{
	}

	// Token: 0x06007EE1 RID: 32481 RVA: 0x001AE478 File Offset: 0x001AC678
	public void LogInfo()
	{
		string title = "Sum";
		this.LogMovingProcessState(title);
	}

	// Token: 0x06007EE2 RID: 32482 RVA: 0x001AE492 File Offset: 0x001AC692
	public void LogMovingProcessState(string title)
	{
	}

	// Token: 0x040039AE RID: 14766
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public LoopScrollView<DangoMonopolyResultRoundItem, DangoMonopolyBoardData> RoundScrollView;

	// Token: 0x040039AF RID: 14767
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public GenericLayout<RewardSmallItemGrid, RewardItemData> RewardScrollView;

	// Token: 0x040039B0 RID: 14768
	[Nullable(2)]
	public DangoMonopolyBoardData ShowBoardData;

	// Token: 0x040039B1 RID: 14769
	[Nullable(2)]
	public DangoMonopolyBoardData LastBoardData;

	// Token: 0x040039B2 RID: 14770
	public List<TsUiSceneDangoActor> ShowDangoActorList = new List<TsUiSceneDangoActor>();

	// Token: 0x040039B3 RID: 14771
	public List<TsUiSceneDangoActor> LastDangoActorList = new List<TsUiSceneDangoActor>();

	// Token: 0x040039B4 RID: 14772
	public Dictionary<int, List<TsUiSceneDangoActor>> DangoActorListMap = new Dictionary<int, List<TsUiSceneDangoActor>>();

	// Token: 0x040039B5 RID: 14773
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public UniTaskCompletionSource<List<TsUiSceneDangoActor>> DangoActorPromise;

	// Token: 0x040039B6 RID: 14774
	public int[] ShowDangoIdList;

	// Token: 0x040039B7 RID: 14775
	[Nullable(2)]
	public CustomPromise MoveDangoPromise;

	// Token: 0x040039B8 RID: 14776
	public readonly float MoveInTime;

	// Token: 0x040039B9 RID: 14777
	public readonly float MoveOutTime;

	// Token: 0x040039BA RID: 14778
	public readonly float MoveOutDelayTime;

	// Token: 0x040039BB RID: 14779
	public readonly float MoveChangeCheckTime;

	// Token: 0x040039BC RID: 14780
	[Nullable(2)]
	public UCurveFloat MoveInCurve;

	// Token: 0x040039BD RID: 14781
	[Nullable(2)]
	public UCurveFloat MoveOutCurve;

	// Token: 0x040039BE RID: 14782
	public FVectorDouble TempVec = new FVectorDouble(0.0);

	// Token: 0x040039BF RID: 14783
	public FVectorDouble ShowVec = new FVectorDouble(0.0);

	// Token: 0x040039C0 RID: 14784
	public readonly string ShowCase = "DangoMonopolyCase";

	// Token: 0x040039C1 RID: 14785
	public bool IsMovingIn;

	// Token: 0x040039C2 RID: 14786
	public bool IsMovingOut;

	// Token: 0x040039C3 RID: 14787
	public bool IsMoveChangeCheck;

	// Token: 0x040039C4 RID: 14788
	public float MoveInDelta;

	// Token: 0x040039C5 RID: 14789
	public float MoveOutDelta;

	// Token: 0x040039C6 RID: 14790
	public float MoveOutDelayDelta;

	// Token: 0x040039C7 RID: 14791
	public float MoveChangeCheckDelta;

	// Token: 0x040039C8 RID: 14792
	[Nullable(2)]
	public CustomPromise MoveInPromise;

	// Token: 0x040039C9 RID: 14793
	[Nullable(2)]
	public CustomPromise MoveOutPromise;

	// Token: 0x040039CA RID: 14794
	public bool ShowLog;

	// Token: 0x040039CB RID: 14795
	public int LastChangeId;

	// Token: 0x040039CC RID: 14796
	public int ShowChangeId;

	// Token: 0x040039CD RID: 14797
	public bool IsMovingChange;

	// Token: 0x02007846 RID: 30790
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04027A2E RID: 162350
		BtnClose,
		// Token: 0x04027A2F RID: 162351
		LoopScrollRoundList,
		// Token: 0x04027A30 RID: 162352
		ItemRound,
		// Token: 0x04027A31 RID: 162353
		ItemRight,
		// Token: 0x04027A32 RID: 162354
		TxtTitle,
		// Token: 0x04027A33 RID: 162355
		TxtDesc,
		// Token: 0x04027A34 RID: 162356
		GridLayoutRewardList,
		// Token: 0x04027A35 RID: 162357
		ItemReward,
		// Token: 0x04027A36 RID: 162358
		TxtTips,
		// Token: 0x04027A37 RID: 162359
		BtnEmpty,
		// Token: 0x04027A38 RID: 162360
		ItemRewardEmpty,
		// Token: 0x04027A39 RID: 162361
		TxtEmptyTips
	}
}
