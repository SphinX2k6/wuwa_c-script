using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002745 RID: 10053
[Nullable(new byte[]
{
	0,
	1
})]
public class RecommendQualityItem : GridProxyAbstract<IRecommendQualityItemData>
{
	// Token: 0x06014A01 RID: 84481 RVA: 0x00537D38 File Offset: 0x00535F38
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleRoot));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014A02 RID: 84482 RVA: 0x00537E20 File Offset: 0x00536020
	[NullableContext(1)]
	public override void Refresh(IRecommendQualityItemData data, bool isSelected, int gridIndex)
	{
		base.SetTextureShowUntilLoaded(data.Bg, base.GetTexture(1), null);
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.ShowTextNew(data.Name);
		}
		UUISprite sprite = base.GetSprite(3);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(data.IsRecommend);
	}

	// Token: 0x06014A03 RID: 84483 RVA: 0x00537E70 File Offset: 0x00536070
	private void OnToggleRoot(EToggleState check)
	{
		if (check == EToggleState.ETT_Checked)
		{
			IScrollViewDelegate<IGridProxy<IRecommendQualityItemData>, IRecommendQualityItemData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate == null)
			{
				return;
			}
			scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
		}
	}

	// Token: 0x06014A04 RID: 84484 RVA: 0x00537E93 File Offset: 0x00536093
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06014A05 RID: 84485 RVA: 0x00537EAB File Offset: 0x005360AB
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x02008DB2 RID: 36274
	private class EChildType
	{
		// Token: 0x0402DFEB RID: 188395
		public const int Root = 0;

		// Token: 0x0402DFEC RID: 188396
		public const int Bg = 1;

		// Token: 0x0402DFED RID: 188397
		public const int Name = 2;

		// Token: 0x0402DFEE RID: 188398
		public const int RecommendIcon = 3;
	}
}
