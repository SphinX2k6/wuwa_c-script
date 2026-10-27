using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C1B RID: 11291
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseBdBuffStrengthenView : UiViewBase
{
	// Token: 0x06017829 RID: 96297 RVA: 0x005FA6F5 File Offset: 0x005F88F5
	public TrapDefenseBdBuffStrengthenView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0601782A RID: 96298 RVA: 0x005FA700 File Offset: 0x005F8900
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

	// Token: 0x0601782B RID: 96299 RVA: 0x005FA80C File Offset: 0x005F8A0C
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseBdBuffStrengthenView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdBuffStrengthenView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601782C RID: 96300 RVA: 0x005FA84F File Offset: 0x005F8A4F
	protected override void OnStart()
	{
	}

	// Token: 0x0601782D RID: 96301 RVA: 0x005FA851 File Offset: 0x005F8A51
	protected override void OnAddEventListener()
	{
	}

	// Token: 0x0601782E RID: 96302 RVA: 0x005FA853 File Offset: 0x005F8A53
	protected override void OnRemoveEventListener()
	{
	}

	// Token: 0x0601782F RID: 96303 RVA: 0x005FA855 File Offset: 0x005F8A55
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x06017830 RID: 96304 RVA: 0x005FA85D File Offset: 0x005F8A5D
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06017831 RID: 96305 RVA: 0x005FA85F File Offset: 0x005F8A5F
	protected override void OnAfterDestroy()
	{
		TrapDefenseModel.Instance.BdBuffSelectProcessFinish();
	}

	// Token: 0x06017832 RID: 96306 RVA: 0x005FA86B File Offset: 0x005F8A6B
	private void OnClickBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06017833 RID: 96307 RVA: 0x005FA874 File Offset: 0x005F8A74
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

	// Token: 0x06017834 RID: 96308 RVA: 0x005FA8CC File Offset: 0x005F8ACC
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

	// Token: 0x06017835 RID: 96309 RVA: 0x005FA928 File Offset: 0x005F8B28
	protected override void OnAfterPlayStartSequence()
	{
		this.CheckBdUpStageEffect().Forget();
	}

	// Token: 0x06017836 RID: 96310 RVA: 0x005FA938 File Offset: 0x005F8B38
	public UniTask CheckBdUpStageEffect()
	{
		TrapDefenseBdBuffStrengthenView.<CheckBdUpStageEffect>d__18 <CheckBdUpStageEffect>d__;
		<CheckBdUpStageEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckBdUpStageEffect>d__.<>4__this = this;
		<CheckBdUpStageEffect>d__.<>1__state = -1;
		<CheckBdUpStageEffect>d__.<>t__builder.Start<TrapDefenseBdBuffStrengthenView.<CheckBdUpStageEffect>d__18>(ref <CheckBdUpStageEffect>d__);
		return <CheckBdUpStageEffect>d__.<>t__builder.Task;
	}

	// Token: 0x0400AF82 RID: 44930
	public TrapDefenseBdSumBuffDescPanel PanelBdBuffDescLeft;

	// Token: 0x0400AF83 RID: 44931
	public TrapDefenseBdSumBuffDescPanel PanelBdBuffDescRight;

	// Token: 0x0400AF84 RID: 44932
	public TrapDefenseBdBuffData BdBuffData;

	// Token: 0x0400AF85 RID: 44933
	public TrapDefenseBdBuffSelectBdItem BdProgressItem;

	// Token: 0x02009201 RID: 37377
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402F3A9 RID: 193449
		public const int BtnClose = 0;

		// Token: 0x0402F3AA RID: 193450
		public const int ItemBuffDescLeft = 1;

		// Token: 0x0402F3AB RID: 193451
		public const int ItemArrow = 2;

		// Token: 0x0402F3AC RID: 193452
		public const int ItemBuffDescRight = 3;

		// Token: 0x0402F3AD RID: 193453
		public const int ItemBdProgress = 4;
	}
}
