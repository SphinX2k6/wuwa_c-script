using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E5B RID: 7771
public class RoleResonanceTabViewNew : UiTabViewBase
{
	// Token: 0x0601339B RID: 78747 RVA: 0x0059E788 File Offset: 0x0059C988
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

	// Token: 0x0601339C RID: 78748 RVA: 0x0059E7F1 File Offset: 0x0059C9F1
	protected void UnBindRedDot()
	{
		if (this.RoleInstance.IsTrialRole())
		{
			return;
		}
		RedDotController.Instance.UnBindRedDot(ERedDotName.RoleResonanceTabHole);
	}

	// Token: 0x0601339D RID: 78749 RVA: 0x0059E80D File Offset: 0x0059CA0D
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.ChangeRoleEvent));
	}

	// Token: 0x0601339E RID: 78750 RVA: 0x0059E82C File Offset: 0x0059CA2C
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

	// Token: 0x0601339F RID: 78751 RVA: 0x0059E895 File Offset: 0x0059CA95
	protected void PlayMontageStart()
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Resonance, false, false, false);
	}

	// Token: 0x060133A0 RID: 78752 RVA: 0x0059E8A5 File Offset: 0x0059CAA5
	protected override void OnBeforeShow()
	{
		this.UpdateView();
	}

	// Token: 0x060133A1 RID: 78753 RVA: 0x0059E8B0 File Offset: 0x0059CAB0
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

	// Token: 0x060133A2 RID: 78754 RVA: 0x0059E975 File Offset: 0x0059CB75
	private void ChangeRoleEvent(int roleId)
	{
		this.RoleInstance = RoleModel.Instance.GetRoleDataById(roleId, true);
		this.PlayMontageStart();
		this.UpdateView();
	}

	// Token: 0x060133A3 RID: 78755 RVA: 0x0059E995 File Offset: 0x0059CB95
	protected override void OnBeforeHide()
	{
		this.UnBindRedDot();
	}

	// Token: 0x060133A4 RID: 78756 RVA: 0x0059E99D File Offset: 0x0059CB9D
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.ChangeRoleEvent));
	}

	// Token: 0x0400A4A7 RID: 42151
	[Nullable(2)]
	private RoleViewAgent RoleViewAgent;

	// Token: 0x0400A4A8 RID: 42152
	[Nullable(2)]
	private RoleDataBase RoleInstance;

	// Token: 0x02008136 RID: 33078
	private enum ERoleResonanceTabViewDefine
	{
		// Token: 0x04029C8D RID: 171149
		UnlockText,
		// Token: 0x04029C8E RID: 171150
		UnLockRootItem
	}
}
