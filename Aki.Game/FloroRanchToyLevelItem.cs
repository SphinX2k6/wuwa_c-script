using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001BA8 RID: 7080
public class FloroRanchToyLevelItem : UiPanelBase
{
	// Token: 0x0600D2CF RID: 53967 RVA: 0x003079B8 File Offset: 0x00305BB8
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

	// Token: 0x0600D2D0 RID: 53968 RVA: 0x00307A63 File Offset: 0x00305C63
	protected override void OnStart()
	{
		base.GetItem(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(false);
		base.GetText(2).SetUIActive(false);
	}

	// Token: 0x0600D2D1 RID: 53969 RVA: 0x00307A8C File Offset: 0x00305C8C
	public void Refresh(int level)
	{
		if (this.Level == level)
		{
			return;
		}
		this.Level = level;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Farm_ToyLevelText", new <>z__ReadOnlySingleElementList<object>(this.Level));
	}

	// Token: 0x0400609E RID: 24734
	public int Level;

	// Token: 0x0200814B RID: 33099
	private class EComponentDefine
	{
		// Token: 0x0402A338 RID: 172856
		public const int ArrowItem = 0;

		// Token: 0x0402A339 RID: 172857
		public const int UpItem = 1;

		// Token: 0x0402A33A RID: 172858
		public const int UpText = 2;

		// Token: 0x0402A33B RID: 172859
		public const int LevelText = 3;
	}
}
