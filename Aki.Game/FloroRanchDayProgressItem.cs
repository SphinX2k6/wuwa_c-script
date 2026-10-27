using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B85 RID: 7045
public class FloroRanchDayProgressItem : UiPanelBase
{
	// Token: 0x0600D1C0 RID: 53696 RVA: 0x00301C90 File Offset: 0x002FFE90
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

	// Token: 0x0600D1C1 RID: 53697 RVA: 0x00301D3B File Offset: 0x002FFF3B
	protected override void OnStart()
	{
		this.PointLayout = new GenericLayout<PointItem, IProgressItem>(base.GetHorizontalLayout(2), new Func<PointItem>(this.CreatePointItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600D1C2 RID: 53698 RVA: 0x00301D6E File Offset: 0x002FFF6E
	[NullableContext(1)]
	private PointItem CreatePointItem()
	{
		return new PointItem();
	}

	// Token: 0x0600D1C3 RID: 53699 RVA: 0x00301D78 File Offset: 0x002FFF78
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

	// Token: 0x04006037 RID: 24631
	[Nullable(1)]
	private GenericLayout<PointItem, IProgressItem> PointLayout;

	// Token: 0x02008108 RID: 33032
	private class EComponentDefine
	{
		// Token: 0x0402A1E1 RID: 172513
		public const int DayText = 0;

		// Token: 0x0402A1E2 RID: 172514
		public const int ProgressSprite = 1;

		// Token: 0x0402A1E3 RID: 172515
		public const int PointLayout = 2;

		// Token: 0x0402A1E4 RID: 172516
		public const int PointItem = 3;
	}
}
