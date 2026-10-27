using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200121A RID: 4634
[NullableContext(1)]
[Nullable(0)]
public class AbyssDangoRoleData
{
	// Token: 0x06007C34 RID: 31796 RVA: 0x001A3D52 File Offset: 0x001A1F52
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06007C35 RID: 31797 RVA: 0x001A3D5A File Offset: 0x001A1F5A
	public int GetLevel()
	{
		return this.Level;
	}

	// Token: 0x06007C36 RID: 31798 RVA: 0x001A3D62 File Offset: 0x001A1F62
	public int[] GetEquipItems()
	{
		return this.EquipItems;
	}

	// Token: 0x06007C37 RID: 31799 RVA: 0x001A3D6C File Offset: 0x001A1F6C
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

	// Token: 0x06007C38 RID: 31800 RVA: 0x001A3DC5 File Offset: 0x001A1FC5
	public bool GetIfLock()
	{
		return this.Lock;
	}

	// Token: 0x06007C39 RID: 31801 RVA: 0x001A3DD0 File Offset: 0x001A1FD0
	public string GetTexture()
	{
		return this.GetConfig().Value.Icon;
	}

	// Token: 0x06007C3A RID: 31802 RVA: 0x001A3DF4 File Offset: 0x001A1FF4
	public string GetFormationIcon()
	{
		return this.GetConfig().Value.FormationIcon;
	}

	// Token: 0x06007C3B RID: 31803 RVA: 0x001A3E18 File Offset: 0x001A2018
	public int GetMeshId()
	{
		int phantomId = this.GetPhantomId();
		return PhantomBattleModel.Instance.GetPhantomInstanceByItemId(phantomId).PhantomItem.Value.MeshId;
	}

	// Token: 0x06007C3C RID: 31804 RVA: 0x001A3E4C File Offset: 0x001A204C
	public int GetPhantomId()
	{
		return this.GetConfig().Value.PhantomItemId;
	}

	// Token: 0x06007C3D RID: 31805 RVA: 0x001A3E6F File Offset: 0x001A206F
	public void Init(AbyssLittleRole data)
	{
		this.Id = data.Id;
		this.Level = 1;
	}

	// Token: 0x06007C3E RID: 31806 RVA: 0x001A3E88 File Offset: 0x001A2088
	public void Phrase(AbyssRoleInfo data, int[] itemIdList)
	{
		this.Id = data.Id;
		this.Level = data.Level;
		this.EquipItems = data.EquipItems.ToArray<int>();
		this.Lock = false;
		this.PhraseSlotData(data.EquipItems.ToArray<int>(), itemIdList);
	}

