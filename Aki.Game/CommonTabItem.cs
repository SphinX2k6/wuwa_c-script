using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x020019B8 RID: 6584
[NullableContext(1)]
[Nullable(0)]
public class CommonTabItem : CommonTabItemBase
{
	// Token: 0x0600C042 RID: 49218 RVA: 0x002B59F0 File Offset: 0x002B3BF0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggleSpriteTransition));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C043 RID: 49219 RVA: 0x002B5AD8 File Offset: 0x002B3CD8
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		Action callback = delegate()
		{
			Action onUndeterminedClick = this.OnUndeterminedClick;
			if (onUndeterminedClick == null)
			{
				return;
			}
			onUndeterminedClick();
		};
		base.GetExtendToggle(1).OnUndeterminedClicked.Add(callback);
		base.GetItem(2).SetUIActive(false);
	}

	// Token: 0x0600C044 RID: 49220 RVA: 0x002B5B28 File Offset: 0x002B3D28
	protected override void OnBeforeDestroy()
	{
		if (this.NeedUnBindAll)
		{
			this.UnBindRedDot();
			return;
		}
		this.UnBindGivenUid(this.RedDotUid);
	}

	// Token: 0x0600C045 RID: 49221 RVA: 0x002B5B48 File Offset: 0x002B3D48
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		CommonTabData data2 = data.Data;
		base.UpdateTabIcon(((data2 != null) ? data2.GetIcon() : null) ?? "");
		this.UnBindRedDot();
		this.NeedUnBindAll = data.NeedUnBindAllRedDot;
		if (data.RedDotName != null)
		{
			this.RedDotUid = data.RedDotUid;
			this.BindRedDot(data.RedDotName.Value, data.RedDotUid);
			return;
		}
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600C046 RID: 49222 RVA: 0x002B5BCB File Offset: 0x002B3DCB
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x0600C047 RID: 49223 RVA: 0x002B5BE4 File Offset: 0x002B3DE4
	public override void OnSelected(bool fireEvent)
	{
		this.SelectedCallBack(base.GridIndex);
	}

	// Token: 0x0600C048 RID: 49224 RVA: 0x002B5BF8 File Offset: 0x002B3DF8
	protected override void OnUpdateTabIcon(string iconPath)
	{
		if (iconPath != "")
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, new Action<bool>(this.RefreshTransition));
		}
	}

	// Token: 0x0600C049 RID: 49225 RVA: 0x002B5C38 File Offset: 0x002B3E38
	protected void RefreshTransition(bool result)
	{
		UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(3);
		if (uiExtendToggleSpriteTransition != null)
		{
			uiExtendToggleSpriteTransition.SetAllStateSprite(base.GetSprite(0).GetSprite());
		}
	}

	// Token: 0x0600C04A RID: 49226 RVA: 0x002B5C62 File Offset: 0x002B3E62
	public void SetToggleStateForce(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x0600C04B RID: 49227 RVA: 0x002B5C74 File Offset: 0x002B3E74
	public void SetCanClickWhenDisable(bool state)
	{
		base.GetExtendToggle(1).SetCanClickWhenDisable(state);
	}

	// Token: 0x0600C04C RID: 49228 RVA: 0x002B5C83 File Offset: 0x002B3E83
	public void SetOnUndeterminedClick(Action call)
	{
		this.OnUndeterminedClick = call;
	}

	// Token: 0x0600C04D RID: 49229 RVA: 0x002B5C8C File Offset: 0x002B3E8C
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x0600C04E RID: 49230 RVA: 0x002B5C9F File Offset: 0x002B3E9F
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x0600C04F RID: 49231 RVA: 0x002B5CA8 File Offset: 0x002B3EA8
	public virtual void BindRedDot(ERedDotName redDotName, int? uId = 0)
	{
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, base.GetItem(2), null, uId.GetValueOrDefault());
		}
	}

	// Token: 0x0600C050 RID: 49232 RVA: 0x002B5CDD File Offset: 0x002B3EDD
	public virtual void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x0600C051 RID: 49233 RVA: 0x002B5D0D File Offset: 0x002B3F0D
	protected void UnBindGivenUid(int? uid = 0)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), uid.GetValueOrDefault());
			this.RedDotName = null;
		}
	}

	// Token: 0x0600C052 RID: 49234 RVA: 0x002B5D4B File Offset: 0x002B3F4B
	public void SetRedDotState(bool bVisible)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x0600C053 RID: 49235 RVA: 0x002B5D5F File Offset: 0x002B3F5F
	public UUISprite GetIconSprite()
	{
		return base.GetSprite(0);
	}

	// Token: 0x0600C054 RID: 49236 RVA: 0x002B5D68 File Offset: 0x002B3F68
	protected override void OnClear()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0400565F RID: 22111
	[Nullable(2)]
	private Action OnUndeterminedClick;

	// Token: 0x04005660 RID: 22112
	protected ERedDotName? RedDotName;

	// Token: 0x04005661 RID: 22113
	protected int? RedDotUid;

	// Token: 0x04005662 RID: 22114
	protected bool NeedUnBindAll = true;

	// Token: 0x02007EE7 RID: 32487
	[NullableContext(0)]
	private class ECommonTabItem
	{
		// Token: 0x0402976C RID: 169836
		public const int Icon = 0;

		// Token: 0x0402976D RID: 169837
		public const int Toggle = 1;

		// Token: 0x0402976E RID: 169838
		public const int RedDot = 2;

		// Token: 0x0402976F RID: 169839
		public const int Transition = 3;
	}
}
