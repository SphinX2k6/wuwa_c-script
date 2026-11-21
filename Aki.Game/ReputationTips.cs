using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200144F RID: 5199
public class ReputationTips : UiViewBase
{
	// Token: 0x0600CEC8 RID: 52936 RVA: 0x003D78D4 File Offset: 0x003D5AD4
	[NullableContext(1)]
	public ReputationTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CEC9 RID: 52937 RVA: 0x003D78E0 File Offset: 0x003D5AE0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CECA RID: 52938 RVA: 0x003D7949 File Offset: 0x003D5B49
	protected override void OnBeforeCreate()
	{
		this.ItemList = (IntPair[])this.OpenParam;
	}

	// Token: 0x0600CECB RID: 52939 RVA: 0x003D795C File Offset: 0x003D5B5C
	protected override void OnStart()
	{
		this.DailyTask = new ReputationTipsItem(base.GetItem(0));
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x0600CECC RID: 52940 RVA: 0x003D797D File Offset: 0x003D5B7D
	protected override void OnAfterShow()
	{
		this.DailyTask.UpdateItem(this.ItemList[0].Item1, this.ItemList[0].Item2);
	}

	// Token: 0x0600CECD RID: 52941 RVA: 0x003D79AC File Offset: 0x003D5BAC
	protected override void OnBeforeDestroy()
	{
		this.DailyTask.Destroy(null);
		this.DailyTask = null;
	}

	// Token: 0x04007597 RID: 30103
	[Nullable(2)]
	private ReputationTipsItem DailyTask;

	// Token: 0x04007598 RID: 30104
	[Nullable(2)]
	private IntPair[] ItemList;

	// Token: 0x020076FC RID: 30460
	private enum EReputationTips
	{
		// Token: 0x04026A75 RID: 158325
		DailyTask,
		// Token: 0x04026A76 RID: 158326
		WorldEvent
	}
}
