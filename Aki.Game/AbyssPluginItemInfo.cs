using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020006CF RID: 1743
[NullableContext(1)]
[Nullable(0)]
public class AbyssPluginItemInfo : AttributeItemData
{
	// Token: 0x06004FF3 RID: 20467 RVA: 0x001AD583 File Offset: 0x001AB783
	public AbyssPluginItemInfo(Aki.Protocol.AbyssPluginItemInfo data) : base(data.ItemId, data.IncrId, data.FuncValue, InventoryDefine.EItemDataType.DangoAbyssItem)
	{
		this.Count = data.Count;
	}

	// Token: 0x06004FF4 RID: 20468 RVA: 0x001AD5AB File Offset: 0x001AB7AB
	public void SetRoleId(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x06004FF5 RID: 20469 RVA: 0x001AD5B4 File Offset: 0x001AB7B4
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x06004FF6 RID: 20470 RVA: 0x001AD5BC File Offset: 0x001AB7BC
	public int GetItemId()
	{
		return this.ConfigId;
	}

	// Token: 0x06004FF7 RID: 20471 RVA: 0x001AD5C4 File Offset: 0x001AB7C4
	public override TItemConfig GetConfig()
	{
		return DangoAbyssConfig.Instance.GetDangoItemById(this.ConfigId).Value;
	}

	// Token: 0x06004FF8 RID: 20472 RVA: 0x001AD5F0 File Offset: 0x001AB7F0
	public override InventoryDefine.EItemMainTypeId? GetMainType()
	{
		return null;
	}

	// Token: 0x06004FF9 RID: 20473 RVA: 0x001AD606 File Offset: 0x001AB806
	public override InventoryDefine.EItemType? GetType()
	{
		return new InventoryDefine.EItemType?(InventoryDefine.EItemType.AbyssItem);
	}

	// Token: 0x06004FFA RID: 20474 RVA: 0x001AD614 File Offset: 0x001AB814
	public override int GetSortIndex()
	{
		TypeInfo? itemTypeConfig = base.GetItemTypeConfig();
		if (itemTypeConfig == null)
		{
			return 0;
		}
		return itemTypeConfig.Value.SortIndex;
	}

	// Token: 0x06004FFB RID: 20475 RVA: 0x001AD644 File Offset: 0x001AB844
	[NullableContext(0)]
	public override Span<int> GetItemAccess()
	{
		return default(Span<int>);
	}

	// Token: 0x06004FFC RID: 20476 RVA: 0x001AD65A File Offset: 0x001AB85A
	public override int GetMaxStackCount()
	{
		return 1;
	}

	// Token: 0x06004FFD RID: 20477 RVA: 0x001AD65D File Offset: 0x001AB85D
	public override int GetUseCountLimit()
	{
		return 1;
	}

	// Token: 0x06004FFE RID: 20478 RVA: 0x001AD660 File Offset: 0x001AB860
	public override InventoryDefine.ERedDotDisableRule GetRedDotDisableRule()
	{
		return InventoryDefine.ERedDotDisableRule.AfterSelect;
	}

	// Token: 0x06004FFF RID: 20479 RVA: 0x001AD663 File Offset: 0x001AB863
	public override bool IsValid()
	{
		return true;
	}

	// Token: 0x06005000 RID: 20480 RVA: 0x001AD666 File Offset: 0x001AB866
	public override bool HasRedDot()
	{
		return false;
	}

	// Token: 0x06005001 RID: 20481 RVA: 0x001AD66C File Offset: 0x001AB86C
	public override int GetQuality()
	{
		return this.GetConfig().As<AbyssItem>().Value.QualityId;
	}

	// Token: 0x06005002 RID: 20482 RVA: 0x001AD694 File Offset: 0x001AB894
	public ConfigPropValue[] GetProp()
	{
		return this.GetConfig().As<AbyssItem>().Value.Prop();
	}

	// Token: 0x06005003 RID: 20483 RVA: 0x001AD6BC File Offset: 0x001AB8BC
	public int GetBelongRole()
	{
		return this.GetConfig().As<AbyssItem>().Value.BelongLittleRole;
	}

	// Token: 0x06005004 RID: 20484 RVA: 0x001AD6E4 File Offset: 0x001AB8E4
	public bool GetCanRecovery()
	{
		return this.RoleId <= 0 && !this.GetIsLock();
	}

	// Token: 0x06005005 RID: 20485 RVA: 0x001AD6FC File Offset: 0x001AB8FC
	public string GetFormationCoreBgPath()
	{
		AbyssQuality? abyssQualityById = DangoAbyssConfig.Instance.GetAbyssQualityById(this.GetQuality());
		return ((abyssQualityById != null) ? abyssQualityById.GetValueOrDefault().AbyssCoreItemFormationBg : null) ?? "";
	}

	// Token: 0x06005006 RID: 20486 RVA: 0x001AD740 File Offset: 0x001AB940
	public string GetFormationBgPath()
	{
		AbyssQuality? abyssQualityById = DangoAbyssConfig.Instance.GetAbyssQualityById(this.GetQuality());
		return ((abyssQualityById != null) ? abyssQualityById.GetValueOrDefault().AbyssItemFormationBg : null) ?? "";
	}

	// Token: 0x06005007 RID: 20487 RVA: 0x001AD784 File Offset: 0x001AB984
	public string GetFormationBgColor()
	{
		AbyssQuality? abyssQualityById = DangoAbyssConfig.Instance.GetAbyssQualityById(this.GetQuality());
		return ((abyssQualityById != null) ? abyssQualityById.GetValueOrDefault().AbyssItemFormationBgColor : null) ?? "";
	}

	// Token: 0x06005008 RID: 20488 RVA: 0x001AD7C8 File Offset: 0x001AB9C8
	public string GetPassiveSkillDesc()
	{
		string passiveBuffShowDesc = this.GetConfig().As<AbyssItem>().Value.PassiveBuffShowDesc;
		if (passiveBuffShowDesc == "")
		{
			return "";
		}
		string[] passiveSkillDescAdd = this.GetPassiveSkillDescAdd();
		return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(passiveBuffShowDesc, null), passiveSkillDescAdd);
	}

