using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001044 RID: 4164
public class FloroRanchDayProgressItem : UiPanelBase
{
	// Token: 0x0600A5D1 RID: 42449 RVA: 0x0030CD68 File Offset: 0x0030AF68
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A5D2 RID: 42450 RVA: 0x0030CE13 File Offset: 0x0030B013
	protected override void OnStart()
	{
		this.PointLayout = new GenericLayout<PointItem, IProgressItem>(base.GetHorizontalLayout(2), new Func<PointItem>(this.CreatePointItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600A5D3 RID: 42451 RVA: 0x0030CE46 File Offset: 0x0030B046
	[NullableContext(1)]
	private PointItem CreatePointItem()
	{
		return new PointItem();
	}

	// Token: 0x0600A5D4 RID: 42452 RVA: 0x0030CE50 File Offset: 0x0030B050
	public void RefreshDay(int remindDay, long maxDay)
	{
		List<IProgressItem> list = new List<IProgressItem>();
		int num = 1;
		while ((long)num <= maxDay)
		{
			list.Add(new ProgressItem
			{
				DayIndex = num,
				IsPassed = ((long)num < maxDay - (long)remindDay + 1L)
			});
			num++;
		}
		GenericLayout<PointItem, IProgressItem> pointLayout = this.PointLayout;
		if (pointLayout == null)
		{
			return;
		}
		pointLayout.RefreshByData(list, delegate
		{
			float fillAmount = 100f / (float)(maxDay - 1L) * (float)(remindDay - 1) / 100f;
			UUISprite sprite = this.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetFillAmount(fillAmount);
			}
			LguiUtil.Instance.SetLocalTextNew(this.GetText(0), "Farm_DayLast", new <>z__ReadOnlySingleElementList<object>(remindDay));
		}, false);
	}

	// Token: 0x04006106 RID: 24838
	[Nullable(1)]
	private GenericLayout<PointItem, IProgressItem> PointLayout;

	// Token: 0x02007296 RID: 29334
	private class EComponentDefine
	{
		// Token: 0x04025515 RID: 152853
		public const int DayText = 0;

		// Token: 0x04025516 RID: 152854
		public const int ProgressSprite = 1;

		// Token: 0x04025517 RID: 152855
		public const int PointLayout = 2;

		// Token: 0x04025518 RID: 152856
		public const int PointItem = 3;
	}
}
