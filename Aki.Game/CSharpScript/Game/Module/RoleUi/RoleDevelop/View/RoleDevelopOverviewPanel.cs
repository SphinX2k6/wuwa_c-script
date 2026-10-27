using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D3B RID: 19771
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopOverviewPanel : UiPanelBase
	{
		// Token: 0x06033149 RID: 209225 RVA: 0x00BE6E0C File Offset: 0x00BE500C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickJumpBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickRecommendBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickPhantomJumpBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickChooseBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603314A RID: 209226 RVA: 0x00BE7114 File Offset: 0x00BE5314
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopOverviewPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopOverviewPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603314B RID: 209227 RVA: 0x00BE7150 File Offset: 0x00BE5350
		protected override void OnStart()
		{
			this.MaterialItemLayout = new GenericLayout<RoleDevelopOverviewMaterialItem, RoleDevelopOverviewMaterialItemData>(base.GetVerticalLayout(6), new Func<RoleDevelopOverviewMaterialItem>(this.CreateMaterialItem), null, false, true);
			this.PhantomSuitLayout = new GenericLayout<RoleDevelopProjectPhantomSuitItem, RoleDevelopPhantomSuitData>(base.GetVerticalLayout(9), new Func<RoleDevelopProjectPhantomSuitItem>(this.CreatePhantomSuitItem), null, false, true);
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x0603314C RID: 209228 RVA: 0x00BE71BC File Offset: 0x00BE53BC
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x0603314D RID: 209229 RVA: 0x00BE71DC File Offset: 0x00BE53DC
		public void RefreshView(bool forceRefresh = false)
		{
			int devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			bool flag = devTargetRoleId > 0;
			base.GetItem(0).SetUIActive(!flag);
			base.GetItem(1).SetUIActive(flag);
			if (!flag)
			{
				return;
			}
			bool flag2 = RoleModel.Instance.IsRoleOwned(devTargetRoleId);
			bool flag3 = RoleDevelopUtil.GetHotRoleGachaIds(devTargetRoleId, true).Count > 0;
			base.GetItem(16).SetUIActive(flag2 || flag3);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), (flag3 && !flag2) ? "RoleProject_GuideBookTitle02" : "RoleProject_GuideBookTitle01", Array.Empty<object>());
			RoleDevelopData roleDevelopData = RoleDevelopModel.Instance.GetRoleDevelopData(devTargetRoleId);
			if (roleDevelopData == null)
			{
				return;
			}
			RoleDevelopProjectBaseData projectData = roleDevelopData.GetProjectData();
			RoleDevelopRoleBaseData developRoleData = roleDevelopData.GetDevelopRoleData();
			if (this.FetterInitRoleId != devTargetRoleId)
			{
				this.SelectPlanId = developRoleData.GetRecommendPlanId();
				this.SelectFirstVisionMonsterId = new int?(developRoleData.GetRecommendFirstVisionMonsterId());
				this.FetterInitRoleId = devTargetRoleId;
			}
			bool flag4 = flag2 && this.IsWeaponQualityLow(devTargetRoleId);
			List<RoleDevelopNeedItem> skillPlanNeedItems = projectData.GetSkillPlanNeedItems();
			List<RoleDevelopNeedItem> list = this.CollectNeedItems(devTargetRoleId);
			if (list == null)
			{
				return;
			}
			List<RoleDevelopItemGroup> list2 = RoleDevelopUtil.BuildGroupItemDataByNeedItems(list, true, true, true);
			List<RoleDevelopOverviewMaterialItemData> list3 = new List<RoleDevelopOverviewMaterialItemData>();
			foreach (RoleDevelopItemGroup groupItem in list2)
			{
				list3.Add(new RoleDevelopOverviewMaterialItemData
				{
					GroupItem = groupItem,
					JumpCallback = new Action<RoleDevelopItemGroup>(this.OnMaterialJump)
				});
			}
			this.MaterialItemLayout.RefreshByData(list3, null, false);
			bool flag5 = this.CheckMaterialsSufficient(list);
			bool flag6 = developRoleData.GetRoleLevel() >= projectData.GetRoleTargetLevel();
			bool flag7 = skillPlanNeedItems.Count == 0;
			bool flag8 = developRoleData.GetWeaponLevel() >= projectData.GetWeaponTargetLevel();
			bool flag9 = flag6 && flag7 && !flag4 && flag8;
			UUIText text = base.GetText(12);
			if (flag9)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_ChoseRole_FinishTips", Array.Empty<object>());
			}
			else if (flag5)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_ChoseRole_ItemTips02", Array.Empty<object>());
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_GuideBookTitle00", Array.Empty<object>());
			}
			base.GetSprite(2).SetUIActive(flag5);
			base.GetItem(4).SetUIActive(flag4);
			if (flag4)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "RoleProject_GuideBookTips01", Array.Empty<object>());
			}
			if (RoleDevelopUtil.IsAnyProspectRole(devTargetRoleId))
			{
				base.GetItem(15).SetUIActive(false);
				return;
			}
			base.GetItem(15).SetUIActive(true);
			this.RefreshPhantomSuitList(forceRefresh);
		}

		// Token: 0x0603314E RID: 209230 RVA: 0x00BE7478 File Offset: 0x00BE5678
		private bool CheckMaterialsSufficient(List<RoleDevelopNeedItem> needItems)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (RoleDevelopNeedItem roleDevelopNeedItem in needItems)
			{
				if (!RoleDevelopUtil.IsUnknownItem(roleDevelopNeedItem.ItemId))
				{
					int num;
					dictionary.TryGetValue(roleDevelopNeedItem.ItemId, out num);
					dictionary[roleDevelopNeedItem.ItemId] = num + roleDevelopNeedItem.Count;
				}
			}
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				if (InventoryModel.Instance.GetItemCountByConfigId(keyValuePair.Key, 0) < keyValuePair.Value)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603314F RID: 209231 RVA: 0x00BE7554 File Offset: 0x00BE5754
		private bool IsWeaponQualityLow(int roleId)
		{
			WeaponInstance weaponInstance = WeaponModel.Instance.GetWeaponDataByRoleDataId(roleId, true) as WeaponInstance;
			if (weaponInstance == null)
			{
				return true;
			}
			int weaponQualityThreshold = RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.WeaponQualityThreshold;
			return weaponInstance.GetItemConfig().QualityId < weaponQualityThreshold;
		}

		// Token: 0x06033150 RID: 209232 RVA: 0x00BE75A8 File Offset: 0x00BE57A8
		private void OnClickJumpBtn()
		{
			int devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			if (devTargetRoleId <= 0)
			{
				return;
			}
			if (RoleModel.Instance.IsRoleOwned(devTargetRoleId))
			{
				RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, devTargetRoleId, null, null, null);
				return;
			}
			List<int> hotRoleGachaIds = RoleDevelopUtil.GetHotRoleGachaIds(devTargetRoleId, true);
			if (hotRoleGachaIds.Count > 0)
			{
				GachaController.Instance.OpenGachaView(hotRoleGachaIds[0]);
			}
		}

		// Token: 0x06033151 RID: 209233 RVA: 0x00BE760C File Offset: 0x00BE580C
		private void OnClickRecommendBtn()
		{
			int developRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			if (developRoleId <= 0 || !RoleModel.Instance.IsRoleOwned(developRoleId))
			{
				return;
			}
			if (!this.IsWeaponQualityLow(developRoleId))
			{
				return;
			}
			OpenRoleMainViewData param = new OpenRoleMainViewData
			{
				AgentType = ERoleAgentType.Normal,
				FinishCallback = delegate(bool success, int viewId)
				{
					UiManager.Instance.OpenView(EUiViewName.RoleDevelopRootView, new RoleDevelopRootViewData
					{
						RoleId = new int?(developRoleId),
						CategoryType = new ERoleDevelopCategoryType?(ERoleDevelopCategoryType.Weapon)
					}, null);
				}
			};
			RoleController.Instance.OpenRoleMainViewByParam(param);
		}

		// Token: 0x06033152 RID: 209234 RVA: 0x00BE7684 File Offset: 0x00BE5884
		private RoleDevelopOverviewMaterialItem CreateMaterialItem()
		{
			return new RoleDevelopOverviewMaterialItem();
		}

		// Token: 0x06033153 RID: 209235 RVA: 0x00BE768B File Offset: 0x00BE588B
		private RoleDevelopProjectPhantomSuitItem CreatePhantomSuitItem()
		{
			return new RoleDevelopProjectPhantomSuitItem();
		}

		// Token: 0x06033154 RID: 209236 RVA: 0x00BE7694 File Offset: 0x00BE5894
		private void OnMaterialJump(RoleDevelopItemGroup groupItem)
		{
			int devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			if (devTargetRoleId > 0)
			{
				RoleDevelopUtil.HandleItemJump(devTargetRoleId, groupItem);
			}
		}

		// Token: 0x06033155 RID: 209237 RVA: 0x00BE76B8 File Offset: 0x00BE58B8
		private void RefreshPhantomSuitList(bool forceRefresh)
		{
			int devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			RoleDevelopData roleDevelopData = RoleDevelopModel.Instance.GetRoleDevelopData(devTargetRoleId);
			if (roleDevelopData == null)
			{
				return;
			}
			if (!forceRefresh && this.PhantomSuitLayout.GetDisplayGridNum() > 0)
			{
				this.PhantomSuitLayout.RefreshWithoutDataSync();
				return;
			}
			List<RoleDevelopPhantomSuitData> recommendPhantomSuits = roleDevelopData.GetDevelopRoleData().GetRecommendPhantomSuits(new int?(this.SelectPlanId), this.SelectFirstVisionMonsterId);
			if (recommendPhantomSuits.Count > 0)
			{
				recommendPhantomSuits[0].IsNeedFetterButton = new bool?(true);
			}
			this.PhantomSuitLayout.RefreshByData(recommendPhantomSuits, null, false);
		}

		// Token: 0x06033156 RID: 209238 RVA: 0x00BE7744 File Offset: 0x00BE5944
		private void OnClickPhantomJumpBtn()
		{
			int devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			if (devTargetRoleId <= 0)
			{
				return;
			}
			VisionRecommendViewOpenParam param = new VisionRecommendViewOpenParam
			{
				RoleId = devTargetRoleId,
				IsFromRoleDev = true,
				SuccessCallBack = new Action<int, int, int?>(this.OnChangeFetterGroupSuccessCallBack),
				GetSelectedPlanIdCallBack = new Func<int, int>(this.OnGetSelectedPlanIdCallBack),
				GetSelectedFirstVisionMonsterIdCallBack = new Func<int, int>(this.OnGetSelectedFirstVisionMonsterIdCallBack)
			};
			UiManager.Instance.OpenView(EUiViewName.VisionNewRecommendView, param, null);
		}

		// Token: 0x06033157 RID: 209239 RVA: 0x00BE77BC File Offset: 0x00BE59BC
		private void OnCommonItemCountAnyChange(int configId, int count)
		{
			GenericLayout<RoleDevelopOverviewMaterialItem, RoleDevelopOverviewMaterialItemData> materialItemLayout = this.MaterialItemLayout;
			List<RoleDevelopOverviewMaterialItem> list = (materialItemLayout != null) ? materialItemLayout.GetLayoutItemList() : null;
			if (list == null)
			{
				return;
			}
			if (this.GetCurrentMaterialGroupCount() != list.Count)
			{
				this.RefreshView(false);
				return;
			}
			GenericLayout<RoleDevelopOverviewMaterialItem, RoleDevelopOverviewMaterialItemData> materialItemLayout2 = this.MaterialItemLayout;
			if (materialItemLayout2 == null)
			{
				return;
			}
			materialItemLayout2.RefreshWithoutDataSync();
		}

		// Token: 0x06033158 RID: 209240 RVA: 0x00BE7808 File Offset: 0x00BE5A08
		private int GetCurrentMaterialGroupCount()
		{
			int devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			if (devTargetRoleId <= 0)
			{
				return 0;
			}
			List<RoleDevelopNeedItem> list = this.CollectNeedItems(devTargetRoleId);
			if (list == null)
			{
				return 0;
			}
			return RoleDevelopUtil.BuildGroupItemDataByNeedItems(list, true, true, true).Count;
		}

		// Token: 0x06033159 RID: 209241 RVA: 0x00BE7844 File Offset: 0x00BE5A44
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<RoleDevelopNeedItem> CollectNeedItems(int developRoleId)
		{
			RoleDevelopData roleDevelopData = RoleDevelopModel.Instance.GetRoleDevelopData(developRoleId);
			if (roleDevelopData == null)
			{
				return null;
			}
			RoleDevelopProjectBaseData projectData = roleDevelopData.GetProjectData();
			bool flag = RoleModel.Instance.IsRoleOwned(developRoleId) && this.IsWeaponQualityLow(developRoleId);
			List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
			list.AddRange(projectData.GetRoleUpgradeNeedItems());
			list.AddRange(projectData.GetRoleBreachNeedItems());
			list.AddRange(projectData.GetSkillPlanNeedItems());
			if (!flag)
			{
				list.AddRange(projectData.GetWeaponUpgradeNeedItems());
				list.AddRange(projectData.GetWeaponBreachNeedItems());
			}
			return list;
		}

		// Token: 0x0603315A RID: 209242 RVA: 0x00BE78C8 File Offset: 0x00BE5AC8
		private void OnClickChooseBtn()
		{
			RoleController.OpenRoleDevelopSelectTargetView(ERoleDevelopUpdateTargetSource.Detection, null);
		}

		// Token: 0x0603315B RID: 209243 RVA: 0x00BE78E4 File Offset: 0x00BE5AE4
		private void OnChangeFetterGroupSuccessCallBack(int roleId, int planId, int? firstVisionMonsterId)
		{
			this.SelectPlanId = planId;
			this.SelectFirstVisionMonsterId = firstVisionMonsterId;
			this.RefreshPhantomSuitList(true);
			RoleController.Instance.RequestUpdateDevelopTarget(roleId, ERoleDevelopUpdateTargetSource.Detection, new int?(planId), firstVisionMonsterId);
		}

		// Token: 0x0603315C RID: 209244 RVA: 0x00BE790E File Offset: 0x00BE5B0E
		private int OnGetSelectedPlanIdCallBack(int roleId)
		{
			return this.SelectPlanId;
		}

		// Token: 0x0603315D RID: 209245 RVA: 0x00BE7916 File Offset: 0x00BE5B16
		private int OnGetSelectedFirstVisionMonsterIdCallBack(int roleId)
		{
			return this.SelectFirstVisionMonsterId.GetValueOrDefault();
		}

		// Token: 0x0401B28D RID: 111245
		private GenericLayout<RoleDevelopOverviewMaterialItem, RoleDevelopOverviewMaterialItemData> MaterialItemLayout;

		// Token: 0x0401B28E RID: 111246
		private GenericLayout<RoleDevelopProjectPhantomSuitItem, RoleDevelopPhantomSuitData> PhantomSuitLayout;

		// Token: 0x0401B28F RID: 111247
		private int SelectPlanId;

		// Token: 0x0401B290 RID: 111248
		private int? SelectFirstVisionMonsterId = new int?(0);

		// Token: 0x0401B291 RID: 111249
		private int FetterInitRoleId;

		// Token: 0x0200AE9B RID: 44699
		[NullableContext(0)]
		public static class EComponentType
		{
			// Token: 0x0403504D RID: 217165
			public const int EmptyItem = 0;

			// Token: 0x0403504E RID: 217166
			public const int ContentItem = 1;

			// Token: 0x0403504F RID: 217167
			public const int FinishSprite = 2;

			// Token: 0x04035050 RID: 217168
			public const int JumpButton = 3;

			// Token: 0x04035051 RID: 217169
			public const int RecommendRootItem = 4;

			// Token: 0x04035052 RID: 217170
			public const int RecommendButton = 5;

			// Token: 0x04035053 RID: 217171
			public const int MaterialVerticalLayout = 6;

			// Token: 0x04035054 RID: 217172
			public const int MaterialItem = 7;

			// Token: 0x04035055 RID: 217173
			public const int PhantomJumpButton = 8;

			// Token: 0x04035056 RID: 217174
			public const int PhantomVerticalLayout = 9;

			// Token: 0x04035057 RID: 217175
			public const int PhantomItem = 10;

			// Token: 0x04035058 RID: 217176
			public const int ChooseButton = 11;

			// Token: 0x04035059 RID: 217177
			public const int MaterialTitleText = 12;

			// Token: 0x0403505A RID: 217178
			public const int JumpButtonText = 13;

			// Token: 0x0403505B RID: 217179
			public const int RecommendHintText = 14;

			// Token: 0x0403505C RID: 217180
			public const int PhantomRootItem = 15;

			// Token: 0x0403505D RID: 217181
			public const int JumpRootItem = 16;
		}
	}
}
