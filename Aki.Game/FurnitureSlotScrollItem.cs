using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Utils;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020004A2 RID: 1186
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FurnitureSlotScrollItem : GridProxyAbstract<FurnitureSlotScrollItemData>
{
	// Token: 0x06003C43 RID: 15427 RVA: 0x0015565C File Offset: 0x0015385C
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

	// Token: 0x06003C44 RID: 15428 RVA: 0x0015571B File Offset: 0x0015391B
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

	// Token: 0x06003C45 RID: 15429 RVA: 0x00155742 File Offset: 0x00153942
	public void RefreshItemToggle()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		FurnitureSlotScrollItemData data = this.Data;
		extendToggle.SetToggleState((data != null && data.IsSelected) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06003C46 RID: 15430 RVA: 0x0015576C File Offset: 0x0015396C
	public void RefreshRedDot()
	{
		UUIItem item = base.GetItem(2);
		FurnitureSlotScrollItemData data = this.Data;
		item.SetUIActive(data != null && data.RedDotShowState);
	}

	// Token: 0x06003C47 RID: 15431 RVA: 0x0015578C File Offset: 0x0015398C
	public void RefreshLine()
	{
		UUIItem item = base.GetItem(5);
		FurnitureSlotScrollItemData data = this.Data;
		item.SetUIActive(data != null && data.LineShowState);
	}

	// Token: 0x06003C48 RID: 15432 RVA: 0x001557AC File Offset: 0x001539AC
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

	// Token: 0x06003C49 RID: 15433 RVA: 0x00155804 File Offset: 0x00153A04
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

	// Token: 0x06003C4A RID: 15434 RVA: 0x00155887 File Offset: 0x00153A87
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

	// Token: 0x0400308D RID: 12429
	private FurnitureSlotScrollItemData Data;

	// Token: 0x0400308E RID: 12430
	public Action<int> OnItemSelected;
}
