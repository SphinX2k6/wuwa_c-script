using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200104F RID: 4175
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEvolveItem : UiPanelBase
{
	// Token: 0x0600A629 RID: 42537 RVA: 0x0030E23C File Offset: 0x0030C43C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A62A RID: 42538 RVA: 0x0030E2E7 File Offset: 0x0030C4E7
	protected override void OnStart()
	{
		this.TemplateItem = base.GetItem(2);
		this.TemplateItem.SetUIActive(false);
	}

	// Token: 0x0600A62B RID: 42539 RVA: 0x0030E304 File Offset: 0x0030C504
	[NullableContext(2)]
	public void Refresh(FloroRanchEvolveData evolveData)
	{
		if (evolveData == null)
		{
			base.GetRootItem().SetUIActive(false);
			return;
		}
		base.GetRootItem().SetUIActive(true);
		base.GetText(1).SetText(evolveData.CurLevel.ToString(), true);
		base.GetSprite(0).SetFillAmount((float)evolveData.CurExp * 1f / (float)evolveData.ExpPerLevel);
		this.RefreshLineItem(evolveData);
	}

	// Token: 0x0600A62C RID: 42540 RVA: 0x0030E370 File Offset: 0x0030C570
	private void RefreshLineItem(FloroRanchEvolveData evolveData)
	{
		if (this.LineItemList.Count < evolveData.ExpPerLevel)
		{
			for (int i = this.LineItemList.Count; i < evolveData.ExpPerLevel; i++)
			{
				UUIItem item = this.CreateItem();
				this.LineItemList.Add(item);
			}
		}
		float num = 360f / (float)evolveData.ExpPerLevel;
		for (int j = 0; j < this.LineItemList.Count; j++)
		{
			UUIItem uuiitem = this.LineItemList[j];
			if (j >= evolveData.ExpPerLevel)
			{
				uuiitem.SetUIActive(false);
			}
			else
			{
				uuiitem.SetUIActive(true);
				FRotator frotator = new FRotator(0f, 180f - num * (float)j, 0f);
				uuiitem.SetUIRelativeRotation(frotator);
			}
		}
	}

	// Token: 0x0600A62D RID: 42541 RVA: 0x0030E42F File Offset: 0x0030C62F
	private UUIItem CreateItem()
	{
		return LguiUtil.Instance.CopyItem(this.TemplateItem, base.GetItem(3));
	}

	// Token: 0x04006118 RID: 24856
	private const int LINE_ROTATOR_YAW_OFFSET = 180;

	// Token: 0x04006119 RID: 24857
	private UUIItem TemplateItem;

	// Token: 0x0400611A RID: 24858
	private readonly List<UUIItem> LineItemList = new List<UUIItem>();

	// Token: 0x020072A5 RID: 29349
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04025559 RID: 152921
		public const int ProgressSprite = 0;

		// Token: 0x0402555A RID: 152922
		public const int LevelText = 1;

		// Token: 0x0402555B RID: 152923
		public const int LineItem = 2;

		// Token: 0x0402555C RID: 152924
		public const int LineRoot = 3;
	}
}
