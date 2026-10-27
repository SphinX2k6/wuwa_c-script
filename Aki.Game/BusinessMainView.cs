using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012FF RID: 4863
[NullableContext(1)]
[Nullable(0)]
public class BusinessMainView : UiViewBase
{
	// Token: 0x060086A5 RID: 34469 RVA: 0x001CBB51 File Offset: 0x001C9D51
	public BusinessMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060086A6 RID: 34470 RVA: 0x001CBB70 File Offset: 0x001C9D70
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
	}

	// Token: 0x060086A7 RID: 34471 RVA: 0x001CBC94 File Offset: 0x001C9E94
	private UniTask InitPopularity()
	{
		BusinessMainView.<InitPopularity>d__12 <InitPopularity>d__;
		<InitPopularity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPopularity>d__.<>4__this = this;
		<InitPopularity>d__.<>1__state = -1;
		<InitPopularity>d__.<>t__builder.Start<BusinessMainView.<InitPopularity>d__12>(ref <InitPopularity>d__);
		return <InitPopularity>d__.<>t__builder.Task;
	}

	// Token: 0x060086A8 RID: 34472 RVA: 0x001CBCD8 File Offset: 0x001C9ED8
	private UniTask InitCaptionItem()
	{
		BusinessMainView.<InitCaptionItem>d__13 <InitCaptionItem>d__;
		<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaptionItem>d__.<>4__this = this;
		<InitCaptionItem>d__.<>1__state = -1;
		<InitCaptionItem>d__.<>t__builder.Start<BusinessMainView.<InitCaptionItem>d__13>(ref <InitCaptionItem>d__);
		return <InitCaptionItem>d__.<>t__builder.Task;
	}

	// Token: 0x060086A9 RID: 34473 RVA: 0x001CBD1C File Offset: 0x001C9F1C
	private UniTask InitNonDetailsModule(UUIItem item)
	{
		BusinessMainView.<InitNonDetailsModule>d__14 <InitNonDetailsModule>d__;
		<InitNonDetailsModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitNonDetailsModule>d__.<>4__this = this;
		<InitNonDetailsModule>d__.item = item;
		<InitNonDetailsModule>d__.<>1__state = -1;
		<InitNonDetailsModule>d__.<>t__builder.Start<BusinessMainView.<InitNonDetailsModule>d__14>(ref <InitNonDetailsModule>d__);
		return <InitNonDetailsModule>d__.<>t__builder.Task;
	}

	// Token: 0x060086AA RID: 34474 RVA: 0x001CBD68 File Offset: 0x001C9F68
	private UniTask InitSkipItem()
	{
		BusinessMainView.<InitSkipItem>d__15 <InitSkipItem>d__;
		<InitSkipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSkipItem>d__.<>4__this = this;
		<InitSkipItem>d__.<>1__state = -1;
		<InitSkipItem>d__.<>t__builder.Start<BusinessMainView.<InitSkipItem>d__15>(ref <InitSkipItem>d__);
		return <InitSkipItem>d__.<>t__builder.Task;
	}

	// Token: 0x060086AB RID: 34475 RVA: 0x001CBDAC File Offset: 0x001C9FAC
	private UniTask InitDelegationDetailsModule()
	{
		BusinessMainView.<InitDelegationDetailsModule>d__16 <InitDelegationDetailsModule>d__;
		<InitDelegationDetailsModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDelegationDetailsModule>d__.<>4__this = this;
		<InitDelegationDetailsModule>d__.<>1__state = -1;
		<InitDelegationDetailsModule>d__.<>t__builder.Start<BusinessMainView.<InitDelegationDetailsModule>d__16>(ref <InitDelegationDetailsModule>d__);
		return <InitDelegationDetailsModule>d__.<>t__builder.Task;
	}

	// Token: 0x060086AC RID: 34476 RVA: 0x001CBDF0 File Offset: 0x001C9FF0
	private void InitBtnItem()
	{
		this.BuildBtn = new ButtonItem(base.GetItem(0));
		this.BuildBtn.SetFunction(delegate(int _)
		{
			this.Vc.SkipToBuild();
		});
		this.HelperBtn = new ButtonItem(base.GetItem(1));
		this.HelperBtn.SetFunction(delegate(int _)
		{
			this.Vc.SkipToHelper();
		});
	}

	// Token: 0x060086AD RID: 34477 RVA: 0x001CBE50 File Offset: 0x001CA050
	private UniTask InitNonDetailsList()
	{
		BusinessMainView.<InitNonDetailsList>d__18 <InitNonDetailsList>d__;
		<InitNonDetailsList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitNonDetailsList>d__.<>4__this = this;
		<InitNonDetailsList>d__.<>1__state = -1;
		<InitNonDetailsList>d__.<>t__builder.Start<BusinessMainView.<InitNonDetailsList>d__18>(ref <InitNonDetailsList>d__);
		return <InitNonDetailsList>d__.<>t__builder.Task;
	}

	// Token: 0x060086AE RID: 34478 RVA: 0x001CBE94 File Offset: 0x001CA094
	private void RefreshNonDetailsList()
	{
		List<DelegationData> delegationDataList = MoonChasingBusinessModel.Instance.GetDelegationDataList();
		for (int i = 0; i < this.NonDetailsList.Count; i++)
		{
			DelegationNonDetailsModule delegationNonDetailsModule = this.NonDetailsList[i];
			if (i < delegationDataList.Count)
			{
				delegationNonDetailsModule.Refresh(delegationDataList[i]);
			}
			else
			{
				delegationNonDetailsModule.SetActive(false);
			}
		}
	}

	// Token: 0x060086AF RID: 34479 RVA: 0x001CBEF0 File Offset: 0x001CA0F0
	private void RefreshNonDetailsListConsume()
	{
		List<DelegationData> delegationDataList = MoonChasingBusinessModel.Instance.GetDelegationDataList();
		for (int i = 0; i < this.NonDetailsList.Count; i++)
		{
			DelegationNonDetailsModule delegationNonDetailsModule = this.NonDetailsList[i];
			if (i < delegationDataList.Count)
			{
				delegationNonDetailsModule.RefreshConsume();
			}
		}
	}

	// Token: 0x060086B0 RID: 34480 RVA: 0x001CBF3C File Offset: 0x001CA13C
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessMainView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessMainView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060086B1 RID: 34481 RVA: 0x001CBF80 File Offset: 0x001CA180
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		BusinessMainView.<OnBeforeShowAsyncImplementImplement>d__22 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<BusinessMainView.<OnBeforeShowAsyncImplementImplement>d__22>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x060086B2 RID: 34482 RVA: 0x001CBFC3 File Offset: 0x001CA1C3
	protected override void OnBeforeShow()
	{
		this.Vc.Show();
		this.RefreshRedDot();
		ActivityMoonChasingController.Instance.CheckIsActivityClose();
	}

	// Token: 0x060086B3 RID: 34483 RVA: 0x001CBFE0 File Offset: 0x001CA1E0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OpenTipsTravelView, new Action(this.BackToMainView));
		EventSystem.Instance.Add(EEventName.UnlockMoonChasingData, new Action(this.UnlockMoonChasingData));
		EventSystem.Instance.Add<bool>(EEventName.RefreshDelegate, new Action<bool>(this.RefreshDelegate));
		EventSystem.Instance.Add(EEventName.BusinessInvestResult, new Action(this.RefreshDelegateConsume));
		EventSystem.Instance.Add(EEventName.ConditionUnlockRole, new Action(this.ConditionUnlockRole));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.CloseView));
	}

	// Token: 0x060086B4 RID: 34484 RVA: 0x001CC094 File Offset: 0x001CA294
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OpenTipsTravelView, new Action(this.BackToMainView));
		EventSystem.Instance.Remove(EEventName.UnlockMoonChasingData, new Action(this.UnlockMoonChasingData));
		EventSystem.Instance.Remove<bool>(EEventName.RefreshDelegate, new Action<bool>(this.RefreshDelegate));
		EventSystem.Instance.Remove(EEventName.BusinessInvestResult, new Action(this.RefreshDelegateConsume));
		EventSystem.Instance.Remove(EEventName.ConditionUnlockRole, new Action(this.ConditionUnlockRole));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.CloseView));
	}

	// Token: 0x060086B5 RID: 34485 RVA: 0x001CC146 File Offset: 0x001CA346
	protected override void OnBeforeDestroy()
	{
		MoonChasingBusinessModel.Instance.SetIsInDelegate(false);
	}

	// Token: 0x060086B6 RID: 34486 RVA: 0x001CC154 File Offset: 0x001CA354
	private void ConditionUnlockRole()
	{
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		if (!MoonChasingBusinessModel.Instance.IsUnlockRoleIdEmpty())
		{
			return;
		}
		if (!this.IsRefreshFromServer)
		{
			return;
		}
		this.IsRefreshFromServer = true;
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Refresh", false, null);
	}

	// Token: 0x060086B7 RID: 34487 RVA: 0x001CC1B4 File Offset: 0x001CA3B4
	private void CloseView(EUiViewName viewName, int _)
	{
		if (viewName == EUiViewName.MoonChasingUnlockRoleView)
		{
			if (!this.IsRefreshFromServer)
			{
				return;
			}
			this.IsRefreshFromServer = true;
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequence("Refresh", false, null);
		}
	}

	// Token: 0x060086B8 RID: 34488 RVA: 0x001CC1FD File Offset: 0x001CA3FD
	private void BackToMainView()
	{
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		this.Vc.BackToState(EBusinessSkipDefine.MainView);
	}

	// Token: 0x060086B9 RID: 34489 RVA: 0x001CC21F File Offset: 0x001CA41F
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 1)
		{
			return null;
		}
		if (!(configParams[0] == "Delegation".ToString()))
		{
			return null;
		}
		DelegationDetailsModule details = this.Details;
		if (details == null)
		{
			return null;
		}
		return details.GetGuideUiItemAndUiItemForShowEx(configParams);
	}

	// Token: 0x060086BA RID: 34490 RVA: 0x001CC251 File Offset: 0x001CA451
	private void UnlockMoonChasingData()
	{
		this.RefreshSkipItem();
	}

	// Token: 0x060086BB RID: 34491 RVA: 0x001CC259 File Offset: 0x001CA459
	private void RefreshDelegate(bool isReplace)
	{
		if (isReplace)
		{
			this.IsRefreshFromServer = true;
			this.RefreshNonDetailsList();
		}
		else
		{
			this.RefreshNonDetailsListConsume();
		}
		this.Popularity.RefreshPopularity();
	}

	// Token: 0x060086BC RID: 34492 RVA: 0x001CC27E File Offset: 0x001CA47E
	private void RefreshDelegateConsume()
	{
		this.RefreshNonDetailsListConsume();
		this.Popularity.RefreshPopularity();
	}

	// Token: 0x060086BD RID: 34493 RVA: 0x001CC294 File Offset: 0x001CA494
	private UniTask ShowDelegation(int delegateId)
	{
		BusinessMainView.<ShowDelegation>d__34 <ShowDelegation>d__;
		<ShowDelegation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowDelegation>d__.<>4__this = this;
		<ShowDelegation>d__.delegateId = delegateId;
		<ShowDelegation>d__.<>1__state = -1;
		<ShowDelegation>d__.<>t__builder.Start<BusinessMainView.<ShowDelegation>d__34>(ref <ShowDelegation>d__);
		return <ShowDelegation>d__.<>t__builder.Task;
	}

	// Token: 0x060086BE RID: 34494 RVA: 0x001CC2E0 File Offset: 0x001CA4E0
	private void RefreshSkipItem()
	{
		MoonChasingModel instance = MoonChasingModel.Instance;
		ValueTuple<EMoonChasingUnlockType, int>? valueTuple = (instance != null) ? instance.GetFirstUnlockData() : null;
		if (valueTuple == null)
		{
			this.SkipItem.SetActive(false);
			return;
		}
		this.SkipItem.SetActive(true);
		this.SkipItem.Refresh();
	}

	// Token: 0x060086BF RID: 34495 RVA: 0x001CC334 File Offset: 0x001CA534
	public void SkipToMainView()
	{
		this.RefreshNonDetailsList();
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		this.CaptionItem.SetTitleIconByResourceId("SP_ChasingMoonIcon3").Forget();
		base.PlaySequenceAsync("SwitchOut", true, false, null).ContinueWith(delegate()
		{
			DelegationDetailsModule details = this.Details;
			if (details == null)
			{
				return;
			}
			details.SetActive(false);
		}).Forget();
	}

	// Token: 0x060086C0 RID: 34496 RVA: 0x001CC39C File Offset: 0x001CA59C
	public void SkipToDelegationDetails(params object[] params_)
	{
		int delegateId = (int)params_[0];
		this.ShowDelegation(delegateId).Forget();
		this.CaptionItem.SetTitleIconByResourceId("SP_ChasingMoonIcon7").Forget();
		base.PlaySequenceAsync("SwitchIn", true, false, null).ContinueWith(delegate()
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}).Forget();
	}

	// Token: 0x060086C1 RID: 34497 RVA: 0x001CC400 File Offset: 0x001CA600
	public UniTask BeforeShowAsync(bool inMainView)
	{
		BusinessMainView.<BeforeShowAsync>d__38 <BeforeShowAsync>d__;
		<BeforeShowAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BeforeShowAsync>d__.<>4__this = this;
		<BeforeShowAsync>d__.inMainView = inMainView;
		<BeforeShowAsync>d__.<>1__state = -1;
		<BeforeShowAsync>d__.<>t__builder.Start<BusinessMainView.<BeforeShowAsync>d__38>(ref <BeforeShowAsync>d__);
		return <BeforeShowAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060086C2 RID: 34498 RVA: 0x001CC44B File Offset: 0x001CA64B
	public void Refresh()
	{
		this.RefreshSkipItem();
	}

	// Token: 0x060086C3 RID: 34499 RVA: 0x001CC453 File Offset: 0x001CA653
	public void RefreshRedDot()
	{
		this.BuildBtn.BindRedDot(ERedDotName.MoonChasingBuilding, 0);
		this.HelperBtn.BindRedDot(ERedDotName.MoonChasingRole, 0);
	}

	// Token: 0x060086C4 RID: 34500 RVA: 0x001CC477 File Offset: 0x001CA677
	public void SwitchShowViewSequence(bool inMainView)
	{
		if (inMainView)
		{
			this.UiViewSequence.ShowSequenceName = "ShowView";
			return;
		}
		this.UiViewSequence.ShowSequenceName = "ShowView01";
	}

	// Token: 0x04003C35 RID: 15413
	[Nullable(2)]
	protected DelegationDetailsModule Details;

	// Token: 0x04003C36 RID: 15414
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04003C37 RID: 15415
	private PopularityModule Popularity;

	// Token: 0x04003C38 RID: 15416
	protected List<DelegationNonDetailsModule> NonDetailsList = new List<DelegationNonDetailsModule>();

	// Token: 0x04003C39 RID: 15417
	protected BusinessSkipItem SkipItem;

	// Token: 0x04003C3A RID: 15418
	private ButtonItem BuildBtn;

	// Token: 0x04003C3B RID: 15419
	private ButtonItem HelperBtn;

	// Token: 0x04003C3C RID: 15420
	private bool IsRefreshFromServer;

	// Token: 0x04003C3D RID: 15421
	private readonly BusinessViewController Vc = new BusinessViewController();

	// Token: 0x0200792D RID: 31021
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027EC1 RID: 163521
		public const int BuildBtn = 0;

		// Token: 0x04027EC2 RID: 163522
		public const int HelperBtn = 1;

		// Token: 0x04027EC3 RID: 163523
		public const int CaptionItem = 2;

		// Token: 0x04027EC4 RID: 163524
		public const int GridOne = 3;

		// Token: 0x04027EC5 RID: 163525
		public const int GridTwo = 4;

		// Token: 0x04027EC6 RID: 163526
		public const int GridThird = 5;

		// Token: 0x04027EC7 RID: 163527
		public const int GridFour = 6;

		// Token: 0x04027EC8 RID: 163528
		public const int MainItem = 7;

		// Token: 0x04027EC9 RID: 163529
		public const int ContentItem = 8;

		// Token: 0x04027ECA RID: 163530
		public const int PopularityItem = 9;

		// Token: 0x04027ECB RID: 163531
		public const int SkipItem = 10;

		// Token: 0x04027ECC RID: 163532
		public const int MaskItem = 11;
	}
}
