using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using Google.Protobuf.Collections;

// Token: 0x020018DC RID: 6364
[NullableContext(1)]
[Nullable(0)]
public abstract class PhantomDataBase
{
	// Token: 0x0600FAF9 RID: 64249 RVA: 0x00496072 File Offset: 0x00494272
	public void SetPhantomLevel(int level)
	{
		this.PhantomLevel = level;
	}

	// Token: 0x0600FAFA RID: 64250 RVA: 0x0049607B File Offset: 0x0049427B
	public static int GenerateLocalUniqueId(int roleId, int slotIndex)
	{
		return -1 * (roleId * 10) - slotIndex;
	}

	// Token: 0x0600FAFB RID: 64251 RVA: 0x00496085 File Offset: 0x00494285
	public void SetIncId(int id)
	{
		this.IncrId = id;
	}

	// Token: 0x0600FAFC RID: 64252 RVA: 0x0049608E File Offset: 0x0049428E
	public int GetPhantomLevel()
	{
		return this.PhantomLevel;
	}

	// Token: 0x0600FAFD RID: 64253 RVA: 0x00496096 File Offset: 0x00494296
	public bool GetVisionNoCultivated()
	{
		return this.GetPhantomLevel() == 0 && this.GetExp() == 0;
	}

	// Token: 0x0600FAFE RID: 64254 RVA: 0x004960AB File Offset: 0x004942AB
	public bool GetVisionIfCanRecovery(bool onlyGold)
	{
		return (!onlyGold || this.GetQuality() >= 5) && this.GetVisionNoCultivated() && !this.GetIsLock();
	}

	// Token: 0x0600FAFF RID: 64255 RVA: 0x004960CE File Offset: 0x004942CE
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

	// Token: 0x0600FB00 RID: 64256 RVA: 0x004960FE File Offset: 0x004942FE
	public bool IsMax()
	{
		return this.PhantomLevel >= PhantomBattleController.Instance.GetMaxLevel(this.IncrId);
	}

	// Token: 0x0600FB01 RID: 64257 RVA: 0x0049611B File Offset: 0x0049431B
	public void SetPhantomExp(int exp)
	{
		this.PhantomExp = exp;
	}

	// Token: 0x0600FB02 RID: 64258 RVA: 0x00496124 File Offset: 0x00494324
	public PhantomBattleInstance CurrentPhantomInstance()
	{
		return this.GetPhantomInstanceWithSkinId();
	}

	// Token: 0x0600FB03 RID: 64259 RVA: 0x0049612C File Offset: 0x0049432C
	[NullableContext(2)]
	public PhantomPropSlot GetCurrentSuspendSlotData()
	{
		return this.SuspendSlot;
	}

	// Token: 0x0600FB04 RID: 64260 RVA: 0x00496134 File Offset: 0x00494334
	public virtual int GetFetterGroupId()
	{
		return this.FetterGroupId;
	}

	// Token: 0x0600FB05 RID: 64261 RVA: 0x0049613C File Offset: 0x0049433C
	public int GetEatFullExp()
	{
		int value = ConfigCommonParamById.GetIntConfig("PhantomExpReturnRatio").Value;
		return (int)Math.Floor((double)(this.GetFullExp() * value) / 1000.0);
	}

	// Token: 0x0600FB06 RID: 64262 RVA: 0x00496178 File Offset: 0x00494378
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

	// Token: 0x0600FB07 RID: 64263 RVA: 0x004961D8 File Offset: 0x004943D8
	public int GetExp()
	{
		return this.PhantomExp;
	}

	// Token: 0x0600FB08 RID: 64264 RVA: 0x004961E0 File Offset: 0x004943E0
	public void UpdateData(Aki.Protocol.PhantomItem data)
	{
		this.IncrId = data.IncrId;
		this.FuncValue = data.FuncValue;
		this.PhantomLevel = data.PhantomLevel;
		this.PhantomExp = data.PhantomExp;
		this.PhantomMainProp = new List<Aki.Protocol.PhantomPropInfo>(data.PhantomMainProp);
		this.PhantomSubProp = new List<Aki.Protocol.PhantomPropInfo>(data.PhantomSubProp);
		this.FetterGroupId = data.FetterGroupId;
		this.SkinIdInternal = data.SkinId;
		this.UnAckSubProp = new List<Aki.Protocol.PhantomPropInfo>(data.UnAckSubProp);
		this.LockSubPropIndices = new List<int>(data.LockPropIndex);
	}

