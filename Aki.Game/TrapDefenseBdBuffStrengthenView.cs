using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002196 RID: 8598
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseBdBuffStrengthenView : UiViewBase
{
	// Token: 0x0601525B RID: 86619 RVA: 0x00627119 File Offset: 0x00625319
	public TrapDefenseBdBuffStrengthenView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0601525C RID: 86620 RVA: 0x00627124 File Offset: 0x00625324
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnClose));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601525D RID: 86621 RVA: 0x00627230 File Offset: 0x00625430
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseBdBuffStrengthenView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdBuffStrengthenView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601525E RID: 86622 RVA: 0x00627273 File Offset: 0x00625473
	protected override void OnStart()
	{
	}

	// Token: 0x0601525F RID: 86623 RVA: 0x00627275 File Offset: 0x00625475
	protected override void OnAddEventListener()
	{
	}

	// Token: 0x06015260 RID: 86624 RVA: 0x00627277 File Offset: 0x00625477
	protected override void OnRemoveEventListener()
	{
	}

	// Token: 0x06015261 RID: 86625 RVA: 0x00627279 File Offset: 0x00625479
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x06015262 RID: 86626 RVA: 0x00627281 File Offset: 0x00625481
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06015263 RID: 86627 RVA: 0x00627283 File Offset: 0x00625483
	protected override void OnAfterDestroy()
	{
		TrapDefenseModel.Instance.BdBuffSelectProcessFinish();
	}

	// Token: 0x06015264 RID: 86628 RVA: 0x0062728F File Offset: 0x0062548F
	private void OnClickBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06015265 RID: 86629 RVA: 0x00627298 File Offset: 0x00625498
	public void UpdateData()
	{
		if (this.BdBuffData == null)
		{
			return;
		}
		this.PanelBdBuffDescLeft.SetActive(true);
		this.PanelBdBuffDescRight.SetActive(true);
		this.PanelBdBuffDescLeft.UpdateDataStrengthenModeBefore(this.BdBuffData);
		this.PanelBdBuffDescRight.UpdateDataStrengthenModeAfter(this.BdBuffData);
		this.UpdateBdProgressItem();
	}

	// Token: 0x06015266 RID: 86630 RVA: 0x006272F0 File Offset: 0x006254F0
	private void UpdateBdProgressItem()
	{
		TrapDefenseBdData belongBdData = this.BdBuffData.GetBelongBdData();
		bool flag = !belongBdData.IsZeroBdType();
		this.BdProgressItem.SetActive(flag);
		if (flag)
		{
			if (TrapDefenseModel.Instance.RougeModeData.IsCheckBdProgress)
			{
				this.BdProgressItem.RefreshCheckProgress(belongBdData);
				return;
			}
			this.BdProgressItem.RefreshItem(belongBdData);
		}
	}

	// Token: 0x06015267 RID: 86631 RVA: 0x0062734C File Offset: 0x0062554C
	protected override void OnAfterPlayStartSequence()
	{
		this.CheckBdUpStageEffect().Forget();
	}

	// Token: 0x06015268 RID: 86632 RVA: 0x0062735C File Offset: 0x0062555C
	public UniTask CheckBdUpStageEffect()
	{
		TrapDefenseBdBuffStrengthenView.<CheckBdUpStageEffect>d__18 <CheckBdUpStageEffect>d__;
		<CheckBdUpStageEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckBdUpStageEffect>d__.<>4__this = this;
		<CheckBdUpStageEffect>d__.<>1__state = -1;
		<CheckBdUpStageEffect>d__.<>t__builder.Start<TrapDefenseBdBuffStrengthenView.<CheckBdUpStageEffect>d__18>(ref <CheckBdUpStageEffect>d__);
		return <CheckBdUpStageEffect>d__.<>t__builder.Task;
	}

	// Token: 0x0400B387 RID: 45959
	public TrapDefenseBdSumBuffDescPanel PanelBdBuffDescLeft;

	// Token: 0x0400B388 RID: 45960
	public TrapDefenseBdSumBuffDescPanel PanelBdBuffDescRight;

	// Token: 0x0400B389 RID: 45961
	public TrapDefenseBdBuffData BdBuffData;

	// Token: 0x0400B38A RID: 45962
	public TrapDefenseBdBuffSelectBdItem BdProgressItem;

	// Token: 0x02008444 RID: 33860
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402AAAA RID: 174762
		public const int BtnClose = 0;

		// Token: 0x0402AAAB RID: 174763
		public const int ItemBuffDescLeft = 1;

		// Token: 0x0402AAAC RID: 174764
		public const int ItemArrow = 2;

		// Token: 0x0402AAAD RID: 174765
		public const int ItemBuffDescRight = 3;

		// Token: 0x0402AAAE RID: 174766
		public const int ItemBdProgress = 4;
	}
}