	// Token: 0x06005009 RID: 20489 RVA: 0x001AD818 File Offset: 0x001ABA18
	public string GetBgDesc()
	{
		string bgDescription = this.GetConfig().As<AbyssItem>().Value.BgDescription;
		if (bgDescription == "")
		{
			return "";
		}
		string[] passiveSkillDescAdd = this.GetPassiveSkillDescAdd();
		return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(bgDescription, null), passiveSkillDescAdd);
	}

	// Token: 0x0600500A RID: 20490 RVA: 0x001AD868 File Offset: 0x001ABA68
	private string[] GetPassiveSkillDescAdd()
	{
		AbyssItem value = this.GetConfig().As<AbyssItem>().Value;
		if (value.LevelDescStrArray().Length > 0)
		{
			int j = 0;
			StringArray? stringArray = value.LevelDescStrArray(j);
			if (stringArray != null)
			{
				StringArray value2 = stringArray.Value;
				int arrayStringLength = value2.ArrayStringLength;
				string[] array = new string[arrayStringLength];
				for (int i = 0; i < arrayStringLength; i++)
				{
					array[i] = value2.ArrayString(i);
				}
				return array;
			}
		}
		return Array.Empty<string>();
	}

	// Token: 0x0600500B RID: 20491 RVA: 0x001AD8EB File Offset: 0x001ABAEB
	[NullableContext(2)]
	public override InventoryDefine.IItemViewDataInfo GetItemViewDataInfo(ItemViewDefine.EItemOperationMode viewMode)
	{
		return null;
	}

	// Token: 0x04003975 RID: 14709
	private int RoleId;
}
