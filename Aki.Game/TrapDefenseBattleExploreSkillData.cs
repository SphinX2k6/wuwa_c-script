using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02001D3E RID: 7486
public class TrapDefenseBattleExploreSkillData : TrapDefenseBattleSkillData
{
	// Token: 0x17001224 RID: 4644
	// (get) Token: 0x0600E305 RID: 58117 RVA: 0x00355B53 File Offset: 0x00353D53
	private bool IsUseItem
	{
		get
		{
			return RouletteModel.Instance.IsEquipItemSelectOn;
		}
	}

	// Token: 0x0600E306 RID: 58118 RVA: 0x00355B60 File Offset: 0x00353D60
	protected override void RefreshSkillTexturePath()
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_IconSkillNone");
		TrapDefenseItem? trapDefenseItemByExploreToolId = TrapDefenseConfig.Instance.GetTrapDefenseItemByExploreToolId(this.ExploreSkillId);
		if (trapDefenseItemByExploreToolId == null)
		{
			this.SkillTexturePath = resourcePath;
			return;
		}
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		TrapDefenseBattleItemData trapDefenseBattleItemData = (instance != null) ? instance.BattleInventoryData.GetItemData(trapDefenseItemByExploreToolId.Value.Id) : null;
		if (trapDefenseBattleItemData == null || trapDefenseBattleItemData.InventoryCount <= 0)
		{
			this.SkillTexturePath = resourcePath;
			return;
		}
		this.SkillTexturePath = RouletteModel.Instance.CurrentExploreSkillIcon;
		if (!string.IsNullOrEmpty(this.SkillTexturePath))
		{
			return;
		}
		if (this.Config == null)
		{
			this.SkillTexturePath = resourcePath;
			return;
		}
		this.SkillTexturePath = this.Config.Value.SkillIcon;
	}

	// Token: 0x0600E307 RID: 58119 RVA: 0x00355C26 File Offset: 0x00353E26
	public override bool IsEnableLongPress()
	{
		return true;
	}

	// Token: 0x0600E308 RID: 58120 RVA: 0x00355C29 File Offset: 0x00353E29
	public override bool IsEnableInput()
	{
		return this.IsEnableInternal;
	}

	// Token: 0x0600E309 RID: 58121 RVA: 0x00355C31 File Offset: 0x00353E31
	public override bool IsEquippedItemBanReqUse()
	{
		return this.IsUseItem && RouletteModel.Instance.IsEquippedItemBanReqUse();
	}

	// Token: 0x0600E30A RID: 58122 RVA: 0x00355C47 File Offset: 0x00353E47
	public override bool IsSkillInItemUseCd()
	{
		return this.IsSkillInItemUseBuffCd() || this.IsSkillInItemUseSkillCd();
	}

	// Token: 0x0600E30B RID: 58123 RVA: 0x00355C59 File Offset: 0x00353E59
	public override bool IsSkillInItemUseBuffCd()
	{
		return this.IsUseItem && !base.IsExploreAsFight && RouletteModel.Instance.IsEquipItemInBuffCd();
	}

	// Token: 0x0600E30C RID: 58124 RVA: 0x00355C78 File Offset: 0x00353E78
	public override bool IsSkillInItemUseSkillCd()
	{
		if (this.IsUseItem && this.CharacterSkillCdComponent != null && !base.IsExploreAsFight)
		{
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(RouletteModel.Instance.CurrentEquipItemId);
			int skillId;
			if (itemConfig != null && itemConfig.Value.Parameters().TryGetValue(21, out skillId))
			{
				GroupSkillCdInfo groupSkillCdInfo = this.CharacterSkillCdComponent.GetGroupSkillCdInfo(skillId);
				float? num = (groupSkillCdInfo != null) ? new float?(groupSkillCdInfo.CurRemainingCd) : null;
				double? num2 = ((num != null) ? new double?((double)num.GetValueOrDefault()) : null) - TimeUtil.Instance.TimeDeviation;
				double num3 = 0.0;
				return num2.GetValueOrDefault() > num3 & num2 != null;
			}
		}
		return false;
	}

	// Token: 0x0600E30D RID: 58125 RVA: 0x00355D80 File Offset: 0x00353F80
	public override ValueTuple<double, double> GetEquippedItemUsingBuffCd()
	{
		if (this.IsUseItem)
		{
			int currentEquipItemId = RouletteModel.Instance.CurrentEquipItemId;
			BuffItemModel instance = BuffItemModel.Instance;
			double buffItemRemainCdTime = instance.GetBuffItemRemainCdTime(currentEquipItemId);
			double buffItemTotalCdTime = instance.GetBuffItemTotalCdTime(currentEquipItemId);
			return new ValueTuple<double, double>(buffItemRemainCdTime, buffItemTotalCdTime);
		}
		return new ValueTuple<double, double>(0.0, 0.0);
	}

	// Token: 0x0600E30E RID: 58126 RVA: 0x00355DD4 File Offset: 0x00353FD4
	public override ValueTuple<double, double> GetEquippedItemUsingSkillCd()
	{
		if (this.IsUseItem && this.CharacterSkillCdComponent != null)
		{
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(RouletteModel.Instance.CurrentEquipItemId);
			int skillId;
			if (itemConfig != null && itemConfig.Value.Parameters().TryGetValue(21, out skillId))
			{
				GroupSkillCdInfo groupSkillCdInfo = this.CharacterSkillCdComponent.GetGroupSkillCdInfo(skillId);
				if (groupSkillCdInfo != null)
				{
					return new ValueTuple<double, double>((double)groupSkillCdInfo.CurRemainingCd, (double)groupSkillCdInfo.CurMaxCd);
				}
			}
		}
		return new ValueTuple<double, double>(0.0, 0.0);
	}

	// Token: 0x0600E30F RID: 58127 RVA: 0x00355E64 File Offset: 0x00354064
	public override int GetSkillId()
	{
		return this.ExploreSkillId;
	}

	// Token: 0x0600E310 RID: 58128 RVA: 0x00355E6C File Offset: 0x0035406C
	public void SetExploreSkillId(int exploreSkillId)
	{
		bool exploreSkillChange = this.ExploreSkillId != exploreSkillId;
		this.ExploreSkillId = exploreSkillId;
		base.SetExploreSkillChange(exploreSkillChange);
		this.RefreshSkillTexturePath();
	}

	// Token: 0x0600E311 RID: 58129 RVA: 0x00355E9A File Offset: 0x0035409A
	public override void RefreshSkillCd()
	{
		if (this.IsUseItem && !base.IsExploreAsFight && (this.IsEquippedItemBanReqUse() || this.IsSkillInItemUseCd()))
		{
			this.IsEnableInternal = false;
			return;
		}
		base.RefreshSkillCd();
	}

	// Token: 0x040068DD RID: 26845
	[Nullable(1)]
	private const string SKILL_NONE_PATH = "T_IconSkillNone";

	// Token: 0x040068DE RID: 26846
	protected int ExploreSkillId;
}
