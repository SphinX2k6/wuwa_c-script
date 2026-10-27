using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001324 RID: 4900
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MoonChasingBusinessModel : ModelBase
{
	// Token: 0x17000B9E RID: 2974
	// (get) Token: 0x060087F9 RID: 34809 RVA: 0x001D0190 File Offset: 0x001CE390
	public bool IsInDelegate
	{
		get
		{
			return this.IsInDelegateInternal;
		}
	}

	// Token: 0x060087FA RID: 34810 RVA: 0x001D0198 File Offset: 0x001CE398
	protected override bool OnInit()
	{
		IReadOnlyList<EntrustRole> configList = ConfigEntrustRoleAll.GetConfigList(true);
		if (configList != null)
		{
			for (int i = 0; i < configList.Count; i++)
			{
				EntrustRole entrustRole = configList[i];
				EditTeamData value = new EditTeamData(entrustRole.Id, entrustRole.Type, entrustRole.UnLockCondition);
				this.EditTeamDataMap[entrustRole.Id] = value;
			}
		}
		return true;
	}

	// Token: 0x060087FB RID: 34811 RVA: 0x001D01F8 File Offset: 0x001CE3F8
	public void SetAllDelegationData(IReadOnlyList<EntrustInfo> dataList)
	{
		for (int i = 0; i < dataList.Count; i++)
		{
			this.SetDelegationData(dataList[i]);
		}
	}

	// Token: 0x060087FC RID: 34812 RVA: 0x001D0224 File Offset: 0x001CE424
	public void SetDelegationData(EntrustInfo data)
	{
		DelegationData value = new DelegationData(data.EntrustId, data.HistoryLevel, data.IsVisiable);
		this.DelegationDataMap[data.EntrustId] = value;
	}

	// Token: 0x060087FD RID: 34813 RVA: 0x001D025C File Offset: 0x001CE45C
	public void ReplaceDelegationData(int oldId, EntrustInfo newData)
	{
		if (oldId == newData.EntrustId)
		{
			EventSystem.Instance.Emit<bool>(EEventName.RefreshDelegate, false);
			return;
		}
		this.DelegationDataMap.Remove(oldId);
		this.SetDelegationData(newData);
		EventSystem.Instance.Emit<bool>(EEventName.RefreshDelegate, true);
	}

	// Token: 0x060087FE RID: 34814 RVA: 0x001D02A9 File Offset: 0x001CE4A9
	public void ConditionUnlockDelegationData(EntrustInfo data)
	{
		this.SetDelegationData(data);
	}

	// Token: 0x060087FF RID: 34815 RVA: 0x001D02B4 File Offset: 0x001CE4B4
	[NullableContext(2)]
	public DelegationData GetDelegationData(int id)
	{
		DelegationData result;
		if (!this.DelegationDataMap.TryGetValue(id, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06008800 RID: 34816 RVA: 0x001D02D4 File Offset: 0x001CE4D4
	public List<DelegationData> GetDelegationDataList()
	{
		List<DelegationData> list = new List<DelegationData>();
		foreach (DelegationData item in this.DelegationDataMap.Values)
		{
			list.Add(item);
		}
		list.Sort(delegate(DelegationData aData, DelegationData bData)
		{
			if (aData.IsVisible != bData.IsVisible)
			{
				if (!aData.IsVisible)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				TrackMoonEntrust valueOrDefault = ConfigTrackMoonEntrustById.GetConfig(aData.Id, true).GetValueOrDefault();
				TrackMoonEntrust valueOrDefault2 = ConfigTrackMoonEntrustById.GetConfig(bData.Id, true).GetValueOrDefault();
				if (valueOrDefault.Star != valueOrDefault2.Star)
				{
					if (valueOrDefault.Star >= valueOrDefault2.Star)
					{
						return 1;
					}
					return -1;
				}
				else if (aData.BestEvaluateLevel != bData.BestEvaluateLevel)
				{
					if (aData.BestEvaluateLevel >= bData.BestEvaluateLevel)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (aData.Id >= bData.Id)
					{
						return 1;
					}
					return -1;
				}
			}
		});
		return list;
	}

	// Token: 0x06008801 RID: 34817 RVA: 0x001D0358 File Offset: 0x001CE558
	public void SetAllEditTeamData(IReadOnlyList<EntrustRoleInfo> dataList)
	{
		foreach (EditTeamData editTeamData in this.EditTeamDataMap.Values)
		{
			editTeamData.IsOwn = false;
		}
		for (int i = 0; i < dataList.Count; i++)
		{
			this.SetEditTeamData(dataList[i]);
		}
	}

	// Token: 0x06008802 RID: 34818 RVA: 0x001D03CC File Offset: 0x001CE5CC
	public void SetEditTeamData(EntrustRoleInfo data)
	{
		RoleProperSettle roleAttr = data.RoleAttr;
		if (roleAttr == null)
		{
			return;
		}
		EditTeamData editTeamData;
		if (!this.EditTeamDataMap.TryGetValue(roleAttr.RoleId, out editTeamData))
		{
			return;
		}
		editTeamData.IsOwn = true;
		editTeamData.SetCharacterDataList(roleAttr);
	}

	// Token: 0x06008803 RID: 34819 RVA: 0x001D0408 File Offset: 0x001CE608
	public EditTeamData DeepCopyEditTeamData(EditTeamData editTeamData)
	{
		EditTeamData editTeamData2 = new EditTeamData(editTeamData.Id, editTeamData.Type, editTeamData.UnLockCondition);
		editTeamData2.SetCharacterDataByEditTeamData(editTeamData);
		return editTeamData2;
	}

	// Token: 0x06008804 RID: 34820 RVA: 0x001D0428 File Offset: 0x001CE628
	public void ConditionUnlockEditTeamData(EntrustRoleInfo data)
	{
		this.SetEditTeamData(data);
		RoleProperSettle roleAttr = data.RoleAttr;
		if (roleAttr != null)
		{
			this.UnlockRoleIdList.Add(roleAttr.RoleId);
			MoonChasingModel.Instance.SaveRoleIdUnlockFlag(roleAttr.RoleId);
		}
		EventSystem.Instance.Emit(EEventName.ConditionUnlockRole);
	}

	// Token: 0x06008805 RID: 34821 RVA: 0x001D0478 File Offset: 0x001CE678
	public int? PopUnlockRoleId()
	{
		if (this.UnlockRoleIdList.Count == 0)
		{
			return null;
		}
		int value = this.UnlockRoleIdList[0];
		this.UnlockRoleIdList.RemoveAt(0);
		return new int?(value);
	}

	// Token: 0x06008806 RID: 34822 RVA: 0x001D04B9 File Offset: 0x001CE6B9
	public bool IsUnlockRoleIdEmpty()
	{
		return this.UnlockRoleIdList.Count == 0;
	}

	// Token: 0x06008807 RID: 34823 RVA: 0x001D04CC File Offset: 0x001CE6CC
	public List<EditTeamData> GetHelpEditTeamDataList(bool withMainRole = false)
	{
		List<EditTeamData> list = new List<EditTeamData>();
		foreach (EditTeamData editTeamData in this.EditTeamDataMap.Values)
		{
			if (this.CheckTypeCanUse(editTeamData.Type) && (editTeamData.Type == 0 || withMainRole))
			{
				list.Add(editTeamData);
			}
		}
		list.Sort(new Comparison<EditTeamData>(this.SortHelpTeamData));
		return list;
	}

	// Token: 0x06008808 RID: 34824 RVA: 0x001D0558 File Offset: 0x001CE758
	public List<EditTeamData> GetUnlockHelpEditTeamDataList(bool withMainRole = false)
	{
		List<EditTeamData> list = new List<EditTeamData>();
		foreach (EditTeamData editTeamData in this.EditTeamDataMap.Values)
		{
			if (this.CheckTypeCanUse(editTeamData.Type) && (editTeamData.Type == 0 || withMainRole) && editTeamData.IsOwn)
			{
				list.Add(editTeamData);
			}
		}
		list.Sort(new Comparison<EditTeamData>(this.SortHelpTeamData));
		return list;
	}

	// Token: 0x06008809 RID: 34825 RVA: 0x001D05EC File Offset: 0x001CE7EC
	private int SortHelpTeamData(EditTeamData aData, EditTeamData bData)
	{
		if (aData.IsOwn != bData.IsOwn)
		{
			if (!aData.IsOwn)
			{
				return 1;
			}
			return -1;
		}
		else if (aData.Level != bData.Level)
		{
			if (aData.Level <= bData.Level)
			{
				return 1;
			}
			return -1;
		}
		else
		{
			int allCharacterValue = aData.GetAllCharacterValue();
			int allCharacterValue2 = bData.GetAllCharacterValue();
			if (allCharacterValue != allCharacterValue2)
			{
				if (allCharacterValue <= allCharacterValue2)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				bool flag = aData.GetTeamDataUnLockState() == EEditTeamDataUnLockState.TaskUnFinish;
				bool flag2 = bData.GetTeamDataUnLockState() == EEditTeamDataUnLockState.TaskUnFinish;
				if (flag != flag2)
				{
					if (!flag)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (aData.Id >= bData.Id)
					{
						return 1;
					}
					return -1;
				}
			}
		}
	}

	// Token: 0x0600880A RID: 34826 RVA: 0x001D0680 File Offset: 0x001CE880
	public int GetPlayerRoleId()
	{
		foreach (EditTeamData editTeamData in this.EditTeamDataMap.Values)
		{
			if (this.CheckTypeCanUse(editTeamData.Type) && editTeamData.Type != 0)
			{
				return editTeamData.Id;
			}
		}
		return 0;
	}

	// Token: 0x0600880B RID: 34827 RVA: 0x001D06F4 File Offset: 0x001CE8F4
	private bool CheckTypeCanUse(int type)
	{
		PlayerInfoModel instance = PlayerInfoModel.Instance;
		return (type != 1 || instance.GetPlayerGender() == EPlayerGender.Male) && (type != 2 || instance.GetPlayerGender() == EPlayerGender.Female);
	}

	// Token: 0x0600880C RID: 34828 RVA: 0x001D0728 File Offset: 0x001CE928
	public List<EditTeamData> GetOwnEditTeamDataList()
	{
		List<EditTeamData> list = new List<EditTeamData>();
		foreach (EditTeamData editTeamData in this.EditTeamDataMap.Values)
		{
			if (this.CheckTypeCanUse(editTeamData.Type) && editTeamData.IsOwn)
			{
				list.Add(editTeamData);
			}
		}
		list.Sort(delegate(EditTeamData aData, EditTeamData bData)
		{
			if (aData.Level != bData.Level)
			{
				if (aData.Level <= bData.Level)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				int allCharacterValue = aData.GetAllCharacterValue();
				int allCharacterValue2 = bData.GetAllCharacterValue();
				if (allCharacterValue != allCharacterValue2)
				{
					if (allCharacterValue <= allCharacterValue2)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (aData.Id >= bData.Id)
					{
						return 1;
					}
					return -1;
				}
			}
		});
		return list;
	}

	// Token: 0x0600880D RID: 34829 RVA: 0x001D07C4 File Offset: 0x001CE9C4
	public EditTeamData GetEditTeamDataById(int roleId)
	{
		return this.EditTeamDataMap[roleId];
	}

	// Token: 0x0600880E RID: 34830 RVA: 0x001D07D2 File Offset: 0x001CE9D2
	public void SetResultData(DelegationResultData resultData)
	{
		this.DelegationResultDataInternal = resultData;
		EventSystem.Instance.Emit(EEventName.SetDelegationResultData);
	}

	// Token: 0x0600880F RID: 34831 RVA: 0x001D07EB File Offset: 0x001CE9EB
	public DelegationResultData GetResultData()
	{
		return this.DelegationResultDataInternal;
	}

	// Token: 0x06008810 RID: 34832 RVA: 0x001D07F4 File Offset: 0x001CE9F4
	private List<CharacterData> CreateCharacterList(bool useScoreName)
	{
		List<CharacterData> list = new List<CharacterData>();
		for (int i = 1; i <= 3; i++)
		{
			CharacterData characterData = new CharacterData(i);
			characterData.SetUseScoreName(useScoreName);
			list.Add(characterData);
		}
		return list;
	}

	// Token: 0x06008811 RID: 34833 RVA: 0x001D082C File Offset: 0x001CEA2C
	public List<CharacterData> GetCharacterValueListByRoleIds(IEnumerable<int> roleIds, bool useScoreName)
	{
		List<CharacterData> list = this.CreateCharacterList(useScoreName);
		foreach (int key in roleIds)
		{
			EditTeamData editTeamData;
			if (this.EditTeamDataMap.TryGetValue(key, out editTeamData))
			{
				List<CharacterData> characterDataList = editTeamData.GetCharacterDataList();
				for (int i = 0; i < 3; i++)
				{
					CharacterData characterData = list[i];
					characterData.SetCurrentValue(characterData.CurrentValue + characterDataList[i].CurrentValue);
				}
			}
		}
		return list;
	}

	// Token: 0x06008812 RID: 34834 RVA: 0x001D08C0 File Offset: 0x001CEAC0
	public IInvestData GetInvestData(int invest)
	{
		TrackMoonEntrust valueOrDefault = ConfigTrackMoonEntrustById.GetConfig(this.GetResultData().EntrustId, true).GetValueOrDefault();
		float num;
		if (valueOrDefault.IdeaSuccRatioLength >= 2)
		{
			DicIntInt valueOrDefault2 = valueOrDefault.IdeaSuccRatio(0).GetValueOrDefault();
			DicIntInt valueOrDefault3 = valueOrDefault.IdeaSuccRatio(1).GetValueOrDefault();
			int key = valueOrDefault2.Key;
			int value = valueOrDefault2.Value;
			int key2 = valueOrDefault3.Key;
			int value2 = valueOrDefault3.Value;
			if (invest >= key2)
			{
				num = (float)value2 / 10f;
			}
			else
			{
				num = ((float)(value2 - value) / (float)(key2 - key) * (float)invest + (float)value) / 10f;
			}
		}
		else
		{
			num = 0f;
		}
		float num2 = (valueOrDefault.IdeaSuccMulLength >= 1) ? ((float)valueOrDefault.IdeaSuccMul(0) / 1000f) : 0f;
		float num3 = (valueOrDefault.IdeaSuccMulLength >= 2) ? ((float)valueOrDefault.IdeaSuccMul(1) / 1000f) : 1f;
		float num4 = num2 * (float)invest / (num3 + (float)invest);
		return new InvestData
		{
			SuccessProbability = (int)num,
			Ratio = (int)((num4 + 1f) * 100f)
		};
	}

	// Token: 0x06008813 RID: 34835 RVA: 0x001D09DC File Offset: 0x001CEBDC
	public Popularity GetCurrentPopularityConfig()
	{
		int popularityValue = MoonChasingModel.Instance.GetPopularityValue();
		return this.GetPopularityConfigByValue(popularityValue);
	}

	// Token: 0x06008814 RID: 34836 RVA: 0x001D09FC File Offset: 0x001CEBFC
	public Popularity? GetLastPopularityConfig()
	{
		Popularity? result = null;
		IReadOnlyList<Popularity> configList = ConfigPopularityAll.GetConfigList(true);
		int popularityValue = MoonChasingModel.Instance.GetPopularityValue();
		if (configList != null)
		{
			for (int i = 0; i < configList.Count; i++)
			{
				Popularity value = configList[i];
				if (value.PopularityValue > popularityValue)
				{
					break;
				}
				result = new Popularity?(value);
			}
		}
		return result;
	}

	// Token: 0x06008815 RID: 34837 RVA: 0x001D0A54 File Offset: 0x001CEC54
	public Popularity GetPopularityConfigByValue(int value)
	{
		IReadOnlyList<Popularity> configList = ConfigPopularityAll.GetConfigList(true);
		if (configList == null || configList.Count == 0)
		{
			return default(Popularity);
		}
		for (int i = 0; i < configList.Count; i++)
		{
			Popularity result = configList[i];
			if (result.PopularityValue > value)
			{
				return result;
			}
		}
		return configList[configList.Count - 1];
	}

	// Token: 0x06008816 RID: 34838 RVA: 0x001D0AB0 File Offset: 0x001CECB0
	public void SetIsInDelegate(bool value)
	{
		this.IsInDelegateInternal = value;
		if (!value)
		{
			EventSystem.Instance.Emit(EEventName.ConditionUnlockRole);
		}
	}

	// Token: 0x17000B9F RID: 2975
	// (get) Token: 0x06008817 RID: 34839 RVA: 0x001D0ACC File Offset: 0x001CECCC
	public static MoonChasingBusinessModel Instance
	{
		get
		{
			return MoonChasingBusinessModel._Instance;
		}
	}

	// Token: 0x06008818 RID: 34840 RVA: 0x001D0AD3 File Offset: 0x001CECD3
	public static MoonChasingBusinessModel GetOrCreateInstance()
	{
		if (MoonChasingBusinessModel._Instance == null)
		{
			MoonChasingBusinessModel.CreateInstance();
		}
		return MoonChasingBusinessModel._Instance;
	}

	// Token: 0x06008819 RID: 34841 RVA: 0x001D0AE7 File Offset: 0x001CECE7
	public static bool CreateInstance()
	{
		if (MoonChasingBusinessModel._Instance != null)
		{
			return true;
		}
		MoonChasingBusinessModel._Instance = new MoonChasingBusinessModel();
		return true;
	}

	// Token: 0x0600881A RID: 34842 RVA: 0x001D0AFD File Offset: 0x001CECFD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600881B RID: 34843 RVA: 0x001D0AFF File Offset: 0x001CECFF
	public static void ResetStaticDefaultValue()
	{
		MoonChasingBusinessModel._Instance = null;
	}

	// Token: 0x0600881C RID: 34844 RVA: 0x001D0B07 File Offset: 0x001CED07
	static MoonChasingBusinessModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonChasingBusinessModel.CreateStaticDefaultValue), new Action(MoonChasingBusinessModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003CAA RID: 15530
	private readonly Dictionary<int, DelegationData> DelegationDataMap = new Dictionary<int, DelegationData>();

	// Token: 0x04003CAB RID: 15531
	private readonly Dictionary<int, EditTeamData> EditTeamDataMap = new Dictionary<int, EditTeamData>();

	// Token: 0x04003CAC RID: 15532
	private DelegationResultData DelegationResultDataInternal;

	// Token: 0x04003CAD RID: 15533
	private readonly List<int> UnlockRoleIdList = new List<int>();

	// Token: 0x04003CAE RID: 15534
	private bool IsInDelegateInternal;

	// Token: 0x04003CAF RID: 15535
	[Nullable(2)]
	private static MoonChasingBusinessModel _Instance;
}
