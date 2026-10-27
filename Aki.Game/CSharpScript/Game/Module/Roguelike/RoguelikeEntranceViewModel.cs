using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DD7 RID: 19927
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeEntranceViewModel
	{
		// Token: 0x060336F3 RID: 210675 RVA: 0x00C03440 File Offset: 0x00C01640
		public UniTask InitAsync(int instanceId)
		{
			RoguelikeEntranceViewModel.<InitAsync>d__1 <InitAsync>d__;
			<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAsync>d__.<>4__this = this;
			<InitAsync>d__.instanceId = instanceId;
			<InitAsync>d__.<>1__state = -1;
			<InitAsync>d__.<>t__builder.Start<RoguelikeEntranceViewModel.<InitAsync>d__1>(ref <InitAsync>d__);
			return <InitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17007EB9 RID: 32441
		// (get) Token: 0x060336F4 RID: 210676 RVA: 0x00C0348B File Offset: 0x00C0168B
		// (set) Token: 0x060336F5 RID: 210677 RVA: 0x00C03494 File Offset: 0x00C01694
		public int CurrentEntriesGroupIndex
		{
			get
			{
				return this.CurrentEntriesGroupIndexInternal;
			}
			set
			{
				if (!this.EntriesDataGroupList[value].IsUnlock)
				{
					RogueInst value2 = RoguelikeConfig.Instance.GetRogueInstConfig(this.InstanceId).Value;
					int id = this.EntriesDataGroupList[value].Id;
					string textId = null;
					for (int i = 0; i < value2.UnlockTipsLength; i++)
					{
						DicIntString? dicIntString = value2.UnlockTips(i);
						if (dicIntString != null && dicIntString.Value.Key == id)
						{
							textId = dicIntString.Value.Value;
							break;
						}
					}
					ScrollingTipsController.Instance.ShowTipsByTextId(textId, Array.Empty<object>());
					return;
				}
				this.CurrentEntriesGroupIndexInternal = value;
				this.UpdateCurrentActiveOverviewId();
				for (int j = 0; j < this.EntriesDataGroupList.Count; j++)
				{
					this.EntriesDataGroupList[j].IsActive = (j <= value);
					this.EntriesDataGroupList[j].IsFocus = (j == this.CurrentEntriesGroupIndexInternal);
				}
				Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RoguelikeInstanceSelectGroupIndex, null);
				if (dictionary == null)
				{
					dictionary = new Dictionary<int, int>();
				}
				dictionary[this.InstanceId] = this.CurrentEntriesGroupIndex;
				LocalStorage.SetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RoguelikeInstanceSelectGroupIndex, dictionary);
			}
		}

		// Token: 0x17007EBA RID: 32442
		// (get) Token: 0x060336F6 RID: 210678 RVA: 0x00C035D6 File Offset: 0x00C017D6
		public RoguelikeEntriesGroupData CurrentEntriesGroupData
		{
			get
			{
				return this.EntriesDataGroupList[this.CurrentEntriesGroupIndex];
			}
		}

		// Token: 0x17007EBB RID: 32443
		// (get) Token: 0x060336F7 RID: 210679 RVA: 0x00C035E9 File Offset: 0x00C017E9
		public bool IsReduceMultiplierAvailable
		{
			get
			{
				return this.CurrentEntriesGroupIndex > this.EntriesGroupAvailableIndexRange.Item1;
			}
		}

		// Token: 0x17007EBC RID: 32444
		// (get) Token: 0x060336F8 RID: 210680 RVA: 0x00C035FE File Offset: 0x00C017FE
		public bool IsAddMultiplierAvailable
		{
			get
			{
				return this.CurrentEntriesGroupIndex < this.EntriesGroupAvailableIndexRange.Item2;
			}
		}

		// Token: 0x060336F9 RID: 210681 RVA: 0x00C03613 File Offset: 0x00C01813
		[NullableContext(2)]
		public void SetCurrentSelectEntryData(RoguelikeEntryData entryData)
		{
			this.CurrentSelectEntryData = entryData;
		}

		// Token: 0x060336FA RID: 210682 RVA: 0x00C0361C File Offset: 0x00C0181C
		private void InitEntries(RogueHotEntryInfo info)
		{
			RepeatedField<int> visibleHotEntryGroupIds = info.VisibleHotEntryGroupIds;
			RepeatedField<int> unlockHotEntryGroupIds = info.UnlockHotEntryGroupIds;
			RepeatedField<int> selectableHotEntryGroupIds = info.SelectableHotEntryGroupIds;
			int item = (selectableHotEntryGroupIds.Count > 0) ? visibleHotEntryGroupIds.IndexOf(selectableHotEntryGroupIds[0]) : -1;
			int item2;
			if (selectableHotEntryGroupIds.Count <= 0)
			{
				item2 = -1;
			}
			else
			{
				RepeatedField<int> repeatedField = visibleHotEntryGroupIds;
				RepeatedField<int> repeatedField2 = selectableHotEntryGroupIds;
				item2 = repeatedField.IndexOf(repeatedField2[repeatedField2.Count - 1]);
			}
			this.EntriesGroupAvailableIndexRange = new ValueTuple<int, int>(item, item2);
			Dictionary<int, int> player = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RoguelikeInstanceSelectGroupIndex, null);
			int value;
			int? num = (player != null && player.TryGetValue(this.InstanceId, out value)) ? new int?(value) : null;
			int num2 = this.EntriesGroupAvailableIndexRange.Item1;
			if (num != null && num.Value >= this.EntriesGroupAvailableIndexRange.Item1 && num.Value <= this.EntriesGroupAvailableIndexRange.Item2 && unlockHotEntryGroupIds.Contains(visibleHotEntryGroupIds[num.Value]))
			{
				num2 = num.Value;
			}
			int num3 = -1;
			bool flag = false;
			this.CurrentEntriesGroupIndexInternal = num2;
			for (int i = 0; i < visibleHotEntryGroupIds.Count; i++)
			{
				int num4 = visibleHotEntryGroupIds[i];
				RoguelikeEntriesGroupData roguelikeEntriesGroupData = new RoguelikeEntriesGroupData();
				roguelikeEntriesGroupData.Index = i;
				roguelikeEntriesGroupData.Id = num4;
				roguelikeEntriesGroupData.IsUnlock = unlockHotEntryGroupIds.Contains(num4);
				roguelikeEntriesGroupData.IsActive = (i <= num2);
				roguelikeEntriesGroupData.IsFocus = (i == num2);
				RogueHotEntryGroup? rogueHotEntryGroupConfig = RoguelikeConfig.Instance.GetRogueHotEntryGroupConfig(num4);
				if (rogueHotEntryGroupConfig != null)
				{
					ValueTuple<IReadOnlyList<int>, ERoguelikeEntryType, List<RoguelikeEntryData>>[] array = new ValueTuple<IReadOnlyList<int>, ERoguelikeEntryType, List<RoguelikeEntryData>>[]
					{
						new ValueTuple<IReadOnlyList<int>, ERoguelikeEntryType, List<RoguelikeEntryData>>(rogueHotEntryGroupConfig.Value.Group1(), ERoguelikeEntryType.Type1, roguelikeEntriesGroupData.GroupDataListRow1),
						new ValueTuple<IReadOnlyList<int>, ERoguelikeEntryType, List<RoguelikeEntryData>>(rogueHotEntryGroupConfig.Value.Group2(), ERoguelikeEntryType.Type2, roguelikeEntriesGroupData.GroupDataListRow2),
						new ValueTuple<IReadOnlyList<int>, ERoguelikeEntryType, List<RoguelikeEntryData>>(rogueHotEntryGroupConfig.Value.Group3(), ERoguelikeEntryType.Type3, roguelikeEntriesGroupData.GroupDataListRow3)
					};
					if (roguelikeEntriesGroupData.IsActive)
					{
						int num5 = 0;
						using (IEnumerator<IReadOnlyList<int>> enumerator = (from x in array
						select x.Item1).GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								IReadOnlyList<int> readOnlyList = enumerator.Current;
								if (readOnlyList.Count != 0)
								{
									int num6 = readOnlyList.Count<int>() - 1;
									if (num5 <= num6)
									{
										num5 = num6;
										num3 = readOnlyList[num6];
									}
								}
							}
							goto IL_2CA;
						}
						goto IL_261;
					}
					goto IL_261;
					IL_2CA:
					foreach (ValueTuple<IReadOnlyList<int>, ERoguelikeEntryType, List<RoguelikeEntryData>> valueTuple in array)
					{
						IReadOnlyList<int> item3 = valueTuple.Item1;
						ERoguelikeEntryType item4 = valueTuple.Item2;
						List<RoguelikeEntryData> item5 = valueTuple.Item3;
						foreach (int num7 in item3)
						{
							RogueHotEntry? rogueHotEntryConfig = RoguelikeConfig.Instance.GetRogueHotEntryConfig(num7);
							if (rogueHotEntryConfig != null)
							{
								RoguelikeEntryData roguelikeEntryData = new RoguelikeEntryData();
								roguelikeEntryData.Id = num7;
								roguelikeEntryData.GroupId = num4;
								roguelikeEntryData.Type = item4;
								roguelikeEntryData.OverviewId = rogueHotEntryConfig.Value.OverviewId;
								roguelikeEntryData.OverviewParam = rogueHotEntryConfig.Value.OverviewShowParam().ToList<int>();
								item5.Add(roguelikeEntryData);
								if (num7 == num3)
								{
									this.CurrentSelectEntryData = roguelikeEntryData;
								}
							}
						}
					}
					this.EntriesDataGroupMap[num4] = roguelikeEntriesGroupData;
					this.EntriesDataGroupList.Add(roguelikeEntriesGroupData);
					goto IL_3D7;
					IL_261:
					if (!flag)
					{
						foreach (IReadOnlyList<int> readOnlyList2 in from x in array
						select x.Item1)
						{
							if (readOnlyList2.Count != 0)
							{
								num3 = readOnlyList2[0];
							}
						}
						flag = true;
						goto IL_2CA;
					}
					goto IL_2CA;
				}
				IL_3D7:;
			}
			this.UpdateCurrentActiveOverviewId();
		}

		// Token: 0x060336FB RID: 210683 RVA: 0x00C03A44 File Offset: 0x00C01C44
		public bool GetEntryDataActiveState(RoguelikeEntryData entryData)
		{
			RoguelikeEntriesGroupData roguelikeEntriesGroupData2;
			RoguelikeEntriesGroupData roguelikeEntriesGroupData = this.EntriesDataGroupMap.TryGetValue(entryData.GroupId, out roguelikeEntriesGroupData2) ? roguelikeEntriesGroupData2 : null;
			return roguelikeEntriesGroupData != null && roguelikeEntriesGroupData.IsActive;
		}

		// Token: 0x060336FC RID: 210684 RVA: 0x00C03A78 File Offset: 0x00C01C78
		public bool HasMultiAvailableEntriesGroup()
		{
			int num = 0;
			for (int i = this.EntriesGroupAvailableIndexRange.Item1; i <= this.EntriesGroupAvailableIndexRange.Item2; i++)
			{
				if (this.EntriesDataGroupList[i].IsUnlock)
				{
					if (num > 0)
					{
						return true;
					}
					num++;
				}
			}
			return false;
		}

		// Token: 0x060336FD RID: 210685 RVA: 0x00C03AC8 File Offset: 0x00C01CC8
		private void UpdateCurrentActiveOverviewId()
		{
			this.CurrentActiveOverviewId.Clear();
			for (int i = 0; i <= this.CurrentEntriesGroupIndex; i++)
			{
				foreach (RoguelikeEntryData roguelikeEntryData in this.EntriesDataGroupList[i].GetAllEntryDataList())
				{
					this.CurrentActiveOverviewId.Add(roguelikeEntryData.OverviewId);
				}
			}
		}

		// Token: 0x060336FE RID: 210686 RVA: 0x00C03B50 File Offset: 0x00C01D50
		public bool GetOverviewIdActiveState(int overviewId)
		{
			return this.CurrentActiveOverviewId.Contains(overviewId);
		}

		// Token: 0x060336FF RID: 210687 RVA: 0x00C03B60 File Offset: 0x00C01D60
		public List<int> GetEntriesOverviewIdList()
		{
			HashSet<int> hashSet = new HashSet<int>();
			for (int i = 0; i <= this.EntriesGroupAvailableIndexRange.Item2; i++)
			{
				foreach (RoguelikeEntryData roguelikeEntryData in this.EntriesDataGroupList[i].GetAllEntryDataList())
				{
					hashSet.Add(roguelikeEntryData.OverviewId);
				}
			}
			List<int> list = hashSet.ToList<int>();
			list.Sort(delegate(int a, int b)
			{
				RogueHotEntryOverview value = RoguelikeConfig.Instance.GetRogueHotEntryOverviewConfig(a).Value;
				RogueHotEntryOverview value2 = RoguelikeConfig.Instance.GetRogueHotEntryOverviewConfig(b).Value;
				return value.SortId - value2.SortId;
			});
			return list;
		}

		// Token: 0x06033700 RID: 210688 RVA: 0x00C03C0C File Offset: 0x00C01E0C
		public List<int> GetEntriesOverviewIdParam(int overviewId)
		{
			List<int> list = new List<int>();
			for (int i = 0; i <= this.CurrentEntriesGroupIndex; i++)
			{
				foreach (RoguelikeEntryData roguelikeEntryData in this.EntriesDataGroupList[i].GetAllEntryDataList())
				{
					if (overviewId == roguelikeEntryData.OverviewId)
					{
						if (list.Count == 0)
						{
							list = roguelikeEntryData.OverviewParam.ToList<int>();
						}
						else
						{
							int num = 0;
							while (num < list.Count && num < roguelikeEntryData.OverviewParam.Count)
							{
								List<int> list2 = list;
								int index = num;
								list2[index] += roguelikeEntryData.OverviewParam[num];
								num++;
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06033701 RID: 210689 RVA: 0x00C03CEC File Offset: 0x00C01EEC
		public int GetEntriesOverviewIdCount(int overviewId)
		{
			int num = 0;
			for (int i = 0; i <= this.CurrentEntriesGroupIndex; i++)
			{
				foreach (RoguelikeEntryData roguelikeEntryData in this.EntriesDataGroupList[i].GetAllEntryDataList())
				{
					if (overviewId == roguelikeEntryData.OverviewId)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06033702 RID: 210690 RVA: 0x00C03D64 File Offset: 0x00C01F64
		private void InitFormation(RogueHotEntryInfo info, IReadOnlyList<int> validRoleList)
		{
			this.VisibleRoleList = info.VisibleRoleIds.ToList<int>();
			this.ValidRoleList = (from roleId in validRoleList
			where this.VisibleRoleList.Contains(roleId)
			select roleId).ToList<int>();
			this.RoleShowLevel = info.RoleShowLevel;
			foreach (int num in this.ValidRoleList)
			{
				RogueCharacter? rogueCharacterConfig = RoguelikeConfig.Instance.GetRogueCharacterConfig(num);
				if (rogueCharacterConfig == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Roguelike;
					ELogAuthor author = ELogAuthor.YYZ;
					string message = "RoguelikeEntranceViewModel初始化失败,角色配置不存在";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RogueRoleId", num);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					this.RoleId2ValidRoleId[rogueCharacterConfig.Value.RoleId] = num;
					this.RoleTrialId2ValidRoleId[rogueCharacterConfig.Value.TrialRoleId] = num;
				}
			}
			this.InitFormationIdList();
			this.ShowNewUnlockRole = this.HasNewUnlockRoleId();
		}

		// Token: 0x06033703 RID: 210691 RVA: 0x00C03E80 File Offset: 0x00C02080
		private void InitFormationIdList()
		{
			this.FormationIdList = new List<int>(new int[3]);
			List<int> player = LocalStorage.GetPlayer<List<int>>(ELocalStoragePlayerKey.RoguelikeFormationIdList, null);
			if (player == null)
			{
				return;
			}
			for (int i = 0; i < player.Count<int>(); i++)
			{
				int num = player[i];
				if (num != 0)
				{
					bool flag = this.RoleId2ValidRoleId.ContainsKey(num);
					bool flag2 = this.RoleTrialId2ValidRoleId.ContainsKey(num);
					if (!flag && !flag2)
					{
						player[i] = 0;
					}
					else if (RoleModel.Instance.IsMainRole(num))
					{
						int num2 = num;
						int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
						if (!(num2 == curSelectMainRoleId.GetValueOrDefault() & curSelectMainRoleId != null))
						{
							player[i] = 0;
						}
					}
					else if (flag2 && !flag)
					{
						int id = this.RoleTrialId2ValidRoleId[num];
						RogueCharacter? rogueCharacterConfig = RoguelikeConfig.Instance.GetRogueCharacterConfig(id);
						if (rogueCharacterConfig != null)
						{
							RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(rogueCharacterConfig.Value.RoleId);
							if (roleInstanceById != null)
							{
								player[i] = roleInstanceById.GetRoleId();
							}
						}
					}
				}
			}
			this.FormationIdList = player.ToList<int>();
		}

		// Token: 0x06033704 RID: 210692 RVA: 0x00C03F9F File Offset: 0x00C0219F
		public void CacheRoleSelect()
		{
			LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.RoguelikeFormationIdList, this.FormationIdList);
		}

		// Token: 0x06033705 RID: 210693 RVA: 0x00C03FB4 File Offset: 0x00C021B4
		public List<RoleDataBase> GetFormationRoleDataList()
		{
			HashSet<RoleDataBase> hashSet = new HashSet<RoleDataBase>();
			foreach (int rogueRoleId in this.ValidRoleList)
			{
				RoleDataBase roguelikeRoleData = RoguelikeModel.Instance.GetRoguelikeRoleData(rogueRoleId);
				if (roguelikeRoleData != null && (!RoleModel.Instance.IsMainRole(roguelikeRoleData.GetRoleId()) || !roguelikeRoleData.IsTrialRole()))
				{
					hashSet.Add(roguelikeRoleData);
				}
			}
			return hashSet.ToList<RoleDataBase>();
		}

		// Token: 0x06033706 RID: 210694 RVA: 0x00C04040 File Offset: 0x00C02240
		public List<TeamRoleSkillData> GetSupportCustomSkillShowData(int roleId)
		{
			List<TeamRoleSkillData> list = new List<TeamRoleSkillData>();
			int num2;
			int num3;
			int num = this.RoleId2ValidRoleId.TryGetValue(roleId, out num2) ? num2 : (this.RoleTrialId2ValidRoleId.TryGetValue(roleId, out num3) ? num3 : 0);
			if (num == 0)
			{
				return new List<TeamRoleSkillData>();
			}
			RoguelikeConfig instance = RoguelikeConfig.Instance;
			RogueCharacter? rogueCharacter = (instance != null) ? instance.GetRogueCharacterConfig(num) : null;
			if (rogueCharacter == null)
			{
				return new List<TeamRoleSkillData>();
			}
			foreach (int id in rogueCharacter.Value.SupportSkillListIter())
			{
				RogueSkill? rogueSkillConfig = RoguelikeConfig.Instance.GetRogueSkillConfig(id);
				if (rogueSkillConfig != null)
				{
					list.Add(new TeamRoleSkillData
					{
						SkillName = rogueSkillConfig.Value.SkillName,
						SkillIcon = rogueSkillConfig.Value.Icon,
						SkillTypeText = ConfigMultiTextLang.GetLocalTextNew(rogueSkillConfig.Value.SkillTypeText, null),
						SkillDesc = rogueSkillConfig.Value.SkillDesc,
						SkillDescNum = rogueSkillConfig.Value.SkillDescParam(),
						SkillResume = rogueSkillConfig.Value.SkillResume,
						SkillResumeNum = rogueSkillConfig.Value.SkillResumeParam()
					});
				}
			}
			return list;
		}

		// Token: 0x06033707 RID: 210695 RVA: 0x00C041D0 File Offset: 0x00C023D0
		public bool HasNewUnlockRoleId()
		{
			ServerStorageSet serverStorageSet = (ServerStorageSet)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoguelikeNewCharacterUnlock);
			foreach (int num in this.ValidRoleList)
			{
				RogueCharacter? rogueCharacterConfig = RoguelikeConfig.Instance.GetRogueCharacterConfig(num);
				if (rogueCharacterConfig != null && rogueCharacterConfig.Value.UnlockInst != 0 && !serverStorageSet.Has(num))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06033708 RID: 210696 RVA: 0x00C04268 File Offset: 0x00C02468
		public void CacheNewUnlockRoleId()
		{
			ServerStorageSet serverStorageSet = (ServerStorageSet)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoguelikeNewCharacterUnlock);
			foreach (int num in this.ValidRoleList)
			{
				RogueCharacter? rogueCharacterConfig = RoguelikeConfig.Instance.GetRogueCharacterConfig(num);
				if (rogueCharacterConfig != null && rogueCharacterConfig.Value.UnlockInst != 0 && !serverStorageSet.Has(num))
				{
					serverStorageSet.Add(num);
				}
			}
			this.ShowNewUnlockRole = false;
		}

		// Token: 0x06033709 RID: 210697 RVA: 0x00C04304 File Offset: 0x00C02504
		[NullableContext(0)]
		public ValueTuple<int, int>? GetNewUnlockEntriesGroupId()
		{
			RogueInst? rogueInstConfig = RoguelikeConfig.Instance.GetRogueInstConfig(this.InstanceId);
			if (rogueInstConfig.Value.FirstReadEntrys() == null || rogueInstConfig.Value.FirstReadEntrysLength == 0)
			{
				return null;
			}
			ServerStorageMap serverStorageMap = (ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoguelikeNewEntriesGroupUnlock);
			int num = serverStorageMap.Has(this.InstanceId) ? serverStorageMap.Get(this.InstanceId).GetValueOrDefault() : 0;
			if (num == 0)
			{
				int[] array = rogueInstConfig.Value.FirstReadEntrys();
				serverStorageMap.Set(this.InstanceId, array[1]);
				return new ValueTuple<int, int>?(new ValueTuple<int, int>(array[0], array[1]));
			}
			int num2 = -1;
			foreach (RoguelikeEntriesGroupData roguelikeEntriesGroupData in this.EntriesDataGroupList)
			{
				if (roguelikeEntriesGroupData.IsUnlock)
				{
					num2 = roguelikeEntriesGroupData.Id;
				}
			}
			if (num2 == -1)
			{
				return null;
			}
			if (num == num2)
			{
				return null;
			}
			serverStorageMap.Set(this.InstanceId, num2);
			return new ValueTuple<int, int>?(new ValueTuple<int, int>(num, num2));
		}

		// Token: 0x0401B4DD RID: 111837
		public int InstanceId;

		// Token: 0x0401B4DE RID: 111838
		public Dictionary<int, RoguelikeEntriesGroupData> EntriesDataGroupMap = new Dictionary<int, RoguelikeEntriesGroupData>();

		// Token: 0x0401B4DF RID: 111839
		public List<RoguelikeEntriesGroupData> EntriesDataGroupList = new List<RoguelikeEntriesGroupData>();

		// Token: 0x0401B4E0 RID: 111840
		[Nullable(2)]
		public RoguelikeEntryData CurrentSelectEntryData;

		// Token: 0x0401B4E1 RID: 111841
		[Nullable(0)]
		private ValueTuple<int, int> EntriesGroupAvailableIndexRange = new ValueTuple<int, int>(0, 0);

		// Token: 0x0401B4E2 RID: 111842
		private int CurrentEntriesGroupIndexInternal = -1;

		// Token: 0x0401B4E3 RID: 111843
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<bool, RoguelikeEntryData> OnClickEntry;

		// Token: 0x0401B4E4 RID: 111844
		private HashSet<int> CurrentActiveOverviewId = new HashSet<int>();

		// Token: 0x0401B4E5 RID: 111845
		public List<int> FormationIdList = new List<int>();

		// Token: 0x0401B4E6 RID: 111846
		public List<int> VisibleRoleList = new List<int>();

		// Token: 0x0401B4E7 RID: 111847
		public List<int> ValidRoleList = new List<int>();

		// Token: 0x0401B4E8 RID: 111848
		public Dictionary<int, int> RoleId2ValidRoleId = new Dictionary<int, int>();

		// Token: 0x0401B4E9 RID: 111849
		public Dictionary<int, int> RoleTrialId2ValidRoleId = new Dictionary<int, int>();

		// Token: 0x0401B4EA RID: 111850
		public int RoleShowLevel;

		// Token: 0x0401B4EB RID: 111851
		public bool ShowNewUnlockRole;
	}
}
