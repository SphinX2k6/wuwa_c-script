using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029BE RID: 10686
public class ShipTowerPassBuffShowView : UiViewBase
{
	// Token: 0x0601626F RID: 90735 RVA: 0x0059A235 File Offset: 0x00598435
	[NullableContext(1)]
	public ShipTowerPassBuffShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016270 RID: 90736 RVA: 0x0059A240 File Offset: 0x00598440
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

	// Token: 0x06016271 RID: 90737 RVA: 0x0059A288 File Offset: 0x00598488
	private void InitDataParam()
	{
	}

	// Token: 0x06016272 RID: 90738 RVA: 0x0059A28C File Offset: 0x0059848C
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerPassBuffShowView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerPassBuffShowView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016273 RID: 90739 RVA: 0x0059A2D0 File Offset: 0x005984D0
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

	// Token: 0x0400A500 RID: 42240
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<ShipTowerPassBuffShowItem, TItem> BuffScroll;

	// Token: 0x02008FD6 RID: 36822
	public class Params
	{
		// Token: 0x0402E951 RID: 190801
		[Nullable(2)]
		public ShipTowerStageData StageData;
	}

	// Token: 0x02008FD7 RID: 36823
	private static class EChildType
	{
		// Token: 0x0402E952 RID: 190802
		public const int ScrollBar = 0;
	}
}
