using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F8D RID: 8077
public class ReputationTips : UiViewBase
{
	// Token: 0x0600FAA9 RID: 64169 RVA: 0x003CBDA1 File Offset: 0x003C9FA1
	[NullableContext(1)]
	public ReputationTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FAAA RID: 64170 RVA: 0x003CBDAC File Offset: 0x003C9FAC
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

	// Token: 0x0600FAAB RID: 64171 RVA: 0x003CBE15 File Offset: 0x003CA015
	protected override void OnBeforeCreate()
	{
		this.ItemList = (IntPair[])this.OpenParam;
	}

	// Token: 0x0600FAAC RID: 64172 RVA: 0x003CBE28 File Offset: 0x003CA028
	protected override void OnStart()
	{
		this.DailyTask = new ReputationTipsItem(base.GetItem(0));
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x0600FAAD RID: 64173 RVA: 0x003CBE49 File Offset: 0x003CA049
	protected override void OnAfterShow()
	{
		this.DailyTask.UpdateItem(this.ItemList[0].Item1, this.ItemList[0].Item2);
	}

	// Token: 0x0600FAAE RID: 64174 RVA: 0x003CBE78 File Offset: 0x003CA078
	protected override void OnBeforeDestroy()
	{
		this.DailyTask.Destroy(null);
		this.DailyTask = null;
	}

	// Token: 0x040074B6 RID: 29878
	[Nullable(2)]
	private ReputationTipsItem DailyTask;

	// Token: 0x040074B7 RID: 29879
	[Nullable(2)]
	private IntPair[] ItemList;

	// Token: 0x02008577 RID: 34167
	private enum EReputationTips
	{
		// Token: 0x0402B752 RID: 178002
		DailyTask,
		// Token: 0x0402B753 RID: 178003
		WorldEvent
	}
}
