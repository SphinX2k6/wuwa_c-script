using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B92 RID: 7058
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchHandBookItem : GridProxyAbstract<int>
{
	// Token: 0x0600D224 RID: 53796 RVA: 0x00303810 File Offset: 0x00301A10
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

	// Token: 0x0600D225 RID: 53797 RVA: 0x003038DC File Offset: 0x00301ADC
	protected override void OnStart()
	{
		this.SmallSlotLayout = new GenericLayout<FloroRanchHandBookSmallSlotItem, FloroRanchUnlockDataBase>(base.GetGridLayout(3), new Func<FloroRanchHandBookSmallSlotItem>(this.CreateSmallSlotItem), null, true, false);
	}

	// Token: 0x0600D226 RID: 53798 RVA: 0x00303900 File Offset: 0x00301B00
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

	// Token: 0x0600D227 RID: 53799 RVA: 0x00303954 File Offset: 0x00301B54
	private void TrySelectFirstItem()
	{
		FloroRanchHandBookSmallSlotItem floroRanchHandBookSmallSlotItem = this.SmallSlotLayout.GetLayoutItemList()[0];
		if ((this.IsSelectedItem == null || !this.IsSelectedItem()) && floroRanchHandBookSmallSlotItem != null)
		{
			this.OnClickCallback(floroRanchHandBookSmallSlotItem);
			this.SmallSlotLayout.SelectGridProxy(0, false);
		}
	}

	// Token: 0x0600D228 RID: 53800 RVA: 0x003039A4 File Offset: 0x00301BA4
	private FloroRanchHandBookSmallSlotItem CreateSmallSlotItem()
	{
		FloroRanchHandBookSmallSlotItem floroRanchHandBookSmallSlotItem = new FloroRanchHandBookSmallSlotItem();
		floroRanchHandBookSmallSlotItem.SetActivityDataType(this.ActivityDataType);
		floroRanchHandBookSmallSlotItem.BindClickCallback(this.OnClickCallback);
		return floroRanchHandBookSmallSlotItem;
	}

	// Token: 0x0400604E RID: 24654
	private GenericLayout<FloroRanchHandBookSmallSlotItem, FloroRanchUnlockDataBase> SmallSlotLayout;

	// Token: 0x0400604F RID: 24655
	public EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x04006050 RID: 24656
	public Action<FloroRanchHandBookSmallSlotItem> OnClickCallback = delegate(FloroRanchHandBookSmallSlotItem item)
	{
	};

	// Token: 0x04006051 RID: 24657
	[Nullable(2)]
	public Func<bool> IsSelectedItem;

	// Token: 0x02008119 RID: 33049
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A236 RID: 172598
		public const int TextureTitleIcon = 0;

		// Token: 0x0402A237 RID: 172599
		public const int ItemTitlePanel = 1;

		// Token: 0x0402A238 RID: 172600
		public const int TextTitle = 2;

		// Token: 0x0402A239 RID: 172601
		public const int LayoutSmallSlot = 3;

		// Token: 0x0402A23A RID: 172602
		public const int ItemSmallSlot = 4;
	}
}
