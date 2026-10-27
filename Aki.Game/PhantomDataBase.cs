using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using Google.Protobuf.Collections;

// Token: 0x020023F7 RID: 9207
[NullableContext(1)]
[Nullable(0)]
public abstract class PhantomDataBase
{
	// Token: 0x06012647 RID: 75335 RVA: 0x00488B6A File Offset: 0x00486D6A
	public void SetPhantomLevel(int level)
	{
		this.PhantomLevel = level;
	}

	// Token: 0x06012648 RID: 75336 RVA: 0x00488B73 File Offset: 0x00486D73
	public static int GenerateLocalUniqueId(int roleId, int slotIndex)
	{
		return -1 * (roleId * 10) - slotIndex;
	}

	// Token: 0x06012649 RID: 75337 RVA: 0x00488B7D File Offset: 0x00486D7D
	public void SetIncId(int id)
	{
		this.IncrId = id;
	}

	// Token: 0x0601264A RID: 75338 RVA: 0x00488B86 File Offset: 0x00486D86
	public int GetPhantomLevel()
	{
		return this.PhantomLevel;
	}

	// Token: 0x0601264B RID: 75339 RVA: 0x00488B8E File Offset: 0x00486D8E
	public bool GetVisionNoCultivated()
	{
		return this.GetPhantomLevel() == 0 && this.GetExp() == 0;
	}

	// Token: 0x0601264C RID: 75340 RVA: 0x00488BA3 File Offset: 0x00486DA3
	public bool GetVisionIfCanRecovery(bool onlyGold)
	{
		return (!onlyGold || this.GetQuality() >= 5) && this.GetVisionNoCultivated() && !this.GetIsLock();
	}

	// Token: 0x0601264D RID: 75341 RVA: 0x00488BC6 File Offset: 0x00486DC6
	public bool GetVisionIfCanRefine(EVisionRefineRefineType refineType)
	{
		if (this.GetQuality() < 5)
		{
			return false;
		}
		if (refineType == EVisionRefineRefineType.Main)
		{
			return this.GetVisionNoCultivated();
		}
		return refineType == EVisionRefineRefineType.Sub && this.GetMaxSubPropCount() == this.PhantomSubProp.Count;
	}

	// Token: 0x0601264E RID: 75342 RVA: 0x00488BF6 File Offset: 0x00486DF6
	public bool IsMax()
	{
		return this.PhantomLevel >= PhantomBattleController.Instance.GetMaxLevel(this.IncrId);
	}

	// Token: 0x0601264F RID: 75343 RVA: 0x00488C13 File Offset: 0x00486E13
	public void SetPhantomExp(int exp)
	{
		this.PhantomExp = exp;
	}

	// Token: 0x06012650 RID: 75344 RVA: 0x00488C1C File Offset: 0x00486E1C
	public PhantomBattleInstance CurrentPhantomInstance()
	{
		return this.GetPhantomInstanceWithSkinId();
	}

	// Token: 0x06012651 RID: 75345 RVA: 0x00488C24 File Offset: 0x00486E24
	[NullableContext(2)]
	public PhantomPropSlot GetCurrentSuspendSlotData()
	{
		return this.SuspendSlot;
	}

	// Token: 0x06012652 RID: 75346 RVA: 0x00488C2C File Offset: 0x00486E2C
	public virtual int GetFetterGroupId()
	{
		return this.FetterGroupId;
	}

	// Token: 0x06012653 RID: 75347 RVA: 0x00488C34 File Offset: 0x00486E34
	public int GetEatFullExp()
	{
		int value = ConfigCommonParamById.GetIntConfig("PhantomExpReturnRatio").Value;
		return (int)Math.Floor((double)(this.GetFullExp() * value) / 1000.0);
	}

	// Token: 0x06012654 RID: 75348 RVA: 0x00488C70 File Offset: 0x00486E70
	public int GetFullExp()
	{
		if (this.GetPhantomLevel() == 0)
		{
			return this.PhantomExp;
		}
		int num = 0;
		for (int i = 1; i <= this.GetPhantomLevel(); i++)
		{
			num += PhantomBattleConfig.Instance.GetPhantomLevelExpByGroupIdAndLevel(this.GetPhantomInstance().PhantomItem.Value.LevelUpGroupId, i);
		}
		return num + this.PhantomExp;
	}

	// Token: 0x06012655 RID: 75349 RVA: 0x00488CD0 File Offset: 0x00486ED0
	public int GetExp()
	{
		return this.PhantomExp;
	}

	// Token: 0x06012656 RID: 75350 RVA: 0x00488CD8 File Offset: 0x00486ED8
	public void UpdateData(Aki.Protocol.PhantomItem data)
	{
		this.IncrId = data.IncrId;
		this.FuncValue = data.FuncValue;
		this.PhantomLevel = data.PhantomLevel;
		this.PhantomExp = data.PhantomExp;
		this.PhantomMainProp = data.PhantomMainProp.ToList<Aki.Protocol.PhantomPropInfo>();
		this.PhantomSubProp = data.PhantomSubProp.ToList<Aki.Protocol.PhantomPropInfo>();
		this.FetterGroupId = data.FetterGroupId;
		this.SkinIdInternal = data.SkinId;
		this.UnAckSubProp = data.UnAckSubProp.ToList<Aki.Protocol.PhantomPropInfo>();
		this.LockSubPropIndices = data.LockPropIndex.ToList<int>();
	}

	// Token: 0x06012657 RID: 75351 RVA: 0x00488D71 File Offset: 0x00486F71
	public void SetMainProp(List<Aki.Protocol.PhantomPropInfo> data)
	{
		this.PhantomMainProp = data;
	}

	// Token: 0x06012658 RID: 75352 RVA: 0x00488D7A File Offset: 0x00486F7A
	public void SetSubProp(List<Aki.Protocol.PhantomPropInfo> data)
	{
		this.PhantomSubProp = data;
	}

	// Token: 0x06012659 RID: 75353 RVA: 0x00488D83 File Offset: 0x00486F83
	public int GetIncrId()
	{
		return this.IncrId;
	}

	// Token: 0x0601265A RID: 75354 RVA: 0x00488D8B File Offset: 0x00486F8B
	public void OnFunctionValueChange(int value)
	{
		this.FuncValue = value;
	}

