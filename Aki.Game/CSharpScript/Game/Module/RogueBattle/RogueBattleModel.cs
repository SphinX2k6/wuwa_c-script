using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.PermanentRogue;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Module.InstanceDungeon;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EA7 RID: 16039
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RogueBattleModel : ModelBase
	{
		// Token: 0x170052E1 RID: 21217
		// (get) Token: 0x06028B6E RID: 166766 RVA: 0x00B6A7CC File Offset: 0x00B689CC
		// (set) Token: 0x06028B6F RID: 166767 RVA: 0x00B6A7D9 File Offset: 0x00B689D9
		public string CurrentRoomMusicState
		{
			get
			{
				return this.CurrentRoomMusicStateInternal.State;
			}
			set
			{
				this.CurrentRoomMusicStateInternal.State = (value ?? "none");
			}
		}

		// Token: 0x06028B70 RID: 166768 RVA: 0x00B6A7F0 File Offset: 0x00B689F0
		public void ChangeDescMode()
		{
			this.DescMode = ((this.DescMode == EDescModel.SIMPLE) ? EDescModel.DETAIL : EDescModel.SIMPLE);
			EventSystem.Instance.Emit(EEventName.RogueBattleDescModeChange);
		}

		// Token: 0x06028B71 RID: 166769 RVA: 0x00B6A814 File Offset: 0x00B68A14
		[NullableContext(2)]
		public RogueResOption GetOptionDataById(int index)
		{
			RogueResOption result;
			if (!this.OptionMap.TryGetValue(index, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06028B72 RID: 166770 RVA: 0x00B6A834 File Offset: 0x00B68A34
		public void SetOptionData(int bindId, RogueResOption data)
		{
			this.OptionMap[bindId] = data;
		}

		// Token: 0x06028B73 RID: 166771 RVA: 0x00B6A843 File Offset: 0x00B68A43
		[NullableContext(2)]
		public RogueResFormation GetFormationDataByIndex(int index)
		{
			if (index < 0 || index >= this.FormationData.Count)
			{
				return null;
			}
			return this.FormationData[index];
		}

		// Token: 0x06028B74 RID: 166772 RVA: 0x00B6A868 File Offset: 0x00B68A68
		public void UpdateFormationData(int index, RogueResFormation data)
		{
			if (index < 0)
			{
				return;
			}
			if (index < this.FormationData.Count)
			{
				this.FormationData[index] = data;
				return;
			}
			while (this.FormationData.Count < index)
			{
				this.FormationData.Add(new RogueResFormation());
			}
			this.FormationData.Add(data);
		}

		// Token: 0x06028B75 RID: 166773 RVA: 0x00B6A8C0 File Offset: 0x00B68AC0
		[NullableContext(2)]
		public RogueResGainData GetPhantomData()
		{
			if (!this.TotalGainDataMap.ContainsKey(RogueResDataType.Phantom))
			{
				return null;
			}
			using (Dictionary<int, RogueResGainData>.ValueCollection.Enumerator enumerator = this.TotalGainDataMap[RogueResDataType.Phantom].Values.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					return enumerator.Current;
				}
			}
			return null;
		}

		// Token: 0x06028B76 RID: 166774 RVA: 0x00B6A92C File Offset: 0x00B68B2C
		public List<RogueResGainData> GetTokenData()
		{
			List<RogueResGainData> list = new List<RogueResGainData>();
			if (!this.TotalGainDataMap.ContainsKey(RogueResDataType.Token))
			{
				return list;
			}
			foreach (RogueResGainData item in this.TotalGainDataMap[RogueResDataType.Token].Values)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06028B77 RID: 166775 RVA: 0x00B6A9A4 File Offset: 0x00B68BA4
		[NullableContext(2)]
		public RogueResRole GetRoleInfoById(int id)
		{
			Dictionary<int, RogueResGainData> dictionary;
			if (!this.TotalGainDataMap.TryGetValue(RogueResDataType.Role, out dictionary))
			{
				Log.Instance.Error(ELogModule.RogueBattle, ELogAuthor.LPH, "没有角色数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			RogueResGainData rogueResGainData;
			if (dictionary.TryGetValue(id, out rogueResGainData))
			{
				return rogueResGainData.RogueResRole;
			}
			return null;
		}

		// Token: 0x06028B78 RID: 166776 RVA: 0x00B6A9F8 File Offset: 0x00B68BF8
		public int GetIncIdByRoleId(int roleId)
		{
			Dictionary<int, RogueResGainData> dictionary;
			if (!this.TotalGainDataMap.TryGetValue(RogueResDataType.Role, out dictionary))
			{
				return 0;
			}
			foreach (KeyValuePair<int, RogueResGainData> keyValuePair in dictionary)
			{
				RogueResRole rogueResRole = keyValuePair.Value.RogueResRole;
				if (rogueResRole != null && rogueResRole.RoleIdOrTrialRoleId == roleId)
				{
					return keyValuePair.Key;
				}
			}
			return 0;
		}

		// Token: 0x06028B79 RID: 166777 RVA: 0x00B6AA7C File Offset: 0x00B68C7C
		public List<RoleDataBase> GetRoleList()
		{
			Dictionary<int, RogueResGainData> dictionary;
			if (!this.TotalGainDataMap.TryGetValue(RogueResDataType.Role, out dictionary))
			{
				Log.Instance.Error(ELogModule.RogueBattle, ELogAuthor.LPH, "没有角色数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return new List<RoleDataBase>();
			}
			List<RoleDataBase> list = new List<RoleDataBase>();
			foreach (RogueResGainData rogueResGainData in dictionary.Values)
			{
				int roleIdOrTrialRoleId = rogueResGainData.RogueResRole.RoleIdOrTrialRoleId;
				RoleDataBase roleDataBase;
				if (roleIdOrTrialRoleId > 100000)
				{
					roleDataBase = new RoleRobotData(roleIdOrTrialRoleId);
				}
				else
				{
					roleDataBase = new RogueBattleRoleData(roleIdOrTrialRoleId);
				}
				roleDataBase.GetLevelData().SetLevel(MapRogueModel.Instance.GetRogueRoleLevel());
				list.Add(roleDataBase);
			}
			return list;
		}

		// Token: 0x06028B7A RID: 166778 RVA: 0x00B6AB4C File Offset: 0x00B68D4C
		public bool IsRoleGot(int roleId)
		{
			Dictionary<int, RogueResGainData> dictionary;
			if (!this.TotalGainDataMap.TryGetValue(RogueResDataType.Role, out dictionary))
			{
				Log.Instance.Error(ELogModule.RogueBattle, ELogAuthor.LPH, "没有角色数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			using (Dictionary<int, RogueResGainData>.ValueCollection.Enumerator enumerator = dictionary.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RogueResRole.RoleIdOrTrialRoleId == roleId)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06028B7B RID: 166779 RVA: 0x00B6ABDC File Offset: 0x00B68DDC
		public RoleBondInfo GetRoleBondDataById(int id)
		{
			if (!this.RoleFetterMap.ContainsKey(id))
			{
				RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(id);
				int valueOrDefault = ((rogueResBond != null) ? rogueResBond.GetValueOrDefault().GetStarMap(1) : null).GetValueOrDefault();
				return new RoleBondInfo
				{
					ConfigId = id,
					CurStar = 0,
					TargetStar = valueOrDefault,
					Level = 0
				};
			}
			return this.RoleFetterMap[id];
		}

		// Token: 0x06028B7C RID: 166780 RVA: 0x00B6AC60 File Offset: 0x00B68E60
		public RoleBondInfo GetRoleBondPreviewDataById(int bondId, int upStar = 0, int? designatedLv = null, int? designatedStar = null)
		{
			RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(bondId);
			RoleBondInfo roleBondInfo = null;
			if (this.RoleFetterMap.ContainsKey(bondId))
			{
				roleBondInfo = this.RoleFetterMap[bondId];
			}
			int num = 0;
			int i;
			int num3;
			if (designatedLv != null && designatedStar != null)
			{
				num = designatedLv.Value;
				i = designatedStar.Value + upStar;
				int num2 = num + 1;
				if (num2 > this.MaxRoleStar)
				{
					num2 = this.MaxRoleStar;
				}
				num3 = rogueResBond.Value.GetStarMap(num2).Value;
			}
			else if (roleBondInfo != null)
			{
				num = roleBondInfo.Level;
				i = roleBondInfo.CurStar + upStar;
				num3 = roleBondInfo.TargetStar;
			}
			else
			{
				i = upStar;
				num3 = rogueResBond.Value.GetStarMap(1).Value;
			}
			while (i >= num3)
			{
				num = Math.Min(num + 1, this.MaxRoleStar);
				int num4 = num + 1;
				if (num4 > this.MaxRoleStar)
				{
					num4 = this.MaxRoleStar;
				}
				num3 = rogueResBond.Value.GetStarMap(num4).Value;
				if (num == this.MaxRoleStar)
				{
					break;
				}
			}
			return new RoleBondInfo
			{
				ConfigId = bondId,
				CurStar = i,
				TargetStar = num3,
				Level = num
			};
		}

		// Token: 0x06028B7D RID: 166781 RVA: 0x00B6ADAC File Offset: 0x00B68FAC
		public int GetBondRoleCount(int bondId)
		{
			IReadOnlyList<RogueResBondRole> allRogueResBondRole = RogueBattleConfig.Instance.GetAllRogueResBondRole();
			if (allRogueResBondRole == null)
			{
				return 0;
			}
			int num = 0;
			foreach (RogueResBondRole rogueResBondRole in allRogueResBondRole)
			{
				bool flag = false;
				for (int i = 0; i < rogueResBondRole.BondIdsLength; i++)
				{
					if (rogueResBondRole.BondIds(i) == bondId)
					{
						flag = true;
						break;
					}
				}
				if (flag && (this.IsRoleGot(rogueResBondRole.RoleId) || this.IsRoleGot(rogueResBondRole.TrialRoleId)))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06028B7E RID: 166782 RVA: 0x00B6AE50 File Offset: 0x00B69050
		public int GetLinkIdByRoleList(List<RoleDataBase> roleDataList)
		{
			List<int> list = new List<int>();
			foreach (RoleDataBase roleDataBase in roleDataList)
			{
				list.Add(roleDataBase.GetRoleId());
			}
			return this.GetLinkIdByRoleIdList(list);
		}

		// Token: 0x06028B7F RID: 166783 RVA: 0x00B6AEB0 File Offset: 0x00B690B0
		public int GetLinkIdByRoleIdList(List<int> roleIdList)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int id in roleIdList)
			{
				RogueResBondRole? rogueResBondRole = RogueBattleConfig.Instance.GetRogueResBondRole(id);
				if (rogueResBondRole != null)
				{
					for (int i = 0; i < rogueResBondRole.Value.BondIdsLength; i++)
					{
						int num = rogueResBondRole.Value.BondIds(i);
						hashSet.Add(num);
						int num2 = 0;
						if (dictionary.ContainsKey(num))
						{
							num2 = dictionary[num];
						}
						dictionary[num] = num2 + 1;
					}
				}
			}
			foreach (int num3 in hashSet)
			{
				RoleBondInfo roleBondDataById = this.GetRoleBondDataById(num3);
				RogueResBond value = RogueBattleConfig.Instance.GetRogueResBond(num3).Value;
				int num4 = value.LinkRule(0);
				if (roleBondDataById.Level >= num4)
				{
					int num5 = 0;
					if (dictionary.ContainsKey(num3))
					{
						num5 = dictionary[num3];
					}
					if (num5 == value.ActLinkNum)
					{
						return num3;
					}
				}
			}
			return 0;
		}

		// Token: 0x06028B80 RID: 166784 RVA: 0x00B6B014 File Offset: 0x00B69214
		public bool IsBondLinkCanActivate(int bondId)
		{
			RoleBondInfo roleBondDataById = this.GetRoleBondDataById(bondId);
			RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(bondId);
			if (rogueResBond == null)
			{
				return false;
			}
			if (this.GetBondRoleCount(bondId) < rogueResBond.Value.ActLinkNum)
			{
				return false;
			}
			int num = rogueResBond.Value.LinkRule(0);
			return roleBondDataById.Level >= num;
		}

		// Token: 0x06028B81 RID: 166785 RVA: 0x00B6B078 File Offset: 0x00B69278
		public bool IsAnyBondLinkCanActivate()
		{
			foreach (RoleBondInfo roleBondInfo in this.GetAllOwnedRoleBondData())
			{
				if (this.IsBondLinkCanActivate(roleBondInfo.ConfigId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06028B82 RID: 166786 RVA: 0x00B6B0DC File Offset: 0x00B692DC
		public List<RoleBondInfo> GetAllOwnedRoleBondData()
		{
			List<RoleBondInfo> list = new List<RoleBondInfo>();
			foreach (RoleBondInfo item in this.RoleFetterMap.Values)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06028B83 RID: 166787 RVA: 0x00B6B13C File Offset: 0x00B6933C
		public void UpdateOptionData(RogueResInstOptionsUpdateNotify data)
		{
			foreach (KeyValuePair<int, RogueResOption> keyValuePair in data.Adds)
			{
				int key = keyValuePair.Key;
				RogueResOption value = keyValuePair.Value;
				this.SetOptionData(key, value);
			}
			foreach (int key2 in data.Removes)
			{
				this.OptionMap.Remove(key2);
			}
			foreach (KeyValuePair<int, RogueResOption> keyValuePair2 in data.Updates)
			{
				int key3 = keyValuePair2.Key;
				RogueResOption value2 = keyValuePair2.Value;
				this.SetOptionData(key3, value2);
			}
		}

		// Token: 0x06028B84 RID: 166788 RVA: 0x00B6B238 File Offset: 0x00B69438
		public void UpdateGainData(RogueResGainDataUpdateNotify data)
		{
			foreach (RogueResGainData rogueResGainData in data.Adds)
			{
				int key = rogueResGainData.IncId;
				if (rogueResGainData.RogueResDataType == RogueResDataType.Role)
				{
					key = rogueResGainData.RogueResRole.RoleIdOrTrialRoleId;
					this.SetRogueResNewRoleFlag(true);
				}
				this.GainDataMap[rogueResGainData.IncId] = rogueResGainData;
				if (!this.TotalGainDataMap.ContainsKey(rogueResGainData.RogueResDataType))
				{
					this.TotalGainDataMap[rogueResGainData.RogueResDataType] = new Dictionary<int, RogueResGainData>();
				}
				this.TotalGainDataMap[rogueResGainData.RogueResDataType][key] = rogueResGainData;
			}
			foreach (RogueResGainData rogueResGainData2 in data.Updates)
			{
				int key2 = rogueResGainData2.IncId;
				if (rogueResGainData2.RogueResDataType == RogueResDataType.Role)
				{
					key2 = rogueResGainData2.RogueResRole.RoleIdOrTrialRoleId;
				}
				this.GainDataMap[rogueResGainData2.IncId] = rogueResGainData2;
				if (!this.TotalGainDataMap.ContainsKey(rogueResGainData2.RogueResDataType))
				{
					this.TotalGainDataMap[rogueResGainData2.RogueResDataType] = new Dictionary<int, RogueResGainData>();
				}
				this.TotalGainDataMap[rogueResGainData2.RogueResDataType][key2] = rogueResGainData2;
			}
			foreach (int key3 in data.Removes)
			{
				RogueResGainData rogueResGainData3;
				if (this.GainDataMap.TryGetValue(key3, out rogueResGainData3))
				{
					this.GainDataMap.Remove(key3);
					Dictionary<int, RogueResGainData> dictionary;
					if (this.TotalGainDataMap.TryGetValue(rogueResGainData3.RogueResDataType, out dictionary))
					{
						if (rogueResGainData3.RogueResDataType == RogueResDataType.Role)
						{
							int roleIdOrTrialRoleId = rogueResGainData3.RogueResRole.RoleIdOrTrialRoleId;
							dictionary.Remove(roleIdOrTrialRoleId);
						}
						else
						{
							dictionary.Remove(key3);
						}
					}
				}
			}
		}

		// Token: 0x06028B85 RID: 166789 RVA: 0x00B6B440 File Offset: 0x00B69640
		public void UpdateElementData(RogueResElementUpdateNotify notify)
		{
			foreach (ElementUnit elementUnit in notify.ElementUnits)
			{
				this.ElementMap[elementUnit.ElementId] = elementUnit;
			}
		}

		// Token: 0x06028B86 RID: 166790 RVA: 0x00B6B498 File Offset: 0x00B69698
		public void UpdateFetterData(RogueResRoleBondUpdateNotify notify)
		{
			foreach (RoleBondInfo roleBondInfo in notify.RoleBondInfos)
			{
				this.RoleFetterMap[roleBondInfo.ConfigId] = roleBondInfo;
			}
		}

		// Token: 0x06028B87 RID: 166791 RVA: 0x00B6B4F0 File Offset: 0x00B696F0
		public void InitOptionData(RogueResInstOptionsNotify data)
		{
			foreach (KeyValuePair<int, RogueResOption> keyValuePair in data.RogueResOptionDict)
			{
				int key = keyValuePair.Key;
				RogueResOption value = keyValuePair.Value;
				this.SetOptionData(key, value);
			}
		}

		// Token: 0x06028B88 RID: 166792 RVA: 0x00B6B550 File Offset: 0x00B69750
		public void InitGainData(RogueResGainDataTotalNotify data)
		{
			this.RoleFetterMap.Clear();
			this.TotalGainDataMap.Clear();
			this.GainDataMap.Clear();
			this.RoleFetterMap.Clear();
			this.ElementMap.Clear();
			foreach (RogueResGainData rogueResGainData in data.RogueResGainDatas)
			{
				if (!this.TotalGainDataMap.ContainsKey(rogueResGainData.RogueResDataType))
				{
					this.TotalGainDataMap[rogueResGainData.RogueResDataType] = new Dictionary<int, RogueResGainData>();
				}
				if (rogueResGainData.RogueResDataType == RogueResDataType.Role)
				{
					this.TotalGainDataMap[rogueResGainData.RogueResDataType][rogueResGainData.RogueResRole.RoleIdOrTrialRoleId] = rogueResGainData;
				}
				else
				{
					this.TotalGainDataMap[rogueResGainData.RogueResDataType][rogueResGainData.IncId] = rogueResGainData;
				}
				this.GainDataMap[rogueResGainData.IncId] = rogueResGainData;
			}
			this.ElementMap[1] = new ElementUnit
			{
				ElementId = 1,
				Count = 0
			};
			this.ElementMap[2] = new ElementUnit
			{
				ElementId = 2,
				Count = 0
			};
			this.ElementMap[3] = new ElementUnit
			{
				ElementId = 3,
				Count = 0
			};
			this.ElementMap[4] = new ElementUnit
			{
				ElementId = 4,
				Count = 0
			};
			foreach (ElementUnit elementUnit in data.ElementUnits)
			{
				this.ElementMap[elementUnit.ElementId] = elementUnit;
			}
			foreach (RoleBondInfo roleBondInfo in data.RoleBondInfos)
			{
				this.RoleFetterMap[roleBondInfo.ConfigId] = roleBondInfo;
			}
		}

		// Token: 0x06028B89 RID: 166793 RVA: 0x00B6B76C File Offset: 0x00B6996C
		public void InitFormationData(List<RogueResFormation> data)
		{
			this.FormationData = data;
		}

		// Token: 0x06028B8A RID: 166794 RVA: 0x00B6B778 File Offset: 0x00B69978
		protected override bool OnClear()
		{
			this.OptionMap.Clear();
			this.TotalGainDataMap.Clear();
			this.GainDataMap.Clear();
			this.ElementMap.Clear();
			this.SelectGainData = null;
			this.CurrentBindId = 0;
			this.CurrentRoomTypeId = string.Empty;
			this.CurrentRoomId = 0;
			this.CurrentRoomMusicState = "none";
			return true;
		}

		// Token: 0x06028B8B RID: 166795 RVA: 0x00B6B7E0 File Offset: 0x00B699E0
		public List<IRogueBattleElementInfo> GetTotalElementInfo([Nullable(new byte[]
		{
			2,
			1
		})] List<ElementUnit> addElement = null)
		{
			Dictionary<int, IRogueBattleElementInfo> dictionary = new Dictionary<int, IRogueBattleElementInfo>();
			if (addElement != null)
			{
				foreach (ElementUnit elementUnit in addElement)
				{
					RogueBattleElementInfo value = new RogueBattleElementInfo
					{
						ElementId = elementUnit.ElementId,
						Count = elementUnit.Count,
						IsPreview = true
					};
					dictionary[elementUnit.ElementId] = value;
				}
			}
			foreach (ElementUnit elementUnit2 in this.ElementMap.Values)
			{
				if (!dictionary.ContainsKey(elementUnit2.ElementId))
				{
					RogueBattleElementInfo value2 = new RogueBattleElementInfo
					{
						ElementId = elementUnit2.ElementId,
						Count = elementUnit2.Count,
						IsPreview = false
					};
					dictionary[elementUnit2.ElementId] = value2;
				}
				else
				{
					dictionary[elementUnit2.ElementId].Count += elementUnit2.Count;
				}
			}
			List<IRogueBattleElementInfo> list = new List<IRogueBattleElementInfo>();
			foreach (IRogueBattleElementInfo item in dictionary.Values)
			{
				list.Add(item);
			}
			for (int i = 0; i < list.Count - 1; i++)
			{
				for (int j = i + 1; j < list.Count; j++)
				{
					if (list[i].ElementId > list[j].ElementId)
					{
						IRogueBattleElementInfo value3 = list[i];
						list[i] = list[j];
						list[j] = value3;
					}
				}
			}
			return list;
		}

		// Token: 0x06028B8C RID: 166796 RVA: 0x00B6B9CC File Offset: 0x00B69BCC
		public int GetTotalElementCount()
		{
			int num = 0;
			foreach (ElementUnit elementUnit in this.ElementMap.Values)
			{
				num += elementUnit.Count;
			}
			return num;
		}

		// Token: 0x06028B8D RID: 166797 RVA: 0x00B6BA2C File Offset: 0x00B69C2C
		[NullableContext(2)]
		public IRogueBattleElementInfo GetElementInfoById(int id)
		{
			ElementUnit elementUnit;
			if (this.ElementMap.TryGetValue(id, out elementUnit))
			{
				return new RogueBattleElementInfo
				{
					ElementId = elementUnit.ElementId,
					Count = elementUnit.Count,
					IsPreview = false
				};
			}
			return null;
		}

		// Token: 0x06028B8E RID: 166798 RVA: 0x00B6BA70 File Offset: 0x00B69C70
		public bool CheckPhantomAffixCanUnlock(PhantomAffixInfo data)
		{
			bool result = true;
			foreach (ElementUnit elementUnit in data.ElementUnits)
			{
				ElementUnit elementUnit2;
				if (!this.ElementMap.TryGetValue(elementUnit.ElementId, out elementUnit2) || elementUnit2.Count < elementUnit.Count)
				{
					result = false;
					break;
				}
			}
			return result;
		}

		// Token: 0x06028B8F RID: 166799 RVA: 0x00B6BAE0 File Offset: 0x00B69CE0
		public int GetCurrentSeasonId()
		{
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			if (instanceId == 0)
			{
				return 0;
			}
			RogueResDungeonConfig? config = ConfigRogueResDungeonConfigById.GetConfig(instanceId, true);
			if (config == null)
			{
				return ActivityPermanentRogueModel.Instance.GetNewSeasonId();
			}
			return config.Value.SeasonId;
		}

		// Token: 0x06028B90 RID: 166800 RVA: 0x00B6BB28 File Offset: 0x00B69D28
		public List<IRogueBattleMapRoleGridInfo> GetRoleListByBond(int bondId)
		{
			if (this.BondAllRoleMap.Count == 0)
			{
				IReadOnlyList<RogueResBondRole> allRogueResBondRole = RogueBattleConfig.Instance.GetAllRogueResBondRole();
				if (allRogueResBondRole != null)
				{
					foreach (RogueResBondRole rogueResBondRole in allRogueResBondRole)
					{
						for (int i = 0; i < rogueResBondRole.BondIdsLength; i++)
						{
							int key = rogueResBondRole.BondIds(i);
							if (!this.BondAllRoleMap.ContainsKey(key))
							{
								this.BondAllRoleMap[key] = new List<int>();
							}
							this.BondAllRoleMap[key].Add(rogueResBondRole.RoleId);
						}
					}
				}
			}
			List<int> list;
			if (!this.BondAllRoleMap.TryGetValue(bondId, out list))
			{
				return new List<IRogueBattleMapRoleGridInfo>();
			}
			List<IRogueBattleMapRoleGridInfo> list2 = new List<IRogueBattleMapRoleGridInfo>();
			List<IRogueBattleMapRoleGridInfo> list3 = new List<IRogueBattleMapRoleGridInfo>();
			int currentSeasonId = this.GetCurrentSeasonId();
			List<int> trailRole = ActivityPermanentRogueModel.Instance.GetTrailRole(currentSeasonId, ERogueResTrialType.Static);
			List<int> trailRole2 = ActivityPermanentRogueModel.Instance.GetTrailRole(currentSeasonId, ERogueResTrialType.Dynamic);
			foreach (int num in list)
			{
				if (this.IsRoleGot(num))
				{
					RogueBattleMapRoleGridInfo item = new RogueBattleMapRoleGridInfo
					{
						IsGain = true,
						ConfigId = num,
						NeedLevel = false
					};
					list2.Add(item);
				}
				else if (!RoleModel.Instance.IsMainRole(num))
				{
					RogueResBondRole value = RogueBattleConfig.Instance.GetRogueResBondRole(num).Value;
					if (this.IsRoleGot(value.TrialRoleId))
					{
						RogueBattleMapRoleGridInfo item2 = new RogueBattleMapRoleGridInfo
						{
							IsGain = true,
							ConfigId = value.TrialRoleId,
							NeedLevel = false
						};
						list2.Add(item2);
					}
					else
					{
						bool flag = trailRole.Contains(value.TrialRoleId);
						bool flag2 = trailRole2.Contains(value.TrialRoleId);
						int configId;
						if (flag || flag2)
						{
							configId = value.TrialRoleId;
						}
						else
						{
							configId = num;
						}
						RogueBattleMapRoleGridInfo item3 = new RogueBattleMapRoleGridInfo
						{
							IsGain = false,
							ConfigId = configId,
							NeedLevel = false
						};
						list3.Add(item3);
					}
				}
			}
			for (int j = 0; j < list2.Count - 1; j++)
			{
				for (int k = j + 1; k < list2.Count; k++)
				{
					RogueResRole roleInfoById = this.GetRoleInfoById(list2[j].ConfigId);
					bool roleIsRogueTrial = this.GetRoleIsRogueTrial(list2[j].ConfigId);
					RogueResRole roleInfoById2 = this.GetRoleInfoById(list2[k].ConfigId);
					bool roleIsRogueTrial2 = this.GetRoleIsRogueTrial(list2[k].ConfigId);
					bool flag3 = false;
					if (roleInfoById.Level == roleInfoById2.Level)
					{
						if (roleIsRogueTrial != roleIsRogueTrial2)
						{
							flag3 = !roleIsRogueTrial;
						}
						else if (list2[j].ConfigId > list2[k].ConfigId)
						{
							flag3 = true;
						}
					}
					else if (roleInfoById2.Level > roleInfoById.Level)
					{
						flag3 = true;
					}
					if (flag3)
					{
						IRogueBattleMapRoleGridInfo value2 = list2[j];
						list2[j] = list2[k];
						list2[k] = value2;
					}
				}
			}
			for (int l = 0; l < list3.Count - 1; l++)
			{
				for (int m = l + 1; m < list3.Count; m++)
				{
					bool roleIsRogueTrial3 = this.GetRoleIsRogueTrial(list3[l].ConfigId);
					bool roleCantGet = this.GetRoleCantGet(list3[l].ConfigId);
					bool roleIsRogueTrial4 = this.GetRoleIsRogueTrial(list3[m].ConfigId);
					bool roleCantGet2 = this.GetRoleCantGet(list3[m].ConfigId);
					bool flag4 = false;
					if (roleIsRogueTrial3 != roleIsRogueTrial4)
					{
						flag4 = !roleIsRogueTrial3;
					}
					else if (roleCantGet != roleCantGet2)
					{
						flag4 = (roleCantGet && !roleCantGet2);
					}
					else if (list3[l].ConfigId > list3[m].ConfigId)
					{
						flag4 = true;
					}
					if (flag4)
					{
						IRogueBattleMapRoleGridInfo value3 = list3[l];
						list3[l] = list3[m];
						list3[m] = value3;
					}
				}
			}
			List<IRogueBattleMapRoleGridInfo> list4 = new List<IRogueBattleMapRoleGridInfo>();
			list4.AddRange(list2);
			list4.AddRange(list3);
			return list4;
		}

		// Token: 0x06028B91 RID: 166801 RVA: 0x00B6BF98 File Offset: 0x00B6A198
		public bool GetRoleCantGet(int roleRogueId)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleRogueId);
			return !RoleConfig.Instance.IsTrialRole(roleRogueId) && RoleModel.Instance.GetRoleInstanceById(roleConfig.Value.Id) == null;
		}

		// Token: 0x06028B92 RID: 166802 RVA: 0x00B6BFDC File Offset: 0x00B6A1DC
		public bool GetRoleIsRogueTrial(int roleRogueId)
		{
			RoleInfo value = RoleConfig.Instance.GetRoleConfig(roleRogueId).Value;
			return RoleConfig.Instance.IsTrialRole(roleRogueId) && RoleModel.Instance.GetRoleInstanceById(value.Id) == null;
		}

		// Token: 0x06028B93 RID: 166803 RVA: 0x00B6C020 File Offset: 0x00B6A220
		public List<IRogueBattleMapGridEffectInfo> GetEffectList()
		{
			Dictionary<string, IRogueBattleMapGridEffectInfo> dictionary = new Dictionary<string, IRogueBattleMapGridEffectInfo>();
			this.GetTeamStaticEffect(dictionary);
			this.GetTeamEffectList(dictionary);
			this.GetBondExploreEffect(dictionary);
			List<IRogueBattleMapGridEffectInfo> list = new List<IRogueBattleMapGridEffectInfo>();
			foreach (KeyValuePair<string, IRogueBattleMapGridEffectInfo> keyValuePair in dictionary)
			{
				list.Add(keyValuePair.Value);
			}
			return list;
		}

		// Token: 0x06028B94 RID: 166804 RVA: 0x00B6C098 File Offset: 0x00B6A298
		private void GetTeamEffectList(Dictionary<string, IRogueBattleMapGridEffectInfo> infoMap)
		{
			int teamLv = MapRogueModel.Instance.GameInfo.TeamLv;
			IReadOnlyList<RogueResTeamLvRule> allRogueResTeamLvRule = RogueBattleConfig.Instance.GetAllRogueResTeamLvRule();
			if (allRogueResTeamLvRule == null)
			{
				return;
			}
			foreach (RogueResTeamLvRule rogueResTeamLvRule in allRogueResTeamLvRule)
			{
				if (rogueResTeamLvRule.LevelRangeLength == 2 && rogueResTeamLvRule.RangeEffectsLength > 0 && teamLv >= rogueResTeamLvRule.LevelRange(0))
				{
					for (int i = 0; i < rogueResTeamLvRule.RangeEffectsLength; i++)
					{
						int id = rogueResTeamLvRule.RangeEffects(i);
						RogueResEffect? rogueResEffectById = RogueBattleConfig.Instance.GetRogueResEffectById(id);
						if (rogueResEffectById != null)
						{
							RogueResEffectTag? rogueResEffectTagById = RogueBattleConfig.Instance.GetRogueResEffectTagById(rogueResEffectById.Value.Tag);
							if (rogueResEffectTagById != null)
							{
								int num = (teamLv >= rogueResTeamLvRule.LevelRange(1)) ? (rogueResTeamLvRule.LevelRange(1) - rogueResTeamLvRule.LevelRange(0) + 1) : (teamLv - rogueResTeamLvRule.LevelRange(0) + 1);
								if (!infoMap.ContainsKey(rogueResEffectTagById.Value.Text))
								{
									RogueBattleMapGridEffectInfo value = new RogueBattleMapGridEffectInfo
									{
										TagKey = rogueResEffectTagById.Value.Text,
										Count = num * rogueResEffectById.Value.DescIntParam,
										IsRatio = rogueResEffectTagById.Value.IsRatio,
										Icon = rogueResEffectTagById.Value.Icon
									};
									infoMap[rogueResEffectTagById.Value.Text] = value;
								}
								else
								{
									infoMap[rogueResEffectTagById.Value.Text].Count += num * rogueResEffectById.Value.DescIntParam;
								}
							}
						}
					}
				}
				if (rogueResTeamLvRule.TargetLevel != 0 && teamLv >= rogueResTeamLvRule.TargetLevel && rogueResTeamLvRule.TargetEffectsLength > 0)
				{
					for (int j = 0; j < rogueResTeamLvRule.TargetEffectsLength; j++)
					{
						int id2 = rogueResTeamLvRule.TargetEffects(j);
						RogueResEffect? rogueResEffectById2 = RogueBattleConfig.Instance.GetRogueResEffectById(id2);
						if (rogueResEffectById2 != null)
						{
							RogueResEffectTag? rogueResEffectTagById2 = RogueBattleConfig.Instance.GetRogueResEffectTagById(rogueResEffectById2.Value.Tag);
							if (rogueResEffectTagById2 != null)
							{
								if (!infoMap.ContainsKey(rogueResEffectTagById2.Value.Text))
								{
									RogueBattleMapGridEffectInfo value2 = new RogueBattleMapGridEffectInfo
									{
										TagKey = rogueResEffectTagById2.Value.Text,
										Count = rogueResEffectById2.Value.DescIntParam,
										IsRatio = rogueResEffectTagById2.Value.IsRatio,
										Icon = rogueResEffectTagById2.Value.Icon
									};
									infoMap[rogueResEffectTagById2.Value.Text] = value2;
								}
								else
								{
									infoMap[rogueResEffectTagById2.Value.Text].Count += rogueResEffectById2.Value.DescIntParam;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06028B95 RID: 166805 RVA: 0x00B6C3E4 File Offset: 0x00B6A5E4
		private void GetTeamStaticEffect(Dictionary<string, IRogueBattleMapGridEffectInfo> infoMap)
		{
			int teamLv = MapRogueModel.Instance.GameInfo.TeamLv;
			IReadOnlyList<RogueResTeamLvRule> allRogueResTeamLvRule = RogueBattleConfig.Instance.GetAllRogueResTeamLvRule();
			if (allRogueResTeamLvRule == null)
			{
				return;
			}
			RogueResEffectTag value = RogueBattleConfig.Instance.GetRogueResEffectTagById(34).Value;
			RogueBattleMapGridEffectInfo rogueBattleMapGridEffectInfo = new RogueBattleMapGridEffectInfo
			{
				TagKey = value.Text,
				Count = 0,
				IsRatio = false,
				Icon = value.Icon
			};
			RogueResEffectTag value2 = RogueBattleConfig.Instance.GetRogueResEffectTagById(32).Value;
			RogueBattleMapGridEffectInfo rogueBattleMapGridEffectInfo2 = new RogueBattleMapGridEffectInfo
			{
				TagKey = value2.Text,
				Count = 0,
				IsRatio = false,
				Icon = value2.Icon
			};
			foreach (RogueResTeamLvRule rogueResTeamLvRule in allRogueResTeamLvRule)
			{
				if (rogueResTeamLvRule.LevelRangeLength == 2 && rogueResTeamLvRule.RoleLevel > 0 && teamLv >= rogueResTeamLvRule.LevelRange(0))
				{
					int num = (teamLv >= rogueResTeamLvRule.LevelRange(1)) ? (rogueResTeamLvRule.LevelRange(1) - rogueResTeamLvRule.LevelRange(0) + 1) : (teamLv - rogueResTeamLvRule.LevelRange(0) + 1);
					rogueBattleMapGridEffectInfo.Count += num * rogueResTeamLvRule.RoleLevel;
				}
			}
			rogueBattleMapGridEffectInfo2.Count = rogueBattleMapGridEffectInfo.Count;
			List<RogueResSkillLvRule> list = new List<RogueResSkillLvRule>(RogueBattleConfig.Instance.GetAllRogueResSkillLvRule() ?? new List<RogueResSkillLvRule>());
			list.Sort(delegate(RogueResSkillLvRule a, RogueResSkillLvRule b)
			{
				if (a.Level == b.Level)
				{
					return 0;
				}
				if (a.Level <= b.Level)
				{
					return -1;
				}
				return 1;
			});
			RogueResEffectTag value3 = RogueBattleConfig.Instance.GetRogueResEffectTagById(33).Value;
			RogueBattleMapGridEffectInfo rogueBattleMapGridEffectInfo3 = new RogueBattleMapGridEffectInfo
			{
				TagKey = value3.Text,
				Count = 0,
				IsRatio = false,
				Icon = value3.Icon
			};
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (teamLv >= list[i].Level)
				{
					int count = 0;
					for (int j = 0; j < list[i].SkillLevelLength; j++)
					{
						if (list[i].SkillLevel(j).Value.Key == teamLv)
						{
							count = list[i].SkillLevel(j).Value.Value;
							break;
						}
					}
					rogueBattleMapGridEffectInfo3.Count = count;
					break;
				}
			}
			infoMap[value.Text] = rogueBattleMapGridEffectInfo;
			infoMap[value2.Text] = rogueBattleMapGridEffectInfo2;
			infoMap[value3.Text] = rogueBattleMapGridEffectInfo3;
		}

		// Token: 0x06028B96 RID: 166806 RVA: 0x00B6C6B0 File Offset: 0x00B6A8B0
		private void GetBondExploreEffect(Dictionary<string, IRogueBattleMapGridEffectInfo> infoMap)
		{
			foreach (RoleBondInfo roleBondInfo in this.GetAllOwnedRoleBondData())
			{
				if (roleBondInfo.Level != 0)
				{
					RogueResBond? rogueResBond = RogueBattleConfig.Instance.GetRogueResBond(roleBondInfo.ConfigId);
					if (rogueResBond != null && rogueResBond.Value.ExploreEffectLength != 0)
					{
						for (int i = 0; i < rogueResBond.Value.ExploreEffectLength; i++)
						{
							DicIntInt? dicIntInt = rogueResBond.Value.ExploreEffect(i);
							int key = dicIntInt.Value.Key;
							int value = dicIntInt.Value.Value;
							if (roleBondInfo.Level >= key)
							{
								RogueResEffect? rogueResEffectById = RogueBattleConfig.Instance.GetRogueResEffectById(value);
								if (rogueResEffectById != null)
								{
									RogueResEffectTag? rogueResEffectTagById = RogueBattleConfig.Instance.GetRogueResEffectTagById(rogueResEffectById.Value.Tag);
									if (rogueResEffectTagById != null)
									{
										if (!infoMap.ContainsKey(rogueResEffectTagById.Value.Text))
										{
											RogueBattleMapGridEffectInfo value2 = new RogueBattleMapGridEffectInfo
											{
												TagKey = rogueResEffectTagById.Value.Text,
												Count = rogueResEffectById.Value.DescIntParam,
												IsRatio = rogueResEffectTagById.Value.IsRatio,
												Icon = rogueResEffectTagById.Value.Icon
											};
											infoMap[rogueResEffectTagById.Value.Text] = value2;
										}
										else
										{
											infoMap[rogueResEffectTagById.Value.Text].Count += rogueResEffectById.Value.DescIntParam;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06028B97 RID: 166807 RVA: 0x00B6C8B8 File Offset: 0x00B6AAB8
		public bool GetRogueResNewRoleFlag()
		{
			ServerStorageUtil.OverrideLocalBooleanToServerBoolean(ELocalStoragePlayerKey.RogueResNewRoleFlag, EClientStorageSystemIdType.RogueResNewRoleFlag, true);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResNewRoleFlag) as ServerStorageBoolean).Get().GetValueOrDefault();
		}

		// Token: 0x06028B98 RID: 166808 RVA: 0x00B6C8F4 File Offset: 0x00B6AAF4
		public void SetRogueResNewRoleFlag(bool bNew)
		{
			ServerStorageBoolean serverStorageBoolean = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResNewRoleFlag) as ServerStorageBoolean;
			bool? flag = serverStorageBoolean.Get();
			if (flag.GetValueOrDefault() == bNew & flag != null)
			{
				return;
			}
			serverStorageBoolean.Set(new bool?(bNew));
			EventSystem.Instance.Emit(EEventName.RogueResNewRoleFlagChange);
		}

		// Token: 0x06028B99 RID: 166809 RVA: 0x00B6C950 File Offset: 0x00B6AB50
		public void ClearData()
		{
			this.TotalGainDataMap.Clear();
			this.BondAllRoleMap.Clear();
			this.GainDataMap.Clear();
			this.ElementMap.Clear();
			this.RoleFetterMap.Clear();
			this.FormationData = new List<RogueResFormation>();
		}

		// Token: 0x170052E2 RID: 21218
		// (get) Token: 0x06028B9A RID: 166810 RVA: 0x00B6C99F File Offset: 0x00B6AB9F
		public static RogueBattleModel Instance
		{
			get
			{
				return RogueBattleModel._Instance;
			}
		}

		// Token: 0x06028B9B RID: 166811 RVA: 0x00B6C9A6 File Offset: 0x00B6ABA6
		public static RogueBattleModel GetOrCreateInstance()
		{
			if (RogueBattleModel._Instance == null)
			{
				RogueBattleModel.CreateInstance();
			}
			return RogueBattleModel._Instance;
		}

		// Token: 0x06028B9C RID: 166812 RVA: 0x00B6C9BA File Offset: 0x00B6ABBA
		public static bool CreateInstance()
		{
			if (RogueBattleModel._Instance != null)
			{
				return true;
			}
			RogueBattleModel._Instance = new RogueBattleModel();
			return true;
		}

		// Token: 0x06028B9D RID: 166813 RVA: 0x00B6C9D0 File Offset: 0x00B6ABD0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06028B9E RID: 166814 RVA: 0x00B6C9D2 File Offset: 0x00B6ABD2
		public static void ResetStaticDefaultValue()
		{
			RogueBattleModel._Instance = null;
		}

		// Token: 0x06028B9F RID: 166815 RVA: 0x00B6C9DA File Offset: 0x00B6ABDA
		static RogueBattleModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RogueBattleModel.CreateStaticDefaultValue), new Action(RogueBattleModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401622C RID: 90668
		public Dictionary<RogueResDataType, Dictionary<int, RogueResGainData>> TotalGainDataMap = new Dictionary<RogueResDataType, Dictionary<int, RogueResGainData>>();

		// Token: 0x0401622D RID: 90669
		public Dictionary<int, RogueResGainData> GainDataMap = new Dictionary<int, RogueResGainData>();

		// Token: 0x0401622E RID: 90670
		public Dictionary<int, ElementUnit> ElementMap = new Dictionary<int, ElementUnit>();

		// Token: 0x0401622F RID: 90671
		public Dictionary<int, RoleBondInfo> RoleFetterMap = new Dictionary<int, RoleBondInfo>();

		// Token: 0x04016230 RID: 90672
		public Dictionary<int, List<int>> BondAllRoleMap = new Dictionary<int, List<int>>();

		// Token: 0x04016231 RID: 90673
		public List<RogueResFormation> FormationData = new List<RogueResFormation>();

		// Token: 0x04016232 RID: 90674
		public EDescModel DescMode;

		// Token: 0x04016233 RID: 90675
		[Nullable(2)]
		public RogueResGainData SelectGainData;

		// Token: 0x04016234 RID: 90676
		public int CurrentBindId;

		// Token: 0x04016235 RID: 90677
		public string CurrentRoomTypeId = string.Empty;

		// Token: 0x04016236 RID: 90678
		public int CurrentRoomId;

		// Token: 0x04016237 RID: 90679
		public int CurrentMapSummaryBond;

		// Token: 0x04016238 RID: 90680
		public bool IsMapSummaryBondJumping;

		// Token: 0x04016239 RID: 90681
		public int MaxRoleStar;

		// Token: 0x0401623A RID: 90682
		public List<int> SummaryRoleList = new List<int>();

		// Token: 0x0401623B RID: 90683
		private readonly StateRef CurrentRoomMusicStateInternal = new StateRef("game_rogue_room_type", "none");

		// Token: 0x0401623C RID: 90684
		private readonly Dictionary<int, RogueResOption> OptionMap = new Dictionary<int, RogueResOption>();

		// Token: 0x0401623D RID: 90685
		[Nullable(2)]
		private static RogueBattleModel _Instance;
	}
}
