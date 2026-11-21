using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001048 RID: 4168
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDebugInfoItem : UiPanelBase, IGridProxy<string>
{
	// Token: 0x17001187 RID: 4487
	// (get) Token: 0x0600A5E3 RID: 42467 RVA: 0x0030CFDF File Offset: 0x0030B1DF
	// (set) Token: 0x0600A5E4 RID: 42468 RVA: 0x0030CFE7 File Offset: 0x0030B1E7
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<string>, string> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x17001188 RID: 4488
	// (get) Token: 0x0600A5E5 RID: 42469 RVA: 0x0030CFF0 File Offset: 0x0030B1F0
	// (set) Token: 0x0600A5E6 RID: 42470 RVA: 0x0030CFF8 File Offset: 0x0030B1F8
	public int GridIndex { get; set; }

	// Token: 0x17001189 RID: 4489
	// (get) Token: 0x0600A5E7 RID: 42471 RVA: 0x0030D001 File Offset: 0x0030B201
	// (set) Token: 0x0600A5E8 RID: 42472 RVA: 0x0030D009 File Offset: 0x0030B209
	public int DisplayIndex { get; set; }

	// Token: 0x0600A5E9 RID: 42473 RVA: 0x0030D014 File Offset: 0x0030B214
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A5EA RID: 42474 RVA: 0x0030D05C File Offset: 0x0030B25C
	public void Refresh(string data, bool isSelected, int gridIndex)
	{
		base.GetText(0).SetText(data, true);
	}

	// Token: 0x0600A5EB RID: 42475 RVA: 0x0030D06C File Offset: 0x0030B26C
	public UniTask RefreshAsync(string data, bool isSelected, int gridIndex)
	{
		FloroRanchDebugInfoItem.<RefreshAsync>d__15 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<FloroRanchDebugInfoItem.<RefreshAsync>d__15>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A5EC RID: 42476 RVA: 0x0030D0A7 File Offset: 0x0030B2A7
	public void Clear()
	{
	}

	// Token: 0x0600A5ED RID: 42477 RVA: 0x0030D0A9 File Offset: 0x0030B2A9
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600A5EE RID: 42478 RVA: 0x0030D0AB File Offset: 0x0030B2AB
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600A5EF RID: 42479 RVA: 0x0030D0AD File Offset: 0x0030B2AD
	[return: Nullable(2)]
	public object GetKey(string data, int gridIndex)
	{
		return null;
	}

	// Token: 0x02007299 RID: 29337
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402551D RID: 152861
		public const int Text = 0;
	}
}
