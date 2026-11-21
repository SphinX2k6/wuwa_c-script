using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200178C RID: 6028
public class MotorcycleDiyFramePanel : UiPanelBase
{
	// Token: 0x0600EA6A RID: 60010 RVA: 0x0044BE5C File Offset: 0x0044A05C
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

	// Token: 0x0600EA6B RID: 60011 RVA: 0x0044BF1B File Offset: 0x0044A11B
	protected override void OnStart()
	{
		this.SetEditable(true);
	}

	// Token: 0x0600EA6C RID: 60012 RVA: 0x0044BF24 File Offset: 0x0044A124
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

	// Token: 0x0600EA6D RID: 60013 RVA: 0x0044BF83 File Offset: 0x0044A183
	public void SetEditable(bool isEditable)
	{
		base.GetItem(5).SetUIActive(!isEditable);
		base.GetTexture(2).SetUIActive(isEditable);
		base.GetTexture(3).SetUIActive(isEditable);
	}

	// Token: 0x0600EA6E RID: 60014 RVA: 0x0044BFB0 File Offset: 0x0044A1B0
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

	// Token: 0x0200798B RID: 31115
	private class EMotorFrameComponent
	{
		// Token: 0x0402762F RID: 161327
		public const int BtnEnter = 0;

		// Token: 0x04027630 RID: 161328
		public const int TxtTitle = 1;

		// Token: 0x04027631 RID: 161329
		public const int TexIconBig = 2;

		// Token: 0x04027632 RID: 161330
		public const int TexIconSmall = 3;

		// Token: 0x04027633 RID: 161331
		public const int NewItem = 4;

		// Token: 0x04027634 RID: 161332
		public const int LockItem = 5;
	}
}
