using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x0200192C RID: 6444
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class VisionEquipGroupModel : ModelBase
{
	// Token: 0x0600FEA7 RID: 65191 RVA: 0x004A5B1C File Offset: 0x004A3D1C
	public VisionEquipGroupModel()
	{
		this.VisionEquipGroupList = new List<VisionEquipGroupData>();
	}

	// Token: 0x0600FEA8 RID: 65192 RVA: 0x004A5B30 File Offset: 0x004A3D30
	public void RefreshVisionEquipGroupData(IReadOnlyList<PhantomEquipGroupInfo> data)
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

	// Token: 0x0600FEA9 RID: 65193 RVA: 0x004A5B8C File Offset: 0x004A3D8C
	public bool CheckVisionListIfInGroup(List<int> incIdList)
	{
		int count = this.VisionEquipGroupList.Count;
		for (int i = 0; i < count; i++)
		{
			VisionEquipGroupData visionEquipGroupData = this.VisionEquipGroupList[i];
			bool flag = true;
			foreach (int num in incIdList)
			{
				bool flag2 = false;
				int[] visionUniqueIdList = visionEquipGroupData.GetVisionUniqueIdList();
				for (int j = 0; j < visionUniqueIdList.Length; j++)
				{
					if (visionUniqueIdList[j] == num)
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
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

	// Token: 0x0600FEAA RID: 65194 RVA: 0x004A5C38 File Offset: 0x004A3E38
	public List<VisionEquipGroupData> GetVisionEquipGroupList()
	{
		return this.VisionEquipGroupList;
	}

	// Token: 0x0600FEAB RID: 65195 RVA: 0x004A5C40 File Offset: 0x004A3E40
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

	// Token: 0x0600FEAC RID: 65196 RVA: 0x004A5CAC File Offset: 0x004A3EAC
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

	// Token: 0x0600FEAD RID: 65197 RVA: 0x004A5CE4 File Offset: 0x004A3EE4
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

	// Token: 0x0600FEAE RID: 65198 RVA: 0x004A5D40 File Offset: 0x004A3F40
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

	// Token: 0x0600FEAF RID: 65199 RVA: 0x004A5E78 File Offset: 0x004A4078
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

	// Token: 0x0600FEB0 RID: 65200 RVA: 0x004A5F04 File Offset: 0x004A4104
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

	// Token: 0x0600FEB1 RID: 65201 RVA: 0x004A5F68 File Offset: 0x004A4168
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

	// Token: 0x0600FEB2 RID: 65202 RVA: 0x004A6044 File Offset: 0x004A4244
	private List<VisionAssembleAttrData> GetCurrentRoleAttrData(int currentSelectRoleId, bool compareMode)
	{
		List<int> incrIdList = RoleModel.Instance.GetRoleDataById(currentSelectRoleId, true).GetPhantomData().GetIncrIdList();
		return this.GetVisionAttrDataListByIncIdList(incrIdList, compareMode);
	}

	// Token: 0x0600FEB3 RID: 65203 RVA: 0x004A6070 File Offset: 0x004A4270
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

	// Token: 0x0600FEB4 RID: 65204 RVA: 0x004A62EC File Offset: 0x004A44EC
	public void SaveLocalTopTipState(bool state)
	{
		int value = (state > false) ? 1 : 0;
		LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.VisionTopTipsState, value);
	}

	// Token: 0x0600FEB5 RID: 65205 RVA: 0x004A6307 File Offset: 0x004A4507
	public bool GetLocalTipsState()
	{
		return LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.VisionTopTipsState, 0) == 1;
	}

	// Token: 0x0600FEB6 RID: 65206 RVA: 0x004A6314 File Offset: 0x004A4514
	public bool GetVisionGroupFirstOpenState()
	{
		bool flag = FunctionModel.Instance.IsOpen(EFunctionType.VisionGroup);
		ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.FirstOpenVisionGroup, EClientStorageSystemIdType.FirstOpenVisionGroup, true);
		return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FirstOpenVisionGroup) as ServerStorageBoolean).Get().GetValueOrDefault(true) && flag;
	}

	// Token: 0x0600FEB7 RID: 65207 RVA: 0x004A635D File Offset: 0x004A455D
	public void SaveVisionGroupFirstOpenState(bool state)
	{
		(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FirstOpenVisionGroup) as ServerStorageBoolean).Set(new bool?(state));
	}

	// Token: 0x1700185E RID: 6238
	// (get) Token: 0x0600FEB8 RID: 65208 RVA: 0x004A637B File Offset: 0x004A457B
	public static VisionEquipGroupModel Instance
	{
		get
		{
			return VisionEquipGroupModel._Instance;
		}
	}

	// Token: 0x0600FEB9 RID: 65209 RVA: 0x004A6382 File Offset: 0x004A4582
	public static VisionEquipGroupModel GetOrCreateInstance()
	{
		if (VisionEquipGroupModel._Instance == null)
		{
			VisionEquipGroupModel.CreateInstance();
		}
		return VisionEquipGroupModel._Instance;
	}

	// Token: 0x0600FEBA RID: 65210 RVA: 0x004A6396 File Offset: 0x004A4596
	public static bool CreateInstance()
	{
		if (VisionEquipGroupModel._Instance != null)
		{
			return true;
		}
		VisionEquipGroupModel._Instance = new VisionEquipGroupModel();
		return true;
	}

	// Token: 0x0600FEBB RID: 65211 RVA: 0x004A63AC File Offset: 0x004A45AC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FEBC RID: 65212 RVA: 0x004A63AE File Offset: 0x004A45AE
	public static void ResetStaticDefaultValue()
	{
		VisionEquipGroupModel._Instance = null;
	}

	// Token: 0x0600FEBD RID: 65213 RVA: 0x004A63B6 File Offset: 0x004A45B6
	static VisionEquipGroupModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VisionEquipGroupModel.CreateStaticDefaultValue), new Action(VisionEquipGroupModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008DA5 RID: 36261
	private List<VisionEquipGroupData> VisionEquipGroupList;

	// Token: 0x04008DA6 RID: 36262
	public int FilterDataLength;

	// Token: 0x04008DA7 RID: 36263
	[Nullable(2)]
	private static VisionEquipGroupModel _Instance;
}
