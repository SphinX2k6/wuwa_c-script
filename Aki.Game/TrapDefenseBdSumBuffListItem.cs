using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C1E RID: 11294
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TrapDefenseBdSumBuffListItem : GridProxyAbstract<TrapDefenseBdData>
{
	// Token: 0x0601786B RID: 96363 RVA: 0x005FB8AC File Offset: 0x005F9AAC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601786C RID: 96364 RVA: 0x005FB958 File Offset: 0x005F9B58
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseBdSumBuffListItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdSumBuffListItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601786D RID: 96365 RVA: 0x005FB99C File Offset: 0x005F9B9C
	public override UniTask RefreshAsync(TrapDefenseBdData data, bool isSelected, int gridIndex)
	{
		TrapDefenseBdSumBuffListItem.<RefreshAsync>d__11 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<TrapDefenseBdSumBuffListItem.<RefreshAsync>d__11>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601786E RID: 96366 RVA: 0x005FB9E7 File Offset: 0x005F9BE7
	private TrapDefenseBdBuffItem CreateItemBdBuff()
	{
		return new TrapDefenseBdBuffItem
		{
			OnSelectBuffItemCallback = new Action<TrapDefenseBdBuffData, TrapDefenseBdBuffItem>(this.OnSelectBdBuffItem),
			OnIsShowBdBuffLockStateCallback = this.OnIsShowBdBuffLockStateCallback,
			OnIsNewTagStateCallback = this.OnIsNewTagStateCallback,
			OnGetBdBuffConfig = this.OnGetBdBuffConfig
		};
	}

	// Token: 0x0601786F RID: 96367 RVA: 0x005FBA24 File Offset: 0x005F9C24
	public override void OnSelected(bool isSelected)
	{
		if (!this.IsFireForBuffClick)
		{
			this.LayoutBdBuff.SelectGridProxy(Math.Max(this.LastSelectBuffIndex, 0), false);
		}
	}

	// Token: 0x06017870 RID: 96368 RVA: 0x005FBA46 File Offset: 0x005F9C46
	public override void OnDeselected(bool isSelected)
	{
		this.LayoutBdBuff.DeselectCurrentGridProxy();
	}

	// Token: 0x06017871 RID: 96369 RVA: 0x005FBA54 File Offset: 0x005F9C54
	private void OnSelectBdBuffItem(TrapDefenseBdBuffData data, TrapDefenseBdBuffItem item)
	{
		this.IsFireForBuffClick = true;
		IScrollViewDelegate<IGridProxy<TrapDefenseBdData>, TrapDefenseBdData> scrollViewDelegate = base.ScrollViewDelegate;
		if (scrollViewDelegate != null)
		{
			scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
		}
		Action<TrapDefenseBdBuffData, TrapDefenseBdBuffItem> onSelectBdBuffItemCallBack = this.OnSelectBdBuffItemCallBack;
		if (onSelectBdBuffItemCallBack != null)
		{
			onSelectBdBuffItemCallBack(data, item);
		}
		this.IsFireForBuffClick = false;
	}

	// Token: 0x0400AF8F RID: 44943
	public TrapDefenseBdData ItemData;

	// Token: 0x0400AF90 RID: 44944
	public GenericLayout<TrapDefenseBdBuffItem, TrapDefenseBdBuffData> LayoutBdBuff;

	// Token: 0x0400AF91 RID: 44945
	public Action<TrapDefenseBdBuffData, TrapDefenseBdBuffItem> OnSelectBdBuffItemCallBack;

	// Token: 0x0400AF92 RID: 44946
	public int LastSelectBuffIndex = -1;

	// Token: 0x0400AF93 RID: 44947
	public bool IsFireForBuffClick;

	// Token: 0x0400AF94 RID: 44948
	public Func<TrapDefenseBdBuffData, bool> OnIsShowBdBuffLockStateCallback;

	// Token: 0x0400AF95 RID: 44949
	public Func<TrapDefenseBdBuffData, bool> OnIsNewTagStateCallback;

	// Token: 0x0400AF96 RID: 44950
	public Func<TrapDefenseBdBuffData, TrapDefenseBdBuff> OnGetBdBuffConfig;

	// Token: 0x0200920A RID: 37386
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402F3E3 RID: 193507
		public const int TextureBdIcon = 0;

		// Token: 0x0402F3E4 RID: 193508
		public const int TextTitle = 1;

		// Token: 0x0402F3E5 RID: 193509
		public const int LayoutBdBuff = 2;

		// Token: 0x0402F3E6 RID: 193510
		public const int ItemBdBuff = 3;
	}
}
