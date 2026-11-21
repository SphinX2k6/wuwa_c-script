using System;
using System.Collections.Generic;
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
	// Token: 0x02003DA0 RID: 15776
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeEntranceViewModel
	{
		// Token: 0x06028560 RID: 165216 RVA: 0x00B4C998 File Offset: 0x00B4AB98
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

		// Token: 0x17005269 RID: 21097
		// (get) Token: 0x06028561 RID: 165217 RVA: 0x00B4C9E3 File Offset: 0x00B4ABE3
		// (set) Token: 0x06028562 RID: 165218 RVA: 0x00B4C9EC File Offset: 0x00B4ABEC
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

		// Token: 0x1700526A RID: 21098
		// (get) Token: 0x06028563 RID: 165219 RVA: 0x00B4CB2E File Offset: 0x00B4AD2E
		public RoguelikeEntriesGroupData CurrentEntriesGroupData
		{
			get
			{
				return this.EntriesDataGroupList[this.CurrentEntriesGroupIndex];
			}
		}

		// Token: 0x1700526B RID: 21099
		// (get) Token: 0x06028564 RID: 165220 RVA: 0x00B4CB41 File Offset: 0x00B4AD41
		public bool IsReduceMultiplierAvailable
		{
			get
			{
				return this.CurrentEntriesGroupIndex > this.EntriesGroupAvailableIndexRange.Item1;
			}
		}

		// Token: 0x1700526C RID: 21100
		// (get) Token: 0x06028565 RID: 165221 RVA: 0x00B4CB56 File Offset: 0x00B4AD56
		public bool IsAddMultiplierAvailable
		{
			get
			{
				return this.CurrentEntriesGroupIndex < this.EntriesGroupAvailableIndexRange.Item2;
			}
		}

		// Token: 0x06028566 RID: 165222 RVA: 0x00B4CB6B File Offset: 0x00B4AD6B
		[NullableContext(2)]
		public void SetCurrentSelectEntryData(RoguelikeEntryData entryData)
		{
			this.CurrentSelectEntryData = entryData;
		}

		// Token: 0x06028567 RID: 165223 RVA: 0x00B4CB74 File Offset: 0x00B4AD74
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
						ValueTuple<IReadOnlyList<int>, ERoguelikeEntryType, List<RoguelikeEntryData>>[] array2 = array;
						for (int j = 0; j < array2.Length; j++)
						{
							IReadOnlyList<int> item3 = array2[j].Item1;
							if (item3.Count != 0)
							{
								int num6 = item3.Count - 1;
								if (num5 <= num6)
								{
									num5 = num6;
									num3 = item3[num6];
								}
							}
						}
					}
					else if (!flag)
					{
						ValueTuple<IReadOnlyList<int>, ERoguelikeEntryType, List<RoguelikeEntryData>>[] array2 = array;
						for (int j = 0; j < array2.Length; j++)
						{
							IReadOnlyList<int> item4 = array2[j].Item1;
							if (item4.Count != 0)
							{
								num3 = item4[0];
							}
						}
						flag = true;
					}
					foreach (ValueTuple<IReadOnlyList<int>, ERoguelikeEntryType, List<RoguelikeEntryData>> valueTuple in array)
					{
						IReadOnlyList<int> item5 = valueTuple.Item1;
						ERoguelikeEntryType item6 = valueTuple.Item2;
						List<RoguelikeEntryData> item7 = valueTuple.Item3;
						foreach (int num7 in item5)
						{
							RogueHotEntry? rogueHotEntryConfig = RoguelikeConfig.Instance.GetRogueHotEntryConfig(num7);
							if (rogueHotEntryConfig != null)
							{
								RoguelikeEntryData roguelikeEntryData = new RoguelikeEntryData();
								roguelikeEntryData.Id = num7;
								roguelikeEntryData.GroupId = num4;
								roguelikeEntryData.Type = item6;
								roguelikeEntryData.OverviewId = rogueHotEntryConfig.Value.OverviewId;
								roguelikeEntryData.OverviewParam = new List<int>(rogueHotEntryConfig.Value.OverviewShowParam());
								item7.Add(roguelikeEntryData);
								if (num7 == num3)
								{
									this.CurrentSelectEntryData = roguelikeEntryData;
								}
							}
						}
					}
					this.EntriesDataGroupMap[num4] = roguelikeEntriesGroupData;
					this.EntriesDataGroupList.Add(roguelikeEntriesGroupData);
				}
			}
			this.UpdateCurrentActiveOverviewId();
		}

		// Token: 0x06028568 RID: 165224 RVA: 0x00B4CF34 File Offset: 0x00B4B134
		public bool GetEntryDataActiveState(RoguelikeEntryData entryData)
		{
			RoguelikeEntriesGroupData roguelikeEntriesGroupData2;
			RoguelikeEntriesGroupData roguelikeEntriesGroupData = this.EntriesDataGroupMap.TryGetValue(entryData.GroupId, out roguelikeEntriesGroupData2) ? roguelikeEntriesGroupData2 : null;
			return roguelikeEntriesGroupData != null && roguelikeEntriesGroupData.IsActive;
		}

		// Token: 0x06028569 RID: 165225 RVA: 0x00B4CF68 File Offset: 0x00B4B168
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

		// Token: 0x0602856A RID: 165226 RVA: 0x00B4CFB8 File Offset: 0x00B4B1B8
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

		// Token: 0x0602856B RID: 165227 RVA: 0x00B4D040 File Offset: 0x00B4B240
		public bool GetOverviewIdActiveState(int overviewId)
		{
			return this.CurrentActiveOverviewId.Contains(overviewId);
		}

		// Token: 0x0602856C RID: 165228 RVA: 0x00B4D050 File Offset: 0x00B4B250
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
			List<int> list = new List<int>(hashSet);
			list.Sort(delegate(int a, int b)
			{
				RogueHotEntryOverview value = RoguelikeConfig.Instance.GetRogueHotEntryOverviewConfig(a).Value;
				RogueHotEntryOverview value2 = RoguelikeConfig.Instance.GetRogueHotEntryOverviewConfig(b).Value;
				return value.SortId - value2.SortId;
			});
			return list;
		}

		// Token: 0x0602856D RID: 165229 RVA: 0x00B4D0FC File Offset: 0x00B4B2FC
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
							list = new List<int>(roguelikeEntryData.OverviewParam);
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

		// Token: 0x0602856E RID: 165230 RVA: 0x00B4D1DC File Offset: 0x00B4B3DC
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

		// Token: 0x0602856F RID: 165231 RVA: 0x00B4D254 File Offset: 0x00B4B454
		private void InitFormation(RogueHotEntryInfo info, IReadOnlyList<int> validRoleList)
		{
			this.VisibleRoleList = new List<int>(info.VisibleRoleIds);
			this.ValidRoleList = new List<int>();
			foreach (int item in validRoleList)
			{
				if (this.VisibleRoleList.Contains(item))
				{
					this.ValidRoleList.Add(item);
				}
			}
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

		// Token: 0x06028570 RID: 165232 RVA: 0x00B4D3B0 File Offset: 0x00B4B5B0
		private void InitFormationIdList()
		{
			this.FormationIdList = new List<int>(new int[3]);
			List<int> player = LocalStorage.GetPlayer<List<int>>(ELocalStoragePlayerKey.RoguelikeFormationIdList, null);
			if (player == null)
			{
				return;
			}
			for (int i = 0; i < player.Count; i++)
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
			this.FormationIdList = new List<int>(player);
		}

		// Token: 0x06028571 RID: 165233 RVA: 0x00B4D4CF File Offset: 0x00B4B6CF
		public void CacheRoleSelect()
		{
			LocalStorage.SetPlayer<List<int>>(ELocalStoragePlayerKey.RoguelikeFormationIdList, this.FormationIdList);
		}

		// Token: 0x06028572 RID: 165234 RVA: 0x00B4D4E4 File Offset: 0x00B4B6E4
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
			return new List<RoleDataBase>(hashSet);
		}

		// Token: 0x06028573 RID: 165235 RVA: 0x00B4D570 File Offset: 0x00B4B770
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

		// Token: 0x06028574 RID: 165236 RVA: 0x00B4D700 File Offset: 0x00B4B900
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

		// Token: 0x06028575 RID: 165237 RVA: 0x00B4D798 File Offset: 0x00B4B998
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

		// Token: 0x06028576 RID: 165238 RVA: 0x00B4D834 File Offset: 0x00B4BA34
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

		// Token: 0x04015EB0 RID: 89776
		public int InstanceId;

		// Token: 0x04015EB1 RID: 89777
		public Dictionary<int, RoguelikeEntriesGroupData> EntriesDataGroupMap = new Dictionary<int, RoguelikeEntriesGroupData>();

		// Token: 0x04015EB2 RID: 89778
		public List<RoguelikeEntriesGroupData> EntriesDataGroupList = new List<RoguelikeEntriesGroupData>();

		// Token: 0x04015EB3 RID: 89779
		[Nullable(2)]
		public RoguelikeEntryData CurrentSelectEntryData;

		// Token: 0x04015EB4 RID: 89780
		[Nullable(0)]
		private ValueTuple<int, int> EntriesGroupAvailableIndexRange = new ValueTuple<int, int>(0, 0);

		// Token: 0x04015EB5 RID: 89781
		private int CurrentEntriesGroupIndexInternal = -1;

		// Token: 0x04015EB6 RID: 89782
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<bool, RoguelikeEntryData> OnClickEntry;

		// Token: 0x04015EB7 RID: 89783
		private HashSet<int> CurrentActiveOverviewId = new HashSet<int>();

		// Token: 0x04015EB8 RID: 89784
		public List<int> FormationIdList = new List<int>();

		// Token: 0x04015EB9 RID: 89785
		public List<int> VisibleRoleList = new List<int>();

		// Token: 0x04015EBA RID: 89786
		public List<int> ValidRoleList = new List<int>();

		// Token: 0x04015EBB RID: 89787
		public Dictionary<int, int> RoleId2ValidRoleId = new Dictionary<int, int>();

		// Token: 0x04015EBC RID: 89788
		public Dictionary<int, int> RoleTrialId2ValidRoleId = new Dictionary<int, int>();

		// Token: 0x04015EBD RID: 89789
		public int RoleShowLevel;

		// Token: 0x04015EBE RID: 89790
		public bool ShowNewUnlockRole;
	}
}
