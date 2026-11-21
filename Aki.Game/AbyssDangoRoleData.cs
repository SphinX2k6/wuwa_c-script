using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x020006CE RID: 1742
[NullableContext(1)]
[Nullable(0)]
public class AbyssDangoRoleData
{
	// Token: 0x06004FCA RID: 20426 RVA: 0x001AC9CA File Offset: 0x001AABCA
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06004FCB RID: 20427 RVA: 0x001AC9D2 File Offset: 0x001AABD2
	public int GetLevel()
	{
		return this.Level;
	}

	// Token: 0x06004FCC RID: 20428 RVA: 0x001AC9DA File Offset: 0x001AABDA
	public int[] GetEquipItems()
	{
		return this.EquipItems;
	}

	// Token: 0x06004FCD RID: 20429 RVA: 0x001AC9E4 File Offset: 0x001AABE4
	public int[] GetEquipItemConfigIdList()
	{
		List<int> list = new List<int>();
		foreach (int incId in this.EquipItems)
		{
			global::AbyssPluginItemInfo pluginItemInfoById = DangoAbyssModel.Instance.GetPluginItemInfoById(incId);
			if (pluginItemInfoById != null)
			{
				list.Add(pluginItemInfoById.GetItemId());
			}
			else
			{
				list.Add(0);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06004FCE RID: 20430 RVA: 0x001ACA3D File Offset: 0x001AAC3D
	public bool GetIfLock()
	{
		return this.Lock;
	}

	// Token: 0x06004FCF RID: 20431 RVA: 0x001ACA48 File Offset: 0x001AAC48
	public string GetTexture()
	{
		return this.GetConfig().Value.Icon;
	}

	// Token: 0x06004FD0 RID: 20432 RVA: 0x001ACA6C File Offset: 0x001AAC6C
	public string GetFormationIcon()
	{
		return this.GetConfig().Value.FormationIcon;
	}

	// Token: 0x06004FD1 RID: 20433 RVA: 0x001ACA90 File Offset: 0x001AAC90
	public int GetMeshId()
	{
		int phantomId = this.GetPhantomId();
		return PhantomBattleModel.Instance.GetPhantomInstanceByItemId(phantomId).PhantomItem.Value.MeshId;
	}

	// Token: 0x06004FD2 RID: 20434 RVA: 0x001ACAC4 File Offset: 0x001AACC4
	public int GetPhantomId()
	{
		return this.GetConfig().Value.PhantomItemId;
	}

	// Token: 0x06004FD3 RID: 20435 RVA: 0x001ACAE7 File Offset: 0x001AACE7
	public void Init(AbyssLittleRole data)
	{
		this.Id = data.Id;
		this.Level = 1;
	}

	// Token: 0x06004FD4 RID: 20436 RVA: 0x001ACB00 File Offset: 0x001AAD00
	public void Phrase(AbyssRoleInfo data, int[] itemIdList)
	{
		this.Id = data.Id;
		this.Level = data.Level;
		RepeatedField<int> equipItems = data.EquipItems;
		int[] array = new int[equipItems.Count];
		equipItems.CopyTo(array, 0);
		this.EquipItems = array;
		this.Lock = false;
		this.PhraseSlotData(data.EquipItems, itemIdList);
	}

	// Token: 0x06004FD5 RID: 20437 RVA: 0x001ACB5C File Offset: 0x001AAD5C
	public void PhraseSlotData(IReadOnlyList<int> incIdList, int[] itemIdList)
	{
		if (incIdList.Count < 9)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.WDX;
			string message = "团子插槽信息不足";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dangoId", this.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		for (int i = 0; i < 9; i++)
		{
			int uniqueId = incIdList[i];
			int itemId = itemIdList[i];
			AbyssDangoRoleSlotData abyssDangoRoleSlotData = new AbyssDangoRoleSlotData();
			abyssDangoRoleSlotData.SetDangoRoleId(this.Id);
			abyssDangoRoleSlotData.Refresh(i, uniqueId, itemId);
			this.PluginSlotDataMap[i] = abyssDangoRoleSlotData;
		}
	}

	// Token: 0x06004FD6 RID: 20438 RVA: 0x001ACBEC File Offset: 0x001AADEC
	public int GetQuality()
	{
		return this.GetConfig().Value.Quality;
	}

	// Token: 0x06004FD7 RID: 20439 RVA: 0x001ACC10 File Offset: 0x001AAE10
	public string GetQualitySpritePath()
	{
		return DangoAbyssConfig.Instance.GetAbyssQualityById(this.GetQuality()).Value.Bg;
	}

	// Token: 0x06004FD8 RID: 20440 RVA: 0x001ACC40 File Offset: 0x001AAE40
	public Dictionary<int, int> GetEquipPluginMap()
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 0; i < 9; i++)
		{
			dictionary[i] = 0;
		}
		foreach (KeyValuePair<int, AbyssDangoRoleSlotData> keyValuePair in this.PluginSlotDataMap)
		{
			dictionary[keyValuePair.Value.GetSlotIndex()] = keyValuePair.Value.GetEquipId();
		}
		return dictionary;
	}

	// Token: 0x06004FD9 RID: 20441 RVA: 0x001ACCC8 File Offset: 0x001AAEC8
	[NullableContext(2)]
	public AbyssDangoRoleSlotData GetPluginSlotData(int slot)
	{
		AbyssDangoRoleSlotData result;
		if (this.PluginSlotDataMap.TryGetValue(slot, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06004FDA RID: 20442 RVA: 0x001ACCE8 File Offset: 0x001AAEE8
	public int GetCurrentPluginSlotNum()
	{
		return this.GetLevelConfig().Value.PluginNum;
	}

	// Token: 0x06004FDB RID: 20443 RVA: 0x001ACD0C File Offset: 0x001AAF0C
	public string GetName()
	{
		return this.GetConfig().Value.Name;
	}

	// Token: 0x06004FDC RID: 20444 RVA: 0x001ACD30 File Offset: 0x001AAF30
	public AbyssCastDesc GetCastTypeDesc()
	{
		return DangoAbyssConfig.Instance.GetDangoCastDescById(this.GetConfig().Value.CastType).Value;
	}

	// Token: 0x06004FDD RID: 20445 RVA: 0x001ACD68 File Offset: 0x001AAF68
	public string GetSkillCastTypeName()
	{
		return this.GetCastTypeDesc().Name;
	}

	// Token: 0x06004FDE RID: 20446 RVA: 0x001ACD84 File Offset: 0x001AAF84
	public string GetSkillCastTypeIconPath()
	{
		return this.GetCastTypeDesc().Icon;
	}

	// Token: 0x06004FDF RID: 20447 RVA: 0x001ACD9F File Offset: 0x001AAF9F
	public AbyssLittleRole? GetConfig()
	{
		return DangoAbyssConfig.Instance.GetDangoRoleById(this.Id);
	}

	// Token: 0x06004FE0 RID: 20448 RVA: 0x001ACDB4 File Offset: 0x001AAFB4
	private int GetLevelGroupId()
	{
		return this.GetConfig().Value.LevelGroupId;
	}

	// Token: 0x06004FE1 RID: 20449 RVA: 0x001ACDD7 File Offset: 0x001AAFD7
	[NullableContext(2)]
	public IReadOnlyList<AbyssRoleLevel> GetLevelGroupConfigs()
	{
		return DangoAbyssConfig.Instance.GetDangoLevelConfigByGroupId(this.GetLevelGroupId());
	}

	// Token: 0x06004FE2 RID: 20450 RVA: 0x001ACDEC File Offset: 0x001AAFEC
	public int GetSkillId()
	{
		return PhantomBattleModel.Instance.GetPhantomInstanceByItemId(this.GetConfig().Value.PhantomItemId).GetPhantomSkillId().Value;
	}

	// Token: 0x06004FE3 RID: 20451 RVA: 0x001ACE26 File Offset: 0x001AB026
	public PhantomSkill? GetSkillConfig()
	{
		return PhantomBattleConfig.Instance.GetPhantomSkillBySkillId(this.GetSkillId());
	}

	// Token: 0x06004FE4 RID: 20452 RVA: 0x001ACE38 File Offset: 0x001AB038
	public string GetSkillDesc()
	{
		PhantomSkill? phantomSkill;
		return ((this.GetSkillConfig() != null) ? phantomSkill.GetValueOrDefault().DescriptionEx : null) ?? string.Empty;
	}

	// Token: 0x06004FE5 RID: 20453 RVA: 0x001ACE70 File Offset: 0x001AB070
	public string[] GetSkillDescAddition()
	{
		int skillId = this.GetSkillId();
		int qualityId = PhantomBattleModel.Instance.GetPhantomInstanceByItemId(this.GetConfig().Value.PhantomItemId).PhantomItem.Value.QualityId;
		return PhantomBattleConfig.Instance.GetPhantomSkillDescExBySkillIdAndQuality(skillId, qualityId);
	}

	// Token: 0x06004FE6 RID: 20454 RVA: 0x001ACEC8 File Offset: 0x001AB0C8
	public string[] GetEffectPassiveSkillDescList()
	{
		List<string> list = new List<string>();
		foreach (KeyValuePair<int, AbyssDangoRoleSlotData> keyValuePair in this.PluginSlotDataMap)
		{
			string passiveSkillDesc = keyValuePair.Value.GetPassiveSkillDesc();
			if (passiveSkillDesc != "")
			{
				list.Add(passiveSkillDesc);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06004FE7 RID: 20455 RVA: 0x001ACF44 File Offset: 0x001AB144
	public AbyssRoleLevel? GetLevelConfig()
	{
		return DangoAbyssConfig.Instance.GetDangoLevelConfigByLevelAndGroupId(this.Level, this.GetLevelGroupId());
	}

	// Token: 0x06004FE8 RID: 20456 RVA: 0x001ACF5C File Offset: 0x001AB15C
	public ICostData[] GetCurrentLevelUpConsume()
	{
		AbyssRoleLevel? levelConfig = this.GetLevelConfig();
		if (levelConfig == null)
		{
			return Array.Empty<ICostData>();
		}
		Dictionary<int, int> dictionary = levelConfig.Value.Consume();
		List<ICostData> list = new List<ICostData>();
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(keyValuePair.Key, 0);
			CostData item = new CostData
			{
				ItemId = keyValuePair.Key,
				Cost = keyValuePair.Value,
				Count = itemCountByConfigId
			};
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x06004FE9 RID: 20457 RVA: 0x001AD01C File Offset: 0x001AB21C
	public bool GetIfLevelUpEnough()
	{
		foreach (ICostData costData in this.GetCurrentLevelUpConsume())
		{
			if (costData.Cost > costData.Count)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06004FEA RID: 20458 RVA: 0x001AD053 File Offset: 0x001AB253
	public int GetMaxLevel()
	{
		return DangoAbyssConfig.Instance.GetDangoLevelConfigByGroupId(this.GetLevelGroupId()).Count;
	}

	// Token: 0x06004FEB RID: 20459 RVA: 0x001AD06C File Offset: 0x001AB26C
	public bool GetIfMaxLevel()
	{
		IReadOnlyList<AbyssRoleLevel> dangoLevelConfigByGroupId = DangoAbyssConfig.Instance.GetDangoLevelConfigByGroupId(this.GetLevelGroupId());
		return this.Level >= dangoLevelConfigByGroupId.Count;
	}

	// Token: 0x06004FEC RID: 20460 RVA: 0x001AD09C File Offset: 0x001AB29C
	public bool GetIfCanLevelUp()
	{
		bool ifLock = this.GetIfLock();
		bool ifMaxLevel = this.GetIfMaxLevel();
		return !ifLock && !ifMaxLevel;
	}

	// Token: 0x06004FED RID: 20461 RVA: 0x001AD0C0 File Offset: 0x001AB2C0
	public AttrListScrollData[] GetLevelUpPreviewData(int targetLevel)
	{
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		foreach (ConfigPropValue configPropValue in DangoAbyssConfig.Instance.GetDangoLevelConfigByLevelAndGroupId(targetLevel - 1, this.GetLevelGroupId()).Value.Prop())
		{
			bool flag = false;
			foreach (AttrListScrollData attrListScrollData in list)
			{
				if (attrListScrollData.Id == configPropValue.Id && attrListScrollData.IsRatio == configPropValue.IsRatio)
				{
					attrListScrollData.BaseValue += (double)configPropValue.Value;
					flag = true;
				}
			}
			if (!flag)
			{
				list.Add(new AttrListScrollData(configPropValue.Id, (double)configPropValue.Value, 0.0, 0, configPropValue.IsRatio, CommonComponentDefine.EAttributeType.NormalType));
			}
		}
		if (targetLevel <= this.GetMaxLevel())
		{
			foreach (ConfigPropValue configPropValue2 in DangoAbyssConfig.Instance.GetDangoLevelConfigByLevelAndGroupId(targetLevel, this.GetLevelGroupId()).Value.Prop())
			{
				bool flag2 = false;
				foreach (AttrListScrollData attrListScrollData2 in list)
				{
					if (attrListScrollData2.Id == configPropValue2.Id && attrListScrollData2.IsRatio == configPropValue2.IsRatio)
					{
						attrListScrollData2.AddValue += (double)configPropValue2.Value;
						flag2 = true;
					}
				}
				if (!flag2)
				{
					list.Add(new AttrListScrollData(configPropValue2.Id, 0.0, (double)configPropValue2.Value, 0, configPropValue2.IsRatio, CommonComponentDefine.EAttributeType.NormalType));
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06004FEE RID: 20462 RVA: 0x001AD2B4 File Offset: 0x001AB4B4
	public int GetLevelUpPluginAddData(int newLevel)
	{
		AbyssRoleLevel? dangoLevelConfigByLevelAndGroupId = DangoAbyssConfig.Instance.GetDangoLevelConfigByLevelAndGroupId(newLevel, this.GetLevelGroupId());
		AbyssRoleLevel? dangoLevelConfigByLevelAndGroupId2 = DangoAbyssConfig.Instance.GetDangoLevelConfigByLevelAndGroupId(newLevel - 1, this.GetLevelGroupId());
		if (dangoLevelConfigByLevelAndGroupId == null || dangoLevelConfigByLevelAndGroupId2 == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.WDX;
			string message = "获取团子升级信息错误，检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("level", newLevel);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0;
		}
		return dangoLevelConfigByLevelAndGroupId.Value.PluginNum - dangoLevelConfigByLevelAndGroupId2.Value.PluginNum;
	}

	// Token: 0x06004FEF RID: 20463 RVA: 0x001AD34C File Offset: 0x001AB54C
	private string GetPropValueString(int indexId, double value, bool isRatio)
	{
		double propRatioValue = TipsDataTool.GetPropRatioValue(value, isRatio);
		return AttributeModel.Instance.GetFormatAttributeValueString(indexId, propRatioValue, isRatio);
	}

	// Token: 0x06004FF0 RID: 20464 RVA: 0x001AD370 File Offset: 0x001AB570
	public IAttributeInfo[] GetLevelUpViewAttributeInfo(int newLevel, bool? isMax = null)
	{
		AttrListScrollData[] levelUpPreviewData = this.GetLevelUpPreviewData(newLevel);
		List<IAttributeInfo> list = new List<IAttributeInfo>();
		foreach (AttrListScrollData attrListScrollData in levelUpPreviewData)
		{
			PropertyIndex value = PropertyIndexConfig.Instance.GetPropertyIndexInfo(attrListScrollData.Id).Value;
			AttributeInfo attributeInfo = new AttributeInfo
			{
				Name = value.Name,
				IconPath = value.Icon,
				ShowArrow = !isMax,
				PreText = this.GetPropValueString(attrListScrollData.Id, attrListScrollData.BaseValue, attrListScrollData.IsRatio)
			};
			if (isMax == null || !isMax.Value)
			{
				attributeInfo.CurText = this.GetPropValueString(attrListScrollData.Id, attrListScrollData.AddValue, attrListScrollData.IsRatio);
			}
			list.Add(attributeInfo);
		}
		int levelUpPluginAddData = this.GetLevelUpPluginAddData(newLevel);
		if (levelUpPluginAddData <= 0 || (isMax != null && isMax.Value))
		{
			return list.ToArray();
		}
		AttributeInfo item = new AttributeInfo
		{
			Name = "Ayess_Chajiancao_Text",
			IconPath = null,
			ShowArrow = new bool?(false),
			CurText = StringUtils.Format("+{0}", new string[]
			{
				levelUpPluginAddData.ToString()
			})
		};
		list.Add(item);
		return list.ToArray();
	}

	// Token: 0x06004FF1 RID: 20465 RVA: 0x001AD4F0 File Offset: 0x001AB6F0
	public ILevelUpSuccessAttributeData GetLevelUpViewData(int newLevel)
	{
		LevelInfo levelInfo = new LevelInfo
		{
			PreUpgradeLv = newLevel - 1,
			UpgradeLv = newLevel,
			FormatStringId = "Text_LevelShow_Text",
			IsMaxLevel = new bool?(newLevel >= this.GetMaxLevel())
		};
		IAttributeInfo[] levelUpViewAttributeInfo = this.GetLevelUpViewAttributeInfo(newLevel, null);
		return new LevelUpSuccessAttributeData
		{
			LevelInfo = levelInfo,
			AttributeInfo = new List<IAttributeInfo>(levelUpViewAttributeInfo)
		};
	}

	// Token: 0x04003970 RID: 14704
	private int Id;

	// Token: 0x04003971 RID: 14705
	private int Level;

	// Token: 0x04003972 RID: 14706
	private int[] EquipItems = Array.Empty<int>();

	// Token: 0x04003973 RID: 14707
	private bool Lock = true;

	// Token: 0x04003974 RID: 14708
	private readonly Dictionary<int, AbyssDangoRoleSlotData> PluginSlotDataMap = new Dictionary<int, AbyssDangoRoleSlotData>();
}
