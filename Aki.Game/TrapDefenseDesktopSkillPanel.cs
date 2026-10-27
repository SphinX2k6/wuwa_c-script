using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TrapDefense;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D36 RID: 7478
public class TrapDefenseDesktopSkillPanel : TrapDefenseSkillPanelBase
{
	// Token: 0x0600E28F RID: 57999 RVA: 0x00353BAD File Offset: 0x00351DAD
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600E290 RID: 58000 RVA: 0x00353BE8 File Offset: 0x00351DE8
	public override UniTask InitializeAsync()
	{
		TrapDefenseDesktopSkillPanel.<InitializeAsync>d__3 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<TrapDefenseDesktopSkillPanel.<InitializeAsync>d__3>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E291 RID: 58001 RVA: 0x00353C2B File Offset: 0x00351E2B
	protected override void OnChildStart()
	{
		this.RefreshExploreSkillItem();
	}

	// Token: 0x0600E292 RID: 58002 RVA: 0x00353C34 File Offset: 0x00351E34
	private UniTask NewAllBattleSkillItems()
	{
		TrapDefenseDesktopSkillPanel.<NewAllBattleSkillItems>d__5 <NewAllBattleSkillItems>d__;
		<NewAllBattleSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewAllBattleSkillItems>d__.<>4__this = this;
		<NewAllBattleSkillItems>d__.<>1__state = -1;
		<NewAllBattleSkillItems>d__.<>t__builder.Start<TrapDefenseDesktopSkillPanel.<NewAllBattleSkillItems>d__5>(ref <NewAllBattleSkillItems>d__);
		return <NewAllBattleSkillItems>d__.<>t__builder.Task;
	}

	// Token: 0x0600E293 RID: 58003 RVA: 0x00353C78 File Offset: 0x00351E78
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

	// Token: 0x0600E294 RID: 58004 RVA: 0x00353CC8 File Offset: 0x00351EC8
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

	// Token: 0x0600E295 RID: 58005 RVA: 0x00353D02 File Offset: 0x00351F02
	[NullableContext(1)]
	protected override string[] GetActionNameList()
	{
		return TrapDefenseDesktopSkillPanel.actionNameList;
	}

	// Token: 0x040068C5 RID: 26821
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly string[] actionNameList = new string[]
	{
		"塔防射击",
		"塔防道具"
	};

	// Token: 0x02008340 RID: 33600
	private static class EComponentDefine
	{
		// Token: 0x0402ACC4 RID: 175300
		public const int Attack = 0;

		// Token: 0x0402ACC5 RID: 175301
		public const int Explore = 1;
	}
}
