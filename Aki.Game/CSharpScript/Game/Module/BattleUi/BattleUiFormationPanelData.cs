using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C90 RID: 23696
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiFormationPanelData
	{
		// Token: 0x0603BD94 RID: 245140 RVA: 0x00E4B360 File Offset: 0x00E49560
		public void Init()
		{
		}

		// Token: 0x0603BD95 RID: 245141 RVA: 0x00E4B362 File Offset: 0x00E49562
		public void Clear()
		{
			this.PositionItemMap.Clear();
		}

		// Token: 0x0603BD96 RID: 245142 RVA: 0x00E4B370 File Offset: 0x00E49570
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

		// Token: 0x0603BD97 RID: 245143 RVA: 0x00E4B64C File Offset: 0x00E4984C
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

		// Token: 0x0603BD98 RID: 245144 RVA: 0x00E4B6EC File Offset: 0x00E498EC
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

		// Token: 0x0603BD99 RID: 245145 RVA: 0x00E4B745 File Offset: 0x00E49945
		[NullableContext(2)]
		public FormationItemData GetItemData(int position)
		{
			return this.PositionItemMap.GetValueOrDefault(position);
		}

		// Token: 0x0603BD9A RID: 245146 RVA: 0x00E4B754 File Offset: 0x00E49954
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

		// Token: 0x0603BD9B RID: 245147 RVA: 0x00E4B7CC File Offset: 0x00E499CC
		public IReadOnlyList<string> GetActionNames()
		{
			return BattleUiFormationPanelData.ActionNames;
		}

		// Token: 0x0603BD9C RID: 245148 RVA: 0x00E4B7D4 File Offset: 0x00E499D4
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

		// Token: 0x0603BD9D RID: 245149 RVA: 0x00E4B81F File Offset: 0x00E49A1F
		public void RegisterInputHandler(EFormationInputType type, Action<string> handler)
		{
			this.InputHandlerMap[type] = handler;
		}

		// Token: 0x0603BD9E RID: 245150 RVA: 0x00E4B82E File Offset: 0x00E49A2E
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<string> GetInputHandler()
		{
			return this.InputHandler;
		}

		// Token: 0x0401F346 RID: 127814
		[StaticVariableRuleIgnore]
		private static readonly string[] ActionNames = new string[]
		{
			"切换角色1",
			"切换角色2",
			"切换角色3",
			"切换角色4"
		};

		// Token: 0x0401F347 RID: 127815
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string> InputHandler;

		// Token: 0x0401F348 RID: 127816
		private readonly Dictionary<EFormationInputType, Action<string>> InputHandlerMap = new Dictionary<EFormationInputType, Action<string>>();

		// Token: 0x0401F349 RID: 127817
		public Dictionary<int, FormationItemData> PositionItemMap = new Dictionary<int, FormationItemData>();

		// Token: 0x0401F34A RID: 127818
		public ETeamGroupType DataSource = ETeamGroupType.Battle;
	}
}
