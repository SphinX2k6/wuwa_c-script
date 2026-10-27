using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200280B RID: 10251
[NullableContext(2)]
[Nullable(0)]
public class RoleDevPhantomViewItem : UiPanelBase
{
	// Token: 0x0601508E RID: 86158 RVA: 0x005534D0 File Offset: 0x005516D0
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
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnClickSwitch))
		};
	}

	// Token: 0x0601508F RID: 86159 RVA: 0x00553600 File Offset: 0x00551800
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevPhantomViewItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevPhantomViewItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015090 RID: 86160 RVA: 0x00553643 File Offset: 0x00551843
	protected override void OnBeforeCreateImplement()
	{
		this.UiViewSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiViewSequence);
	}

	// Token: 0x06015091 RID: 86161 RVA: 0x00553660 File Offset: 0x00551860
	private UniTask InitVisionHeadItems()
	{
		RoleDevPhantomViewItem.<InitVisionHeadItems>d__14 <InitVisionHeadItems>d__;
		<InitVisionHeadItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitVisionHeadItems>d__.<>4__this = this;
		<InitVisionHeadItems>d__.<>1__state = -1;
		<InitVisionHeadItems>d__.<>t__builder.Start<RoleDevPhantomViewItem.<InitVisionHeadItems>d__14>(ref <InitVisionHeadItems>d__);
		return <InitVisionHeadItems>d__.<>t__builder.Task;
	}

	// Token: 0x06015092 RID: 86162 RVA: 0x005536A3 File Offset: 0x005518A3
	private void InitPanelSuit()
	{
		this.SuitLayout = new GenericLayout<RoleDevPhantomSuitItem, RoleDevPhantomSuitItemData>(base.GetVerticalLayout(9), new Func<RoleDevPhantomSuitItem>(this.InitSuitLayoutItem), null, false, true);
	}

	// Token: 0x06015093 RID: 86163 RVA: 0x005536C7 File Offset: 0x005518C7
	[NullableContext(1)]
	private RoleDevPhantomSuitItem InitSuitLayoutItem()
	{
		return new RoleDevPhantomSuitItem();
	}

	// Token: 0x06015094 RID: 86164 RVA: 0x005536D0 File Offset: 0x005518D0
	[NullableContext(1)]
	public void Refresh(RoleDevPhantomViewItemDataBase data)
	{
		this.Data = data;
		if (RoleModel.Instance.GetRoleDataById(data.RoleId, true) == null)
		{
			base.GetItem(0).SetUIActive(false);
			this.RefreshSuitList(data.SuitDataList);
			return;
		}
		base.GetItem(0).SetUIActive(true);
		this.RefreshSuitList(data.SuitDataList);
		this.RefreshPhantomItems(data.RoleId);
		this.RefreshDevelopButtons();
		this.SetVisionHeadItems();
	}

	// Token: 0x06015095 RID: 86165 RVA: 0x00553748 File Offset: 0x00551948
	private void SetVisionHeadItems()
	{
		int count = this.RoleVisionItems.Count;
		for (int i = 0; i < count; i++)
		{
			this.RoleVisionItems[i].SetRoleId(this.Data.RoleId);
		}
	}

	// Token: 0x06015096 RID: 86166 RVA: 0x0055378C File Offset: 0x0055198C
	private void RefreshPhantomItems(int roleId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (roleDataById == null)
		{
			return;
		}
		List<PhantomDataBase> currentViewShowPhantomList = PhantomBattleModel.Instance.GetCurrentViewShowPhantomList(roleDataById);
		int count = this.RoleVisionItems.Count;
		for (int i = 0; i < count; i++)
		{
			PhantomDataBase data = (currentViewShowPhantomList != null && currentViewShowPhantomList.Count > i) ? currentViewShowPhantomList[i] : null;
			this.RoleVisionItems[i].UpdateItem(data);
		}
	}

	// Token: 0x06015097 RID: 86167 RVA: 0x005537F9 File Offset: 0x005519F9
	private void RefreshDevelopButtons()
	{
		base.GetItem(2).SetUIActive(false);
		this.ButtonDevelop.SetFunction(new Action<int>(this.OnClickDevelop));
		this.ButtonDevelop.SetLocalTextNew("RoleProject_Button01", Array.Empty<object>());
	}

	// Token: 0x06015098 RID: 86168 RVA: 0x00553834 File Offset: 0x00551A34
	[NullableContext(1)]
	private void RefreshSuitList(List<RoleDevPhantomSuitItemData> suitDataList)
	{
		if (this.SuitLayout != null)
		{
			this.SuitLayout.RefreshByData(suitDataList, null, false);
		}
	}

	// Token: 0x06015099 RID: 86169 RVA: 0x0055384C File Offset: 0x00551A4C
	private void OnClickDevelop(int _)
	{
		RoleDevController.Instance.LogRoleDevSubPageClick(this.Data.RoleId, ERoleDevMainPage.Phantom, ERoleDevSubPageButton.PhantomGoToCultivation);
		int num = 0;
		PhantomBattleModel.Instance.CurrentEquipmentSelectIndex = num;
		int equipByIndex = PhantomBattleController.Instance.GetEquipByIndex(this.Data.RoleId, num);
		PhantomBattleModel.Instance.CurrentSelectUniqueId = equipByIndex;
		PhantomUtil.OpenVisionEquipmentView(this.Data.RoleId, num, null);
	}

	// Token: 0x0601509A RID: 86170 RVA: 0x005538BC File Offset: 0x00551ABC
	private void OnClickSwitch()
	{
		RoleDevController.Instance.LogRoleDevSubPageClick(this.Data.RoleId, ERoleDevMainPage.Phantom, ERoleDevSubPageButton.SwitchScheme);
		VisionRecommendViewOpenParam param = new VisionRecommendViewOpenParam
		{
			RoleId = this.Data.RoleId,
			IsFromRoleDev = true,
			SuccessCallBack = new Action<int, int, int?>(this.OnChangeFetterGroupSuccessInternal),
			GetSelectedPlanIdCallBack = new Func<int, int>(this.OnGetSelectedPlanIdInternal)
		};
		UiManager.Instance.OpenView(EUiViewName.VisionNewRecommendView, param, null);
	}

	// Token: 0x0601509B RID: 86171 RVA: 0x00553934 File Offset: 0x00551B34
	private UniTask InitDevelopButtons()
	{
		RoleDevPhantomViewItem.<InitDevelopButtons>d__24 <InitDevelopButtons>d__;
		<InitDevelopButtons>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDevelopButtons>d__.<>4__this = this;
		<InitDevelopButtons>d__.<>1__state = -1;
		<InitDevelopButtons>d__.<>t__builder.Start<RoleDevPhantomViewItem.<InitDevelopButtons>d__24>(ref <InitDevelopButtons>d__);
		return <InitDevelopButtons>d__.<>t__builder.Task;
	}

	// Token: 0x0601509C RID: 86172 RVA: 0x00553977 File Offset: 0x00551B77
	private void OnChangeFetterGroupSuccessInternal(int roleId, int planId, int? firstVisionMonsterId)
	{
		RoleDevPhantomViewItemDataBase data = this.Data;
		if (data != null)
		{
			RoleDevViewModel roleDevViewModel = data.RoleDevViewModel;
			if (roleDevViewModel != null)
			{
				roleDevViewModel.SetRoleRecommendPlanId(roleId, planId);
			}
		}
		Action<int, int> onChangeFetterGroupSuccessCallBack = this.OnChangeFetterGroupSuccessCallBack;
		if (onChangeFetterGroupSuccessCallBack == null)
		{
			return;
		}
		onChangeFetterGroupSuccessCallBack(roleId, planId);
	}

	// Token: 0x0601509D RID: 86173 RVA: 0x005539AC File Offset: 0x00551BAC
	private int OnGetSelectedPlanIdInternal(int roleId)
	{
		RoleDevPhantomViewItemDataBase data = this.Data;
		int? num;
		if (data == null)
		{
			num = null;
		}
		else
		{
			RoleDevViewModel roleDevViewModel = data.RoleDevViewModel;
			num = ((roleDevViewModel != null) ? new int?(roleDevViewModel.GetRoleRecommendPlanId(roleId)) : null);
		}
		int? num2 = num;
		return num2.GetValueOrDefault();
	}

	// Token: 0x04009E1D RID: 40477
	public Action<int> OnClickToggleCallBack;

	// Token: 0x04009E1E RID: 40478
	public Func<int, bool> CanClickCallBack;

	// Token: 0x04009E1F RID: 40479
	public Action<int> OnDevelopCallBack;

	// Token: 0x04009E20 RID: 40480
	public Action<int> OnPerfectDevelopCallBack;

	// Token: 0x04009E21 RID: 40481
	public Action<int, int> OnChangeFetterGroupSuccessCallBack;

	// Token: 0x04009E22 RID: 40482
	[Nullable(1)]
	private readonly List<RoleDevPhantomHeadItem> RoleVisionItems = new List<RoleDevPhantomHeadItem>();

	// Token: 0x04009E23 RID: 40483
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevPhantomSuitItem, RoleDevPhantomSuitItemData> SuitLayout;

	// Token: 0x04009E24 RID: 40484
	private ButtonItem ButtonDevelop;

	// Token: 0x04009E25 RID: 40485
	public UiBehaviorLevelSequence UiViewSequence;

	// Token: 0x04009E26 RID: 40486
	private RoleDevPhantomViewItemDataBase Data;

	// Token: 0x02008E50 RID: 36432
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E29D RID: 189085
		PanelPhantomDev,
		// Token: 0x0402E29E RID: 189086
		BtnDevelop,
		// Token: 0x0402E29F RID: 189087
		BtnPerfectDevelop,
		// Token: 0x0402E2A0 RID: 189088
		SubPhantomCircle1,
		// Token: 0x0402E2A1 RID: 189089
		SubPhantomCircle2,
		// Token: 0x0402E2A2 RID: 189090
		SubPhantomCircle3,
		// Token: 0x0402E2A3 RID: 189091
		SubPhantomCircle4,
		// Token: 0x0402E2A4 RID: 189092
		SubPhantomCircle5,
		// Token: 0x0402E2A5 RID: 189093
		BtnSwitch,
		// Token: 0x0402E2A6 RID: 189094
		PanelSuitLayout,
		// Token: 0x0402E2A7 RID: 189095
		PanelSuit
	}
}
