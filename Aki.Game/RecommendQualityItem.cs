using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C30 RID: 7216
[Nullable(new byte[]
{
	0,
	1
})]
public class RecommendQualityItem : GridProxyAbstract<IRecommendQualityItemData>
{
	// Token: 0x06011EE3 RID: 73443 RVA: 0x00546B0C File Offset: 0x00544D0C
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

	// Token: 0x06011EE4 RID: 73444 RVA: 0x00546BF4 File Offset: 0x00544DF4
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

	// Token: 0x06011EE5 RID: 73445 RVA: 0x00546C44 File Offset: 0x00544E44
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

	// Token: 0x06011EE6 RID: 73446 RVA: 0x00546C67 File Offset: 0x00544E67
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06011EE7 RID: 73447 RVA: 0x00546C7F File Offset: 0x00544E7F
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x02007F3B RID: 32571
	private class EChildType
	{
		// Token: 0x04029302 RID: 168706
		public const int Root = 0;

		// Token: 0x04029303 RID: 168707
		public const int Bg = 1;

		// Token: 0x04029304 RID: 168708
		public const int Name = 2;

		// Token: 0x04029305 RID: 168709
		public const int RecommendIcon = 3;
	}
}
