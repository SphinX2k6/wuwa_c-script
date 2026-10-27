using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D54 RID: 19796
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopSelectTargetView : UiViewBase
	{
		// Token: 0x0603326B RID: 209515 RVA: 0x00BEDDF8 File Offset: 0x00BEBFF8
		public RoleDevelopSelectTargetView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603326C RID: 209516 RVA: 0x00BEDE18 File Offset: 0x00BEC018
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603326D RID: 209517 RVA: 0x00BEE038 File Offset: 0x00BEC238
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopSelectTargetView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopSelectTargetView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603326E RID: 209518 RVA: 0x00BEE07C File Offset: 0x00BEC27C
		protected override void OnStart()
		{
			this.WeaponQualityThreshold = RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.WeaponQualityThreshold;
			this.PhantomNumThreshold = RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.PhantomNumThreshold;
			this.PhantomQualityThreshold = RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.PhantomQualityThreshold;
			this.PhantomLevelThreshold = RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.PhantomLevelThreshold;
			this.RefreshRoleGridLayout();
			this.RefreshHotRoleGridLayout();
			EventSystem.Instance.Add(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
		}

		// Token: 0x0603326F RID: 209519 RVA: 0x00BEE131 File Offset: 0x00BEC331
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
		}

		// Token: 0x06033270 RID: 209520 RVA: 0x00BEE150 File Offset: 0x00BEC350
		private void InitData()
		{
			this.RoleDevelopDataList = RoleDevelopModel.Instance.GetNormalRoleDevelopData();
			List<RoleDevelopData> allHotRoleDevelopData = RoleDevelopModel.Instance.GetAllHotRoleDevelopData(false);
			RoleDevelopSelectTargetViewData roleDevelopSelectTargetViewData = this.OpenParam as RoleDevelopSelectTargetViewData;
			int? roleId = (roleDevelopSelectTargetViewData != null) ? roleDevelopSelectTargetViewData.RoleId : null;
			if (roleId != null && roleId.GetValueOrDefault() != 0)
			{
				this.CurSelectRoleDevelopData = (this.RoleDevelopDataList.Find((RoleDevelopData d) => d.GetId() == roleId.Value) ?? allHotRoleDevelopData.Find((RoleDevelopData d) => d.GetId() == roleId.Value));
			}
		}

		// Token: 0x06033271 RID: 209521 RVA: 0x00BEE1F4 File Offset: 0x00BEC3F4
		private void RefreshRoleGridLayout()
		{
			List<RoleDevelopData> roleDevelopDataList = this.RoleDevelopDataList;
			if (this.RoleDataList.Count <= 0)
			{
				foreach (RoleDevelopData roleDevelopData in roleDevelopDataList)
				{
					int id = roleDevelopData.GetId();
					RoleInstance roleInstance = RoleModel.Instance.GetRoleInstanceById(id);
					if (roleInstance == null)
					{
						roleInstance = new RoleInstance(id);
					}
					this.RoleDataList.Add(roleInstance);
				}
				this.FilterSortEntrance.UpdateData(EFilterSortGroupId.RoleDev, this.RoleDataList, Array.Empty<object>());
				return;
			}
			this.RoleLayout.RefreshByData(this.RoleDevelopDataList, new Action(this.OnRoleGridLayoutRefresh), true);
		}

		// Token: 0x06033272 RID: 209522 RVA: 0x00BEE2B0 File Offset: 0x00BEC4B0
		private void OnUpdateSortList(List<RoleDataBase> dataList, bool isOutSideChange, EFilterSortType operationType)
		{
			this.RoleDataList = dataList;
			Dictionary<int, int> orderMap = new Dictionary<int, int>();
			for (int i = 0; i < dataList.Count; i++)
			{
				orderMap[dataList[i].GetRoleId()] = i;
			}
			int targetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			this.RoleDevelopDataList.Sort(delegate(RoleDevelopData a, RoleDevelopData b)
			{
				int id = a.GetId();
				int id2 = b.GetId();
				if (targetRoleId > 0)
				{
					if (id == targetRoleId)
					{
						return -1;
					}
					if (id2 == targetRoleId)
					{
						return 1;
					}
				}
				int num = orderMap.ContainsKey(id) ? orderMap[id] : int.MaxValue;
				int num2 = orderMap.ContainsKey(id2) ? orderMap[id2] : int.MaxValue;
				return num - num2;
			});
			base.GetScrollViewWithScrollbar(14).SetScrollProgress(0f);
			this.RoleLayout.RefreshByData(this.RoleDevelopDataList, new Action(this.OnRoleGridLayoutRefresh), true);
		}

		// Token: 0x06033273 RID: 209523 RVA: 0x00BEE358 File Offset: 0x00BEC558
		private void RefreshHotRoleGridLayout()
		{
			List<RoleDevelopData> allHotRoleDevelopData = RoleDevelopModel.Instance.GetAllHotRoleDevelopData(true);
			if (allHotRoleDevelopData.Count <= 0)
			{
				this.HotRoleLayout.SetActive(false);
				return;
			}
			this.HotRoleLayout.SetActive(true);
			this.HotRoleLayout.RefreshByData(allHotRoleDevelopData, new Action(this.OnHotRoleGridLayoutRefresh), true);
		}

		// Token: 0x06033274 RID: 209524 RVA: 0x00BEE3AC File Offset: 0x00BEC5AC
		private void RefreshRoleView()
		{
			RoleDevelopRoleBaseData developRoleData = this.CurSelectRoleDevelopData.GetDevelopRoleData();
			base.SetTextureShowUntilLoaded(developRoleData.GetRoleIllustrationPath(), base.GetTexture(5), null);
			base.GetText(8).SetText(developRoleData.GetName(), true);
			ERoleDevelopHotRoleTag hotRoleTag = this.CurSelectRoleDevelopData.GetHotRoleTag();
			this.RoleDevelopTagItem.RefreshByData(hotRoleTag);
			int elementId = developRoleData.GetElementId();
			ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(elementId);
			UUITexture texture = base.GetTexture(7);
			UUITexture texture2 = base.GetTexture(6);
			UUIText text = base.GetText(10);
			if (elementConfig != null)
			{
				base.SetElementIcon(elementConfig.Value.Icon2, texture, elementId, null);
				base.SetElementIcon(elementConfig.Value.Icon2, texture2, elementId, null);
				texture.SetColor(FColor.FromHex(elementConfig.Value.ElementColor));
				texture.SetUIActive(true);
				texture2.SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(text, elementConfig.Value.Name, Array.Empty<object>());
				text.SetUIActive(true);
			}
			else
			{
				texture.SetUIActive(false);
				texture2.SetUIActive(false);
				text.SetUIActive(false);
			}
			this.ConditionLayout.RefreshByData(this.GetConditionItemDataList(), null, false);
			string textId = (RoleDevelopModel.Instance.DevTargetRoleId == this.CurSelectRoleDevelopData.GetId()) ? "RoleProject_CancelRoleButton" : "RoleProject_ConfirmRoleButton";
			this.ConfirmButton.SetLocalTextNew(textId, Array.Empty<object>());
		}

		// Token: 0x06033275 RID: 209525 RVA: 0x00BEE540 File Offset: 0x00BEC740
		private List<RoleDevelopSelectTargetHintItemData> GetConditionItemDataList()
		{
			RoleDevelopData curSelectRoleDevelopData = this.CurSelectRoleDevelopData;
			if (curSelectRoleDevelopData == null)
			{
				return new List<RoleDevelopSelectTargetHintItemData>();
			}
			int id = curSelectRoleDevelopData.GetId();
			int num = RoleModel.Instance.IsRoleOwned(id) ? 1 : 0;
			bool flag = RoleDevelopUtil.IsAnyProspectRole(id);
			RoleDevelopProjectBaseData projectData = curSelectRoleDevelopData.GetProjectData();
			if (num == 0 || flag)
			{
				List<RoleDevelopSelectTargetHintItemData> result = new List<RoleDevelopSelectTargetHintItemData>();
				this.AddMaterialHint(projectData, flag, result);
				return result;
			}
			RoleDevelopRoleBaseData developRoleData = curSelectRoleDevelopData.GetDevelopRoleData();
			List<RoleDevelopSelectTargetHintItemData> result2 = new List<RoleDevelopSelectTargetHintItemData>();
			bool flag2 = this.CheckRoleCondition(developRoleData, result2);
			bool flag3 = this.CheckWeaponCondition(developRoleData, result2);
			bool flag4 = this.CheckPhantomCondition(id, result2);
			bool flag5 = this.CheckSkillCondition(id, projectData, result2);
			if (flag2 && flag3 && flag4 && flag5)
			{
				return new List<RoleDevelopSelectTargetHintItemData>
				{
					new RoleDevelopSelectTargetHintItemData
					{
						IconKey = "T_RoleDevelopTag1",
						DescKey = "RoleProject_ChoseRole_FinishTips"
					}
				};
			}
			this.AddMaterialHint(projectData, false, result2);
			return result2;
		}

		// Token: 0x06033276 RID: 209526 RVA: 0x00BEE614 File Offset: 0x00BEC814
		private bool CheckRoleCondition(RoleDevelopRoleBaseData developRoleData, List<RoleDevelopSelectTargetHintItemData> result)
		{
			int roleLevel = developRoleData.GetRoleLevel();
			int roleTargetLevel = developRoleData.GetRoleTargetLevel();
			if (roleLevel < roleTargetLevel)
			{
				result.Add(new RoleDevelopSelectTargetHintItemData
				{
					IconKey = "T_RoleDevelopTag3",
					DescKey = "RoleProject_ChoseRole_RoleTips01"
				});
				return false;
			}
			return true;
		}

		// Token: 0x06033277 RID: 209527 RVA: 0x00BEE658 File Offset: 0x00BEC858
		private bool CheckWeaponCondition(RoleDevelopRoleBaseData developRoleData, List<RoleDevelopSelectTargetHintItemData> result)
		{
			WeaponInstance weaponInstance = developRoleData.GetWeaponInstance();
			if (weaponInstance == null || weaponInstance.GetItemConfig().QualityId < this.WeaponQualityThreshold)
			{
				result.Add(new RoleDevelopSelectTargetHintItemData
				{
					IconKey = "T_RoleDevelopTag2",
					DescKey = "RoleProject_ChoseRole_WeaponTips01"
				});
				return false;
			}
			int weaponLevel = developRoleData.GetWeaponLevel();
			int weaponTargetLevel = developRoleData.GetWeaponTargetLevel();
			if (weaponLevel < weaponTargetLevel)
			{
				result.Add(new RoleDevelopSelectTargetHintItemData
				{
					IconKey = "T_RoleDevelopTag3",
					DescKey = "RoleProject_ChoseRole_WeaponTips02"
				});
				return false;
			}
			return true;
		}

		// Token: 0x06033278 RID: 209528 RVA: 0x00BEE6DC File Offset: 0x00BEC8DC
		private bool CheckPhantomCondition(int roleId, List<RoleDevelopSelectTargetHintItemData> result)
		{
			List<int> incrIdList = PhantomBattleModel.Instance.GetBattleDataById(roleId).GetIncrIdList();
			int num = (this.PhantomNumThreshold > 0) ? this.PhantomNumThreshold : incrIdList.Count;
			List<PhantomBattleData> list = new List<PhantomBattleData>();
			foreach (int num2 in incrIdList)
			{
				if (num2 > 0)
				{
					PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(num2);
					if (phantomBattleData != null)
					{
						list.Add(phantomBattleData);
					}
				}
			}
			if (list.Count < num)
			{
				result.Add(new RoleDevelopSelectTargetHintItemData
				{
					IconKey = "T_RoleDevelopTag2",
					DescKey = "RoleProject_ChoseRole_PhantomTips01"
				});
				return false;
			}
			if (this.GetFetterTriggerCount(list) < 5)
			{
				result.Add(new RoleDevelopSelectTargetHintItemData
				{
					IconKey = "T_RoleDevelopTag2",
					DescKey = "RoleProject_ChoseRole_PhantomTips01"
				});
				return false;
			}
			using (List<PhantomBattleData>.Enumerator enumerator2 = list.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetQuality() < this.PhantomQualityThreshold)
					{
						result.Add(new RoleDevelopSelectTargetHintItemData
						{
							IconKey = "T_RoleDevelopTag2",
							DescKey = "RoleProject_ChoseRole_PhantomTips02"
						});
						return false;
					}
				}
			}
			foreach (PhantomBattleData phantomBattleData2 in list)
			{
				int num3 = (this.PhantomLevelThreshold > 0) ? this.PhantomLevelThreshold : phantomBattleData2.GetLevelLimit();
				if (phantomBattleData2.GetPhantomLevel() < num3)
				{
					result.Add(new RoleDevelopSelectTargetHintItemData
					{
						IconKey = "T_RoleDevelopTag2",
						DescKey = "RoleProject_ChoseRole_PhantomTips03"
					});
					return false;
				}
			}
			foreach (PhantomBattleData phantomBattleData3 in list)
			{
				if (phantomBattleData3.GetIfHaveUnIdentifySubProp() || phantomBattleData3.GetIfHaveLockSubProp())
				{
					result.Add(new RoleDevelopSelectTargetHintItemData
					{
						IconKey = "T_RoleDevelopTag2",
						DescKey = "RoleProject_ChoseRole_PhantomTips04"
					});
					return false;
				}
			}
			return true;
		}

		// Token: 0x06033279 RID: 209529 RVA: 0x00BEE930 File Offset: 0x00BECB30
		private int GetFetterTriggerCount(List<PhantomBattleData> phantomDataList)
		{
			Dictionary<int, int> dictionary = PhantomDataBase.CalculateFetterByPhantomBattleData(new List<PhantomDataBase>(phantomDataList));
			if (dictionary == null)
			{
				return 0;
			}
			int num = 0;
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int num2;
				int num3;
				keyValuePair.Deconstruct(out num2, out num3);
				int groupId = num2;
				int num4 = num3;
				Dictionary<int, int> fetterGroupFetterDataById = PhantomBattleConfig.Instance.GetFetterGroupFetterDataById(groupId);
				if (fetterGroupFetterDataById != null)
				{
					int num5 = 0;
					foreach (int num6 in fetterGroupFetterDataById.Keys)
					{
						if (num6 <= num4 && num6 > num5)
						{
							num5 = num6;
						}
					}
					num += num5;
				}
			}
			return num;
		}

		// Token: 0x0603327A RID: 209530 RVA: 0x00BEEA08 File Offset: 0x00BECC08
		private bool CheckSkillCondition(int roleId, RoleDevelopProjectBaseData projectData, List<RoleDevelopSelectTargetHintItemData> result)
		{
			if (!projectData.IsSkillPlanFinished())
			{
				result.Add(new RoleDevelopSelectTargetHintItemData
				{
					IconKey = "T_RoleDevelopTag3",
					DescKey = "RoleProject_ChoseRole_SkillTips01"
				});
				return false;
			}
			return true;
		}

		// Token: 0x0603327B RID: 209531 RVA: 0x00BEEA38 File Offset: 0x00BECC38
		private void AddMaterialHint(RoleDevelopProjectBaseData projectData, bool isProspect, List<RoleDevelopSelectTargetHintItemData> result)
		{
			List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
			list.AddRange(projectData.GetRoleUpgradeNeedItems());
			list.AddRange(projectData.GetRoleBreachNeedItems());
			list.AddRange(projectData.GetWeaponUpgradeNeedItems());
			list.AddRange(projectData.GetWeaponBreachNeedItems());
			list.AddRange(projectData.GetSkillPlanNeedItems());
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (RoleDevelopNeedItem roleDevelopNeedItem in list)
			{
				int num;
				dictionary.TryGetValue(roleDevelopNeedItem.ItemId, out num);
				dictionary[roleDevelopNeedItem.ItemId] = num + roleDevelopNeedItem.Count;
			}
			List<RoleDevelopNeedItem> list2 = new List<RoleDevelopNeedItem>();
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int num2;
				int num3;
				keyValuePair.Deconstruct(out num2, out num3);
				int itemId = num2;
				int count = num3;
				list2.Add(new RoleDevelopNeedItem
				{
					ItemId = itemId,
					Count = count
				});
			}
			List<RoleDevelopNeedItem> needItems = list2;
			if (isProspect)
			{
				int unknownItemId = RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.UnknownItemId;
				needItems = list2.FindAll((RoleDevelopNeedItem item) => item.ItemId != unknownItemId);
			}
			if (RoleDevelopUtil.CheckIsAllNeedItemsEnough(needItems))
			{
				result.Add(new RoleDevelopSelectTargetHintItemData
				{
					IconKey = "T_RoleDevelopTag1",
					DescKey = "RoleProject_ChoseRole_ItemTips02"
				});
				return;
			}
			result.Add(new RoleDevelopSelectTargetHintItemData
			{
				IconKey = "T_RoleDevelopTag2",
				DescKey = "RoleProject_ChoseRole_ItemTips01"
			});
		}

		// Token: 0x0603327C RID: 209532 RVA: 0x00BEEBE8 File Offset: 0x00BECDE8
		private void OnHotRoleGridItemSelected(RoleDevelopData data)
		{
			this.RoleLayout.DeselectCurrentGridProxy();
			this.HotRoleLayout.DeselectCurrentGridProxy();
			this.HotRoleLayout.SelectGridProxyByKey(data.GetId(), false);
			this.CurSelectRoleDevelopData = data;
			this.IsSelectedFromHotRole = true;
			this.RefreshRoleView();
		}

		// Token: 0x0603327D RID: 209533 RVA: 0x00BEEC38 File Offset: 0x00BECE38
		private void OnRoleGridItemSelected(RoleDevelopData data)
		{
			this.RoleLayout.DeselectCurrentGridProxy();
			this.HotRoleLayout.DeselectCurrentGridProxy();
			this.RoleLayout.SelectGridProxyByKey(data.GetId(), false);
			this.CurSelectRoleDevelopData = data;
			this.IsSelectedFromHotRole = false;
			this.RefreshRoleView();
		}

		// Token: 0x0603327E RID: 209534 RVA: 0x00BEEC88 File Offset: 0x00BECE88
		private void OnClickConfirmButton(int value)
		{
			int id = this.CurSelectRoleDevelopData.GetId();
			int num = (RoleDevelopModel.Instance.DevTargetRoleId == id) ? 0 : id;
			RoleDevelopSelectTargetViewData roleDevelopSelectTargetViewData = this.OpenParam as RoleDevelopSelectTargetViewData;
			ERoleDevelopUpdateTargetSource source = (roleDevelopSelectTargetViewData != null) ? roleDevelopSelectTargetViewData.Source : ERoleDevelopUpdateTargetSource.Detection;
			RoleController.Instance.RequestUpdateDevelopTarget(num, source, null, null);
			if (num != 0)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x0603327F RID: 209535 RVA: 0x00BEECF3 File Offset: 0x00BECEF3
		private void OnCloseButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06033280 RID: 209536 RVA: 0x00BEECFC File Offset: 0x00BECEFC
		private RoleDevelopHotRoleGridItem CreateHotRoleGridItem()
		{
			RoleDevelopHotRoleGridItem roleDevelopHotRoleGridItem = new RoleDevelopHotRoleGridItem();
			roleDevelopHotRoleGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnHotRoleGridItemToggleChanged));
			roleDevelopHotRoleGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnHotRoleGridItemCanExecuteChange));
			return roleDevelopHotRoleGridItem;
		}

		// Token: 0x06033281 RID: 209537 RVA: 0x00BEED27 File Offset: 0x00BECF27
		private RoleDevelopGridItem CreateRoleGridItem()
		{
			RoleDevelopGridItem roleDevelopGridItem = new RoleDevelopGridItem();
			roleDevelopGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnRoleGridItemToggleChanged));
			roleDevelopGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnRoleGridItemCanExecuteChange));
			return roleDevelopGridItem;
		}

		// Token: 0x06033282 RID: 209538 RVA: 0x00BEED52 File Offset: 0x00BECF52
		private RoleDevelopSelectTargetHintItem CreateConditionItem()
		{
			return new RoleDevelopSelectTargetHintItem();
		}

		// Token: 0x06033283 RID: 209539 RVA: 0x00BEED59 File Offset: 0x00BECF59
		private bool IsNormalRole(int roleId)
		{
			return !RoleDevelopUtil.IsAnyProspectRole(roleId);
		}

		// Token: 0x06033284 RID: 209540 RVA: 0x00BEED64 File Offset: 0x00BECF64
		private void OnRoleGridLayoutRefresh()
		{
			if (this.CurSelectRoleDevelopData == null)
			{
				this.CurSelectRoleDevelopData = this.RoleDevelopDataList[0];
			}
			int id = this.CurSelectRoleDevelopData.GetId();
			if (!this.IsNormalRole(id))
			{
				return;
			}
			this.RoleLayout.SelectGridProxyByKey(id, false);
			this.OnRoleGridItemSelected(this.CurSelectRoleDevelopData);
		}

		// Token: 0x06033285 RID: 209541 RVA: 0x00BEEDC0 File Offset: 0x00BECFC0
		private void OnHotRoleGridLayoutRefresh()
		{
			int id = this.CurSelectRoleDevelopData.GetId();
			if (this.IsNormalRole(id))
			{
				return;
			}
			this.HotRoleLayout.SelectGridProxyByKey(id, false);
			this.OnHotRoleGridItemSelected(this.CurSelectRoleDevelopData);
		}

		// Token: 0x06033286 RID: 209542 RVA: 0x00BEEE04 File Offset: 0x00BED004
		private void OnHotRoleGridItemToggleChanged(MediumItemGridExtendCallback callbackParameter)
		{
			this.OnHotRoleGridItemSelected((RoleDevelopData)callbackParameter.Data);
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x06033287 RID: 209543 RVA: 0x00BEEE38 File Offset: 0x00BED038
		private bool OnHotRoleGridItemCanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			if (!this.IsSelectedFromHotRole)
			{
				return true;
			}
			int id = ((RoleDevelopData)data).GetId();
			RoleDevelopData curSelectRoleDevelopData = this.CurSelectRoleDevelopData;
			int? num = (curSelectRoleDevelopData != null) ? new int?(curSelectRoleDevelopData.GetId()) : null;
			return !(id == num.GetValueOrDefault() & num != null);
		}

		// Token: 0x06033288 RID: 209544 RVA: 0x00BEEE90 File Offset: 0x00BED090
		private void OnRoleGridItemToggleChanged(MediumItemGridExtendCallback callbackParameter)
		{
			this.OnRoleGridItemSelected((RoleDevelopData)callbackParameter.Data);
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x06033289 RID: 209545 RVA: 0x00BEEEC4 File Offset: 0x00BED0C4
		private bool OnRoleGridItemCanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			if (this.IsSelectedFromHotRole)
			{
				return true;
			}
			int id = ((RoleDevelopData)data).GetId();
			RoleDevelopData curSelectRoleDevelopData = this.CurSelectRoleDevelopData;
			int? num = (curSelectRoleDevelopData != null) ? new int?(curSelectRoleDevelopData.GetId()) : null;
			return !(id == num.GetValueOrDefault() & num != null);
		}

		// Token: 0x0603328A RID: 209546 RVA: 0x00BEEF1A File Offset: 0x00BED11A
		private void OnRoleDevTargetRoleIdChange()
		{
			if (RoleDevelopModel.Instance.DevTargetRoleId != 0)
			{
				return;
			}
			this.HotRoleLayout.RefreshWithoutDataSync();
			this.RoleLayout.RefreshWithoutDataSync();
			this.RefreshRoleView();
		}

		// Token: 0x0401B2EE RID: 111342
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B2EF RID: 111343
		private GenericLayout<RoleDevelopHotRoleGridItem, RoleDevelopData> HotRoleLayout;

		// Token: 0x0401B2F0 RID: 111344
		private GenericLayout<RoleDevelopGridItem, RoleDevelopData> RoleLayout;

		// Token: 0x0401B2F1 RID: 111345
		private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

		// Token: 0x0401B2F2 RID: 111346
		private RoleDevelopTagItem RoleDevelopTagItem;

		// Token: 0x0401B2F3 RID: 111347
		private List<RoleDataBase> RoleDataList = new List<RoleDataBase>();

		// Token: 0x0401B2F4 RID: 111348
		private List<RoleDevelopData> RoleDevelopDataList = new List<RoleDevelopData>();

		// Token: 0x0401B2F5 RID: 111349
		[Nullable(2)]
		private RoleDevelopData CurSelectRoleDevelopData;

		// Token: 0x0401B2F6 RID: 111350
		private bool IsSelectedFromHotRole;

		// Token: 0x0401B2F7 RID: 111351
		private int WeaponQualityThreshold;

		// Token: 0x0401B2F8 RID: 111352
		private int PhantomNumThreshold;

		// Token: 0x0401B2F9 RID: 111353
		private int PhantomQualityThreshold;

		// Token: 0x0401B2FA RID: 111354
		private int PhantomLevelThreshold;

		// Token: 0x0401B2FB RID: 111355
		private ButtonItem ConfirmButton;

		// Token: 0x0401B2FC RID: 111356
		private GenericLayout<RoleDevelopSelectTargetHintItem, RoleDevelopSelectTargetHintItemData> ConditionLayout;

		// Token: 0x0200AEC8 RID: 44744
		[NullableContext(0)]
		public static class EComponentType
		{
			// Token: 0x04035163 RID: 217443
			public const int CaptionItem = 0;

			// Token: 0x04035164 RID: 217444
			public const int HotRoleGrid = 1;

			// Token: 0x04035165 RID: 217445
			public const int HotRoleItem = 2;

			// Token: 0x04035166 RID: 217446
			public const int RoleGrid = 3;

			// Token: 0x04035167 RID: 217447
			public const int FilterSortItem = 4;

			// Token: 0x04035168 RID: 217448
			public const int RoleTexture = 5;

			// Token: 0x04035169 RID: 217449
			public const int ElementBgTexture = 6;

			// Token: 0x0403516A RID: 217450
			public const int ElementIconTexture = 7;

			// Token: 0x0403516B RID: 217451
			public const int NameText = 8;

			// Token: 0x0403516C RID: 217452
			public const int DevelopTag = 9;

			// Token: 0x0403516D RID: 217453
			public const int ElementText = 10;

			// Token: 0x0403516E RID: 217454
			public const int ConditionVerticalLayout = 11;

			// Token: 0x0403516F RID: 217455
			public const int ConditionItem = 12;

			// Token: 0x04035170 RID: 217456
			public const int ConfirmButton = 13;

			// Token: 0x04035171 RID: 217457
			public const int ScrollView = 14;
		}
	}
}
