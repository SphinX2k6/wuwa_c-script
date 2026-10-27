using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x020019BB RID: 6587
[NullableContext(1)]
[Nullable(0)]
public class EditFormationTabItem : CommonTabItemBase
{
	// Token: 0x0600C073 RID: 49267 RVA: 0x002B5E9B File Offset: 0x002B409B
	public EditFormationTabItem(bool hasRedDot = true)
	{
		this.HasRedDot = hasRedDot;
	}

	// Token: 0x0600C074 RID: 49268 RVA: 0x002B5EAC File Offset: 0x002B40AC
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

	// Token: 0x0600C075 RID: 49269 RVA: 0x002B5FB7 File Offset: 0x002B41B7
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		if (this.HasRedDot)
		{
			base.GetItem(2).SetUIActive(false);
		}
	}

	// Token: 0x0600C076 RID: 49270 RVA: 0x002B5FE5 File Offset: 0x002B41E5
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0600C077 RID: 49271 RVA: 0x002B5FED File Offset: 0x002B41ED
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x0600C078 RID: 49272 RVA: 0x002B6006 File Offset: 0x002B4206
	public void ShowTeamBattleTips(bool isShow = true)
	{
		base.GetItem(this.GetComponentIndex(4)).SetUIActive(isShow);
	}

	// Token: 0x0600C079 RID: 49273 RVA: 0x002B601B File Offset: 0x002B421B
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		CommonTabData data2 = data.Data;
		base.UpdateTabIcon(((data2 != null) ? data2.GetIcon() : null) ?? "");
	}

	// Token: 0x0600C07A RID: 49274 RVA: 0x002B6040 File Offset: 0x002B4240
	protected override void OnUpdateTabIcon(string iconPath)
	{
		this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, new Action<bool>(this.RefreshTransition));
	}

	// Token: 0x0600C07B RID: 49275 RVA: 0x002B6074 File Offset: 0x002B4274
	protected void RefreshTransition(bool result)
	{
		UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(this.GetComponentIndex(3));
		if (uiExtendToggleSpriteTransition != null)
		{
			uiExtendToggleSpriteTransition.SetAllStateSprite(base.GetSprite(0).GetSprite());
		}
	}

	// Token: 0x0600C07C RID: 49276 RVA: 0x002B60A4 File Offset: 0x002B42A4
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x0600C07D RID: 49277 RVA: 0x002B60B7 File Offset: 0x002B42B7
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x0600C07E RID: 49278 RVA: 0x002B60C0 File Offset: 0x002B42C0
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

	// Token: 0x0600C07F RID: 49279 RVA: 0x002B60F8 File Offset: 0x002B42F8
	private int GetComponentIndex(int index)
	{
		if (this.HasRedDot || index <= 2)
		{
			return index;
		}
		return index - 1;
	}

	// Token: 0x0600C080 RID: 49280 RVA: 0x002B610B File Offset: 0x002B430B
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x0400566F RID: 22127
	private ERedDotName? RedDotName;

	// Token: 0x04005670 RID: 22128
	private readonly bool HasRedDot;

	// Token: 0x02007EE8 RID: 32488
	[NullableContext(0)]
	private class EEditFormationTabItem
	{
		// Token: 0x04029770 RID: 169840
		public const int Icon = 0;

		// Token: 0x04029771 RID: 169841
		public const int Toggle = 1;

		// Token: 0x04029772 RID: 169842
		public const int RedDot = 2;

		// Token: 0x04029773 RID: 169843
		public const int Transition = 3;

		// Token: 0x04029774 RID: 169844
		public const int ItemTip = 4;
	}
}
