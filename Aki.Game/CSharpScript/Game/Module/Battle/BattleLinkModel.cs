using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Sequence.Common_Seq.Video.SplitScreen;
using AkiClient.Game.Aki.Sequence.Common_Seq.Video.SplitScreen.SplitScreenData;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.DreamLink;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Module.RoleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C4A RID: 23626
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class BattleLinkModel : ModelBase
	{
		// Token: 0x0603BB09 RID: 244489 RVA: 0x00E3FCBB File Offset: 0x00E3DEBB
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603BB0A RID: 244490 RVA: 0x00E3FCC0 File Offset: 0x00E3DEC0
		protected override bool OnLeaveLevel()
		{
			if (this.MainBp.HasValue)
			{
				if (this.MainBp.IsT1)
				{
					ActorSystem.Instance.Put("BattleLinkModel.OnLeaveLevel", this.MainBp.AsT1, null);
				}
				else if (this.MainBp.IsT2)
				{
					ActorSystem.Instance.Put("BattleLinkModel.OnLeaveLevel", this.MainBp.AsT2, null);
				}
			}
			this.MainBp.Clear();
			this.ThreeRoleSeq = null;
			this.TwoRoleSeq = null;
			Dictionary<int, BattleLinkModel.LinkRoleData> linkRoleDataMap = this.LinkRoleDataMap;
			if (linkRoleDataMap != null)
			{
				linkRoleDataMap.Clear();
			}
			Dictionary<int, BattleLinkModel.LinkRoleMorphData> linkRoleMorphDataMap = this.LinkRoleMorphDataMap;
			if (linkRoleMorphDataMap != null)
			{
				linkRoleMorphDataMap.Clear();
			}
			this.InstanceId = -1;
			this.PlayerRoleId = -1;
			this.IsThreeRoleTeam = false;
			this.IsTwoRoleTeam = false;
			this.PreloadRoleIds = null;
			this.IsLinkSkillInCd = false;
			this.LinkEntityIds = null;
			this.LinkStatus = ELinkStatus.None;
			this.NewLinkStatus = ENewLinkStatus.None;
			this.NewLinkId = 0;
			this.NewLinkGmTest = false;
			this.PreloadConfigId = 0;
			return true;
		}

		// Token: 0x0603BB0B RID: 244491 RVA: 0x00E3FDC0 File Offset: 0x00E3DFC0
		private void ClearRoleRes(List<int> roleIdList)
		{
			if (this.PreloadRoleIds != null)
			{
				List<int> list = new List<int>();
				foreach (int num in this.PreloadRoleIds)
				{
					if (!roleIdList.Contains(num))
					{
						list.Add(num);
						Dictionary<int, BattleLinkModel.LinkRoleData> linkRoleDataMap = this.LinkRoleDataMap;
						if (linkRoleDataMap != null)
						{
							linkRoleDataMap.Remove(num);
						}
						Dictionary<int, BattleLinkModel.LinkRoleMorphData> linkRoleMorphDataMap = this.LinkRoleMorphDataMap;
						if (linkRoleMorphDataMap != null)
						{
							linkRoleMorphDataMap.Remove(num);
						}
					}
				}
				using (List<int>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						int item = enumerator.Current;
						this.PreloadRoleIds.Remove(item);
					}
					return;
				}
			}
			Dictionary<int, BattleLinkModel.LinkRoleData> linkRoleDataMap2 = this.LinkRoleDataMap;
			if (linkRoleDataMap2 != null)
			{
				linkRoleDataMap2.Clear();
			}
			Dictionary<int, BattleLinkModel.LinkRoleMorphData> linkRoleMorphDataMap2 = this.LinkRoleMorphDataMap;
			if (linkRoleMorphDataMap2 == null)
			{
				return;
			}
			linkRoleMorphDataMap2.Clear();
		}

		// Token: 0x0603BB0C RID: 244492 RVA: 0x00E3FEB8 File Offset: 0x00E3E0B8
		[NullableContext(2)]
		private List<int> GetPreloadRoleIds()
		{
			if (this.CheckInNewBattleLink())
			{
				return this.RoleIdList;
			}
			if (this.CheckInSpecialBattleLink())
			{
				if (this.PreloadConfigId != 0)
				{
					LinkPreload? linkPreloadConfig = BattleLinkConfig.Instance.GetLinkPreloadConfig(this.PreloadConfigId);
					if (linkPreloadConfig != null)
					{
						LinkPreload value = linkPreloadConfig.Value;
						int roleIdListLength = value.RoleIdListLength;
						List<int> list = new List<int>(roleIdListLength);
						for (int i = 0; i < roleIdListLength; i++)
						{
							list.Add(value.RoleIdList(i));
						}
						LinkParam? linkParam = BattleLinkConfig.Instance.GetLinkParam(1);
						Dictionary<int, int> dictionary = (linkParam != null) ? linkParam.GetValueOrDefault().ChangeGenderMap() : null;
						for (int j = 0; j < list.Count; j++)
						{
							int num = list[j];
							int num2 = num;
							if (dictionary != null && dictionary.ContainsKey(num))
							{
								MainRoleConfig? mainRoleById = RoleConfig.Instance.GetMainRoleById(num);
								if (mainRoleById != null && mainRoleById.Value.Gender != (int)PlayerInfoModel.Instance.GetPlayerGender())
								{
									num2 = dictionary.GetValueOrDefault(num, num);
									list[list.IndexOf(num)] = num2;
								}
							}
							RoleInfo? roleInfo;
							int? num3 = (RoleConfig.Instance.GetRoleConfig(num2) != null) ? new int?(roleInfo.GetValueOrDefault().MeshId) : null;
							int? num4 = num3;
							int num5 = 0;
							if (!(num4.GetValueOrDefault() == num5 & num4 != null))
							{
								if (this.ModelIdMap == null)
								{
									this.ModelIdMap = new Dictionary<int, int>();
								}
								this.ModelIdMap[num2] = num3.Value;
							}
						}
						return list;
					}
				}
				return null;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			if (this.PreloadRoleIdsMap == null)
			{
				RogueWhiteCat? activityConfig = DreamLinkConfig.Instance.GetActivityConfig(102600001);
				if (activityConfig == null)
				{
					return null;
				}
				Dictionary<int, string> dictionary2 = activityConfig.Value.PreloadRoleIds();
				this.PreloadRoleIdsMap = new Dictionary<int, List<int>>();
				foreach (KeyValuePair<int, string> keyValuePair in dictionary2)
				{
					IEnumerable<string> source = keyValuePair.Value.Split(';', StringSplitOptions.None);
					Func<string, int> selector;
					if ((selector = BattleLinkModel.<>O.<0>__Parse) == null)
					{
						selector = (BattleLinkModel.<>O.<0>__Parse = new Func<string, int>(int.Parse));
					}
					List<int> value2 = source.Select(selector).ToList<int>();
					this.PreloadRoleIdsMap[keyValuePair.Key] = value2;
				}
			}
			List<int> roleIdList;
			if (!this.PreloadRoleIdsMap.TryGetValue(instanceId, out roleIdList))
			{
				roleIdList = this.RoleIdList;
			}
			return roleIdList;
		}

		// Token: 0x0603BB0D RID: 244493 RVA: 0x00E40168 File Offset: 0x00E3E368
		public void SetRoleIdList(List<int> roleIdList)
		{
			this.RoleIdList = new List<int>(roleIdList);
			bool flag = true;
			if (this.CheckInNewBattleLink())
			{
				List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(false);
				Dictionary<int, int> modelIdMap = this.ModelIdMap;
				if (modelIdMap != null)
				{
					modelIdMap.Clear();
				}
				Dictionary<int, int> morphModelIdMap = this.MorphModelIdMap;
				if (morphModelIdMap != null)
				{
					morphModelIdMap.Clear();
				}
				this.OneRoleTeammateRoleId = 0;
				LinkParam? linkParam = BattleLinkConfig.Instance.GetLinkParam(1);
				foreach (SceneTeamItem sceneTeamItem in teamItems)
				{
					int baseRoleId = RoleConfig.Instance.GetBaseRoleId(sceneTeamItem.GetConfigId);
					if (roleIdList.Contains(baseRoleId))
					{
						CreatureModel instance = CreatureModel.Instance;
						EntityHandle entityHandle = (instance != null) ? instance.GetEntity(sceneTeamItem.GetCreatureDataId()) : null;
						WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
						int? num;
						if (worldEntity == null)
						{
							num = null;
						}
						else
						{
							CreatureDataComponent component = worldEntity.GetComponent<CreatureDataComponent>();
							num = ((component != null) ? new int?(component.GetModelId()) : null);
						}
						int? num2 = num;
						int valueOrDefault = num2.GetValueOrDefault();
						if (valueOrDefault != 0)
						{
							if (this.ModelIdMap == null)
							{
								this.ModelIdMap = new Dictionary<int, int>();
							}
							this.ModelIdMap[baseRoleId] = valueOrDefault;
						}
						int value;
						if (linkParam != null && linkParam.GetValueOrDefault().MorphModelIdMap().TryGetValue(valueOrDefault, out value))
						{
							if (this.MorphModelIdMap == null)
							{
								this.MorphModelIdMap = new Dictionary<int, int>();
							}
							this.MorphModelIdMap[baseRoleId] = value;
						}
					}
				}
				if (teamItems.Count == 1)
				{
					int linkIdByRoleIdList = RogueBattleModel.Instance.GetLinkIdByRoleIdList(roleIdList);
					LinkData? linkDataConfig = BattleLinkConfig.Instance.GetLinkDataConfig(linkIdByRoleIdList);
					if (linkDataConfig != null && linkDataConfig.Value.IsEnableOneRoleBurst != 0)
					{
						int oneRoleBurstTeammateId = linkDataConfig.Value.OneRoleBurstTeammateId;
						LinkCharacter? roleConfig = BattleLinkConfig.Instance.GetRoleConfig(oneRoleBurstTeammateId);
						if (roleConfig != null)
						{
							int roleId = roleConfig.Value.RoleId;
							if (this.ModelIdMap != null)
							{
								this.ModelIdMap[roleId] = oneRoleBurstTeammateId;
							}
							roleIdList.Add(roleId);
							this.OneRoleTeammateRoleId = roleId;
						}
					}
				}
			}
			else if (this.CheckInSpecialBattleLink())
			{
				flag = false;
			}
			this.IsThreeRoleTeam = false;
			this.IsTwoRoleTeam = false;
			if (roleIdList.Count == 3)
			{
				this.IsThreeRoleTeam = true;
			}
			else if (roleIdList.Count == 2)
			{
				this.IsTwoRoleTeam = true;
			}
			if (this.IsThreeRoleTeam || this.IsTwoRoleTeam)
			{
				int num3 = roleIdList[0];
				if (flag)
				{
					SceneTeamItem getCurrentTeamItem = SceneTeamModel.Instance.GetCurrentTeamItem;
					if (getCurrentTeamItem != null)
					{
						num3 = RoleConfig.Instance.GetBaseRoleId(getCurrentTeamItem.GetConfigId);
					}
				}
				List<int> list = new List<int>(roleIdList);
				list.Remove(num3);
				list.Insert(1, num3);
				this.RoleIdList = list;
				this.PlayerRoleId = num3;
				return;
			}
			this.PlayerRoleId = -1;
		}

		// Token: 0x0603BB0E RID: 244494 RVA: 0x00E40460 File Offset: 0x00E3E660
		public CustomPromise<bool> PreloadRes()
		{
			CustomPromise<bool> tcs = new CustomPromise<bool>();
			if (this.PreloadRoleIds != null && this.RoleIdList != null && this.PreloadRoleIds.Count >= this.RoleIdList.Count)
			{
				bool flag = true;
				int count = this.RoleIdList.Count;
				for (int i = 0; i < count; i++)
				{
					if (!this.PreloadRoleIds.Contains(this.RoleIdList[i]))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					tcs.SetResult(true);
					return tcs;
				}
			}
			this.PreloadRoleIds = (this.GetPreloadRoleIds() ?? new List<int>());
			List<int> roleIdList = this.PreloadRoleIds;
			if (this.LinkRoleDataMap == null)
			{
				this.LinkRoleDataMap = new Dictionary<int, BattleLinkModel.LinkRoleData>();
			}
			foreach (int num in roleIdList)
			{
				BattleLinkModel.LinkRoleData value = new BattleLinkModel.LinkRoleData
				{
					RoleId = num
				};
				this.LinkRoleDataMap[num] = value;
				Dictionary<int, int> morphModelIdMap = this.MorphModelIdMap;
				if (morphModelIdMap != null && morphModelIdMap.ContainsKey(num))
				{
					if (this.LinkRoleMorphDataMap == null)
					{
						this.LinkRoleMorphDataMap = new Dictionary<int, BattleLinkModel.LinkRoleMorphData>();
					}
					if (!this.LinkRoleMorphDataMap.ContainsKey(num))
					{
						BattleLinkModel.LinkRoleData linkRoleData = new BattleLinkModel.LinkRoleData
						{
							RoleId = num
						};
						BattleLinkModel.LinkRoleMorphData value2 = new BattleLinkModel.LinkRoleMorphData
						{
							RoleId = num,
							LinkRoleData = linkRoleData
						};
						this.LinkRoleMorphDataMap[num] = value2;
					}
				}
			}
			Action <>9__4;
			Action<Exception> <>9__5;
			Action <>9__2;
			Action<Exception> <>9__3;
			this.LoadSplitScreenRes().ContinueWith(delegate()
			{
				UniTask task = this.LoadDataAsset(roleIdList);
				Action continuationFunction;
				if ((continuationFunction = <>9__2) == null)
				{
					continuationFunction = (<>9__2 = delegate()
					{
						UniTask task3 = this.LoadCharacterRes(roleIdList);
						Action continuationFunction2;
						if ((continuationFunction2 = <>9__4) == null)
						{
							continuationFunction2 = (<>9__4 = delegate()
							{
								this.InitMainBp();
								this.ResetMainBp();
								tcs.SetResult(true);
							});
						}
						UniTask task4 = task3.ContinueWith(continuationFunction2);
						Action<Exception> exceptionHandler2;
						if ((exceptionHandler2 = <>9__5) == null)
						{
							exceptionHandler2 = (<>9__5 = delegate(Exception _)
							{
								tcs.SetResult(false);
							});
						}
						task4.Forget(exceptionHandler2, true);
					});
				}
				UniTask task2 = task.ContinueWith(continuationFunction);
				Action<Exception> exceptionHandler;
				if ((exceptionHandler = <>9__3) == null)
				{
					exceptionHandler = (<>9__3 = delegate(Exception _)
					{
						tcs.SetResult(false);
					});
				}
				task2.Forget(exceptionHandler, true);
			}).Forget(delegate(Exception _)
			{
				tcs.SetResult(false);
			}, true);
			return tcs;
		}

		// Token: 0x0603BB0F RID: 244495 RVA: 0x00E40630 File Offset: 0x00E3E830
		public CustomPromise<bool> PreloadTeamRoleRes()
		{
			List<int> teamRoleConfigIdList = SceneTeamModel.Instance.GetTeamRoleConfigIdList(false, true);
			if (teamRoleConfigIdList != null)
			{
				this.SetRoleIdList(teamRoleConfigIdList);
				this.ClearRoleRes(teamRoleConfigIdList);
			}
			else
			{
				this.ClearRoleRes(new List<int>());
			}
			return this.PreloadRes();
		}

		// Token: 0x0603BB10 RID: 244496 RVA: 0x00E40670 File Offset: 0x00E3E870
		public void SetPreloadConfigId(int id)
		{
			if (BattleLinkConfig.Instance.GetLinkPreloadConfig(id) != null)
			{
				this.PreloadConfigId = id;
			}
		}

		// Token: 0x0603BB11 RID: 244497 RVA: 0x00E4069C File Offset: 0x00E3E89C
		private UniTask LoadSplitScreenRes()
		{
			BattleLinkModel.<LoadSplitScreenRes>d__40 <LoadSplitScreenRes>d__;
			<LoadSplitScreenRes>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadSplitScreenRes>d__.<>4__this = this;
			<LoadSplitScreenRes>d__.<>1__state = -1;
			<LoadSplitScreenRes>d__.<>t__builder.Start<BattleLinkModel.<LoadSplitScreenRes>d__40>(ref <LoadSplitScreenRes>d__);
			return <LoadSplitScreenRes>d__.<>t__builder.Task;
		}

		// Token: 0x0603BB12 RID: 244498 RVA: 0x00E406E0 File Offset: 0x00E3E8E0
		private UniTask LoadDataAsset(List<int> roleIdList)
		{
			BattleLinkModel.<LoadDataAsset>d__41 <LoadDataAsset>d__;
			<LoadDataAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadDataAsset>d__.<>4__this = this;
			<LoadDataAsset>d__.roleIdList = roleIdList;
			<LoadDataAsset>d__.<>1__state = -1;
			<LoadDataAsset>d__.<>t__builder.Start<BattleLinkModel.<LoadDataAsset>d__41>(ref <LoadDataAsset>d__);
			return <LoadDataAsset>d__.<>t__builder.Task;
		}

		// Token: 0x0603BB13 RID: 244499 RVA: 0x00E4072C File Offset: 0x00E3E92C
		private UniTask LoadCharacterRes(List<int> roleIdList)
		{
			BattleLinkModel.<LoadCharacterRes>d__42 <LoadCharacterRes>d__;
			<LoadCharacterRes>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadCharacterRes>d__.<>4__this = this;
			<LoadCharacterRes>d__.roleIdList = roleIdList;
			<LoadCharacterRes>d__.<>1__state = -1;
			<LoadCharacterRes>d__.<>t__builder.Start<BattleLinkModel.<LoadCharacterRes>d__42>(ref <LoadCharacterRes>d__);
			return <LoadCharacterRes>d__.<>t__builder.Task;
		}

		// Token: 0x0603BB14 RID: 244500 RVA: 0x00E40778 File Offset: 0x00E3E978
		private void PushLoadCharacterResPromise(int roleId, int? modelId = null, bool isNewLink = false)
		{
			List<UniTask> loadCharacterPromises = this.LoadCharacterPromises;
			object obj;
			if (modelId != null)
			{
				int? num = modelId;
				Dictionary<int, int> morphModelIdMap = this.MorphModelIdMap;
				int? num2 = (morphModelIdMap != null) ? morphModelIdMap.GetValueOrNull(roleId) : null;
				obj = (num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null));
			}
			else
			{
				obj = 0;
			}
			object obj2 = obj;
			BP_SplitScreenCharacterData_C bp_SplitScreenCharacterData_C;
			if (obj2 == null)
			{
				Dictionary<int, BattleLinkModel.LinkRoleData> linkRoleDataMap = this.LinkRoleDataMap;
				if (linkRoleDataMap == null)
				{
					bp_SplitScreenCharacterData_C = null;
				}
				else
				{
					BattleLinkModel.LinkRoleData valueOrDefault = linkRoleDataMap.GetValueOrDefault(roleId);
					bp_SplitScreenCharacterData_C = ((valueOrDefault != null) ? valueOrDefault.DataAsset : null);
				}
			}
			else
			{
				Dictionary<int, BattleLinkModel.LinkRoleMorphData> linkRoleMorphDataMap = this.LinkRoleMorphDataMap;
				if (linkRoleMorphDataMap == null)
				{
					bp_SplitScreenCharacterData_C = null;
				}
				else
				{
					BattleLinkModel.LinkRoleMorphData valueOrDefault2 = linkRoleMorphDataMap.GetValueOrDefault(roleId);
					if (valueOrDefault2 == null)
					{
						bp_SplitScreenCharacterData_C = null;
					}
					else
					{
						BattleLinkModel.LinkRoleData linkRoleData = valueOrDefault2.LinkRoleData;
						bp_SplitScreenCharacterData_C = ((linkRoleData != null) ? linkRoleData.DataAsset : null);
					}
				}
			}
			BP_SplitScreenCharacterData_C bp_SplitScreenCharacterData_C2 = bp_SplitScreenCharacterData_C;
			if (bp_SplitScreenCharacterData_C2 != null)
			{
				UClassStackOnlyPtr ptr = bp_SplitScreenCharacterData_C2.CharacterActorClass.Get();
				if (ptr.IsValid())
				{
					string pathName = UKismetSystemLibrary.GetPathName(ptr.ToClass());
					loadCharacterPromises.Add(this.LoadRoleBp(roleId, modelId, pathName));
				}
				if (bp_SplitScreenCharacterData_C2.Cos_Pose_AnimSequence != null)
				{
					string pathName2 = UKismetSystemLibrary.GetPathName(bp_SplitScreenCharacterData_C2.Cos_Pose_AnimSequence);
					loadCharacterPromises.Add(this.LoadAnim(roleId, modelId, pathName2, false, "WeaponCase"));
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.WWJ;
				string message = "[BattleLink]找不到角色对应的DA";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleid", roleId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			BattleLinkCharacter? battleLinkCharacter = null;
			LinkCharacter? morphRoleConfig;
			if (obj2 != null)
			{
				morphRoleConfig = this.GetMorphRoleConfig(roleId);
			}
			else
			{
				this.GetRoleConfig(roleId, out morphRoleConfig, out battleLinkCharacter, false);
			}
			if (morphRoleConfig != null)
			{
				LinkCharacter value = morphRoleConfig.Value;
				if (value.NeedLoadMesh == 1)
				{
					RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
					int? num3 = (roleConfig != null) ? new int?(roleConfig.GetValueOrDefault().MeshId) : null;
					int? num2 = num3;
					int num4 = 0;
					if (!(num2.GetValueOrDefault() == num4 & num2 != null))
					{
						SModelConfig dataTableRowFromName = DataTableUtil.GetDataTableRowFromName<SModelConfig>(EDataTable.ModelConfig, num3.ToString());
						FName? fname = (dataTableRowFromName != null) ? new FName?(dataTableRowFromName.网格体.GetAssetPathName()) : null;
						if (fname != FName.NAME_None)
						{
							loadCharacterPromises.Add(this.LoadMesh(roleId, modelId, fname.ToString(), false, "WeaponCase"));
						}
					}
				}
				if (isNewLink)
				{
					int weaponMeshListLength = value.WeaponMeshListLength;
					int weaponAnimListLength = value.WeaponAnimListLength;
					int compNameListLength = value.CompNameListLength;
					for (int i = 0; i < weaponMeshListLength; i++)
					{
						loadCharacterPromises.Add(this.LoadMesh(roleId, modelId, value.WeaponMeshList(i), true, (i < compNameListLength) ? value.CompNameList(i) : "WeaponCase"));
					}
					for (int j = 0; j < weaponAnimListLength; j++)
					{
						loadCharacterPromises.Add(this.LoadAnim(roleId, modelId, value.WeaponAnimList(j), true, (j < compNameListLength) ? value.CompNameList(j) : "WeaponCase"));
					}
					return;
				}
				if (roleId == 1105)
				{
					loadCharacterPromises.Add(this.LoadMesh(roleId, modelId, "/Game/Aki/Character/Weapon/Prop/Role/ZhezhiProp/EZhezhiMaobixiaoMd10011/Model/EZhezhiMaobixiaoMd10011.EZhezhiMaobixiaoMd10011", true, "WeaponCase"));
					loadCharacterPromises.Add(this.LoadAnim(roleId, modelId, "/Game/Aki/Character/Weapon/Prop/Role/ZhezhiProp/EZhezhiMaobixiaoMd10011/BaseAnim/Maobi_CosPose.Maobi_CosPose", true, "WeaponCase"));
					return;
				}
			}
			else if (battleLinkCharacter != null)
			{
				if (battleLinkCharacter.Value.NeedLoadMesh == 1)
				{
					RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
					int? num5 = (roleConfig != null) ? new int?(roleConfig.GetValueOrDefault().MeshId) : null;
					int? num2 = num5;
					int num4 = 0;
					if (!(num2.GetValueOrDefault() == num4 & num2 != null))
					{
						SModelConfig dataTableRowFromName2 = DataTableUtil.GetDataTableRowFromName<SModelConfig>(EDataTable.ModelConfig, num5.ToString());
						FName? fname2 = (dataTableRowFromName2 != null) ? new FName?(dataTableRowFromName2.网格体.GetAssetPathName()) : null;
						if (fname2 != FName.NAME_None)
						{
							loadCharacterPromises.Add(this.LoadMesh(roleId, modelId, fname2.ToString(), false, "WeaponCase"));
						}
					}
				}
				if (isNewLink)
				{
					throw new UnreachableException();
				}
				if (roleId == 1105)
				{
					loadCharacterPromises.Add(this.LoadMesh(roleId, modelId, "/Game/Aki/Character/Weapon/Prop/Role/ZhezhiProp/EZhezhiMaobixiaoMd10011/Model/EZhezhiMaobixiaoMd10011.EZhezhiMaobixiaoMd10011", true, "WeaponCase"));
					loadCharacterPromises.Add(this.LoadAnim(roleId, modelId, "/Game/Aki/Character/Weapon/Prop/Role/ZhezhiProp/EZhezhiMaobixiaoMd10011/BaseAnim/Maobi_CosPose.Maobi_CosPose", true, "WeaponCase"));
					return;
				}
			}
			else
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.WWJ;
				string message2 = "[BattleLink]找不到roleId的配置";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("roleid", roleId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
		}

		// Token: 0x0603BB15 RID: 244501 RVA: 0x00E40C14 File Offset: 0x00E3EE14
		private UniTask LoadMainBp()
		{
			BattleLinkModel.<LoadMainBp>d__44 <LoadMainBp>d__;
			<LoadMainBp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadMainBp>d__.<>4__this = this;
			<LoadMainBp>d__.<>1__state = -1;
			<LoadMainBp>d__.<>t__builder.Start<BattleLinkModel.<LoadMainBp>d__44>(ref <LoadMainBp>d__);
			return <LoadMainBp>d__.<>t__builder.Task;
		}

		// Token: 0x0603BB16 RID: 244502 RVA: 0x00E40C58 File Offset: 0x00E3EE58
		private UniTask LoadCharacterDataAsset(int roleId, int modelId, string path)
		{
			BattleLinkModel.<LoadCharacterDataAsset>d__45 <LoadCharacterDataAsset>d__;
			<LoadCharacterDataAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadCharacterDataAsset>d__.<>4__this = this;
			<LoadCharacterDataAsset>d__.roleId = roleId;
			<LoadCharacterDataAsset>d__.modelId = modelId;
			<LoadCharacterDataAsset>d__.path = path;
			<LoadCharacterDataAsset>d__.<>1__state = -1;
			<LoadCharacterDataAsset>d__.<>t__builder.Start<BattleLinkModel.<LoadCharacterDataAsset>d__45>(ref <LoadCharacterDataAsset>d__);
			return <LoadCharacterDataAsset>d__.<>t__builder.Task;
		}

		// Token: 0x0603BB17 RID: 244503 RVA: 0x00E40CB4 File Offset: 0x00E3EEB4
		private UniTask LoadAnim(int roleId, int? modelId, string path, bool isWeapon = false, string weaponKey = "WeaponCase")
		{
			BattleLinkModel.<LoadAnim>d__46 <LoadAnim>d__;
			<LoadAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadAnim>d__.<>4__this = this;
			<LoadAnim>d__.roleId = roleId;
			<LoadAnim>d__.modelId = modelId;
			<LoadAnim>d__.path = path;
			<LoadAnim>d__.isWeapon = isWeapon;
			<LoadAnim>d__.weaponKey = weaponKey;
			<LoadAnim>d__.<>1__state = -1;
			<LoadAnim>d__.<>t__builder.Start<BattleLinkModel.<LoadAnim>d__46>(ref <LoadAnim>d__);
			return <LoadAnim>d__.<>t__builder.Task;
		}

		// Token: 0x0603BB18 RID: 244504 RVA: 0x00E40D24 File Offset: 0x00E3EF24
		private UniTask LoadRoleBp(int roleId, int? modelId, string path)
		{
			BattleLinkModel.<LoadRoleBp>d__47 <LoadRoleBp>d__;
			<LoadRoleBp>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadRoleBp>d__.<>4__this = this;
			<LoadRoleBp>d__.roleId = roleId;
			<LoadRoleBp>d__.modelId = modelId;
			<LoadRoleBp>d__.path = path;
			<LoadRoleBp>d__.<>1__state = -1;
			<LoadRoleBp>d__.<>t__builder.Start<BattleLinkModel.<LoadRoleBp>d__47>(ref <LoadRoleBp>d__);
			return <LoadRoleBp>d__.<>t__builder.Task;
		}

		// Token: 0x0603BB19 RID: 244505 RVA: 0x00E40D80 File Offset: 0x00E3EF80
		private UniTask LoadSeq(string path)
		{
			BattleLinkModel.<LoadSeq>d__48 <LoadSeq>d__;
			<LoadSeq>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadSeq>d__.<>4__this = this;
			<LoadSeq>d__.path = path;
			<LoadSeq>d__.<>1__state = -1;
			<LoadSeq>d__.<>t__builder.Start<BattleLinkModel.<LoadSeq>d__48>(ref <LoadSeq>d__);
			return <LoadSeq>d__.<>t__builder.Task;
		}

		// Token: 0x0603BB1A RID: 244506 RVA: 0x00E40DCC File Offset: 0x00E3EFCC
		private UniTask LoadMesh(int roleId, int? modelId, string path, bool isWeapon = false, string weaponKey = "WeaponCase")
		{
			BattleLinkModel.<LoadMesh>d__49 <LoadMesh>d__;
			<LoadMesh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadMesh>d__.<>4__this = this;
			<LoadMesh>d__.roleId = roleId;
			<LoadMesh>d__.modelId = modelId;
			<LoadMesh>d__.path = path;
			<LoadMesh>d__.isWeapon = isWeapon;
			<LoadMesh>d__.weaponKey = weaponKey;
			<LoadMesh>d__.<>1__state = -1;
			<LoadMesh>d__.<>t__builder.Start<BattleLinkModel.<LoadMesh>d__49>(ref <LoadMesh>d__);
			return <LoadMesh>d__.<>t__builder.Task;
		}

		// Token: 0x0603BB1B RID: 244507 RVA: 0x00E40E3C File Offset: 0x00E3F03C
		public bool CheckSplitScreenRes()
		{
			if (!this.MainBp.HasValue)
			{
				Log.Instance.Warn(ELogModule.Battle, ELogAuthor.WWJ, "[BattleLink]播放分屏时资源没准备好: MainBp", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (!this.IsThreeRoleTeam && !this.IsTwoRoleTeam)
			{
				Log.Instance.Warn(ELogModule.Battle, ELogAuthor.WWJ, "[BattleLink]非三人或双人队伍, 播放分屏检查seq失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (this.IsThreeRoleTeam && this.ThreeRoleSeq == null)
			{
				Log.Instance.Warn(ELogModule.Battle, ELogAuthor.WWJ, "[BattleLink]播放分屏时资源没准备好: ThreeRoleSeq", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (this.IsTwoRoleTeam && this.TwoRoleSeq == null)
			{
				Log.Instance.Warn(ELogModule.Battle, ELogAuthor.WWJ, "[BattleLink]播放分屏时资源没准备好: TwoRoleSeq", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x0603BB1C RID: 244508 RVA: 0x00E40F00 File Offset: 0x00E3F100
		private void InitMainBp()
		{
			if (!this.MainBp.HasValue)
			{
				return;
			}
			this.InstanceId = CreatureModel.Instance.GetInstanceId();
			if (this.MainBp.IsT1)
			{
				BP_SplitScreen_C asT = this.MainBp.AsT1;
				asT.End();
				FHitResult fhitResult = new FHitResult();
				asT.D_K2_SetActorLocation(new FVectorDouble(0.0, 0.0, -3000.0), false, ref fhitResult, false);
				asT.SetActorHiddenInGame(true);
				return;
			}
			BP_SplitScreen_New_C asT2 = this.MainBp.AsT2;
			asT2.End();
			FHitResult fhitResult2 = new FHitResult();
			asT2.D_K2_SetActorLocation(new FVectorDouble(0.0, 0.0, -3000.0), false, ref fhitResult2, false);
			asT2.SetActorHiddenInGame(true);
		}

		// Token: 0x0603BB1D RID: 244509 RVA: 0x00E40FCC File Offset: 0x00E3F1CC
		public unsafe void ResetMainBp()
		{
			if (!this.MainBp.HasValue)
			{
				return;
			}
			List<UChildActorComponent> list2;
			if (this.MainBp.IsT1)
			{
				BP_SplitScreen_C asT = this.MainBp.AsT1;
				asT.Reset();
				if (this.IsThreeRoleTeam)
				{
					asT.E_LinkPos_1 = 0f;
					asT.E_LinkPos_2 = 0.5f;
					asT.E_LinkPos_3 = 1f;
				}
				else
				{
					asT.E_LinkPos_1 = 1f;
					asT.E_LinkPos_2 = 0f;
				}
				int num = 2;
				List<UChildActorComponent> list = new List<UChildActorComponent>(num);
				CollectionsMarshal.SetCount<UChildActorComponent>(list, num);
				Span<UChildActorComponent> span = CollectionsMarshal.AsSpan<UChildActorComponent>(list);
				int num2 = 0;
				*span[num2] = asT.CharacterActor_1;
				num2++;
				*span[num2] = asT.CharacterActor_2;
				list2 = list;
				if (this.IsThreeRoleTeam)
				{
					list2.Add(asT.CharacterActor_3);
				}
			}
			else
			{
				BP_SplitScreen_New_C asT2 = this.MainBp.AsT2;
				asT2.Reset();
				if (this.IsThreeRoleTeam)
				{
					asT2.E_LinkPos_1 = 0f;
					asT2.E_LinkPos_2 = 0.5f;
					asT2.E_LinkPos_3 = 1f;
				}
				else
				{
					asT2.E_LinkPos_1 = 1f;
					asT2.E_LinkPos_2 = 0f;
				}
				int num2 = 2;
				List<UChildActorComponent> list3 = new List<UChildActorComponent>(num2);
				CollectionsMarshal.SetCount<UChildActorComponent>(list3, num2);
				Span<UChildActorComponent> span = CollectionsMarshal.AsSpan<UChildActorComponent>(list3);
				int num = 0;
				*span[num] = asT2.CharacterActor_1;
				num++;
				*span[num] = asT2.CharacterActor_2;
				list2 = list3;
				if (this.IsThreeRoleTeam)
				{
					list2.Add(asT2.CharacterActor_3);
				}
			}
			for (int i = 0; i < list2.Count; i++)
			{
				if (i < this.RoleIdList.Count)
				{
					int roleId = this.RoleIdList[i];
					int currentModelId = this.GetCurrentModelId(roleId);
					BattleLinkModel.LinkRoleData linkRoleData = this.GetLinkRoleData(roleId, new int?(currentModelId));
					UClass classPtr = (linkRoleData != null) ? linkRoleData.SeqBpClass : null;
					UChildActorComponent uchildActorComponent = list2[i];
					if (uchildActorComponent != null)
					{
						uchildActorComponent.SetChildActorClass(classPtr);
					}
					object obj;
					if (uchildActorComponent == null)
					{
						obj = null;
					}
					else
					{
						AActor childActor = uchildActorComponent.ChildActor;
						obj = ((childActor != null) ? childActor.GetComponentByClass(USkeletalMeshComponent.StaticClass()) : null);
					}
					USkeletalMeshComponent uskeletalMeshComponent = obj as USkeletalMeshComponent;
					if (uskeletalMeshComponent != null)
					{
						USkeletalMesh uskeletalMesh = (linkRoleData != null) ? linkRoleData.Mesh : null;
						if (uskeletalMesh != null)
						{
							uskeletalMeshComponent.SetSkeletalMesh(uskeletalMesh, true);
						}
						Dictionary<string, USkeletalMesh> dictionary = (linkRoleData != null) ? linkRoleData.WeaponMeshMap : null;
						if (dictionary != null)
						{
							foreach (KeyValuePair<string, USkeletalMesh> keyValuePair in dictionary)
							{
								USkeletalMeshComponent uskeletalMeshComponent2 = null;
								TArray<UActorComponent> tarray;
								if (uchildActorComponent == null)
								{
									tarray = null;
								}
								else
								{
									AActor childActor2 = uchildActorComponent.ChildActor;
									tarray = ((childActor2 != null) ? childActor2.K2_GetComponentsByClass(UMeshComponent.StaticClass()) : null);
								}
								TArray<UActorComponent> tarray2 = tarray;
								if (tarray2 != null)
								{
									for (int j = 0; j < tarray2.Num(); j++)
									{
										USkeletalMeshComponent uskeletalMeshComponent3 = tarray2.Get(j) as USkeletalMeshComponent;
										if (uskeletalMeshComponent3 != null && uskeletalMeshComponent3.GetName() == keyValuePair.Key)
										{
											uskeletalMeshComponent2 = uskeletalMeshComponent3;
											break;
										}
									}
								}
								if (uskeletalMeshComponent2 != null)
								{
									uskeletalMeshComponent2.SetSkeletalMesh(keyValuePair.Value, true);
									uskeletalMeshComponent2.SetVisibility(true, false);
									uskeletalMeshComponent2.SetActive(true, false);
								}
							}
						}
					}
					BP_SplitScreenCharacterData_C bp_SplitScreenCharacterData_C = (linkRoleData != null) ? linkRoleData.DataAsset : null;
					if (bp_SplitScreenCharacterData_C != null)
					{
						this.SetMainBpProp(i, roleId, bp_SplitScreenCharacterData_C);
					}
				}
			}
		}

		// Token: 0x0603BB1E RID: 244510 RVA: 0x00E4133C File Offset: 0x00E3F53C
		private void SetMainBpProp(int index, int roleId, BP_SplitScreenCharacterData_C dataAsset)
		{
			if (!this.MainBp.HasValue)
			{
				return;
			}
			if (this.MainBp.IsT1)
			{
				BP_SplitScreen_C asT = this.MainBp.AsT1;
				switch (index)
				{
				case 0:
					asT.PointLight1_Location = dataAsset.PointLight_Location;
					asT.PointLight1_ToonLightColor = dataAsset.PointLight_Color;
					asT.EyeLightSimulation_Color1 = dataAsset.EyeLightSimulation_Color;
					return;
				case 1:
					asT.PointLight2_Location = dataAsset.PointLight_Location;
					asT.PointLight2_ToonLightColor = dataAsset.PointLight_Color;
					asT.EyeLightSimulation_Color2 = dataAsset.EyeLightSimulation_Color;
					return;
				case 2:
					asT.PointLight3_Location = dataAsset.PointLight_Location;
					asT.PointLight3_ToonLightColor = dataAsset.PointLight_Color;
					asT.EyeLightSimulation_Color3 = dataAsset.EyeLightSimulation_Color;
					return;
				default:
					return;
				}
			}
			else
			{
				BP_SplitScreen_New_C asT2 = this.MainBp.AsT2;
				switch (index)
				{
				case 0:
					asT2.PointLight1_Location = dataAsset.PointLight_Location;
					asT2.PointLight1_ToonLightColor = dataAsset.PointLight_Color;
					asT2.EyeLightSimulation_Color1 = dataAsset.EyeLightSimulation_Color;
					asT2.LightYaw1 = dataAsset.LightYaw;
					asT2.FaceLightYaw1 = dataAsset.FaceLightYaw;
					asT2.RoleId1 = roleId;
					return;
				case 1:
					asT2.PointLight2_Location = dataAsset.PointLight_Location;
					asT2.PointLight2_ToonLightColor = dataAsset.PointLight_Color;
					asT2.EyeLightSimulation_Color2 = dataAsset.EyeLightSimulation_Color;
					asT2.LightYaw2 = dataAsset.LightYaw;
					asT2.FaceLightYaw2 = dataAsset.FaceLightYaw;
					asT2.RoleId2 = roleId;
					return;
				case 2:
					asT2.PointLight3_Location = dataAsset.PointLight_Location;
					asT2.PointLight3_ToonLightColor = dataAsset.PointLight_Color;
					asT2.EyeLightSimulation_Color3 = dataAsset.EyeLightSimulation_Color;
					asT2.LightYaw3 = dataAsset.LightYaw;
					asT2.FaceLightYaw3 = dataAsset.FaceLightYaw;
					asT2.RoleId3 = roleId;
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x0603BB1F RID: 244511 RVA: 0x00E414E0 File Offset: 0x00E3F6E0
		private void SetRoleAnim(int roleId, UChildActorComponent childActorComp, bool isPreload)
		{
			AActor childActor = childActorComp.ChildActor;
			if (!childActor.IsValid())
			{
				return;
			}
			USkeletalMeshComponent uskeletalMeshComponent = childActor.GetComponentByClass(USkeletalMeshComponent.StaticClass()) as USkeletalMeshComponent;
			if (uskeletalMeshComponent == null)
			{
				return;
			}
			UAnimInstance uanimInstance = uskeletalMeshComponent.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_BASE) ?? uskeletalMeshComponent.GetAnimInstance();
			int currentModelId = this.GetCurrentModelId(roleId);
			BattleLinkModel.LinkRoleData linkRoleData = this.GetLinkRoleData(roleId, new int?(currentModelId));
			if (isPreload)
			{
				UAnimSequence asset = (linkRoleData != null) ? linkRoleData.Anim : null;
				UAnimMontage uanimMontage = (uanimInstance != null) ? uanimInstance.PlaySlotAnimationAsDynamicMontage(asset, SequenceDefine.ABP_Seq_Slot_Name, 0f, 0f, 1f, 1, -1f, 0f, true) : null;
				if (uanimMontage != null)
				{
					if (uanimInstance != null)
					{
						uanimInstance.Montage_Pause(uanimMontage);
					}
					if (linkRoleData != null)
					{
						linkRoleData.Montage = uanimMontage;
						return;
					}
				}
			}
			else
			{
				UAnimMontage uanimMontage2 = (linkRoleData != null) ? linkRoleData.Montage : null;
				if (uanimMontage2 != null)
				{
					if (uanimInstance != null)
					{
						uanimInstance.Montage_Resume(uanimMontage2);
					}
					linkRoleData.Montage = null;
				}
				Dictionary<string, UAnimSequence> dictionary = (linkRoleData != null) ? linkRoleData.WeaponAnimMap : null;
				if (dictionary != null)
				{
					foreach (KeyValuePair<string, UAnimSequence> keyValuePair in dictionary)
					{
						string text;
						UAnimSequence uanimSequence;
						keyValuePair.Deconstruct(out text, out uanimSequence);
						string b = text;
						UAnimSequence newAnimToPlay = uanimSequence;
						USkeletalMeshComponent uskeletalMeshComponent2 = null;
						TArray<UActorComponent> tarray = childActor.K2_GetComponentsByClass(UMeshComponent.StaticClass());
						for (int i = 0; i < tarray.Num(); i++)
						{
							USkeletalMeshComponent uskeletalMeshComponent3 = tarray.Get(i) as USkeletalMeshComponent;
							if (uskeletalMeshComponent3 != null && uskeletalMeshComponent3.GetName() == b)
							{
								uskeletalMeshComponent2 = uskeletalMeshComponent3;
								break;
							}
						}
						if (uskeletalMeshComponent2 != null)
						{
							uskeletalMeshComponent2.PlayAnimation(newAnimToPlay, false);
						}
					}
				}
			}
		}

		// Token: 0x0603BB20 RID: 244512 RVA: 0x00E416A4 File Offset: 0x00E3F8A4
		private bool IsRoleMorphing(int roleId)
		{
			foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItems(false))
			{
				if (roleId == RoleConfig.Instance.GetBaseRoleId(sceneTeamItem.GetConfigId))
				{
					EntityHandle entityHandle = sceneTeamItem.EntityHandle;
					object obj;
					if (entityHandle == null)
					{
						obj = null;
					}
					else
					{
						WorldEntity entity = entityHandle.Entity;
						obj = ((entity != null) ? entity.GetComponent<CharacterMorphComponent>() : null);
					}
					object obj2 = obj;
					return obj2 != null && obj2.IsMorphing();
				}
			}
			return false;
		}

		// Token: 0x0603BB21 RID: 244513 RVA: 0x00E41738 File Offset: 0x00E3F938
		public void PlayRoleAnim(bool isPreload = false)
		{
			if (!this.MainBp.HasValue)
			{
				return;
			}
			if (this.MainBp.IsT1)
			{
				BP_SplitScreen_C asT = this.MainBp.AsT1;
				this.SetRoleAnim(this.RoleIdList[0], asT.CharacterActor_1, isPreload);
				this.SetRoleAnim(this.RoleIdList[1], asT.CharacterActor_2, isPreload);
				if (this.IsThreeRoleTeam)
				{
					this.SetRoleAnim(this.RoleIdList[2], asT.CharacterActor_3, isPreload);
					return;
				}
			}
			else
			{
				BP_SplitScreen_New_C asT2 = this.MainBp.AsT2;
				this.SetRoleAnim(this.RoleIdList[0], asT2.CharacterActor_1, isPreload);
				this.SetRoleAnim(this.RoleIdList[1], asT2.CharacterActor_2, isPreload);
				if (this.IsThreeRoleTeam)
				{
					this.SetRoleAnim(this.RoleIdList[2], asT2.CharacterActor_3, isPreload);
				}
			}
		}

		// Token: 0x0603BB22 RID: 244514 RVA: 0x00E41820 File Offset: 0x00E3FA20
		public void PlayRoleLinkAudio()
		{
			RogueWhiteCat? activityConfig = DreamLinkConfig.Instance.GetActivityConfig(102600001);
			if (activityConfig != null)
			{
				RogueWhiteCat valueOrDefault = activityConfig.GetValueOrDefault();
				int firstWhiteCatDungeonId = valueOrDefault.FirstWhiteCatDungeonId;
				if (this.IsThreeRoleTeam && this.InstanceId == firstWhiteCatDungeonId)
				{
					bool flag = true;
					int[] source = valueOrDefault.PlotRoleLinkTeam();
					foreach (int value in this.RoleIdList)
					{
						flag = (flag && source.Contains(value));
					}
					if (flag)
					{
						string plotRoleLinkAudio = valueOrDefault.PlotRoleLinkAudio;
						AudioSystem.Instance.PostEvent(plotRoleLinkAudio);
						return;
					}
				}
				this.PlayCurrentRoleLinkAudio();
				return;
			}
		}

		// Token: 0x0603BB23 RID: 244515 RVA: 0x00E418E8 File Offset: 0x00E3FAE8
		private void PlayCurrentRoleLinkAudio()
		{
			if (this.PlayerRoleId < 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[BattleLink]播放Link语音时获取当前角色失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleId", this.PlayerRoleId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			int roleId = (this.OneRoleTeammateRoleId != 0) ? this.OneRoleTeammateRoleId : this.PlayerRoleId;
			LinkCharacter? linkCharacter;
			BattleLinkCharacter? battleLinkCharacter;
			this.GetRoleConfig(roleId, out linkCharacter, out battleLinkCharacter, true);
			if (linkCharacter == null && battleLinkCharacter == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Audio;
				ELogAuthor author2 = ELogAuthor.CWZ;
				string message2 = "[BattleLink]播放Link语音时获取当前角色配置失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("RoleId", this.PlayerRoleId);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			string @event = (linkCharacter != null) ? linkCharacter.Value.RoleLinkAudio : battleLinkCharacter.Value.RoleLinkAudio;
			AudioSystem.Instance.PostEvent(@event);
		}

		// Token: 0x0603BB24 RID: 244516 RVA: 0x00E419D0 File Offset: 0x00E3FBD0
		public void InitBeforeStart()
		{
			if (!this.MainBp.HasValue)
			{
				return;
			}
			if (this.MainBp.IsT2)
			{
				BP_SplitScreen_New_C asT = this.MainBp.AsT2;
				if (this.IsThreeRoleTeam)
				{
					asT.IsThree = true;
					asT.Width = 38f;
					return;
				}
				asT.IsThree = false;
				asT.Width = 28f;
			}
		}

		// Token: 0x0603BB25 RID: 244517 RVA: 0x00E41A31 File Offset: 0x00E3FC31
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public OneOf<BP_SplitScreen_C, BP_SplitScreen_New_C> GetSplitScreenMainBp()
		{
			return this.MainBp;
		}

		// Token: 0x0603BB26 RID: 244518 RVA: 0x00E41A39 File Offset: 0x00E3FC39
		[NullableContext(2)]
		public ULevelSequence GetSplitScreenSeq()
		{
			if (this.IsThreeRoleTeam)
			{
				return this.ThreeRoleSeq;
			}
			if (this.IsTwoRoleTeam)
			{
				return this.TwoRoleSeq;
			}
			return null;
		}

		// Token: 0x0603BB27 RID: 244519 RVA: 0x00E41A5C File Offset: 0x00E3FC5C
		public int GetLinkDuration()
		{
			if (this.LinkDuration != null)
			{
				return this.LinkDuration.Value;
			}
			this.LinkDuration = new int?(ConfigCommonParamById.GetIntConfig("LinkPrepareDuration").Value);
			return this.LinkDuration.Value;
		}

		// Token: 0x0603BB28 RID: 244520 RVA: 0x00E41AAA File Offset: 0x00E3FCAA
		public bool CheckInBattleLink()
		{
			return this.CheckInNewBattleLink() || this.CheckInDreamLink() || this.CheckInSpecialBattleLink();
		}

		// Token: 0x0603BB29 RID: 244521 RVA: 0x00E41AC4 File Offset: 0x00E3FCC4
		public bool CheckInNewBattleLink()
		{
			if (this.NewLinkGmTest && this.PreloadConfigId == 0)
			{
				return true;
			}
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			LinkParam? linkParam = BattleLinkConfig.Instance.GetLinkParam(1);
			return (config == null || config.GetValueOrDefault().InstSubType != 0) && (linkParam != null && linkParam.GetValueOrDefault().InstSubTypeList().Contains(config.Value.InstSubType));
		}

		// Token: 0x0603BB2A RID: 244522 RVA: 0x00E41B6C File Offset: 0x00E3FD6C
		public bool CheckInDreamLink()
		{
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			if (config != null && config.GetValueOrDefault().InstSubType == 23)
			{
				return true;
			}
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("LinkInstanceIds");
			return intArrayConfig != null && intArrayConfig.Contains(instanceId);
		}

		// Token: 0x0603BB2B RID: 244523 RVA: 0x00E41BDC File Offset: 0x00E3FDDC
		public bool CheckInSpecialBattleLink()
		{
			if (this.NewLinkGmTest && this.PreloadConfigId != 0)
			{
				return true;
			}
			if (!GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			LinkParam? linkParam = BattleLinkConfig.Instance.GetLinkParam(1);
			return (config == null || config.GetValueOrDefault().Id != 0) && (linkParam != null && linkParam.GetValueOrDefault().InstIdList().Contains(config.Value.Id));
		}

		// Token: 0x0603BB2C RID: 244524 RVA: 0x00E41C84 File Offset: 0x00E3FE84
		public string GetSpecialLinkEnergyButton()
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			LinkParam? linkParam = BattleLinkConfig.Instance.GetLinkParam(1);
			if (config != null && config.Value.Id != 0 && linkParam != null)
			{
				LinkParam valueOrDefault = linkParam.GetValueOrDefault();
				if (valueOrDefault.InstIdList().Contains(config.Value.Id))
				{
					return valueOrDefault.LinkEnergyButtonMap().GetValueOrDefault(config.Value.Id) ?? string.Empty;
				}
			}
			return string.Empty;
		}

		// Token: 0x0603BB2D RID: 244525 RVA: 0x00E41D29 File Offset: 0x00E3FF29
		public bool IsNewLinkGmTest()
		{
			return this.NewLinkGmTest;
		}

		// Token: 0x0603BB2E RID: 244526 RVA: 0x00E41D31 File Offset: 0x00E3FF31
		public void SetNewLinkGmTest(bool isGmTest)
		{
			this.NewLinkGmTest = isGmTest;
		}

		// Token: 0x0603BB2F RID: 244527 RVA: 0x00E41D3A File Offset: 0x00E3FF3A
		public ELinkStatus GetLinkStatus()
		{
			return this.LinkStatus;
		}

		// Token: 0x0603BB30 RID: 244528 RVA: 0x00E41D44 File Offset: 0x00E3FF44
		public bool CanUseLinkSkill(int? entityId = null)
		{
			if (this.LinkStatus != ELinkStatus.Ready && this.LinkStatus != ELinkStatus.Link)
			{
				return false;
			}
			if (this.IsLinkSkillInCd)
			{
				return false;
			}
			int? num = entityId;
			int? num2;
			if (num == null)
			{
				EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
				if (getCurrentEntity == null)
				{
					num2 = null;
				}
				else
				{
					WorldEntity entity = getCurrentEntity.Entity;
					num2 = ((entity != null) ? new int?(entity.Id) : null);
				}
			}
			else
			{
				num2 = num;
			}
			int? num3 = num2;
			return num3 != null && !this.HasLinkEntityId(num3.Value);
		}

		// Token: 0x0603BB31 RID: 244529 RVA: 0x00E41DD0 File Offset: 0x00E3FFD0
		public void ResetLinkSkillStatus()
		{
			this.SetLinkSkillInCd(false);
			this.LinkEntityIds = null;
		}

		// Token: 0x0603BB32 RID: 244530 RVA: 0x00E41DE0 File Offset: 0x00E3FFE0
		public void UpdateLinkStatus(ELinkStatus status, double? param = null)
		{
			this.LinkStatus = status;
			this.SetLinkSkillInCd(false);
			if (status == ELinkStatus.None)
			{
				this.LinkEntityIds = null;
				BattleLinkController.Instance.StopLink();
				BattleLinkController.Instance.SetMessageId(null);
			}
			else if (status == ELinkStatus.Ready)
			{
				this.LinkEntityIds = null;
			}
			else if (status == ELinkStatus.Link)
			{
				double startTime = param ?? Time.Instance.Now;
				BattleLinkController.Instance.StartLink(startTime);
			}
			else if (status == ELinkStatus.Explosion)
			{
				BattleLinkController.Instance.StartLinkExplosion();
			}
			EventSystem.Instance.Emit<ELinkStatus>(EEventName.OnBattleLinkStatusChanged, status);
		}

		// Token: 0x0603BB33 RID: 244531 RVA: 0x00E41E80 File Offset: 0x00E40080
		public void HandleLinkingStateNotify(LinkingStateNotify notify)
		{
			BattleLinkController.Instance.SetMessageId(new long?(notify.ContextId));
			if (notify.Step == 0)
			{
				this.UpdateLinkStatus(ELinkStatus.Ready, null);
				return;
			}
			if (!this.IsThreeRoleTeam && !this.IsTwoRoleTeam)
			{
				this.UpdateLinkStatus(ELinkStatus.None, null);
				return;
			}
			if ((this.IsThreeRoleTeam && notify.Step < 3) || (this.IsTwoRoleTeam && notify.Step < 2))
			{
				this.UpdateLinkStatus(ELinkStatus.Link, new double?((double)notify.TimeStamp));
				return;
			}
			this.UpdateLinkStatus(ELinkStatus.Explosion, null);
		}

		// Token: 0x0603BB34 RID: 244532 RVA: 0x00E41F24 File Offset: 0x00E40124
		public void HandleLinkExitNotify(LinkExitNotify notify)
		{
			this.UpdateLinkStatus(ELinkStatus.None, null);
		}

		// Token: 0x0603BB35 RID: 244533 RVA: 0x00E41F41 File Offset: 0x00E40141
		public void AddLinkEntityId(int entityId)
		{
			if (this.LinkEntityIds == null)
			{
				this.LinkEntityIds = new List<int>();
			}
			if (!this.LinkEntityIds.Contains(entityId))
			{
				this.LinkEntityIds.Add(entityId);
			}
			this.SetLinkSkillInCd(true);
		}

		// Token: 0x0603BB36 RID: 244534 RVA: 0x00E41F77 File Offset: 0x00E40177
		public bool HasLinkEntityId(int entityId)
		{
			List<int> linkEntityIds = this.LinkEntityIds;
			return linkEntityIds != null && linkEntityIds.Contains(entityId);
		}

		// Token: 0x0603BB37 RID: 244535 RVA: 0x00E41F91 File Offset: 0x00E40191
		public void SetLinkSkillInCd(bool isInCd)
		{
			if (this.IsLinkSkillInCd == isInCd)
			{
				return;
			}
			this.IsLinkSkillInCd = isInCd;
			BattleLinkController.Instance.SetPlayerUltraSkillEnable(!isInCd);
		}

		// Token: 0x0603BB38 RID: 244536 RVA: 0x00E41FB4 File Offset: 0x00E401B4
		public void HandleNewLinkStateNotify(NewLinkNotify notify, [Nullable(2)] CombatCommon combatCommon)
		{
			ENewLinkStatus enewLinkStatus = (ENewLinkStatus)notify.Current;
			if (this.NewLinkStatus == ENewLinkStatus.Burst && enewLinkStatus != ENewLinkStatus.Burst)
			{
				BattleLinkController.Instance.OnExitLinkBurst();
			}
			this.NewLinkStatus = enewLinkStatus;
			this.NewLinkId = notify.LinkId;
		}

		// Token: 0x0603BB39 RID: 244537 RVA: 0x00E41FF2 File Offset: 0x00E401F2
		public ENewLinkStatus GetNewLinkStatus()
		{
			return this.NewLinkStatus;
		}

		// Token: 0x0603BB3A RID: 244538 RVA: 0x00E41FFA File Offset: 0x00E401FA
		public LinkData? GetLinkConfig()
		{
			return BattleLinkConfig.Instance.GetLinkDataConfig(this.NewLinkId);
		}

		// Token: 0x0603BB3B RID: 244539 RVA: 0x00E4200C File Offset: 0x00E4020C
		private void GetRoleConfig(int roleId, out LinkCharacter? linkConfig, out BattleLinkCharacter? battleLinkCharacter, bool checkMorph = false)
		{
			if (this.CheckInNewBattleLink() || this.CheckInSpecialBattleLink())
			{
				Dictionary<int, int> modelIdMap = this.ModelIdMap;
				int id = (modelIdMap != null) ? modelIdMap.GetValueOrDefault(roleId) : 0;
				if (checkMorph)
				{
					id = this.GetCurrentModelId(roleId);
				}
				linkConfig = BattleLinkConfig.Instance.GetRoleConfig(id);
				battleLinkCharacter = null;
				return;
			}
			linkConfig = null;
			battleLinkCharacter = DreamLinkConfig.Instance.GetRoleConfig(roleId);
		}

		// Token: 0x0603BB3C RID: 244540 RVA: 0x00E4207C File Offset: 0x00E4027C
		private LinkCharacter? GetMorphRoleConfig(int roleId)
		{
			Dictionary<int, int> morphModelIdMap = this.MorphModelIdMap;
			int id = (morphModelIdMap != null) ? morphModelIdMap.GetValueOrDefault(roleId) : 0;
			return BattleLinkConfig.Instance.GetRoleConfig(id);
		}

		// Token: 0x0603BB3D RID: 244541 RVA: 0x00E420A8 File Offset: 0x00E402A8
		[NullableContext(2)]
		private BattleLinkModel.LinkRoleData GetLinkRoleData(int roleId, int? modelId = null)
		{
			if (modelId != null)
			{
				int? num = modelId;
				int num2 = 0;
				if (!(num.GetValueOrDefault() == num2 & num != null))
				{
					Dictionary<int, int> morphModelIdMap = this.MorphModelIdMap;
					int num3 = (morphModelIdMap != null) ? morphModelIdMap.GetValueOrDefault(roleId) : 0;
					num = modelId;
					if (num3 == num.GetValueOrDefault() & num != null)
					{
						Dictionary<int, BattleLinkModel.LinkRoleMorphData> linkRoleMorphDataMap = this.LinkRoleMorphDataMap;
						if (linkRoleMorphDataMap == null)
						{
							return null;
						}
						BattleLinkModel.LinkRoleMorphData valueOrDefault = linkRoleMorphDataMap.GetValueOrDefault(roleId);
						if (valueOrDefault == null)
						{
							return null;
						}
						return valueOrDefault.LinkRoleData;
					}
				}
			}
			Dictionary<int, BattleLinkModel.LinkRoleData> linkRoleDataMap = this.LinkRoleDataMap;
			if (linkRoleDataMap == null)
			{
				return null;
			}
			return linkRoleDataMap.GetValueOrDefault(roleId);
		}

		// Token: 0x0603BB3E RID: 244542 RVA: 0x00E4212E File Offset: 0x00E4032E
		private int GetCurrentModelId(int roleId)
		{
			Dictionary<int, int> morphModelIdMap = this.MorphModelIdMap;
			if (morphModelIdMap != null && morphModelIdMap.ContainsKey(roleId) && this.IsRoleMorphing(roleId))
			{
				return this.MorphModelIdMap[roleId];
			}
			Dictionary<int, int> modelIdMap = this.ModelIdMap;
			if (modelIdMap == null)
			{
				return 0;
			}
			return modelIdMap.GetValueOrDefault(roleId);
		}

		// Token: 0x17008DB8 RID: 36280
		// (get) Token: 0x0603BB3F RID: 244543 RVA: 0x00E4216D File Offset: 0x00E4036D
		public static BattleLinkModel Instance
		{
			get
			{
				return BattleLinkModel._Instance;
			}
		}

		// Token: 0x0603BB40 RID: 244544 RVA: 0x00E42174 File Offset: 0x00E40374
		public static BattleLinkModel GetOrCreateInstance()
		{
			if (BattleLinkModel._Instance == null)
			{
				BattleLinkModel.CreateInstance();
			}
			return BattleLinkModel._Instance;
		}

		// Token: 0x0603BB41 RID: 244545 RVA: 0x00E42188 File Offset: 0x00E40388
		public static bool CreateInstance()
		{
			if (BattleLinkModel._Instance != null)
			{
				return true;
			}
			BattleLinkModel._Instance = new BattleLinkModel();
			return true;
		}

		// Token: 0x0603BB42 RID: 244546 RVA: 0x00E4219E File Offset: 0x00E4039E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BB43 RID: 244547 RVA: 0x00E421A0 File Offset: 0x00E403A0
		public static void ResetStaticDefaultValue()
		{
			BattleLinkModel._Instance = null;
		}

		// Token: 0x0603BB44 RID: 244548 RVA: 0x00E421A8 File Offset: 0x00E403A8
		static BattleLinkModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BattleLinkModel.CreateStaticDefaultValue), new Action(BattleLinkModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401F13E RID: 127294
		private const int THREE_ROLE = 3;

		// Token: 0x0401F13F RID: 127295
		private const int TWO_ROLE = 2;

		// Token: 0x0401F140 RID: 127296
		private const int ACTIVITY_ID = 102600001;

		// Token: 0x0401F141 RID: 127297
		private const int LINK_COMMON_PARAM_ROW = 1;

		// Token: 0x0401F142 RID: 127298
		private const string DEFAULT_COMP_NAME = "WeaponCase";

		// Token: 0x0401F143 RID: 127299
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private OneOf<BP_SplitScreen_C, BP_SplitScreen_New_C> MainBp;

		// Token: 0x0401F144 RID: 127300
		[Nullable(2)]
		private ULevelSequence ThreeRoleSeq;

		// Token: 0x0401F145 RID: 127301
		[Nullable(2)]
		private ULevelSequence TwoRoleSeq;

		// Token: 0x0401F146 RID: 127302
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, BattleLinkModel.LinkRoleData> LinkRoleDataMap;

		// Token: 0x0401F147 RID: 127303
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, BattleLinkModel.LinkRoleMorphData> LinkRoleMorphDataMap;

		// Token: 0x0401F148 RID: 127304
		private int InstanceId = -1;

		// Token: 0x0401F149 RID: 127305
		private int PlayerRoleId = -1;

		// Token: 0x0401F14A RID: 127306
		[Nullable(2)]
		private List<int> RoleIdList;

		// Token: 0x0401F14B RID: 127307
		private bool IsThreeRoleTeam;

		// Token: 0x0401F14C RID: 127308
		private bool IsTwoRoleTeam;

		// Token: 0x0401F14D RID: 127309
		private int OneRoleTeammateRoleId;

		// Token: 0x0401F14E RID: 127310
		[Nullable(2)]
		private List<int> LinkEntityIds;

		// Token: 0x0401F14F RID: 127311
		private int? LinkDuration;

		// Token: 0x0401F150 RID: 127312
		private bool IsLinkSkillInCd;

		// Token: 0x0401F151 RID: 127313
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, List<int>> PreloadRoleIdsMap;

		// Token: 0x0401F152 RID: 127314
		[Nullable(2)]
		private List<int> PreloadRoleIds;

		// Token: 0x0401F153 RID: 127315
		[Nullable(2)]
		private Dictionary<int, int> ModelIdMap;

		// Token: 0x0401F154 RID: 127316
		[Nullable(2)]
		private Dictionary<int, int> MorphModelIdMap;

		// Token: 0x0401F155 RID: 127317
		[Nullable(2)]
		private List<UniTask> LoadCharacterPromises;

		// Token: 0x0401F156 RID: 127318
		private int PreloadConfigId;

		// Token: 0x0401F157 RID: 127319
		public bool NewLinkGmTest;

		// Token: 0x0401F158 RID: 127320
		private ELinkStatus LinkStatus;

		// Token: 0x0401F159 RID: 127321
		private ENewLinkStatus NewLinkStatus;

		// Token: 0x0401F15A RID: 127322
		private int NewLinkId;

		// Token: 0x0401F15B RID: 127323
		[Nullable(2)]
		private static BattleLinkModel _Instance;

		// Token: 0x0200BE48 RID: 48712
		[NullableContext(0)]
		private enum ELinkTriggerStep
		{
			// Token: 0x04039619 RID: 235033
			Start,
			// Token: 0x0403961A RID: 235034
			Role1End,
			// Token: 0x0403961B RID: 235035
			Role2End,
			// Token: 0x0403961C RID: 235036
			Role3End
		}

		// Token: 0x0200BE49 RID: 48713
		[NullableContext(2)]
		[Nullable(0)]
		public class LinkRoleData
		{
			// Token: 0x0403961D RID: 235037
			public int RoleId;

			// Token: 0x0403961E RID: 235038
			public UClass SeqBpClass;

			// Token: 0x0403961F RID: 235039
			public UAnimSequence Anim;

			// Token: 0x04039620 RID: 235040
			public USkeletalMesh Mesh;

			// Token: 0x04039621 RID: 235041
			public UAnimMontage Montage;

			// Token: 0x04039622 RID: 235042
			public BP_SplitScreenCharacterData_C DataAsset;

			// Token: 0x04039623 RID: 235043
			[Nullable(new byte[]
			{
				2,
				1,
				1
			})]
			public Dictionary<string, UAnimSequence> WeaponAnimMap;

			// Token: 0x04039624 RID: 235044
			[Nullable(new byte[]
			{
				2,
				1,
				1
			})]
			public Dictionary<string, USkeletalMesh> WeaponMeshMap;
		}

		// Token: 0x0200BE4A RID: 48714
		[NullableContext(0)]
		public class LinkRoleMorphData
		{
			// Token: 0x04039625 RID: 235045
			public int RoleId;

			// Token: 0x04039626 RID: 235046
			[Nullable(2)]
			public BattleLinkModel.LinkRoleData LinkRoleData;
		}

		// Token: 0x0200BE4B RID: 48715
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04039627 RID: 235047
			[Nullable(0)]
			public static Func<string, int> <0>__Parse;
		}
	}
}