	// Token: 0x0600FB09 RID: 64265 RVA: 0x00496279 File Offset: 0x00494479
	public void SetMainProp(List<Aki.Protocol.PhantomPropInfo> data)
	{
		this.PhantomMainProp = data;
	}

	// Token: 0x0600FB0A RID: 64266 RVA: 0x00496282 File Offset: 0x00494482
	public void SetSubProp(List<Aki.Protocol.PhantomPropInfo> data)
	{
		this.PhantomSubProp = data;
	}

	// Token: 0x0600FB0B RID: 64267 RVA: 0x0049628B File Offset: 0x0049448B
	public int GetIncrId()
	{
		return this.IncrId;
	}

	// Token: 0x0600FB0C RID: 64268 RVA: 0x00496293 File Offset: 0x00494493
	public void OnFunctionValueChange(int value)
	{
		this.FuncValue = value;
	}

	// Token: 0x0600FB0D RID: 64269 RVA: 0x0049629C File Offset: 0x0049449C
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

	// Token: 0x0600FB0E RID: 64270 RVA: 0x00496360 File Offset: 0x00494560
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

	// Token: 0x0600FB0F RID: 64271 RVA: 0x004963F0 File Offset: 0x004945F0
	public bool IsFunctionValue(InventoryDefine.EItemDataFunctionType functionType)
	{
		return (this.FuncValue & 1 << (int)functionType) > 0;
	}

	// Token: 0x0600FB10 RID: 64272 RVA: 0x00496402 File Offset: 0x00494602
	public bool GetIsLock()
	{
		return this.IsFunctionValue(InventoryDefine.EItemDataFunctionType.Lock);
	}

	// Token: 0x0600FB11 RID: 64273 RVA: 0x0049640B File Offset: 0x0049460B
	public bool GetIsDeprecated()
	{
		return this.IsFunctionValue(InventoryDefine.EItemDataFunctionType.Deprecate);
	}

	// Token: 0x0600FB12 RID: 64274 RVA: 0x00496414 File Offset: 0x00494614
	public int GetEquipRoleId()
	{
		return PhantomBattleModel.Instance.GetPhantomEquipOnRoleId(this.GetIncrId()).GetValueOrDefault();
	}

	// Token: 0x0600FB13 RID: 64275 RVA: 0x0049643C File Offset: 0x0049463C
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

	// Token: 0x0600FB14 RID: 64276 RVA: 0x00496484 File Offset: 0x00494684
	public string GetNameColor()
	{
		return CSharpScript.Game.Module.Item.ItemConfig.Instance.GetQualityConfig(this.GetQuality()).Value.DropColor;
	}

	// Token: 0x0600FB15 RID: 64277 RVA: 0x004964B4 File Offset: 0x004946B4
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

	// Token: 0x0600FB16 RID: 64278 RVA: 0x00496578 File Offset: 0x00494778
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

	// Token: 0x0600FB17 RID: 64279 RVA: 0x00496618 File Offset: 0x00494818
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

	// Token: 0x0600FB18 RID: 64280 RVA: 0x004966A0 File Offset: 0x004948A0
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

	// Token: 0x0600FB19 RID: 64281 RVA: 0x004966FC File Offset: 0x004948FC
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

	// Token: 0x0600FB1A RID: 64282 RVA: 0x00496894 File Offset: 0x00494A94
	public List<VisionAttributeVariantTwoData> GetPreviewCurrentShowFetterList()
	{
		return new List<VisionAttributeVariantTwoData>();
	}

	// Token: 0x0600FB1B RID: 64283 RVA: 0x0049689C File Offset: 0x00494A9C
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

	// Token: 0x0600FB1C RID: 64284 RVA: 0x00496970 File Offset: 0x00494B70
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

	// Token: 0x0600FB1D RID: 64285 RVA: 0x004969A2 File Offset: 0x00494BA2
	public int[] GetCanActiveFetterList()
	{
		return PhantomBattleModel.Instance.GetTargetCanActiveFettersList(this.GetIncrId());
	}

