using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000E58 RID: 3672
public class SmallItemTopRightTagComponent : SmallItemGridComponent
{
	// Token: 0x0600937E RID: 37758 RVA: 0x002BEE04 File Offset: 0x002BD004
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

	// Token: 0x0600937F RID: 37759 RVA: 0x002BEE70 File Offset: 0x002BD070
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

	// Token: 0x06009380 RID: 37760 RVA: 0x002BEF31 File Offset: 0x002BD131
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemTopRightText";
	}

	// Token: 0x06009381 RID: 37761 RVA: 0x002BEF38 File Offset: 0x002BD138
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007062 RID: 28770
	private enum EChildType
	{
		// Token: 0x04024A61 RID: 150113
		BgSprite,
		// Token: 0x04024A62 RID: 150114
		TopRightText
	}
}
