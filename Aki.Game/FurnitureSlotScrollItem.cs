using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Utils;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000FED RID: 4077
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FurnitureSlotScrollItem : GridProxyAbstract<FurnitureSlotScrollItemData>
{
	// Token: 0x060068AB RID: 26795 RVA: 0x0014CD98 File Offset: 0x0014AF98
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItemToggle))
		};
	}

	// Token: 0x060068AC RID: 26796 RVA: 0x0014CE57 File Offset: 0x0014B057
	[NullableContext(1)]
	public override void Refresh(FurnitureSlotScrollItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshItemToggle();
		this.RefreshRedDot();
		this.RefreshLine();
		this.RefreshTagIndex();
		this.RefreshIcon();
	}

	// Token: 0x060068AD RID: 26797 RVA: 0x0014CE7E File Offset: 0x0014B07E
	public void RefreshItemToggle()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		FurnitureSlotScrollItemData data = this.Data;
		extendToggle.SetToggleState((data != null && data.IsSelected) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060068AE RID: 26798 RVA: 0x0014CEA8 File Offset: 0x0014B0A8
	public void RefreshRedDot()
	{
		UUIItem item = base.GetItem(2);
		FurnitureSlotScrollItemData data = this.Data;
		item.SetUIActive(data != null && data.RedDotShowState);
	}

	// Token: 0x060068AF RID: 26799 RVA: 0x0014CEC8 File Offset: 0x0014B0C8
	public void RefreshLine()
	{
		UUIItem item = base.GetItem(5);
		FurnitureSlotScrollItemData data = this.Data;
		item.SetUIActive(data != null && data.LineShowState);
	}

	// Token: 0x060068B0 RID: 26800 RVA: 0x0014CEE8 File Offset: 0x0014B0E8
	public void RefreshTagIndex()
	{
		FurnitureSlotScrollItemData data = this.Data;
		bool flag = data != null && data.ShowTagIndex;
		base.GetItem(3).SetUIActive(flag);
		if (flag)
		{
			FurnitureSlotScrollItemData data2 = this.Data;
			string newText = RomanNumeralUtils.ConvertToRoman((data2 != null) ? data2.TagIndex : 0);
			base.GetText(4).SetText(newText, true);
		}
	}

	// Token: 0x060068B1 RID: 26801 RVA: 0x0014CF40 File Offset: 0x0014B140
	public void RefreshIcon()
	{
		FurnitureConfig instance = FurnitureConfig.Instance;
		FurnitureSlotScrollItemData data = this.Data;
		FurnitureDiyTag? furnitureTagConfig = instance.GetFurnitureTagConfig((data != null) ? data.TagId : 0);
		if (furnitureTagConfig == null)
		{
			return;
		}
		FurnitureSlotScrollItemData data2 = this.Data;
		string path = (((data2 != null) ? data2.PlacedFurnitureId : 0) > 0) ? furnitureTagConfig.Value.OccupiedIcon : furnitureTagConfig.Value.EmptyIcon;
		this.SetSpriteByPath(path, base.GetSprite(1), false, null, null);
	}

	// Token: 0x060068B2 RID: 26802 RVA: 0x0014CFC3 File Offset: 0x0014B1C3
	private void OnClickItemToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<int> onItemSelected = this.OnItemSelected;
			if (onItemSelected == null)
			{
				return;
			}
			onItemSelected(base.GridIndex);
		}
	}

	// Token: 0x04002FF4 RID: 12276
	private FurnitureSlotScrollItemData Data;

	// Token: 0x04002FF5 RID: 12277
	public Action<int> OnItemSelected;
}
