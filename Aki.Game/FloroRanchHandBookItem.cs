using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001051 RID: 4177
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchHandBookItem : GridProxyAbstract<int>
{
	// Token: 0x0600A635 RID: 42549 RVA: 0x0030E8E8 File Offset: 0x0030CAE8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A636 RID: 42550 RVA: 0x0030E9B4 File Offset: 0x0030CBB4
	protected override void OnStart()
	{
		this.SmallSlotLayout = new GenericLayout<FloroRanchHandBookSmallSlotItem, FloroRanchUnlockDataBase>(base.GetGridLayout(3), new Func<FloroRanchHandBookSmallSlotItem>(this.CreateSmallSlotItem), null, true, false);
	}

	// Token: 0x0600A637 RID: 42551 RVA: 0x0030E9D8 File Offset: 0x0030CBD8
	public override UniTask RefreshAsync(int data, bool isSelected, int gridIndex)
	{
		FloroRanchHandBookItem.<RefreshAsync>d__7 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.gridIndex = gridIndex;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<FloroRanchHandBookItem.<RefreshAsync>d__7>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A638 RID: 42552 RVA: 0x0030EA2C File Offset: 0x0030CC2C
	private void TrySelectFirstItem()
	{
		FloroRanchHandBookSmallSlotItem floroRanchHandBookSmallSlotItem = this.SmallSlotLayout.GetLayoutItemList()[0];
		if ((this.IsSelectedItem == null || !this.IsSelectedItem()) && floroRanchHandBookSmallSlotItem != null)
		{
			this.OnClickCallback(floroRanchHandBookSmallSlotItem);
			this.SmallSlotLayout.SelectGridProxy(0, false);
		}
	}

	// Token: 0x0600A639 RID: 42553 RVA: 0x0030EA7C File Offset: 0x0030CC7C
	private FloroRanchHandBookSmallSlotItem CreateSmallSlotItem()
	{
		FloroRanchHandBookSmallSlotItem floroRanchHandBookSmallSlotItem = new FloroRanchHandBookSmallSlotItem();
		floroRanchHandBookSmallSlotItem.SetActivityDataType(this.ActivityDataType);
		floroRanchHandBookSmallSlotItem.BindClickCallback(this.OnClickCallback);
		return floroRanchHandBookSmallSlotItem;
	}

	// Token: 0x0400611D RID: 24861
	private GenericLayout<FloroRanchHandBookSmallSlotItem, FloroRanchUnlockDataBase> SmallSlotLayout;

	// Token: 0x0400611E RID: 24862
	public EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x0400611F RID: 24863
	public Action<FloroRanchHandBookSmallSlotItem> OnClickCallback = delegate(FloroRanchHandBookSmallSlotItem item)
	{
	};

	// Token: 0x04006120 RID: 24864
	[Nullable(2)]
	public Func<bool> IsSelectedItem;

	// Token: 0x020072A7 RID: 29351
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402556A RID: 152938
		public const int TextureTitleIcon = 0;

		// Token: 0x0402556B RID: 152939
		public const int ItemTitlePanel = 1;

		// Token: 0x0402556C RID: 152940
		public const int TextTitle = 2;

		// Token: 0x0402556D RID: 152941
		public const int LayoutSmallSlot = 3;

		// Token: 0x0402556E RID: 152942
		public const int ItemSmallSlot = 4;
	}
}
