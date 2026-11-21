using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.TrapDefense;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011FD RID: 4605
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseMobileSkillPanel : TrapDefenseSkillPanelBase
{
	// Token: 0x0600B6ED RID: 46829 RVA: 0x00360990 File Offset: 0x0035EB90
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x0600B6EE RID: 46830 RVA: 0x00360A44 File Offset: 0x0035EC44
	public override UniTask InitializeAsync()
	{
		TrapDefenseMobileSkillPanel.<InitializeAsync>d__7 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<TrapDefenseMobileSkillPanel.<InitializeAsync>d__7>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B6EF RID: 46831 RVA: 0x00360A88 File Offset: 0x0035EC88
	protected override void OnChildStart()
	{
		bool flag = RouletteModel.Instance.IsExploreRouletteOpen(false);
		bool curInstToLevelDataHasShop = TrapDefenseModel.Instance.GetCurInstToLevelDataHasShop();
		this.RefreshSkillItemActive(2, flag && curInstToLevelDataHasShop);
		((TrapDefenseBattleSkillItem)this.BattleSkillItemList[5]).SetIsBanLongPress(true);
	}

	// Token: 0x0600B6F0 RID: 46832 RVA: 0x00360AD0 File Offset: 0x0035ECD0
	private UniTask NewAllBattleSkillItems()
	{
		TrapDefenseMobileSkillPanel.<NewAllBattleSkillItems>d__9 <NewAllBattleSkillItems>d__;
		<NewAllBattleSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewAllBattleSkillItems>d__.<>4__this = this;
		<NewAllBattleSkillItems>d__.<>1__state = -1;
		<NewAllBattleSkillItems>d__.<>t__builder.Start<TrapDefenseMobileSkillPanel.<NewAllBattleSkillItems>d__9>(ref <NewAllBattleSkillItems>d__);
		return <NewAllBattleSkillItems>d__.<>t__builder.Task;
	}

	// Token: 0x0600B6F1 RID: 46833 RVA: 0x00360B14 File Offset: 0x0035ED14
	private void RefreshSkillItemActive(int index, bool active)
	{
		TrapDefenseBattleSkillData trapDefenseBattleSkillData;
		if (this.DataMap.TryGetValue(index, out trapDefenseBattleSkillData))
		{
			trapDefenseBattleSkillData.SetVisible(active);
		}
		this.BattleSkillItemList[index].RefreshVisible();
	}

	// Token: 0x0600B6F2 RID: 46834 RVA: 0x00360B4C File Offset: 0x0035ED4C
	private void RefreshSkillItemEnable(int index, bool enable)
	{
		TrapDefenseBattleSkillData trapDefenseBattleSkillData;
		if (this.DataMap.TryGetValue(index, out trapDefenseBattleSkillData))
		{
			trapDefenseBattleSkillData.SetEnable(enable);
		}
		this.BattleSkillItemList[index].RefreshEnable(false);
	}

	// Token: 0x0600B6F3 RID: 46835 RVA: 0x00360B82 File Offset: 0x0035ED82
	public void SetRecyclePrice(int recyclePrice)
	{
		this.RecyclePriceItem.UpdatePrice(recyclePrice);
	}

	// Token: 0x0600B6F4 RID: 46836 RVA: 0x00360B90 File Offset: 0x0035ED90
	public void RefreshButtonByTipsType(ETrapDefenseBuildTipsType type)
	{
		this.Type = type;
		bool active = (this.Type & ETrapDefenseBuildTipsType.Recycle) > ETrapDefenseBuildTipsType.None;
		this.RefreshSkillItemActive(6, active);
		this.RefreshAttackAndRotate();
	}

	// Token: 0x0600B6F5 RID: 46837 RVA: 0x00360BC0 File Offset: 0x0035EDC0
	private void RefreshAttackAndRotate()
	{
		bool flag = !this.IsInBuild;
		bool flag2 = (this.Type & ETrapDefenseBuildTipsType.Build) > ETrapDefenseBuildTipsType.None && this.IsInBuild;
		bool active = (this.Type & ETrapDefenseBuildTipsType.Rotate) > ETrapDefenseBuildTipsType.None && this.IsInBuild;
		this.RefreshSkillItemActive(1, active);
		this.RefreshSkillItemActive(5, flag);
		this.RefreshSkillItemActive(0, true);
		this.RefreshSkillItemEnable(0, flag || flag2);
	}

	// Token: 0x0600B6F6 RID: 46838 RVA: 0x00360C23 File Offset: 0x0035EE23
	public void SetIsInBuild(bool isInBuild)
	{
		this.IsInBuild = isInBuild;
		this.RefreshBuildData();
		this.RefreshBuildIcon();
		this.RefreshSkillName();
		this.RefreshMachineCdState();
		this.RefreshAttackAndRotate();
	}

	// Token: 0x0600B6F7 RID: 46839 RVA: 0x00360C4C File Offset: 0x0035EE4C
	private void RefreshBuildData()
	{
		TrapDefenseBattleSkillData trapDefenseBattleSkillData;
		if (this.DataMap.TryGetValue(0, out trapDefenseBattleSkillData))
		{
			trapDefenseBattleSkillData.SetIsBuilding(this.IsInBuild);
		}
		TrapDefenseBattleSkillData trapDefenseBattleSkillData2;
		if (this.DataMap.TryGetValue(5, out trapDefenseBattleSkillData2))
		{
			trapDefenseBattleSkillData2.SetIsBuilding(this.IsInBuild);
		}
	}

	// Token: 0x0600B6F8 RID: 46840 RVA: 0x00360C94 File Offset: 0x0035EE94
	private void RefreshBuildIcon()
	{
		BattleSkillItem battleSkillItem = this.BattleSkillItemList[0];
		BattleSkillItem battleSkillItem2 = this.BattleSkillItemList[5];
		if (this.IsInBuild)
		{
			if (battleSkillItem != null)
			{
				battleSkillItem.SetSkillIcon("/Game/Aki/UI/UIResources/Common/Atlas/SkillIcon/SkillIconNor/SP_IconT62.SP_IconT62");
				return;
			}
		}
		else
		{
			if (battleSkillItem != null)
			{
				battleSkillItem.RefreshSkillIcon();
			}
			if (battleSkillItem2 != null)
			{
				battleSkillItem2.RefreshSkillIcon();
			}
		}
	}

	// Token: 0x0600B6F9 RID: 46841 RVA: 0x00360CE4 File Offset: 0x0035EEE4
	private void RefreshSkillName()
	{
		BattleSkillItem battleSkillItem = this.BattleSkillItemList[0];
		BattleSkillItem battleSkillItem2 = this.BattleSkillItemList[5];
		if (battleSkillItem != null)
		{
			battleSkillItem.RefreshSkillName();
		}
		if (battleSkillItem2 == null)
		{
			return;
		}
		battleSkillItem2.RefreshSkillName();
	}

	// Token: 0x0600B6FA RID: 46842 RVA: 0x00360D1D File Offset: 0x0035EF1D
	protected override string[] GetActionNameList()
	{
		return TrapDefenseMobileSkillPanel.actionNameList;
	}

	// Token: 0x0600B6FB RID: 46843 RVA: 0x00360D24 File Offset: 0x0035EF24
	public void RefreshMachineCdState()
	{
		TrapDefenseBattleSkillItem trapDefenseBattleSkillItem = this.BattleSkillItemList[0] as TrapDefenseBattleSkillItem;
		TrapDefenseBattleSkillItem trapDefenseBattleSkillItem2 = this.BattleSkillItemList[5] as TrapDefenseBattleSkillItem;
		if (trapDefenseBattleSkillItem == null || trapDefenseBattleSkillItem2 == null)
		{
			return;
		}
		if (this.IsInBuild)
		{
			trapDefenseBattleSkillItem.ResetSkillCoolDown();
			trapDefenseBattleSkillItem2.ResetSkillCoolDown();
			return;
		}
		trapDefenseBattleSkillItem.RefreshTrapDefenseSkillCoolDown();
		trapDefenseBattleSkillItem2.RefreshTrapDefenseSkillCoolDown();
	}

	// Token: 0x040069B4 RID: 27060
	[StaticVariableRuleIgnore]
	private static readonly string[] actionNameList = new string[]
	{
		"塔防射击",
		"塔防旋转",
		"塔防道具",
		"塔防冲刺",
		"塔防跳跃",
		"塔防射击",
		"塔防回收机关"
	};

	// Token: 0x040069B5 RID: 27061
	private const string BUILD_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/SkillIcon/SkillIconNor/SP_IconT62.SP_IconT62";

	// Token: 0x040069B6 RID: 27062
	protected bool IsInBuild;

	// Token: 0x040069B7 RID: 27063
	protected ETrapDefenseBuildTipsType Type;

	// Token: 0x040069B8 RID: 27064
	[Nullable(2)]
	private TrapDefenseRecyclePriceItem RecyclePriceItem;

	// Token: 0x020074D6 RID: 29910
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402601C RID: 155676
		public const int AttackOrBuild = 0;

		// Token: 0x0402601D RID: 155677
		public const int Rotate = 1;

		// Token: 0x0402601E RID: 155678
		public const int Explore = 2;

		// Token: 0x0402601F RID: 155679
		public const int Run = 3;

		// Token: 0x04026020 RID: 155680
		public const int Jump = 4;

		// Token: 0x04026021 RID: 155681
		public const int SubAttack = 5;

		// Token: 0x04026022 RID: 155682
		public const int Recover = 6;
	}
}
