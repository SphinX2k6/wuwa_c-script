using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200078D RID: 1933
internal class MapTravelExpComponent : UiPanelBase
{
	// Token: 0x060058AD RID: 22701 RVA: 0x001CD918 File Offset: 0x001CBB18
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060058AE RID: 22702 RVA: 0x001CD9A4 File Offset: 0x001CBBA4
	public void SetProgress(int current, int target, bool isMax)
	{
		if (isMax)
		{
			base.GetSprite(1).SetFillAmount(1f);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "MapTravelLevelMax_Text", Array.Empty<object>());
			return;
		}
		base.GetSprite(1).SetFillAmount(MathUtils.Instance.Clamp((float)current / (float)target, 0f, 1f));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "MapTravelExp_Text", new <>z__ReadOnlyArray<object>(new object[]
		{
			current,
			target
		}));
	}

	// Token: 0x060058AF RID: 22703 RVA: 0x001CDA39 File Offset: 0x001CBC39
	public void SetLevel(int level)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "MapTravelLv_Text", new <>z__ReadOnlySingleElementList<object>(level));
	}

	// Token: 0x02006A75 RID: 27253
	private class EExpComponents
	{
		// Token: 0x04023083 RID: 143491
		public const int TxtLevel = 0;

		// Token: 0x04023084 RID: 143492
		public const int ExpRing = 1;

		// Token: 0x04023085 RID: 143493
		public const int ExpProgress = 2;
	}
}
