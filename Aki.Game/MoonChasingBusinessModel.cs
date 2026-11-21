using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020007D8 RID: 2008
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MoonChasingBusinessModel : ModelBase
{
	// Token: 0x17000BBE RID: 3006
	// (get) Token: 0x06005B94 RID: 23444 RVA: 0x001D8FFC File Offset: 0x001D71FC
	public bool IsInDelegate
	{
		get
		{
			return this.IsInDelegateInternal;
		}
	}

	// Token: 0x06005B95 RID: 23445 RVA: 0x001D9004 File Offset: 0x001D7204
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

	// Token: 0x06005B96 RID: 23446 RVA: 0x001D9064 File Offset: 0x001D7264
	public void SetAllDelegationData(IReadOnlyList<EntrustInfo> dataList)
	{
		for (int i = 0; i < dataList.Count; i++)
		{
			this.SetDelegationData(dataList[i]);
		}
	}

	// Token: 0x06005B97 RID: 23447 RVA: 0x001D9090 File Offset: 0x001D7290
	public void SetDelegationData(EntrustInfo data)
	{
		DelegationData value = new DelegationData(data.EntrustId, data.HistoryLevel, data.IsVisiable);
		this.DelegationDataMap[data.EntrustId] = value;
	}

	// Token: 0x06005B98 RID: 23448 RVA: 0x001D90C8 File Offset: 0x001D72C8
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

	// Token: 0x06005B99 RID: 23449 RVA: 0x001D9115 File Offset: 0x001D7315
	public void ConditionUnlockDelegationData(EntrustInfo data)
	{
		this.SetDelegationData(data);
	}

	// Token: 0x06005B9A RID: 23450 RVA: 0x001D9120 File Offset: 0x001D7320
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

	// Token: 0x06005B9B RID: 23451 RVA: 0x001D9140 File Offset: 0x001D7340
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

	// Token: 0x06005B9C RID: 23452 RVA: 0x001D91C4 File Offset: 0x001D73C4
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

	// Token: 0x06005B9D RID: 23453 RVA: 0x001D9238 File Offset: 0x001D7438
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

	// Token: 0x06005B9E RID: 23454 RVA: 0x001D9274 File Offset: 0x001D7474
	public EditTeamData DeepCopyEditTeamData(EditTeamData editTeamData)
	{
		EditTeamData editTeamData2 = new EditTeamData(editTeamData.Id, editTeamData.Type, editTeamData.UnLockCondition);
		editTeamData2.SetCharacterDataByEditTeamData(editTeamData);
		return editTeamData2;
	}

	// Token: 0x06005B9F RID: 23455 RVA: 0x001D9294 File Offset: 0x001D7494
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

	// Token: 0x06005BA0 RID: 23456 RVA: 0x001D92E4 File Offset: 0x001D74E4
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

	// Token: 0x06005BA1 RID: 23457 RVA: 0x001D9325 File Offset: 0x001D7525
	public bool IsUnlockRoleIdEmpty()
	{
		return this.UnlockRoleIdList.Count == 0;
	}

	// Token: 0x06005BA2 RID: 23458 RVA: 0x001D9338 File Offset: 0x001D7538
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

	// Token: 0x06005BA3 RID: 23459 RVA: 0x001D93C4 File Offset: 0x001D75C4
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

	// Token: 0x06005BA4 RID: 23460 RVA: 0x001D9458 File Offset: 0x001D7658
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

	// Token: 0x06005BA5 RID: 23461 RVA: 0x001D94EC File Offset: 0x001D76EC
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

	// Token: 0x06005BA6 RID: 23462 RVA: 0x001D9560 File Offset: 0x001D7760
	private bool CheckTypeCanUse(int type)
	{
		PlayerInfoModel instance = PlayerInfoModel.Instance;
		return (type != 1 || instance.GetPlayerGender() == EPlayerGender.Male) && (type != 2 || instance.GetPlayerGender() == EPlayerGender.Female);
	}

	// Token: 0x06005BA7 RID: 23463 RVA: 0x001D9594 File Offset: 0x001D7794
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

	// Token: 0x06005BA8 RID: 23464 RVA: 0x001D9630 File Offset: 0x001D7830
	public EditTeamData GetEditTeamDataById(int roleId)
	{
		return this.EditTeamDataMap[roleId];
	}

	// Token: 0x06005BA9 RID: 23465 RVA: 0x001D963E File Offset: 0x001D783E
	public void SetResultData(DelegationResultData resultData)
	{
		this.DelegationResultDataInternal = resultData;
		EventSystem.Instance.Emit(EEventName.SetDelegationResultData);
	}

	// Token: 0x06005BAA RID: 23466 RVA: 0x001D9657 File Offset: 0x001D7857
	public DelegationResultData GetResultData()
	{
		return this.DelegationResultDataInternal;
	}

	// Token: 0x06005BAB RID: 23467 RVA: 0x001D9660 File Offset: 0x001D7860
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

	// Token: 0x06005BAC RID: 23468 RVA: 0x001D9698 File Offset: 0x001D7898
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

	// Token: 0x06005BAD RID: 23469 RVA: 0x001D972C File Offset: 0x001D792C
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

	// Token: 0x06005BAE RID: 23470 RVA: 0x001D9848 File Offset: 0x001D7A48
	public Popularity GetCurrentPopularityConfig()
	{
		int popularityValue = MoonChasingModel.Instance.GetPopularityValue();
		return this.GetPopularityConfigByValue(popularityValue);
	}

	// Token: 0x06005BAF RID: 23471 RVA: 0x001D9868 File Offset: 0x001D7A68
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

	// Token: 0x06005BB0 RID: 23472 RVA: 0x001D98C0 File Offset: 0x001D7AC0
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

	// Token: 0x06005BB1 RID: 23473 RVA: 0x001D991C File Offset: 0x001D7B1C
	public void SetIsInDelegate(bool value)
	{
		this.IsInDelegateInternal = value;
		if (!value)
		{
			EventSystem.Instance.Emit(EEventName.ConditionUnlockRole);
		}
	}

	// Token: 0x17000BBF RID: 3007
	// (get) Token: 0x06005BB2 RID: 23474 RVA: 0x001D9938 File Offset: 0x001D7B38
	public static MoonChasingBusinessModel Instance
	{
		get
		{
			return MoonChasingBusinessModel._Instance;
		}
	}

	// Token: 0x06005BB3 RID: 23475 RVA: 0x001D993F File Offset: 0x001D7B3F
	public static MoonChasingBusinessModel GetOrCreateInstance()
	{
		if (MoonChasingBusinessModel._Instance == null)
		{
			MoonChasingBusinessModel.CreateInstance();
		}
		return MoonChasingBusinessModel._Instance;
	}

	// Token: 0x06005BB4 RID: 23476 RVA: 0x001D9953 File Offset: 0x001D7B53
	public static bool CreateInstance()
	{
		if (MoonChasingBusinessModel._Instance != null)
		{
			return true;
		}
		MoonChasingBusinessModel._Instance = new MoonChasingBusinessModel();
		return true;
	}

	// Token: 0x06005BB5 RID: 23477 RVA: 0x001D9969 File Offset: 0x001D7B69
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005BB6 RID: 23478 RVA: 0x001D996B File Offset: 0x001D7B6B
	public static void ResetStaticDefaultValue()
	{
		MoonChasingBusinessModel._Instance = null;
	}

	// Token: 0x06005BB7 RID: 23479 RVA: 0x001D9973 File Offset: 0x001D7B73
	static MoonChasingBusinessModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonChasingBusinessModel.CreateStaticDefaultValue), new Action(MoonChasingBusinessModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003D42 RID: 15682
	private readonly Dictionary<int, DelegationData> DelegationDataMap = new Dictionary<int, DelegationData>();

	// Token: 0x04003D43 RID: 15683
	private readonly Dictionary<int, EditTeamData> EditTeamDataMap = new Dictionary<int, EditTeamData>();

	// Token: 0x04003D44 RID: 15684
	private DelegationResultData DelegationResultDataInternal;

	// Token: 0x04003D45 RID: 15685
	private readonly List<int> UnlockRoleIdList = new List<int>();

	// Token: 0x04003D46 RID: 15686
	private bool IsInDelegateInternal;

	// Token: 0x04003D47 RID: 15687
	[Nullable(2)]
	private static MoonChasingBusinessModel _Instance;
}
