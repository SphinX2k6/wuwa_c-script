using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001BF7 RID: 7159
[NullableContext(1)]
[Nullable(0)]
public class FormationModel : ModelBase
{
	// Token: 0x0600D54C RID: 54604 RVA: 0x00312080 File Offset: 0x00310280
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
				formationData.AddRoleData(item2.RoleId, item2.RoleSkinId, item2.Level, item3, item4, item2.SkillBranchId, new FormationRoleEquip
				{
					WeaponId = item2.WeaponId,
					WeaponBreachLevel = item2.WeaponBreachLevel,
					WeaponSkinId = item2.WeaponSkinId,
					DressList = item2.DressList.ToArray<int>()
				});
			}
			if (key == num)
			{
				this.CurrentFormationDataInternal = formationData;
			}
		}
	}

	// Token: 0x0600D54D RID: 54605 RVA: 0x0031238C File Offset: 0x0031058C
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

	// Token: 0x0600D54E RID: 54606 RVA: 0x003123E0 File Offset: 0x003105E0
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

	// Token: 0x0600D54F RID: 54607 RVA: 0x00312550 File Offset: 0x00310750
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

	// Token: 0x0600D550 RID: 54608 RVA: 0x00312630 File Offset: 0x00310830
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

	// Token: 0x0600D551 RID: 54609 RVA: 0x00312650 File Offset: 0x00310850
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

	// Token: 0x17001198 RID: 4504
	// (get) Token: 0x0600D552 RID: 54610 RVA: 0x00312688 File Offset: 0x00310888
	[Nullable(2)]
	public FormationData CurrentFormationData
	{
		[NullableContext(2)]
		get
		{
			return this.CurrentFormationDataInternal;
		}
	}

	// Token: 0x17001199 RID: 4505
	// (get) Token: 0x0600D553 RID: 54611 RVA: 0x00312690 File Offset: 0x00310890
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

	// Token: 0x0600D554 RID: 54612 RVA: 0x003126BB File Offset: 0x003108BB
	public bool IsRoleInCurrentFormation(int roleId)
	{
		FormationData currentFormationDataInternal = this.CurrentFormationDataInternal;
		return currentFormationDataInternal != null && currentFormationDataInternal.RoleIdList.Contains(roleId);
	}

	// Token: 0x0600D555 RID: 54613 RVA: 0x003126D4 File Offset: 0x003108D4
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

	// Token: 0x0600D556 RID: 54614 RVA: 0x00312720 File Offset: 0x00310920
	public void InitEditingFormationMap()
	{
		this.EditingFormationMap.Clear();
		foreach (FormationData formationData in this.FormationDataMap.Values)
		{
			int formationId = formationData.FormationId;
			foreach (FormationRoleData formationRoleData in formationData.GetRoleDataMap().Values)
			{
				this.SetEditingRoleId(formationId, formationRoleData.Position, formationRoleData.ConfigId, true);
			}
		}
	}

	// Token: 0x0600D557 RID: 54615 RVA: 0x003127D8 File Offset: 0x003109D8
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

	// Token: 0x0600D558 RID: 54616 RVA: 0x00312944 File Offset: 0x00310B44
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

	// Token: 0x0600D559 RID: 54617 RVA: 0x003129B4 File Offset: 0x00310BB4
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

	// Token: 0x0600D55A RID: 54618 RVA: 0x00312A24 File Offset: 0x00310C24
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

	// Token: 0x0600D55B RID: 54619 RVA: 0x00312AA4 File Offset: 0x00310CA4
	public HashSet<int> GetEditingRoleIdSet(int editFormationId)
	{
		return new HashSet<int>(this.GetEditingRoleIdList(editFormationId));
	}

	// Token: 0x0600D55C RID: 54620 RVA: 0x00312AB4 File Offset: 0x00310CB4
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

	// Token: 0x0600D55D RID: 54621 RVA: 0x00312B78 File Offset: 0x00310D78
	public Dictionary<int, int[]> CreateEditingFormationSnapshot()
	{
		Dictionary<int, int[]> dictionary = new Dictionary<int, int[]>();
		foreach (KeyValuePair<int, List<EditingRoleData_Tmp>> keyValuePair in this.EditingFormationMap)
		{
			dictionary[keyValuePair.Key] = (from roleData in keyValuePair.Value
			orderby roleData.Position
			select roleData.RoleId).ToArray<int>();
		}
		return dictionary;
	}

	// Token: 0x0600D55E RID: 54622 RVA: 0x00312C2C File Offset: 0x00310E2C
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

	// Token: 0x0600D55F RID: 54623 RVA: 0x00312CD4 File Offset: 0x00310ED4
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

	// Token: 0x0600D560 RID: 54624 RVA: 0x00312D19 File Offset: 0x00310F19
	[NullableContext(2)]
	public FormationViewSwitchCache TakeViewSwitchCache()
	{
		FormationViewSwitchCache viewSwitchCache = this.ViewSwitchCache;
		this.ViewSwitchCache = null;
		return viewSwitchCache;
	}

	// Token: 0x0600D561 RID: 54625 RVA: 0x00312D28 File Offset: 0x00310F28
	public void ClearViewSwitchCache()
	{
		this.ViewSwitchCache = null;
	}

	// Token: 0x0600D562 RID: 54626 RVA: 0x00312D31 File Offset: 0x00310F31
	public bool IsViewSwitching()
	{
		return this.IsViewSwitchingInternal;
	}

	// Token: 0x0600D563 RID: 54627 RVA: 0x00312D39 File Offset: 0x00310F39
	public void SetViewSwitching(bool isSwitching)
	{
		this.IsViewSwitchingInternal = isSwitching;
	}

	// Token: 0x0600D564 RID: 54628 RVA: 0x00312D42 File Offset: 0x00310F42
	public bool IsInEditingFormation(int editFormationId, int configId)
	{
		return this.GetEditingRolePosition(editFormationId, configId) > 0;
	}

	// Token: 0x0600D565 RID: 54629 RVA: 0x00312D50 File Offset: 0x00310F50
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

	// Token: 0x0600D566 RID: 54630 RVA: 0x00312DC8 File Offset: 0x00310FC8
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

	// Token: 0x0600D567 RID: 54631 RVA: 0x00312E34 File Offset: 0x00311034
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

	// Token: 0x0600D568 RID: 54632 RVA: 0x00312EC0 File Offset: 0x003110C0
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
		return hashSet.ToArray<int>();
	}

	// Token: 0x0600D569 RID: 54633 RVA: 0x00312F68 File Offset: 0x00311168
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

	// Token: 0x0600D56A RID: 54634 RVA: 0x00313000 File Offset: 0x00311200
	public bool IsEditingFormationHasSpecialTrialRole()
	{
		using (Dictionary<int, int[]>.ValueCollection.Enumerator enumerator = this.GetAllEditingFormation().Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Any((int id) => RoleUtils.IsSpecialTrialRole(id)))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600D56B RID: 54635 RVA: 0x00313080 File Offset: 0x00311280
	public bool IsCurrentFormationHasSpecialTrialRole()
	{
		FormationData currentFormationDataInternal = this.CurrentFormationDataInternal;
		if (currentFormationDataInternal == null)
		{
			return false;
		}
		return currentFormationDataInternal.RoleIdList.Any((int id) => RoleUtils.IsSpecialTrialRole(id));
	}

	// Token: 0x1700119A RID: 4506
	// (get) Token: 0x0600D56C RID: 54636 RVA: 0x003130B7 File Offset: 0x003112B7
	public static FormationModel Instance
	{
		get
		{
			return FormationModel._Instance;
		}
	}

	// Token: 0x0600D56D RID: 54637 RVA: 0x003130BE File Offset: 0x003112BE
	public static FormationModel GetOrCreateInstance()
	{
		if (FormationModel._Instance == null)
		{
			FormationModel.CreateInstance();
		}
		return FormationModel._Instance;
	}

	// Token: 0x0600D56E RID: 54638 RVA: 0x003130D2 File Offset: 0x003112D2
	public static bool CreateInstance()
	{
		if (FormationModel._Instance != null)
		{
			return true;
		}
		FormationModel._Instance = new FormationModel();
		return true;
	}

	// Token: 0x0600D56F RID: 54639 RVA: 0x003130E8 File Offset: 0x003112E8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D570 RID: 54640 RVA: 0x003130EA File Offset: 0x003112EA
	public static void ResetStaticDefaultValue()
	{
		FormationModel._Instance = null;
	}

	// Token: 0x0600D571 RID: 54641 RVA: 0x003130F2 File Offset: 0x003112F2
	static FormationModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationModel.CreateStaticDefaultValue), new Action(FormationModel.ResetStaticDefaultValue));
	}

	// Token: 0x040061B8 RID: 25016
	private const int HEALTH_ATTR_ID = 3;

	// Token: 0x040061B9 RID: 25017
	private readonly Dictionary<int, FormationData> FormationDataMap = new Dictionary<int, FormationData>();

	// Token: 0x040061BA RID: 25018
	[Nullable(2)]
	private FormationData CurrentFormationDataInternal;

	// Token: 0x040061BB RID: 25019
	private readonly Dictionary<int, List<EditingRoleData_Tmp>> EditingFormationMap = new Dictionary<int, List<EditingRoleData_Tmp>>();

	// Token: 0x040061BC RID: 25020
	[Nullable(2)]
	private FormationViewSwitchCache ViewSwitchCache;

	// Token: 0x040061BD RID: 25021
	private bool IsViewSwitchingInternal;

	// Token: 0x040061BE RID: 25022
	[Nullable(2)]
	private static FormationModel _Instance;
}
