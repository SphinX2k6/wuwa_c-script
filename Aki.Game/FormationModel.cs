using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020010B6 RID: 4278
[NullableContext(1)]
[Nullable(0)]
public class FormationModel : ModelBase
{
	// Token: 0x0600A95F RID: 43359 RVA: 0x0031D334 File Offset: 0x0031B534
	public void UpdatePlayerFormations(IList<PlayerFightFormations> playerFormations)
	{
		this.FormationDataMap.Clear();
		int? id = PlayerInfoModel.Instance.GetId();
		int num = 0;
		Dictionary<int, List<ValueTuple<Aki.Protocol.FormationRoleInfo, int, bool>>> dictionary = new Dictionary<int, List<ValueTuple<Aki.Protocol.FormationRoleInfo, int, bool>>>();
		Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
		foreach (PlayerFightFormations playerFightFormations in playerFormations)
		{
			int playerId = playerFightFormations.PlayerId;
			int num2 = playerId;
			int? num3 = id;
			bool flag = num2 == num3.GetValueOrDefault() & num3 != null;
			foreach (FightFormationNotifyInfo fightFormationNotifyInfo in playerFightFormations.Formations)
			{
				int formationId = fightFormationNotifyInfo.FormationId;
				if (flag || formationId <= 0)
				{
					if (flag && fightFormationNotifyInfo.IsCurrent)
					{
						num = formationId;
					}
					dictionary2[formationId] = (fightFormationNotifyInfo.Name ?? string.Empty);
					List<ValueTuple<Aki.Protocol.FormationRoleInfo, int, bool>> list;
					if (!dictionary.TryGetValue(formationId, out list))
					{
						list = new List<ValueTuple<Aki.Protocol.FormationRoleInfo, int, bool>>();
						dictionary[formationId] = list;
					}
					foreach (Aki.Protocol.FormationRoleInfo formationRoleInfo in fightFormationNotifyInfo.RoleInfos)
					{
						bool item = flag && formationRoleInfo.RoleId == fightFormationNotifyInfo.CurRole;
						list.Add(new ValueTuple<Aki.Protocol.FormationRoleInfo, int, bool>(formationRoleInfo, playerId, item));
					}
				}
			}
		}
		foreach (KeyValuePair<int, List<ValueTuple<Aki.Protocol.FormationRoleInfo, int, bool>>> keyValuePair in dictionary)
		{
			int key = keyValuePair.Key;
			List<ValueTuple<Aki.Protocol.FormationRoleInfo, int, bool>> value = keyValuePair.Value;
			FormationData formationData = new FormationData(key);
			formationData.Name = dictionary2.GetValueOrDefault(key, string.Empty);
			this.FormationDataMap[key] = formationData;
			foreach (ValueTuple<Aki.Protocol.FormationRoleInfo, int, bool> valueTuple in value)
			{
				Aki.Protocol.FormationRoleInfo item2 = valueTuple.Item1;
				int item3 = valueTuple.Item2;
				bool item4 = valueTuple.Item3;
				int[] array = new int[item2.DressList.Count];
				item2.DressList.CopyTo(array, 0);
				formationData.AddRoleData(item2.RoleId, item2.RoleSkinId, item2.Level, item3, item4, item2.SkillBranchId, new FormationRoleEquip
				{
					WeaponId = item2.WeaponId,
					WeaponBreachLevel = item2.WeaponBreachLevel,
					WeaponSkinId = item2.WeaponSkinId,
					DressList = array
				});
			}
			if (key == num)
			{
				this.CurrentFormationDataInternal = formationData;
			}
		}
	}

