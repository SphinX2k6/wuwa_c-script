using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200229B RID: 8859
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyPartTabItem : CommonTabItemBase
{
	// Token: 0x060114EB RID: 70891 RVA: 0x00439884 File Offset: 0x00437A84
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x060114EC RID: 70892 RVA: 0x00439959 File Offset: 0x00437B59
	private void OnClickToggle(EToggleState toggleState)
	{
		bool flag = toggleState == EToggleState.ETT_Checked;
		this.ChangeTabIcon(toggleState == EToggleState.ETT_Checked);
		if (!flag)
		{
			return;
		}
		Action<int> selectedCallBack = this.SelectedCallBack;
		if (selectedCallBack == null)
		{
			return;
		}
		selectedCallBack(base.GridIndex);
	}

	// Token: 0x060114ED RID: 70893 RVA: 0x00439984 File Offset: 0x00437B84
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		MotorcycleDiyPartTabItemData motorcycleDiyPartTabItemData = data as MotorcycleDiyPartTabItemData;
		if (motorcycleDiyPartTabItemData == null)
		{
			return;
		}
		EOutlookType outlookType = motorcycleDiyPartTabItemData.OutlookType;
		int partId = motorcycleDiyPartTabItemData.PartId;
		string text = null;
		if (outlookType == EOutlookType.Sticker)
		{
			MotorStickerPart? motorStickerPartConfig = MotorDiyConfig.Instance.GetMotorStickerPartConfig(partId);
			if (motorStickerPartConfig != null)
			{
				text = motorStickerPartConfig.Value.Icon;
			}
		}
		else if (outlookType == EOutlookType.Decoration)
		{
			MotorDecorationsPart? motorDecorationPartConfig = MotorDiyConfig.Instance.GetMotorDecorationPartConfig(partId);
			if (motorDecorationPartConfig != null)
			{
				text = motorDecorationPartConfig.Value.Icon;
			}
		}
		if (text != null)
		{
			base.SetTextureByPath(text, base.GetTexture(0), null, null);
		}
		base.GetItem(4).SetUIActive(motorcycleDiyPartTabItemData.IsShowLine);
		this.SetPresetRedDotVisible(false);
	}

	// Token: 0x060114EE RID: 70894 RVA: 0x00439A39 File Offset: 0x00437C39
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x060114EF RID: 70895 RVA: 0x00439A3B File Offset: 0x00437C3B
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleStateForce(state, bFire, false, false);
		this.ChangeTabIcon(state == EToggleState.ETT_Checked);
	}

	// Token: 0x060114F0 RID: 70896 RVA: 0x00439A57 File Offset: 0x00437C57
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x060114F1 RID: 70897 RVA: 0x00439A60 File Offset: 0x00437C60
	private void ChangeTabIcon(bool selected)
	{
		MotorcycleDiyPartTabItemData motorcycleDiyPartTabItemData = this.CurrentData as MotorcycleDiyPartTabItemData;
		if (motorcycleDiyPartTabItemData == null)
		{
			return;
		}
		EOutlookType outlookType = motorcycleDiyPartTabItemData.OutlookType;
		int partId = motorcycleDiyPartTabItemData.PartId;
		string text = null;
		if (outlookType == EOutlookType.Sticker)
		{
			MotorStickerPart? motorStickerPartConfig = MotorDiyConfig.Instance.GetMotorStickerPartConfig(partId);
			if (motorStickerPartConfig != null)
			{
				text = (selected ? motorStickerPartConfig.Value.IconSelect : motorStickerPartConfig.Value.Icon);
			}
		}
		else if (outlookType == EOutlookType.Decoration)
		{
			MotorDecorationsPart? motorDecorationPartConfig = MotorDiyConfig.Instance.GetMotorDecorationPartConfig(partId);
			if (motorDecorationPartConfig != null)
			{
				text = (selected ? motorDecorationPartConfig.Value.IconSelect : motorDecorationPartConfig.Value.Icon);
			}
		}
		if (text != null)
		{
			base.SetTextureByPath(text, base.GetTexture(0), null, null);
		}
	}

	// Token: 0x060114F2 RID: 70898 RVA: 0x00439B2C File Offset: 0x00437D2C
	public void BindRedDot(ERedDotName redDotName, int typePart)
	{
		this.UnBindRedDot();
		UUIItem item = base.GetItem(3);
		this.RedDotName = new ERedDotName?(redDotName);
		this.TypePart = typePart;
		RedDotController.Instance.BindRedDot(redDotName, item, null, typePart);
	}

	// Token: 0x060114F3 RID: 70899 RVA: 0x00439B68 File Offset: 0x00437D68
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(3), this.TypePart);
			this.RedDotName = null;
			this.TypePart = 0;
		}
	}

	// Token: 0x060114F4 RID: 70900 RVA: 0x00439BB8 File Offset: 0x00437DB8
	public void BindPreviewRedDot(ERedDotName redDotName, int typePart)
	{
		this.UnBindPreviewRedDot();
		UUIItem item = base.GetItem(5);
		this.PreviewRedDotName = new ERedDotName?(redDotName);
		this.PreviewTypePart = typePart;
		RedDotController.Instance.BindRedDot(redDotName, item, null, typePart);
	}

	// Token: 0x060114F5 RID: 70901 RVA: 0x00439BF4 File Offset: 0x00437DF4
	public void UnBindPreviewRedDot()
	{
		if (this.PreviewRedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.PreviewRedDotName.Value, base.GetItem(5), this.PreviewTypePart);
			this.PreviewRedDotName = null;
			this.PreviewTypePart = 0;
		}
	}

	// Token: 0x060114F6 RID: 70902 RVA: 0x00439C43 File Offset: 0x00437E43
	public void SetPreviewRedDotVisible(bool isVisible)
	{
		base.GetItem(5).SetUIActive(isVisible);
	}

	// Token: 0x060114F7 RID: 70903 RVA: 0x00439C52 File Offset: 0x00437E52
	public void SetPresetRedDotVisible(bool isVisible)
	{
		base.GetItem(6).SetUIActive(isVisible);
	}

	// Token: 0x04008399 RID: 33689
	private ERedDotName? RedDotName;

	// Token: 0x0400839A RID: 33690
	private int TypePart;

	// Token: 0x0400839B RID: 33691
	private ERedDotName? PreviewRedDotName;

	// Token: 0x0400839C RID: 33692
	private int PreviewTypePart;

	// Token: 0x020087DA RID: 34778
	[NullableContext(0)]
	private class EMotorDiyPartTabItemComponent
	{
		// Token: 0x0402C24A RID: 180810
		public const int TexIcon = 0;

		// Token: 0x0402C24B RID: 180811
		public const int TogItem = 1;

		// Token: 0x0402C24C RID: 180812
		public const int RedDotItem = 2;

		// Token: 0x0402C24D RID: 180813
		public const int NewItem = 3;

		// Token: 0x0402C24E RID: 180814
		public const int LineItem = 4;

		// Token: 0x0402C24F RID: 180815
		public const int PreviewItem = 5;

		// Token: 0x0402C250 RID: 180816
		public const int PresetChangeItem = 6;
	}
}
