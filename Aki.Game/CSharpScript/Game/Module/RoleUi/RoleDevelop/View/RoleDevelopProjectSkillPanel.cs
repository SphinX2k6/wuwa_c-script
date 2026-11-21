using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D10 RID: 15632
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectSkillPanel : RoleDevelopProjectBasePanel
	{
		// Token: 0x06028029 RID: 163881 RVA: 0x00B3347C File Offset: 0x00B3167C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
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
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickSwitchState));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602802A RID: 163882 RVA: 0x00B3371C File Offset: 0x00B3191C
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectSkillPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectSkillPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602802B RID: 163883 RVA: 0x00B33760 File Offset: 0x00B31960
		private UniTask InitSkillSlotItems()
		{
			RoleDevelopProjectSkillPanel.<InitSkillSlotItems>d__8 <InitSkillSlotItems>d__;
			<InitSkillSlotItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSkillSlotItems>d__.<>4__this = this;
			<InitSkillSlotItems>d__.<>1__state = -1;
			<InitSkillSlotItems>d__.<>t__builder.Start<RoleDevelopProjectSkillPanel.<InitSkillSlotItems>d__8>(ref <InitSkillSlotItems>d__);
			return <InitSkillSlotItems>d__.<>t__builder.Task;
		}

		// Token: 0x0602802C RID: 163884 RVA: 0x00B337A4 File Offset: 0x00B319A4
		private UniTask InitButtons()
		{
			RoleDevelopProjectSkillPanel.<InitButtons>d__9 <InitButtons>d__;
			<InitButtons>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtons>d__.<>4__this = this;
			<InitButtons>d__.<>1__state = -1;
			<InitButtons>d__.<>t__builder.Start<RoleDevelopProjectSkillPanel.<InitButtons>d__9>(ref <InitButtons>d__);
			return <InitButtons>d__.<>t__builder.Task;
		}

		// Token: 0x0602802D RID: 163885 RVA: 0x00B337E8 File Offset: 0x00B319E8
		private void RefreshSkillSlotItems()
		{
			List<RoleDevelopSkillData> skillDevelopData = this.Data.GetProjectData().GetSkillDevelopData();
			for (int i = 0; i < this.SkillSlotItems.Count; i++)
			{
				this.SkillSlotItems[i].Refresh(skillDevelopData[i], true);
			}
		}

		// Token: 0x0602802E RID: 163886 RVA: 0x00B33838 File Offset: 0x00B31A38
		private void RefreshItemLayout()
		{
			List<RoleDevelopProjectMaterialItemData> skillDevelopProjectViewItems = this.Data.GetProjectData().GetSkillDevelopProjectViewItems();
			foreach (RoleDevelopProjectMaterialItemData roleDevelopProjectMaterialItemData in skillDevelopProjectViewItems)
			{
				ERoleDevelopLogSubPage value;
				if (this.SkillDevelopMaterialTypeToLogSubPageMap.TryGetValue(roleDevelopProjectMaterialItemData.GroupItem.Type, out value))
				{
					roleDevelopProjectMaterialItemData.LogSubPage = new ERoleDevelopLogSubPage?(value);
					roleDevelopProjectMaterialItemData.LogRoleId = new int?(this.Data.GetId());
					roleDevelopProjectMaterialItemData.LogMainPage = new ERoleDevelopCategoryType?(ERoleDevelopCategoryType.Skill);
				}
			}
			this.ItemLayout.RefreshByData(skillDevelopProjectViewItems, null, false);
			base.GetItem(16).SetUIActive(skillDevelopProjectViewItems.Count > 0);
		}

		// Token: 0x0602802F RID: 163887 RVA: 0x00B338FC File Offset: 0x00B31AFC
		private void RefreshTitle()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "RoleProject_SkillUpgradePrefect", Array.Empty<object>());
			base.GetButton(1).RootUIComp.Get().SetUIActive(false);
			base.GetText(0).SetUIActive(false);
		}

		// Token: 0x06028030 RID: 163888 RVA: 0x00B3394C File Offset: 0x00B31B4C
		private void RefreshButtons()
		{
			int id = this.Data.GetId();
			bool flag = RoleDevelopUtil.IsProspectRole(id);
			bool flag2 = RoleModel.Instance.IsRoleOwned(id);
			bool flag3 = flag2 && !flag;
			base.GetItem(7).SetUIActive(flag3);
			base.GetItem(11).SetUIActive(!flag3);
			UUIItem item = base.GetItem(9);
			if (!flag2)
			{
				this.NormalButtonItem.SetUiActive(false);
				this.HighLightButtonItem.SetUiActive(false);
				item.SetUIActive(false);
				return;
			}
			RoleDevelopProjectBaseData projectData = this.Data.GetProjectData();
			bool uiActive;
			bool uiActive2;
			string textId;
			bool uiactive;
			if (projectData.IsSkillPlanFinished())
			{
				List<RoleDevelopSkillData> skillDevelopData = projectData.GetSkillDevelopData();
				int breachLevel = RoleModel.Instance.GetRoleDataById(id, true).GetLevelData().GetBreachLevel();
				bool flag4 = skillDevelopData.TrueForAll((RoleDevelopSkillData skill) => skill.CurrentLevel >= skill.TargetLevel);
				uiActive = true;
				uiActive2 = false;
				textId = "RoleProject_Button02";
				uiactive = (flag4 && breachLevel < 6);
			}
			else
			{
				bool flag5 = RoleDevelopUtil.CheckIsAllNeedItemsEnoughOrCanBeFilled(projectData.GetSkillPlanNeedItems());
				uiActive = !flag5;
				uiActive2 = flag5;
				textId = "RoleProject_Button01";
				uiactive = false;
			}
			this.NormalButtonItem.SetLocalTextNew(textId, Array.Empty<object>());
			this.HighLightButtonItem.SetLocalTextNew(textId, Array.Empty<object>());
			this.NormalButtonItem.SetUiActive(uiActive);
			this.HighLightButtonItem.SetUiActive(uiActive2);
			item.SetUIActive(uiactive);
		}

		// Token: 0x06028031 RID: 163889 RVA: 0x00B33AB3 File Offset: 0x00B31CB3
		public override void OnCommonItemCountAnyChange(int configId)
		{
			this.RefreshButtons();
			this.ItemLayout.RefreshWithoutDataSync();
		}

		// Token: 0x06028032 RID: 163890 RVA: 0x00B33AC6 File Offset: 0x00B31CC6
		protected override void OnRefreshView(bool forceRefresh)
		{
			this.RefreshSkillSlotItems();
			this.RefreshItemLayout();
			this.RefreshTitle();
			this.RefreshButtons();
		}

		// Token: 0x06028033 RID: 163891 RVA: 0x00B33AE0 File Offset: 0x00B31CE0
		private void OnClickSwitchState()
		{
			base.StopSequenceByName("Switch", false, true);
			base.PlaySequenceByName("Switch", false);
			RoleController.Instance.LogRoleDevelopClick(this.Data.GetId(), ERoleDevelopCategoryType.Skill, ERoleDevelopLogSubPage.SkillDevelopSwitchPlan, null);
		}

		// Token: 0x06028034 RID: 163892 RVA: 0x00B33B28 File Offset: 0x00B31D28
		private void OnClickBtnJump(int value)
		{
			int id = this.Data.GetId();
			if (!RoleModel.Instance.IsRoleOwned(id))
			{
				return;
			}
			RoleDevSkillMergeViewParams param = new RoleDevSkillMergeViewParams
			{
				RoleId = id,
				SkillNodeIndex = RoleDevConfig.Instance.GetDefaultSkillNodeIndex()
			};
			UiManager.Instance.OpenView(EUiViewName.RoleSkillMergeView, param, null);
			ERoleDevelopLogSubPage subPage = this.Data.GetProjectData().IsSkillPlanFinished() ? ERoleDevelopLogSubPage.SkillDevelopPerfectJump : ERoleDevelopLogSubPage.SkillDevelopJump;
			RoleController.Instance.LogRoleDevelopClick(id, ERoleDevelopCategoryType.Skill, subPage, null);
		}

		// Token: 0x06028035 RID: 163893 RVA: 0x00B33BAC File Offset: 0x00B31DAC
		private RoleDevelopProjectMaterialItem CreateMaterialItem()
		{
			return new RoleDevelopProjectMaterialItem();
		}

		// Token: 0x04015C84 RID: 89220
		private readonly Dictionary<EItemMaterialType, ERoleDevelopLogSubPage> SkillDevelopMaterialTypeToLogSubPageMap = new Dictionary<EItemMaterialType, ERoleDevelopLogSubPage>
		{
			{
				EItemMaterialType.Weekly,
				ERoleDevelopLogSubPage.SkillDevelopSkillMaterial
			},
			{
				EItemMaterialType.WeaponSkill,
				ERoleDevelopLogSubPage.SkillDevelopWeaponAndSkillMaterial1
			},
			{
				EItemMaterialType.Drop,
				ERoleDevelopLogSubPage.SkillDevelopWeaponAndSkillMaterial2
			}
		};

		// Token: 0x04015C85 RID: 89221
		private List<RoleDevelopProjectSkillSlotItem> SkillSlotItems = new List<RoleDevelopProjectSkillSlotItem>();

		// Token: 0x04015C86 RID: 89222
		private ButtonItem NormalButtonItem;

		// Token: 0x04015C87 RID: 89223
		private ButtonItem HighLightButtonItem;

		// Token: 0x04015C88 RID: 89224
		private GenericLayout<RoleDevelopProjectMaterialItem, RoleDevelopProjectMaterialItemData> ItemLayout;

		// Token: 0x020098E3 RID: 39139
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FAE8 RID: 195304
			TxtSwitchState,
			// Token: 0x0402FAE9 RID: 195305
			BtnSwitchState,
			// Token: 0x0402FAEA RID: 195306
			PanelSkillSlot0,
			// Token: 0x0402FAEB RID: 195307
			PanelSkillSlot1,
			// Token: 0x0402FAEC RID: 195308
			PanelSkillSlot2,
			// Token: 0x0402FAED RID: 195309
			PanelSkillSlot3,
			// Token: 0x0402FAEE RID: 195310
			PanelSkillSlot4,
			// Token: 0x0402FAEF RID: 195311
			PanelItemRight,
			// Token: 0x0402FAF0 RID: 195312
			BtnItemJump,
			// Token: 0x0402FAF1 RID: 195313
			PanelTxtOffset,
			// Token: 0x0402FAF2 RID: 195314
			BtnItemPerfectJump,
			// Token: 0x0402FAF3 RID: 195315
			PanelItemRightLine,
			// Token: 0x0402FAF4 RID: 195316
			PanelItemDetailLayout,
			// Token: 0x0402FAF5 RID: 195317
			PanelItemList,
			// Token: 0x0402FAF6 RID: 195318
			PanelSwitch,
			// Token: 0x0402FAF7 RID: 195319
			TxtTitle,
			// Token: 0x0402FAF8 RID: 195320
			PanelItemDescription
		}
	}
}
