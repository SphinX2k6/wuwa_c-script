using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.TrapDefense;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D3B RID: 7483
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseMobileSkillPanel : TrapDefenseSkillPanelBase
{
	// Token: 0x0600E2D0 RID: 58064 RVA: 0x00354F60 File Offset: 0x00353160
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

	// Token: 0x0600E2D1 RID: 58065 RVA: 0x00355014 File Offset: 0x00353214
	public override UniTask InitializeAsync()
	{
		TrapDefenseMobileSkillPanel.<InitializeAsync>d__7 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<TrapDefenseMobileSkillPanel.<InitializeAsync>d__7>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E2D2 RID: 58066 RVA: 0x00355058 File Offset: 0x00353258
	protected override void OnChildStart()
	{
		bool flag = RouletteModel.Instance.IsExploreRouletteOpen(false);
		bool curInstToLevelDataHasShop = TrapDefenseModel.Instance.GetCurInstToLevelDataHasShop();
		this.RefreshSkillItemActive(2, flag && curInstToLevelDataHasShop);
		((TrapDefenseBattleSkillItem)this.BattleSkillItemList[5]).SetIsBanLongPress(true);
	}

	// Token: 0x0600E2D3 RID: 58067 RVA: 0x003550A0 File Offset: 0x003532A0
	private UniTask NewAllBattleSkillItems()
	{
		TrapDefenseMobileSkillPanel.<NewAllBattleSkillItems>d__9 <NewAllBattleSkillItems>d__;
		<NewAllBattleSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewAllBattleSkillItems>d__.<>4__this = this;
		<NewAllBattleSkillItems>d__.<>1__state = -1;
		<NewAllBattleSkillItems>d__.<>t__builder.Start<TrapDefenseMobileSkillPanel.<NewAllBattleSkillItems>d__9>(ref <NewAllBattleSkillItems>d__);
		return <NewAllBattleSkillItems>d__.<>t__builder.Task;
	}

	// Token: 0x0600E2D4 RID: 58068 RVA: 0x003550E4 File Offset: 0x003532E4
	private void RefreshSkillItemActive(int index, bool active)
	{
		TrapDefenseBattleSkillData trapDefenseBattleSkillData;
		if (this.DataMap.TryGetValue(index, out trapDefenseBattleSkillData))
		{
			trapDefenseBattleSkillData.SetVisible(active);
		}
		this.BattleSkillItemList[index].RefreshVisible();
	}

	// Token: 0x0600E2D5 RID: 58069 RVA: 0x0035511C File Offset: 0x0035331C
	private void RefreshSkillItemEnable(int index, bool enable)
	{
		TrapDefenseBattleSkillData trapDefenseBattleSkillData;
		if (this.DataMap.TryGetValue(index, out trapDefenseBattleSkillData))
		{
			trapDefenseBattleSkillData.SetEnable(enable);
		}
		this.BattleSkillItemList[index].RefreshEnable(false);
	}

	// Token: 0x0600E2D6 RID: 58070 RVA: 0x00355152 File Offset: 0x00353352
	public void SetRecyclePrice(int recyclePrice)
	{
		this.RecyclePriceItem.UpdatePrice(recyclePrice);
	}

	// Token: 0x0600E2D7 RID: 58071 RVA: 0x00355160 File Offset: 0x00353360
	public void RefreshButtonByTipsType(ETrapDefenseBuildTipsType type)
	{
		this.Type = type;
		bool active = (this.Type & ETrapDefenseBuildTipsType.Recycle) > ETrapDefenseBuildTipsType.None;
		this.RefreshSkillItemActive(6, active);
		this.RefreshAttackAndRotate();
	}

	// Token: 0x0600E2D8 RID: 58072 RVA: 0x00355190 File Offset: 0x00353390
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

	// Token: 0x0600E2D9 RID: 58073 RVA: 0x003551F3 File Offset: 0x003533F3
	public void SetIsInBuild(bool isInBuild)
	{
		this.IsInBuild = isInBuild;
		this.RefreshBuildData();
		this.RefreshBuildIcon();
		this.RefreshSkillName();
		this.RefreshMachineCdState();
		this.RefreshAttackAndRotate();
	}

	// Token: 0x0600E2DA RID: 58074 RVA: 0x0035521C File Offset: 0x0035341C
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

	// Token: 0x0600E2DB RID: 58075 RVA: 0x00355264 File Offset: 0x00353464
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

	// Token: 0x0600E2DC RID: 58076 RVA: 0x003552B4 File Offset: 0x003534B4
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

	// Token: 0x0600E2DD RID: 58077 RVA: 0x003552ED File Offset: 0x003534ED
	protected override string[] GetActionNameList()
	{
		return TrapDefenseMobileSkillPanel.actionNameList;
	}

	// Token: 0x0600E2DE RID: 58078 RVA: 0x003552F4 File Offset: 0x003534F4
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

	// Token: 0x040068D5 RID: 26837
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

	// Token: 0x040068D6 RID: 26838
	private const string BUILD_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Atlas/SkillIcon/SkillIconNor/SP_IconT62.SP_IconT62";

	// Token: 0x040068D7 RID: 26839
	protected bool IsInBuild;

	// Token: 0x040068D8 RID: 26840
	protected ETrapDefenseBuildTipsType Type;

	// Token: 0x040068D9 RID: 26841
	[Nullable(2)]
	private TrapDefenseRecyclePriceItem RecyclePriceItem;

	// Token: 0x0200834D RID: 33613
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402ACF4 RID: 175348
		public const int AttackOrBuild = 0;

		// Token: 0x0402ACF5 RID: 175349
		public const int Rotate = 1;

		// Token: 0x0402ACF6 RID: 175350
		public const int Explore = 2;

		// Token: 0x0402ACF7 RID: 175351
		public const int Run = 3;

		// Token: 0x0402ACF8 RID: 175352
		public const int Jump = 4;

		// Token: 0x0402ACF9 RID: 175353
		public const int SubAttack = 5;

		// Token: 0x0402ACFA RID: 175354
		public const int Recover = 6;
	}
}
