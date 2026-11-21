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
	// Token: 0x02003CFA RID: 15610
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopOverviewPanel : UiPanelBase
	{
		// Token: 0x06027F50 RID: 163664 RVA: 0x00B2D718 File Offset: 0x00B2B918
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

		// Token: 0x06027F51 RID: 163665 RVA: 0x00B2DA20 File Offset: 0x00B2BC20
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopOverviewPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopOverviewPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027F52 RID: 163666 RVA: 0x00B2DA5C File Offset: 0x00B2BC5C
		protected override void OnStart()
		{
			this.MaterialItemLayout = new GenericLayout<RoleDevelopOverviewMaterialItem, RoleDevelopOverviewMaterialItemData>(base.GetVerticalLayout(6), new Func<RoleDevelopOverviewMaterialItem>(this.CreateMaterialItem), null, false, true);
			this.PhantomSuitLayout = new GenericLayout<RoleDevelopProjectPhantomSuitItem, RoleDevelopPhantomSuitData>(base.GetVerticalLayout(9), new Func<RoleDevelopProjectPhantomSuitItem>(this.CreatePhantomSuitItem), null, false, true);
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x06027F53 RID: 163667 RVA: 0x00B2DAC8 File Offset: 0x00B2BCC8
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		}

		// Token: 0x06027F54 RID: 163668 RVA: 0x00B2DAE8 File Offset: 0x00B2BCE8
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

		// Token: 0x06027F55 RID: 163669 RVA: 0x00B2DD84 File Offset: 0x00B2BF84
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

		// Token: 0x06027F56 RID: 163670 RVA: 0x00B2DE60 File Offset: 0x00B2C060
		private bool IsWeaponQualityLow(int roleId)
		{
			ERoleDevelopWeaponState weaponState = RoleDevelopUtil.GetWeaponState(roleId);
			return weaponState == ERoleDevelopWeaponState.NotEquipped || weaponState == ERoleDevelopWeaponState.QualityLow;
		}

		// Token: 0x06027F57 RID: 163671 RVA: 0x00B2DE80 File Offset: 0x00B2C080
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

		// Token: 0x06027F58 RID: 163672 RVA: 0x00B2DEE4 File Offset: 0x00B2C0E4
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

		// Token: 0x06027F59 RID: 163673 RVA: 0x00B2DF5C File Offset: 0x00B2C15C
		private RoleDevelopOverviewMaterialItem CreateMaterialItem()
		{
			return new RoleDevelopOverviewMaterialItem();
		}

		// Token: 0x06027F5A RID: 163674 RVA: 0x00B2DF63 File Offset: 0x00B2C163
		private RoleDevelopProjectPhantomSuitItem CreatePhantomSuitItem()
		{
			return new RoleDevelopProjectPhantomSuitItem();
		}

		// Token: 0x06027F5B RID: 163675 RVA: 0x00B2DF6C File Offset: 0x00B2C16C
		private void OnMaterialJump(RoleDevelopItemGroup groupItem)
		{
			int devTargetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			if (devTargetRoleId > 0)
			{
				RoleDevelopUtil.HandleItemJump(devTargetRoleId, groupItem);
			}
		}

		// Token: 0x06027F5C RID: 163676 RVA: 0x00B2DF90 File Offset: 0x00B2C190
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
			else
			{
				this.LogEmptyPhantomSuit(devTargetRoleId);
			}
			this.PhantomSuitLayout.RefreshByData(recommendPhantomSuits, null, false);
		}

		// Token: 0x06027F5D RID: 163677 RVA: 0x00B2E024 File Offset: 0x00B2C224
		private unsafe void LogEmptyPhantomSuit(int roleId)
		{
			List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(roleId);
			string text = "null";
			if (roleFetterRecommendInfo != null)
			{
				text = "";
				foreach (VisionFetterRecommendInfo visionFetterRecommendInfo in roleFetterRecommendInfo)
				{
					string str = text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
					defaultInterpolatedStringHandler.AppendFormatted<int>(visionFetterRecommendInfo.GetPlanId());
					defaultInterpolatedStringHandler.AppendLiteral(":");
					defaultInterpolatedStringHandler.AppendFormatted<int>(visionFetterRecommendInfo.GetRecommendFetterGroupId());
					defaultInterpolatedStringHandler.AppendLiteral(":");
					defaultInterpolatedStringHandler.AppendFormatted<int>(visionFetterRecommendInfo.GetUsage());
					defaultInterpolatedStringHandler.AppendLiteral("|");
					text = str + defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleDev;
			ELogAuthor author = ELogAuthor.CB;
			string message = "培养总览声骸套装为空";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("panelPlanId", this.SelectPlanId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("modelPlanId", RoleDevelopModel.Instance.SelectPlanId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("firstMonsterId", this.SelectFirstVisionMonsterId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("recommend", text);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		}

		// Token: 0x06027F5E RID: 163678 RVA: 0x00B2E1B4 File Offset: 0x00B2C3B4
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

		// Token: 0x06027F5F RID: 163679 RVA: 0x00B2E22C File Offset: 0x00B2C42C
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

		// Token: 0x06027F60 RID: 163680 RVA: 0x00B2E278 File Offset: 0x00B2C478
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

		// Token: 0x06027F61 RID: 163681 RVA: 0x00B2E2B4 File Offset: 0x00B2C4B4
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

		// Token: 0x06027F62 RID: 163682 RVA: 0x00B2E338 File Offset: 0x00B2C538
		private void OnClickChooseBtn()
		{
			RoleController.OpenRoleDevelopSelectTargetView(ERoleDevelopUpdateTargetSource.Detection, null);
		}

		// Token: 0x06027F63 RID: 163683 RVA: 0x00B2E354 File Offset: 0x00B2C554
		private void OnChangeFetterGroupSuccessCallBack(int roleId, int planId, int? firstVisionMonsterId)
		{
			this.SelectPlanId = planId;
			this.SelectFirstVisionMonsterId = firstVisionMonsterId;
			this.RefreshPhantomSuitList(true);
			RoleController.Instance.RequestUpdateDevelopTarget(roleId, ERoleDevelopUpdateTargetSource.Detection, new int?(planId), firstVisionMonsterId);
		}

		// Token: 0x06027F64 RID: 163684 RVA: 0x00B2E37E File Offset: 0x00B2C57E
		private int OnGetSelectedPlanIdCallBack(int roleId)
		{
			return this.SelectPlanId;
		}

		// Token: 0x06027F65 RID: 163685 RVA: 0x00B2E386 File Offset: 0x00B2C586
		private int OnGetSelectedFirstVisionMonsterIdCallBack(int roleId)
		{
			return this.SelectFirstVisionMonsterId.GetValueOrDefault();
		}

		// Token: 0x04015C49 RID: 89161
		private GenericLayout<RoleDevelopOverviewMaterialItem, RoleDevelopOverviewMaterialItemData> MaterialItemLayout;

		// Token: 0x04015C4A RID: 89162
		private GenericLayout<RoleDevelopProjectPhantomSuitItem, RoleDevelopPhantomSuitData> PhantomSuitLayout;

		// Token: 0x04015C4B RID: 89163
		private int SelectPlanId;

		// Token: 0x04015C4C RID: 89164
		private int? SelectFirstVisionMonsterId = new int?(0);

		// Token: 0x04015C4D RID: 89165
		private int FetterInitRoleId;

		// Token: 0x020098BA RID: 39098
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402F9FC RID: 195068
			EmptyItem,
			// Token: 0x0402F9FD RID: 195069
			ContentItem,
			// Token: 0x0402F9FE RID: 195070
			FinishSprite,
			// Token: 0x0402F9FF RID: 195071
			JumpButton,
			// Token: 0x0402FA00 RID: 195072
			RecommendRootItem,
			// Token: 0x0402FA01 RID: 195073
			RecommendButton,
			// Token: 0x0402FA02 RID: 195074
			MaterialVerticalLayout,
			// Token: 0x0402FA03 RID: 195075
			MaterialItem,
			// Token: 0x0402FA04 RID: 195076
			PhantomJumpButton,
			// Token: 0x0402FA05 RID: 195077
			PhantomVerticalLayout,
			// Token: 0x0402FA06 RID: 195078
			PhantomItem,
			// Token: 0x0402FA07 RID: 195079
			ChooseButton,
			// Token: 0x0402FA08 RID: 195080
			MaterialTitleText,
			// Token: 0x0402FA09 RID: 195081
			JumpButtonText,
			// Token: 0x0402FA0A RID: 195082
			RecommendHintText,
			// Token: 0x0402FA0B RID: 195083
			PhantomRootItem,
			// Token: 0x0402FA0C RID: 195084
			JumpRootItem
		}
	}
}
