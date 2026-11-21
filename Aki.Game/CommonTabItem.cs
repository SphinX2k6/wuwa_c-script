using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000E76 RID: 3702
[NullableContext(1)]
[Nullable(0)]
public class CommonTabItem : CommonTabItemBase
{
	// Token: 0x0600944C RID: 37964 RVA: 0x002C0980 File Offset: 0x002BEB80
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

	// Token: 0x0600944D RID: 37965 RVA: 0x002C0A68 File Offset: 0x002BEC68
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

	// Token: 0x0600944E RID: 37966 RVA: 0x002C0AB8 File Offset: 0x002BECB8
	protected override void OnBeforeDestroy()
	{
		if (this.NeedUnBindAll)
		{
			this.UnBindRedDot();
			return;
		}
		this.UnBindGivenUid(this.RedDotUid);
	}

	// Token: 0x0600944F RID: 37967 RVA: 0x002C0AD8 File Offset: 0x002BECD8
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

	// Token: 0x06009450 RID: 37968 RVA: 0x002C0B5B File Offset: 0x002BED5B
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x06009451 RID: 37969 RVA: 0x002C0B74 File Offset: 0x002BED74
	public override void OnSelected(bool fireEvent)
	{
		this.SelectedCallBack(base.GridIndex);
	}

	// Token: 0x06009452 RID: 37970 RVA: 0x002C0B88 File Offset: 0x002BED88
	protected override void OnUpdateTabIcon(string iconPath)
	{
		if (iconPath != "")
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, new Action<bool>(this.RefreshTransition));
		}
	}

	// Token: 0x06009453 RID: 37971 RVA: 0x002C0BC8 File Offset: 0x002BEDC8
	protected void RefreshTransition(bool result)
	{
		UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(3);
		if (uiExtendToggleSpriteTransition != null)
		{
			uiExtendToggleSpriteTransition.SetAllStateSprite(base.GetSprite(0).GetSprite());
		}
	}

	// Token: 0x06009454 RID: 37972 RVA: 0x002C0BF2 File Offset: 0x002BEDF2
	public void SetToggleStateForce(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x06009455 RID: 37973 RVA: 0x002C0C04 File Offset: 0x002BEE04
	public void SetCanClickWhenDisable(bool state)
	{
		base.GetExtendToggle(1).SetCanClickWhenDisable(state);
	}

	// Token: 0x06009456 RID: 37974 RVA: 0x002C0C13 File Offset: 0x002BEE13
	public void SetOnUndeterminedClick(Action call)
	{
		this.OnUndeterminedClick = call;
	}

	// Token: 0x06009457 RID: 37975 RVA: 0x002C0C1C File Offset: 0x002BEE1C
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06009458 RID: 37976 RVA: 0x002C0C2F File Offset: 0x002BEE2F
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x06009459 RID: 37977 RVA: 0x002C0C38 File Offset: 0x002BEE38
	public virtual void BindRedDot(ERedDotName redDotName, int? uId = 0)
	{
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, base.GetItem(2), null, uId.GetValueOrDefault());
		}
	}

	// Token: 0x0600945A RID: 37978 RVA: 0x002C0C6D File Offset: 0x002BEE6D
	public virtual void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x0600945B RID: 37979 RVA: 0x002C0C9D File Offset: 0x002BEE9D
	protected void UnBindGivenUid(int? uid = 0)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), uid.GetValueOrDefault());
			this.RedDotName = null;
		}
	}

	// Token: 0x0600945C RID: 37980 RVA: 0x002C0CDB File Offset: 0x002BEEDB
	public void SetRedDotState(bool bVisible)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x0600945D RID: 37981 RVA: 0x002C0CEF File Offset: 0x002BEEEF
	public UUISprite GetIconSprite()
	{
		return base.GetSprite(0);
	}

	// Token: 0x0600945E RID: 37982 RVA: 0x002C0CF8 File Offset: 0x002BEEF8
	protected override void OnClear()
	{
		this.UnBindRedDot();
	}

	// Token: 0x04005711 RID: 22289
	[Nullable(2)]
	private Action OnUndeterminedClick;

	// Token: 0x04005712 RID: 22290
	protected ERedDotName? RedDotName;

	// Token: 0x04005713 RID: 22291
	protected int? RedDotUid;

	// Token: 0x04005714 RID: 22292
	protected bool NeedUnBindAll = true;

	// Token: 0x02007076 RID: 28790
	[NullableContext(0)]
	private class ECommonTabItem
	{
		// Token: 0x04024AA9 RID: 150185
		public const int Icon = 0;

		// Token: 0x04024AAA RID: 150186
		public const int Toggle = 1;

		// Token: 0x04024AAB RID: 150187
		public const int RedDot = 2;

		// Token: 0x04024AAC RID: 150188
		public const int Transition = 3;
	}
}
