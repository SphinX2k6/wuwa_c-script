using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002AAE RID: 10926
public class SubPackageDownLoadVersionTipsView : UiPanelBase
{
	// Token: 0x06016BFF RID: 93183 RVA: 0x005C5F10 File Offset: 0x005C4110
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickMaskBtn))
		};
	}

	// Token: 0x06016C00 RID: 93184 RVA: 0x005C5FA4 File Offset: 0x005C41A4
	public void RefreshItem(int versionId, FVectorDouble vector)
	{
		DownLoadVersion? downLoadVersionByVersion = SubPackageConfig.Instance.GetDownLoadVersionByVersion(versionId);
		if (downLoadVersionByVersion == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), downLoadVersionByVersion.Value.HelpTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), downLoadVersionByVersion.Value.HelpDesc, Array.Empty<object>());
		this.TipsVector.X = vector.X + 45.0;
		this.TipsVector.Z = vector.Z + 20.0;
		FHitResult fhitResult = new FHitResult();
		base.GetItem(1).D_K2_SetWorldLocation(this.TipsVector, false, ref fhitResult, false);
	}

	// Token: 0x06016C01 RID: 93185 RVA: 0x005C6064 File Offset: 0x005C4264
	public void RefreshItemByClearType(ESubPackageDownLoadPackageType clearType, FVectorDouble vector)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "SubPackageClearTipsTitle_TipsTitle_" + SubPackageDefineClearTypeToTipsNumber.clearTypeToTipsNumber[clearType].ToString(), Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "SubPackageClearTipsTitle_TipsDes_" + SubPackageDefineClearTypeToTipsNumber.clearTypeToTipsNumber[clearType].ToString(), Array.Empty<object>());
		this.TipsVector.X = vector.X + 45.0;
		this.TipsVector.Z = vector.Z + 20.0;
		FHitResult fhitResult = new FHitResult();
		base.GetItem(1).D_K2_SetWorldLocation(this.TipsVector, false, ref fhitResult, false);
	}

	// Token: 0x06016C02 RID: 93186 RVA: 0x005C6129 File Offset: 0x005C4329
	private void OnClickMaskBtn()
	{
		base.SetUiActive(false);
	}

	// Token: 0x0400A8DB RID: 43227
	private const int BG_ITEM_OFFSETX = 45;

	// Token: 0x0400A8DC RID: 43228
	private const int BG_ITEM_OFFSETZ = 20;

	// Token: 0x0400A8DD RID: 43229
	private FVectorDouble TipsVector = new FVectorDouble();

	// Token: 0x020090DE RID: 37086
	private class EComponentDefine
	{
		// Token: 0x0402EEF2 RID: 192242
		public const int MaskBtn = 0;

		// Token: 0x0402EEF3 RID: 192243
		public const int BgItem = 1;

		// Token: 0x0402EEF4 RID: 192244
		public const int TitleText = 2;

		// Token: 0x0402EEF5 RID: 192245
		public const int ContentText = 3;
	}
}
