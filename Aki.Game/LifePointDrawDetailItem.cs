using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001298 RID: 4760
public class LifePointDrawDetailItem : GridProxyAbstract<int>
{
	// Token: 0x06008245 RID: 33349 RVA: 0x001B9D54 File Offset: 0x001B7F54
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

	// Token: 0x06008246 RID: 33350 RVA: 0x001B9E5D File Offset: 0x001B805D
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

	// Token: 0x06008247 RID: 33351 RVA: 0x001B9E98 File Offset: 0x001B8098
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

	// Token: 0x06008248 RID: 33352 RVA: 0x001B9EF0 File Offset: 0x001B80F0
	private void OnClickToggle(EToggleState toggleState)
	{
		LifePointDrawViewModel lifePointDrawDetailViewModel = this.LifePointDrawDetailViewModel;
		if (lifePointDrawDetailViewModel == null)
		{
			return;
		}
		lifePointDrawDetailViewModel.OnSelectChallenge(this.Data.GetValueOrDefault());
	}

	// Token: 0x06008249 RID: 33353 RVA: 0x001B9F0D File Offset: 0x001B810D
	[NullableContext(1)]
	public void SetModel(LifePointDrawViewModel vm)
	{
		this.LifePointDrawDetailViewModel = vm;
	}

	// Token: 0x0600824A RID: 33354 RVA: 0x001B9F18 File Offset: 0x001B8118
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

	// Token: 0x0600824B RID: 33355 RVA: 0x001BA054 File Offset: 0x001B8254
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.LifePointDrawChallengeRedDot, base.GetItem(4), this.Data.Value);
	}

	// Token: 0x04003ADE RID: 15070
	[Nullable(2)]
	private LifePointDrawViewModel LifePointDrawDetailViewModel;

	// Token: 0x04003ADF RID: 15071
	private int? Data;

	// Token: 0x020078AD RID: 30893
	private class EItemComponent
	{
		// Token: 0x04027C19 RID: 162841
		public const int Toggle = 0;

		// Token: 0x04027C1A RID: 162842
		public const int TitleText = 1;

		// Token: 0x04027C1B RID: 162843
		public const int LockItem = 2;

		// Token: 0x04027C1C RID: 162844
		public const int FinishItem = 3;

		// Token: 0x04027C1D RID: 162845
		public const int RedDotItem = 4;
	}
}
