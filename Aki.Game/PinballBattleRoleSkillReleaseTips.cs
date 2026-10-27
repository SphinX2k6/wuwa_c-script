using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D07 RID: 7431
[NullableContext(1)]
[Nullable(0)]
public class PinballBattleRoleSkillReleaseTips : PinballBattleTipsBase
{
	// Token: 0x0600E0B5 RID: 57525 RVA: 0x0034B25A File Offset: 0x0034945A
	public PinballBattleRoleSkillReleaseTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E0B6 RID: 57526 RVA: 0x0034B270 File Offset: 0x00349470
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600E0B7 RID: 57527 RVA: 0x0034B2DC File Offset: 0x003494DC
	protected override UniTask OnBeforeStartAsync()
	{
		PinballBattleRoleSkillReleaseTips.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PinballBattleRoleSkillReleaseTips.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E0B8 RID: 57528 RVA: 0x0034B31F File Offset: 0x0034951F
	public void AddNewRole(int roleId)
	{
		if (!this.TryAddRoleId(roleId))
		{
			return;
		}
		if (this.RootItem == null)
		{
			return;
		}
		GenericLayout<PinballBattleRoleSkillTipsItem, int> roleSkillItemLayout = this.RoleSkillItemLayout;
		if (roleSkillItemLayout != null)
		{
			roleSkillItemLayout.RefreshByData(this.RoleIdList, null, false);
		}
		base.ResetCloseTimer();
	}

	// Token: 0x0600E0B9 RID: 57529 RVA: 0x0034B353 File Offset: 0x00349553
	private bool TryAddRoleId(int roleId)
	{
		if (this.RoleIdList.Contains(roleId))
		{
			return false;
		}
		this.RoleIdList.Add(roleId);
		return true;
	}

	// Token: 0x0600E0BA RID: 57530 RVA: 0x0034B374 File Offset: 0x00349574
	protected override UniTask OnBeforeHideAsync()
	{
		PinballBattleRoleSkillReleaseTips.<OnBeforeHideAsync>d__7 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<PinballBattleRoleSkillReleaseTips.<OnBeforeHideAsync>d__7>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E0BB RID: 57531 RVA: 0x0034B3B8 File Offset: 0x003495B8
	protected override void OnBeforeHide()
	{
		PinballBattleSubController pinballBattleSubController = KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController;
		PinballBattleSubModel model = pinballBattleSubController.GetModel();
		foreach (int roleId in this.RoleIdList)
		{
			int? roleSlotIndex = model.GetRoleSlotIndex(roleId);
			if (roleSlotIndex != null)
			{
				pinballBattleSubController.OnInputUseSkill(roleSlotIndex.Value, 0);
			}
		}
	}

	// Token: 0x040067C0 RID: 26560
	private readonly List<int> RoleIdList = new List<int>();

	// Token: 0x040067C1 RID: 26561
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<PinballBattleRoleSkillTipsItem, int> RoleSkillItemLayout;
}
