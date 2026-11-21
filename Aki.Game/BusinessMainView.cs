using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007B3 RID: 1971
[NullableContext(1)]
[Nullable(0)]
public class BusinessMainView : UiViewBase
{
	// Token: 0x06005A40 RID: 23104 RVA: 0x001D49BD File Offset: 0x001D2BBD
	public BusinessMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06005A41 RID: 23105 RVA: 0x001D49DC File Offset: 0x001D2BDC
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

	// Token: 0x06005A42 RID: 23106 RVA: 0x001D4B00 File Offset: 0x001D2D00
	private UniTask InitPopularity()
	{
		BusinessMainView.<InitPopularity>d__12 <InitPopularity>d__;
		<InitPopularity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitPopularity>d__.<>4__this = this;
		<InitPopularity>d__.<>1__state = -1;
		<InitPopularity>d__.<>t__builder.Start<BusinessMainView.<InitPopularity>d__12>(ref <InitPopularity>d__);
		return <InitPopularity>d__.<>t__builder.Task;
	}

	// Token: 0x06005A43 RID: 23107 RVA: 0x001D4B44 File Offset: 0x001D2D44
	private UniTask InitCaptionItem()
	{
		BusinessMainView.<InitCaptionItem>d__13 <InitCaptionItem>d__;
		<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaptionItem>d__.<>4__this = this;
		<InitCaptionItem>d__.<>1__state = -1;
		<InitCaptionItem>d__.<>t__builder.Start<BusinessMainView.<InitCaptionItem>d__13>(ref <InitCaptionItem>d__);
		return <InitCaptionItem>d__.<>t__builder.Task;
	}

	// Token: 0x06005A44 RID: 23108 RVA: 0x001D4B88 File Offset: 0x001D2D88
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

	// Token: 0x06005A45 RID: 23109 RVA: 0x001D4BD4 File Offset: 0x001D2DD4
	private UniTask InitSkipItem()
	{
		BusinessMainView.<InitSkipItem>d__15 <InitSkipItem>d__;
		<InitSkipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSkipItem>d__.<>4__this = this;
		<InitSkipItem>d__.<>1__state = -1;
		<InitSkipItem>d__.<>t__builder.Start<BusinessMainView.<InitSkipItem>d__15>(ref <InitSkipItem>d__);
		return <InitSkipItem>d__.<>t__builder.Task;
	}

	// Token: 0x06005A46 RID: 23110 RVA: 0x001D4C18 File Offset: 0x001D2E18
	private UniTask InitDelegationDetailsModule()
	{
		BusinessMainView.<InitDelegationDetailsModule>d__16 <InitDelegationDetailsModule>d__;
		<InitDelegationDetailsModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDelegationDetailsModule>d__.<>4__this = this;
		<InitDelegationDetailsModule>d__.<>1__state = -1;
		<InitDelegationDetailsModule>d__.<>t__builder.Start<BusinessMainView.<InitDelegationDetailsModule>d__16>(ref <InitDelegationDetailsModule>d__);
		return <InitDelegationDetailsModule>d__.<>t__builder.Task;
	}

	// Token: 0x06005A47 RID: 23111 RVA: 0x001D4C5C File Offset: 0x001D2E5C
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

	// Token: 0x06005A48 RID: 23112 RVA: 0x001D4CBC File Offset: 0x001D2EBC
	private UniTask InitNonDetailsList()
	{
		BusinessMainView.<InitNonDetailsList>d__18 <InitNonDetailsList>d__;
		<InitNonDetailsList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitNonDetailsList>d__.<>4__this = this;
		<InitNonDetailsList>d__.<>1__state = -1;
		<InitNonDetailsList>d__.<>t__builder.Start<BusinessMainView.<InitNonDetailsList>d__18>(ref <InitNonDetailsList>d__);
		return <InitNonDetailsList>d__.<>t__builder.Task;
	}

	// Token: 0x06005A49 RID: 23113 RVA: 0x001D4D00 File Offset: 0x001D2F00
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

	// Token: 0x06005A4A RID: 23114 RVA: 0x001D4D5C File Offset: 0x001D2F5C
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

	// Token: 0x06005A4B RID: 23115 RVA: 0x001D4DA8 File Offset: 0x001D2FA8
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessMainView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessMainView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005A4C RID: 23116 RVA: 0x001D4DEC File Offset: 0x001D2FEC
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		BusinessMainView.<OnBeforeShowAsyncImplementImplement>d__22 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<BusinessMainView.<OnBeforeShowAsyncImplementImplement>d__22>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06005A4D RID: 23117 RVA: 0x001D4E2F File Offset: 0x001D302F
	protected override void OnBeforeShow()
	{
		this.Vc.Show();
		this.RefreshRedDot();
		ActivityMoonChasingController.Instance.CheckIsActivityClose();
	}

