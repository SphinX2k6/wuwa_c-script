using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200276E RID: 10094
public class RogueBattleMapFetterTabChildItem : GridProxyAbstract<int>
{
	// Token: 0x06014B1A RID: 84762 RVA: 0x0053C968 File Offset: 0x0053AB68
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

	// Token: 0x06014B1B RID: 84763 RVA: 0x0053C9E5 File Offset: 0x0053ABE5
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x06014B1C RID: 84764 RVA: 0x0053CA04 File Offset: 0x0053AC04
	public void SetSelected(bool isSelected)
	{
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x06014B1D RID: 84765 RVA: 0x0053CA2A File Offset: 0x0053AC2A
	private bool CanExecuteChange()
	{
		return this.CanExecuteChangeFunction == null || this.CanExecuteChangeFunction(this.BondId, base.GetExtendToggle(0).GetToggleState());
	}

	// Token: 0x06014B1E RID: 84766 RVA: 0x0053CA54 File Offset: 0x0053AC54
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

	// Token: 0x06014B1F RID: 84767 RVA: 0x0053CB54 File Offset: 0x0053AD54
	private void OnClickToggle(EToggleState state)
	{
		RogueBattleModel.Instance.CurrentMapSummaryBond = this.BondId;
		EventSystem.Instance.Emit<int>(EEventName.RogueResMapSummaryBondUpdate, this.BondId);
	}

	// Token: 0x04009B97 RID: 39831
	private int BondId;

	// Token: 0x04009B98 RID: 39832
	[Nullable(2)]
	public Func<int, EToggleState, bool> CanExecuteChangeFunction;
}
