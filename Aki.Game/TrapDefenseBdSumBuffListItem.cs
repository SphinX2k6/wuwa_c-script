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

// Token: 0x02002199 RID: 8601
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TrapDefenseBdSumBuffListItem : GridProxyAbstract<TrapDefenseBdData>
{
	// Token: 0x0601529D RID: 86685 RVA: 0x006282D0 File Offset: 0x006264D0
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

	// Token: 0x0601529E RID: 86686 RVA: 0x0062837C File Offset: 0x0062657C
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseBdSumBuffListItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdSumBuffListItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601529F RID: 86687 RVA: 0x006283C0 File Offset: 0x006265C0
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

	// Token: 0x060152A0 RID: 86688 RVA: 0x0062840B File Offset: 0x0062660B
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

	// Token: 0x060152A1 RID: 86689 RVA: 0x00628448 File Offset: 0x00626648
	public override void OnSelected(bool isSelected)
	{
		if (!this.IsFireForBuffClick)
		{
			this.LayoutBdBuff.SelectGridProxy(Math.Max(this.LastSelectBuffIndex, 0), false);
		}
	}

	// Token: 0x060152A2 RID: 86690 RVA: 0x0062846A File Offset: 0x0062666A
	public override void OnDeselected(bool isSelected)
	{
		this.LayoutBdBuff.DeselectCurrentGridProxy();
	}

	// Token: 0x060152A3 RID: 86691 RVA: 0x00628478 File Offset: 0x00626678
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

	// Token: 0x0400B394 RID: 45972
	public TrapDefenseBdData ItemData;

	// Token: 0x0400B395 RID: 45973
	public GenericLayout<TrapDefenseBdBuffItem, TrapDefenseBdBuffData> LayoutBdBuff;

	// Token: 0x0400B396 RID: 45974
	public Action<TrapDefenseBdBuffData, TrapDefenseBdBuffItem> OnSelectBdBuffItemCallBack;

	// Token: 0x0400B397 RID: 45975
	public int LastSelectBuffIndex = -1;

	// Token: 0x0400B398 RID: 45976
	public bool IsFireForBuffClick;

	// Token: 0x0400B399 RID: 45977
	public Func<TrapDefenseBdBuffData, bool> OnIsShowBdBuffLockStateCallback;

	// Token: 0x0400B39A RID: 45978
	public Func<TrapDefenseBdBuffData, bool> OnIsNewTagStateCallback;

	// Token: 0x0400B39B RID: 45979
	public Func<TrapDefenseBdBuffData, TrapDefenseBdBuff> OnGetBdBuffConfig;

	// Token: 0x0200844D RID: 33869
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402AAE4 RID: 174820
		public const int TextureBdIcon = 0;

		// Token: 0x0402AAE5 RID: 174821
		public const int TextTitle = 1;

		// Token: 0x0402AAE6 RID: 174822
		public const int LayoutBdBuff = 2;

		// Token: 0x0402AAE7 RID: 174823
		public const int ItemBdBuff = 3;
	}
}
