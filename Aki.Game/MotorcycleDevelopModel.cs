using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using Google.Protobuf.Collections;

// Token: 0x02001748 RID: 5960
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MotorcycleDevelopModel : ModelBase
{
	// Token: 0x0600E734 RID: 59188 RVA: 0x0043AFFC File Offset: 0x004391FC
	public void UpdateMotorInfo(MotorPb data)
	{
		this.CurLevel = data.MotorLevel;
		this.CurExp = data.MotorExp;
		this.CurRewardedMaxLv = data.MotorRewardedLvMax;
		this.DailyLimitExp = data.MotorExpLimitGainDaily;
		this.DailyLimitMaxExp = data.MotorExpMonsterDropDailyLimit;
		this.CurTreeType = data.TreeInUse;
		this.IsFirstDailyExpLimit = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.MotorDevelopIsFirstDailyExpLimit, false);
		if (this.LastLevel == -1)
		{
			this.LastLevel = this.CurLevel;
		}
		if (this.LastExp == -1)
		{
			this.LastExp = this.CurExp;
		}
		this.UpdateTechTree(data.UnlockedTree);
		this.UpdateAllTreeTask(data.TaskTrees);
		this.UpdateMotorLevelEffect();
	}

	// Token: 0x0600E735 RID: 59189 RVA: 0x0043B0AA File Offset: 0x004392AA
	protected override bool OnClear()
	{
		this.RemoveSwitchTechTreeLockTimer();
		return true;
	}

	// Token: 0x0600E736 RID: 59190 RVA: 0x0043B0B4 File Offset: 0x004392B4
	public List<UiDynamicTab> GetMotorTabList()
	{
		List<UiDynamicTab> viewTabList = DynamicTabConfig.Instance.GetViewTabList(EUiViewName.MotorcycleRootView);
		int count = viewTabList.Count;
		List<UiDynamicTab> list = new List<UiDynamicTab>();
		for (int i = 0; i < count; i++)
		{
			UiDynamicTab item = viewTabList[i];
			if (FunctionModel.Instance.IsOpen(item.FunctionId))
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x0600E737 RID: 59191 RVA: 0x0043B114 File Offset: 0x00439314
	public int GetLastLevel()
	{
		return this.LastLevel;
	}

	// Token: 0x0600E738 RID: 59192 RVA: 0x0043B11C File Offset: 0x0043931C
	public int GetLastExp()
	{
		return this.LastExp;
	}

	// Token: 0x0600E739 RID: 59193 RVA: 0x0043B124 File Offset: 0x00439324
	public int GetCurLevel()
	{
		return this.CurLevel;
	}

	// Token: 0x0600E73A RID: 59194 RVA: 0x0043B12C File Offset: 0x0043932C
	public int GetCurExp()
	{
		return this.CurExp;
	}

	// Token: 0x0600E73B RID: 59195 RVA: 0x0043B134 File Offset: 0x00439334
	public int GetCurRewardedMaxLv()
	{
		return this.CurRewardedMaxLv;
	}

	// Token: 0x0600E73C RID: 59196 RVA: 0x0043B13C File Offset: 0x0043933C
	public float GetAttrValueByType(int attrType, int level)
	{
		float result = 0f;
		int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
		MotorLvl? motorLevelConfig = MotorConfig.Instance.GetMotorLevelConfig(level);
		if (motorLevelConfig != null)
		{
			int? worldLv2Attack = motorLevelConfig.Value.GetWorldLv2Attack(curWorldLevel);
			int? worldLv2MotorShield = motorLevelConfig.Value.GetWorldLv2MotorShield(curWorldLevel);
			switch (attrType)
			{
			case 1:
				result = (float)motorLevelConfig.Value.Speed;
				break;
			case 2:
				result = (float)motorLevelConfig.Value.NitrogenValue;
				break;
			case 3:
				result = (float)((worldLv2Attack != null) ? worldLv2Attack.Value : 0);
				break;
			case 4:
				result = (float)((worldLv2MotorShield != null) ? worldLv2MotorShield.Value : 0);
				break;
			case 5:
				result = (float)motorLevelConfig.Value.NitrogenSpeedValue;
				break;
			case 6:
				result = (float)motorLevelConfig.Value.NitrogenConsumeRate;
				break;
			case 7:
				result = (float)motorLevelConfig.Value.NitrogenRecoverRate;
				break;
			case 8:
				result = motorLevelConfig.Value.NitrogenRecoverCoolDown;
				break;
			case 9:
				result = (float)motorLevelConfig.Value.MotorInitialShieldRate;
				break;
			case 10:
				result = (float)motorLevelConfig.Value.MotorShieldRecoverRate;
				break;
			case 11:
				result = motorLevelConfig.Value.MotorShieldCoolDown;
				break;
			case 12:
				result = (float)motorLevelConfig.Value.SoaringEnergy;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600E73D RID: 59197 RVA: 0x0043B2D8 File Offset: 0x004394D8
	public int GetNextLevelExp()
	{
		IReadOnlyList<MotorLvl> allMotorLevelList = MotorConfig.Instance.GetAllMotorLevelList();
		int level = Math.Min(this.CurLevel + 1, allMotorLevelList.Count);
		int result = 0;
		MotorLvl? motorLevelConfig = MotorConfig.Instance.GetMotorLevelConfig(level);
		if (motorLevelConfig != null)
		{
			result = motorLevelConfig.Value.Exp;
		}
		return result;
	}

	// Token: 0x0600E73E RID: 59198 RVA: 0x0043B330 File Offset: 0x00439530
	public List<TItem> GetPreviewRewardByLevel(int level)
	{
		List<TItem> list = new List<TItem>();
		MotorLvl? motorLevelConfig = MotorConfig.Instance.GetMotorLevelConfig(level);
		if (motorLevelConfig != null)
		{
			list = this.GetPreviewReward(motorLevelConfig.Value.RewardId);
		}
		list.Sort(delegate(TItem a, TItem b)
		{
			int itemId = a.ItemData.ItemId;
			int itemId2 = b.ItemData.ItemId;
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(itemId2);
			int num = (itemConfigData != null) ? itemConfigData.QualityId : 0;
			int num2 = (itemConfigData2 != null) ? itemConfigData2.QualityId : 0;
			if (num != num2)
			{
				return num2 - num;
			}
			return itemId - itemId2;
		});
		return list;
	}

	// Token: 0x0600E73F RID: 59199 RVA: 0x0043B394 File Offset: 0x00439594
	public List<TItem> GetAllPreviewReward()
	{
		List<TItem> list = new List<TItem>();
		IEnumerable<MotorLvl> allMotorLevelList = MotorConfig.Instance.GetAllMotorLevelList();
		Dictionary<int, TItem> dictionary = new Dictionary<int, TItem>();
		foreach (MotorLvl motorLvl in allMotorLevelList)
		{
			int rewardId = motorLvl.RewardId;
			if (rewardId != 0)
			{
				DropPackage? dropPackage;
				Dictionary<int, int> dictionary2 = (CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(rewardId) != null) ? dropPackage.GetValueOrDefault().DropPreview() : null;
				if (dictionary2 != null)
				{
					foreach (KeyValuePair<int, int> keyValuePair in dictionary2)
					{
						int key = keyValuePair.Key;
						int value = keyValuePair.Value;
						TItem titem;
						if (!dictionary.TryGetValue(key, out titem))
						{
							titem = new TItem
							{
								ItemData = new InventoryDefine.GetItemData(key, 0),
								Count = value
							};
							dictionary[key] = titem;
						}
						else
						{
							titem.Count += value;
							dictionary[key] = titem;
						}
					}
				}
			}
		}
		foreach (KeyValuePair<int, TItem> keyValuePair2 in dictionary)
		{
			list.Add(keyValuePair2.Value);
		}
		list.Sort(delegate(TItem a, TItem b)
		{
			int itemId = a.ItemData.ItemId;
			int itemId2 = b.ItemData.ItemId;
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(itemId2);
			int num = (itemConfigData != null) ? itemConfigData.QualityId : 0;
			int num2 = (itemConfigData2 != null) ? itemConfigData2.QualityId : 0;
			if (num != num2)
			{
				return num2 - num;
			}
			return itemId - itemId2;
		});
		return list;
	}

	// Token: 0x0600E740 RID: 59200 RVA: 0x0043B540 File Offset: 0x00439740
	public List<TItem> GetPreviewReward(int dropId)
	{
		List<TItem> list = new List<TItem>();
		if (dropId == 0)
		{
			return list;
		}
		DropPackage? dropPackage;
		Dictionary<int, int> dictionary = (CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(dropId) != null) ? dropPackage.GetValueOrDefault().DropPreview() : null;
		if (dictionary == null)
		{
			return list;
		}
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			TItem item = new TItem
			{
				ItemData = new InventoryDefine.GetItemData(key, 0),
				Count = value
			};
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600E741 RID: 59201 RVA: 0x0043B600 File Offset: 0x00439800
	public bool IsDailyExpToLimit()
	{
		return this.DailyLimitMaxExp > 0 && this.DailyLimitExp >= this.DailyLimitMaxExp;
	}

	// Token: 0x0600E742 RID: 59202 RVA: 0x0043B61E File Offset: 0x0043981E
	public void UpdateMotorExpAndLevel(MotorExpAddNotify data)
	{
		this.CurExp = data.CurExp;
		this.CurLevel = data.CurLevel;
		this.DailyLimitExp = data.MotorExpLimitGainDaily;
		this.DailyLimitMaxExp = data.MotorExpMonsterDropDailyLimit;
		this.UpdateMotorLevelEffect();
	}

	// Token: 0x0600E743 RID: 59203 RVA: 0x0043B656 File Offset: 0x00439856
	public void UpdateMotorRewardedMaxLevel(MotorLevelOneKeyRewardResponse data)
	{
		this.CurRewardedMaxLv = data.MotorRewardedLvMax;
	}

	// Token: 0x0600E744 RID: 59204 RVA: 0x0043B664 File Offset: 0x00439864
	public void CheckMotorExpChange()
	{
		if (this.LastLevel < this.CurLevel)
		{
			this.SetLevelUp(this.LastLevel, this.CurLevel, this.CurExp, this.LastExp);
			this.LastLevel = this.CurLevel;
		}
		this.LastExp = this.CurExp;
		if (this.DailyLimitExp == 0)
		{
			this.IsFirstDailyExpLimit = false;
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.MotorDevelopIsFirstDailyExpLimit, false);
		}
		if (this.IsDailyExpToLimit() && !this.IsFirstDailyExpLimit)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("MotorBike_ExpLimit_Tips", Array.Empty<object>());
			this.IsFirstDailyExpLimit = true;
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.MotorDevelopIsFirstDailyExpLimit, true);
		}
	}

	// Token: 0x0600E745 RID: 59205 RVA: 0x0043B708 File Offset: 0x00439908
	public void SetExpChange(int currentLevel, int currentExp, int lastExp, int maxExp, int differenceExp)
	{
		LevelUpViewViedData data = new LevelUpViewViedData
		{
			AddExp = true,
			PreLevel = currentLevel,
			PreExp = lastExp,
			CurLevel = currentLevel,
			CurExp = currentExp
		};
		this.TryOpenLevelUpView(data);
	}

	// Token: 0x0600E746 RID: 59206 RVA: 0x0043B748 File Offset: 0x00439948
	public void SetLevelUp(int lastLevel, int currentLevel, int currentExp, int lastExp)
	{
		LevelUpViewViedData data = new LevelUpViewViedData
		{
			AddExp = true,
			PreLevel = lastLevel,
			PreExp = lastExp,
			CurLevel = currentLevel,
			CurExp = currentExp
		};
		this.TryOpenLevelUpView(data);
	}

	// Token: 0x0600E747 RID: 59207 RVA: 0x0043B788 File Offset: 0x00439988
	private void RefreshCacheData(ILevelUpViewViedData data)
	{
		if (this.CacheLvUpData == null)
		{
			return;
		}
		if (data.AddExp)
		{
			this.CacheLvUpData.AddExp = data.AddExp;
		}
		if (data.PreLevel < this.CacheLvUpData.PreLevel)
		{
			this.CacheLvUpData.PreLevel = data.PreLevel;
			this.CacheLvUpData.PreExp = data.PreExp;
		}
		else if (data.PreLevel == this.CacheLvUpData.PreLevel && data.PreExp <= this.CacheLvUpData.PreExp)
		{
			this.CacheLvUpData.PreExp = data.PreExp;
		}
		if (data.CurLevel > this.CacheLvUpData.CurLevel)
		{
			this.CacheLvUpData.CurLevel = data.CurLevel;
			this.CacheLvUpData.CurExp = data.CurExp;
			return;
		}
		if (data.CurLevel == this.CacheLvUpData.CurLevel && data.CurExp >= this.CacheLvUpData.CurExp)
		{
			this.CacheLvUpData.CurExp = data.CurExp;
		}
	}

	// Token: 0x0600E748 RID: 59208 RVA: 0x0043B894 File Offset: 0x00439A94
	private void TryOpenLevelUpView(ILevelUpViewViedData data)
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.MotorcycleLevelUpView) && this.CacheLvUpData != null)
		{
			this.RefreshCacheData(data);
			return;
		}
		this.CacheLvUpData = data;
		if (UiManager.Instance.GetViewByName(EUiViewName.MotorcycleLevelUpView) == null)
		{
			UiManager.Instance.OpenView(EUiViewName.MotorcycleLevelUpView, this.CacheLvUpData, null);
		}
	}

	// Token: 0x0600E749 RID: 59209 RVA: 0x0043B8F0 File Offset: 0x00439AF0
	public ILevelUpViewViedData GetCacheData()
	{
		return this.CacheLvUpData;
	}

	// Token: 0x0600E74A RID: 59210 RVA: 0x0043B8F8 File Offset: 0x00439AF8
	public void ClearCacheData()
	{
		this.CacheLvUpData = null;
	}

	// Token: 0x0600E74B RID: 59211 RVA: 0x0043B904 File Offset: 0x00439B04
	public void UpdateMotorLevelEffect()
	{
		MotorLvl? motorLevelConfig = MotorConfig.Instance.GetMotorLevelConfig(this.CurLevel);
		if (motorLevelConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.TZQ;
			string message = "无效的等级";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Level", this.CurLevel);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		FormationAttributeController.Instance.AddSpeedModifier(this.ModifierHandle, EFormationAttributeId.MotorcycleStrength, EModifierType.Override, (float)motorLevelConfig.Value.NitrogenRecoverRate, 0);
	}

	// Token: 0x0600E74C RID: 59212 RVA: 0x0043B984 File Offset: 0x00439B84
	public bool RedDotHasLevelUpReward()
	{
		return this.CurRewardedMaxLv < this.CurLevel;
	}

	// Token: 0x0600E74D RID: 59213 RVA: 0x0043B994 File Offset: 0x00439B94
	private void InitTechNodes()
	{
		if (this.TechNodeMap.Count > 0)
		{
			return;
		}
		foreach (int treeType in MotorConfig.Instance.GetAllMotorTreeIds())
		{
			foreach (MotorTech motorTech in MotorConfig.Instance.GetMotorTechConfigList(treeType))
			{
				MotorTechTreeNode value = new MotorTechTreeNode(motorTech.Id, motorTech.TreeType, motorTech.PreNode());
				this.TechNodeMap[motorTech.Id] = value;
			}
		}
	}

	// Token: 0x0600E74E RID: 59214 RVA: 0x0043BA3C File Offset: 0x00439C3C
	public void UpdateCurTreeType(int treeType)
	{
		this.CurTreeType = treeType;
	}

	// Token: 0x0600E74F RID: 59215 RVA: 0x0043BA45 File Offset: 0x00439C45
	public void UpdateSelectedTreeType(int treeType)
	{
		this.SelectedTreeType = treeType;
	}

	// Token: 0x0600E750 RID: 59216 RVA: 0x0043BA50 File Offset: 0x00439C50
	public void UpdateDamgeIdToSkillLevel(int nodeId, int preLevel, int newLevel)
	{
		if (preLevel == newLevel)
		{
			return;
		}
		if (preLevel > 0)
		{
			MotorEffect? motorEffect = this.GetnodeEffectConfig(nodeId, preLevel);
			if (motorEffect != null)
			{
				foreach (long key in motorEffect.Value.GetDamageIdListArray())
				{
					this.DamgeIdToSkillLevel.Remove(key);
				}
			}
		}
		if (newLevel > 0)
		{
			MotorEffect? motorEffect2 = this.GetnodeEffectConfig(nodeId, newLevel);
			if (motorEffect2 != null && motorEffect2.Value.DamageIdListLength > 0)
			{
				foreach (long num in motorEffect2.Value.GetDamageIdListArray())
				{
					if (this.DamgeIdToSkillLevel.ContainsKey(num))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Vehicle;
						ELogAuthor author = ELogAuthor.TZQ;
						string message = "重复的结算ID";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ID", num);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					else
					{
						this.DamgeIdToSkillLevel[num] = motorEffect2.Value.SkillLevel;
					}
				}
			}
		}
	}

	// Token: 0x0600E751 RID: 59217 RVA: 0x0043BB60 File Offset: 0x00439D60
	public void UpdateTechNodeList(MotorTechPb[] data)
	{
		foreach (MotorTechPb motorTechPb in data)
		{
			MotorTechTreeNode motorTechTreeNode;
			if (this.TechNodeMap.TryGetValue(motorTechPb.Id, out motorTechTreeNode))
			{
				this.UpdateDamgeIdToSkillLevel(motorTechPb.Id, motorTechTreeNode.NodeLevel, motorTechPb.Level);
				motorTechTreeNode.NodeLevel = motorTechPb.Level;
				motorTechTreeNode.CurrentValue = motorTechPb.Current;
				motorTechTreeNode.TargetValue = motorTechPb.Target;
				if (motorTechPb.Unlock)
				{
					motorTechTreeNode.Status = ((motorTechPb.Level >= 1) ? EMotorTechTreeNodeStatus.Activated : EMotorTechTreeNodeStatus.CanUnlock);
				}
			}
		}
	}

	// Token: 0x0600E752 RID: 59218 RVA: 0x0043BBF0 File Offset: 0x00439DF0
	public void UpdateOneTechTree(MotorTechOneTreePb data)
	{
		RepeatedField<MotorTechPb> tech = data.Tech;
		this.InitTechNodes();
		foreach (MotorTechPb motorTechPb in tech)
		{
			MotorTechTreeNode motorTechTreeNode;
			if (this.TechNodeMap.TryGetValue(motorTechPb.Id, out motorTechTreeNode))
			{
				this.UpdateDamgeIdToSkillLevel(motorTechPb.Id, motorTechTreeNode.NodeLevel, motorTechPb.Level);
				motorTechTreeNode.NodeLevel = motorTechPb.Level;
				motorTechTreeNode.CurrentValue = motorTechPb.Current;
				motorTechTreeNode.TargetValue = motorTechPb.Target;
				if (motorTechPb.Unlock)
				{
					motorTechTreeNode.Status = ((motorTechPb.Level >= 1) ? EMotorTechTreeNodeStatus.Activated : EMotorTechTreeNodeStatus.CanUnlock);
				}
			}
		}
	}

	// Token: 0x0600E753 RID: 59219 RVA: 0x0043BCA8 File Offset: 0x00439EA8
	public void UpdateTechTree(IReadOnlyList<MotorTechOneTreePb> dataList)
	{
		foreach (MotorTechOneTreePb motorTechOneTreePb in dataList)
		{
			this.UnlockTechTree(motorTechOneTreePb.TreeId);
			this.UpdateOneTechTree(motorTechOneTreePb);
		}
	}

	// Token: 0x0600E754 RID: 59220 RVA: 0x0043BCFC File Offset: 0x00439EFC
	public void UpdateTechTreeNewUnlocked(int treeType, bool isNew)
	{
		ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.MotorDevelopNewUnlockTree) as ServerStorageSet;
		if (isNew)
		{
			serverStorageSet.Add(treeType);
			return;
		}
		serverStorageSet.Remove(treeType);
	}

	// Token: 0x0600E755 RID: 59221 RVA: 0x0043BD30 File Offset: 0x00439F30
	public void UnlockTechNode(IReadOnlyList<int> nodeIds)
	{
		foreach (int nodeId in nodeIds)
		{
			this.RefreshTechTreeNode(nodeId, EMotorTechTreeNodeStatus.CanUnlock);
		}
	}

	// Token: 0x0600E756 RID: 59222 RVA: 0x0043BD7C File Offset: 0x00439F7C
	public void UnlockTechTree(int treeType)
	{
		if (!this.UnlockTreeTypeList.Contains(treeType))
		{
			this.UnlockTreeTypeList.Add(treeType);
		}
		this.UnlockTreeTypeList.Sort(delegate(int a, int b)
		{
			MotorTechTree? motorTechTreeConfig = MotorConfig.Instance.GetMotorTechTreeConfig(a);
			MotorTechTree? motorTechTreeConfig2 = MotorConfig.Instance.GetMotorTechTreeConfig(b);
			int num = (motorTechTreeConfig != null) ? motorTechTreeConfig.Value.Order : 0;
			int num2 = (motorTechTreeConfig2 != null) ? motorTechTreeConfig2.Value.Order : 0;
			return num - num2;
		});
	}

	// Token: 0x0600E757 RID: 59223 RVA: 0x0043BDD0 File Offset: 0x00439FD0
	public int[] GetCommonTechNodeIdList(int treeType)
	{
		List<MotorTech> list = new List<MotorTech>();
		List<int> list2 = new List<int>();
		foreach (MotorTech item in MotorConfig.Instance.GetMotorTechConfigList(treeType))
		{
			if (item.Type == 0)
			{
				list.Add(item);
			}
		}
		list.Sort((MotorTech a, MotorTech b) => a.GeneralNodeSortOrder - b.GeneralNodeSortOrder);
		foreach (MotorTech motorTech in list)
		{
			list2.Add(motorTech.Id);
		}
		return list2.ToArray();
	}

	// Token: 0x0600E758 RID: 59224 RVA: 0x0043BEA8 File Offset: 0x0043A0A8
	public int FindTechNodeIdByCoord(int[] coord, int treeType)
	{
		int result = -1;
		foreach (MotorTech motorTech in MotorConfig.Instance.GetMotorTechConfigList(treeType))
		{
			int[] exclusiveNodeSortOrderArray = motorTech.GetExclusiveNodeSortOrderArray();
			if (coord[0] == exclusiveNodeSortOrderArray[0] && coord[1] == exclusiveNodeSortOrderArray[1])
			{
				result = motorTech.Id;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600E759 RID: 59225 RVA: 0x0043BF18 File Offset: 0x0043A118
	public int? GetSkillLevelByDamageId(long damageId)
	{
		int value;
		if (!this.DamgeIdToSkillLevel.TryGetValue(damageId, out value))
		{
			return null;
		}
		return new int?(value);
	}

	// Token: 0x0600E75A RID: 59226 RVA: 0x0043BF45 File Offset: 0x0043A145
	public int GetCurTreeType()
	{
		return this.CurTreeType;
	}

	// Token: 0x0600E75B RID: 59227 RVA: 0x0043BF4D File Offset: 0x0043A14D
	public int GetSelectedTreeType()
	{
		return this.SelectedTreeType;
	}

	// Token: 0x0600E75C RID: 59228 RVA: 0x0043BF55 File Offset: 0x0043A155
	public List<int> GetActivatedTreeTypeList()
	{
		return this.UnlockTreeTypeList;
	}

	// Token: 0x0600E75D RID: 59229 RVA: 0x0043BF60 File Offset: 0x0043A160
	[NullableContext(2)]
	public MotorTechTreeNode GetTechNodeById(int nodeId)
	{
		MotorTechTreeNode result;
		if (!this.TechNodeMap.TryGetValue(nodeId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0600E75E RID: 59230 RVA: 0x0043BF80 File Offset: 0x0043A180
	public List<IMotorTechNodeListData> GetExclusiveNodeParamList(int treeType)
	{
		List<IMotorTechNodeListData> list = new List<IMotorTechNodeListData>();
		IEnumerable<MotorTech> motorTechConfigList = MotorConfig.Instance.GetMotorTechConfigList(treeType);
		List<int[]> list2 = new List<int[]>();
		foreach (MotorTech motorTech in motorTechConfigList)
		{
			if (motorTech.Type == 1)
			{
				int[] exclusiveNodeSortOrderArray = motorTech.GetExclusiveNodeSortOrderArray();
				list2.Add(exclusiveNodeSortOrderArray);
			}
		}
		Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
		foreach (int[] array in list2)
		{
			int num = array[0];
			int item = array[1];
			if (num > 0)
			{
				List<int> list3;
				if (!dictionary.TryGetValue(num, out list3))
				{
					list3 = new List<int>();
					dictionary[num] = list3;
				}
				if (!list3.Contains(item))
				{
					list3.Add(item);
				}
				list3.Sort((int a, int b) => a - b);
			}
		}
		foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
		{
			int key = keyValuePair.Key;
			List<int> value = keyValuePair.Value;
			List<int> list4 = new List<int>();
			List<int> list5 = new List<int>();
			foreach (int num2 in value)
			{
				if (num2 > 0)
				{
					list4.Add(this.FindTechNodeIdByCoord(new int[]
					{
						key,
						num2
					}, treeType));
				}
				else if (num2 < 0)
				{
					list5.Add(this.FindTechNodeIdByCoord(new int[]
					{
						key,
						num2
					}, treeType));
				}
			}
			int[] array2 = new int[2];
			array2[0] = key;
			int middleId = this.FindTechNodeIdByCoord(array2, treeType);
			MotorTechNodeListData item2 = new MotorTechNodeListData
			{
				TopIds = list4.ToArray(),
				BottomIds = list5.ToArray(),
				MiddleId = middleId
			};
			list.Add(item2);
		}
		return list;
	}

	// Token: 0x0600E75F RID: 59231 RVA: 0x0043C1B8 File Offset: 0x0043A3B8
	public void RefreshTechTreeNode(int nodeId, EMotorTechTreeNodeStatus status)
	{
		MotorTechTreeNode techNodeById = this.GetTechNodeById(nodeId);
		if (techNodeById != null)
		{
			techNodeById.Status = status;
		}
	}

	// Token: 0x0600E760 RID: 59232 RVA: 0x0043C1D8 File Offset: 0x0043A3D8
	public bool IsLinkTimeNodeActivated()
	{
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("MotorTechLinkTimeNodeId").GetValueOrDefault();
		MotorTechTreeNode techNodeById = this.GetTechNodeById(valueOrDefault);
		return techNodeById != null && techNodeById.Status == EMotorTechTreeNodeStatus.Activated;
	}

	// Token: 0x0600E761 RID: 59233 RVA: 0x0043C210 File Offset: 0x0043A410
	public bool IsPreNodeActivated(MotorTechTreeNode node)
	{
		bool result = false;
		if (node.PreNodeIds == null || node.PreNodeIds.Length == 0)
		{
			result = true;
		}
		foreach (int num in node.PreNodeIds)
		{
			if (num == 0)
			{
				result = true;
				break;
			}
			MotorTechTreeNode techNodeById = this.GetTechNodeById(num);
			if (techNodeById != null && techNodeById.Status == EMotorTechTreeNodeStatus.Activated)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600E762 RID: 59234 RVA: 0x0043C270 File Offset: 0x0043A470
	public bool IsAllNodeMaxLevel(int treeType)
	{
		foreach (MotorTechTreeNode motorTechTreeNode in this.TechNodeMap.Values)
		{
			if (motorTechTreeNode.TreeType == treeType)
			{
				MotorTech? motorTechConfig = MotorConfig.Instance.GetMotorTechConfig(motorTechTreeNode.NodeId);
				if (motorTechConfig == null)
				{
					return false;
				}
				if (motorTechTreeNode.NodeLevel < motorTechConfig.Value.GetTechLvArray().Length)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600E763 RID: 59235 RVA: 0x0043C30C File Offset: 0x0043A50C
	public MotorEffect? GetnodeEffectConfig(int nodeId, int nodeLevel)
	{
		MotorTech? motorTechConfig = MotorConfig.Instance.GetMotorTechConfig(nodeId);
		if (motorTechConfig == null || nodeLevel <= 0)
		{
			return null;
		}
		int id = motorTechConfig.Value.GetTechLvArray()[nodeLevel - 1];
		MotorTechLv? motorTechLvConfig = MotorConfig.Instance.GetMotorTechLvConfig(id);
		if (motorTechLvConfig == null)
		{
			return null;
		}
		return MotorConfig.Instance.GetMotorEffectConfig(motorTechLvConfig.Value.Effect);
	}

	// Token: 0x0600E764 RID: 59236 RVA: 0x0043C38C File Offset: 0x0043A58C
	public bool CanUpgradeNode(MotorTechTreeNode node)
	{
		MotorTechTree? motorTechTreeConfig = MotorConfig.Instance.GetMotorTechTreeConfig(node.TreeType);
		if (motorTechTreeConfig == null)
		{
			return false;
		}
		MotorTech? motorTechConfig = MotorConfig.Instance.GetMotorTechConfig(node.NodeId);
		if (motorTechConfig == null)
		{
			return false;
		}
		int num = (node.NodeLevel == motorTechConfig.Value.GetTechLvArray().Length) ? node.NodeLevel : (node.NodeLevel + 1);
		int id = motorTechConfig.Value.GetTechLvArray()[num - 1];
		MotorTechLv? motorTechLvConfig = MotorConfig.Instance.GetMotorTechLvConfig(id);
		if (motorTechLvConfig != null)
		{
			int consume = motorTechLvConfig.Value.Consume;
			return InventoryModel.Instance.GetItemCountByConfigId(motorTechTreeConfig.Value.TpItemId, 0) - motorTechLvConfig.Value.Consume >= 0;
		}
		return false;
	}

	// Token: 0x0600E765 RID: 59237 RVA: 0x0043C470 File Offset: 0x0043A670
	public bool RedDotHasAnyNewTechTree()
	{
		foreach (int treeType in this.UnlockTreeTypeList)
		{
			if (this.RedDotHasNewTechTree(treeType))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600E766 RID: 59238 RVA: 0x0043C4CC File Offset: 0x0043A6CC
	public bool RedDotHasNewTechTree(int treeType)
	{
		return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.MotorDevelopNewUnlockTree) as ServerStorageSet).Has(treeType);
	}

	// Token: 0x0600E767 RID: 59239 RVA: 0x0043C4E8 File Offset: 0x0043A6E8
	public bool RedDotHasUpgradableTechNode(int? treeType)
	{
		foreach (MotorTechTreeNode motorTechTreeNode in this.TechNodeMap.Values)
		{
			bool flag = treeType == null || motorTechTreeNode.TreeType == treeType.Value;
			MotorTech? motorTechConfig = MotorConfig.Instance.GetMotorTechConfig(motorTechTreeNode.NodeId);
			bool flag2 = motorTechTreeNode.NodeLevel >= motorTechConfig.Value.GetTechLvArray().Length;
			bool flag3 = motorTechTreeNode.Status == EMotorTechTreeNodeStatus.Lock;
			if (flag && !flag2 && !flag3 && this.CanUpgradeNode(motorTechTreeNode))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600E768 RID: 59240 RVA: 0x0043C5AC File Offset: 0x0043A7AC
	public void UpdateOneTask(MotorTaskPb data)
	{
		MotorTechTaskNode motorTechTaskNode;
		if (!this.TaskNodeMap.TryGetValue(data.Id, out motorTechTaskNode))
		{
			MotorTask? motorTaskConfig = MotorConfig.Instance.GetMotorTaskConfig(data.Id);
			motorTechTaskNode = new MotorTechTaskNode();
			motorTechTaskNode.TaskId = motorTaskConfig.Value.Id;
			motorTechTaskNode.TreeType = motorTaskConfig.Value.TreeType;
			this.TaskNodeMap[data.Id] = motorTechTaskNode;
		}
		motorTechTaskNode.StartTime = MathUtils.Instance.LongToNumber(data.StartTime);
		motorTechTaskNode.EndTime = MathUtils.Instance.LongToNumber(data.EndTime);
		motorTechTaskNode.ProcessInfo.Current = data.Process.Current;
		motorTechTaskNode.ProcessInfo.Target = data.Process.Target;
		motorTechTaskNode.RewardInfo.WaitRewardCount = data.Reward.WaitReward;
		motorTechTaskNode.RewardInfo.RewardedCount = data.Reward.Rewarded;
		motorTechTaskNode.RewardInfo.MaxRewardCount = data.Reward.MaxReward;
		switch (data.Type)
		{
		case MotorTaskTypePb.Unknown:
			motorTechTaskNode.Type = EMotorTechTaskType.Unknown;
			return;
		case MotorTaskTypePb.Single:
			motorTechTaskNode.Type = EMotorTechTaskType.OnlyOnce;
			return;
		case MotorTaskTypePb.Limited:
			motorTechTaskNode.Type = EMotorTechTaskType.Limited;
			return;
		case MotorTaskTypePb.Cycle:
			motorTechTaskNode.Type = EMotorTechTaskType.Loop;
			return;
		default:
			return;
		}
	}

	// Token: 0x0600E769 RID: 59241 RVA: 0x0043C6F8 File Offset: 0x0043A8F8
	public void UpdateOneTreeTask(IReadOnlyList<MotorTaskPb> taskList)
	{
		foreach (MotorTaskPb data in taskList)
		{
			this.UpdateOneTask(data);
		}
	}

	// Token: 0x0600E76A RID: 59242 RVA: 0x0043C740 File Offset: 0x0043A940
	public void UpdateAllTreeTask(IReadOnlyList<MotorTaskTreePb> dataList)
	{
		foreach (MotorTaskTreePb motorTaskTreePb in dataList)
		{
			this.TaskRewardMap[motorTaskTreePb.TreeId] = motorTaskTreePb.TpRewarded;
			this.UpdateOneTreeTask(motorTaskTreePb.Tasks);
		}
	}

	// Token: 0x0600E76B RID: 59243 RVA: 0x0043C7A4 File Offset: 0x0043A9A4
	[NullableContext(2)]
	public MotorTechTaskNode GetTaskNodeInfo(int taskId)
	{
		MotorTechTaskNode result;
		if (!this.TaskNodeMap.TryGetValue(taskId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0600E76C RID: 59244 RVA: 0x0043C7C4 File Offset: 0x0043A9C4
	public List<MotorTechTaskNode> GetTaskListByTree(int treeType)
	{
		List<MotorTechTaskNode> list = new List<MotorTechTaskNode>();
		double serverTime = TimeUtil.Instance.GetServerTime();
		foreach (KeyValuePair<int, MotorTechTaskNode> keyValuePair in this.TaskNodeMap)
		{
			MotorTechTaskNode value = keyValuePair.Value;
			if (value.TreeType == treeType)
			{
				if (value.Type == EMotorTechTaskType.Limited)
				{
					if ((double)value.StartTime < serverTime && (double)value.EndTime > serverTime)
					{
						list.Add(value);
					}
				}
				else if (value.Type == EMotorTechTaskType.Loop)
				{
					if (value.RewardInfo.MaxRewardCount != 0 && value.RewardInfo.MaxRewardCount != -1)
					{
						list.Add(value);
					}
				}
				else
				{
					list.Add(value);
				}
			}
		}
		list.Sort(delegate(MotorTechTaskNode a, MotorTechTaskNode b)
		{
			int waitRewardCount = a.RewardInfo.WaitRewardCount;
			int waitRewardCount2 = b.RewardInfo.WaitRewardCount;
			if (waitRewardCount != waitRewardCount2)
			{
				return waitRewardCount2 - waitRewardCount;
			}
			int maxRewardCount = a.RewardInfo.MaxRewardCount;
			int maxRewardCount2 = b.RewardInfo.MaxRewardCount;
			int rewardedCount = a.RewardInfo.RewardedCount;
			int rewardedCount2 = b.RewardInfo.RewardedCount;
			int num = (maxRewardCount > 0 && rewardedCount >= maxRewardCount) ? 0 : 1;
			int num2 = (maxRewardCount2 > 0 && rewardedCount2 >= maxRewardCount2) ? 0 : 1;
			if (num != num2)
			{
				return num2 - num;
			}
			MotorTask? motorTaskConfig = MotorConfig.Instance.GetMotorTaskConfig(a.TaskId);
			MotorTask? motorTaskConfig2 = MotorConfig.Instance.GetMotorTaskConfig(b.TaskId);
			int num3 = (motorTaskConfig != null) ? motorTaskConfig.Value.SortOrder : 0;
			int num4 = (motorTaskConfig2 != null) ? motorTaskConfig2.Value.SortOrder : 0;
			return num3 - num4;
		});
		return list;
	}

	// Token: 0x0600E76D RID: 59245 RVA: 0x0043C8C0 File Offset: 0x0043AAC0
	public int[] GetWaitRewardTaskIds(int treeType)
	{
		List<int> list = new List<int>();
		foreach (MotorTechTaskNode motorTechTaskNode in this.GetTaskListByTree(treeType))
		{
			if (motorTechTaskNode.RewardInfo.WaitRewardCount > 0)
			{
				list.Add(motorTechTaskNode.TaskId);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600E76E RID: 59246 RVA: 0x0043C934 File Offset: 0x0043AB34
	public int GetCostPointByTree(int treeType)
	{
		int num = 0;
		foreach (MotorTech motorTech in MotorConfig.Instance.GetMotorTechConfigList(treeType))
		{
			MotorTechTreeNode techNodeById = this.GetTechNodeById(motorTech.Id);
			if (techNodeById != null)
			{
				for (int i = 0; i < motorTech.GetTechLvArray().Length; i++)
				{
					int id = motorTech.GetTechLvArray()[i];
					MotorTechLv? motorTechLvConfig = MotorConfig.Instance.GetMotorTechLvConfig(id);
					if (motorTechLvConfig != null && techNodeById.NodeLevel >= i + 1)
					{
						num += motorTechLvConfig.Value.Consume;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0600E76F RID: 59247 RVA: 0x0043C9F0 File Offset: 0x0043ABF0
	public int GetFreePointByTree(int treeType)
	{
		MotorTechTree? motorTechTreeConfig = MotorConfig.Instance.GetMotorTechTreeConfig(treeType);
		if (motorTechTreeConfig == null)
		{
			return 0;
		}
		return InventoryModel.Instance.GetItemCountByConfigId(motorTechTreeConfig.Value.TpItemId, 0);
	}

	// Token: 0x0600E770 RID: 59248 RVA: 0x0043CA30 File Offset: 0x0043AC30
	public int GetTotalPointByTree(int treeType)
	{
		int result = 0;
		MotorTechTree? motorTechTreeConfig = MotorConfig.Instance.GetMotorTechTreeConfig(treeType);
		if (motorTechTreeConfig != null)
		{
			result = motorTechTreeConfig.Value.TaskLimitPointNum;
		}
		return result;
	}

	// Token: 0x0600E771 RID: 59249 RVA: 0x0043CA68 File Offset: 0x0043AC68
	public bool IsOverLimitPointNum(int treeType)
	{
		int costPointByTree = this.GetCostPointByTree(treeType);
		int freePointByTree = this.GetFreePointByTree(treeType);
		int totalPointByTree = this.GetTotalPointByTree(treeType);
		return costPointByTree + freePointByTree >= totalPointByTree;
	}

	// Token: 0x0600E772 RID: 59250 RVA: 0x0043CA94 File Offset: 0x0043AC94
	public bool RedDotCanGetAnyTaskReward()
	{
		foreach (int value in this.GetActivatedTreeTypeList())
		{
			if (this.RedDotCanGetTaskReward(new int?(value)))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600E773 RID: 59251 RVA: 0x0043CAF8 File Offset: 0x0043ACF8
	public bool RedDotCanGetTaskReward(int? treeType)
	{
		if (treeType != null && this.IsOverLimitPointNum(treeType.Value))
		{
			return false;
		}
		foreach (MotorTechTaskNode motorTechTaskNode in this.TaskNodeMap.Values)
		{
			if ((treeType == null || motorTechTaskNode.TreeType == treeType.Value) && motorTechTaskNode.RewardInfo.WaitRewardCount > 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600E774 RID: 59252 RVA: 0x0043CB98 File Offset: 0x0043AD98
	public void StartSwitchTechTreeLockTimer(int duration)
	{
		this.RemoveSwitchTechTreeLockTimer();
		this.SwitchTechTreeLockTimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.RemoveSwitchTechTreeLockTimer();
		}, (float)(duration * 1000), null, null, true, 1f);
	}

	// Token: 0x0600E775 RID: 59253 RVA: 0x0043CBCC File Offset: 0x0043ADCC
	public void RemoveSwitchTechTreeLockTimer()
	{
		if (this.SwitchTechTreeLockTimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.SwitchTechTreeLockTimerId);
			this.SwitchTechTreeLockTimerId = null;
		}
	}

	// Token: 0x0600E776 RID: 59254 RVA: 0x0043CBEE File Offset: 0x0043ADEE
	public bool IsSwitchTechTreeTimeLocked()
	{
		return this.SwitchTechTreeLockTimerId != null;
	}

	// Token: 0x0600E777 RID: 59255 RVA: 0x0043CBFC File Offset: 0x0043ADFC
	public bool IsSwitchTechTreePlayerLocked()
	{
		BaseTagComponent component = SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<BaseTagComponent>();
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]) || component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_ForbiddenActionInFight_Text", Array.Empty<object>());
			return true;
		}
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]) || component.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中"]) || component.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.状态.空中状态"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_ForbiddenActionMidair_Text", Array.Empty<object>());
			return true;
		}
		return false;
	}

	// Token: 0x17001626 RID: 5670
	// (get) Token: 0x0600E778 RID: 59256 RVA: 0x0043CCC4 File Offset: 0x0043AEC4
	public static MotorcycleDevelopModel Instance
	{
		get
		{
			return MotorcycleDevelopModel._Instance;
		}
	}

	// Token: 0x0600E779 RID: 59257 RVA: 0x0043CCCB File Offset: 0x0043AECB
	public static MotorcycleDevelopModel GetOrCreateInstance()
	{
		if (MotorcycleDevelopModel._Instance == null)
		{
			MotorcycleDevelopModel.CreateInstance();
		}
		return MotorcycleDevelopModel._Instance;
	}

	// Token: 0x0600E77A RID: 59258 RVA: 0x0043CCDF File Offset: 0x0043AEDF
	public static bool CreateInstance()
	{
		if (MotorcycleDevelopModel._Instance != null)
		{
			return true;
		}
		MotorcycleDevelopModel._Instance = new MotorcycleDevelopModel();
		return true;
	}

	// Token: 0x0600E77B RID: 59259 RVA: 0x0043CCF5 File Offset: 0x0043AEF5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E77C RID: 59260 RVA: 0x0043CCF7 File Offset: 0x0043AEF7
	public static void ResetStaticDefaultValue()
	{
		MotorcycleDevelopModel._Instance = null;
	}

	// Token: 0x0600E77D RID: 59261 RVA: 0x0043CCFF File Offset: 0x0043AEFF
	static MotorcycleDevelopModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleDevelopModel.CreateStaticDefaultValue), new Action(MotorcycleDevelopModel.ResetStaticDefaultValue));
	}

	// Token: 0x040083F4 RID: 33780
	private int LastLevel = -1;

	// Token: 0x040083F5 RID: 33781
	private int LastExp = -1;

	// Token: 0x040083F6 RID: 33782
	private int DailyLimitExp;

	// Token: 0x040083F7 RID: 33783
	private int DailyLimitMaxExp;

	// Token: 0x040083F8 RID: 33784
	private bool IsFirstDailyExpLimit;

	// Token: 0x040083F9 RID: 33785
	private int CurLevel = 1;

	// Token: 0x040083FA RID: 33786
	private int CurExp;

	// Token: 0x040083FB RID: 33787
	private int CurRewardedMaxLv;

	// Token: 0x040083FC RID: 33788
	[Nullable(2)]
	private ILevelUpViewViedData CacheLvUpData;

	// Token: 0x040083FD RID: 33789
	private readonly string ModifierHandle = "MotorLevel";

	// Token: 0x040083FE RID: 33790
	private int CurTreeType;

	// Token: 0x040083FF RID: 33791
	private int SelectedTreeType;

	// Token: 0x04008400 RID: 33792
	private readonly List<int> UnlockTreeTypeList = new List<int>();

	// Token: 0x04008401 RID: 33793
	public Dictionary<int, MotorTechTreeNode> TechNodeMap = new Dictionary<int, MotorTechTreeNode>();

	// Token: 0x04008402 RID: 33794
	public Dictionary<long, int> DamgeIdToSkillLevel = new Dictionary<long, int>();

	// Token: 0x04008403 RID: 33795
	private readonly Dictionary<int, int> TaskRewardMap = new Dictionary<int, int>();

	// Token: 0x04008404 RID: 33796
	private readonly Dictionary<int, MotorTechTaskNode> TaskNodeMap = new Dictionary<int, MotorTechTaskNode>();

	// Token: 0x04008405 RID: 33797
	[Nullable(2)]
	private TimerHandle SwitchTechTreeLockTimerId;

	// Token: 0x04008406 RID: 33798
	[Nullable(2)]
	private static MotorcycleDevelopModel _Instance;
}
