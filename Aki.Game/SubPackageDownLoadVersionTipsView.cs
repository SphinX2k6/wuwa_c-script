using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200202A RID: 8234
public class SubPackageDownLoadVersionTipsView : UiPanelBase
{
	// Token: 0x0601462E RID: 83502 RVA: 0x005F29A4 File Offset: 0x005F0BA4
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

	// Token: 0x0601462F RID: 83503 RVA: 0x005F2A38 File Offset: 0x005F0C38
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

	// Token: 0x06014630 RID: 83504 RVA: 0x005F2AF8 File Offset: 0x005F0CF8
	public void RefreshItemByClearType(ESubPackageDownLoadPackageType clearType, FVectorDouble vector)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "SubPackageClearTipsTitle_TipsTitle_" + SubPackageDefineClearTypeToTipsNumber.clearTypeToTipsNumber[clearType].ToString(), Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "SubPackageClearTipsTitle_TipsDes_" + SubPackageDefineClearTypeToTipsNumber.clearTypeToTipsNumber[clearType].ToString(), Array.Empty<object>());
		this.TipsVector.X = vector.X + 45.0;
		this.TipsVector.Z = vector.Z + 20.0;
		FHitResult fhitResult = new FHitResult();
		base.GetItem(1).D_K2_SetWorldLocation(this.TipsVector, false, ref fhitResult, false);
	}

	// Token: 0x06014631 RID: 83505 RVA: 0x005F2BBD File Offset: 0x005F0DBD
	private void OnClickMaskBtn()
	{
		base.SetUiActive(false);
	}

	// Token: 0x0400ACE1 RID: 44257
	private const int BG_ITEM_OFFSETX = 45;

	// Token: 0x0400ACE2 RID: 44258
	private const int BG_ITEM_OFFSETZ = 20;

	// Token: 0x0400ACE3 RID: 44259
	private FVectorDouble TipsVector = new FVectorDouble();

	// Token: 0x02008322 RID: 33570
	private class EComponentDefine
	{
		// Token: 0x0402A5F7 RID: 173559
		public const int MaskBtn = 0;

		// Token: 0x0402A5F8 RID: 173560
		public const int BgItem = 1;

		// Token: 0x0402A5F9 RID: 173561
		public const int TitleText = 2;

		// Token: 0x0402A5FA RID: 173562
		public const int ContentText = 3;
	}
}
