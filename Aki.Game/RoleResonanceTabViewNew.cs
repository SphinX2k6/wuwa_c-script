using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028E0 RID: 10464
public class RoleResonanceTabViewNew : UiTabViewBase
{
	// Token: 0x06015997 RID: 88471 RVA: 0x005738C0 File Offset: 0x00571AC0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06015998 RID: 88472 RVA: 0x00573929 File Offset: 0x00571B29
	protected void UnBindRedDot()
	{
		if (this.RoleInstance.IsTrialRole())
		{
			return;
		}
		RedDotController.Instance.UnBindRedDot(ERedDotName.RoleResonanceTabHole);
	}

	// Token: 0x06015999 RID: 88473 RVA: 0x00573945 File Offset: 0x00571B45
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.ChangeRoleEvent));
	}

	// Token: 0x0601599A RID: 88474 RVA: 0x00573964 File Offset: 0x00571B64
	protected override void OnStart()
	{
		this.RoleViewAgent = (this.OpenParam as RoleViewAgent);
		if (this.RoleViewAgent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.BB;
			string message = "RoleViewAgent为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("界面名称", "RoleResonanceTabViewNew");
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.RoleInstance = this.RoleViewAgent.GetCurSelectRoleData();
		this.PlayMontageStart();
	}

	// Token: 0x0601599B RID: 88475 RVA: 0x005739CD File Offset: 0x00571BCD
	protected void PlayMontageStart()
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Resonance, false, false, false);
	}

	// Token: 0x0601599C RID: 88476 RVA: 0x005739DD File Offset: 0x00571BDD
	protected override void OnBeforeShow()
	{
		this.UpdateView();
	}

	// Token: 0x0601599D RID: 88477 RVA: 0x005739E8 File Offset: 0x00571BE8
	private void UpdateView()
	{
		RoleInfo roleConfig = this.RoleInstance.GetRoleConfig();
		UUIText text = base.GetText(0);
		List<ResonantChain> roleResonanceList = RoleResonanceConfig.Instance.GetRoleResonanceList(roleConfig.ResonantChainGroupId);
		UUIText uuitext = text;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.RoleInstance.GetResonanceData().GetResonantChainGroupIndex());
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(roleResonanceList.Count);
		uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		base.GetItem(1).SetUIActive(!this.RoleInstance.IsTrialRole());
		if (UiManager.Instance.IsViewShow(EUiViewName.RoleHandBookRootView))
		{
			(text.GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIActive(false);
		}
	}

	// Token: 0x0601599E RID: 88478 RVA: 0x00573AAD File Offset: 0x00571CAD
	private void ChangeRoleEvent(int roleId)
	{
		this.RoleInstance = RoleModel.Instance.GetRoleDataById(roleId, true);
		this.PlayMontageStart();
		this.UpdateView();
	}

	// Token: 0x0601599F RID: 88479 RVA: 0x00573ACD File Offset: 0x00571CCD
	protected override void OnBeforeHide()
	{
		this.UnBindRedDot();
	}

	// Token: 0x060159A0 RID: 88480 RVA: 0x00573AD5 File Offset: 0x00571CD5
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.ChangeRoleEvent));
	}

	// Token: 0x0400A0BD RID: 41149
	[Nullable(2)]
	private RoleViewAgent RoleViewAgent;

	// Token: 0x0400A0BE RID: 41150
	[Nullable(2)]
	private RoleDataBase RoleInstance;

	// Token: 0x02008EEE RID: 36590
	private enum ERoleResonanceTabViewDefine
	{
		// Token: 0x0402E592 RID: 189842
		UnlockText,
		// Token: 0x0402E593 RID: 189843
		UnLockRootItem
	}
}
