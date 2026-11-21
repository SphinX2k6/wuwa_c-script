using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D86 RID: 7558
[NullableContext(2)]
[Nullable(0)]
public class RoleDevPhantomViewItem : UiPanelBase
{
	// Token: 0x06012A8E RID: 76430 RVA: 0x0057E2A4 File Offset: 0x0057C4A4
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

	// Token: 0x06012A8F RID: 76431 RVA: 0x0057E3D4 File Offset: 0x0057C5D4
	protected override UniTask OnBeforeStartAsync()
	{
		RoleDevPhantomViewItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevPhantomViewItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012A90 RID: 76432 RVA: 0x0057E417 File Offset: 0x0057C617
	protected override void OnBeforeCreateImplement()
	{
		this.UiViewSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiViewSequence);
	}

	// Token: 0x06012A91 RID: 76433 RVA: 0x0057E434 File Offset: 0x0057C634
	private UniTask InitVisionHeadItems()
	{
		RoleDevPhantomViewItem.<InitVisionHeadItems>d__14 <InitVisionHeadItems>d__;
		<InitVisionHeadItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitVisionHeadItems>d__.<>4__this = this;
		<InitVisionHeadItems>d__.<>1__state = -1;
		<InitVisionHeadItems>d__.<>t__builder.Start<RoleDevPhantomViewItem.<InitVisionHeadItems>d__14>(ref <InitVisionHeadItems>d__);
		return <InitVisionHeadItems>d__.<>t__builder.Task;
	}

	// Token: 0x06012A92 RID: 76434 RVA: 0x0057E477 File Offset: 0x0057C677
	private void InitPanelSuit()
	{
		this.SuitLayout = new GenericLayout<RoleDevPhantomSuitItem, RoleDevPhantomSuitItemData>(base.GetVerticalLayout(9), new Func<RoleDevPhantomSuitItem>(this.InitSuitLayoutItem), null, false, true);
	}

	// Token: 0x06012A93 RID: 76435 RVA: 0x0057E49B File Offset: 0x0057C69B
	[NullableContext(1)]
	private RoleDevPhantomSuitItem InitSuitLayoutItem()
	{
		return new RoleDevPhantomSuitItem();
	}

	// Token: 0x06012A94 RID: 76436 RVA: 0x0057E4A4 File Offset: 0x0057C6A4
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

	// Token: 0x06012A95 RID: 76437 RVA: 0x0057E51C File Offset: 0x0057C71C
	private void SetVisionHeadItems()
	{
		int count = this.RoleVisionItems.Count;
		for (int i = 0; i < count; i++)
		{
			this.RoleVisionItems[i].SetRoleId(this.Data.RoleId);
		}
	}

	// Token: 0x06012A96 RID: 76438 RVA: 0x0057E560 File Offset: 0x0057C760
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

	// Token: 0x06012A97 RID: 76439 RVA: 0x0057E5CD File Offset: 0x0057C7CD
	private void RefreshDevelopButtons()
	{
		base.GetItem(2).SetUIActive(false);
		this.ButtonDevelop.SetFunction(new Action<int>(this.OnClickDevelop));
		this.ButtonDevelop.SetLocalTextNew("RoleProject_Button01", Array.Empty<object>());
	}

	// Token: 0x06012A98 RID: 76440 RVA: 0x0057E608 File Offset: 0x0057C808
	[NullableContext(1)]
	private void RefreshSuitList(List<RoleDevPhantomSuitItemData> suitDataList)
	{
		if (this.SuitLayout != null)
		{
			this.SuitLayout.RefreshByData(suitDataList, null, false);
		}
	}

	// Token: 0x06012A99 RID: 76441 RVA: 0x0057E620 File Offset: 0x0057C820
	private void OnClickDevelop(int _)
	{
		RoleDevController.Instance.LogRoleDevSubPageClick(this.Data.RoleId, ERoleDevMainPage.Phantom, ERoleDevSubPageButton.PhantomGoToCultivation);
		int num = 0;
		PhantomBattleModel.Instance.CurrentEquipmentSelectIndex = num;
		int equipByIndex = PhantomBattleController.Instance.GetEquipByIndex(this.Data.RoleId, num);
		PhantomBattleModel.Instance.CurrentSelectUniqueId = equipByIndex;
		PhantomUtil.OpenVisionEquipmentView(this.Data.RoleId, num, null);
	}

	// Token: 0x06012A9A RID: 76442 RVA: 0x0057E690 File Offset: 0x0057C890
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

	// Token: 0x06012A9B RID: 76443 RVA: 0x0057E708 File Offset: 0x0057C908
	private UniTask InitDevelopButtons()
	{
		RoleDevPhantomViewItem.<InitDevelopButtons>d__24 <InitDevelopButtons>d__;
		<InitDevelopButtons>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitDevelopButtons>d__.<>4__this = this;
		<InitDevelopButtons>d__.<>1__state = -1;
		<InitDevelopButtons>d__.<>t__builder.Start<RoleDevPhantomViewItem.<InitDevelopButtons>d__24>(ref <InitDevelopButtons>d__);
		return <InitDevelopButtons>d__.<>t__builder.Task;
	}

	// Token: 0x06012A9C RID: 76444 RVA: 0x0057E74B File Offset: 0x0057C94B
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

	// Token: 0x06012A9D RID: 76445 RVA: 0x0057E780 File Offset: 0x0057C980
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

	// Token: 0x0400A206 RID: 41478
	public Action<int> OnClickToggleCallBack;

	// Token: 0x0400A207 RID: 41479
	public Func<int, bool> CanClickCallBack;

	// Token: 0x0400A208 RID: 41480
	public Action<int> OnDevelopCallBack;

	// Token: 0x0400A209 RID: 41481
	public Action<int> OnPerfectDevelopCallBack;

	// Token: 0x0400A20A RID: 41482
	public Action<int, int> OnChangeFetterGroupSuccessCallBack;

	// Token: 0x0400A20B RID: 41483
	[Nullable(1)]
	private readonly List<RoleDevPhantomHeadItem> RoleVisionItems = new List<RoleDevPhantomHeadItem>();

	// Token: 0x0400A20C RID: 41484
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleDevPhantomSuitItem, RoleDevPhantomSuitItemData> SuitLayout;

	// Token: 0x0400A20D RID: 41485
	private ButtonItem ButtonDevelop;

	// Token: 0x0400A20E RID: 41486
	public UiBehaviorLevelSequence UiViewSequence;

	// Token: 0x0400A20F RID: 41487
	private RoleDevPhantomViewItemDataBase Data;

	// Token: 0x02008098 RID: 32920
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029999 RID: 170393
		PanelPhantomDev,
		// Token: 0x0402999A RID: 170394
		BtnDevelop,
		// Token: 0x0402999B RID: 170395
		BtnPerfectDevelop,
		// Token: 0x0402999C RID: 170396
		SubPhantomCircle1,
		// Token: 0x0402999D RID: 170397
		SubPhantomCircle2,
		// Token: 0x0402999E RID: 170398
		SubPhantomCircle3,
		// Token: 0x0402999F RID: 170399
		SubPhantomCircle4,
		// Token: 0x040299A0 RID: 170400
		SubPhantomCircle5,
		// Token: 0x040299A1 RID: 170401
		BtnSwitch,
		// Token: 0x040299A2 RID: 170402
		PanelSuitLayout,
		// Token: 0x040299A3 RID: 170403
		PanelSuit
	}
}
