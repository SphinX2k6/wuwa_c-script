using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TrapDefense;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011F8 RID: 4600
public class TrapDefenseDesktopSkillPanel : TrapDefenseSkillPanelBase
{
	// Token: 0x0600B6AC RID: 46764 RVA: 0x0035F5DD File Offset: 0x0035D7DD
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600B6AD RID: 46765 RVA: 0x0035F618 File Offset: 0x0035D818
	public override UniTask InitializeAsync()
	{
		TrapDefenseDesktopSkillPanel.<InitializeAsync>d__3 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<TrapDefenseDesktopSkillPanel.<InitializeAsync>d__3>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B6AE RID: 46766 RVA: 0x0035F65B File Offset: 0x0035D85B
	protected override void OnChildStart()
	{
		this.RefreshExploreSkillItem();
	}

	// Token: 0x0600B6AF RID: 46767 RVA: 0x0035F664 File Offset: 0x0035D864
	private UniTask NewAllBattleSkillItems()
	{
		TrapDefenseDesktopSkillPanel.<NewAllBattleSkillItems>d__5 <NewAllBattleSkillItems>d__;
		<NewAllBattleSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewAllBattleSkillItems>d__.<>4__this = this;
		<NewAllBattleSkillItems>d__.<>1__state = -1;
		<NewAllBattleSkillItems>d__.<>t__builder.Start<TrapDefenseDesktopSkillPanel.<NewAllBattleSkillItems>d__5>(ref <NewAllBattleSkillItems>d__);
		return <NewAllBattleSkillItems>d__.<>t__builder.Task;
	}

	// Token: 0x0600B6B0 RID: 46768 RVA: 0x0035F6A8 File Offset: 0x0035D8A8
	private void RefreshExploreSkillItem()
	{
		TrapDefenseBattleSkillData trapDefenseBattleSkillData;
		if (this.DataMap.TryGetValue(1, out trapDefenseBattleSkillData))
		{
			bool flag = RouletteModel.Instance.IsExploreRouletteOpen(false);
			bool curInstToLevelDataHasShop = TrapDefenseModel.Instance.GetCurInstToLevelDataHasShop();
			trapDefenseBattleSkillData.SetVisible(flag && curInstToLevelDataHasShop);
		}
		this.BattleSkillItemList[1].RefreshVisible();
	}

	// Token: 0x0600B6B1 RID: 46769 RVA: 0x0035F6F8 File Offset: 0x0035D8F8
	public void RefreshButtonByIsInBuild(bool isInBuild)
	{
		bool visible = !isInBuild;
		TrapDefenseBattleSkillData trapDefenseBattleSkillData;
		if (this.DataMap.TryGetValue(0, out trapDefenseBattleSkillData))
		{
			trapDefenseBattleSkillData.SetVisible(visible);
		}
		this.BattleSkillItemList[0].RefreshVisible();
	}

	// Token: 0x0600B6B2 RID: 46770 RVA: 0x0035F732 File Offset: 0x0035D932
	[NullableContext(1)]
	protected override string[] GetActionNameList()
	{
		return TrapDefenseDesktopSkillPanel.actionNameList;
	}

	// Token: 0x040069A4 RID: 27044
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly string[] actionNameList = new string[]
	{
		"塔防射击",
		"塔防道具"
	};

	// Token: 0x020074C9 RID: 29897
	private static class EComponentDefine
	{
		// Token: 0x04025FEC RID: 155628
		public const int Attack = 0;

		// Token: 0x04025FED RID: 155629
		public const int Explore = 1;
	}
}