	// Token: 0x06005A4E RID: 23118 RVA: 0x001D4E4C File Offset: 0x001D304C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OpenTipsTravelView, new Action(this.BackToMainView));
		EventSystem.Instance.Add(EEventName.UnlockMoonChasingData, new Action(this.UnlockMoonChasingData));
		EventSystem.Instance.Add<bool>(EEventName.RefreshDelegate, new Action<bool>(this.RefreshDelegate));
		EventSystem.Instance.Add(EEventName.BusinessInvestResult, new Action(this.RefreshDelegateConsume));
		EventSystem.Instance.Add(EEventName.ConditionUnlockRole, new Action(this.ConditionUnlockRole));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.CloseView));
	}

	// Token: 0x06005A4F RID: 23119 RVA: 0x001D4F00 File Offset: 0x001D3100
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OpenTipsTravelView, new Action(this.BackToMainView));
		EventSystem.Instance.Remove(EEventName.UnlockMoonChasingData, new Action(this.UnlockMoonChasingData));
		EventSystem.Instance.Remove<bool>(EEventName.RefreshDelegate, new Action<bool>(this.RefreshDelegate));
		EventSystem.Instance.Remove(EEventName.BusinessInvestResult, new Action(this.RefreshDelegateConsume));
		EventSystem.Instance.Remove(EEventName.ConditionUnlockRole, new Action(this.ConditionUnlockRole));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.CloseView));
	}

	// Token: 0x06005A50 RID: 23120 RVA: 0x001D4FB2 File Offset: 0x001D31B2
	protected override void OnBeforeDestroy()
	{
		MoonChasingBusinessModel.Instance.SetIsInDelegate(false);
	}

	// Token: 0x06005A51 RID: 23121 RVA: 0x001D4FC0 File Offset: 0x001D31C0
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

	// Token: 0x06005A52 RID: 23122 RVA: 0x001D5020 File Offset: 0x001D3220
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

	// Token: 0x06005A53 RID: 23123 RVA: 0x001D5069 File Offset: 0x001D3269
	private void BackToMainView()
	{
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		this.Vc.BackToState(EBusinessSkipDefine.MainView);
	}

	// Token: 0x06005A54 RID: 23124 RVA: 0x001D508B File Offset: 0x001D328B
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

	// Token: 0x06005A55 RID: 23125 RVA: 0x001D50BD File Offset: 0x001D32BD
	private void UnlockMoonChasingData()
	{
		this.RefreshSkipItem();
	}

	// Token: 0x06005A56 RID: 23126 RVA: 0x001D50C5 File Offset: 0x001D32C5
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

	// Token: 0x06005A57 RID: 23127 RVA: 0x001D50EA File Offset: 0x001D32EA
	private void RefreshDelegateConsume()
	{
		this.RefreshNonDetailsListConsume();
		this.Popularity.RefreshPopularity();
	}

	// Token: 0x06005A58 RID: 23128 RVA: 0x001D5100 File Offset: 0x001D3300
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

	// Token: 0x06005A59 RID: 23129 RVA: 0x001D514C File Offset: 0x001D334C
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

	// Token: 0x06005A5A RID: 23130 RVA: 0x001D51A0 File Offset: 0x001D33A0
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

	// Token: 0x06005A5B RID: 23131 RVA: 0x001D5208 File Offset: 0x001D3408
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

	// Token: 0x06005A5C RID: 23132 RVA: 0x001D526C File Offset: 0x001D346C
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

	// Token: 0x06005A5D RID: 23133 RVA: 0x001D52B7 File Offset: 0x001D34B7
	public void Refresh()
	{
		this.RefreshSkipItem();
	}

	// Token: 0x06005A5E RID: 23134 RVA: 0x001D52BF File Offset: 0x001D34BF
	public void RefreshRedDot()
	{
		this.BuildBtn.BindRedDot(ERedDotName.MoonChasingBuilding, 0);
		this.HelperBtn.BindRedDot(ERedDotName.MoonChasingRole, 0);
	}

	// Token: 0x06005A5F RID: 23135 RVA: 0x001D52E3 File Offset: 0x001D34E3
	public void SwitchShowViewSequence(bool inMainView)
	{
		if (inMainView)
		{
			this.UiViewSequence.ShowSequenceName = "ShowView";
			return;
		}
		this.UiViewSequence.ShowSequenceName = "ShowView01";
	}

	// Token: 0x04003CCD RID: 15565
	[Nullable(2)]
	protected DelegationDetailsModule Details;

	// Token: 0x04003CCE RID: 15566
	[Nullable(2)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04003CCF RID: 15567
	private PopularityModule Popularity;

	// Token: 0x04003CD0 RID: 15568
	protected List<DelegationNonDetailsModule> NonDetailsList = new List<DelegationNonDetailsModule>();

	// Token: 0x04003CD1 RID: 15569
	protected BusinessSkipItem SkipItem;

	// Token: 0x04003CD2 RID: 15570
	private ButtonItem BuildBtn;

	// Token: 0x04003CD3 RID: 15571
	private ButtonItem HelperBtn;

	// Token: 0x04003CD4 RID: 15572
	private bool IsRefreshFromServer;

	// Token: 0x04003CD5 RID: 15573
	private readonly BusinessViewController Vc = new BusinessViewController();

	// Token: 0x02006AB7 RID: 27319
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x040231EE RID: 143854
		public const int BuildBtn = 0;

		// Token: 0x040231EF RID: 143855
		public const int HelperBtn = 1;

		// Token: 0x040231F0 RID: 143856
		public const int CaptionItem = 2;

		// Token: 0x040231F1 RID: 143857
		public const int GridOne = 3;

		// Token: 0x040231F2 RID: 143858
		public const int GridTwo = 4;

		// Token: 0x040231F3 RID: 143859
		public const int GridThird = 5;

		// Token: 0x040231F4 RID: 143860
		public const int GridFour = 6;

		// Token: 0x040231F5 RID: 143861
		public const int MainItem = 7;

		// Token: 0x040231F6 RID: 143862
		public const int ContentItem = 8;

		// Token: 0x040231F7 RID: 143863
		public const int PopularityItem = 9;

		// Token: 0x040231F8 RID: 143864
		public const int SkipItem = 10;

		// Token: 0x040231F9 RID: 143865
		public const int MaskItem = 11;
	}
}
