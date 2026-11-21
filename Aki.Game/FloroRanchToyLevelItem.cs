using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001067 RID: 4199
public class FloroRanchToyLevelItem : UiPanelBase
{
	// Token: 0x0600A6E0 RID: 42720 RVA: 0x00312A98 File Offset: 0x00310C98
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A6E1 RID: 42721 RVA: 0x00312B43 File Offset: 0x00310D43
	protected override void OnStart()
	{
		base.GetItem(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(false);
		base.GetText(2).SetUIActive(false);
	}

	// Token: 0x0600A6E2 RID: 42722 RVA: 0x00312B6C File Offset: 0x00310D6C
	public void Refresh(int level)
	{
		if (this.Level == level)
		{
			return;
		}
		this.Level = level;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Farm_ToyLevelText", new <>z__ReadOnlySingleElementList<object>(this.Level));
	}

	// Token: 0x0400616D RID: 24941
	public int Level;

	// Token: 0x020072D9 RID: 29401
	private class EComponentDefine
	{
		// Token: 0x0402566C RID: 153196
		public const int ArrowItem = 0;

		// Token: 0x0402566D RID: 153197
		public const int UpItem = 1;

		// Token: 0x0402566E RID: 153198
		public const int UpText = 2;

		// Token: 0x0402566F RID: 153199
		public const int LevelText = 3;
	}
}
