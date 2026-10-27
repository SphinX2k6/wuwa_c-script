using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200121B RID: 4635
[NullableContext(1)]
[Nullable(0)]
public class AbyssPluginItemInfo : AttributeItemData
{
	// Token: 0x06007C5D RID: 31837 RVA: 0x001A48FB File Offset: 0x001A2AFB
	public AbyssPluginItemInfo(Aki.Protocol.AbyssPluginItemInfo data) : base(data.ItemId, data.IncrId, data.FuncValue, InventoryDefine.EItemDataType.DangoAbyssItem)
	{
		this.Count = data.Count;
	}

	// Token: 0x06007C5E RID: 31838 RVA: 0x001A4923 File Offset: 0x001A2B23
	public void SetRoleId(int roleId)
	{
		this.RoleId = roleId;
	}

	// Token: 0x06007C5F RID: 31839 RVA: 0x001A492C File Offset: 0x001A2B2C
	public int GetRoleId()
	{
		return this.RoleId;
	}

	// Token: 0x06007C60 RID: 31840 RVA: 0x001A4934 File Offset: 0x001A2B34
	public int GetItemId()
	{
		return this.ConfigId;
	}

	// Token: 0x06007C61 RID: 31841 RVA: 0x001A493C File Offset: 0x001A2B3C
	public override TItemConfig GetConfig()
	{
		return DangoAbyssConfig.Instance.GetDangoItemById(this.ConfigId).Value;
	}

	// Token: 0x06007C62 RID: 31842 RVA: 0x001A4968 File Offset: 0x001A2B68
	public override InventoryDefine.EItemMainTypeId? GetMainType()
	{
		return null;
	}

	// Token: 0x06007C63 RID: 31843 RVA: 0x001A497E File Offset: 0x001A2B7E
	public override InventoryDefine.EItemType? GetType()
	{
		return new InventoryDefine.EItemType?(InventoryDefine.EItemType.AbyssItem);
	}

	// Token: 0x06007C64 RID: 31844 RVA: 0x001A498C File Offset: 0x001A2B8C
	public override int GetSortIndex()
	{
		TypeInfo? itemTypeConfig = base.GetItemTypeConfig();
		if (itemTypeConfig == null)
		{
			return 0;
		}
		return itemTypeConfig.Value.SortIndex;
	}

	// Token: 0x06007C65 RID: 31845 RVA: 0x001A49BC File Offset: 0x001A2BBC
	[NullableContext(0)]
	public override Span<int> GetItemAccess()
	{
		return default(Span<int>);
	}

	// Token: 0x06007C66 RID: 31846 RVA: 0x001A49D2 File Offset: 0x001A2BD2
	public override int GetMaxStackCount()
	{
		return 1;
	}

	// Token: 0x06007C67 RID: 31847 RVA: 0x001A49D5 File Offset: 0x001A2BD5
	public override int GetUseCountLimit()
	{
		return 1;
	}

	// Token: 0x06007C68 RID: 31848 RVA: 0x001A49D8 File Offset: 0x001A2BD8
	public override InventoryDefine.ERedDotDisableRule GetRedDotDisableRule()
	{
		return InventoryDefine.ERedDotDisableRule.AfterSelect;
	}

	// Token: 0x06007C69 RID: 31849 RVA: 0x001A49DB File Offset: 0x001A2BDB
	public override bool IsValid()
	{
		return true;
	}

	// Token: 0x06007C6A RID: 31850 RVA: 0x001A49DE File Offset: 0x001A2BDE
	public override bool HasRedDot()
	{
		return false;
	}

	// Token: 0x06007C6B RID: 31851 RVA: 0x001A49E4 File Offset: 0x001A2BE4
	public override int GetQuality()
	{
		return this.GetConfig().As<AbyssItem>().Value.QualityId;
	}

	// Token: 0x06007C6C RID: 31852 RVA: 0x001A4A0C File Offset: 0x001A2C0C
	public ConfigPropValue[] GetProp()
	{
		return this.GetConfig().As<AbyssItem>().Value.Prop();
	}

	// Token: 0x06007C6D RID: 31853 RVA: 0x001A4A34 File Offset: 0x001A2C34
	public int GetBelongRole()
	{
		return this.GetConfig().As<AbyssItem>().Value.BelongLittleRole;
	}

	// Token: 0x06007C6E RID: 31854 RVA: 0x001A4A5C File Offset: 0x001A2C5C
	public bool GetCanRecovery()
	{
		return this.RoleId <= 0 && !this.GetIsLock();
	}

	// Token: 0x06007C6F RID: 31855 RVA: 0x001A4A74 File Offset: 0x001A2C74
	public string GetFormationCoreBgPath()
	{
		AbyssQuality? abyssQualityById = DangoAbyssConfig.Instance.GetAbyssQualityById(this.GetQuality());
		return ((abyssQualityById != null) ? abyssQualityById.GetValueOrDefault().AbyssCoreItemFormationBg : null) ?? "";
	}

	// Token: 0x06007C70 RID: 31856 RVA: 0x001A4AB8 File Offset: 0x001A2CB8
	public string GetFormationBgPath()
	{
		AbyssQuality? abyssQualityById = DangoAbyssConfig.Instance.GetAbyssQualityById(this.GetQuality());
		return ((abyssQualityById != null) ? abyssQualityById.GetValueOrDefault().AbyssItemFormationBg : null) ?? "";
	}

	// Token: 0x06007C71 RID: 31857 RVA: 0x001A4AFC File Offset: 0x001A2CFC
	public string GetFormationBgColor()
	{
		AbyssQuality? abyssQualityById = DangoAbyssConfig.Instance.GetAbyssQualityById(this.GetQuality());
		return ((abyssQualityById != null) ? abyssQualityById.GetValueOrDefault().AbyssItemFormationBgColor : null) ?? "";
	}

	// Token: 0x06007C72 RID: 31858 RVA: 0x001A4B40 File Offset: 0x001A2D40
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

	// Token: 0x06007C73 RID: 31859 RVA: 0x001A4B90 File Offset: 0x001A2D90
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

	// Token: 0x06007C74 RID: 31860 RVA: 0x001A4BE0 File Offset: 0x001A2DE0
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

	// Token: 0x06007C75 RID: 31861 RVA: 0x001A4C63 File Offset: 0x001A2E63
	[NullableContext(2)]
	public override InventoryDefine.IItemViewDataInfo GetItemViewDataInfo(ItemViewDefine.EItemOperationMode viewMode)
	{
		return null;
	}

	// Token: 0x040038DC RID: 14556
	private int RoleId;
}
