using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022A8 RID: 8872
public class MotorcycleDiyFramePanel : UiPanelBase
{
	// Token: 0x060115D2 RID: 71122 RVA: 0x0043F270 File Offset: 0x0043D470
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBtnEnterClick))
		};
	}

	// Token: 0x060115D3 RID: 71123 RVA: 0x0043F32F File Offset: 0x0043D52F
	protected override void OnStart()
	{
		this.SetEditable(true);
	}

	// Token: 0x060115D4 RID: 71124 RVA: 0x0043F338 File Offset: 0x0043D538
	public void Refresh(int frameId)
	{
		MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(frameId);
		if (motorFrameConfig == null)
		{
			return;
		}
		base.SetTextureByPath(motorFrameConfig.Value.ModelIconPath, base.GetTexture(2), null, null);
		base.GetItem(4).SetUIActive(MotorcycleDiyModel.Instance.RedDotHasNewFrameVisible());
	}

	// Token: 0x060115D5 RID: 71125 RVA: 0x0043F397 File Offset: 0x0043D597
	public void SetEditable(bool isEditable)
	{
		base.GetItem(5).SetUIActive(!isEditable);
		base.GetTexture(2).SetUIActive(isEditable);
		base.GetTexture(3).SetUIActive(isEditable);
	}

	// Token: 0x060115D6 RID: 71126 RVA: 0x0043F3C4 File Offset: 0x0043D5C4
	private void OnBtnEnterClick()
	{
		MotorcycleDiyModel.Instance.ResetSelectedItemInfo();
		OpenMotorcycleDiyRootViewData param = new OpenMotorcycleDiyRootViewData
		{
			OpenTabView = new EUiTabViewName?(EUiTabViewName.MotorcycleDiyFrameTabView),
			PartTabIndex = new int?(1),
			IsNeedResetMotor = new bool?(true)
		};
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyRootView, param, null);
	}

	// Token: 0x02008804 RID: 34820
	private class EMotorFrameComponent
	{
		// Token: 0x0402C326 RID: 181030
		public const int BtnEnter = 0;

		// Token: 0x0402C327 RID: 181031
		public const int TxtTitle = 1;

		// Token: 0x0402C328 RID: 181032
		public const int TexIconBig = 2;

		// Token: 0x0402C329 RID: 181033
		public const int TexIconSmall = 3;

		// Token: 0x0402C32A RID: 181034
		public const int NewItem = 4;

		// Token: 0x0402C32B RID: 181035
		public const int LockItem = 5;
	}
}