	// Token: 0x0600FB1E RID: 64286 RVA: 0x004969B4 File Offset: 0x00494BB4
	public int[] GetDelFetterList(int index, int roleId)
	{
		return PhantomBattleModel.Instance.GetPreviewFettersDel(this, index, roleId);
	}

	// Token: 0x0600FB1F RID: 64287 RVA: 0x004969C3 File Offset: 0x00494BC3
	public int[] GetAddFetterList(int index, int roleId)
	{
		return PhantomBattleModel.Instance.GetPreviewFetterAdd(this, index, roleId);
	}

	// Token: 0x0600FB20 RID: 64288 RVA: 0x004969D2 File Offset: 0x00494BD2
	public PhantomFetterGroup GetFetterGroupConfig()
	{
		return PhantomBattleConfig.Instance.GetFetterGroupById(this.GetFetterGroupId());
	}

	// Token: 0x0600FB21 RID: 64289 RVA: 0x004969E4 File Offset: 0x00494BE4
	public bool GetIsFetterGroupSpecial()
	{
		return this.GetFetterGroupConfig().FetterType == 1;
	}

	// Token: 0x0600FB22 RID: 64290 RVA: 0x00496A04 File Offset: 0x00494C04
	public int GetCost()
	{
		int rarity = this.GetConfig().Rarity;
		return PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity).Value.Cost;
	}

	// Token: 0x0600FB23 RID: 64291 RVA: 0x00496A3C File Offset: 0x00494C3C
	public PhantomRarity? GetRareConfig()
	{
		int rarity = this.GetConfig().Rarity;
		return PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity);
	}

	// Token: 0x0600FB24 RID: 64292 RVA: 0x00496A64 File Offset: 0x00494C64
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

	// Token: 0x0600FB25 RID: 64293 RVA: 0x00496B74 File Offset: 0x00494D74
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

	// Token: 0x0600FB26 RID: 64294 RVA: 0x00496B9C File Offset: 0x00494D9C
	public int GetMaxSubPropCount()
	{
		int quality = this.GetQuality();
		return PhantomBattleConfig.Instance.GetPhantomSlotUnlockLevel(quality).Length;
	}

	// Token: 0x0600FB27 RID: 64295 RVA: 0x00496BC0 File Offset: 0x00494DC0
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

	// Token: 0x0600FB28 RID: 64296 RVA: 0x00496C14 File Offset: 0x00494E14
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

	// Token: 0x0600FB29 RID: 64297 RVA: 0x00496C70 File Offset: 0x00494E70
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

	// Token: 0x0600FB2A RID: 64298 RVA: 0x00496CED File Offset: 0x00494EED
	public int GetIdentifyCostItemId()
	{
		return 2;
	}

	// Token: 0x0600FB2B RID: 64299 RVA: 0x00496CF0 File Offset: 0x00494EF0
	public int GetIdentifyCostItemValue()
	{
		return PhantomBattleConfig.Instance.GetQualityIdentifyCost(this.GetQuality());
	}

	// Token: 0x0600FB2C RID: 64300 RVA: 0x00496D04 File Offset: 0x00494F04
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

	// Token: 0x0600FB2D RID: 64301 RVA: 0x00496D80 File Offset: 0x00494F80
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

	// Token: 0x0600FB2E RID: 64302 RVA: 0x00496DE0 File Offset: 0x00494FE0
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

	// Token: 0x0600FB2F RID: 64303 RVA: 0x00496E28 File Offset: 0x00495028
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

	// Token: 0x0600FB30 RID: 64304 RVA: 0x00496E70 File Offset: 0x00495070
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

	// Token: 0x0600FB31 RID: 64305 RVA: 0x00496ED8 File Offset: 0x004950D8
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

	// Token: 0x0600FB32 RID: 64306 RVA: 0x00496F30 File Offset: 0x00495130
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

	// Token: 0x0600FB33 RID: 64307 RVA: 0x00496F88 File Offset: 0x00495188
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

	// Token: 0x0600FB34 RID: 64308 RVA: 0x00497078 File Offset: 0x00495278
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

	// Token: 0x0600FB35 RID: 64309 RVA: 0x004970AC File Offset: 0x004952AC
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

	// Token: 0x0600FB36 RID: 64310 RVA: 0x0049711C File Offset: 0x0049531C
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

	// Token: 0x0600FB37 RID: 64311 RVA: 0x0049717C File Offset: 0x0049537C
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

	// Token: 0x0600FB38 RID: 64312 RVA: 0x004971DC File Offset: 0x004953DC
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

	// Token: 0x0600FB39 RID: 64313 RVA: 0x0049720C File Offset: 0x0049540C
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

	// Token: 0x0600FB3A RID: 64314 RVA: 0x00497268 File Offset: 0x00495468
	public int GetSlotUnlockLevel(int index)
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("PhantomSlotUnlockLevel");
		if (intArrayConfig.Count < index)
		{
			return 9999;
		}
		return intArrayConfig[index];
	}

	// Token: 0x0600FB3B RID: 64315 RVA: 0x00497296 File Offset: 0x00495496
	public bool GetSlotLockState(int index)
	{
		return this.GetPhantomLevel() < this.GetSlotUnlockLevel(index);
	}

	// Token: 0x0600FB3C RID: 64316 RVA: 0x004972AC File Offset: 0x004954AC
	public float GetIdentifyBackRadio()
	{
		return (float)ConfigCommonParamById.GetIntConfig("PhantomIdentifyReturnRatio").Value / 1000f;
	}

	// Token: 0x0600FB3D RID: 64317 RVA: 0x004972D2 File Offset: 0x004954D2
	public int GetCurrentIdentifyNum()
	{
		return this.PhantomSubProp.Count;
	}

	// Token: 0x0600FB3E RID: 64318 RVA: 0x004972E0 File Offset: 0x004954E0
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

	// Token: 0x0600FB3F RID: 64319 RVA: 0x00497328 File Offset: 0x00495528
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

	// Token: 0x0600FB40 RID: 64320 RVA: 0x00497398 File Offset: 0x00495598
	public List<VisionSlotData> GetCurrentSlotData()
	{
		return this.GetLevelSlotData(this.GetPhantomLevel());
	}

	// Token: 0x0600FB41 RID: 64321 RVA: 0x004973A8 File Offset: 0x004955A8
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

	// Token: 0x0600FB42 RID: 64322 RVA: 0x0049743C File Offset: 0x0049563C
	public int GetCurrentSkillId()
	{
		return this.GetPhantomInstanceWithSkinId().PhantomItem.Value.SkillId;
	}

	// Token: 0x0600FB43 RID: 64323 RVA: 0x00497464 File Offset: 0x00495664
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] GetSkillDescExParam(int skillId)
	{
		return PhantomBattleConfig.Instance.GetPhantomSkillDescExBySkillIdAndQuality(skillId, this.GetQuality());
	}

	// Token: 0x0600FB44 RID: 64324 RVA: 0x00497478 File Offset: 0x00495678
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

	// Token: 0x0600FB45 RID: 64325 RVA: 0x00497508 File Offset: 0x00495708
	public PhantomSkill? GetNormalSkillConfig()
	{
		PhantomBattleInstance phantomInstanceWithSkinId = this.GetPhantomInstanceWithSkinId();
		return PhantomBattleConfig.Instance.GetPhantomSkillBySkillId(phantomInstanceWithSkinId.PhantomItem.Value.SkillId);
	}

	// Token: 0x0600FB46 RID: 64326 RVA: 0x0049753C File Offset: 0x0049573C
	public int GetNormalSkillId()
	{
		return this.GetPhantomInstanceWithSkinId().PhantomItem.Value.SkillId;
	}

	// Token: 0x0600FB47 RID: 64327 RVA: 0x00497564 File Offset: 0x00495764
	public int GetPersonalSkillId()
	{
		return 0;
	}

	// Token: 0x0600FB48 RID: 64328 RVA: 0x00497568 File Offset: 0x00495768
	public PhantomBattleInstance GetPhantomInstanceWithSkinId()
	{
		int skinId = this.SkinId;
		if (skinId != 0)
		{
			return PhantomBattleModel.Instance.GetPhantomInstanceByItemId(skinId);
		}
		return this.GetPhantomInstance();
	}

	// Token: 0x0600FB49 RID: 64329 RVA: 0x00497591 File Offset: 0x00495791
	private PhantomBattleInstance GetPhantomInstance()
	{
		return PhantomBattleModel.Instance.GetPhantomInstanceByItemId(this.GetConfigId(false));
	}

	// Token: 0x0600FB4A RID: 64330 RVA: 0x004975A4 File Offset: 0x004957A4
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

	// Token: 0x0600FB4B RID: 64331 RVA: 0x004976E4 File Offset: 0x004958E4
	public List<Aki.Protocol.PhantomPropInfo> GetPhantomMainProp()
	{
		return this.PhantomMainProp;
	}

	// Token: 0x0600FB4C RID: 64332 RVA: 0x004976EC File Offset: 0x004958EC
	public Aki.Protocol.PhantomPropInfo GetPhantomFirstMainProp()
	{
		return this.PhantomMainProp[0];
	}

	// Token: 0x0600FB4D RID: 64333 RVA: 0x004976FC File Offset: 0x004958FC
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

	// Token: 0x0600FB4E RID: 64334 RVA: 0x0049779C File Offset: 0x0049599C
	public List<Aki.Protocol.PhantomPropInfo> GetPhantomSubProp()
	{
		return this.PhantomSubProp;
	}

	// Token: 0x0600FB4F RID: 64335 RVA: 0x004977A4 File Offset: 0x004959A4
	public List<Aki.Protocol.PhantomPropInfo> GetUnAckSubProp()
	{
		return this.UnAckSubProp;
	}

	// Token: 0x0600FB50 RID: 64336 RVA: 0x004977AC File Offset: 0x004959AC
	public List<int> GetLockSubPropIndices()
	{
		return this.LockSubPropIndices;
	}

	// Token: 0x0600FB51 RID: 64337 RVA: 0x004977B4 File Offset: 0x004959B4
	public void SetConfigId(int itemId)
	{
		this.ItemId = itemId;
	}

	// Token: 0x0600FB52 RID: 64338 RVA: 0x004977BD File Offset: 0x004959BD
	public void SetSkinId(int skinId)
	{
		this.SkinIdInternal = skinId;
	}

	// Token: 0x1700180D RID: 6157
	// (get) Token: 0x0600FB53 RID: 64339 RVA: 0x004977C6 File Offset: 0x004959C6
	public int SkinId
	{
		get
		{
			return this.SkinIdInternal;
		}
	}

	// Token: 0x0600FB54 RID: 64340 RVA: 0x004977D0 File Offset: 0x004959D0
	public int GetConfigId(bool useSkin = false)
	{
		int skinId = this.SkinId;
		if (useSkin && skinId != 0)
		{
			return skinId;
		}
		return this.ItemId;
	}

	// Token: 0x0600FB55 RID: 64341 RVA: 0x004977F2 File Offset: 0x004959F2
	public Aki.Config.PhantomItem GetConfig()
	{
		if (this.ConfigCache == null)
		{
			this.ConfigCache = PhantomBattleConfig.Instance.GetPhantomItemById(this.ItemId);
		}
		return this.ConfigCache.Value;
	}

	// Token: 0x0600FB56 RID: 64342 RVA: 0x00497824 File Offset: 0x00495A24
	public Aki.Config.PhantomItem GetSkinConfig()
	{
		int skinId = this.SkinId;
		if (skinId != 0)
		{
			return PhantomBattleConfig.Instance.GetPhantomItemById(skinId).Value;
		}
		return this.GetConfig();
	}

	// Token: 0x0600FB57 RID: 64343 RVA: 0x00497858 File Offset: 0x00495A58
	public Aki.Config.MonsterInfo? GetMonsterConfig()
	{
		Aki.Config.MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(this.GetMonsterId(false));
		if (monsterInfoConfig == null)
		{
			return null;
		}
		return monsterInfoConfig;
	}

	// Token: 0x0600FB58 RID: 64344 RVA: 0x0049788C File Offset: 0x00495A8C
	public int GetLevelLimit()
	{
		return PhantomBattleConfig.Instance.GetPhantomQualityByItemQuality(this.GetQuality()).Value.LevelLimit;
	}

	// Token: 0x0600FB59 RID: 64345 RVA: 0x004978BC File Offset: 0x00495ABC
	public int GetQuality()
	{
		return this.GetConfig().QualityId;
	}

	// Token: 0x0600FB5A RID: 64346 RVA: 0x004978D8 File Offset: 0x00495AD8
	public int GetMonsterId(bool useSkin = false)
	{
		if (useSkin && this.SkinId != 0)
		{
			return this.GetSkinConfig().MonsterId;
		}
		return this.GetConfig().MonsterId;
	}

	// Token: 0x0600FB5B RID: 64347 RVA: 0x00497910 File Offset: 0x00495B10
	public string GetMonsterName()
	{
		if (this.SkinId != 0)
		{
			return this.GetSkinConfig().MonsterName;
		}
		return this.GetConfig().MonsterName;
	}

	// Token: 0x0600FB5C RID: 64348 RVA: 0x00497944 File Offset: 0x00495B44
	public AttrListScrollData GetFirstMainPropAttribute(CommonComponentDefine.EAttributeType attributeType, bool needAddType = false)
	{
		int phantomPropId = this.PhantomMainProp[0].PhantomPropId;
		double value = (double)this.PhantomMainProp[0].Value;
		PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(phantomPropId);
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(phantomMainPropertyItemId.PropId);
		double propRatioValue = TipsDataTool.GetPropRatioValue(value, phantomMainPropertyItemId.AddType == 2);
		return new AttrListScrollData(phantomMainPropertyItemId.PropId, propRatioValue, (double)((!needAddType) ? 0 : phantomMainPropertyItemId.AddType), propertyIndexInfo.Value.Priority, phantomMainPropertyItemId.AddType == 2, attributeType);
	}

	// Token: 0x0600FB5D RID: 64349 RVA: 0x004979DC File Offset: 0x00495BDC
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

	// Token: 0x0600FB5E RID: 64350 RVA: 0x00497AF8 File Offset: 0x00495CF8
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

	// Token: 0x0600FB5F RID: 64351 RVA: 0x00497BC8 File Offset: 0x00495DC8
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

	// Token: 0x0600FB60 RID: 64352 RVA: 0x00497C9C File Offset: 0x00495E9C
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

	// Token: 0x0600FB61 RID: 64353 RVA: 0x00497D6C File Offset: 0x00495F6C
	public bool CheckIfHaveSelectMainPhantomType()
	{
		VisionMainSelectPhantomData currentMainPhantom = VisionRecommendModel.Instance.CurrentMainPhantom;
		return currentMainPhantom == null || (this.FetterGroupId == currentMainPhantom.FetterGroupId && this.GetMonsterId(false) == currentMainPhantom.MonsterId);
	}

	// Token: 0x0600FB62 RID: 64354 RVA: 0x00497DA8 File Offset: 0x00495FA8
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

	// Token: 0x0600FB63 RID: 64355 RVA: 0x00497F10 File Offset: 0x00496110
	protected static int? GetPropValue(IPhantomPropInfo prop, bool ifSub)
	{
		return prop.Value;
	}

	// Token: 0x0600FB64 RID: 64356
	public abstract bool IsBreach();

	// Token: 0x04008C7D RID: 35965
	protected List<Aki.Protocol.PhantomPropInfo> PhantomMainProp = new List<Aki.Protocol.PhantomPropInfo>();

	// Token: 0x04008C7E RID: 35966
	protected List<Aki.Protocol.PhantomPropInfo> PhantomSubProp = new List<Aki.Protocol.PhantomPropInfo>();

	// Token: 0x04008C7F RID: 35967
	protected List<Aki.Protocol.PhantomPropInfo> UnAckSubProp = new List<Aki.Protocol.PhantomPropInfo>();

	// Token: 0x04008C80 RID: 35968
	protected List<int> LockSubPropIndices = new List<int>();

	// Token: 0x04008C81 RID: 35969
	protected int PhantomLevel;

	// Token: 0x04008C82 RID: 35970
	protected int PhantomExp;

	// Token: 0x04008C83 RID: 35971
	protected int ItemId;

	// Token: 0x04008C84 RID: 35972
	protected int FuncValue;

	// Token: 0x04008C85 RID: 35973
	[Nullable(2)]
	protected PhantomPropSlot SuspendSlot;

	// Token: 0x04008C86 RID: 35974
	private int IncrId;

	// Token: 0x04008C87 RID: 35975
	protected int FetterGroupId;

	// Token: 0x04008C88 RID: 35976
	private int SkinIdInternal;

	// Token: 0x04008C89 RID: 35977
	private Aki.Config.PhantomItem? ConfigCache;
}
