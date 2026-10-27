using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002235 RID: 8757
public class MotorcycleLevelActiveTreeItem : UiPanelBase
{
	// Token: 0x06011167 RID: 69991 RVA: 0x0042A79C File Offset: 0x0042899C
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

	// Token: 0x06011168 RID: 69992 RVA: 0x0042A81C File Offset: 0x00428A1C
	public void Refresh()
	{
		int curTreeType = MotorcycleDevelopModel.Instance.GetCurTreeType();
		MotorTechTree? motorTechTreeConfig = MotorConfig.Instance.GetMotorTechTreeConfig(curTreeType);
		base.SetTextureByPath(motorTechTreeConfig.Value.Icon, base.GetTexture(0), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), motorTechTreeConfig.Value.Name, Array.Empty<object>());
	}

	// Token: 0x06011169 RID: 69993 RVA: 0x0042A88C File Offset: 0x00428A8C
	private void OnBtnShowDetailClick()
	{
		int curTreeType = MotorcycleDevelopModel.Instance.GetCurTreeType();
		UiManager.Instance.OpenView(EUiViewName.MotorcycleTechTreeDetailView, curTreeType, null);
	}

	// Token: 0x02008769 RID: 34665
	private class EMotorLevelActiveTreeItemComponent
	{
		// Token: 0x0402C036 RID: 180278
		public const int TexIcon = 0;

		// Token: 0x0402C037 RID: 180279
		public const int TxtName = 1;

		// Token: 0x0402C038 RID: 180280
		public const int BtnShowDetail = 2;
	}
}
