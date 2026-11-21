using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000E79 RID: 3705
[NullableContext(1)]
[Nullable(0)]
public class EditFormationTabItem : CommonTabItemBase
{
	// Token: 0x0600947D RID: 38013 RVA: 0x002C0E2B File Offset: 0x002BF02B
	public EditFormationTabItem(bool hasRedDot = true)
	{
		this.HasRedDot = hasRedDot;
	}

	// Token: 0x0600947E RID: 38014 RVA: 0x002C0E3C File Offset: 0x002BF03C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		if (this.HasRedDot)
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
		}
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(this.GetComponentIndex(3), typeof(UUIExtendToggleSpriteTransition)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(this.GetComponentIndex(4), typeof(UUIItem)));
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600947F RID: 38015 RVA: 0x002C0F47 File Offset: 0x002BF147
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		if (this.HasRedDot)
		{
			base.GetItem(2).SetUIActive(false);
		}
	}

	// Token: 0x06009480 RID: 38016 RVA: 0x002C0F75 File Offset: 0x002BF175
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x06009481 RID: 38017 RVA: 0x002C0F7D File Offset: 0x002BF17D
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x06009482 RID: 38018 RVA: 0x002C0F96 File Offset: 0x002BF196
	public void ShowTeamBattleTips(bool isShow = true)
	{
		base.GetItem(this.GetComponentIndex(4)).SetUIActive(isShow);
	}

	// Token: 0x06009483 RID: 38019 RVA: 0x002C0FAB File Offset: 0x002BF1AB
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		CommonTabData data2 = data.Data;
		base.UpdateTabIcon(((data2 != null) ? data2.GetIcon() : null) ?? "");
	}

	// Token: 0x06009484 RID: 38020 RVA: 0x002C0FD0 File Offset: 0x002BF1D0
	protected override void OnUpdateTabIcon(string iconPath)
	{
		this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, new Action<bool>(this.RefreshTransition));
	}

	// Token: 0x06009485 RID: 38021 RVA: 0x002C1004 File Offset: 0x002BF204
	protected void RefreshTransition(bool result)
	{
		UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(this.GetComponentIndex(3));
		if (uiExtendToggleSpriteTransition != null)
		{
			uiExtendToggleSpriteTransition.SetAllStateSprite(base.GetSprite(0).GetSprite());
		}
	}

	// Token: 0x06009486 RID: 38022 RVA: 0x002C1034 File Offset: 0x002BF234
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06009487 RID: 38023 RVA: 0x002C1047 File Offset: 0x002BF247
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x06009488 RID: 38024 RVA: 0x002C1050 File Offset: 0x002BF250
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		if (!this.HasRedDot)
		{
			return;
		}
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, base.GetItem(2), null, uId);
		}
	}

	// Token: 0x06009489 RID: 38025 RVA: 0x002C1088 File Offset: 0x002BF288
	private int GetComponentIndex(int index)
	{
		if (this.HasRedDot || index <= 2)
		{
			return index;
		}
		return index - 1;
	}

	// Token: 0x0600948A RID: 38026 RVA: 0x002C109B File Offset: 0x002BF29B
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x04005721 RID: 22305
	private ERedDotName? RedDotName;

	// Token: 0x04005722 RID: 22306
	private readonly bool HasRedDot;

	// Token: 0x02007077 RID: 28791
	[NullableContext(0)]
	private class EEditFormationTabItem
	{
		// Token: 0x04024AAD RID: 150189
		public const int Icon = 0;

		// Token: 0x04024AAE RID: 150190
		public const int Toggle = 1;

		// Token: 0x04024AAF RID: 150191
		public const int RedDot = 2;

		// Token: 0x04024AB0 RID: 150192
		public const int Transition = 3;

		// Token: 0x04024AB1 RID: 150193
		public const int ItemTip = 4;
	}
}