	// Token: 0x0600A960 RID: 43360 RVA: 0x0031D658 File Offset: 0x0031B858
	public void ApplyCurrentFormationData(int formationId)
	{
		FormationData currentFormationDataInternal;
		if (!this.FormationDataMap.TryGetValue(formationId, out currentFormationDataInternal))
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Formation;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "[Formation] 应用当前编队";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("formationId", formationId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.CurrentFormationDataInternal = currentFormationDataInternal;
	}

	// Token: 0x0600A961 RID: 43361 RVA: 0x0031D6AC File Offset: 0x0031B8AC
	public unsafe void ReorderFormation(int formationId, int targetId)
	{
		int maxFormationId = FormationConfig.Instance.GetMaxFormationId();
		if (formationId < 1 || formationId > maxFormationId || targetId < 1 || targetId > maxFormationId)
		{
			return;
		}
		List<int> list = new List<int>();
		for (int i = 1; i <= maxFormationId; i++)
		{
			list.Add(i);
		}
		list.RemoveAt(formationId - 1);
		list.Insert(targetId - 1, formationId);
		Dictionary<int, FormationData> dictionary = new Dictionary<int, FormationData>();
		Dictionary<int, List<EditingRoleData_Tmp>> dictionary2 = new Dictionary<int, List<EditingRoleData_Tmp>>();
		for (int j = 1; j <= maxFormationId; j++)
		{
			FormationData value;
			if (this.FormationDataMap.Remove(j, out value))
			{
				dictionary[j] = value;
			}
			List<EditingRoleData_Tmp> value2;
			if (this.EditingFormationMap.Remove(j, out value2))
			{
				dictionary2[j] = value2;
			}
		}
		for (int k = 0; k < list.Count; k++)
		{
			int num = k + 1;
			int key = list[k];
			FormationData formationData;
			if (dictionary.TryGetValue(key, out formationData))
			{
				formationData.FormationId = num;
				this.FormationDataMap[num] = formationData;
			}
			List<EditingRoleData_Tmp> value3;
			if (dictionary2.TryGetValue(key, out value3))
			{
				this.EditingFormationMap[num] = value3;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Formation;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "[Formation] 编队重排落地";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("formationId", formationId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("targetId", targetId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0600A962 RID: 43362 RVA: 0x0031D81C File Offset: 0x0031BA1C
	public void ChangeEditedMainRole()
	{
		RoleModel instance = RoleModel.Instance;
		foreach (List<EditingRoleData_Tmp> list in this.EditingFormationMap.Values)
		{
			foreach (EditingRoleData_Tmp editingRoleData_Tmp in list)
			{
				if (instance.IsMainRole(editingRoleData_Tmp.RoleId))
				{
					int? newMainRoleId = instance.GetNewMainRoleId(editingRoleData_Tmp.RoleId);
					if (newMainRoleId != null)
					{
						int roleId = editingRoleData_Tmp.RoleId;
						int? num = newMainRoleId;
						if (!(roleId == num.GetValueOrDefault() & num != null))
						{
							editingRoleData_Tmp.RoleId = newMainRoleId.Value;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A963 RID: 43363 RVA: 0x0031D8FC File Offset: 0x0031BAFC
	[NullableContext(2)]
	public FormationData GetFormationData(int formationId)
	{
		FormationData result;
		if (this.FormationDataMap.TryGetValue(formationId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600A964 RID: 43364 RVA: 0x0031D91C File Offset: 0x0031BB1C
	public void SetFormationName(int formationId, string name)
	{
		FormationData formationData;
		if (!this.FormationDataMap.TryGetValue(formationId, out formationData))
		{
			formationData = new FormationData(formationId);
			this.FormationDataMap[formationId] = formationData;
		}
		formationData.Name = name;
	}

	// Token: 0x170011BD RID: 4541
	// (get) Token: 0x0600A965 RID: 43365 RVA: 0x0031D954 File Offset: 0x0031BB54
	[Nullable(2)]
	public FormationData CurrentFormationData
	{
		[NullableContext(2)]
		get
		{
			return this.CurrentFormationDataInternal;
		}
	}

	// Token: 0x170011BE RID: 4542
	// (get) Token: 0x0600A966 RID: 43366 RVA: 0x0031D95C File Offset: 0x0031BB5C
	public int? CurrentFormationId
	{
		get
		{
			FormationData currentFormationDataInternal = this.CurrentFormationDataInternal;
			if (currentFormationDataInternal == null)
			{
				return null;
			}
			return new int?(currentFormationDataInternal.FormationId);
		}
	}

	// Token: 0x0600A967 RID: 43367 RVA: 0x0031D987 File Offset: 0x0031BB87
	public bool IsRoleInCurrentFormation(int roleId)
	{
		FormationData currentFormationDataInternal = this.CurrentFormationDataInternal;
		return currentFormationDataInternal != null && currentFormationDataInternal.RoleIdList.Contains(roleId);
	}

	// Token: 0x0600A968 RID: 43368 RVA: 0x0031D9A0 File Offset: 0x0031BBA0
	public int GetCurrentFormationSkillBranchId(int position)
	{
		FormationData currentFormationDataInternal = this.CurrentFormationDataInternal;
		int? num;
		if (currentFormationDataInternal == null)
		{
			num = null;
		}
		else
		{
			FormationRoleData roleDataByPosition = currentFormationDataInternal.GetRoleDataByPosition(position);
			num = ((roleDataByPosition != null) ? new int?(roleDataByPosition.MultiSkillBranchIndex) : null);
		}
		int? num2 = num;
		return num2.GetValueOrDefault();
	}

	// Token: 0x0600A969 RID: 43369 RVA: 0x0031D9EC File Offset: 0x0031BBEC
	public void InitEditingFormationMap()
	{
		this.EditingFormationMap.Clear();
		foreach (FormationData formationData in this.FormationDataMap.Values)
		{
			int formationId = formationData.FormationId;
			foreach (FormationRoleData formationRoleData in formationData.GetRoleDataMap().Values)
			{
				formationRoleData.PlayerName = null;
				formationRoleData.ThirdPartyOnlineId = null;
				formationRoleData.OnlineIndex = null;
				this.SetEditingRoleId(formationId, formationRoleData.Position, formationRoleData.ConfigId, true);
			}
		}
	}

	// Token: 0x0600A96A RID: 43370 RVA: 0x0031DABC File Offset: 0x0031BCBC
	public bool SetEditingRoleId(int editFormationId, int editPosition, int roleId = 0, bool fillEmpty = true)
	{
		if (editPosition > 3 || editPosition <= 0)
		{
			return false;
		}
		if (!this.IsMyPosition(editPosition))
		{
			return false;
		}
		List<EditingRoleData_Tmp> list;
		if (!this.EditingFormationMap.TryGetValue(editFormationId, out list))
		{
			list = new List<EditingRoleData_Tmp>();
			for (int i = 1; i <= 3; i++)
			{
				list.Add(new EditingRoleData_Tmp(i));
			}
			this.EditingFormationMap[editFormationId] = list;
		}
		foreach (EditingRoleData_Tmp editingRoleData_Tmp in list)
		{
			if (editingRoleData_Tmp.Position == editPosition)
			{
				editingRoleData_Tmp.RoleId = roleId;
				break;
			}
		}
		if (GameModeModel.Instance.IsMulti || !fillEmpty)
		{
			return true;
		}
		List<int> list2 = new List<int>();
		foreach (EditingRoleData_Tmp editingRoleData_Tmp2 in list)
		{
			if (editingRoleData_Tmp2.RoleId > 0)
			{
				list2.Add(editingRoleData_Tmp2.RoleId);
			}
		}
		foreach (EditingRoleData_Tmp editingRoleData_Tmp3 in list)
		{
			int num = editingRoleData_Tmp3.Position - 1;
			editingRoleData_Tmp3.RoleId = ((num < list2.Count) ? list2[num] : 0);
		}
		return true;
	}

	// Token: 0x0600A96B RID: 43371 RVA: 0x0031DC28 File Offset: 0x0031BE28
	public int GetEditingRoleId(int editFormationId, int position)
	{
		List<EditingRoleData_Tmp> list;
		if (!this.EditingFormationMap.TryGetValue(editFormationId, out list))
		{
			return 0;
		}
		foreach (EditingRoleData_Tmp editingRoleData_Tmp in list)
		{
			if (editingRoleData_Tmp.Position == position)
			{
				return editingRoleData_Tmp.RoleId;
			}
		}
		return 0;
	}

	// Token: 0x0600A96C RID: 43372 RVA: 0x0031DC98 File Offset: 0x0031BE98
	public int GetEditingRolePosition(int editFormationId, int roleConfigId)
	{
		List<EditingRoleData_Tmp> list;
		if (!this.EditingFormationMap.TryGetValue(editFormationId, out list))
		{
			return -1;
		}
		foreach (EditingRoleData_Tmp editingRoleData_Tmp in list)
		{
			if (editingRoleData_Tmp.RoleId == roleConfigId)
			{
				return editingRoleData_Tmp.Position;
			}
		}
		return -1;
	}

	// Token: 0x0600A96D RID: 43373 RVA: 0x0031DD08 File Offset: 0x0031BF08
	public int[] GetEditingRoleIdList(int editFormationId)
	{
		List<EditingRoleData_Tmp> list;
		if (!this.EditingFormationMap.TryGetValue(editFormationId, out list))
		{
			return new int[0];
		}
		List<int> list2 = new List<int>();
		foreach (EditingRoleData_Tmp editingRoleData_Tmp in list)
		{
			if (editingRoleData_Tmp.RoleId > 0)
			{
				list2.Add(editingRoleData_Tmp.RoleId);
			}
		}
		return list2.ToArray();
	}

	// Token: 0x0600A96E RID: 43374 RVA: 0x0031DD88 File Offset: 0x0031BF88
	public HashSet<int> GetEditingRoleIdSet(int editFormationId)
	{
		return new HashSet<int>(this.GetEditingRoleIdList(editFormationId));
	}

	// Token: 0x0600A96F RID: 43375 RVA: 0x0031DD98 File Offset: 0x0031BF98
	public Dictionary<int, int[]> GetAllEditingFormation()
	{
		Dictionary<int, int[]> dictionary = new Dictionary<int, int[]>();
		foreach (KeyValuePair<int, List<EditingRoleData_Tmp>> keyValuePair in this.EditingFormationMap)
		{
			List<int> list = new List<int>();
			foreach (EditingRoleData_Tmp editingRoleData_Tmp in keyValuePair.Value)
			{
				if (editingRoleData_Tmp.RoleId > 0)
				{
					list.Add(editingRoleData_Tmp.RoleId);
				}
			}
			dictionary[keyValuePair.Key] = list.ToArray();
		}
		return dictionary;
	}

	// Token: 0x0600A970 RID: 43376 RVA: 0x0031DE5C File Offset: 0x0031C05C
	public Dictionary<int, int[]> CreateEditingFormationSnapshot()
	{
		Dictionary<int, int[]> dictionary = new Dictionary<int, int[]>(this.EditingFormationMap.Count);
		foreach (KeyValuePair<int, List<EditingRoleData_Tmp>> keyValuePair in this.EditingFormationMap)
		{
			dictionary[keyValuePair.Key] = NoLinq.SelectToArray<EditingRoleData_Tmp, int>(keyValuePair.Value, (EditingRoleData_Tmp role) => role.RoleId);
		}
		return dictionary;
	}

	// Token: 0x0600A971 RID: 43377 RVA: 0x0031DEF4 File Offset: 0x0031C0F4
	public void RestoreEditingFormationSnapshot(Dictionary<int, int[]> snapshot)
	{
		this.EditingFormationMap.Clear();
		foreach (KeyValuePair<int, int[]> keyValuePair in snapshot)
		{
			List<EditingRoleData_Tmp> list = new List<EditingRoleData_Tmp>();
			for (int i = 0; i < 3; i++)
			{
				list.Add(new EditingRoleData_Tmp(i + 1)
				{
					RoleId = ((i < keyValuePair.Value.Length) ? keyValuePair.Value[i] : 0)
				});
			}
			this.EditingFormationMap[keyValuePair.Key] = list;
		}
	}

	// Token: 0x0600A972 RID: 43378 RVA: 0x0031DF9C File Offset: 0x0031C19C
	public void SetViewSwitchCache(int editFormationId, int goBattleFormationId)
	{
		this.ViewSwitchCache = new FormationViewSwitchCache
		{
			EditFormationId = editFormationId,
			GoBattleFormationId = goBattleFormationId,
			EditingSnapshot = this.CreateEditingFormationSnapshot(),
			SwitchStartTimeMs = DateTimeOffset.Now.ToUnixTimeMilliseconds()
		};
	}

	// Token: 0x0600A973 RID: 43379 RVA: 0x0031DFE1 File Offset: 0x0031C1E1
	[NullableContext(2)]
	public FormationViewSwitchCache TakeViewSwitchCache()
	{
		FormationViewSwitchCache viewSwitchCache = this.ViewSwitchCache;
		this.ViewSwitchCache = null;
		return viewSwitchCache;
	}

	// Token: 0x0600A974 RID: 43380 RVA: 0x0031DFF0 File Offset: 0x0031C1F0
	public void ClearViewSwitchCache()
	{
		this.ViewSwitchCache = null;
	}

	// Token: 0x0600A975 RID: 43381 RVA: 0x0031DFF9 File Offset: 0x0031C1F9
	public bool IsViewSwitching()
	{
		return this.IsViewSwitchingInternal;
	}

	// Token: 0x0600A976 RID: 43382 RVA: 0x0031E001 File Offset: 0x0031C201
	public void SetViewSwitching(bool isSwitching)
	{
		this.IsViewSwitchingInternal = isSwitching;
	}

	// Token: 0x0600A977 RID: 43383 RVA: 0x0031E00A File Offset: 0x0031C20A
	public bool IsInEditingFormation(int editFormationId, int configId)
	{
		return this.GetEditingRolePosition(editFormationId, configId) > 0;
	}

	// Token: 0x0600A978 RID: 43384 RVA: 0x0031E018 File Offset: 0x0031C218
	public bool IsRoleDead(int roleConfigId)
	{
		SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)roleConfigId, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.ConfigId,
			OnlyMyRole = new bool?(true)
		});
		bool flag;
		if (teamItem == null)
		{
			flag = (null != null);
		}
		else
		{
			EntityHandle entityHandle = teamItem.EntityHandle;
			flag = (((entityHandle != null) ? entityHandle.Entity : null) != null);
		}
		if (flag)
		{
			return teamItem.IsDead();
		}
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleConfigId, true);
		return roleDataById == null || roleDataById.GetAttributeData().GetAttrValueById(3) <= 0;
	}

	// Token: 0x0600A979 RID: 43385 RVA: 0x0031E090 File Offset: 0x0031C290
	public bool IsMyPosition(int position)
	{
		if (!GameModeModel.Instance.IsMulti)
		{
			return true;
		}
		bool isMyTeam = OnlineModel.Instance.GetIsMyTeam();
		FormationData currentFormationDataInternal = this.CurrentFormationDataInternal;
		FormationRoleData formationRoleData = (currentFormationDataInternal != null) ? currentFormationDataInternal.GetRoleDataByPosition(position) : null;
		if (formationRoleData == null || formationRoleData.ConfigId == 0)
		{
			return isMyTeam;
		}
		int? id = PlayerInfoModel.Instance.GetId();
		int playerId = formationRoleData.PlayerId;
		return id.GetValueOrDefault() == playerId & id != null;
	}

	// Token: 0x0600A97A RID: 43386 RVA: 0x0031E0FC File Offset: 0x0031C2FC
	public float GetFormationAverageLevel()
	{
		float num = 0f;
		int num2 = 0;
		foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(false))
		{
			WorldEntity entity = entityHandle.Entity;
			BaseAttributeComponent baseAttributeComponent = (entity != null) ? entity.GetComponent<BaseAttributeComponent>() : null;
			if (baseAttributeComponent != null)
			{
				num += baseAttributeComponent.GetCurrentValue(EAttributeType.Lv);
				num2++;
			}
		}
		if (num2 <= 0)
		{
			return 0f;
		}
		return num / (float)num2;
	}

	// Token: 0x0600A97B RID: 43387 RVA: 0x0031E188 File Offset: 0x0031C388
	public int[] GetFormationAllSpecialTrialRole()
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (FormationData formationData in this.FormationDataMap.Values)
		{
			foreach (int num in formationData.GetRoleIdListWithTrial(true))
			{
				if (RoleUtils.IsSpecialTrialRole(num))
				{
					hashSet.Add(num);
				}
			}
		}
		int[] array = new int[hashSet.Count];
		hashSet.CopyTo(array);
		return array;
	}

	// Token: 0x0600A97C RID: 43388 RVA: 0x0031E240 File Offset: 0x0031C440
	public bool IsFormationHasSpecialTrialRole()
	{
		foreach (FormationData formationData in this.FormationDataMap.Values)
		{
			using (List<int>.Enumerator enumerator2 = formationData.GetRoleIdListWithTrial(true).GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (RoleUtils.IsSpecialTrialRole(enumerator2.Current))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600A97D RID: 43389 RVA: 0x0031E2D8 File Offset: 0x0031C4D8
	public bool IsEditingFormationHasSpecialTrialRole()
	{
		foreach (int[] array in this.GetAllEditingFormation().Values)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (RoleUtils.IsSpecialTrialRole(array[i]))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600A97E RID: 43390 RVA: 0x0031E348 File Offset: 0x0031C548
	public bool IsCurrentFormationHasSpecialTrialRole()
	{
		FormationData currentFormationDataInternal = this.CurrentFormationDataInternal;
		List<int> list = (currentFormationDataInternal != null) ? currentFormationDataInternal.RoleIdList : null;
		if (list == null)
		{
			return false;
		}
		using (List<int>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (RoleUtils.IsSpecialTrialRole(enumerator.Current))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x170011BF RID: 4543
	// (get) Token: 0x0600A97F RID: 43391 RVA: 0x0031E3B4 File Offset: 0x0031C5B4
	public static FormationModel Instance
	{
		get
		{
			return FormationModel._Instance;
		}
	}

	// Token: 0x0600A980 RID: 43392 RVA: 0x0031E3BB File Offset: 0x0031C5BB
	public static FormationModel GetOrCreateInstance()
	{
		if (FormationModel._Instance == null)
		{
			FormationModel.CreateInstance();
		}
		return FormationModel._Instance;
	}

	// Token: 0x0600A981 RID: 43393 RVA: 0x0031E3CF File Offset: 0x0031C5CF
	public static bool CreateInstance()
	{
		if (FormationModel._Instance != null)
		{
			return true;
		}
		FormationModel._Instance = new FormationModel();
		return true;
	}

	// Token: 0x0600A982 RID: 43394 RVA: 0x0031E3E5 File Offset: 0x0031C5E5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A983 RID: 43395 RVA: 0x0031E3E7 File Offset: 0x0031C5E7
	public static void ResetStaticDefaultValue()
	{
		FormationModel._Instance = null;
	}

	// Token: 0x0600A984 RID: 43396 RVA: 0x0031E3EF File Offset: 0x0031C5EF
	static FormationModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationModel.CreateStaticDefaultValue), new Action(FormationModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400628A RID: 25226
	private const int HEALTH_ATTR_ID = 3;

	// Token: 0x0400628B RID: 25227
	private readonly Dictionary<int, FormationData> FormationDataMap = new Dictionary<int, FormationData>();

	// Token: 0x0400628C RID: 25228
	[Nullable(2)]
	private FormationData CurrentFormationDataInternal;

	// Token: 0x0400628D RID: 25229
	private readonly Dictionary<int, List<EditingRoleData_Tmp>> EditingFormationMap = new Dictionary<int, List<EditingRoleData_Tmp>>();

	// Token: 0x0400628E RID: 25230
	[Nullable(2)]
	private FormationViewSwitchCache ViewSwitchCache;

	// Token: 0x0400628F RID: 25231
	private bool IsViewSwitchingInternal;

	// Token: 0x04006290 RID: 25232
	[Nullable(2)]
	private static FormationModel _Instance;
}
