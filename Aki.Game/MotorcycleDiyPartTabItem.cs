using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200177F RID: 6015
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyPartTabItem : CommonTabItemBase
{
	// Token: 0x0600E983 RID: 59779 RVA: 0x0044647C File Offset: 0x0044467C
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

	// Token: 0x0600E984 RID: 59780 RVA: 0x00446551 File Offset: 0x00444751
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

	// Token: 0x0600E985 RID: 59781 RVA: 0x0044657C File Offset: 0x0044477C
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

	// Token: 0x0600E986 RID: 59782 RVA: 0x00446631 File Offset: 0x00444831
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x0600E987 RID: 59783 RVA: 0x00446633 File Offset: 0x00444833
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleStateForce(state, bFire, false, false);
		this.ChangeTabIcon(state == EToggleState.ETT_Checked);
	}

	// Token: 0x0600E988 RID: 59784 RVA: 0x0044664F File Offset: 0x0044484F
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x0600E989 RID: 59785 RVA: 0x00446658 File Offset: 0x00444858
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

	// Token: 0x0600E98A RID: 59786 RVA: 0x00446724 File Offset: 0x00444924
	public void BindRedDot(ERedDotName redDotName, int typePart)
	{
		this.UnBindRedDot();
		UUIItem item = base.GetItem(3);
		this.RedDotName = new ERedDotName?(redDotName);
		this.TypePart = typePart;
		RedDotController.Instance.BindRedDot(redDotName, item, null, typePart);
	}

	// Token: 0x0600E98B RID: 59787 RVA: 0x00446760 File Offset: 0x00444960
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(3), this.TypePart);
			this.RedDotName = null;
			this.TypePart = 0;
		}
	}

	// Token: 0x0600E98C RID: 59788 RVA: 0x004467B0 File Offset: 0x004449B0
	public void BindPreviewRedDot(ERedDotName redDotName, int typePart)
	{
		this.UnBindPreviewRedDot();
		UUIItem item = base.GetItem(5);
		this.PreviewRedDotName = new ERedDotName?(redDotName);
		this.PreviewTypePart = typePart;
		RedDotController.Instance.BindRedDot(redDotName, item, null, typePart);
	}

	// Token: 0x0600E98D RID: 59789 RVA: 0x004467EC File Offset: 0x004449EC
	public void UnBindPreviewRedDot()
	{
		if (this.PreviewRedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.PreviewRedDotName.Value, base.GetItem(5), this.PreviewTypePart);
			this.PreviewRedDotName = null;
			this.PreviewTypePart = 0;
		}
	}

	// Token: 0x0600E98E RID: 59790 RVA: 0x0044683B File Offset: 0x00444A3B
	public void SetPreviewRedDotVisible(bool isVisible)
	{
		base.GetItem(5).SetUIActive(isVisible);
	}

	// Token: 0x0600E98F RID: 59791 RVA: 0x0044684A File Offset: 0x00444A4A
	public void SetPresetRedDotVisible(bool isVisible)
	{
		base.GetItem(6).SetUIActive(isVisible);
	}

	// Token: 0x040084D7 RID: 34007
	private ERedDotName? RedDotName;

	// Token: 0x040084D8 RID: 34008
	private int TypePart;

	// Token: 0x040084D9 RID: 34009
	private ERedDotName? PreviewRedDotName;

	// Token: 0x040084DA RID: 34010
	private int PreviewTypePart;

	// Token: 0x02007963 RID: 31075
	[NullableContext(0)]
	private class EMotorDiyPartTabItemComponent
	{
		// Token: 0x04027556 RID: 161110
		public const int TexIcon = 0;

		// Token: 0x04027557 RID: 161111
		public const int TogItem = 1;

		// Token: 0x04027558 RID: 161112
		public const int RedDotItem = 2;

		// Token: 0x04027559 RID: 161113
		public const int NewItem = 3;

		// Token: 0x0402755A RID: 161114
		public const int LineItem = 4;

		// Token: 0x0402755B RID: 161115
		public const int PreviewItem = 5;

		// Token: 0x0402755C RID: 161116
		public const int PresetChangeItem = 6;
	}
}
