using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Item.Data;
using CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.RoleDevelopWorldDropEnoughTips;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CF2 RID: 15602
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RoleDevelopModel : ModelBase
	{
		// Token: 0x170051F3 RID: 20979
		// (get) Token: 0x06027E81 RID: 163457 RVA: 0x00B278B0 File Offset: 0x00B25AB0
		// (set) Token: 0x06027E82 RID: 163458 RVA: 0x00B278B8 File Offset: 0x00B25AB8
		public bool IsWorldDropTipShowing { get; set; }

		// Token: 0x06027E83 RID: 163459 RVA: 0x00B278C4 File Offset: 0x00B25AC4
		protected override bool OnInit()
		{
			EventSystem.Instance.Add<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
			EventSystem.Instance.Add<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnRoleBreakUp));
			EventSystem.Instance.Add<int, ArrayIntInt>(EEventName.RoleSkillLevelUp, new Action<int, ArrayIntInt>(this.OnRoleSkillLevelUp));
			EventSystem.Instance.Add<int>(EEventName.WeaponRoleEquipChanged, new Action<int>(this.OnTargetRoleChanged));
			EventSystem.Instance.Add<int>(EEventName.WeaponRoleLevelUp, new Action<int>(this.OnTargetRoleChanged));
			EventSystem.Instance.Add<int>(EEventName.WeaponRoleBreakUp, new Action<int>(this.OnTargetRoleChanged));
			EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
			EventSystem.Instance.Add<ItemRewardNotify>(EEventName.OnItemRewardNotify, new Action<ItemRewardNotify>(this.OnItemRewardNotify));
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			EventSystem.Instance.Add<int>(EEventName.ActiveRole, new Action<int>(this.OnActiveRole));
			EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnMainRoleChanged));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			return true;
		}

		// Token: 0x06027E84 RID: 163460 RVA: 0x00B27A40 File Offset: 0x00B25C40
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
			EventSystem.Instance.Remove<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnRoleBreakUp));
			EventSystem.Instance.Remove<int, ArrayIntInt>(EEventName.RoleSkillLevelUp, new Action<int, ArrayIntInt>(this.OnRoleSkillLevelUp));
			EventSystem.Instance.Remove<int>(EEventName.WeaponRoleEquipChanged, new Action<int>(this.OnTargetRoleChanged));
			EventSystem.Instance.Remove<int>(EEventName.WeaponRoleLevelUp, new Action<int>(this.OnTargetRoleChanged));
			EventSystem.Instance.Remove<int>(EEventName.WeaponRoleBreakUp, new Action<int>(this.OnTargetRoleChanged));
			EventSystem.Instance.Remove<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
			EventSystem.Instance.Remove<ItemRewardNotify>(EEventName.OnItemRewardNotify, new Action<ItemRewardNotify>(this.OnItemRewardNotify));
			EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			EventSystem.Instance.Remove<int>(EEventName.ActiveRole, new Action<int>(this.OnActiveRole));
			EventSystem.Instance.Remove<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnMainRoleChanged));
			EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Remove<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			return true;
		}

		// Token: 0x06027E85 RID: 163461 RVA: 0x00B27BBA File Offset: 0x00B25DBA
		private void OnRoleLevelUp(int roleId, int exp, int level)
		{
			this.OnTargetRoleChanged(roleId);
		}

		// Token: 0x06027E86 RID: 163462 RVA: 0x00B27BC3 File Offset: 0x00B25DC3
		private void OnRoleBreakUp(int roleId, int level)
		{
			this.OnTargetRoleChanged(roleId);
		}

		// Token: 0x06027E87 RID: 163463 RVA: 0x00B27BCC File Offset: 0x00B25DCC
		private void OnRoleSkillLevelUp(int roleId, ArrayIntInt skillInfo)
		{
			this.OnTargetRoleChanged(roleId);
		}

		// Token: 0x06027E88 RID: 163464 RVA: 0x00B27BD5 File Offset: 0x00B25DD5
		private void OnTargetRoleChanged(int roleId)
		{
			if (roleId == this.DevTargetRoleIdInternal)
			{
				this.InvalidateNeedItemCache();
			}
		}

		// Token: 0x06027E89 RID: 163465 RVA: 0x00B27BE6 File Offset: 0x00B25DE6
		private void OnPlayerLevelChanged(int i, int i1, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			this.InvalidateNeedItemCache();
		}

		// Token: 0x06027E8A RID: 163466 RVA: 0x00B27BF0 File Offset: 0x00B25DF0
		private void OnActiveRole(int roleId)
		{
			if (this.RoleDevelopDataMap.Count == 0)
			{
				return;
			}
			if (!this.RoleDevelopDataMap.ContainsKey(roleId) && RoleDevConfig.Instance.GetRoleDevProjectConfig(roleId) != null)
			{
				this.CreateRoleDevelopData(roleId);
			}
			this.InvalidateNeedItemCache();
		}

		// Token: 0x06027E8B RID: 163467 RVA: 0x00B27C3C File Offset: 0x00B25E3C
		private void OnMainRoleChanged(int roleId)
		{
			if (!RoleModel.Instance.IsMainRole(roleId))
			{
				return;
			}
			if (this.RoleDevelopDataMap.Count == 0)
			{
				return;
			}
			int? num = null;
			foreach (int num2 in this.RoleDevelopDataMap.Keys)
			{
				if (RoleModel.Instance.IsMainRole(num2) && num2 != roleId)
				{
					num = new int?(num2);
					break;
				}
			}
			if (num != null)
			{
				int valueOrDefault = num.GetValueOrDefault();
				this.RoleDevelopDataMap.Remove(valueOrDefault);
			}
			if (!this.RoleDevelopDataMap.ContainsKey(roleId) && RoleDevConfig.Instance.GetRoleDevProjectConfig(roleId) != null)
			{
				this.CreateRoleDevelopData(roleId);
			}
			if (this.DevTargetRoleIdInternal != 0 && RoleModel.Instance.IsMainRole(this.DevTargetRoleIdInternal) && this.DevTargetRoleIdInternal != roleId)
			{
				this.SetDevTargetRoleId(roleId);
			}
			this.InvalidateNeedItemCache();
		}

		// Token: 0x06027E8C RID: 163468 RVA: 0x00B27D48 File Offset: 0x00B25F48
		private void OnFunctionOpenUpdate(EFunctionType functionType, bool isOpen)
		{
			if (functionType == EFunctionType.RoleDev && isOpen)
			{
				if (this.GetRoleDevelopNewState() == ERoleDevelopNewState.None)
				{
					this.SetRoleDevelopNewState(ERoleDevelopNewState.New);
				}
				int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
				if (curSelectMainRoleId != null)
				{
					RoleController.Instance.LogRoleDevelopSkillRecommendClick(curSelectMainRoleId.Value, true);
				}
			}
		}

		// Token: 0x06027E8D RID: 163469 RVA: 0x00B27D96 File Offset: 0x00B25F96
		public ERoleDevelopNewState GetRoleDevelopNewState()
		{
			return (ERoleDevelopNewState)LocalStorage.GetPlayer<int>(ELocalStoragePlayerKey.RoleDevelopNewState, 0);
		}

		// Token: 0x06027E8E RID: 163470 RVA: 0x00B27DA3 File Offset: 0x00B25FA3
		private void SetRoleDevelopNewState(ERoleDevelopNewState state)
		{
			LocalStorage.SetPlayer<int>(ELocalStoragePlayerKey.RoleDevelopNewState, (int)state);
		}

		// Token: 0x06027E8F RID: 163471 RVA: 0x00B27DB1 File Offset: 0x00B25FB1
		public void MarkRoleDevelopNewDismissed()
		{
			if (this.GetRoleDevelopNewState() == ERoleDevelopNewState.New)
			{
				this.SetRoleDevelopNewState(ERoleDevelopNewState.Dismissed);
			}
		}

		// Token: 0x170051F4 RID: 20980
		// (get) Token: 0x06027E90 RID: 163472 RVA: 0x00B27DC3 File Offset: 0x00B25FC3
		public string Version
		{
			get
			{
				return this.VersionInternal;
			}
		}

		// Token: 0x170051F5 RID: 20981
		// (get) Token: 0x06027E91 RID: 163473 RVA: 0x00B27DCB File Offset: 0x00B25FCB
		public int DevTargetRoleId
		{
			get
			{
				return this.DevTargetRoleIdInternal;
			}
		}

		// Token: 0x06027E92 RID: 163474 RVA: 0x00B27DD4 File Offset: 0x00B25FD4
		public void UpdateRoleDevConfig(RoleDevelopConfigs configs)
		{
			RepeatedField<RoleDevPropsConfig> devPropsList = configs.DevPropsList;
			if (devPropsList != null && devPropsList.Count > 0)
			{
				RoleDevConfig.Instance.UpdateDevProsListConfig(devPropsList);
			}
			if (configs.DevTargetRole != 0)
			{
				this.SetDevTargetRoleId(configs.DevTargetRole);
			}
			RepeatedField<RoleDevPropsProjectConfig> devPropsProjectList = configs.DevPropsProjectList;
			if (devPropsProjectList != null && devPropsProjectList.Count > 0)
			{
				RoleDevConfig.Instance.UpdateDevPropsProjectConfig(devPropsProjectList);
			}
			if (!string.IsNullOrEmpty(configs.Version))
			{
				this.VersionInternal = configs.Version;
			}
		}

		// Token: 0x06027E93 RID: 163475 RVA: 0x00B27E4A File Offset: 0x00B2604A
		public void UpdateDevTargetRoleId(int roleId)
		{
			this.SetDevTargetRoleId(roleId);
			this.InvalidateNeedItemCache();
		}

		// Token: 0x06027E94 RID: 163476 RVA: 0x00B27E5C File Offset: 0x00B2605C
		private void SetDevTargetRoleId(int roleId)
		{
			if (!RoleDevelopUtil.IsProspectRole(roleId))
			{
				IEnumerable<RoleInfo> roleList = RoleConfig.Instance.GetRoleList();
				bool flag = false;
				foreach (RoleInfo roleInfo in roleList)
				{
					if (roleInfo.RoleType == 1 && roleInfo.Id == roleId)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					this.DevTargetRoleIdInternal = 0;
					return;
				}
			}
			RoleModel instance = RoleModel.Instance;
			if (instance.IsMainRole(roleId))
			{
				int? curSelectMainRoleId = instance.GetCurSelectMainRoleId();
				if (curSelectMainRoleId != null)
				{
					int valueOrDefault = curSelectMainRoleId.GetValueOrDefault();
					if (valueOrDefault != roleId)
					{
						this.DevTargetRoleIdInternal = valueOrDefault;
						return;
					}
				}
			}
			this.DevTargetRoleIdInternal = roleId;
		}

		// Token: 0x06027E95 RID: 163477 RVA: 0x00B27F14 File Offset: 0x00B26114
		public bool IsShowInHotRoleList(int id)
		{
			if (!RoleDevelopUtil.IsHotRole(id))
			{
				return false;
			}
			int typeId = RoleDevConfig.Instance.GetRoleDevProsListConfig(id).TypeId;
			if (typeId == 4 || typeId == 0)
			{
				return false;
			}
			if (typeId == 1)
			{
				return RoleDevelopUtil.IsProspectRoleValid(id);
			}
			if (typeId == 2)
			{
				return RoleDevelopUtil.IsCurrentVersionProspectRoleValid(id);
			}
			if (typeId == 3)
			{
				return RoleDevelopUtil.IsReturningRoleValid(id);
			}
			return RoleDevelopUtil.GetHotRoleGachaId(id, true) != null;
		}

		// Token: 0x06027E96 RID: 163478 RVA: 0x00B27F78 File Offset: 0x00B26178
		private List<int> GetAllConfigRoleIdList()
		{
			List<int> list = new List<int>();
			IEnumerable<RoleInfo> roleList = RoleConfig.Instance.GetRoleList();
			RoleModel instance = RoleModel.Instance;
			foreach (RoleInfo roleInfo in roleList)
			{
				if (roleInfo.RoleType == 1)
				{
					int id = roleInfo.Id;
					if (instance.IsMainRole(id))
					{
						int? curSelectMainRoleId = instance.GetCurSelectMainRoleId();
						int num = id;
						if (!(curSelectMainRoleId.GetValueOrDefault() == num & curSelectMainRoleId != null))
						{
							continue;
						}
					}
					if (HandBookModel.Instance.GetRoleCanShowInHandBook(id) && !RoleDevelopUtil.IsRoleInProspectTime(id))
					{
						list.Add(id);
					}
				}
			}
			return list;
		}

		// Token: 0x06027E97 RID: 163479 RVA: 0x00B2802C File Offset: 0x00B2622C
		[NullableContext(2)]
		public RoleDevelopData GetRoleDevelopData(int id)
		{
			this.CreateAllRoleDevelopData();
			RoleDevelopData result;
			this.RoleDevelopDataMap.TryGetValue(id, out result);
			return result;
		}

		// Token: 0x06027E98 RID: 163480 RVA: 0x00B28050 File Offset: 0x00B26250
		private void CreateAllRoleDevelopData()
		{
			if (this.RoleDevelopDataMap.Count > 0)
			{
				return;
			}
			foreach (IRoleDevProsConfig roleDevProsConfig in RoleDevConfig.Instance.GetAllRoleDevProsListConfig())
			{
				int id = roleDevProsConfig.Id;
				if (!this.RoleDevelopDataMap.ContainsKey(id))
				{
					IRoleDevProsConfig roleDevProsListConfig = RoleDevConfig.Instance.GetRoleDevProsListConfig(id);
					if (roleDevProsListConfig != null && roleDevProsListConfig.TypeId != 4 && roleDevProsListConfig.TypeId != 0)
					{
						if (RoleDevelopUtil.IsProspectRole(id) && RoleDevConfig.Instance.GetRoleDevProsProjectConfig(id) == null)
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.RoleDev;
							ELogAuthor author = ELogAuthor.LJS;
							string message = "跨版本前瞻角色未配置RoleDevProsProject";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
							instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						}
						else if (roleDevProsListConfig.TypeId == 2 && RoleDevelopUtil.IsRoleInProspectTime(id) && RoleDevConfig.Instance.GetRoleDevProsProjectConfig(id) == null)
						{
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.RoleDev;
							ELogAuthor author2 = ELogAuthor.LJS;
							string message2 = "在前瞻时间内的当前版本前瞻角色未配置RoleDevProsProject";
							ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("id", id);
							instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						}
						else if (!RoleDevelopUtil.IsProspectRole(id) && RoleDevConfig.Instance.GetRoleDevProjectConfig(id) == null)
						{
							Log instance3 = Log.Instance;
							ELogModule module3 = ELogModule.RoleDev;
							ELogAuthor author3 = ELogAuthor.LJS;
							string message3 = "非前瞻的热门角色未配置RoleDevProject";
							ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("id", id);
							instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
						}
						else
						{
							this.CreateRoleDevelopData(roleDevProsConfig.Id);
						}
					}
				}
			}
			foreach (int num in this.GetAllConfigRoleIdList())
			{
				if (!this.RoleDevelopDataMap.ContainsKey(num))
				{
					if (RoleDevConfig.Instance.GetRoleDevProjectConfig(num) == null)
					{
						Log instance4 = Log.Instance;
						ELogModule module4 = ELogModule.RoleDev;
						ELogAuthor author4 = ELogAuthor.LJS;
						string message4 = "角色未配置RoleDevProject";
						ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("id", num);
						instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
					}
					else
					{
						this.CreateRoleDevelopData(num);
					}
				}
			}
		}

		// Token: 0x06027E99 RID: 163481 RVA: 0x00B282B0 File Offset: 0x00B264B0
		private RoleDevelopData CreateRoleDevelopData(int id)
		{
			RoleDevelopData roleDevelopData = new RoleDevelopData(id);
			this.RoleDevelopDataMap[id] = roleDevelopData;
			return roleDevelopData;
		}

		// Token: 0x06027E9A RID: 163482 RVA: 0x00B282D2 File Offset: 0x00B264D2
		public List<RoleDevelopData> GetAllRoleDevelopData()
		{
			this.CreateAllRoleDevelopData();
			return new List<RoleDevelopData>(this.RoleDevelopDataMap.Values);
		}

		// Token: 0x06027E9B RID: 163483 RVA: 0x00B282EC File Offset: 0x00B264EC
		public void UpdateTeamRecommendData(RepeatedField<TeamRecommendRole> teamRecommendList)
		{
			this.TeamRecommendMap.Clear();
			foreach (TeamRecommendRole teamRecommendRole in teamRecommendList)
			{
				List<RoleDevelopTeamRecommendInfo> list = new List<RoleDevelopTeamRecommendInfo>();
				foreach (TeamRecommendInfo teamRecommendInfo in teamRecommendRole.Teams)
				{
					List<RoleDevelopTeamRecommendTeammate> list2 = new List<RoleDevelopTeamRecommendTeammate>();
					foreach (TeamRecommendTeammate teamRecommendTeammate in teamRecommendInfo.Teammates)
					{
						List<RoleDevelopTeamRecommendRoleInfo> list3 = new List<RoleDevelopTeamRecommendRoleInfo>();
						foreach (TeamRecommendRoleInfo info in teamRecommendTeammate.Spares)
						{
							list3.Add(RoleDevelopModel.ConvertTeamRecommendRoleInfo(info));
						}
						list2.Add(new RoleDevelopTeamRecommendTeammate
						{
							Main = RoleDevelopModel.ConvertTeamRecommendRoleInfo(teamRecommendTeammate.Main),
							Spares = list3
						});
					}
					list.Add(new RoleDevelopTeamRecommendInfo
					{
						SkillBranchId = teamRecommendInfo.SkillBranchId,
						Teammates = list2
					});
				}
				this.TeamRecommendMap[teamRecommendRole.RoleId] = list;
			}
		}

		// Token: 0x06027E9C RID: 163484 RVA: 0x00B2849C File Offset: 0x00B2669C
		[NullableContext(2)]
		private static RoleDevelopTeamRecommendRoleInfo ConvertTeamRecommendRoleInfo(TeamRecommendRoleInfo info)
		{
			if (info == null)
			{
				return null;
			}
			return new RoleDevelopTeamRecommendRoleInfo
			{
				RoleId = info.RoleId,
				SkillBranchId = info.SkillBranchId
			};
		}

		// Token: 0x06027E9D RID: 163485 RVA: 0x00B284C0 File Offset: 0x00B266C0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RoleDevelopTeamRecommendInfo> GetTeamRecommendData(int roleId)
		{
			return this.TeamRecommendMap.GetValueOrDefault(roleId);
		}

		// Token: 0x06027E9E RID: 163486 RVA: 0x00B284D0 File Offset: 0x00B266D0
		public List<RoleDevelopData> GetAllHotRoleDevelopData(bool sort = false)
		{
			List<RoleDevelopData> allRoleDevelopData = this.GetAllRoleDevelopData();
			List<RoleDevelopData> list = new List<RoleDevelopData>();
			foreach (RoleDevelopData roleDevelopData in allRoleDevelopData)
			{
				if (RoleDevelopUtil.IsHotRole(roleDevelopData.GetId()) && this.IsShowInHotRoleList(roleDevelopData.GetId()))
				{
					list.Add(roleDevelopData);
				}
			}
			if (sort)
			{
				this.SortHotRoleDevelopData(list);
			}
			return list;
		}

		// Token: 0x06027E9F RID: 163487 RVA: 0x00B28550 File Offset: 0x00B26750
		private void SortHotRoleDevelopData(List<RoleDevelopData> dataList)
		{
			dataList.Sort(delegate(RoleDevelopData a, RoleDevelopData b)
			{
				IRoleDevProsConfig roleDevProsListConfig = RoleDevConfig.Instance.GetRoleDevProsListConfig(a.GetId());
				int num = (roleDevProsListConfig != null) ? roleDevProsListConfig.SortId : int.MaxValue;
				IRoleDevProsConfig roleDevProsListConfig2 = RoleDevConfig.Instance.GetRoleDevProsListConfig(b.GetId());
				int num2 = (roleDevProsListConfig2 != null) ? roleDevProsListConfig2.SortId : int.MaxValue;
				return num - num2;
			});
		}

		// Token: 0x06027EA0 RID: 163488 RVA: 0x00B28578 File Offset: 0x00B26778
		public List<RoleDevelopData> GetNormalRoleDevelopData()
		{
			List<RoleDevelopData> allRoleDevelopData = this.GetAllRoleDevelopData();
			List<RoleDevelopData> list = new List<RoleDevelopData>();
			foreach (RoleDevelopData roleDevelopData in allRoleDevelopData)
			{
				if (!RoleDevelopUtil.IsProspectRole(roleDevelopData.GetId()) && !RoleDevelopUtil.IsCurrentVersionProspectRoleInProspect(roleDevelopData.GetId()) && HandBookModel.Instance.GetRoleCanShowInHandBook(roleDevelopData.GetId()))
				{
					list.Add(roleDevelopData);
				}
			}
			return list;
		}

		// Token: 0x06027EA1 RID: 163489 RVA: 0x00B28600 File Offset: 0x00B26800
		public EItemRequirementState GetItemGroupRequirementState(RoleDevelopItemGroup itemGroup, [Nullable(2)] IReadOnlyDictionary<int, int> excludeCountMap = null)
		{
			List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
			if (itemGroup.Items != null)
			{
				foreach (RoleDevelopNeedItem roleDevelopNeedItem in itemGroup.Items)
				{
					if (!RoleDevelopUtil.IsUnknownItem(roleDevelopNeedItem.ItemId))
					{
						list.Add(roleDevelopNeedItem);
					}
				}
			}
			List<string> list2 = new List<string>();
			foreach (RoleDevelopNeedItem roleDevelopNeedItem2 in list)
			{
				List<string> list3 = list2;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(roleDevelopNeedItem2.ItemId);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted<int>(roleDevelopNeedItem2.Count);
				list3.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			if (list.Count == 0)
			{
				return EItemRequirementState.Satisfied;
			}
			InventoryModel instance = InventoryModel.Instance;
			ComposePopupModel instance2 = ComposePopupModel.Instance;
			RoleDevConfig instance3 = RoleDevConfig.Instance;
			CSharpScript.Game.Module.Item.ItemConfig instance4 = CSharpScript.Game.Module.Item.ItemConfig.Instance;
			List<RoleDevelopModel.ItemCalcInfo> list4 = new List<RoleDevelopModel.ItemCalcInfo>();
			Dictionary<int, RoleDevelopModel.ItemCalcInfo> dictionary = new Dictionary<int, RoleDevelopModel.ItemCalcInfo>();
			bool flag = true;
			foreach (RoleDevelopNeedItem roleDevelopNeedItem3 in list)
			{
				int num = Math.Max(0, instance.GetItemCountByConfigId(roleDevelopNeedItem3.ItemId, 0) - ((excludeCountMap != null) ? excludeCountMap.GetValueOrDefault(roleDevelopNeedItem3.ItemId, 0) : 0));
				if (num < roleDevelopNeedItem3.Count)
				{
					flag = false;
				}
				int maxGiftExchangeCount = instance2.GetMaxGiftExchangeCount(roleDevelopNeedItem3.ItemId, null);
				int num2 = num + maxGiftExchangeCount;
				int synthesisValue = instance3.GetItemJumpGroupConfig(roleDevelopNeedItem3.ItemId).Value.SynthesisValue;
				int qualityId = instance4.GetConfig(roleDevelopNeedItem3.ItemId).Value.QualityId;
				int num3 = Math.Max(0, roleDevelopNeedItem3.Count - num2);
				int num4 = Math.Max(0, num2 - roleDevelopNeedItem3.Count);
				RoleDevelopModel.ItemCalcInfo itemCalcInfo = new RoleDevelopModel.ItemCalcInfo
				{
					ItemId = roleDevelopNeedItem3.ItemId,
					QualityId = qualityId,
					Deficit = num3,
					NeededPoints = synthesisValue * num3,
					AvailablePoints = synthesisValue * num4
				};
				list4.Add(itemCalcInfo);
				dictionary[roleDevelopNeedItem3.ItemId] = itemCalcInfo;
			}
			if (flag)
			{
				return EItemRequirementState.Satisfied;
			}
			list4.Sort((RoleDevelopModel.ItemCalcInfo a, RoleDevelopModel.ItemCalcInfo b) => a.QualityId - b.QualityId);
			foreach (RoleDevelopModel.ItemCalcInfo itemCalcInfo2 in list4)
			{
				if (itemCalcInfo2.Deficit > 0)
				{
					if (itemCalcInfo2.NeededPoints <= 0)
					{
						return EItemRequirementState.NotSatisfied;
					}
					if (itemCalcInfo2.AvailablePoints >= itemCalcInfo2.NeededPoints)
					{
						itemCalcInfo2.AvailablePoints -= itemCalcInfo2.NeededPoints;
					}
					else if (!RoleDevelopModel.TrySupplementFromMaterials(itemCalcInfo2, dictionary, excludeCountMap))
					{
						return EItemRequirementState.NotSatisfied;
					}
				}
			}
			return EItemRequirementState.Supplement;
		}

		// Token: 0x06027EA2 RID: 163490 RVA: 0x00B28954 File Offset: 0x00B26B54
		private static bool TrySupplementFromMaterials(RoleDevelopModel.ItemCalcInfo calcItem, Dictionary<int, RoleDevelopModel.ItemCalcInfo> itemCalcMap, [Nullable(2)] IReadOnlyDictionary<int, int> excludeCountMap = null)
		{
			int num = calcItem.NeededPoints - calcItem.AvailablePoints;
			if (num <= 0)
			{
				return true;
			}
			HashSet<int> visited = new HashSet<int>
			{
				calcItem.ItemId
			};
			num = RoleDevelopModel.ConsumeFromSynthesisTree(num, calcItem.ItemId, itemCalcMap, visited, excludeCountMap);
			calcItem.AvailablePoints = 0;
			return num <= 0;
		}

		// Token: 0x06027EA3 RID: 163491 RVA: 0x00B289A8 File Offset: 0x00B26BA8
		private static int ConsumeFromSynthesisTree(int needed, int itemId, Dictionary<int, RoleDevelopModel.ItemCalcInfo> itemCalcMap, HashSet<int> visited, [Nullable(2)] IReadOnlyDictionary<int, int> excludeCountMap = null)
		{
			ComposePopupModel instance = ComposePopupModel.Instance;
			List<IComposeItemData> composeMaterialList = instance.GetComposeMaterialList(itemId);
			if (composeMaterialList == null || composeMaterialList.Count == 0)
			{
				return needed;
			}
			InventoryModel instance2 = InventoryModel.Instance;
			RoleDevConfig instance3 = RoleDevConfig.Instance;
			CSharpScript.Game.Module.Item.ItemConfig instance4 = CSharpScript.Game.Module.Item.ItemConfig.Instance;
			int num = needed;
			foreach (IComposeItemData composeItemData in composeMaterialList)
			{
				if (num <= 0)
				{
					break;
				}
				if (!visited.Contains(composeItemData.ItemId))
				{
					visited.Add(composeItemData.ItemId);
					RoleDevelopModel.ItemCalcInfo itemCalcInfo;
					if (!itemCalcMap.TryGetValue(composeItemData.ItemId, out itemCalcInfo))
					{
						RoleDevItemJumpGroup? itemJumpGroupConfig = instance3.GetItemJumpGroupConfig(composeItemData.ItemId);
						if (itemJumpGroupConfig == null)
						{
							continue;
						}
						int num2 = Math.Max(0, instance2.GetItemCountByConfigId(composeItemData.ItemId, 0) - ((excludeCountMap != null) ? excludeCountMap.GetValueOrDefault(composeItemData.ItemId, 0) : 0));
						int maxGiftExchangeCount = instance.GetMaxGiftExchangeCount(composeItemData.ItemId, null);
						int num3 = num2 + maxGiftExchangeCount;
						int synthesisValue = itemJumpGroupConfig.Value.SynthesisValue;
						ItemInfo? itemInfo;
						int qualityId = (instance4.GetConfig(composeItemData.ItemId) != null) ? itemInfo.GetValueOrDefault().QualityId : 0;
						itemCalcInfo = new RoleDevelopModel.ItemCalcInfo
						{
							ItemId = composeItemData.ItemId,
							QualityId = qualityId,
							Deficit = 0,
							NeededPoints = 0,
							AvailablePoints = synthesisValue * num3
						};
						itemCalcMap[composeItemData.ItemId] = itemCalcInfo;
					}
					int num4 = Math.Min(itemCalcInfo.AvailablePoints, num);
					itemCalcInfo.AvailablePoints -= num4;
					num -= num4;
					if (num > 0)
					{
						num = RoleDevelopModel.ConsumeFromSynthesisTree(num, composeItemData.ItemId, itemCalcMap, visited, excludeCountMap);
					}
				}
			}
			return num;
		}

		// Token: 0x06027EA4 RID: 163492 RVA: 0x00B28B94 File Offset: 0x00B26D94
		public bool IsItemGroupCanBeSupplemented(RoleDevelopItemGroup itemGroup)
		{
			return this.GetItemGroupRequirementState(itemGroup, null) == EItemRequirementState.Supplement;
		}

		// Token: 0x06027EA5 RID: 163493 RVA: 0x00B28BA4 File Offset: 0x00B26DA4
		public EItemRequirementState GetItemRequirementState(int itemId, int needCount)
		{
			if (RoleDevelopUtil.IsUnknownItem(itemId))
			{
				return EItemRequirementState.Satisfied;
			}
			InventoryModel instance = InventoryModel.Instance;
			ComposePopupModel instance2 = ComposePopupModel.Instance;
			RoleDevConfig instance3 = RoleDevConfig.Instance;
			int itemCountByConfigId = instance.GetItemCountByConfigId(itemId, 0);
			if (itemCountByConfigId >= needCount)
			{
				return EItemRequirementState.Satisfied;
			}
			int maxGiftExchangeCount = instance2.GetMaxGiftExchangeCount(itemId, null);
			if (itemCountByConfigId + maxGiftExchangeCount >= needCount)
			{
				return EItemRequirementState.Supplement;
			}
			RoleDevItemJumpGroup? itemJumpGroupConfig = instance3.GetItemJumpGroupConfig(itemId);
			if (itemJumpGroupConfig == null || itemJumpGroupConfig.Value.SynthesisValue <= 0)
			{
				return EItemRequirementState.NotSatisfied;
			}
			int num = needCount - itemCountByConfigId - maxGiftExchangeCount;
			int neededPoints = itemJumpGroupConfig.Value.SynthesisValue * num;
			HashSet<int> visited = new HashSet<int>
			{
				itemId
			};
			if (this.BorrowSynthesisPointsFromMaterials(itemId, neededPoints, visited) > 0)
			{
				return EItemRequirementState.NotSatisfied;
			}
			return EItemRequirementState.Supplement;
		}

		// Token: 0x06027EA6 RID: 163494 RVA: 0x00B28C50 File Offset: 0x00B26E50
		private int BorrowSynthesisPointsFromMaterials(int parentId, int neededPoints, HashSet<int> visited)
		{
			ComposePopupModel instance = ComposePopupModel.Instance;
			InventoryModel instance2 = InventoryModel.Instance;
			RoleDevConfig instance3 = RoleDevConfig.Instance;
			List<IComposeItemData> composeMaterialList = instance.GetComposeMaterialList(parentId);
			if (composeMaterialList == null || composeMaterialList.Count == 0)
			{
				return neededPoints;
			}
			int num = neededPoints;
			foreach (IComposeItemData composeItemData in composeMaterialList)
			{
				if (num <= 0)
				{
					break;
				}
				if (!visited.Contains(composeItemData.ItemId))
				{
					visited.Add(composeItemData.ItemId);
					RoleDevItemJumpGroup? itemJumpGroupConfig = instance3.GetItemJumpGroupConfig(composeItemData.ItemId);
					if (itemJumpGroupConfig != null && itemJumpGroupConfig.Value.SynthesisValue > 0)
					{
						int itemCountByConfigId = instance2.GetItemCountByConfigId(composeItemData.ItemId, 0);
						int maxGiftExchangeCount = instance.GetMaxGiftExchangeCount(composeItemData.ItemId, null);
						int developRoleNeedItemCount = this.GetDevelopRoleNeedItemCount(composeItemData.ItemId);
						int num2 = Math.Min(Math.Max(0, itemCountByConfigId + maxGiftExchangeCount - developRoleNeedItemCount) * itemJumpGroupConfig.Value.SynthesisValue, num);
						num -= num2;
						if (num > 0)
						{
							num = this.BorrowSynthesisPointsFromMaterials(composeItemData.ItemId, num, visited);
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06027EA7 RID: 163495 RVA: 0x00B28D98 File Offset: 0x00B26F98
		public bool IsItemCanBeSupplemented(int itemId, int needCount)
		{
			return this.GetItemRequirementState(itemId, needCount) == EItemRequirementState.Supplement;
		}

		// Token: 0x06027EA8 RID: 163496 RVA: 0x00B28DA8 File Offset: 0x00B26FA8
		public int GetItemComposeChainSupplyCount(int itemId)
		{
			RoleDevConfig instance = RoleDevConfig.Instance;
			RoleDevItemJumpGroup? itemJumpGroupConfig = instance.GetItemJumpGroupConfig(itemId);
			if (itemJumpGroupConfig == null || itemJumpGroupConfig.Value.SynthesisValue <= 0)
			{
				return 0;
			}
			ComposePopupModel instance2 = ComposePopupModel.Instance;
			InventoryModel instance3 = InventoryModel.Instance;
			HashSet<int> visited = new HashSet<int>
			{
				itemId
			};
			long num = 0L;
			this.AccumulateComposeChainPoints(itemId, visited, instance, instance2, instance3, ref num);
			return (int)(num / (long)itemJumpGroupConfig.Value.SynthesisValue);
		}

		// Token: 0x06027EA9 RID: 163497 RVA: 0x00B28E24 File Offset: 0x00B27024
		private void AccumulateComposeChainPoints(int currentItemId, HashSet<int> visited, RoleDevConfig roleDevConfig, ComposePopupModel composePopupModel, InventoryModel inventoryModel, ref long totalAvailablePoints)
		{
			List<IComposeItemData> composeMaterialList = composePopupModel.GetComposeMaterialList(currentItemId);
			if (composeMaterialList == null || composeMaterialList.Count == 0)
			{
				return;
			}
			foreach (IComposeItemData composeItemData in composeMaterialList)
			{
				if (!visited.Contains(composeItemData.ItemId))
				{
					visited.Add(composeItemData.ItemId);
					RoleDevItemJumpGroup? itemJumpGroupConfig = roleDevConfig.GetItemJumpGroupConfig(composeItemData.ItemId);
					if (itemJumpGroupConfig != null)
					{
						int itemCountByConfigId = inventoryModel.GetItemCountByConfigId(composeItemData.ItemId, 0);
						int maxGiftExchangeCount = composePopupModel.GetMaxGiftExchangeCount(composeItemData.ItemId, null);
						totalAvailablePoints += (long)itemJumpGroupConfig.Value.SynthesisValue * (long)(itemCountByConfigId + maxGiftExchangeCount);
						this.AccumulateComposeChainPoints(composeItemData.ItemId, visited, roleDevConfig, composePopupModel, inventoryModel, ref totalAvailablePoints);
					}
				}
			}
		}

		// Token: 0x06027EAA RID: 163498 RVA: 0x00B28F0C File Offset: 0x00B2710C
		public bool IsDevelopRoleNeedItem(int itemId)
		{
			return this.GetNeedItemCache().ContainsKey(itemId);
		}

		// Token: 0x06027EAB RID: 163499 RVA: 0x00B28F1A File Offset: 0x00B2711A
		public bool IsDevelopRoleNeedItemCanBeSupplemented(int itemId)
		{
			return this.IsDevelopRoleNeedItem(itemId) && this.IsItemCanBeSupplemented(itemId, this.GetDevelopRoleNeedItemCount(itemId));
		}

		// Token: 0x06027EAC RID: 163500 RVA: 0x00B28F38 File Offset: 0x00B27138
		public EItemRequirementState GetItemBelongingGroupRequirementState(int itemId)
		{
			RoleDevelopItemGroup roleDevelopItemGroup = this.BuildNeedItemGroupByItemId(itemId);
			if (roleDevelopItemGroup == null)
			{
				return EItemRequirementState.Satisfied;
			}
			return this.GetItemGroupRequirementState(roleDevelopItemGroup, null);
		}

		// Token: 0x06027EAD RID: 163501 RVA: 0x00B28F5A File Offset: 0x00B2715A
		public bool IsItemBelongingGroupCanBeSupplemented(int itemId)
		{
			return this.GetItemBelongingGroupRequirementState(itemId) == EItemRequirementState.Supplement;
		}

		// Token: 0x06027EAE RID: 163502 RVA: 0x00B28F68 File Offset: 0x00B27168
		[NullableContext(2)]
		private RoleDevelopItemGroup BuildNeedItemGroupByItemId(int itemId)
		{
			RoleDevItemJumpGroup? itemJumpGroupConfig = RoleDevConfig.Instance.GetItemJumpGroupConfig(itemId);
			if (itemJumpGroupConfig == null)
			{
				return null;
			}
			EItemMaterialType itemType = (EItemMaterialType)itemJumpGroupConfig.Value.ItemType;
			RoleDevelopItemGroup roleDevelopItemGroup;
			if (!this.GetNeedItemGroupByTypeCache().TryGetValue(itemType, out roleDevelopItemGroup))
			{
				return null;
			}
			int subGroup = itemJumpGroupConfig.Value.SubGroup;
			List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
			foreach (RoleDevelopNeedItem roleDevelopNeedItem in roleDevelopItemGroup.Items)
			{
				RoleDevItemJumpGroup? itemJumpGroupConfig2 = RoleDevConfig.Instance.GetItemJumpGroupConfig(roleDevelopNeedItem.ItemId);
				if (itemJumpGroupConfig2 != null && itemJumpGroupConfig2.Value.SubGroup == subGroup)
				{
					list.Add(roleDevelopNeedItem);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			return new RoleDevelopItemGroup
			{
				Type = itemType,
				Items = list
			};
		}

		// Token: 0x06027EAF RID: 163503 RVA: 0x00B29060 File Offset: 0x00B27260
		private Dictionary<EItemMaterialType, RoleDevelopItemGroup> GetNeedItemGroupByTypeCache()
		{
			if (this.NeedItemGroupByTypeCache == null)
			{
				this.NeedItemGroupByTypeCache = this.BuildNeedItemGroupByTypeMap();
			}
			return this.NeedItemGroupByTypeCache;
		}

		// Token: 0x06027EB0 RID: 163504 RVA: 0x00B2907C File Offset: 0x00B2727C
		private Dictionary<EItemMaterialType, RoleDevelopItemGroup> BuildNeedItemGroupByTypeMap()
		{
			Dictionary<EItemMaterialType, RoleDevelopItemGroup> dictionary = new Dictionary<EItemMaterialType, RoleDevelopItemGroup>();
			foreach (KeyValuePair<int, int> keyValuePair in this.GetNeedItemCache())
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (value > 0)
				{
					RoleDevItemJumpGroup? itemJumpGroupConfig = RoleDevConfig.Instance.GetItemJumpGroupConfig(key);
					if (itemJumpGroupConfig != null)
					{
						EItemMaterialType itemType = (EItemMaterialType)itemJumpGroupConfig.Value.ItemType;
						RoleDevelopItemGroup roleDevelopItemGroup;
						if (!dictionary.TryGetValue(itemType, out roleDevelopItemGroup))
						{
							roleDevelopItemGroup = new RoleDevelopItemGroup
							{
								Type = itemType,
								Items = new List<RoleDevelopNeedItem>()
							};
							dictionary[itemType] = roleDevelopItemGroup;
						}
						roleDevelopItemGroup.Items.Add(new RoleDevelopNeedItem
						{
							ItemId = key,
							Count = value
						});
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06027EB1 RID: 163505 RVA: 0x00B29164 File Offset: 0x00B27364
		public int GetDevelopRoleNeedItemCount(int itemId)
		{
			int result;
			this.GetNeedItemCache().TryGetValue(itemId, out result);
			return result;
		}

		// Token: 0x06027EB2 RID: 163506 RVA: 0x00B29184 File Offset: 0x00B27384
		public List<RoleDevelopNeedItem> GetAllDevelopRoleNeedItems()
		{
			List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
			foreach (KeyValuePair<int, int> keyValuePair in this.GetNeedItemCache())
			{
				list.Add(new RoleDevelopNeedItem
				{
					ItemId = keyValuePair.Key,
					Count = keyValuePair.Value
				});
			}
			return list;
		}

		// Token: 0x06027EB3 RID: 163507 RVA: 0x00B291FC File Offset: 0x00B273FC
		public List<RoleDevelopItemGroup> GetAllDevelopRoleNeedItemGroups()
		{
			return RoleDevelopUtil.BuildGroupItemDataByNeedItems(this.GetAllDevelopRoleNeedItems(), false, true, false);
		}

		// Token: 0x06027EB4 RID: 163508 RVA: 0x00B2920C File Offset: 0x00B2740C
		public EItemMaterialType? GetDevelopRoleItemMaterialType(int itemId)
		{
			RoleDevItemJumpGroup? itemJumpGroupConfig = RoleDevConfig.Instance.GetItemJumpGroupConfig(itemId);
			if (itemJumpGroupConfig == null)
			{
				return null;
			}
			return new EItemMaterialType?((EItemMaterialType)itemJumpGroupConfig.Value.ItemType);
		}

		// Token: 0x06027EB5 RID: 163509 RVA: 0x00B2924C File Offset: 0x00B2744C
		public RoleDevelopSettlementJumpData CheckSettlementQuickJumpData(IReadOnlyList<RoleDevelopSettlementRewardItem> rewardItems, ERoleDevelopSettlementSourceDungeonType sourceDungeonType)
		{
			RoleDevelopSettlementJumpData roleDevelopSettlementJumpData = this.CreateEmptySettlementJumpData(sourceDungeonType);
			if (this.DevTargetRoleIdInternal == 0 || sourceDungeonType == ERoleDevelopSettlementSourceDungeonType.None || rewardItems.Count <= 0)
			{
				return roleDevelopSettlementJumpData;
			}
			string developRoleIconPath = this.GetDevelopRoleIconPath();
			if (string.IsNullOrEmpty(developRoleIconPath))
			{
				return roleDevelopSettlementJumpData;
			}
			roleDevelopSettlementJumpData.RoleId = this.DevTargetRoleIdInternal;
			roleDevelopSettlementJumpData.RoleIconPath = developRoleIconPath;
			foreach (RoleDevelopSettlementRewardItem roleDevelopSettlementRewardItem in rewardItems)
			{
				if (roleDevelopSettlementRewardItem != null && roleDevelopSettlementRewardItem.ItemId > 0 && roleDevelopSettlementRewardItem.Count > 0 && this.IsDevelopRoleNeedItem(roleDevelopSettlementRewardItem.ItemId))
				{
					roleDevelopSettlementJumpData.MatchedItemIds.Add(roleDevelopSettlementRewardItem.ItemId);
					EItemMaterialType? developRoleItemMaterialType = this.GetDevelopRoleItemMaterialType(roleDevelopSettlementRewardItem.ItemId);
					if (developRoleItemMaterialType != null && developRoleItemMaterialType.GetValueOrDefault() != EItemMaterialType.Drop && ((developRoleItemMaterialType.GetValueOrDefault() != EItemMaterialType.RoleExp && developRoleItemMaterialType.GetValueOrDefault() != EItemMaterialType.WeaponExp) || sourceDungeonType == ERoleDevelopSettlementSourceDungeonType.Simulation))
					{
						roleDevelopSettlementJumpData.NeedCheckItemIds.Add(roleDevelopSettlementRewardItem.ItemId);
						int developRoleNeedItemCount = this.GetDevelopRoleNeedItemCount(roleDevelopSettlementRewardItem.ItemId);
						if (InventoryModel.Instance.GetItemCountByConfigId(roleDevelopSettlementRewardItem.ItemId, 0) + roleDevelopSettlementRewardItem.Count < developRoleNeedItemCount)
						{
							int needCount = Math.Max(0, developRoleNeedItemCount - roleDevelopSettlementRewardItem.Count);
							if (!this.IsItemCanBeSupplemented(roleDevelopSettlementRewardItem.ItemId, needCount))
							{
								return this.CreateEmptySettlementJumpData(sourceDungeonType);
							}
						}
					}
				}
			}
			roleDevelopSettlementJumpData.CanShow = (roleDevelopSettlementJumpData.MatchedItemIds.Count > 0);
			return roleDevelopSettlementJumpData;
		}

		// Token: 0x06027EB6 RID: 163510 RVA: 0x00B293D0 File Offset: 0x00B275D0
		public int GetDevelopRoleHaveItemCount(int itemId)
		{
			return InventoryModel.Instance.GetItemCountByConfigId(itemId, 0);
		}

		// Token: 0x06027EB7 RID: 163511 RVA: 0x00B293DE File Offset: 0x00B275DE
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"HaveCount",
			"NeedCount"
		})]
		public ValueTuple<int, int> GetDevelopRoleHaveAndNeedCount(int itemId)
		{
			return new ValueTuple<int, int>(this.GetDevelopRoleHaveItemCount(itemId), this.GetDevelopRoleNeedItemCount(itemId));
		}

		// Token: 0x06027EB8 RID: 163512 RVA: 0x00B293F4 File Offset: 0x00B275F4
		public string GetDevelopRoleIconPath()
		{
			if (this.DevTargetRoleIdInternal == 0)
			{
				return "";
			}
			RoleDevelopData roleDevelopData = this.GetRoleDevelopData(this.DevTargetRoleIdInternal);
			if (roleDevelopData == null)
			{
				return "";
			}
			return roleDevelopData.GetDevelopRoleData().GetRoleIconPath();
		}

		// Token: 0x06027EB9 RID: 163513 RVA: 0x00B29430 File Offset: 0x00B27630
		public string GetDevelopRoleSmallIconPath()
		{
			if (this.DevTargetRoleIdInternal == 0)
			{
				return "";
			}
			RoleDevelopData roleDevelopData = this.GetRoleDevelopData(this.DevTargetRoleIdInternal);
			if (roleDevelopData == null)
			{
				return "";
			}
			return roleDevelopData.GetDevelopRoleData().GetRoleSmallIconPath();
		}

		// Token: 0x06027EBA RID: 163514 RVA: 0x00B2946C File Offset: 0x00B2766C
		public string GetDevelopRoleCircleIconPath()
		{
			if (this.DevTargetRoleIdInternal == 0)
			{
				return "";
			}
			RoleDevelopData roleDevelopData = this.GetRoleDevelopData(this.DevTargetRoleIdInternal);
			if (roleDevelopData == null)
			{
				return "";
			}
			return roleDevelopData.GetDevelopRoleData().GetRoleCircleIconPath();
		}

		// Token: 0x06027EBB RID: 163515 RVA: 0x00B294A8 File Offset: 0x00B276A8
		public EItemRequirementState GetRoleExpItemRequirementState()
		{
			RoleDevelopData roleDevelopData = this.GetRoleDevelopData(this.DevTargetRoleIdInternal);
			if (roleDevelopData == null)
			{
				return EItemRequirementState.NotSatisfied;
			}
			int roleUpgradeExp = roleDevelopData.GetProjectData().GetRoleUpgradeExp();
			if (roleUpgradeExp <= 0)
			{
				return EItemRequirementState.Satisfied;
			}
			RoleModel instance = RoleModel.Instance;
			InventoryModel instance2 = InventoryModel.Instance;
			ComposePopupModel instance3 = ComposePopupModel.Instance;
			ItemInfo[] roleCostExpList = instance.GetRoleCostExpList();
			int num = 0;
			int num2 = 0;
			foreach (ItemInfo itemInfo in roleCostExpList)
			{
				int valueOrDefault = instance.GetRoleExpItemExp(itemInfo.Id).GetValueOrDefault();
				num += valueOrDefault * instance2.GetCommonItemCount(itemInfo.Id, 0);
				num2 += valueOrDefault * instance3.GetMaxGiftExchangeCount(itemInfo.Id, null);
			}
			if (num >= roleUpgradeExp)
			{
				return EItemRequirementState.Satisfied;
			}
			if (num + num2 >= roleUpgradeExp)
			{
				return EItemRequirementState.Supplement;
			}
			return EItemRequirementState.NotSatisfied;
		}

		// Token: 0x06027EBC RID: 163516 RVA: 0x00B29570 File Offset: 0x00B27770
		public EItemRequirementState GetWeaponExpItemRequirementState()
		{
			RoleDevelopData roleDevelopData = this.GetRoleDevelopData(this.DevTargetRoleIdInternal);
			if (roleDevelopData == null)
			{
				return EItemRequirementState.NotSatisfied;
			}
			int weaponUpgradeExp = roleDevelopData.GetProjectData().GetWeaponUpgradeExp();
			if (weaponUpgradeExp <= 0)
			{
				return EItemRequirementState.Satisfied;
			}
			InventoryModel instance = InventoryModel.Instance;
			ComposePopupModel instance2 = ComposePopupModel.Instance;
			WeaponModel instance3 = WeaponModel.Instance;
			List<ItemInfo> weaponExpItemConfigList = instance3.GetWeaponExpItemConfigList();
			int num = 0;
			int num2 = 0;
			foreach (ItemInfo itemInfo in weaponExpItemConfigList)
			{
				int weaponItemExp = instance3.GetWeaponItemExp(0, itemInfo.Id);
				num += weaponItemExp * instance.GetCommonItemCount(itemInfo.Id, 0);
				num2 += weaponItemExp * instance2.GetMaxGiftExchangeCount(itemInfo.Id, null);
			}
			if (num >= weaponUpgradeExp)
			{
				return EItemRequirementState.Satisfied;
			}
			if (num + num2 >= weaponUpgradeExp)
			{
				return EItemRequirementState.Supplement;
			}
			return EItemRequirementState.NotSatisfied;
		}

		// Token: 0x06027EBD RID: 163517 RVA: 0x00B2964C File Offset: 0x00B2784C
		public EItemRequirementState GetExpItemRequirementState(int itemId)
		{
			foreach (ItemInfo itemInfo in RoleModel.Instance.GetRoleCostExpList())
			{
				if (itemInfo.Id == itemId)
				{
					return this.GetRoleExpItemRequirementState();
				}
			}
			foreach (ItemInfo itemInfo2 in WeaponModel.Instance.GetWeaponExpItemConfigList())
			{
				if (itemInfo2.Id == itemId)
				{
					return this.GetWeaponExpItemRequirementState();
				}
			}
			return EItemRequirementState.NotSatisfied;
		}

		// Token: 0x06027EBE RID: 163518 RVA: 0x00B296E8 File Offset: 0x00B278E8
		public void InvalidateNeedItemCache()
		{
			this.NeedItemCache = null;
			this.NeedItemChainItemSet = null;
			this.NeedItemGroupByTypeCache = null;
			this.DeficitDetectionIdSetCache = null;
			this.ClearWorldDropTip();
			EventSystem.Instance.Emit(EEventName.RoleDevelopNeedItemsChanged);
		}

		// Token: 0x06027EBF RID: 163519 RVA: 0x00B2971C File Offset: 0x00B2791C
		private void OnCommonItemCountAnyChange(int configId, int count)
		{
			if (this.DevTargetRoleIdInternal != 0 && this.GetNeedItemChainItemSet().Contains(configId))
			{
				this.InvalidateNeedItemCache();
			}
			if (this.DevTargetRoleIdInternal != 0 && (this.IsDevelopRoleNeedItem(configId) || this.GetNeedItemChainItemSet().Contains(configId)))
			{
				this.DeficitDetectionIdSetCache = null;
			}
			if (!this.WorldDropTipShownItemIds.Contains(configId))
			{
				return;
			}
			if (this.DevTargetRoleIdInternal == 0)
			{
				return;
			}
			if (!this.IsDevelopRoleNeedItem(configId))
			{
				return;
			}
			int developRoleNeedItemCount = this.GetDevelopRoleNeedItemCount(configId);
			if (count < developRoleNeedItemCount)
			{
				this.WorldDropTipShownItemIds.Remove(configId);
				return;
			}
			RoleDevelopItemGroup roleDevelopItemGroup = this.BuildNeedItemGroupByItemId(configId);
			if (roleDevelopItemGroup == null)
			{
				return;
			}
			EItemRequirementState itemGroupRequirementState = this.GetItemGroupRequirementState(roleDevelopItemGroup, null);
			if (itemGroupRequirementState != EItemRequirementState.Satisfied && itemGroupRequirementState != EItemRequirementState.Supplement)
			{
				this.WorldDropTipShownItemIds.Remove(configId);
			}
		}

		// Token: 0x06027EC0 RID: 163520 RVA: 0x00B297D8 File Offset: 0x00B279D8
		private void OnItemRewardNotify(ItemRewardNotify notify)
		{
			if (notify == null || this.DevTargetRoleIdInternal == 0)
			{
				return;
			}
			Dictionary<int, int> dictionary = this.AggregateRewardItemCounts(notify);
			if (dictionary.Count <= 0)
			{
				return;
			}
			RoleDevConfig instance = RoleDevConfig.Instance;
			if (instance == null)
			{
				return;
			}
			Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
			int? num = null;
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (this.IsDevelopRoleNeedItem(key))
				{
					RoleDevItemJumpGroup? itemJumpGroupConfig = instance.GetItemJumpGroupConfig(key);
					if (itemJumpGroupConfig != null)
					{
						EItemMaterialType itemType = (EItemMaterialType)itemJumpGroupConfig.Value.ItemType;
						if (itemType == EItemMaterialType.Map || itemType == EItemMaterialType.Drop)
						{
							dictionary2[key] = value;
							if (num == null)
							{
								num = new int?(key);
							}
						}
					}
				}
			}
			if (num != null)
			{
				this.HandleDropTypeReward(num.Value, dictionary2);
			}
		}

		// Token: 0x06027EC1 RID: 163521 RVA: 0x00B298D4 File Offset: 0x00B27AD4
		private Dictionary<int, int> AggregateRewardItemCounts(ItemRewardNotify notify)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			MapField<int, RewardItemInfoList> rewardItems = notify.RewardItems;
			if (rewardItems == null)
			{
				return dictionary;
			}
			foreach (int key in rewardItems.Keys)
			{
				RewardItemInfoList rewardItemInfoList;
				if (rewardItems.TryGetValue(key, out rewardItemInfoList) && rewardItemInfoList != null)
				{
					RepeatedField<RewardItemInfo> itemList = rewardItemInfoList.ItemList;
					if (itemList != null)
					{
						foreach (RewardItemInfo rewardItemInfo in itemList)
						{
							int itemId = rewardItemInfo.ItemId;
							int count = rewardItemInfo.Count;
							if (itemId > 0 && count > 0)
							{
								dictionary[itemId] = dictionary.GetValueOrDefault(itemId, 0) + count;
							}
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06027EC2 RID: 163522 RVA: 0x00B299B0 File Offset: 0x00B27BB0
		private void HandleDropTypeReward(int representativeItemId, Dictionary<int, int> dropExcludeMap)
		{
			RoleDevelopItemGroup roleDevelopItemGroup = this.BuildNeedItemGroupByItemId(representativeItemId);
			if (roleDevelopItemGroup == null)
			{
				return;
			}
			EItemRequirementState itemGroupRequirementState = this.GetItemGroupRequirementState(roleDevelopItemGroup, dropExcludeMap);
			EItemRequirementState itemGroupRequirementState2 = this.GetItemGroupRequirementState(roleDevelopItemGroup, null);
			if (!RoleDevelopModel.<HandleDropTypeReward>g__Enough|83_0(itemGroupRequirementState) && RoleDevelopModel.<HandleDropTypeReward>g__Enough|83_0(itemGroupRequirementState2))
			{
				this.ShowDropEnoughTip(representativeItemId);
			}
		}

		// Token: 0x06027EC3 RID: 163523 RVA: 0x00B299F0 File Offset: 0x00B27BF0
		private void ShowDropEnoughTip(int itemId)
		{
			int? dropPromptDisplayItemId = this.GetDropPromptDisplayItemId(itemId);
			if (dropPromptDisplayItemId != null)
			{
				RoleDevelopWorldDropEnoughTipsController.TryShow(itemId, dropPromptDisplayItemId.Value);
			}
		}

		// Token: 0x06027EC4 RID: 163524 RVA: 0x00B29A1C File Offset: 0x00B27C1C
		private int? GetDropPromptDisplayItemId(int itemId)
		{
			ComposePopupModel instance = ComposePopupModel.Instance;
			CSharpScript.Game.Module.Item.ItemConfig instance2 = CSharpScript.Game.Module.Item.ItemConfig.Instance;
			HashSet<int> hashSet = new HashSet<int>
			{
				itemId
			};
			Queue<int> queue = new Queue<int>(4);
			queue.Push(itemId);
			while (queue.Size > 0)
			{
				int itemId2 = queue.Pop();
				List<IComposeItemData> composeMaterialList = instance.GetComposeMaterialList(itemId2);
				if (composeMaterialList != null && composeMaterialList.Count != 0)
				{
					foreach (IComposeItemData composeItemData in composeMaterialList)
					{
						int itemId3 = composeItemData.ItemId;
						if (itemId3 != 0 && !hashSet.Contains(itemId3))
						{
							hashSet.Add(itemId3);
							queue.Push(itemId3);
						}
					}
				}
			}
			if (hashSet.Count < 2)
			{
				return new int?(itemId);
			}
			InventoryDefine.EQuality equality = (WorldLevelModel.Instance.OriginWorldLevel > 5) ? InventoryDefine.EQuality.Orange : InventoryDefine.EQuality.Purple;
			foreach (int num in hashSet)
			{
				ItemInfo? itemInfo;
				if (((instance2.GetConfig(num) != null) ? itemInfo.GetValueOrDefault().QualityId : 0) == (int)equality)
				{
					return new int?(num);
				}
			}
			return new int?(itemId);
		}

		// Token: 0x06027EC5 RID: 163525 RVA: 0x00B29B78 File Offset: 0x00B27D78
		public bool EnqueueWorldDropTip(int itemId, int displayItemId)
		{
			if (this.WorldDropTipShownItemIds.Contains(itemId))
			{
				return false;
			}
			this.WorldDropTipShownItemIds.Add(itemId);
			this.WorldDropTipQueue.Add(new RoleDevelopWorldDropTipEntry
			{
				ItemId = itemId,
				DisplayItemId = displayItemId
			});
			return true;
		}

		// Token: 0x06027EC6 RID: 163526 RVA: 0x00B29BB8 File Offset: 0x00B27DB8
		public bool AdvanceWorldDropTipToNext()
		{
			if (this.WorldDropTipQueue.Count <= 0)
			{
				this.WorldDropTipCurrentEntry = null;
				this.IsWorldDropTipShowing = false;
				return false;
			}
			this.WorldDropTipCurrentEntry = this.WorldDropTipQueue[0];
			this.WorldDropTipQueue.RemoveAt(0);
			this.IsWorldDropTipShowing = true;
			return true;
		}

		// Token: 0x06027EC7 RID: 163527 RVA: 0x00B29C09 File Offset: 0x00B27E09
		[NullableContext(2)]
		public RoleDevelopWorldDropTipEntry GetWorldDropTipCurrentEntry()
		{
			return this.WorldDropTipCurrentEntry;
		}

		// Token: 0x06027EC8 RID: 163528 RVA: 0x00B29C11 File Offset: 0x00B27E11
		public bool HasPendingWorldDropTip()
		{
			return this.WorldDropTipQueue.Count > 0;
		}

		// Token: 0x06027EC9 RID: 163529 RVA: 0x00B29C21 File Offset: 0x00B27E21
		public void ClearWorldDropTip()
		{
			this.WorldDropTipQueue.Clear();
			this.WorldDropTipShownItemIds.Clear();
			this.WorldDropTipCurrentEntry = null;
			this.IsWorldDropTipShowing = false;
		}

		// Token: 0x06027ECA RID: 163530 RVA: 0x00B29C47 File Offset: 0x00B27E47
		private Dictionary<int, int> GetNeedItemCache()
		{
			if (this.NeedItemCache == null)
			{
				this.BuildNeedItemCaches();
			}
			return this.NeedItemCache;
		}

		// Token: 0x06027ECB RID: 163531 RVA: 0x00B29C5D File Offset: 0x00B27E5D
		public HashSet<int> GetNeedItemChainItemSet()
		{
			if (this.NeedItemChainItemSet == null)
			{
				this.BuildNeedItemCaches();
			}
			return this.NeedItemChainItemSet;
		}

		// Token: 0x06027ECC RID: 163532 RVA: 0x00B29C74 File Offset: 0x00B27E74
		private Dictionary<EItemMaterialType, List<int>> GetItemIdsByMaterialType()
		{
			if (this.ItemIdsByMaterialTypeCache != null)
			{
				return this.ItemIdsByMaterialTypeCache;
			}
			Dictionary<EItemMaterialType, List<int>> dictionary = new Dictionary<EItemMaterialType, List<int>>();
			IReadOnlyList<RoleDevItemJumpGroup> allItemJumpGroupConfigs = RoleDevConfig.Instance.GetAllItemJumpGroupConfigs();
			if (allItemJumpGroupConfigs != null)
			{
				foreach (RoleDevItemJumpGroup roleDevItemJumpGroup in allItemJumpGroupConfigs)
				{
					EItemMaterialType itemType = (EItemMaterialType)roleDevItemJumpGroup.ItemType;
					List<int> list;
					if (!dictionary.TryGetValue(itemType, out list))
					{
						list = new List<int>();
						dictionary[itemType] = list;
					}
					list.Add(roleDevItemJumpGroup.ItemId);
				}
			}
			this.ItemIdsByMaterialTypeCache = dictionary;
			return dictionary;
		}

		// Token: 0x06027ECD RID: 163533 RVA: 0x00B29D14 File Offset: 0x00B27F14
		private void BuildNeedItemCaches()
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			HashSet<int> hashSet = new HashSet<int>();
			RoleDevelopData roleDevelopData = this.GetRoleDevelopData(this.DevTargetRoleIdInternal);
			if (roleDevelopData == null)
			{
				this.NeedItemCache = dictionary;
				this.NeedItemChainItemSet = hashSet;
				return;
			}
			RoleDevelopProjectBaseData projectData = roleDevelopData.GetProjectData();
			foreach (List<RoleDevelopNeedItem> list in new List<List<RoleDevelopNeedItem>>
			{
				projectData.GetRoleUpgradeNeedItems(),
				projectData.GetRoleBreachNeedItems(),
				projectData.GetWeaponUpgradeNeedItems(),
				projectData.GetWeaponBreachNeedItems(),
				projectData.GetSkillPlanNeedItems()
			})
			{
				foreach (RoleDevelopNeedItem roleDevelopNeedItem in list)
				{
					if (!RoleDevelopUtil.IsUnknownItem(roleDevelopNeedItem.ItemId))
					{
						int num;
						dictionary.TryGetValue(roleDevelopNeedItem.ItemId, out num);
						dictionary[roleDevelopNeedItem.ItemId] = num + roleDevelopNeedItem.Count;
					}
				}
			}
			ComposePopupModel instance = ComposePopupModel.Instance;
			ItemAccessedFromGiftPathConfig instance2 = ItemAccessedFromGiftPathConfig.Instance;
			RoleDevConfig instance3 = RoleDevConfig.Instance;
			HashSet<int> hashSet2 = new HashSet<int>(dictionary.Keys);
			Queue<int> queue = new Queue<int>(4);
			foreach (int element in dictionary.Keys)
			{
				queue.Push(element);
			}
			HashSet<EItemMaterialType> hashSet3 = new HashSet<EItemMaterialType>();
			foreach (int itemId in dictionary.Keys)
			{
				RoleDevItemJumpGroup? itemJumpGroupConfig = instance3.GetItemJumpGroupConfig(itemId);
				if (itemJumpGroupConfig != null)
				{
					EItemMaterialType itemType = (EItemMaterialType)itemJumpGroupConfig.Value.ItemType;
					if (itemType == EItemMaterialType.RoleExp || itemType == EItemMaterialType.WeaponExp)
					{
						hashSet3.Add(itemType);
					}
				}
			}
			if (hashSet3.Count <= 0)
			{
				goto IL_331;
			}
			Dictionary<EItemMaterialType, List<int>> itemIdsByMaterialType = this.GetItemIdsByMaterialType();
			using (HashSet<EItemMaterialType>.Enumerator enumerator4 = hashSet3.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					EItemMaterialType key = enumerator4.Current;
					List<int> list2;
					if (itemIdsByMaterialType.TryGetValue(key, out list2))
					{
						foreach (int num2 in list2)
						{
							hashSet.Add(num2);
							if (hashSet2.Add(num2))
							{
								queue.Push(num2);
							}
						}
					}
				}
				goto IL_331;
			}
			IL_26E:
			int num3 = queue.Pop();
			List<IComposeItemData> composeMaterialList = instance.GetComposeMaterialList(num3);
			if (composeMaterialList != null)
			{
				foreach (IComposeItemData composeItemData in composeMaterialList)
				{
					if (hashSet2.Add(composeItemData.ItemId))
					{
						hashSet.Add(composeItemData.ItemId);
						queue.Push(composeItemData.ItemId);
					}
				}
			}
			foreach (int num4 in instance2.GetGiftItemGroupById(num3, true))
			{
				if (hashSet2.Add(num4))
				{
					hashSet.Add(num4);
					queue.Push(num4);
				}
			}
			IL_331:
			if (queue.Empty)
			{
				this.NeedItemCache = dictionary;
				this.NeedItemChainItemSet = hashSet;
				return;
			}
			goto IL_26E;
		}

		// Token: 0x06027ECE RID: 163534 RVA: 0x00B2A0D0 File Offset: 0x00B282D0
		public HashSet<int> GetDevelopRoleDeficitDetectionIdSet()
		{
			if (this.DeficitDetectionIdSetCache == null)
			{
				this.DeficitDetectionIdSetCache = this.BuildDeficitDetectionIdSet();
			}
			HashSet<int> hashSet = new HashSet<int>(this.DeficitDetectionIdSetCache);
			foreach (int item in this.BuildPhantomPlanDetectionIdSet())
			{
				hashSet.Add(item);
			}
			return hashSet;
		}

		// Token: 0x06027ECF RID: 163535 RVA: 0x00B2A148 File Offset: 0x00B28348
		public int GetDevelopRoleNeedItemDeficitCount(int itemId)
		{
			int developRoleNeedItemCount = this.GetDevelopRoleNeedItemCount(itemId);
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(itemId, 0);
			return Math.Max(0, developRoleNeedItemCount - itemCountByConfigId);
		}

		// Token: 0x06027ED0 RID: 163536 RVA: 0x00B2A174 File Offset: 0x00B28374
		private HashSet<int> BuildDeficitDetectionIdSet()
		{
			HashSet<int> hashSet = new HashSet<int>();
			if (this.DevTargetRoleIdInternal == 0)
			{
				return hashSet;
			}
			RoleDevConfig instance = RoleDevConfig.Instance;
			foreach (KeyValuePair<int, int> keyValuePair in this.GetNeedItemCache())
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (!RoleDevelopUtil.IsUnknownItem(key) && InventoryModel.Instance.GetItemCountByConfigId(key, 0) < value)
				{
					RoleDevItemJumpGroup? itemJumpGroupConfig = instance.GetItemJumpGroupConfig(key);
					if (itemJumpGroupConfig != null)
					{
						int itemType = itemJumpGroupConfig.Value.ItemType;
						if (itemType >= 1 && itemType <= 5)
						{
							int detectionType = itemJumpGroupConfig.Value.DetectionType;
							if (detectionType == 1 || detectionType == 2)
							{
								int detectionIDLength = itemJumpGroupConfig.Value.DetectionIDLength;
								if (detectionIDLength > 0)
								{
									for (int i = 0; i < detectionIDLength; i++)
									{
										int num = itemJumpGroupConfig.Value.DetectionID(i);
										if (num != 0)
										{
											hashSet.Add(num);
										}
									}
								}
							}
						}
					}
				}
			}
			return hashSet;
		}

		// Token: 0x06027ED1 RID: 163537 RVA: 0x00B2A2A8 File Offset: 0x00B284A8
		private unsafe HashSet<int> BuildPhantomPlanDetectionIdSet()
		{
			HashSet<int> hashSet = new HashSet<int>();
			if (this.DevTargetRoleIdInternal == 0)
			{
				return hashSet;
			}
			RoleDevConfig instance = RoleDevConfig.Instance;
			foreach (int fetterGroupId in RoleDevelopUtil.GetDefaultRecommendFetterGroupIdList(this.DevTargetRoleIdInternal))
			{
				RoleDevPhantomJumpGroup? phantomJumpGroupConfig = instance.GetPhantomJumpGroupConfig(fetterGroupId);
				if (phantomJumpGroupConfig != null)
				{
					Span<int> phantomJumpIdBytes = phantomJumpGroupConfig.Value.GetPhantomJumpIdBytes();
					for (int i = 0; i < phantomJumpIdBytes.Length; i++)
					{
						int num = *phantomJumpIdBytes[i];
						if (num != 0)
						{
							hashSet.Add(num);
						}
					}
				}
			}
			return hashSet;
		}

		// Token: 0x06027ED2 RID: 163538 RVA: 0x00B2A364 File Offset: 0x00B28564
		private RoleDevelopSettlementJumpData CreateEmptySettlementJumpData(ERoleDevelopSettlementSourceDungeonType sourceDungeonType)
		{
			return new RoleDevelopSettlementJumpData
			{
				CanShow = false,
				RoleId = 0,
				RoleIconPath = "",
				MatchedItemIds = new List<int>(),
				NeedCheckItemIds = new List<int>(),
				SourceDungeonType = sourceDungeonType
			};
		}

		// Token: 0x170051F6 RID: 20982
		// (get) Token: 0x06027ED3 RID: 163539 RVA: 0x00B2A3A1 File Offset: 0x00B285A1
		public static RoleDevelopModel Instance
		{
			get
			{
				return RoleDevelopModel._Instance;
			}
		}

		// Token: 0x06027ED4 RID: 163540 RVA: 0x00B2A3A8 File Offset: 0x00B285A8
		public static RoleDevelopModel GetOrCreateInstance()
		{
			if (RoleDevelopModel._Instance == null)
			{
				RoleDevelopModel.CreateInstance();
			}
			return RoleDevelopModel._Instance;
		}

		// Token: 0x06027ED5 RID: 163541 RVA: 0x00B2A3BC File Offset: 0x00B285BC
		public static bool CreateInstance()
		{
			if (RoleDevelopModel._Instance != null)
			{
				return true;
			}
			RoleDevelopModel._Instance = new RoleDevelopModel();
			return true;
		}

		// Token: 0x06027ED6 RID: 163542 RVA: 0x00B2A3D2 File Offset: 0x00B285D2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06027ED7 RID: 163543 RVA: 0x00B2A3D4 File Offset: 0x00B285D4
		public static void ResetStaticDefaultValue()
		{
			RoleDevelopModel._Instance = null;
		}

		// Token: 0x06027ED8 RID: 163544 RVA: 0x00B2A3DC File Offset: 0x00B285DC
		static RoleDevelopModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoleDevelopModel.CreateStaticDefaultValue), new Action(RoleDevelopModel.ResetStaticDefaultValue));
		}

		// Token: 0x06027EDA RID: 163546 RVA: 0x00B2A43A File Offset: 0x00B2863A
		[CompilerGenerated]
		internal static bool <HandleDropTypeReward>g__Enough|83_0(EItemRequirementState s)
		{
			return s == EItemRequirementState.Satisfied || s == EItemRequirementState.Supplement;
		}

		// Token: 0x04015C30 RID: 89136
		private int DevTargetRoleIdInternal;

		// Token: 0x04015C31 RID: 89137
		private string VersionInternal = "";

		// Token: 0x04015C32 RID: 89138
		private Dictionary<int, RoleDevelopData> RoleDevelopDataMap = new Dictionary<int, RoleDevelopData>();

		// Token: 0x04015C33 RID: 89139
		private Dictionary<int, List<RoleDevelopTeamRecommendInfo>> TeamRecommendMap = new Dictionary<int, List<RoleDevelopTeamRecommendInfo>>();

		// Token: 0x04015C34 RID: 89140
		[Nullable(2)]
		private Dictionary<int, int> NeedItemCache;

		// Token: 0x04015C35 RID: 89141
		[Nullable(2)]
		private HashSet<int> NeedItemChainItemSet;

		// Token: 0x04015C36 RID: 89142
		[Nullable(2)]
		private HashSet<int> DeficitDetectionIdSetCache;

		// Token: 0x04015C37 RID: 89143
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EItemMaterialType, RoleDevelopItemGroup> NeedItemGroupByTypeCache;

		// Token: 0x04015C38 RID: 89144
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EItemMaterialType, List<int>> ItemIdsByMaterialTypeCache;

		// Token: 0x04015C39 RID: 89145
		private List<RoleDevelopWorldDropTipEntry> WorldDropTipQueue = new List<RoleDevelopWorldDropTipEntry>();

		// Token: 0x04015C3A RID: 89146
		private HashSet<int> WorldDropTipShownItemIds = new HashSet<int>();

		// Token: 0x04015C3B RID: 89147
		[Nullable(2)]
		private RoleDevelopWorldDropTipEntry WorldDropTipCurrentEntry;

		// Token: 0x04015C3D RID: 89149
		public int SelectPlanId;

		// Token: 0x04015C3E RID: 89150
		public int SelectFirstVisionMonsterId;

		// Token: 0x04015C3F RID: 89151
		[Nullable(2)]
		private static RoleDevelopModel _Instance;

		// Token: 0x020098B0 RID: 39088
		[NullableContext(0)]
		private class ItemCalcInfo
		{
			// Token: 0x0402F9D2 RID: 195026
			public int ItemId;

			// Token: 0x0402F9D3 RID: 195027
			public int QualityId;

			// Token: 0x0402F9D4 RID: 195028
			public int Deficit;

			// Token: 0x0402F9D5 RID: 195029
			public int NeededPoints;

			// Token: 0x0402F9D6 RID: 195030
			public int AvailablePoints;
		}
	}
}
