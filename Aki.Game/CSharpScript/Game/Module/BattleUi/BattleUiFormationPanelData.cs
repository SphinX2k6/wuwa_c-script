using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C71 RID: 19569
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiFormationPanelData
	{
		// Token: 0x06030CE2 RID: 199906 RVA: 0x00D9B8DC File Offset: 0x00D99ADC
		public void Init()
		{
		}

		// Token: 0x06030CE3 RID: 199907 RVA: 0x00D9B8DE File Offset: 0x00D99ADE
		public void Clear()
		{
			this.PositionItemMap.Clear();
		}

		// Token: 0x06030CE4 RID: 199908 RVA: 0x00D9B8EC File Offset: 0x00D99AEC
		public void UpdateFormationPanelData()
		{
			this.PositionItemMap.Clear();
			int valueOrDefault = PlayerInfoModel.Instance.GetId().GetValueOrDefault();
			bool flag = !GameModeController.Instance.IsInInstance();
			int[] array;
			if (!GameModeModel.Instance.IsMulti)
			{
				(array = new int[1])[0] = valueOrDefault;
			}
			else
			{
				array = OnlineModel.Instance.GetAllWorldTeamPlayer();
			}
			int[] array2 = array;
			int i = 0;
			while (i < array2.Length)
			{
				int num = array2[i];
				bool flag2 = num == valueOrDefault;
				SceneTeamPlayer teamPlayerData = SceneTeamModel.Instance.GetTeamPlayerData(num);
				if (teamPlayerData != null)
				{
					goto IL_F3;
				}
				if (!flag2 && flag)
				{
					WorldTeamPlayerFightInfo worldTeamPlayerFightInfo = OnlineModel.Instance.GetWorldTeamPlayerFightInfo(num);
					List<WorldTeamRoleInfo> list = (worldTeamPlayerFightInfo != null) ? worldTeamPlayerFightInfo.RoleInfos : null;
					if (list != null)
					{
						using (List<WorldTeamRoleInfo>.Enumerator enumerator = list.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								WorldTeamRoleInfo worldTeamRoleInfo = enumerator.Current;
								this.AddPositionItem(num, worldTeamRoleInfo.RoleId, worldTeamRoleInfo.RoleSkinId, null);
							}
							goto IL_297;
						}
						goto IL_F3;
					}
				}
				IL_297:
				i++;
				continue;
				IL_F3:
				ETeamGroupType eteamGroupType = ETeamGroupType.Battle;
				ETeamGroupType? currentGroupType = teamPlayerData.GetCurrentGroupType();
				if (!GameModeModel.Instance.IsMulti && currentGroupType.GetValueOrDefault() == ETeamGroupType.Phantom && this.IsPhantomContainsSpecialRole(teamPlayerData))
				{
					eteamGroupType = ETeamGroupType.Phantom;
				}
				this.DataSource = eteamGroupType;
				SceneTeamGroup group = teamPlayerData.GetGroup(eteamGroupType);
				List<SceneTeamRole> list2 = (group != null) ? group.GetRoleList() : null;
				if (list2 != null)
				{
					if (flag2)
					{
						using (List<SceneTeamRole>.Enumerator enumerator2 = list2.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								SceneTeamRole sceneTeamRole = enumerator2.Current;
								int roleId = sceneTeamRole.RoleId;
								int roleSkinIdByRoleId = RoleSkinModel.Instance.GetRoleSkinIdByRoleId(roleId);
								this.AddPositionItem(num, roleId, roleSkinIdByRoleId, new long?(sceneTeamRole.CreatureDataId));
							}
							goto IL_297;
						}
					}
					WorldTeamPlayerFightInfo worldTeamPlayerFightInfo2 = OnlineModel.Instance.GetWorldTeamPlayerFightInfo(num);
					foreach (SceneTeamRole sceneTeamRole2 in list2)
					{
						int roleId2 = sceneTeamRole2.RoleId;
						WorldTeamRoleInfo worldTeamRoleInfo2 = (worldTeamPlayerFightInfo2 != null) ? worldTeamPlayerFightInfo2.GetRoleInfoByConfigId(roleId2) : null;
						int roleSkinId;
						if (worldTeamRoleInfo2 != null)
						{
							roleSkinId = worldTeamRoleInfo2.RoleSkinId;
						}
						else
						{
							long creatureDataId = sceneTeamRole2.CreatureDataId;
							if (creatureDataId == 0L)
							{
								return;
							}
							EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
							int? num2;
							if (entity == null)
							{
								num2 = null;
							}
							else
							{
								WorldEntity entity2 = entity.Entity;
								if (entity2 == null)
								{
									num2 = null;
								}
								else
								{
									CreatureDataComponent component = entity2.GetComponent<CreatureDataComponent>();
									num2 = ((component != null) ? new int?(component.GetSkinId()) : null);
								}
							}
							int? num3 = num2;
							roleSkinId = num3.GetValueOrDefault();
						}
						this.AddPositionItem(num, roleId2, roleSkinId, new long?(sceneTeamRole2.CreatureDataId));
					}
					goto IL_297;
				}
				goto IL_297;
			}
		}

		// Token: 0x06030CE5 RID: 199909 RVA: 0x00D9BBC8 File Offset: 0x00D99DC8
		[NullableContext(2)]
		private bool IsPhantomContainsSpecialRole(SceneTeamPlayer playerData)
		{
			if (playerData == null)
			{
				return false;
			}
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("PhantomTeamShowRoleIds");
			if (intArrayConfig == null || intArrayConfig.Count == 0)
			{
				return false;
			}
			HashSet<int> hashSet = new HashSet<int>(intArrayConfig);
			SceneTeamGroup group = playerData.GetGroup(ETeamGroupType.Phantom);
			List<SceneTeamRole> list = (group != null) ? group.GetRoleList() : null;
			if (list == null)
			{
				return false;
			}
			foreach (SceneTeamRole sceneTeamRole in list)
			{
				if (hashSet.Contains(sceneTeamRole.RoleId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06030CE6 RID: 199910 RVA: 0x00D9BC68 File Offset: 0x00D99E68
		private void AddPositionItem(int playerId, int roleId, int roleSkinId, long? creatureDataId = null)
		{
			int key = this.PositionItemMap.Count + 1;
			FormationItemData formationItemData = new FormationItemData();
			formationItemData.PlayerId = playerId;
			formationItemData.RoleId = roleId;
			formationItemData.RoleSkinId = roleSkinId;
			if (creatureDataId != null)
			{
				formationItemData.CreatureDataId = creatureDataId.Value;
			}
			this.PositionItemMap[key] = formationItemData;
		}

		// Token: 0x06030CE7 RID: 199911 RVA: 0x00D9BCC1 File Offset: 0x00D99EC1
		[NullableContext(2)]
		public FormationItemData GetItemData(int position)
		{
			return this.PositionItemMap.GetValueOrDefault(position);
		}

		// Token: 0x06030CE8 RID: 199912 RVA: 0x00D9BCD0 File Offset: 0x00D99ED0
		public int GetRolePosition(int playerId, int roleId)
		{
			foreach (KeyValuePair<int, FormationItemData> keyValuePair in this.PositionItemMap)
			{
				if (keyValuePair.Value.PlayerId == playerId && keyValuePair.Value.RoleId == roleId)
				{
					return keyValuePair.Key;
				}
			}
			return 0;
		}

		// Token: 0x06030CE9 RID: 199913 RVA: 0x00D9BD48 File Offset: 0x00D99F48
		public IReadOnlyList<string> GetActionNames()
		{
			return BattleUiFormationPanelData.ActionNames;
		}

		// Token: 0x06030CEA RID: 199914 RVA: 0x00D9BD50 File Offset: 0x00D99F50
		public void SetInputType(EFormationInputType type)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "切换编队ActionInputHandler";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.InputHandler = this.InputHandlerMap.GetValueOrDefault(type);
		}

		// Token: 0x06030CEB RID: 199915 RVA: 0x00D9BD9B File Offset: 0x00D99F9B
		public void RegisterInputHandler(EFormationInputType type, Action<string> handler)
		{
			this.InputHandlerMap[type] = handler;
		}

		// Token: 0x06030CEC RID: 199916 RVA: 0x00D9BDAA File Offset: 0x00D99FAA
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<string> GetInputHandler()
		{
			return this.InputHandler;
		}

		// Token: 0x04019DFD RID: 105981
		[StaticVariableRuleIgnore]
		private static readonly string[] ActionNames = new string[]
		{
			"切换角色1",
			"切换角色2",
			"切换角色3",
			"切换角色4"
		};

		// Token: 0x04019DFE RID: 105982
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string> InputHandler;

		// Token: 0x04019DFF RID: 105983
		private readonly Dictionary<EFormationInputType, Action<string>> InputHandlerMap = new Dictionary<EFormationInputType, Action<string>>();

		// Token: 0x04019E00 RID: 105984
		public Dictionary<int, FormationItemData> PositionItemMap = new Dictionary<int, FormationItemData>();

		// Token: 0x04019E01 RID: 105985
		public ETeamGroupType DataSource = ETeamGroupType.Battle;
	}
}
