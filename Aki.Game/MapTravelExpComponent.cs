using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012D9 RID: 4825
internal class MapTravelExpComponent : UiPanelBase
{
	// Token: 0x06008512 RID: 34066 RVA: 0x001C4ABC File Offset: 0x001C2CBC
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

	// Token: 0x06008513 RID: 34067 RVA: 0x001C4B48 File Offset: 0x001C2D48
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

	// Token: 0x06008514 RID: 34068 RVA: 0x001C4BDD File Offset: 0x001C2DDD
	public void SetLevel(int level)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "MapTravelLv_Text", new <>z__ReadOnlySingleElementList<object>(level));
	}

	// Token: 0x020078EB RID: 30955
	private class EExpComponents
	{
		// Token: 0x04027D55 RID: 163157
		public const int TxtLevel = 0;

		// Token: 0x04027D56 RID: 163158
		public const int ExpRing = 1;

		// Token: 0x04027D57 RID: 163159
		public const int ExpProgress = 2;
	}
}
