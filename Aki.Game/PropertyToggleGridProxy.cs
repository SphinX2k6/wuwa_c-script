using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000D23 RID: 3363
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PropertyToggleGridProxy : GridProxyAbstract<FilterItemData>
{
	// Token: 0x06008B44 RID: 35652 RVA: 0x002A1A5C File Offset: 0x0029FC5C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleChanged));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008B45 RID: 35653 RVA: 0x002A1B44 File Offset: 0x0029FD44
	protected override void OnStart()
	{
		base.GetTexture(2).SetUIActive(true);
		base.GetSprite(3).SetUIActive(false);
	}

	// Token: 0x06008B46 RID: 35654 RVA: 0x002A1B60 File Offset: 0x0029FD60
	private void OnToggleChanged(EToggleState state)
	{
		bool isChecked = state == EToggleState.ETT_Checked;
		if (this.ToggleFunction != null)
		{
			this.ToggleFunction(isChecked, this.Data.FilterId, this.Data.Content ?? "");
		}
	}

	// Token: 0x06008B47 RID: 35655 RVA: 0x002A1BA8 File Offset: 0x0029FDA8
	public override void Refresh(FilterItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		UUIText text = base.GetText(4);
		if (text != null)
		{
			text.SetText(data.Content ?? "", true);
		}
		UUITexture texture = base.GetTexture(2);
		if (texture != null)
		{
			base.SetTextureByPath(data.GetIconPath() ?? "", texture, null, null);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x06008B48 RID: 35656 RVA: 0x002A1C24 File Offset: 0x0029FE24
	public void SetToggleFunction(TPropertyToggleFunction func)
	{
		this.ToggleFunction = func;
	}

	// Token: 0x06008B49 RID: 35657 RVA: 0x002A1C30 File Offset: 0x0029FE30
	public void SetSelectedState(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x04005367 RID: 21351
	[Nullable(2)]
	private TPropertyToggleFunction ToggleFunction;

	// Token: 0x04005368 RID: 21352
	[Nullable(2)]
	public FilterItemData Data;

	// Token: 0x02006FB4 RID: 28596
	[NullableContext(0)]
	private class EPropertyToggleDefine
	{
		// Token: 0x040247E4 RID: 149476
		public const int Toggle = 0;

		// Token: 0x040247E5 RID: 149477
		public const int TexIcon = 2;

		// Token: 0x040247E6 RID: 149478
		public const int SpriteIcon = 3;

		// Token: 0x040247E7 RID: 149479
		public const int PropertyText = 4;
	}
}
