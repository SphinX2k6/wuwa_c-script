using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200186A RID: 6250
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PropertyToggleGridProxy : GridProxyAbstract<FilterItemData>
{
	// Token: 0x0600B75B RID: 46939 RVA: 0x00297338 File Offset: 0x00295538
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

	// Token: 0x0600B75C RID: 46940 RVA: 0x00297420 File Offset: 0x00295620
	protected override void OnStart()
	{
		base.GetTexture(2).SetUIActive(true);
		base.GetSprite(3).SetUIActive(false);
	}

	// Token: 0x0600B75D RID: 46941 RVA: 0x0029743C File Offset: 0x0029563C
	private void OnToggleChanged(EToggleState state)
	{
		bool isChecked = state == EToggleState.ETT_Checked;
		if (this.ToggleFunction != null)
		{
			this.ToggleFunction(isChecked, this.Data.FilterId, this.Data.Content ?? "");
		}
	}

	// Token: 0x0600B75E RID: 46942 RVA: 0x00297484 File Offset: 0x00295684
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

	// Token: 0x0600B75F RID: 46943 RVA: 0x00297500 File Offset: 0x00295700
	public void SetToggleFunction(TPropertyToggleFunction func)
	{
		this.ToggleFunction = func;
	}

	// Token: 0x0600B760 RID: 46944 RVA: 0x0029750C File Offset: 0x0029570C
	public void SetSelectedState(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x040052BC RID: 21180
	[Nullable(2)]
	private TPropertyToggleFunction ToggleFunction;

	// Token: 0x040052BD RID: 21181
	[Nullable(2)]
	public FilterItemData Data;

	// Token: 0x02007E2D RID: 32301
	[NullableContext(0)]
	private class EPropertyToggleDefine
	{
		// Token: 0x040294B7 RID: 169143
		public const int Toggle = 0;

		// Token: 0x040294B8 RID: 169144
		public const int TexIcon = 2;

		// Token: 0x040294B9 RID: 169145
		public const int SpriteIcon = 3;

		// Token: 0x040294BA RID: 169146
		public const int PropertyText = 4;
	}
}
