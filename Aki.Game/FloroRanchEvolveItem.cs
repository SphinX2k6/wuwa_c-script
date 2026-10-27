using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B90 RID: 7056
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchEvolveItem : UiPanelBase
{
	// Token: 0x0600D218 RID: 53784 RVA: 0x00303164 File Offset: 0x00301364
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

	// Token: 0x0600D219 RID: 53785 RVA: 0x0030320F File Offset: 0x0030140F
	protected override void OnStart()
	{
		this.TemplateItem = base.GetItem(2);
		this.TemplateItem.SetUIActive(false);
	}

	// Token: 0x0600D21A RID: 53786 RVA: 0x0030322C File Offset: 0x0030142C
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

	// Token: 0x0600D21B RID: 53787 RVA: 0x00303298 File Offset: 0x00301498
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

	// Token: 0x0600D21C RID: 53788 RVA: 0x00303357 File Offset: 0x00301557
	private UUIItem CreateItem()
	{
		return LguiUtil.Instance.CopyItem(this.TemplateItem, base.GetItem(3));
	}

	// Token: 0x04006049 RID: 24649
	private const int LINE_ROTATOR_YAW_OFFSET = 180;

	// Token: 0x0400604A RID: 24650
	private UUIItem TemplateItem;

	// Token: 0x0400604B RID: 24651
	private readonly List<UUIItem> LineItemList = new List<UUIItem>();

	// Token: 0x02008117 RID: 33047
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402A225 RID: 172581
		public const int ProgressSprite = 0;

		// Token: 0x0402A226 RID: 172582
		public const int LevelText = 1;

		// Token: 0x0402A227 RID: 172583
		public const int LineItem = 2;

		// Token: 0x0402A228 RID: 172584
		public const int LineRoot = 3;
	}
}
