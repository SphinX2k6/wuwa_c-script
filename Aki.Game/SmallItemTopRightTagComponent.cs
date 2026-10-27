using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200199B RID: 6555
public class SmallItemTopRightTagComponent : SmallItemGridComponent
{
	// Token: 0x0600BF76 RID: 49014 RVA: 0x002B3E80 File Offset: 0x002B2080
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BF77 RID: 49015 RVA: 0x002B3EEC File Offset: 0x002B20EC
	[NullableContext(2)]
	protected override void OnRefresh(object tempData)
	{
		ISmallItemTopRightTagComponentParams smallItemTopRightTagComponentParams = (ISmallItemTopRightTagComponentParams)tempData;
		string topRightTextId = smallItemTopRightTagComponentParams.TopRightTextId;
		string topRightText = smallItemTopRightTagComponentParams.TopRightText;
		bool flag = StringUtils.IsEmpty(topRightTextId);
		bool flag2 = StringUtils.IsEmpty(topRightText);
		bool flag3 = !flag || !flag2;
		this.SetActive(flag3);
		if (!flag3)
		{
			return;
		}
		UUIText text = base.GetText(1);
		if (topRightTextId != null && !flag)
		{
			object[] topRightTextParameter = smallItemTopRightTagComponentParams.TopRightTextParameter;
			LguiUtil.Instance.SetLocalTextNew(text, topRightTextId, topRightTextParameter);
		}
		else if (topRightText != null && !flag2)
		{
			text.SetText(topRightText, true);
		}
		string topRightTextBgColor = smallItemTopRightTagComponentParams.TopRightTextBgColor;
		if (topRightTextBgColor != null)
		{
			base.GetSprite(0).SetColor(FColor.FromHex(topRightTextBgColor));
		}
		string topRightTextColor = smallItemTopRightTagComponentParams.TopRightTextColor;
		if (topRightTextColor != null)
		{
			base.GetText(1).SetColor(FColor.FromHex(topRightTextColor));
		}
	}

	// Token: 0x0600BF78 RID: 49016 RVA: 0x002B3FAD File Offset: 0x002B21AD
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemTopRightText";
	}

	// Token: 0x0600BF79 RID: 49017 RVA: 0x002B3FB4 File Offset: 0x002B21B4
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007ED3 RID: 32467
	private enum EChildType
	{
		// Token: 0x04029724 RID: 169764
		BgSprite,
		// Token: 0x04029725 RID: 169765
		TopRightText
	}
}
