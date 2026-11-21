using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02001200 RID: 4608
public class TrapDefenseBattleExploreSkillData : TrapDefenseBattleSkillData
{
	// Token: 0x1700124E RID: 4686
	// (get) Token: 0x0600B722 RID: 46882 RVA: 0x00361583 File Offset: 0x0035F783
	private bool IsUseItem
	{
		get
		{
			return RouletteModel.Instance.IsEquipItemSelectOn;
		}
	}

	// Token: 0x0600B723 RID: 46883 RVA: 0x00361590 File Offset: 0x0035F790
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

	// Token: 0x0600B724 RID: 46884 RVA: 0x00361656 File Offset: 0x0035F856
	public override bool IsEnableLongPress()
	{
		return true;
	}

	// Token: 0x0600B725 RID: 46885 RVA: 0x00361659 File Offset: 0x0035F859
	public override bool IsEnableInput()
	{
		return this.IsEnableInternal;
	}

	// Token: 0x0600B726 RID: 46886 RVA: 0x00361661 File Offset: 0x0035F861
	public override bool IsEquippedItemBanReqUse()
	{
		return this.IsUseItem && RouletteModel.Instance.IsEquippedItemBanReqUse();
	}

	// Token: 0x0600B727 RID: 46887 RVA: 0x00361677 File Offset: 0x0035F877
	public override bool IsSkillInItemUseCd()
	{
		return this.IsSkillInItemUseBuffCd() || this.IsSkillInItemUseSkillCd();
	}

	// Token: 0x0600B728 RID: 46888 RVA: 0x00361689 File Offset: 0x0035F889
	public override bool IsSkillInItemUseBuffCd()
	{
		return this.IsUseItem && !base.IsExploreAsFight && RouletteModel.Instance.IsEquipItemInBuffCd();
	}

	// Token: 0x0600B729 RID: 46889 RVA: 0x003616A8 File Offset: 0x0035F8A8
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

	// Token: 0x0600B72A RID: 46890 RVA: 0x003617B0 File Offset: 0x0035F9B0
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

	// Token: 0x0600B72B RID: 46891 RVA: 0x00361804 File Offset: 0x0035FA04
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

	// Token: 0x0600B72C RID: 46892 RVA: 0x00361894 File Offset: 0x0035FA94
	public override int GetSkillId()
	{
		return this.ExploreSkillId;
	}

	// Token: 0x0600B72D RID: 46893 RVA: 0x0036189C File Offset: 0x0035FA9C
	public void SetExploreSkillId(int exploreSkillId)
	{
		bool exploreSkillChange = this.ExploreSkillId != exploreSkillId;
		this.ExploreSkillId = exploreSkillId;
		base.SetExploreSkillChange(exploreSkillChange);
		this.RefreshSkillTexturePath();
	}

	// Token: 0x0600B72E RID: 46894 RVA: 0x003618CA File Offset: 0x0035FACA
	public override void RefreshSkillCd()
	{
		if (this.IsUseItem && !base.IsExploreAsFight && (this.IsEquippedItemBanReqUse() || this.IsSkillInItemUseCd()))
		{
			this.IsEnableInternal = false;
			return;
		}
		base.RefreshSkillCd();
	}

	// Token: 0x040069BC RID: 27068
	[Nullable(1)]
	private const string SKILL_NONE_PATH = "T_IconSkillNone";

	// Token: 0x040069BD RID: 27069
	protected int ExploreSkillId;
}
