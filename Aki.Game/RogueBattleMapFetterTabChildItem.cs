using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C59 RID: 7257
public class RogueBattleMapFetterTabChildItem : GridProxyAbstract<int>
{
	// Token: 0x06011FFD RID: 73725 RVA: 0x0054B778 File Offset: 0x00549978
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06011FFE RID: 73726 RVA: 0x0054B7F5 File Offset: 0x005499F5
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x06011FFF RID: 73727 RVA: 0x0054B814 File Offset: 0x00549A14
	public void SetSelected(bool isSelected)
	{
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x06012000 RID: 73728 RVA: 0x0054B83A File Offset: 0x00549A3A
	private bool CanExecuteChange()
	{
		return this.CanExecuteChangeFunction == null || this.CanExecuteChangeFunction(this.BondId, base.GetExtendToggle(0).GetToggleState());
	}

	// Token: 0x06012001 RID: 73729 RVA: 0x0054B864 File Offset: 0x00549A64
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.BondId = data;
		this.SetSelected(this.BondId == RogueBattleModel.Instance.CurrentMapSummaryBond);
		RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(this.BondId);
		RoleBondInfo roleBondDataById = RogueBattleModel.Instance.GetRoleBondDataById(this.BondId);
		FColor color = FColor.FromHex(RogueBattleConfig.Instance.GetBondLvConfigByLv(roleBondDataById.Level).Value.LvColor);
		UUIText text = base.GetText(1);
		UUIText text2 = base.GetText(2);
		text.SetColor(color);
		LguiUtil.Instance.SetLocalTextNew(text, rogueResBond.Value.Name, Array.Empty<object>());
		if (roleBondDataById != null && roleBondDataById.Level > 0)
		{
			text2.SetColor(color);
			LguiUtil.Instance.SetLocalTextNew(text2, "RogueResSynergyLV", new <>z__ReadOnlySingleElementList<object>(roleBondDataById.Level));
			base.GetText(2).SetUIActive(true);
			return;
		}
		base.GetText(2).SetUIActive(false);
	}

	// Token: 0x06012002 RID: 73730 RVA: 0x0054B964 File Offset: 0x00549B64
	private void OnClickToggle(EToggleState state)
	{
		RogueBattleModel.Instance.CurrentMapSummaryBond = this.BondId;
		EventSystem.Instance.Emit<int>(EEventName.RogueResMapSummaryBondUpdate, this.BondId);
	}

	// Token: 0x04009CEF RID: 40175
	private int BondId;

	// Token: 0x04009CF0 RID: 40176
	[Nullable(2)]
	public Func<int, EToggleState, bool> CanExecuteChangeFunction;
}