	// Token: 0x0601265B RID: 75355 RVA: 0x00488D94 File Offset: 0x00486F94
	public List<AttrListScrollData> GetSuspendAttributeData()
	{
		RepeatedField<Aki.Protocol.PhantomPropInfo> phantomProp = this.SuspendSlot.PhantomProp;
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in phantomProp)
		{
			PhantomSubProperty phantomSubPropertyById = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(phantomPropInfo.PhantomPropId);
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(phantomPropInfo.PhantomPropId);
			bool isRatio = phantomSubPropertyById.AddType == 2;
			double propRatioValue = TipsDataTool.GetPropRatioValue((double)phantomPropInfo.Value, isRatio);
			list.Add(new AttrListScrollData(phantomSubPropertyById.PropId, 0.0, propRatioValue, propertyIndexInfo.Value.Priority, isRatio, CommonComponentDefine.EAttributeType.PhantomType));
		}
		return list;
	}

	// Token: 0x0601265C RID: 75356 RVA: 0x00488E58 File Offset: 0x00487058
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<AttrListScrollData> GetSlotIndexAttributeData(int index, CommonComponentDefine.EAttributeType attributeType)
	{
		if (this.GetSlotIndexDataEx(index) != null)
		{
			Aki.Protocol.PhantomPropInfo slotIndexDataEx = this.GetSlotIndexDataEx(index);
			List<AttrListScrollData> list = new List<AttrListScrollData>();
			PhantomSubProperty phantomSubPropertyById = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(slotIndexDataEx.PhantomPropId);
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(slotIndexDataEx.PhantomPropId);
			bool isRatio = phantomSubPropertyById.AddType == 2;
			double propRatioValue = TipsDataTool.GetPropRatioValue((double)slotIndexDataEx.Value, isRatio);
			list.Add(new AttrListScrollData(phantomSubPropertyById.PropId, 0.0, propRatioValue, propertyIndexInfo.Value.Priority, isRatio, attributeType));
			return list;
		}
		return null;
	}

	// Token: 0x0601265D RID: 75357 RVA: 0x00488EE8 File Offset: 0x004870E8
	public bool IsFunctionValue(InventoryDefine.EItemDataFunctionType functionType)
	{
		return (this.FuncValue & 1 << (int)functionType) > 0;
	}

	// Token: 0x0601265E RID: 75358 RVA: 0x00488EFA File Offset: 0x004870FA
	public bool GetIsLock()
	{
		return this.IsFunctionValue(InventoryDefine.EItemDataFunctionType.Lock);
	}

	// Token: 0x0601265F RID: 75359 RVA: 0x00488F03 File Offset: 0x00487103
	public bool GetIsDeprecated()
	{
		return this.IsFunctionValue(InventoryDefine.EItemDataFunctionType.Deprecate);
	}

	// Token: 0x06012660 RID: 75360 RVA: 0x00488F0C File Offset: 0x0048710C
	public int GetEquipRoleId()
	{
		return PhantomBattleModel.Instance.GetPhantomEquipOnRoleId(this.GetIncrId()).GetValueOrDefault();
	}

	// Token: 0x06012661 RID: 75361 RVA: 0x00488F34 File Offset: 0x00487134
	public int GetEquipRoleIndex()
	{
		int equipRoleId = this.GetEquipRoleId();
		if (equipRoleId > 0)
		{
			List<int> incrIdList = PhantomBattleModel.Instance.GetBattleDataById(equipRoleId).GetIncrIdList();
			if (incrIdList.Contains(this.GetIncrId()))
			{
				return incrIdList.IndexOf(this.GetIncrId());
			}
		}
		return -1;
	}

	// Token: 0x06012662 RID: 75362 RVA: 0x00488F7C File Offset: 0x0048717C
	public string GetNameColor()
	{
		return CSharpScript.Game.Module.Item.ItemConfig.Instance.GetQualityConfig(this.GetQuality()).Value.DropColor;
	}

	// Token: 0x06012663 RID: 75363 RVA: 0x00488FAC File Offset: 0x004871AC
	private IReadOnlyList<int> CalculateFinalIncList(int index, int roleId)
	{
		List<int> incrIdList = PhantomBattleModel.Instance.GetBattleDataById(roleId).GetIncrIdList();
		if (index == -1)
		{
			return incrIdList;
		}
		int indexPhantomId = PhantomBattleModel.Instance.GetBattleDataById(roleId).GetIndexPhantomId(index);
		int incrId = this.GetIncrId();
		if (indexPhantomId == incrId)
		{
			return incrIdList;
		}
		List<int> list = new List<int>(PhantomBattleModel.Instance.GetBattleDataById(roleId).GetIncrIdList());
		if (indexPhantomId == 0)
		{
			if (this.GetEquipRoleId() == roleId)
			{
				int equipRoleIndex = this.GetEquipRoleIndex();
				list[equipRoleIndex] = 0;
				list[index] = incrId;
			}
			else
			{
				list[index] = incrId;
			}
		}
		else if (indexPhantomId != incrId)
		{
			if (this.GetEquipRoleId() == roleId)
			{
				int equipRoleIndex2 = this.GetEquipRoleIndex();
				list[equipRoleIndex2] = list[index];
				list[index] = incrId;
			}
			else
			{
				list[index] = incrId;
			}
		}
		return list;
	}

	// Token: 0x06012664 RID: 75364 RVA: 0x00489070 File Offset: 0x00487270
	[return: Nullable(2)]
	public static Dictionary<int, int> CalculateFetterByPhantomBattleData(List<PhantomDataBase> phantomBattleData)
	{
		int count = phantomBattleData.Count;
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		Dictionary<int, List<int>> dictionary2 = new Dictionary<int, List<int>>();
		for (int i = 0; i < count; i++)
		{
			PhantomDataBase phantomDataBase = phantomBattleData[i];
			if (phantomDataBase != null)
			{
				int fetterGroupId = phantomDataBase.GetFetterGroupId();
				List<int> list;
				if (!dictionary2.TryGetValue(fetterGroupId, out list))
				{
					list = new List<int>();
				}
				if (!list.Contains(phantomDataBase.GetMonsterId(false)))
				{
					int num;
					if (!dictionary.TryGetValue(fetterGroupId, out num))
					{
						num = 0;
					}
					int value = num + 1;
					dictionary[fetterGroupId] = value;
					list.Add(phantomDataBase.GetMonsterId(false));
				}
				dictionary2[fetterGroupId] = list;
			}
		}
		return dictionary;
	}

	// Token: 0x06012665 RID: 75365 RVA: 0x00489110 File Offset: 0x00487310
	public bool IfEquipSameNameMonsterOnRole(int index, int roleId)
	{
		List<int> list = new List<int>();
		foreach (int uniqueId in this.CalculateFinalIncList(index, roleId))
		{
			PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(uniqueId);
			if (phantomDataBase != null)
			{
				list.Add(phantomDataBase.GetMonsterId(false));
			}
		}
		HashSet<int> hashSet = new HashSet<int>(list);
		return list.Count != hashSet.Count;
	}

	// Token: 0x06012666 RID: 75366 RVA: 0x00489198 File Offset: 0x00487398
	public bool IfEquipOverNeedOnRole(List<VisionFetterData> fetterData)
	{
		if (fetterData.Count <= 0)
		{
			return false;
		}
		VisionFetterData visionFetterData = fetterData[0];
		for (int i = 1; i < fetterData.Count; i++)
		{
			if (fetterData[i].NeedActiveNum > visionFetterData.NeedActiveNum)
			{
				visionFetterData = fetterData[i];
			}
		}
		return visionFetterData.ActiveFetterGroupNum > visionFetterData.NeedActiveNum;
	}

	// Token: 0x06012667 RID: 75367 RVA: 0x004891F4 File Offset: 0x004873F4
	public List<VisionFetterData> GetPreviewShowFetterList(int index, int roleId)
	{
		List<VisionFetterData> list = new List<VisionFetterData>();
		if (this.FetterGroupId <= 0)
		{
			return list;
		}
		Dictionary<int, int> fetterGroupFetterDataById = PhantomBattleConfig.Instance.GetFetterGroupFetterDataById(this.FetterGroupId);
		IReadOnlyList<int> readOnlyList = this.CalculateFinalIncList(index, roleId);
		VisionFetterData[] roleFetterData = PhantomBattleModel.Instance.GetRoleFetterData(roleId);
		int count = readOnlyList.Count;
		List<PhantomDataBase> list2 = new List<PhantomDataBase>();
		for (int i = 0; i < count; i++)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(readOnlyList[i]);
			if (phantomBattleData != null)
			{
				list2.Add(phantomBattleData);
			}
		}
		Dictionary<int, int> dictionary = PhantomDataBase.CalculateFetterByPhantomBattleData(list2);
		int num = roleFetterData.Length;
		foreach (KeyValuePair<int, int> keyValuePair in fetterGroupFetterDataById)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			VisionFetterData visionFetterData = new VisionFetterData();
			visionFetterData.FetterGroupId = this.FetterGroupId;
			visionFetterData.FetterId = value;
			visionFetterData.NeedActiveNum = key;
			int num2;
			if (!dictionary.TryGetValue(this.FetterGroupId, out num2))
			{
				num2 = 0;
			}
			visionFetterData.ActiveFetterGroupNum = num2;
			visionFetterData.ActiveState = (num2 >= key);
			bool flag = num2 >= key;
			bool flag2 = false;
			for (int j = 0; j < num; j++)
			{
				if (roleFetterData[j].FetterId == value && roleFetterData[j].ActiveState != flag && flag)
				{
					flag2 = true;
					break;
				}
			}
			if (flag2)
			{
				visionFetterData.NewAdd = true;
			}
			list.Add(visionFetterData);
		}
		return list;
	}

	// Token: 0x06012668 RID: 75368 RVA: 0x0048938C File Offset: 0x0048758C
	public List<VisionAttributeVariantTwoData> GetPreviewCurrentShowFetterList()
	{
		return new List<VisionAttributeVariantTwoData>();
	}

	// Token: 0x06012669 RID: 75369 RVA: 0x00489394 File Offset: 0x00487594
	public List<VisionAttributeVariantTwoData> GetShowFetterList(int index, int roleId)
	{
		List<VisionAttributeVariantTwoData> list = new List<VisionAttributeVariantTwoData>();
		if (index != -1)
		{
			foreach (int fetterId in this.GetAddFetterList(index, roleId))
			{
				list.Add(new VisionAttributeVariantTwoData
				{
					FetterId = fetterId,
					State = EFetterCompare.Add
				});
			}
			foreach (int fetterId2 in this.GetDelFetterList(index, roleId))
			{
				list.Add(new VisionAttributeVariantTwoData
				{
					FetterId = fetterId2,
					State = EFetterCompare.Decrease
				});
			}
		}
		foreach (int fetterId3 in this.GetCanActiveFetterList())
		{
			if (!this.CheckFetterInList(list, fetterId3))
			{
				list.Add(new VisionAttributeVariantTwoData
				{
					FetterId = fetterId3,
					State = EFetterCompare.Normal
				});
			}
		}
		return list;
	}

	// Token: 0x0601266A RID: 75370 RVA: 0x00489468 File Offset: 0x00487668
	private bool CheckFetterInList(List<VisionAttributeVariantTwoData> data, int fetterId)
	{
		for (int i = data.Count - 1; i >= 0; i--)
		{
			if (data[i].FetterId == fetterId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601266B RID: 75371 RVA: 0x0048949A File Offset: 0x0048769A
	public int[] GetCanActiveFetterList()
	{
		return PhantomBattleModel.Instance.GetTargetCanActiveFettersList(this.GetIncrId());
	}

	// Token: 0x0601266C RID: 75372 RVA: 0x004894AC File Offset: 0x004876AC
	public int[] GetDelFetterList(int index, int roleId)
	{
		return PhantomBattleModel.Instance.GetPreviewFettersDel(this, index, roleId);
	}

	// Token: 0x0601266D RID: 75373 RVA: 0x004894BB File Offset: 0x004876BB
	public int[] GetAddFetterList(int index, int roleId)
	{
		return PhantomBattleModel.Instance.GetPreviewFetterAdd(this, index, roleId);
	}

	// Token: 0x0601266E RID: 75374 RVA: 0x004894CA File Offset: 0x004876CA
	public PhantomFetterGroup GetFetterGroupConfig()
	{
		return PhantomBattleConfig.Instance.GetFetterGroupById(this.GetFetterGroupId());
	}

	// Token: 0x0601266F RID: 75375 RVA: 0x004894DC File Offset: 0x004876DC
	public bool GetIsFetterGroupSpecial()
	{
		return this.GetFetterGroupConfig().FetterType == 1;
	}

	// Token: 0x06012670 RID: 75376 RVA: 0x004894FC File Offset: 0x004876FC
	public int GetCost()
	{
		int rarity = this.GetConfig().Rarity;
		return PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity).Value.Cost;
	}

	// Token: 0x06012671 RID: 75377 RVA: 0x00489534 File Offset: 0x00487734
	public PhantomRarity? GetRareConfig()
	{
		int rarity = this.GetConfig().Rarity;
		return PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity);
	}

	// Token: 0x06012672 RID: 75378 RVA: 0x0048955C File Offset: 0x0048775C
	public ILevelUpSuccessAttributeData GetNewSubPropSuccessData(List<Aki.Protocol.PhantomPropInfo> pastSubProp)
	{
		int count = pastSubProp.Count;
		int count2 = this.PhantomSubProp.Count;
		List<AttrListScrollData> subPropShowAttributeList = this.GetSubPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType);
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		for (int i = count; i < count2; i++)
		{
			subPropShowAttributeList[i].AddValue = subPropShowAttributeList[i].BaseValue;
			subPropShowAttributeList[i].BaseValue = 0.0;
			list.Add(subPropShowAttributeList[i]);
		}
		List<IAttributeInfo> list2 = new List<IAttributeInfo>();
		foreach (AttrListScrollData attrData in list)
		{
			IAttributeInfo attributeInfo = RoleLevelUpSuccessController.ConvertsAttrListScrollDataToAttributeInfo(attrData);
			attributeInfo.ShowArrow = new bool?(false);
			attributeInfo.PreText = null;
			list2.Add(attributeInfo);
		}
		return new LevelUpSuccessAttributeData
		{
			Title = "IdentifySuccess",
			WiderScrollView = new bool?(false),
			AttributeInfo = list2,
			IsShowArrow = new bool?(false)
		};
	}

	// Token: 0x06012673 RID: 75379 RVA: 0x0048966C File Offset: 0x0048786C
	[NullableContext(2)]
	public Aki.Protocol.PhantomPropInfo GetSlotIndexDataEx(int index)
	{
		List<Aki.Protocol.PhantomPropInfo> phantomSubProp = this.PhantomSubProp;
		if (phantomSubProp.Count > index)
		{
			return phantomSubProp[index];
		}
		return null;
	}

	// Token: 0x06012674 RID: 75380 RVA: 0x00489694 File Offset: 0x00487894
	public int GetMaxSubPropCount()
	{
		int quality = this.GetQuality();
		return PhantomBattleConfig.Instance.GetPhantomSlotUnlockLevel(quality).Length;
	}

	// Token: 0x06012675 RID: 75381 RVA: 0x004896B8 File Offset: 0x004878B8
	public List<VisionSubPropData> GetSubPropIdentifyPreviewData(int currentLevel, int identifyNum)
	{
		List<VisionSubPropData> levelSubPropData = this.GetLevelSubPropData(currentLevel);
		int num = 0;
		int count = levelSubPropData.Count;
		for (int i = 0; i < count; i++)
		{
			if (levelSubPropData[i].SlotState == EVisionSlotState.UnlockAndNoProp && identifyNum - num > 0)
			{
				levelSubPropData[i].SlotState = EVisionSlotState.PrepareToIdentify;
				num++;
			}
		}
		return levelSubPropData;
	}

	// Token: 0x06012676 RID: 75382 RVA: 0x0048970C File Offset: 0x0048790C
	public List<VisionSubPropData> GetLevelSubPropPreviewData(int currentLevel, int targetLevel)
	{
		List<VisionSubPropData> levelSubPropData = this.GetLevelSubPropData(currentLevel);
		List<VisionSubPropData> levelSubPropData2 = this.GetLevelSubPropData(targetLevel);
		int count = levelSubPropData2.Count;
		for (int i = 0; i < count; i++)
		{
			if (levelSubPropData2[i].SlotState != EVisionSlotState.Lock && levelSubPropData[i].SlotState == EVisionSlotState.Lock)
			{
				levelSubPropData2[i].SlotState = EVisionSlotState.PreviewUnLock;
			}
		}
		return levelSubPropData2;
	}

	// Token: 0x06012677 RID: 75383 RVA: 0x00489768 File Offset: 0x00487968
	public List<VisionSubPropData> GetEquipmentViewPreviewData()
	{
		List<VisionSubPropData> levelSubPropData = this.GetLevelSubPropData(this.GetPhantomLevel());
		int count = levelSubPropData.Count;
		List<VisionSubPropData> list = new List<VisionSubPropData>();
		int num = 0;
		for (int i = 0; i < count; i++)
		{
			if (levelSubPropData[i].SlotState == EVisionSlotState.UnlockAndHaveProp)
			{
				list.Add(levelSubPropData[i]);
			}
			if (levelSubPropData[i].SlotState == EVisionSlotState.UnlockAndNoProp && num == 0)
			{
				list.Add(levelSubPropData[i]);
				num++;
			}
		}
		return list;
	}

	// Token: 0x06012678 RID: 75384 RVA: 0x004897E5 File Offset: 0x004879E5
	public int GetIdentifyCostItemId()
	{
		return 2;
	}

	// Token: 0x06012679 RID: 75385 RVA: 0x004897E8 File Offset: 0x004879E8
	public int GetIdentifyCostItemValue()
	{
		return PhantomBattleConfig.Instance.GetQualityIdentifyCost(this.GetQuality());
	}

	// Token: 0x0601267A RID: 75386 RVA: 0x004897FC File Offset: 0x004879FC
	public Dictionary<int, int> GetCurrentIdentifyCost()
	{
		int quality = this.GetQuality();
		PhantomQuality? phantomQualityByItemQuality = PhantomBattleConfig.Instance.GetPhantomQualityByItemQuality(quality);
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 0; i < phantomQualityByItemQuality.Value.IdentifyCostLength; i++)
		{
			DicIntInt? dicIntInt = phantomQualityByItemQuality.Value.IdentifyCost(i);
			dictionary.TryAdd(dicIntInt.Value.Key, dicIntInt.Value.Value);
		}
		return dictionary;
	}

	// Token: 0x0601267B RID: 75387 RVA: 0x00489878 File Offset: 0x00487A78
	public int GetCurrentSubPropLockCount()
	{
		List<VisionSubPropData> levelSubPropData = this.GetLevelSubPropData(this.GetPhantomLevel());
		int num = 0;
		using (List<VisionSubPropData>.Enumerator enumerator = levelSubPropData.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.SlotState == EVisionSlotState.Lock)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x0601267C RID: 75388 RVA: 0x004898D8 File Offset: 0x00487AD8
	public bool GetIfHaveEnoughIdentifyGold(int identifyNum)
	{
		int num = this.GetIdentifyCostItemValue() * identifyNum;
		int num2 = 0;
		List<ItemDataBase> itemDataBaseByConfigId = InventoryModel.Instance.GetItemDataBaseByConfigId(this.GetIdentifyCostItemId());
		if (itemDataBaseByConfigId.Count > 0)
		{
			num2 = itemDataBaseByConfigId[0].GetCount();
		}
		return num2 - num >= 0;
	}

	// Token: 0x0601267D RID: 75389 RVA: 0x00489920 File Offset: 0x00487B20
	public bool GetIfHaveEnoughIdentifyConsumeItem(int identifyNum)
	{
		int num = this.GetCurrentIdentifyCostValue() * identifyNum;
		List<ItemDataBase> itemDataBaseByConfigId = InventoryModel.Instance.GetItemDataBaseByConfigId(this.GetCurrentIdentifyCostId());
		int num2 = 0;
		if (itemDataBaseByConfigId.Count > 0)
		{
			num2 = itemDataBaseByConfigId[0].GetCount();
		}
		return num2 - num >= 0;
	}

	// Token: 0x0601267E RID: 75390 RVA: 0x00489968 File Offset: 0x00487B68
	public int GetNextIdentifyLevel()
	{
		List<VisionSubPropData> levelSubPropData = this.GetLevelSubPropData(this.GetPhantomLevel());
		int result = 0;
		foreach (VisionSubPropData visionSubPropData in levelSubPropData)
		{
			if (visionSubPropData.SlotState == EVisionSlotState.Lock)
			{
				result = visionSubPropData.GetUnlockLevel();
				break;
			}
		}
		return result;
	}

	// Token: 0x0601267F RID: 75391 RVA: 0x004899D0 File Offset: 0x00487BD0
	public int GetCurrentIdentifyCostId()
	{
		Dictionary<int, int> currentIdentifyCost = this.GetCurrentIdentifyCost();
		int result = 0;
		foreach (KeyValuePair<int, int> keyValuePair in currentIdentifyCost)
		{
			result = keyValuePair.Key;
		}
		return result;
	}

	// Token: 0x06012680 RID: 75392 RVA: 0x00489A28 File Offset: 0x00487C28
	public int GetCurrentIdentifyCostValue()
	{
		Dictionary<int, int> currentIdentifyCost = this.GetCurrentIdentifyCost();
		int result = 0;
		foreach (KeyValuePair<int, int> keyValuePair in currentIdentifyCost)
		{
			result = keyValuePair.Value;
		}
		return result;
	}

	// Token: 0x06012681 RID: 75393 RVA: 0x00489A80 File Offset: 0x00487C80
	public int GetCurrentCanIdentifyCount()
	{
		List<VisionSubPropData> levelSubPropData = this.GetLevelSubPropData(this.GetPhantomLevel());
		int num = 0;
		using (List<VisionSubPropData>.Enumerator enumerator = levelSubPropData.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.SlotState == EVisionSlotState.UnlockAndNoProp)
				{
					num++;
				}
			}
		}
		int num2 = num;
		foreach (KeyValuePair<int, int> keyValuePair in this.GetCurrentIdentifyCost())
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			int num3 = 0;
			List<ItemDataBase> itemDataBaseByConfigId = InventoryModel.Instance.GetItemDataBaseByConfigId(key);
			if (itemDataBaseByConfigId.Count > 0)
			{
				num3 = (int)Math.Floor((double)itemDataBaseByConfigId[0].GetCount() / (double)value);
			}
			if (num3 < num2)
			{
				num2 = num3;
			}
		}
		return num2;
	}

	// Token: 0x06012682 RID: 75394 RVA: 0x00489B70 File Offset: 0x00487D70
	public int GetLevelUnlockSubPropSlotCount(int level)
	{
		int maxSubPropCount = this.GetMaxSubPropCount();
		int num = 0;
		for (int i = 0; i < maxSubPropCount; i++)
		{
			if (level >= this.GetSubPropUnlockLevel(i))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06012683 RID: 75395 RVA: 0x00489BA4 File Offset: 0x00487DA4
	public List<VisionSubPropData> GetLevelSubPropData(int level)
	{
		int maxSubPropCount = this.GetMaxSubPropCount();
		List<VisionSubPropData> list = new List<VisionSubPropData>();
		for (int i = 0; i < maxSubPropCount; i++)
		{
			VisionSubPropData visionSubPropData = new VisionSubPropData(i, this);
			if (level >= this.GetSubPropUnlockLevel(i))
			{
				Aki.Protocol.PhantomPropInfo slotIndexDataEx = this.GetSlotIndexDataEx(i);
				if (slotIndexDataEx != null)
				{
					visionSubPropData.SlotState = EVisionSlotState.UnlockAndHaveProp;
					visionSubPropData.PhantomSubProp = slotIndexDataEx;
				}
				else
				{
					visionSubPropData.SlotState = EVisionSlotState.UnlockAndNoProp;
				}
			}
			else
			{
				visionSubPropData.SlotState = EVisionSlotState.Lock;
			}
			list.Add(visionSubPropData);
		}
		return list;
	}

	// Token: 0x06012684 RID: 75396 RVA: 0x00489C14 File Offset: 0x00487E14
	public bool GetIfHaveLockSubProp()
	{
		List<VisionSubPropData> levelSubPropData = this.GetLevelSubPropData(this.GetPhantomLevel());
		bool result = false;
		using (List<VisionSubPropData>.Enumerator enumerator = levelSubPropData.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.SlotState == EVisionSlotState.Lock)
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06012685 RID: 75397 RVA: 0x00489C74 File Offset: 0x00487E74
	public bool GetIfHaveUnIdentifySubProp()
	{
		List<VisionSubPropData> levelSubPropData = this.GetLevelSubPropData(this.GetPhantomLevel());
		bool result = false;
		using (List<VisionSubPropData>.Enumerator enumerator = levelSubPropData.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.SlotState == EVisionSlotState.UnlockAndNoProp)
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06012686 RID: 75398 RVA: 0x00489CD4 File Offset: 0x00487ED4
	public int GetSubPropUnlockLevel(int index)
	{
		int quality = this.GetQuality();
		int[] phantomSlotUnlockLevel = PhantomBattleConfig.Instance.GetPhantomSlotUnlockLevel(quality);
		if (phantomSlotUnlockLevel.Length < index)
		{
			return 9999;
		}
		return phantomSlotUnlockLevel[index];
	}

	// Token: 0x06012687 RID: 75399 RVA: 0x00489D04 File Offset: 0x00487F04
	public int GetMaxSlotCount()
	{
		int levelLimit = this.GetLevelLimit();
		IEnumerable<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("PhantomSlotUnlockLevel");
		int num = 0;
		foreach (int num2 in intArrayConfig)
		{
			if (levelLimit >= num2)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06012688 RID: 75400 RVA: 0x00489D60 File Offset: 0x00487F60
	public int GetSlotUnlockLevel(int index)
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("PhantomSlotUnlockLevel");
		if (intArrayConfig.Count < index)
		{
			return 9999;
		}
		return intArrayConfig[index];
	}

	// Token: 0x06012689 RID: 75401 RVA: 0x00489D8E File Offset: 0x00487F8E
	public bool GetSlotLockState(int index)
	{
		return this.GetPhantomLevel() < this.GetSlotUnlockLevel(index);
	}

	// Token: 0x0601268A RID: 75402 RVA: 0x00489DA4 File Offset: 0x00487FA4
	public float GetIdentifyBackRadio()
	{
		return (float)ConfigCommonParamById.GetIntConfig("PhantomIdentifyReturnRatio").Value / 1000f;
	}

	// Token: 0x0601268B RID: 75403 RVA: 0x00489DCA File Offset: 0x00487FCA
	public int GetCurrentIdentifyNum()
	{
		return this.PhantomSubProp.Count;
	}

	// Token: 0x0601268C RID: 75404 RVA: 0x00489DD8 File Offset: 0x00487FD8
	public Dictionary<int, int> GetIdentifyBackItem()
	{
		float currentIdentifyCostValue = (float)this.GetCurrentIdentifyCostValue();
		int currentIdentifyCostId = this.GetCurrentIdentifyCostId();
		int currentIdentifyNum = this.GetCurrentIdentifyNum();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		int num = (int)Math.Floor((double)(currentIdentifyCostValue * (float)currentIdentifyNum * this.GetIdentifyBackRadio()));
		if (num > 0)
		{
			dictionary[currentIdentifyCostId] = num;
		}
		return dictionary;
	}

	// Token: 0x0601268D RID: 75405 RVA: 0x00489E20 File Offset: 0x00488020
	public List<VisionSlotData> GetLevelSlotData(int level)
	{
		int maxSlotCount = this.GetMaxSlotCount();
		List<VisionSlotData> list = new List<VisionSlotData>();
		if (maxSlotCount >= 1 && level < this.GetSlotUnlockLevel(0))
		{
			return list;
		}
		for (int i = 0; i < maxSlotCount; i++)
		{
			VisionSlotData visionSlotData = new VisionSlotData();
			if (level >= this.GetSlotUnlockLevel(i))
			{
				if (this.GetSlotIndexDataEx(i) != null)
				{
					visionSlotData.SlotState = EVisionSlotState.UnlockAndHaveProp;
				}
				else
				{
					visionSlotData.SlotState = EVisionSlotState.UnlockAndNoProp;
				}
			}
			else
			{
				visionSlotData.SlotState = EVisionSlotState.Lock;
			}
			list.Add(visionSlotData);
		}
		return list;
	}

	// Token: 0x0601268E RID: 75406 RVA: 0x00489E90 File Offset: 0x00488090
	public List<VisionSlotData> GetCurrentSlotData()
	{
		return this.GetLevelSlotData(this.GetPhantomLevel());
	}

	// Token: 0x0601268F RID: 75407 RVA: 0x00489EA0 File Offset: 0x004880A0
	public List<VisionSlotData> GetPreviewSlotData(int previewLevel)
	{
		List<VisionSlotData> currentSlotData = this.GetCurrentSlotData();
		List<VisionSlotData> levelSlotData = this.GetLevelSlotData(previewLevel);
		int count = levelSlotData.Count;
		for (int i = 0; i < count; i++)
		{
			if (currentSlotData.Count == 0)
			{
				int slotUnlockLevel = this.GetSlotUnlockLevel(i);
				if (previewLevel >= slotUnlockLevel)
				{
					levelSlotData[i].SlotState = EVisionSlotState.PreviewUnLock;
				}
				else
				{
					levelSlotData[i].SlotState = EVisionSlotState.Lock;
				}
			}
			else if (currentSlotData.Count > i && currentSlotData[i].SlotState != levelSlotData[i].SlotState)
			{
				levelSlotData[i].SlotState = EVisionSlotState.PreviewUnLock;
			}
		}
		return levelSlotData;
	}

	// Token: 0x06012690 RID: 75408 RVA: 0x00489F34 File Offset: 0x00488134
	public int GetCurrentSkillId()
	{
		return this.GetPhantomInstanceWithSkinId().PhantomItem.Value.SkillId;
	}

	// Token: 0x06012691 RID: 75409 RVA: 0x00489F5C File Offset: 0x0048815C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] GetSkillDescExParam(int skillId)
	{
		return PhantomBattleConfig.Instance.GetPhantomSkillDescExBySkillIdAndQuality(skillId, this.GetQuality());
	}

	// Token: 0x06012692 RID: 75410 RVA: 0x00489F70 File Offset: 0x00488170
	[NullableContext(2)]
	public IMainSkillInfoData GetNormalSkillDesc()
	{
		PhantomBattleInstance phantomInstanceWithSkinId = this.GetPhantomInstanceWithSkinId();
		PhantomSkill? phantomSkillBySkillId = PhantomBattleConfig.Instance.GetPhantomSkillBySkillId(phantomInstanceWithSkinId.PhantomItem.Value.SkillId);
		if (phantomSkillBySkillId == null)
		{
			return null;
		}
		return new MainSkillInfoData
		{
			MainSkillText = phantomSkillBySkillId.Value.DescriptionEx,
			MainSkillParameter = this.GetSkillDescExParam(phantomSkillBySkillId.Value.Id),
			MainSkillIcon = phantomSkillBySkillId.Value.BattleViewIcon
		};
	}

	// Token: 0x06012693 RID: 75411 RVA: 0x0048A000 File Offset: 0x00488200
	public PhantomSkill? GetNormalSkillConfig()
	{
		PhantomBattleInstance phantomInstanceWithSkinId = this.GetPhantomInstanceWithSkinId();
		return PhantomBattleConfig.Instance.GetPhantomSkillBySkillId(phantomInstanceWithSkinId.PhantomItem.Value.SkillId);
	}

	// Token: 0x06012694 RID: 75412 RVA: 0x0048A034 File Offset: 0x00488234
	public int GetNormalSkillId()
	{
		return this.GetPhantomInstanceWithSkinId().PhantomItem.Value.SkillId;
	}

	// Token: 0x06012695 RID: 75413 RVA: 0x0048A05C File Offset: 0x0048825C
	public int GetPersonalSkillId()
	{
		return 0;
	}

	// Token: 0x06012696 RID: 75414 RVA: 0x0048A060 File Offset: 0x00488260
	public PhantomBattleInstance GetPhantomInstanceWithSkinId()
	{
		int skinId = this.SkinId;
		if (skinId != 0)
		{
			return PhantomBattleModel.Instance.GetPhantomInstanceByItemId(skinId);
		}
		return this.GetPhantomInstance();
	}

	// Token: 0x06012697 RID: 75415 RVA: 0x0048A089 File Offset: 0x00488289
	private PhantomBattleInstance GetPhantomInstance()
	{
		return PhantomBattleModel.Instance.GetPhantomInstanceByItemId(this.GetConfigId(false));
	}

	// Token: 0x06012698 RID: 75416 RVA: 0x0048A09C File Offset: 0x0048829C
	public List<AttrListScrollData> GetLevelUpPreviewData(int targetLevel)
	{
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		Dictionary<int, int> mainPropValueMapInTargetLevel = this.GetMainPropValueMapInTargetLevel(targetLevel);
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in this.PhantomMainProp)
		{
			dictionary[phantomPropInfo.PhantomPropId] = phantomPropInfo.Value;
		}
		foreach (KeyValuePair<int, int> keyValuePair in mainPropValueMapInTargetLevel)
		{
			int key = keyValuePair.Key;
			double value = (double)keyValuePair.Value;
			int num;
			if (!dictionary.TryGetValue(key, out num))
			{
				num = 0;
			}
			PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(key);
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(phantomMainPropertyItemId.PropId);
			bool isRatio = phantomMainPropertyItemId.AddType == 2;
			double propRatioValue = TipsDataTool.GetPropRatioValue((double)num, isRatio);
			double propRatioValue2 = TipsDataTool.GetPropRatioValue(value, isRatio);
			list.Add(new AttrListScrollData(phantomMainPropertyItemId.PropId, propRatioValue, propRatioValue2, propertyIndexInfo.Value.Priority, isRatio, CommonComponentDefine.EAttributeType.PhantomType));
		}
		return list;
	}

	// Token: 0x06012699 RID: 75417 RVA: 0x0048A1DC File Offset: 0x004883DC
	public List<Aki.Protocol.PhantomPropInfo> GetPhantomMainProp()
	{
		return this.PhantomMainProp;
	}

	// Token: 0x0601269A RID: 75418 RVA: 0x0048A1E4 File Offset: 0x004883E4
	public Aki.Protocol.PhantomPropInfo GetPhantomFirstMainProp()
	{
		return this.PhantomMainProp[0];
	}

	// Token: 0x0601269B RID: 75419 RVA: 0x0048A1F4 File Offset: 0x004883F4
	public Dictionary<int, int> GetMainPropValueMapInTargetLevel(int level)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in this.GetPhantomMainProp())
		{
			PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(phantomPropInfo.PhantomPropId);
			int phantomGrowthValueByGrowthIdAndLevel = PhantomBattleConfig.Instance.GetPhantomGrowthValueByGrowthIdAndLevel(phantomMainPropertyItemId.GrowthId, level);
			double attributeValue = TipsDataTool.GetAttributeValue((double)phantomMainPropertyItemId.StandardProperty, (double)phantomGrowthValueByGrowthIdAndLevel, false);
			dictionary[phantomPropInfo.PhantomPropId] = (int)Math.Floor(attributeValue);
		}
		return dictionary;
	}

	// Token: 0x0601269C RID: 75420 RVA: 0x0048A294 File Offset: 0x00488494
	public List<Aki.Protocol.PhantomPropInfo> GetPhantomSubProp()
	{
		return this.PhantomSubProp;
	}

	// Token: 0x0601269D RID: 75421 RVA: 0x0048A29C File Offset: 0x0048849C
	public List<Aki.Protocol.PhantomPropInfo> GetUnAckSubProp()
	{
		return this.UnAckSubProp;
	}

	// Token: 0x0601269E RID: 75422 RVA: 0x0048A2A4 File Offset: 0x004884A4
	public List<int> GetLockSubPropIndices()
	{
		return this.LockSubPropIndices;
	}

	// Token: 0x0601269F RID: 75423 RVA: 0x0048A2AC File Offset: 0x004884AC
	public void SetConfigId(int itemId)
	{
		this.ItemId = itemId;
	}

	// Token: 0x060126A0 RID: 75424 RVA: 0x0048A2B5 File Offset: 0x004884B5
	public void SetSkinId(int skinId)
	{
		this.SkinIdInternal = skinId;
	}

	// Token: 0x170017D3 RID: 6099
	// (get) Token: 0x060126A1 RID: 75425 RVA: 0x0048A2BE File Offset: 0x004884BE
	public int SkinId
	{
		get
		{
			return this.SkinIdInternal;
		}
	}

	// Token: 0x060126A2 RID: 75426 RVA: 0x0048A2C8 File Offset: 0x004884C8
	public int GetConfigId(bool useSkin = false)
	{
		int skinId = this.SkinId;
		if (useSkin && skinId != 0)
		{
			return skinId;
		}
		return this.ItemId;
	}

	// Token: 0x060126A3 RID: 75427 RVA: 0x0048A2EA File Offset: 0x004884EA
	public Aki.Config.PhantomItem GetConfig()
	{
		if (this.ConfigCache == null)
		{
			this.ConfigCache = PhantomBattleConfig.Instance.GetPhantomItemById(this.ItemId);
		}
		return this.ConfigCache.Value;
	}

	// Token: 0x060126A4 RID: 75428 RVA: 0x0048A31C File Offset: 0x0048851C
	public Aki.Config.PhantomItem GetSkinConfig()
	{
		int skinId = this.SkinId;
		if (skinId != 0)
		{
			return PhantomBattleConfig.Instance.GetPhantomItemById(skinId).Value;
		}
		return this.GetConfig();
	}

	// Token: 0x060126A5 RID: 75429 RVA: 0x0048A350 File Offset: 0x00488550
	public Aki.Config.MonsterInfo? GetMonsterConfig()
	{
		Aki.Config.MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(this.GetMonsterId(false));
		if (monsterInfoConfig == null)
		{
			return null;
		}
		return monsterInfoConfig;
	}

	// Token: 0x060126A6 RID: 75430 RVA: 0x0048A384 File Offset: 0x00488584
	public int GetLevelLimit()
	{
		return PhantomBattleConfig.Instance.GetPhantomQualityByItemQuality(this.GetQuality()).Value.LevelLimit;
	}

	// Token: 0x060126A7 RID: 75431 RVA: 0x0048A3B4 File Offset: 0x004885B4
	public int GetQuality()
	{
		return this.GetConfig().QualityId;
	}

	// Token: 0x060126A8 RID: 75432 RVA: 0x0048A3D0 File Offset: 0x004885D0
	public int GetMonsterId(bool useSkin = false)
	{
		if (useSkin && this.SkinId != 0)
		{
			return this.GetSkinConfig().MonsterId;
		}
		return this.GetConfig().MonsterId;
	}

	// Token: 0x060126A9 RID: 75433 RVA: 0x0048A408 File Offset: 0x00488608
	public string GetMonsterName()
	{
		if (this.SkinId != 0)
		{
			return this.GetSkinConfig().MonsterName;
		}
		return this.GetConfig().MonsterName;
	}

	// Token: 0x060126AA RID: 75434 RVA: 0x0048A43C File Offset: 0x0048863C
	public AttrListScrollData GetFirstMainPropAttribute(CommonComponentDefine.EAttributeType attributeType, bool needAddType = false)
	{
		int phantomPropId = this.PhantomMainProp[0].PhantomPropId;
		double value = (double)this.PhantomMainProp[0].Value;
		PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(phantomPropId);
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(phantomMainPropertyItemId.PropId);
		double propRatioValue = TipsDataTool.GetPropRatioValue(value, phantomMainPropertyItemId.AddType == 2);
		return new AttrListScrollData(phantomMainPropertyItemId.PropId, propRatioValue, (double)((!needAddType) ? 0 : phantomMainPropertyItemId.AddType), propertyIndexInfo.Value.Priority, phantomMainPropertyItemId.AddType == 2, attributeType);
	}

	// Token: 0x060126AB RID: 75435 RVA: 0x0048A4D4 File Offset: 0x004886D4
	public List<AttrListScrollData> GetMainPropShowAttributeList(CommonComponentDefine.EAttributeType attributeType, bool needAddType = false)
	{
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in this.PhantomMainProp)
		{
			dictionary[phantomPropInfo.PhantomPropId] = phantomPropInfo.Value;
		}
		List<int> list2 = new List<int>(dictionary.Keys);
		int count = list2.Count;
		for (int i = 0; i < count; i++)
		{
			PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(list2[i]);
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(phantomMainPropertyItemId.PropId);
			double propRatioValue = TipsDataTool.GetPropRatioValue((double)dictionary[list2[i]], phantomMainPropertyItemId.AddType == 2);
			list.Add(new AttrListScrollData(phantomMainPropertyItemId.PropId, propRatioValue, (double)((!needAddType) ? 0 : phantomMainPropertyItemId.AddType), propertyIndexInfo.Value.Priority, phantomMainPropertyItemId.AddType == 2, attributeType));
		}
		return list;
	}

	// Token: 0x060126AC RID: 75436 RVA: 0x0048A5F0 File Offset: 0x004887F0
	public List<AttrListScrollData> GetSubPropShowAttributeList(CommonComponentDefine.EAttributeType attributeType)
	{
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in this.PhantomSubProp)
		{
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(phantomPropInfo.PhantomPropId);
			PhantomSubProperty phantomSubPropertyById = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(phantomPropInfo.PhantomPropId);
			bool isRatio = phantomSubPropertyById.AddType == 2;
			double propRatioValue = TipsDataTool.GetPropRatioValue((double)phantomPropInfo.Value, isRatio);
			list.Add(new AttrListScrollData(phantomSubPropertyById.PropId, propRatioValue, 0.0, propertyIndexInfo.Value.Priority, phantomSubPropertyById.AddType == 2, attributeType));
		}
		return list;
	}

	// Token: 0x060126AD RID: 75437 RVA: 0x0048A6C0 File Offset: 0x004888C0
	public bool CheckIfHaveSelectRecommendMainAttr()
	{
		List<VisionSelectRecommendData> currentSelectMainAttrArray = VisionRecommendModel.Instance.CurrentSelectMainAttrArray;
		if (currentSelectMainAttrArray.Count == 0)
		{
			return true;
		}
		foreach (VisionSelectRecommendData visionSelectRecommendData in currentSelectMainAttrArray)
		{
			foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in this.PhantomMainProp)
			{
				PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(phantomPropInfo.PhantomPropId);
				if (phantomMainPropertyItemId.AddType == visionSelectRecommendData.AddType && phantomMainPropertyItemId.PropId == visionSelectRecommendData.AttrId)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060126AE RID: 75438 RVA: 0x0048A794 File Offset: 0x00488994
	public bool CheckIfHaveSelectRecommendSubAttr()
	{
		foreach (VisionSelectRecommendData visionSelectRecommendData in VisionRecommendModel.Instance.CurrentSelectSubAttrArray)
		{
			bool flag = false;
			foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in this.PhantomSubProp)
			{
				PhantomSubProperty phantomSubPropertyById = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(phantomPropInfo.PhantomPropId);
				if (phantomSubPropertyById.AddType == visionSelectRecommendData.AddType && phantomSubPropertyById.PropId == visionSelectRecommendData.AttrId)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060126AF RID: 75439 RVA: 0x0048A864 File Offset: 0x00488A64
	public bool CheckIfHaveSelectMainPhantomType()
	{
		VisionMainSelectPhantomData currentMainPhantom = VisionRecommendModel.Instance.CurrentMainPhantom;
		return currentMainPhantom == null || (this.FetterGroupId == currentMainPhantom.FetterGroupId && this.GetMonsterId(false) == currentMainPhantom.MonsterId);
	}

	// Token: 0x060126B0 RID: 75440 RVA: 0x0048A8A0 File Offset: 0x00488AA0
	public List<AttrListScrollData> GetPropShowAttributeList(CommonComponentDefine.EAttributeType attributeType)
	{
		List<AttrListScrollData> list = new List<AttrListScrollData>();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in this.PhantomMainProp)
		{
			dictionary[phantomPropInfo.PhantomPropId] = phantomPropInfo.Value;
		}
		Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
		foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo2 in this.PhantomSubProp)
		{
			dictionary2[phantomPropInfo2.PhantomPropId] = phantomPropInfo2.Value;
			if (!dictionary.ContainsKey(phantomPropInfo2.PhantomPropId))
			{
				dictionary[phantomPropInfo2.PhantomPropId] = 0;
			}
		}
		List<int> list2 = new List<int>(dictionary.Keys);
		int count = list2.Count;
		for (int i = 0; i < count; i++)
		{
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(list2[i]);
			int num;
			if (!dictionary2.TryGetValue(list2[i], out num))
			{
				num = 0;
			}
			list.Add(new AttrListScrollData(list2[i], (double)dictionary[list2[i]], (double)num, propertyIndexInfo.Value.Priority, false, attributeType));
		}
		return list;
	}

	// Token: 0x060126B1 RID: 75441 RVA: 0x0048AA08 File Offset: 0x00488C08
	protected static int? GetPropValue(IPhantomPropInfo prop, bool ifSub)
	{
		return prop.Value;
	}

	// Token: 0x060126B2 RID: 75442
	public abstract bool IsBreach();

	// Token: 0x04008B36 RID: 35638
	protected List<Aki.Protocol.PhantomPropInfo> PhantomMainProp = new List<Aki.Protocol.PhantomPropInfo>();

	// Token: 0x04008B37 RID: 35639
	protected List<Aki.Protocol.PhantomPropInfo> PhantomSubProp = new List<Aki.Protocol.PhantomPropInfo>();

	// Token: 0x04008B38 RID: 35640
	protected List<Aki.Protocol.PhantomPropInfo> UnAckSubProp = new List<Aki.Protocol.PhantomPropInfo>();

	// Token: 0x04008B39 RID: 35641
	protected List<int> LockSubPropIndices = new List<int>();

	// Token: 0x04008B3A RID: 35642
	protected int PhantomLevel;

	// Token: 0x04008B3B RID: 35643
	protected int PhantomExp;

	// Token: 0x04008B3C RID: 35644
	protected int ItemId;

	// Token: 0x04008B3D RID: 35645
	protected int FuncValue;

	// Token: 0x04008B3E RID: 35646
	[Nullable(2)]
	protected PhantomPropSlot SuspendSlot;

	// Token: 0x04008B3F RID: 35647
	private int IncrId;

	// Token: 0x04008B40 RID: 35648
	protected int FetterGroupId;

	// Token: 0x04008B41 RID: 35649
	private int SkinIdInternal;

	// Token: 0x04008B42 RID: 35650
	private Aki.Config.PhantomItem? ConfigCache;
}
