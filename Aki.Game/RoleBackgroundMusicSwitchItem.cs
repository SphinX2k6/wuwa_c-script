using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D14 RID: 7444
public class RoleBackgroundMusicSwitchItem : UiPanelBase
{
	// Token: 0x060126DC RID: 75484 RVA: 0x00572124 File Offset: 0x00570324
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060126DD RID: 75485 RVA: 0x005721B0 File Offset: 0x005703B0
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.SetSelfInteractive(false);
		extendToggle.SetCanClickWhenDisable(true);
		extendToggle.OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnPointUpCallBackInternal));
		EventSystem.Instance.Add<int, bool>(EEventName.OnRoleBackgroundMusicEnabledChanged, new Action<int, bool>(this.OnRoleBackgroundMusicEnabledChanged));
	}

	// Token: 0x060126DE RID: 75486 RVA: 0x00572204 File Offset: 0x00570404
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove<int, bool>(EEventName.OnRoleBackgroundMusicEnabledChanged, new Action<int, bool>(this.OnRoleBackgroundMusicEnabledChanged));
	}

	// Token: 0x060126DF RID: 75487 RVA: 0x00572222 File Offset: 0x00570422
	[NullableContext(1)]
	public void RefreshByRoleData(RoleDataBase roleData)
	{
		this.RoleData = roleData;
		this.Refresh();
	}

	// Token: 0x060126E0 RID: 75488 RVA: 0x00572234 File Offset: 0x00570434
	public void Refresh()
	{
		if (this.RoleData == null)
		{
			return;
		}
		base.SetRoleIcon("", base.GetTexture(2), this.RoleData.GetRoleId(), null, null);
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		EToggleState state = this.RoleData.GetBackgroundMusicEnabled() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x060126E1 RID: 75489 RVA: 0x00572294 File Offset: 0x00570494
	private void OnPointUpCallBackInternal(EToggleState state)
	{
		if (this.RoleData == null || this.RoleData.IsTrialRole())
		{
			return;
		}
		if (state == EToggleState.ETT_Checked)
		{
			RoleController.Instance.RoleOperateSelfBgmRequest(this.RoleData.GetDataId(), false, null);
			return;
		}
		if (state == EToggleState.ETT_UnChecked)
		{
			RoleController.Instance.RoleOperateSelfBgmRequest(this.RoleData.GetDataId(), true, null);
		}
	}

	// Token: 0x060126E2 RID: 75490 RVA: 0x005722ED File Offset: 0x005704ED
	private void OnRoleBackgroundMusicEnabledChanged(int roleDataId, bool _)
	{
		if (this.RoleData == null || this.RoleData.GetDataId() != roleDataId)
		{
			return;
		}
		this.Refresh();
	}

	// Token: 0x0400A080 RID: 41088
	[Nullable(2)]
	public RoleDataBase RoleData;

	// Token: 0x02008052 RID: 32850
	private enum EComponentDefine
	{
		// Token: 0x04029850 RID: 170064
		SwitchToggle,
		// Token: 0x04029851 RID: 170065
		DescText,
		// Token: 0x04029852 RID: 170066
		RoleIconTexture
	}
}
