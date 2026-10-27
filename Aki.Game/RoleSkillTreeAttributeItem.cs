using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028C0 RID: 10432
public class RoleSkillTreeAttributeItem : UiPanelBase
{
	// Token: 0x06015837 RID: 88119 RVA: 0x0056CE0E File Offset: 0x0056B00E
	[NullableContext(1)]
	public RoleSkillTreeAttributeItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06015838 RID: 88120 RVA: 0x0056CE24 File Offset: 0x0056B024
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06015839 RID: 88121 RVA: 0x0056CF11 File Offset: 0x0056B111
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(5);
		this.TemplateContainerWidth = ((item != null) ? item.GetWidth() : 0f);
	}

	// Token: 0x0601583A RID: 88122 RVA: 0x0056CF30 File Offset: 0x0056B130
	[NullableContext(1)]
	public void Refresh(CommonAttributeData curData, [Nullable(2)] CommonAttributeData nextData)
	{
		UUIText text = base.GetText(0);
		UUIText text2 = base.GetText(1);
		text.SetWidth(this.TemplateContainerWidth);
		text2.SetWidth(this.TemplateContainerWidth);
		if (!string.IsNullOrEmpty(curData.AttrBaseValue))
		{
			text2.SetText(curData.AttrBaseValue, true);
		}
		if (!string.IsNullOrEmpty(curData.AttrNameText))
		{
			text.SetText(curData.AttrNameText, true);
		}
		float x = text.GetTextRenderSize().X;
		float x2 = text2.GetTextRenderSize().X;
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("RoleSkillTreeAttributeSpace").GetValueOrDefault();
		float num = this.TemplateContainerWidth - (float)valueOrDefault;
		float num2 = num / 2f;
		if (x + x2 < num)
		{
			text.SetWidth(x);
			text2.SetWidth(x2);
		}
		else if (x >= num2 && x2 >= num2)
		{
			text.SetWidth(num2);
			text2.SetWidth(num2);
		}
		else if (x >= num2)
		{
			text.SetWidth(num - x2);
			text2.SetWidth(x2);
		}
		else
		{
			text.SetWidth(x);
			text2.SetWidth(num - x);
		}
		if (nextData != null && !string.IsNullOrEmpty(nextData.AttrBaseValue))
		{
			UUIText text3 = base.GetText(3);
			text3.SetText(nextData.AttrBaseValue, true);
			bool flag = nextData.AttrBaseValue != curData.AttrBaseValue;
			UUIItem uuiitem = text3;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(text3.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			base.GetItem(4).SetUIActive(flag);
		}
	}

	// Token: 0x0601583B RID: 88123 RVA: 0x0056D099 File Offset: 0x0056B299
	public void SetNextLevelItem(bool bActive)
	{
		base.GetItem(2).SetUIActive(bActive);
	}

	// Token: 0x0400A04C RID: 41036
	private float TemplateContainerWidth;

	// Token: 0x02008EC6 RID: 36550
	private enum EComponent
	{
		// Token: 0x0402E4BF RID: 189631
		NameText,
		// Token: 0x0402E4C0 RID: 189632
		CurValueText,
		// Token: 0x0402E4C1 RID: 189633
		NextLevelItem,
		// Token: 0x0402E4C2 RID: 189634
		NextValueText,
		// Token: 0x0402E4C3 RID: 189635
		UpArrowItem,
		// Token: 0x0402E4C4 RID: 189636
		LeftContainerItem
	}
}
