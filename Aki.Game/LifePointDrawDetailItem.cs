using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200074C RID: 1868
public class LifePointDrawDetailItem : GridProxyAbstract<int>
{
	// Token: 0x060055DC RID: 21980 RVA: 0x001C2A24 File Offset: 0x001C0C24
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060055DD RID: 21981 RVA: 0x001C2B2D File Offset: 0x001C0D2D
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.CanExecuteChange.Unbind();
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
		if (extendToggle2 == null)
		{
			return;
		}
		extendToggle2.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x060055DE RID: 21982 RVA: 0x001C2B68 File Offset: 0x001C0D68
	private bool OnCanExecuteChange()
	{
		LifePointDrawViewModel lifePointDrawDetailViewModel = this.LifePointDrawDetailViewModel;
		if (((lifePointDrawDetailViewModel != null) ? new bool?(lifePointDrawDetailViewModel.GetChallengeLockState(this.Data.GetValueOrDefault())) : null).GetValueOrDefault())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Colorful_Locked", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x060055DF RID: 21983 RVA: 0x001C2BC0 File Offset: 0x001C0DC0
	private void OnClickToggle(EToggleState toggleState)
	{
		LifePointDrawViewModel lifePointDrawDetailViewModel = this.LifePointDrawDetailViewModel;
		if (lifePointDrawDetailViewModel == null)
		{
			return;
		}
		lifePointDrawDetailViewModel.OnSelectChallenge(this.Data.GetValueOrDefault());
	}

	// Token: 0x060055E0 RID: 21984 RVA: 0x001C2BDD File Offset: 0x001C0DDD
	[NullableContext(1)]
	public void SetModel(LifePointDrawViewModel vm)
	{
		this.LifePointDrawDetailViewModel = vm;
	}

	// Token: 0x060055E1 RID: 21985 RVA: 0x001C2BE8 File Offset: 0x001C0DE8
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.Data = new int?(data);
		LifePointDrawViewModel lifePointDrawDetailViewModel = this.LifePointDrawDetailViewModel;
		EToggleState state = ((lifePointDrawDetailViewModel != null) ? new bool?(lifePointDrawDetailViewModel.CheckChallengeIfSelect(data)) : null).GetValueOrDefault() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(state, false, false, false);
		}
		LifePointDrawViewModel lifePointDrawDetailViewModel2 = this.LifePointDrawDetailViewModel;
		bool? flag = (lifePointDrawDetailViewModel2 != null) ? new bool?(lifePointDrawDetailViewModel2.GetChallengeLockState(this.Data.GetValueOrDefault())) : null;
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(flag.GetValueOrDefault());
		}
		LifePointDrawViewModel lifePointDrawDetailViewModel3 = this.LifePointDrawDetailViewModel;
		bool? flag2 = (lifePointDrawDetailViewModel3 != null) ? new bool?(lifePointDrawDetailViewModel3.GetChallengeFinishState(data)) : null;
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(flag2.GetValueOrDefault());
		}
		LifePointDrawViewModel lifePointDrawDetailViewModel4 = this.LifePointDrawDetailViewModel;
		string textStringId = (lifePointDrawDetailViewModel4 != null) ? lifePointDrawDetailViewModel4.GetChallengeTitleId(data) : null;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		RedDotController.Instance.UnBindGivenUi(ERedDotName.LifePointDrawChallengeRedDot, base.GetItem(4), data);
		RedDotController.Instance.BindRedDot(ERedDotName.LifePointDrawChallengeRedDot, base.GetItem(4), null, data);
	}

	// Token: 0x060055E2 RID: 21986 RVA: 0x001C2D24 File Offset: 0x001C0F24
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.LifePointDrawChallengeRedDot, base.GetItem(4), this.Data.Value);
	}

	// Token: 0x04003B76 RID: 15222
	[Nullable(2)]
	private LifePointDrawViewModel LifePointDrawDetailViewModel;

	// Token: 0x04003B77 RID: 15223
	private int? Data;

	// Token: 0x02006A38 RID: 27192
	private class EItemComponent
	{
		// Token: 0x04022F4A RID: 143178
		public const int Toggle = 0;

		// Token: 0x04022F4B RID: 143179
		public const int TitleText = 1;

		// Token: 0x04022F4C RID: 143180
		public const int LockItem = 2;

		// Token: 0x04022F4D RID: 143181
		public const int FinishItem = 3;

		// Token: 0x04022F4E RID: 143182
		public const int RedDotItem = 4;
	}
}
