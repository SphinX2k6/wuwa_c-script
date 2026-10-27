using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B89 RID: 7049
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDebugInfoItem : UiPanelBase, IGridProxy<string>
{
	// Token: 0x17001162 RID: 4450
	// (get) Token: 0x0600D1D2 RID: 53714 RVA: 0x00301F07 File Offset: 0x00300107
	// (set) Token: 0x0600D1D3 RID: 53715 RVA: 0x00301F0F File Offset: 0x0030010F
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

	// Token: 0x17001163 RID: 4451
	// (get) Token: 0x0600D1D4 RID: 53716 RVA: 0x00301F18 File Offset: 0x00300118
	// (set) Token: 0x0600D1D5 RID: 53717 RVA: 0x00301F20 File Offset: 0x00300120
	public int GridIndex { get; set; }

	// Token: 0x17001164 RID: 4452
	// (get) Token: 0x0600D1D6 RID: 53718 RVA: 0x00301F29 File Offset: 0x00300129
	// (set) Token: 0x0600D1D7 RID: 53719 RVA: 0x00301F31 File Offset: 0x00300131
	public int DisplayIndex { get; set; }

	// Token: 0x0600D1D8 RID: 53720 RVA: 0x00301F3C File Offset: 0x0030013C
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

	// Token: 0x0600D1D9 RID: 53721 RVA: 0x00301F84 File Offset: 0x00300184
	public void Refresh(string data, bool isSelected, int gridIndex)
	{
		base.GetText(0).SetText(data, true);
	}

	// Token: 0x0600D1DA RID: 53722 RVA: 0x00301F94 File Offset: 0x00300194
	public UniTask RefreshAsync(string data, bool isSelected, int gridIndex)
	{
		FloroRanchDebugInfoItem.<RefreshAsync>d__15 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<FloroRanchDebugInfoItem.<RefreshAsync>d__15>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D1DB RID: 53723 RVA: 0x00301FCF File Offset: 0x003001CF
	public void Clear()
	{
	}

	// Token: 0x0600D1DC RID: 53724 RVA: 0x00301FD1 File Offset: 0x003001D1
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600D1DD RID: 53725 RVA: 0x00301FD3 File Offset: 0x003001D3
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600D1DE RID: 53726 RVA: 0x00301FD5 File Offset: 0x003001D5
	[return: Nullable(2)]
	public object GetKey(string data, int gridIndex)
	{
		return null;
	}

	// Token: 0x0200810B RID: 33035
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402A1E9 RID: 172521
		public const int Text = 0;
	}
}
