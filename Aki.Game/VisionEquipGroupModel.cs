using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x02002447 RID: 9287
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class VisionEquipGroupModel : ModelBase
{
	// Token: 0x060129F1 RID: 76273 RVA: 0x00498550 File Offset: 0x00496750
	public VisionEquipGroupModel()
	{
		this.VisionEquipGroupList = new List<VisionEquipGroupData>();
	}

	// Token: 0x060129F2 RID: 76274 RVA: 0x00498564 File Offset: 0x00496764
	public void RefreshVisionEquipGroupData(List<PhantomEquipGroupInfo> data)
	{
		this.VisionEquipGroupList = new List<VisionEquipGroupData>();
		int count = data.Count;
		for (int i = 0; i < count; i++)
		{
			VisionEquipGroupData visionEquipGroupData = new VisionEquipGroupData();
			visionEquipGroupData.Phrase(i, data[i]);
			this.VisionEquipGroupList.Add(visionEquipGroupData);
		}
		EventSystem.Instance.Emit(EEventName.OnVisionGroupDataUpdate);
	}

	// Token: 0x060129F3 RID: 76275 RVA: 0x004985C0 File Offset: 0x004967C0
	public bool CheckVisionListIfInGroup(List<int> incIdList)
	{
		int count = this.VisionEquipGroupList.Count;
		for (int i = 0; i < count; i++)
		{
			VisionEquipGroupData visionEquipGroupData = this.VisionEquipGroupList[i];
			bool flag = true;
			foreach (int value in incIdList)
			{
				if (!visionEquipGroupData.GetVisionUniqueIdList().Contains(value))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060129F4 RID: 76276 RVA: 0x0049864C File Offset: 0x0049684C
	public List<VisionEquipGroupData> GetVisionEquipGroupList()
	{
		return this.VisionEquipGroupList;
	}

	// Token: 0x060129F5 RID: 76277 RVA: 0x00498654 File Offset: 0x00496854
	public int GetVisionUsedCountInGroup(int incId)
	{
		int num = 0;
		foreach (VisionEquipGroupData visionEquipGroupData in this.VisionEquipGroupList)
		{
			int[] visionUniqueIdList = visionEquipGroupData.GetVisionUniqueIdList();
			for (int i = 0; i < visionUniqueIdList.Length; i++)
			{
				if (visionUniqueIdList[i] == incId)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x060129F6 RID: 76278 RVA: 0x004986C0 File Offset: 0x004968C0
	public bool CheckVisionConsumeBreakGroup(int incId, int consumeCount)
	{
		int visionUsedCountInGroup = this.GetVisionUsedCountInGroup(incId);
		if (visionUsedCountInGroup == 0)
		{
			return false;
		}
		PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(incId);
		return ((phantomItemData != null) ? phantomItemData.GetStackCount() : 0) - consumeCount < visionUsedCountInGroup;
	}

	// Token: 0x060129F7 RID: 76279 RVA: 0x004986F8 File Offset: 0x004968F8
	[NullableContext(2)]
	public VisionEquipGroupData GetVisionEquipGroupDataByIndex(int index)
	{
		foreach (VisionEquipGroupData visionEquipGroupData in this.VisionEquipGroupList)
		{
			if (visionEquipGroupData.GetIndex() == index)
			{
				return visionEquipGroupData;
			}
		}
		return null;
	}

	// Token: 0x060129F8 RID: 76280 RVA: 0x00498754 File Offset: 0x00496954
	public List<VisionFetterData> GetVisionFetterDataByIncIdList(List<int> incIdList)
	{
		List<PhantomDataBase> list = new List<PhantomDataBase>();
		int count = incIdList.Count;
		for (int i = 0; i < count; i++)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(incIdList[i]);
			if (phantomBattleData != null)
			{
				list.Add(phantomBattleData);
			}
		}
		Dictionary<int, int> suitMap = PhantomDataBase.CalculateFetterByPhantomBattleData(list);
		Dictionary<int, Dictionary<int, int>> fetterMapResultBySuitMap = PhantomBattleConfig.Instance.GetFetterMapResultBySuitMap(suitMap);
		List<VisionFetterData> list2 = new List<VisionFetterData>();
		foreach (KeyValuePair<int, Dictionary<int, int>> keyValuePair in fetterMapResultBySuitMap)
		{
			int key = keyValuePair.Key;
			foreach (KeyValuePair<int, int> keyValuePair2 in keyValuePair.Value)
			{
				int key2 = keyValuePair2.Key;
				int value = keyValuePair2.Value;
				list2.Add(new VisionFetterData
				{
					FetterGroupId = key,
					FetterId = key2,
					NeedActiveNum = value,
					ActiveFetterGroupNum = value,
					ActiveState = true
				});
			}
		}
		return list2;
	}

	// Token: 0x060129F9 RID: 76281 RVA: 0x0049888C File Offset: 0x00496A8C
	public List<VisionAssembleAttrData> GetVisionAssembleViewAttrData(int groupIndex, bool compareMode, int currentSelectRoleId)
	{
		List<int> incIdList;
		if (groupIndex == -1)
		{
			incIdList = RoleModel.Instance.GetRoleDataById(currentSelectRoleId, true).GetPhantomData().GetIncrIdList();
		}
		else
		{
			VisionEquipGroupData visionEquipGroupDataByIndex = this.GetVisionEquipGroupDataByIndex(groupIndex);
			if (visionEquipGroupDataByIndex == null)
			{
				return new List<VisionAssembleAttrData>();
			}
			incIdList = new List<int>(visionEquipGroupDataByIndex.GetVisionUniqueIdList());
		}
		List<VisionAssembleAttrData> visionAttrDataListByIncIdList = this.GetVisionAttrDataListByIncIdList(incIdList, compareMode);
		if (!compareMode)
		{
			visionAttrDataListByIncIdList.Sort(new Comparison<VisionAssembleAttrData>(this.SortAttrList));
			return visionAttrDataListByIncIdList;
		}
		List<VisionAssembleAttrData> currentRoleAttrData = this.GetCurrentRoleAttrData(currentSelectRoleId, compareMode);
		this.CombineAttrList(visionAttrDataListByIncIdList, currentRoleAttrData);
		visionAttrDataListByIncIdList.Sort(new Comparison<VisionAssembleAttrData>(this.SortAttrList));
		return visionAttrDataListByIncIdList;
	}

	// Token: 0x060129FA RID: 76282 RVA: 0x00498918 File Offset: 0x00496B18
	private int SortAttrList(VisionAssembleAttrData dataB, VisionAssembleAttrData dataA)
	{
		int priority = dataA.GetPriority();
		int priority2 = dataB.GetPriority();
		bool flag = priority != 0;
		bool flag2 = priority2 != 0;
		if (flag && flag2)
		{
			if (priority == priority2)
			{
				int num = (!dataA.IfPercentage) ? 1 : 0;
				int num2 = (!dataB.IfPercentage) ? 1 : 0;
				return num - num2;
			}
			return priority - priority2;
		}
		else
		{
			if (flag)
			{
				return -1;
			}
			if (flag2)
			{
				return 1;
			}
			return dataA.GetId() - dataB.GetId();
		}
	}

	// Token: 0x060129FB RID: 76283 RVA: 0x0049897C File Offset: 0x00496B7C
	private void CombineAttrList(List<VisionAssembleAttrData> compareAttrDataList, List<VisionAssembleAttrData> currentAttrDataList)
	{
		int count = currentAttrDataList.Count;
		for (int i = 0; i < count; i++)
		{
			VisionAssembleAttrData visionAssembleAttrData = currentAttrDataList[i];
			bool flag = false;
			foreach (VisionAssembleAttrData visionAssembleAttrData2 in compareAttrDataList)
			{
				if (visionAssembleAttrData2.AttrId == visionAssembleAttrData.AttrId && visionAssembleAttrData2.IfPercentage == visionAssembleAttrData.IfPercentage)
				{
					visionAssembleAttrData2.CompareValue = visionAssembleAttrData.CurrentValue;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				compareAttrDataList.Add(new VisionAssembleAttrData
				{
					AttrId = visionAssembleAttrData.AttrId,
					IfPercentage = visionAssembleAttrData.IfPercentage,
					CompareValue = visionAssembleAttrData.CurrentValue,
					CompareMode = true
				});
			}
		}
	}

	// Token: 0x060129FC RID: 76284 RVA: 0x00498A58 File Offset: 0x00496C58
	private List<VisionAssembleAttrData> GetCurrentRoleAttrData(int currentSelectRoleId, bool compareMode)
	{
		List<int> incrIdList = RoleModel.Instance.GetRoleDataById(currentSelectRoleId, true).GetPhantomData().GetIncrIdList();
		return this.GetVisionAttrDataListByIncIdList(incrIdList, compareMode);
	}

	// Token: 0x060129FD RID: 76285 RVA: 0x00498A84 File Offset: 0x00496C84
	private List<VisionAssembleAttrData> GetVisionAttrDataListByIncIdList(List<int> incIdList, bool compareMode)
	{
		List<VisionAssembleAttrData> list = new List<VisionAssembleAttrData>();
		int count = incIdList.Count;
		for (int i = 0; i < count; i++)
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(incIdList[i]);
			if (phantomBattleData != null)
			{
				foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo in phantomBattleData.GetPhantomMainProp())
				{
					PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(phantomPropInfo.PhantomPropId);
					bool flag = phantomMainPropertyItemId.AddType == 2;
					bool flag2 = false;
					foreach (VisionAssembleAttrData visionAssembleAttrData in list)
					{
						if (visionAssembleAttrData.AttrId == phantomMainPropertyItemId.PropId && visionAssembleAttrData.IfPercentage == flag)
						{
							visionAssembleAttrData.CurrentValue += phantomPropInfo.Value;
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						VisionAssembleAttrData visionAssembleAttrData2 = new VisionAssembleAttrData();
						visionAssembleAttrData2.AttrId = phantomMainPropertyItemId.PropId;
						visionAssembleAttrData2.IfPercentage = flag;
						visionAssembleAttrData2.CurrentValue += phantomPropInfo.Value;
						visionAssembleAttrData2.CompareMode = compareMode;
						list.Add(visionAssembleAttrData2);
					}
				}
				foreach (Aki.Protocol.PhantomPropInfo phantomPropInfo2 in phantomBattleData.GetPhantomSubProp())
				{
					PhantomSubProperty phantomSubPropertyById = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(phantomPropInfo2.PhantomPropId);
					bool flag3 = phantomSubPropertyById.AddType == 2;
					bool flag4 = false;
					foreach (VisionAssembleAttrData visionAssembleAttrData3 in list)
					{
						if (visionAssembleAttrData3.AttrId == phantomSubPropertyById.PropId && visionAssembleAttrData3.IfPercentage == flag3)
						{
							visionAssembleAttrData3.CurrentValue += phantomPropInfo2.Value;
							flag4 = true;
							break;
						}
					}
					if (!flag4)
					{
						VisionAssembleAttrData visionAssembleAttrData4 = new VisionAssembleAttrData();
						visionAssembleAttrData4.AttrId = phantomSubPropertyById.PropId;
						visionAssembleAttrData4.IfPercentage = flag3;
						visionAssembleAttrData4.CurrentValue += phantomPropInfo2.Value;
						visionAssembleAttrData4.CompareMode = compareMode;
						list.Add(visionAssembleAttrData4);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x060129FE RID: 76286 RVA: 0x00498D00 File Offset: 0x00496F00
	public void SaveLocalTopTipState(bool state)
	{
		int value = (state > false) ? 1 : 0;
		LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.VisionTopTipsState, value);
	}

	// Token: 0x060129FF RID: 76287 RVA: 0x00498D1B File Offset: 0x00496F1B
	public bool GetLocalTipsState()
	{
		return LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.VisionTopTipsState, 0) == 1;
	}

	// Token: 0x06012A00 RID: 76288 RVA: 0x00498D28 File Offset: 0x00496F28
	public bool GetVisionGroupFirstOpenState()
	{
		bool flag = FunctionModel.Instance.IsOpen(EFunctionType.VisionGroup);
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.FirstOpenVisionGroup, EClientStorageSystemIdType.FirstOpenVisionGroup);
		return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FirstOpenVisionGroup) as ServerStorageBoolean).Get().GetValueOrDefault(true) && flag;
	}

	// Token: 0x06012A01 RID: 76289 RVA: 0x00498D70 File Offset: 0x00496F70
	public void SaveVisionGroupFirstOpenState(bool state)
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FirstOpenVisionGroup) as ServerStorageBoolean).Set(new bool?(state));
	}

	// Token: 0x17001824 RID: 6180
	// (get) Token: 0x06012A02 RID: 76290 RVA: 0x00498D8E File Offset: 0x00496F8E
	public static VisionEquipGroupModel Instance
	{
		get
		{
			return VisionEquipGroupModel._Instance;
		}
	}

	// Token: 0x06012A03 RID: 76291 RVA: 0x00498D95 File Offset: 0x00496F95
	public static VisionEquipGroupModel GetOrCreateInstance()
	{
		if (VisionEquipGroupModel._Instance == null)
		{
			VisionEquipGroupModel.CreateInstance();
		}
		return VisionEquipGroupModel._Instance;
	}

	// Token: 0x06012A04 RID: 76292 RVA: 0x00498DA9 File Offset: 0x00496FA9
	public static bool CreateInstance()
	{
		if (VisionEquipGroupModel._Instance != null)
		{
			return true;
		}
		VisionEquipGroupModel._Instance = new VisionEquipGroupModel();
		return true;
	}

	// Token: 0x06012A05 RID: 76293 RVA: 0x00498DBF File Offset: 0x00496FBF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012A06 RID: 76294 RVA: 0x00498DC1 File Offset: 0x00496FC1
	public static void ResetStaticDefaultValue()
	{
		VisionEquipGroupModel._Instance = null;
	}

	// Token: 0x06012A07 RID: 76295 RVA: 0x00498DC9 File Offset: 0x00496FC9
	static VisionEquipGroupModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VisionEquipGroupModel.CreateStaticDefaultValue), new Action(VisionEquipGroupModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008C5E RID: 35934
	private List<VisionEquipGroupData> VisionEquipGroupList;

	// Token: 0x04008C5F RID: 35935
	public int FilterDataLength;

	// Token: 0x04008C60 RID: 35936
	[Nullable(2)]
	private static VisionEquipGroupModel _Instance;
}
