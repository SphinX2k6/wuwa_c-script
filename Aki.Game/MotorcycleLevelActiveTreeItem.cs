using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001719 RID: 5913
public class MotorcycleLevelActiveTreeItem : UiPanelBase
{
	// Token: 0x0600E5FD RID: 58877 RVA: 0x00437340 File Offset: 0x00435540
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnBtnShowDetailClick))
		};
	}

	// Token: 0x0600E5FE RID: 58878 RVA: 0x004373C0 File Offset: 0x004355C0
	public void Refresh()
	{
		int curTreeType = MotorcycleDevelopModel.Instance.GetCurTreeType();
		MotorTechTree? motorTechTreeConfig = MotorConfig.Instance.GetMotorTechTreeConfig(curTreeType);
		base.SetTextureByPath(motorTechTreeConfig.Value.Icon, base.GetTexture(0), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), motorTechTreeConfig.Value.Name, Array.Empty<object>());
	}

	// Token: 0x0600E5FF RID: 58879 RVA: 0x00437430 File Offset: 0x00435630
	private void OnBtnShowDetailClick()
	{
		int curTreeType = MotorcycleDevelopModel.Instance.GetCurTreeType();
		UiManager.Instance.OpenView(EUiViewName.MotorcycleTechTreeDetailView, curTreeType, null);
	}

	// Token: 0x020078F2 RID: 30962
	private class EMotorLevelActiveTreeItemComponent
	{
		// Token: 0x0402734E RID: 160590
		public const int TexIcon = 0;

		// Token: 0x0402734F RID: 160591
		public const int TxtName = 1;

		// Token: 0x04027350 RID: 160592
		public const int BtnShowDetail = 2;
	}
}