	// Token: 0x06007C3F RID: 31807 RVA: 0x001A3ED8 File Offset: 0x001A20D8
	public void PhraseSlotData(int[] incIdList, int[] itemIdList)
	{
		if (incIdList.Length < 9)
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

	// Token: 0x06007C40 RID: 31808 RVA: 0x001A3F64 File Offset: 0x001A2164
	public int GetQuality()
	{
		return this.GetConfig().Value.Quality;
	}

	// Token: 0x06007C41 RID: 31809 RVA: 0x001A3F88 File Offset: 0x001A2188
	public string GetQualitySpritePath()
	{
		return DangoAbyssConfig.Instance.GetAbyssQualityById(this.GetQuality()).Value.Bg;
	}

	// Token: 0x06007C42 RID: 31810 RVA: 0x001A3FB8 File Offset: 0x001A21B8
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

	// Token: 0x06007C43 RID: 31811 RVA: 0x001A4040 File Offset: 0x001A2240
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

	// Token: 0x06007C44 RID: 31812 RVA: 0x001A4060 File Offset: 0x001A2260
	public int GetCurrentPluginSlotNum()
	{
		return this.GetLevelConfig().Value.PluginNum;
	}

	// Token: 0x06007C45 RID: 31813 RVA: 0x001A4084 File Offset: 0x001A2284
	public string GetName()
	{
		return this.GetConfig().Value.Name;
	}

	// Token: 0x06007C46 RID: 31814 RVA: 0x001A40A8 File Offset: 0x001A22A8
	public AbyssCastDesc GetCastTypeDesc()
	{
		return DangoAbyssConfig.Instance.GetDangoCastDescById(this.GetConfig().Value.CastType).Value;
	}

	// Token: 0x06007C47 RID: 31815 RVA: 0x001A40E0 File Offset: 0x001A22E0
	public string GetSkillCastTypeName()
	{
		return this.GetCastTypeDesc().Name;
	}

	// Token: 0x06007C48 RID: 31816 RVA: 0x001A40FC File Offset: 0x001A22FC
	public string GetSkillCastTypeIconPath()
	{
		return this.GetCastTypeDesc().Icon;
	}

	// Token: 0x06007C49 RID: 31817 RVA: 0x001A4117 File Offset: 0x001A2317
	public AbyssLittleRole? GetConfig()
	{
		return DangoAbyssConfig.Instance.GetDangoRoleById(this.Id);
	}

	// Token: 0x06007C4A RID: 31818 RVA: 0x001A412C File Offset: 0x001A232C
	private int GetLevelGroupId()
	{
		return this.GetConfig().Value.LevelGroupId;
	}

	// Token: 0x06007C4B RID: 31819 RVA: 0x001A414F File Offset: 0x001A234F
	[NullableContext(2)]
	public IReadOnlyList<AbyssRoleLevel> GetLevelGroupConfigs()
	{
		return DangoAbyssConfig.Instance.GetDangoLevelConfigByGroupId(this.GetLevelGroupId());
	}

	// Token: 0x06007C4C RID: 31820 RVA: 0x001A4164 File Offset: 0x001A2364
	public int GetSkillId()
	{
		return PhantomBattleModel.Instance.GetPhantomInstanceByItemId(this.GetConfig().Value.PhantomItemId).GetPhantomSkillId().Value;
	}

	// Token: 0x06007C4D RID: 31821 RVA: 0x001A419E File Offset: 0x001A239E
	public PhantomSkill? GetSkillConfig()
	{
		return PhantomBattleConfig.Instance.GetPhantomSkillBySkillId(this.GetSkillId());
	}

	// Token: 0x06007C4E RID: 31822 RVA: 0x001A41B0 File Offset: 0x001A23B0
	public string GetSkillDesc()
	{
		PhantomSkill? phantomSkill;
		return ((this.GetSkillConfig() != null) ? phantomSkill.GetValueOrDefault().DescriptionEx : null) ?? string.Empty;
	}

	// Token: 0x06007C4F RID: 31823 RVA: 0x001A41E8 File Offset: 0x001A23E8
	public string[] GetSkillDescAddition()
	{
		int skillId = this.GetSkillId();
		int qualityId = PhantomBattleModel.Instance.GetPhantomInstanceByItemId(this.GetConfig().Value.PhantomItemId).PhantomItem.Value.QualityId;
		return PhantomBattleConfig.Instance.GetPhantomSkillDescExBySkillIdAndQuality(skillId, qualityId);
	}

	// Token: 0x06007C50 RID: 31824 RVA: 0x001A4240 File Offset: 0x001A2440
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

	// Token: 0x06007C51 RID: 31825 RVA: 0x001A42BC File Offset: 0x001A24BC
	public AbyssRoleLevel? GetLevelConfig()
	{
		return DangoAbyssConfig.Instance.GetDangoLevelConfigByLevelAndGroupId(this.Level, this.GetLevelGroupId());
	}

	// Token: 0x06007C52 RID: 31826 RVA: 0x001A42D4 File Offset: 0x001A24D4
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

	// Token: 0x06007C53 RID: 31827 RVA: 0x001A4394 File Offset: 0x001A2594
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

	// Token: 0x06007C54 RID: 31828 RVA: 0x001A43CB File Offset: 0x001A25CB
	public int GetMaxLevel()
	{
		return DangoAbyssConfig.Instance.GetDangoLevelConfigByGroupId(this.GetLevelGroupId()).Count;
	}

	// Token: 0x06007C55 RID: 31829 RVA: 0x001A43E4 File Offset: 0x001A25E4
	public bool GetIfMaxLevel()
	{
		IReadOnlyList<AbyssRoleLevel> dangoLevelConfigByGroupId = DangoAbyssConfig.Instance.GetDangoLevelConfigByGroupId(this.GetLevelGroupId());
		return this.Level >= dangoLevelConfigByGroupId.Count;
	}

	// Token: 0x06007C56 RID: 31830 RVA: 0x001A4414 File Offset: 0x001A2614
	public bool GetIfCanLevelUp()
	{
		bool ifLock = this.GetIfLock();
		bool ifMaxLevel = this.GetIfMaxLevel();
		return !ifLock && !ifMaxLevel;
	}

	// Token: 0x06007C57 RID: 31831 RVA: 0x001A4438 File Offset: 0x001A2638
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

	// Token: 0x06007C58 RID: 31832 RVA: 0x001A462C File Offset: 0x001A282C
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

	// Token: 0x06007C59 RID: 31833 RVA: 0x001A46C4 File Offset: 0x001A28C4
	private string GetPropValueString(int indexId, double value, bool isRatio)
	{
		double propRatioValue = TipsDataTool.GetPropRatioValue(value, isRatio);
		return AttributeModel.Instance.GetFormatAttributeValueString(indexId, propRatioValue, isRatio);
	}

	// Token: 0x06007C5A RID: 31834 RVA: 0x001A46E8 File Offset: 0x001A28E8
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

	// Token: 0x06007C5B RID: 31835 RVA: 0x001A4868 File Offset: 0x001A2A68
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
			AttributeInfo = levelUpViewAttributeInfo.ToList<IAttributeInfo>()
		};
	}

	// Token: 0x040038D7 RID: 14551
	private int Id;

	// Token: 0x040038D8 RID: 14552
	private int Level;

	// Token: 0x040038D9 RID: 14553
	private int[] EquipItems = Array.Empty<int>();

	// Token: 0x040038DA RID: 14554
	private bool Lock = true;

	// Token: 0x040038DB RID: 14555
	private readonly Dictionary<int, AbyssDangoRoleSlotData> PluginSlotDataMap = new Dictionary<int, AbyssDangoRoleSlotData>();
}
