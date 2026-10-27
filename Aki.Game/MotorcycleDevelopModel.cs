using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02002264 RID: 8804
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MotorcycleDevelopModel : ModelBase
{
	// Token: 0x0601129E RID: 70302 RVA: 0x0042E45C File Offset: 0x0042C65C
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
		this.UpdateTechTree(data.UnlockedTree.ToArray<MotorTechOneTreePb>());
		this.UpdateAllTreeTask(data.TaskTrees.ToArray<MotorTaskTreePb>());
		this.UpdateMotorLevelEffect();
	}

	// Token: 0x0601129F RID: 70303 RVA: 0x0042E514 File Offset: 0x0042C714
	protected override bool OnClear()
	{
		this.RemoveSwitchTechTreeLockTimer();
		return true;
	}

	// Token: 0x060112A0 RID: 70304 RVA: 0x0042E520 File Offset: 0x0042C720
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

	// Token: 0x060112A1 RID: 70305 RVA: 0x0042E580 File Offset: 0x0042C780
	public int GetLastLevel()
	{
		return this.LastLevel;
	}

	// Token: 0x060112A2 RID: 70306 RVA: 0x0042E588 File Offset: 0x0042C788
	public int GetLastExp()
	{
		return this.LastExp;
	}

	// Token: 0x060112A3 RID: 70307 RVA: 0x0042E590 File Offset: 0x0042C790
	public int GetCurLevel()
	{
		return this.CurLevel;
	}

	// Token: 0x060112A4 RID: 70308 RVA: 0x0042E598 File Offset: 0x0042C798
	public int GetCurExp()
	{
		return this.CurExp;
	}

	// Token: 0x060112A5 RID: 70309 RVA: 0x0042E5A0 File Offset: 0x0042C7A0
	public int GetCurRewardedMaxLv()
	{
		return this.CurRewardedMaxLv;
	}

	// Token: 0x060112A6 RID: 70310 RVA: 0x0042E5A8 File Offset: 0x0042C7A8
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

	// Token: 0x060112A7 RID: 70311 RVA: 0x0042E744 File Offset: 0x0042C944
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

	// Token: 0x060112A8 RID: 70312 RVA: 0x0042E79C File Offset: 0x0042C99C
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

	// Token: 0x060112A9 RID: 70313 RVA: 0x0042E800 File Offset: 0x0042CA00
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

	// Token: 0x060112AA RID: 70314 RVA: 0x0042E9AC File Offset: 0x0042CBAC
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

	// Token: 0x060112AB RID: 70315 RVA: 0x0042EA6C File Offset: 0x0042CC6C
	public bool IsDailyExpToLimit()
	{
		return this.DailyLimitMaxExp > 0 && this.DailyLimitExp >= this.DailyLimitMaxExp;
	}

	// Token: 0x060112AC RID: 70316 RVA: 0x0042EA8A File Offset: 0x0042CC8A
	public void UpdateMotorExpAndLevel(MotorExpAddNotify data)
	{
		this.CurExp = data.CurExp;
		this.CurLevel = data.CurLevel;
		this.DailyLimitExp = data.MotorExpLimitGainDaily;
		this.DailyLimitMaxExp = data.MotorExpMonsterDropDailyLimit;
		this.UpdateMotorLevelEffect();
	}

	// Token: 0x060112AD RID: 70317 RVA: 0x0042EAC2 File Offset: 0x0042CCC2
	public void UpdateMotorRewardedMaxLevel(MotorLevelOneKeyRewardResponse data)
	{
		this.CurRewardedMaxLv = data.MotorRewardedLvMax;
	}

	// Token: 0x060112AE RID: 70318 RVA: 0x0042EAD0 File Offset: 0x0042CCD0
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

	// Token: 0x060112AF RID: 70319 RVA: 0x0042EB74 File Offset: 0x0042CD74
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

	// Token: 0x060112B0 RID: 70320 RVA: 0x0042EBB4 File Offset: 0x0042CDB4
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

	// Token: 0x060112B1 RID: 70321 RVA: 0x0042EBF4 File Offset: 0x0042CDF4
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

	// Token: 0x060112B2 RID: 70322 RVA: 0x0042ED00 File Offset: 0x0042CF00
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

	// Token: 0x060112B3 RID: 70323 RVA: 0x0042ED5C File Offset: 0x0042CF5C
	public ILevelUpViewViedData GetCacheData()
	{
		return this.CacheLvUpData;
	}

	// Token: 0x060112B4 RID: 70324 RVA: 0x0042ED64 File Offset: 0x0042CF64
	public void ClearCacheData()
	{
		this.CacheLvUpData = null;
	}

	// Token: 0x060112B5 RID: 70325 RVA: 0x0042ED70 File Offset: 0x0042CF70
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

	// Token: 0x060112B6 RID: 70326 RVA: 0x0042EDF0 File Offset: 0x0042CFF0
	public bool RedDotHasLevelUpReward()
	{
		return this.CurRewardedMaxLv < this.CurLevel;
	}

	// Token: 0x060112B7 RID: 70327 RVA: 0x0042EE00 File Offset: 0x0042D000
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

	// Token: 0x060112B8 RID: 70328 RVA: 0x0042EEA8 File Offset: 0x0042D0A8
	public void UpdateCurTreeType(int treeType)
	{
		this.CurTreeType = treeType;
	}

	// Token: 0x060112B9 RID: 70329 RVA: 0x0042EEB1 File Offset: 0x0042D0B1
	public void UpdateSelectedTreeType(int treeType)
	{
		this.SelectedTreeType = treeType;
	}

	// Token: 0x060112BA RID: 70330 RVA: 0x0042EEBC File Offset: 0x0042D0BC
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

	// Token: 0x060112BB RID: 70331 RVA: 0x0042EFCC File Offset: 0x0042D1CC
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

	// Token: 0x060112BC RID: 70332 RVA: 0x0042F05C File Offset: 0x0042D25C
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

	// Token: 0x060112BD RID: 70333 RVA: 0x0042F114 File Offset: 0x0042D314
	public void UpdateTechTree(MotorTechOneTreePb[] dataList)
	{
		foreach (MotorTechOneTreePb motorTechOneTreePb in dataList)
		{
			this.UnlockTechTree(motorTechOneTreePb.TreeId);
			this.UpdateOneTechTree(motorTechOneTreePb);
		}
	}

	// Token: 0x060112BE RID: 70334 RVA: 0x0042F148 File Offset: 0x0042D348
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

	// Token: 0x060112BF RID: 70335 RVA: 0x0042F17C File Offset: 0x0042D37C
	public void UnlockTechNode(int[] nodeIds)
	{
		foreach (int nodeId in nodeIds)
		{
			this.RefreshTechTreeNode(nodeId, EMotorTechTreeNodeStatus.CanUnlock);
		}
	}

	// Token: 0x060112C0 RID: 70336 RVA: 0x0042F1A8 File Offset: 0x0042D3A8
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

	// Token: 0x060112C1 RID: 70337 RVA: 0x0042F1FC File Offset: 0x0042D3FC
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

	// Token: 0x060112C2 RID: 70338 RVA: 0x0042F2D4 File Offset: 0x0042D4D4
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

	// Token: 0x060112C3 RID: 70339 RVA: 0x0042F344 File Offset: 0x0042D544
	public int? GetSkillLevelByDamageId(long damageId)
	{
		int value;
		if (!this.DamgeIdToSkillLevel.TryGetValue(damageId, out value))
		{
			return null;
		}
		return new int?(value);
	}

	// Token: 0x060112C4 RID: 70340 RVA: 0x0042F371 File Offset: 0x0042D571
	public int GetCurTreeType()
	{
		return this.CurTreeType;
	}

	// Token: 0x060112C5 RID: 70341 RVA: 0x0042F379 File Offset: 0x0042D579
	public int GetSelectedTreeType()
	{
		return this.SelectedTreeType;
	}

	// Token: 0x060112C6 RID: 70342 RVA: 0x0042F381 File Offset: 0x0042D581
	public List<int> GetActivatedTreeTypeList()
	{
		return this.UnlockTreeTypeList;
	}

	// Token: 0x060112C7 RID: 70343 RVA: 0x0042F38C File Offset: 0x0042D58C
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

	// Token: 0x060112C8 RID: 70344 RVA: 0x0042F3AC File Offset: 0x0042D5AC
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

	// Token: 0x060112C9 RID: 70345 RVA: 0x0042F5E4 File Offset: 0x0042D7E4
	public void RefreshTechTreeNode(int nodeId, EMotorTechTreeNodeStatus status)
	{
		MotorTechTreeNode techNodeById = this.GetTechNodeById(nodeId);
		if (techNodeById != null)
		{
			techNodeById.Status = status;
		}
	}

	// Token: 0x060112CA RID: 70346 RVA: 0x0042F604 File Offset: 0x0042D804
	public bool IsLinkTimeNodeActivated()
	{
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("MotorTechLinkTimeNodeId").GetValueOrDefault();
		MotorTechTreeNode techNodeById = this.GetTechNodeById(valueOrDefault);
		return techNodeById != null && techNodeById.Status == EMotorTechTreeNodeStatus.Activated;
	}

	// Token: 0x060112CB RID: 70347 RVA: 0x0042F63C File Offset: 0x0042D83C
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

	// Token: 0x060112CC RID: 70348 RVA: 0x0042F69C File Offset: 0x0042D89C
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

	// Token: 0x060112CD RID: 70349 RVA: 0x0042F738 File Offset: 0x0042D938
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

	// Token: 0x060112CE RID: 70350 RVA: 0x0042F7B8 File Offset: 0x0042D9B8
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

	// Token: 0x060112CF RID: 70351 RVA: 0x0042F89C File Offset: 0x0042DA9C
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

	// Token: 0x060112D0 RID: 70352 RVA: 0x0042F8F8 File Offset: 0x0042DAF8
	public bool RedDotHasNewTechTree(int treeType)
	{
		return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.MotorDevelopNewUnlockTree) as ServerStorageSet).Has(treeType);
	}

	// Token: 0x060112D1 RID: 70353 RVA: 0x0042F914 File Offset: 0x0042DB14
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

	// Token: 0x060112D2 RID: 70354 RVA: 0x0042F9D8 File Offset: 0x0042DBD8
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

	// Token: 0x060112D3 RID: 70355 RVA: 0x0042FB24 File Offset: 0x0042DD24
	public void UpdateOneTreeTask(MotorTaskPb[] taskList)
	{
		foreach (MotorTaskPb data in taskList)
		{
			this.UpdateOneTask(data);
		}
	}

	// Token: 0x060112D4 RID: 70356 RVA: 0x0042FB4C File Offset: 0x0042DD4C
	public void UpdateAllTreeTask(MotorTaskTreePb[] dataList)
	{
		foreach (MotorTaskTreePb motorTaskTreePb in dataList)
		{
			this.TaskRewardMap[motorTaskTreePb.TreeId] = motorTaskTreePb.TpRewarded;
			this.UpdateOneTreeTask(motorTaskTreePb.Tasks.ToArray<MotorTaskPb>());
		}
	}

	// Token: 0x060112D5 RID: 70357 RVA: 0x0042FB98 File Offset: 0x0042DD98
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

	// Token: 0x060112D6 RID: 70358 RVA: 0x0042FBB8 File Offset: 0x0042DDB8
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

	// Token: 0x060112D7 RID: 70359 RVA: 0x0042FCB4 File Offset: 0x0042DEB4
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

	// Token: 0x060112D8 RID: 70360 RVA: 0x0042FD28 File Offset: 0x0042DF28
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

	// Token: 0x060112D9 RID: 70361 RVA: 0x0042FDE4 File Offset: 0x0042DFE4
	public int GetFreePointByTree(int treeType)
	{
		MotorTechTree? motorTechTreeConfig = MotorConfig.Instance.GetMotorTechTreeConfig(treeType);
		if (motorTechTreeConfig == null)
		{
			return 0;
		}
		return InventoryModel.Instance.GetItemCountByConfigId(motorTechTreeConfig.Value.TpItemId, 0);
	}

	// Token: 0x060112DA RID: 70362 RVA: 0x0042FE24 File Offset: 0x0042E024
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

	// Token: 0x060112DB RID: 70363 RVA: 0x0042FE5C File Offset: 0x0042E05C
	public bool IsOverLimitPointNum(int treeType)
	{
		int costPointByTree = this.GetCostPointByTree(treeType);
		int freePointByTree = this.GetFreePointByTree(treeType);
		int totalPointByTree = this.GetTotalPointByTree(treeType);
		return costPointByTree + freePointByTree >= totalPointByTree;
	}

	// Token: 0x060112DC RID: 70364 RVA: 0x0042FE88 File Offset: 0x0042E088
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

	// Token: 0x060112DD RID: 70365 RVA: 0x0042FEEC File Offset: 0x0042E0EC
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

	// Token: 0x060112DE RID: 70366 RVA: 0x0042FF8C File Offset: 0x0042E18C
	public void StartSwitchTechTreeLockTimer(int duration)
	{
		this.RemoveSwitchTechTreeLockTimer();
		this.SwitchTechTreeLockTimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.RemoveSwitchTechTreeLockTimer();
		}, (float)(duration * 1000), null, null, true, 1f);
	}

	// Token: 0x060112DF RID: 70367 RVA: 0x0042FFC0 File Offset: 0x0042E1C0
	public void RemoveSwitchTechTreeLockTimer()
	{
		if (this.SwitchTechTreeLockTimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.SwitchTechTreeLockTimerId);
			this.SwitchTechTreeLockTimerId = null;
		}
	}

	// Token: 0x060112E0 RID: 70368 RVA: 0x0042FFE2 File Offset: 0x0042E1E2
	public bool IsSwitchTechTreeTimeLocked()
	{
		return this.SwitchTechTreeLockTimerId != null;
	}

	// Token: 0x060112E1 RID: 70369 RVA: 0x0042FFF0 File Offset: 0x0042E1F0
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

	// Token: 0x170015EF RID: 5615
	// (get) Token: 0x060112E2 RID: 70370 RVA: 0x004300B8 File Offset: 0x0042E2B8
	public static MotorcycleDevelopModel Instance
	{
		get
		{
			return MotorcycleDevelopModel._Instance;
		}
	}

	// Token: 0x060112E3 RID: 70371 RVA: 0x004300BF File Offset: 0x0042E2BF
	public static MotorcycleDevelopModel GetOrCreateInstance()
	{
		if (MotorcycleDevelopModel._Instance == null)
		{
			MotorcycleDevelopModel.CreateInstance();
		}
		return MotorcycleDevelopModel._Instance;
	}

	// Token: 0x060112E4 RID: 70372 RVA: 0x004300D3 File Offset: 0x0042E2D3
	public static bool CreateInstance()
	{
		if (MotorcycleDevelopModel._Instance != null)
		{
			return true;
		}
		MotorcycleDevelopModel._Instance = new MotorcycleDevelopModel();
		return true;
	}

	// Token: 0x060112E5 RID: 70373 RVA: 0x004300E9 File Offset: 0x0042E2E9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060112E6 RID: 70374 RVA: 0x004300EB File Offset: 0x0042E2EB
	public static void ResetStaticDefaultValue()
	{
		MotorcycleDevelopModel._Instance = null;
	}

	// Token: 0x060112E7 RID: 70375 RVA: 0x004300F3 File Offset: 0x0042E2F3
	static MotorcycleDevelopModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleDevelopModel.CreateStaticDefaultValue), new Action(MotorcycleDevelopModel.ResetStaticDefaultValue));
	}

	// Token: 0x040082B6 RID: 33462
	private int LastLevel = -1;

	// Token: 0x040082B7 RID: 33463
	private int LastExp = -1;

	// Token: 0x040082B8 RID: 33464
	private int DailyLimitExp;

	// Token: 0x040082B9 RID: 33465
	private int DailyLimitMaxExp;

	// Token: 0x040082BA RID: 33466
	private bool IsFirstDailyExpLimit;

	// Token: 0x040082BB RID: 33467
	private int CurLevel = 1;

	// Token: 0x040082BC RID: 33468
	private int CurExp;

	// Token: 0x040082BD RID: 33469
	private int CurRewardedMaxLv;

	// Token: 0x040082BE RID: 33470
	[Nullable(2)]
	private ILevelUpViewViedData CacheLvUpData;

	// Token: 0x040082BF RID: 33471
	private readonly string ModifierHandle = "MotorLevel";

	// Token: 0x040082C0 RID: 33472
	private int CurTreeType;

	// Token: 0x040082C1 RID: 33473
	private int SelectedTreeType;

	// Token: 0x040082C2 RID: 33474
	private readonly List<int> UnlockTreeTypeList = new List<int>();

	// Token: 0x040082C3 RID: 33475
	public Dictionary<int, MotorTechTreeNode> TechNodeMap = new Dictionary<int, MotorTechTreeNode>();

	// Token: 0x040082C4 RID: 33476
	public Dictionary<long, int> DamgeIdToSkillLevel = new Dictionary<long, int>();

	// Token: 0x040082C5 RID: 33477
	private readonly Dictionary<int, int> TaskRewardMap = new Dictionary<int, int>();

	// Token: 0x040082C6 RID: 33478
	private readonly Dictionary<int, MotorTechTaskNode> TaskNodeMap = new Dictionary<int, MotorTechTaskNode>();

	// Token: 0x040082C7 RID: 33479
	[Nullable(2)]
	private TimerHandle SwitchTechTreeLockTimerId;

	// Token: 0x040082C8 RID: 33480
	[Nullable(2)]
	private static MotorcycleDevelopModel _Instance;
}
