using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200279A RID: 10138
public class RoleBackgroundMusicSwitchItem : UiPanelBase
{
	// Token: 0x06014D0B RID: 85259 RVA: 0x00548084 File Offset: 0x00546284
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

	// Token: 0x06014D0C RID: 85260 RVA: 0x00548110 File Offset: 0x00546310
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.SetSelfInteractive(false);
		extendToggle.SetCanClickWhenDisable(true);
		extendToggle.OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnPointUpCallBackInternal));
		EventSystem.Instance.Add<int, bool>(EEventName.OnRoleBackgroundMusicEnabledChanged, new Action<int, bool>(this.OnRoleBackgroundMusicEnabledChanged));
	}

	// Token: 0x06014D0D RID: 85261 RVA: 0x00548164 File Offset: 0x00546364
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove<int, bool>(EEventName.OnRoleBackgroundMusicEnabledChanged, new Action<int, bool>(this.OnRoleBackgroundMusicEnabledChanged));
	}

	// Token: 0x06014D0E RID: 85262 RVA: 0x00548182 File Offset: 0x00546382
	[NullableContext(1)]
	public void RefreshByRoleData(RoleDataBase roleData)
	{
		this.RoleData = roleData;
		this.Refresh();
	}

	// Token: 0x06014D0F RID: 85263 RVA: 0x00548194 File Offset: 0x00546394
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

	// Token: 0x06014D10 RID: 85264 RVA: 0x005481F4 File Offset: 0x005463F4
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

	// Token: 0x06014D11 RID: 85265 RVA: 0x0054824D File Offset: 0x0054644D
	private void OnRoleBackgroundMusicEnabledChanged(int roleDataId, bool _)
	{
		if (this.RoleData == null || this.RoleData.GetDataId() != roleDataId)
		{
			return;
		}
		this.Refresh();
	}

	// Token: 0x04009CB2 RID: 40114
	[Nullable(2)]
	public RoleDataBase RoleData;

	// Token: 0x02008E0E RID: 36366
	private enum EComponentDefine
	{
		// Token: 0x0402E176 RID: 188790
		SwitchToggle,
		// Token: 0x0402E177 RID: 188791
		DescText,
		// Token: 0x0402E178 RID: 188792
		RoleIconTexture
	}
}
