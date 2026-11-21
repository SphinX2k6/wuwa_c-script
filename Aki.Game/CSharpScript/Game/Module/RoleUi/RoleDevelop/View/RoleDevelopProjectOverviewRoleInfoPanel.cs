using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D01 RID: 15617
	public class RoleDevelopProjectOverviewRoleInfoPanel : RoleDevelopProjectOverviewBaseInfoPanel
	{
		// Token: 0x06027FA4 RID: 163748 RVA: 0x00B2F364 File Offset: 0x00B2D564
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickCallButton));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickCallButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027FA5 RID: 163749 RVA: 0x00B2F515 File Offset: 0x00B2D715
		protected override void OnRefreshPanel(bool forceRefresh)
		{
			this.RefreshLevel();
			this.RefreshResonant();
			this.RefreshMainProperty();
			this.RefreshCallButton();
		}

		// Token: 0x06027FA6 RID: 163750 RVA: 0x00B2F530 File Offset: 0x00B2D730
		private void RefreshLevel()
		{
			int roleLevel = this.Data.GetDevelopRoleData().GetRoleLevel();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_OverSeaServerLv_text", new <>z__ReadOnlySingleElementList<object>(roleLevel));
		}

		// Token: 0x06027FA7 RID: 163751 RVA: 0x00B2F570 File Offset: 0x00B2D770
		private void RefreshResonant()
		{
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.Data.GetId());
			int num = (roleInstanceById != null) ? roleInstanceById.GetResonanceData().GetResonantChainGroupIndex() : 0;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "RoleProject_Overview_Resonant", new <>z__ReadOnlySingleElementList<object>(num));
		}

		// Token: 0x06027FA8 RID: 163752 RVA: 0x00B2F5C8 File Offset: 0x00B2D7C8
		private void RefreshMainProperty()
		{
			UUIItem item = base.GetItem(4);
			UUIItem item2 = base.GetItem(5);
			int id = this.Data.GetId();
			int keyProperty = this.Data.GetDevelopRoleData().GetKeyProperty();
			RoleDevProject? roleDevProjectConfig = RoleDevConfig.Instance.GetRoleDevProjectConfig(id);
			if (keyProperty == 0 || roleDevProjectConfig == null)
			{
				item.SetUIActive(false);
				item2.SetUIActive(false);
				return;
			}
			PropertyIndex? propertyIndexConfigByIndex = RoleDevConfig.Instance.GetPropertyIndexConfigByIndex(keyProperty);
			if (propertyIndexConfigByIndex == null)
			{
				item.SetUIActive(false);
				item2.SetUIActive(false);
				return;
			}
			item.SetUIActive(true);
			bool flag = roleDevProjectConfig.Value.PropertyValue(0) == 1;
			int num = roleDevProjectConfig.Value.PropertyValue(1);
			string text;
			if (!flag)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendFormatted<double>((double)num / 100.0, "F1");
				defaultInterpolatedStringHandler.AppendLiteral("%");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				text = num.ToString();
			}
			string str = text;
			string text2 = ConfigMultiTextLang.GetLocalTextNew(propertyIndexConfigByIndex.Value.Name, null) + " " + str;
			base.GetText(6).SetText(StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("RoleProject_TargetProperty", null), new string[]
			{
				text2
			}), true);
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(id);
			int num2 = (roleInstanceById != null) ? roleInstanceById.GetAttributeData().GetAttrValueById(keyProperty) : 0;
			item2.SetUIActive(num2 >= num);
		}

		// Token: 0x06027FA9 RID: 163753 RVA: 0x00B2F73C File Offset: 0x00B2D93C
		private void RefreshCallButton()
		{
			List<int> hotRoleGachaIds = RoleDevelopUtil.GetHotRoleGachaIds(this.Data.GetId(), true);
			base.GetButton(7).RootUIComp.Get().SetUIActive(hotRoleGachaIds.Count > 0);
		}

		// Token: 0x06027FAA RID: 163754 RVA: 0x00B2F780 File Offset: 0x00B2D980
		private void OnClickCallButton()
		{
			List<int> hotRoleGachaIds = RoleDevelopUtil.GetHotRoleGachaIds(this.Data.GetId(), true);
			if (hotRoleGachaIds.Count <= 0)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.GachaMainView, hotRoleGachaIds[0], null);
			RoleController.Instance.LogRoleDevelopClick(this.Data.GetId(), ERoleDevelopCategoryType.Overview, ERoleDevelopLogSubPage.OverviewCallJump, null);
		}

		// Token: 0x020098C1 RID: 39105
		private enum EComponentType
		{
			// Token: 0x0402FA26 RID: 195110
			LevelItem,
			// Token: 0x0402FA27 RID: 195111
			LevelText,
			// Token: 0x0402FA28 RID: 195112
			ResonantItem,
			// Token: 0x0402FA29 RID: 195113
			ResonantText,
			// Token: 0x0402FA2A RID: 195114
			MainPropertyItem,
			// Token: 0x0402FA2B RID: 195115
			MainPropertyCompleteItem,
			// Token: 0x0402FA2C RID: 195116
			MainPropertyText,
			// Token: 0x0402FA2D RID: 195117
			CallButton,
			// Token: 0x0402FA2E RID: 195118
			JumpButton
		}
	}
}
