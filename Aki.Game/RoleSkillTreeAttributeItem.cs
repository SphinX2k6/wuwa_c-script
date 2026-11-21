using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E3B RID: 7739
public class RoleSkillTreeAttributeItem : UiPanelBase
{
	// Token: 0x06013237 RID: 78391 RVA: 0x00597C56 File Offset: 0x00595E56
	[NullableContext(1)]
	public RoleSkillTreeAttributeItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06013238 RID: 78392 RVA: 0x00597C6C File Offset: 0x00595E6C
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

	// Token: 0x06013239 RID: 78393 RVA: 0x00597D59 File Offset: 0x00595F59
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(5);
		this.TemplateContainerWidth = ((item != null) ? item.GetWidth() : 0f);
	}

	// Token: 0x0601323A RID: 78394 RVA: 0x00597D78 File Offset: 0x00595F78
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

	// Token: 0x0601323B RID: 78395 RVA: 0x00597EE1 File Offset: 0x005960E1
	public void SetNextLevelItem(bool bActive)
	{
		base.GetItem(2).SetUIActive(bActive);
	}

	// Token: 0x0400A435 RID: 42037
	private float TemplateContainerWidth;

	// Token: 0x0200810D RID: 33037
	private enum EComponent
	{
		// Token: 0x04029BBC RID: 170940
		NameText,
		// Token: 0x04029BBD RID: 170941
		CurValueText,
		// Token: 0x04029BBE RID: 170942
		NextLevelItem,
		// Token: 0x04029BBF RID: 170943
		NextValueText,
		// Token: 0x04029BC0 RID: 170944
		UpArrowItem,
		// Token: 0x04029BC1 RID: 170945
		LeftContainerItem
	}
}
