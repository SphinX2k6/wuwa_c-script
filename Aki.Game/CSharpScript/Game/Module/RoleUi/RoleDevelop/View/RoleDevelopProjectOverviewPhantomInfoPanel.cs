using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D04 RID: 15620
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectOverviewPhantomInfoPanel : RoleDevelopProjectOverviewBaseInfoPanel
	{
		// Token: 0x06027FBB RID: 163771 RVA: 0x00B2FE18 File Offset: 0x00B2E018
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickJumpButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027FBC RID: 163772 RVA: 0x00B30094 File Offset: 0x00B2E294
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectOverviewPhantomInfoPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectOverviewPhantomInfoPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027FBD RID: 163773 RVA: 0x00B300D8 File Offset: 0x00B2E2D8
		private void InitLayouts()
		{
			foreach (ValueTuple<int, int> valueTuple in new ValueTuple<int, int>[]
			{
				new ValueTuple<int, int>(8, 9),
				new ValueTuple<int, int>(11, 12)
			})
			{
				int item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				this.BranchElementLayouts.Add(this.CreateElementLayout(item, item2));
			}
			this.ElementLayout = this.CreateElementLayout(14, 15);
		}

		// Token: 0x06027FBE RID: 163774 RVA: 0x00B30150 File Offset: 0x00B2E350
		private GenericLayout<RoleDevelopProjectOverviewPhantomElementItem, RoleDevelopPhantomElementData> CreateElementLayout(int layoutSlot, int itemSlot)
		{
			return new GenericLayout<RoleDevelopProjectOverviewPhantomElementItem, RoleDevelopPhantomElementData>(base.GetHorizontalLayout(layoutSlot), () => new RoleDevelopProjectOverviewPhantomElementItem(), base.GetItem(itemSlot).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06027FBF RID: 163775 RVA: 0x00B30190 File Offset: 0x00B2E390
		protected override void OnRefreshPanel(bool forceRefresh)
		{
			this.RefreshPhantomItems();
			this.RefreshRecommend();
		}

		// Token: 0x06027FC0 RID: 163776 RVA: 0x00B301A0 File Offset: 0x00B2E3A0
		private void RefreshPhantomItems()
		{
			RoleDevelopData data = this.Data;
			List<int> phantomIdList = data.GetDevelopRoleData().GetPhantomIdList();
			for (int i = 0; i < this.PhantomItems.Count; i++)
			{
				int phantomIncId = (i < phantomIdList.Count) ? phantomIdList[i] : 0;
				this.PhantomItems[i].Refresh(data, phantomIncId, i, false);
			}
		}

		// Token: 0x06027FC1 RID: 163777 RVA: 0x00B30200 File Offset: 0x00B2E400
		private void RefreshRecommend()
		{
			int id = this.Data.GetId();
			PhantomRecommend? config = ConfigPhantomRecommendByRoleId.GetConfig(id, true);
			bool flag = config != null && config.GetValueOrDefault().PhantomPlanParamIdLength > 1 && RoleModel.Instance.IsRoleHasBranch(id);
			base.GetItem(6).SetUIActive(flag);
			base.GetItem(13).SetUIActive(!flag);
			if (flag)
			{
				this.RefreshBranchRecommend(id, config.Value);
				return;
			}
			RoleDevelopRoleBaseData developRoleData = this.Data.GetDevelopRoleData();
			List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(id);
			int recommendPlanId = developRoleData.GetRecommendPlanId();
			VisionFetterRecommendInfo recommend = RoleDevelopProjectOverviewPhantomInfoPanel.FindRecommendByPlanId(roleFetterRecommendInfo, recommendPlanId);
			this.ElementLayout.RefreshByData(RoleDevelopProjectOverviewPhantomInfoPanel.CreateElementDataList(recommend), null, false);
		}

		// Token: 0x06027FC2 RID: 163778 RVA: 0x00B302B8 File Offset: 0x00B2E4B8
		private void RefreshBranchRecommend(int roleId, PhantomRecommend recommendConfig)
		{
			List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(roleId);
			Func<int, string> <>9__0;
			for (int i = 0; i < this.BranchToggleItems.Count; i++)
			{
				PhantomPlanParam? phantomPlanParam = (i < recommendConfig.PhantomPlanParamIdLength) ? ConfigPhantomPlanParamById.GetConfig(recommendConfig.PhantomPlanParamId(i), true) : null;
				int activeBranchIndex = (phantomPlanParam == null) ? -1 : RoleModel.Instance.GetRoleBranchIndexById(roleId, phantomPlanParam.Value.SkillBranchId);
				RoleDevelopProjectOverviewSkillBranchItem roleDevelopProjectOverviewSkillBranchItem = this.BranchToggleItems[i];
				roleDevelopProjectOverviewSkillBranchItem.SetActiveBranchIndex(activeBranchIndex);
				Func<int, string> handler;
				if ((handler = <>9__0) == null)
				{
					handler = (<>9__0 = ((int iconIndex) => RoleDevelopProjectOverviewPhantomInfoPanel.GetSkillBranchIcon(roleId, iconIndex)));
				}
				roleDevelopProjectOverviewSkillBranchItem.RefreshIcon(handler);
				int fetterGroupId = (i < recommendConfig.RecommendFetterGroupsLength) ? recommendConfig.RecommendFetterGroups(i) : 0;
				VisionFetterRecommendInfo recommend = RoleDevelopProjectOverviewPhantomInfoPanel.FindRecommendByFetterGroupId(roleFetterRecommendInfo, fetterGroupId);
				this.BranchElementLayouts[i].RefreshByData(RoleDevelopProjectOverviewPhantomInfoPanel.CreateElementDataList(recommend), null, false);
			}
		}

		// Token: 0x06027FC3 RID: 163779 RVA: 0x00B303C8 File Offset: 0x00B2E5C8
		private static string GetSkillBranchIcon(int roleId, int index)
		{
			int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(roleId, index);
			SkillBranch? skillBranchConfigById = RoleConfig.Instance.GetSkillBranchConfigById(roleBranchIdByIndex);
			return ((skillBranchConfigById != null) ? skillBranchConfigById.GetValueOrDefault().Icon : null) ?? string.Empty;
		}

		// Token: 0x06027FC4 RID: 163780 RVA: 0x00B30414 File Offset: 0x00B2E614
		[NullableContext(2)]
		private static VisionFetterRecommendInfo FindRecommendByPlanId([Nullable(new byte[]
		{
			2,
			1
		})] List<VisionFetterRecommendInfo> recommendInfoList, int planId)
		{
			if (recommendInfoList == null || recommendInfoList.Count == 0)
			{
				return null;
			}
			VisionFetterRecommendInfo result;
			if ((result = recommendInfoList.Find((VisionFetterRecommendInfo recommend) => recommend.GetPlanId() == planId)) == null)
			{
				result = (recommendInfoList.Find((VisionFetterRecommendInfo recommend) => recommend.GetRecommendFetterGroupId() == planId) ?? recommendInfoList[0]);
			}
			return result;
		}

		// Token: 0x06027FC5 RID: 163781 RVA: 0x00B30470 File Offset: 0x00B2E670
		[NullableContext(2)]
		private static VisionFetterRecommendInfo FindRecommendByFetterGroupId([Nullable(new byte[]
		{
			2,
			1
		})] List<VisionFetterRecommendInfo> recommendInfoList, int fetterGroupId)
		{
			if (recommendInfoList == null || fetterGroupId <= 0)
			{
				return null;
			}
			return recommendInfoList.Find((VisionFetterRecommendInfo recommend) => recommend.GetRecommendFetterGroupId() == fetterGroupId);
		}

		// Token: 0x06027FC6 RID: 163782 RVA: 0x00B304AC File Offset: 0x00B2E6AC
		private static List<RoleDevelopPhantomElementData> CreateElementDataList([Nullable(2)] VisionFetterRecommendInfo recommend)
		{
			List<RoleDevelopPhantomElementData> list = new List<RoleDevelopPhantomElementData>();
			if (recommend == null)
			{
				return list;
			}
			List<IVisionNewRecommendFetterItemData> list2 = recommend.BuildFetterItemDataList();
			for (int i = 0; i < list2.Count; i++)
			{
				list.Add(new RoleDevelopPhantomElementData
				{
					FetterGroupId = list2[i].GroupId,
					Count = list2[i].Count,
					ShowAdd = (i < list2.Count - 1)
				});
			}
			return list;
		}

		// Token: 0x06027FC7 RID: 163783 RVA: 0x00B30520 File Offset: 0x00B2E720
		private void OnClickJumpButton()
		{
			base.SwitchCategory(ERoleDevelopCategoryType.Phantom);
			RoleController.Instance.LogRoleDevelopClick(this.Data.GetId(), ERoleDevelopCategoryType.Overview, ERoleDevelopLogSubPage.OverviewPhantomPageJump, null);
		}

		// Token: 0x04015C60 RID: 89184
		private readonly List<RoleDevelopProjectPhantomItem> PhantomItems = new List<RoleDevelopProjectPhantomItem>();

		// Token: 0x04015C61 RID: 89185
		private readonly List<RoleDevelopProjectOverviewSkillBranchItem> BranchToggleItems = new List<RoleDevelopProjectOverviewSkillBranchItem>();

		// Token: 0x04015C62 RID: 89186
		private readonly List<GenericLayout<RoleDevelopProjectOverviewPhantomElementItem, RoleDevelopPhantomElementData>> BranchElementLayouts = new List<GenericLayout<RoleDevelopProjectOverviewPhantomElementItem, RoleDevelopPhantomElementData>>();

		// Token: 0x04015C63 RID: 89187
		private GenericLayout<RoleDevelopProjectOverviewPhantomElementItem, RoleDevelopPhantomElementData> ElementLayout;

		// Token: 0x020098C7 RID: 39111
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FA46 RID: 195142
			JumpButton,
			// Token: 0x0402FA47 RID: 195143
			PhantomSlot0,
			// Token: 0x0402FA48 RID: 195144
			PhantomSlot1,
			// Token: 0x0402FA49 RID: 195145
			PhantomSlot2,
			// Token: 0x0402FA4A RID: 195146
			PhantomSlot3,
			// Token: 0x0402FA4B RID: 195147
			PhantomSlot4,
			// Token: 0x0402FA4C RID: 195148
			BranchRecommendPanel,
			// Token: 0x0402FA4D RID: 195149
			BranchToggle1,
			// Token: 0x0402FA4E RID: 195150
			BranchElementHorizontalLayout1,
			// Token: 0x0402FA4F RID: 195151
			BranchElementItem1,
			// Token: 0x0402FA50 RID: 195152
			BranchToggle2,
			// Token: 0x0402FA51 RID: 195153
			BranchElementHorizontalLayout2,
			// Token: 0x0402FA52 RID: 195154
			BranchElementItem2,
			// Token: 0x0402FA53 RID: 195155
			RecommendPanel,
			// Token: 0x0402FA54 RID: 195156
			ElementHorizontalLayout,
			// Token: 0x0402FA55 RID: 195157
			ElementItem
		}
	}
}
