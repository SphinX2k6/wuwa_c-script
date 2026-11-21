using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F39 RID: 7993
public class ShipTowerPassBuffShowView : UiViewBase
{
	// Token: 0x06013C75 RID: 81013 RVA: 0x005C51C1 File Offset: 0x005C33C1
	[NullableContext(1)]
	public ShipTowerPassBuffShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013C76 RID: 81014 RVA: 0x005C51CC File Offset: 0x005C33CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06013C77 RID: 81015 RVA: 0x005C5214 File Offset: 0x005C3414
	private void InitDataParam()
	{
	}

	// Token: 0x06013C78 RID: 81016 RVA: 0x005C5218 File Offset: 0x005C3418
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerPassBuffShowView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerPassBuffShowView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013C79 RID: 81017 RVA: 0x005C525C File Offset: 0x005C345C
	protected override void OnBeforeShow()
	{
		ShipTowerPassBuffShowView.Params @params = this.OpenParam as ShipTowerPassBuffShowView.Params;
		ShipTowerStageData shipTowerStageData = (@params != null) ? @params.StageData : null;
		IReadOnlyList<TItem> readOnlyList = (shipTowerStageData != null) ? shipTowerStageData.GetPassUnlockBuffList() : null;
		IReadOnlyList<TItem> data = readOnlyList ?? Array.Empty<TItem>();
		GenericScrollViewNew<ShipTowerPassBuffShowItem, TItem> buffScroll = this.BuffScroll;
		if (buffScroll == null)
		{
			return;
		}
		buffScroll.RefreshByData(data, null, false);
	}

	// Token: 0x0400A8EA RID: 43242
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<ShipTowerPassBuffShowItem, TItem> BuffScroll;

	// Token: 0x0200821E RID: 33310
	public class Params
	{
		// Token: 0x0402A04E RID: 172110
		[Nullable(2)]
		public ShipTowerStageData StageData;
	}

	// Token: 0x0200821F RID: 33311
	private static class EChildType
	{
		// Token: 0x0402A04F RID: 172111
		public const int ScrollBar = 0;
	}
}
