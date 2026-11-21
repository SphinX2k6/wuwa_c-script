using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D17 RID: 15639
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopProjectWeaponRecommendListItem : GridProxyAbstract<RoleDevelopProjectWeaponRecommendListItemData>
	{
		// Token: 0x0602807C RID: 163964 RVA: 0x00B353C4 File Offset: 0x00B335C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickCall));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602807D RID: 163965 RVA: 0x00B35530 File Offset: 0x00B33730
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectWeaponRecommendListItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectWeaponRecommendListItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602807E RID: 163966 RVA: 0x00B35574 File Offset: 0x00B33774
		public override void Refresh(RoleDevelopProjectWeaponRecommendListItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			int recommendWeaponId = data.RecommendWeaponId;
			WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(recommendWeaponId);
			int developRoleId = data.DevelopRoleId;
			bool flag = RoleModel.Instance.IsRoleOwned(developRoleId);
			WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(developRoleId);
			bool flag2 = flag && weaponInstanceByRoleId != null && weaponInstanceByRoleId.GetItemId() == recommendWeaponId;
			List<int> weaponGachaIds = this.GetWeaponGachaIds(recommendWeaponId);
			bool flag3 = InventoryModel.Instance.GetItemCountByConfigId(recommendWeaponId, 0) > 0;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), weaponConfigByItemId.Value.WeaponName, Array.Empty<object>());
			base.GetItem(7).SetUIActive(flag2);
			base.GetButton(2).RootUIComp.Get().SetUIActive(!flag2 && weaponGachaIds.Count > 0);
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				ItemConfigId = new int?(recommendWeaponId),
				Data = data
			};
			this.WeaponItemGrid.Apply<PropSmallItemGrid>(parameters);
			if (flag3 && !flag2)
			{
				string textId = flag ? "RoleProject_Button05" : "RoleProject_Button06";
				this.ButtonJump.SetLocalTextNew(textId, Array.Empty<object>());
				this.ButtonJump.SetUiActive(flag3);
			}
			else
			{
				this.ButtonJump.SetUiActive(false);
			}
			UUIItem item = base.GetItem(4);
			if (flag3)
			{
				this.ButtonItemAccess.SetUiActive(false);
				item.SetUIActive(false);
				return;
			}
			RoleDevWeaponJumpGroup? weaponJumpGroupConfigByWeaponId = RoleDevConfig.Instance.GetWeaponJumpGroupConfigByWeaponId(recommendWeaponId);
			if (weaponJumpGroupConfigByWeaponId.Value.JumpPath != 0)
			{
				this.ButtonItemAccess.SetLocalTextNew(weaponJumpGroupConfigByWeaponId.Value.PathDescribe, Array.Empty<object>());
				this.ButtonItemAccess.SetUiActive(true);
				item.SetUIActive(false);
				return;
			}
			this.ButtonItemAccess.SetUiActive(false);
			item.SetUIActive(true);
			if (weaponGachaIds.Count > 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), weaponJumpGroupConfigByWeaponId.Value.PathDescribe, Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "RoleProject_Access_None", Array.Empty<object>());
		}

		// Token: 0x0602807F RID: 163967 RVA: 0x00B35790 File Offset: 0x00B33990
		private List<int> GetWeaponGachaIds(int weaponId)
		{
			RoleDevWeaponJumpGroup? weaponJumpGroupConfigByWeaponId = RoleDevConfig.Instance.GetWeaponJumpGroupConfigByWeaponId(weaponId);
			if (weaponJumpGroupConfigByWeaponId == null)
			{
				return new List<int>();
			}
			int jumpType = weaponJumpGroupConfigByWeaponId.Value.JumpType;
			if (jumpType != 1 && jumpType != 2)
			{
				return new List<int>();
			}
			return RoleDevelopUtil.GetHotWeaponGachaIds(weaponId, true);
		}

		// Token: 0x06028080 RID: 163968 RVA: 0x00B357E0 File Offset: 0x00B339E0
		private unsafe void OpenWeaponReplaceView()
		{
			int developRoleId = this.Data.DevelopRoleId;
			int recommendWeaponId = this.Data.RecommendWeaponId;
			WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(developRoleId);
			List<WeaponItemData> weaponListFromReplace = WeaponModel.Instance.GetWeaponListFromReplace(weaponInstanceByRoleId.GetWeaponConfig().Value.WeaponType);
			int sortId = SortConfig.Instance.GetSortId(EFilterSortGroupId.UseWayWeaponResonanceAndReplace);
			Sort value = SortConfig.Instance.GetSortConfig(sortId).Value;
			SortResultData sortResultData = new SortResultData();
			sortResultData.SetConfigId(value.Id);
			sortResultData.SetIsAscending(false);
			int ruleId = *value.GetBaseSortListBytes()[0];
			string sortRuleName = SortConfig.Instance.GetSortRuleName(ruleId, (ESortDataType)value.DataId);
			sortResultData.SetSelectBaseSort(new SortViewBaseSort(ruleId, sortRuleName));
			SortModel.Instance.SortDataList<WeaponItemData>(weaponListFromReplace, value.Id, sortResultData, Array.Empty<object>());
			int num = -1;
			int num2 = -1;
			foreach (WeaponItemData weaponItemData in weaponListFromReplace)
			{
				if (weaponItemData.GetConfigId() == recommendWeaponId)
				{
					WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(weaponItemData.GetUniqueId());
					if (weaponDataByIncId != null)
					{
						if (weaponDataByIncId.GetRoleId() == 0)
						{
							num2 = weaponItemData.GetUniqueId();
							break;
						}
						if (num < 0)
						{
							num = weaponItemData.GetUniqueId();
						}
					}
				}
			}
			if (num2 < 0)
			{
				num2 = num;
			}
			RoleDevelopUtil.OpenWeaponReplaceView(developRoleId, num2);
		}

		// Token: 0x06028081 RID: 163969 RVA: 0x00B35960 File Offset: 0x00B33B60
		private unsafe void OpenInventoryView()
		{
			int recommendWeaponId = this.Data.RecommendWeaponId;
			WeaponConf value = WeaponConfig.Instance.GetWeaponConfigByItemId(recommendWeaponId).Value;
			List<WeaponItemData> weaponListFromReplace = WeaponModel.Instance.GetWeaponListFromReplace(value.WeaponType);
			int sortId = SortConfig.Instance.GetSortId(EFilterSortGroupId.UseWayWeaponResonanceAndReplace);
			Sort value2 = SortConfig.Instance.GetSortConfig(sortId).Value;
			SortResultData sortResultData = new SortResultData();
			sortResultData.SetConfigId(value2.Id);
			sortResultData.SetIsAscending(false);
			int ruleId = *value2.GetBaseSortListBytes()[0];
			string sortRuleName = SortConfig.Instance.GetSortRuleName(ruleId, (ESortDataType)value2.DataId);
			sortResultData.SetSelectBaseSort(new SortViewBaseSort(ruleId, sortRuleName));
			SortModel.Instance.SortDataList<WeaponItemData>(weaponListFromReplace, value2.Id, sortResultData, Array.Empty<object>());
			int? num = null;
			foreach (WeaponItemData weaponItemData in weaponListFromReplace)
			{
				if (weaponItemData.GetConfigId() == recommendWeaponId)
				{
					num = new int?(weaponItemData.GetUniqueId());
					break;
				}
			}
			UiManager.Instance.OpenView(EUiViewName.InventoryView, num, null);
		}

		// Token: 0x06028082 RID: 163970 RVA: 0x00B35AA8 File Offset: 0x00B33CA8
		private void OnClickCall()
		{
			if (this.Data == null)
			{
				return;
			}
			List<int> weaponGachaIds = this.GetWeaponGachaIds(this.Data.RecommendWeaponId);
			if (weaponGachaIds.Count > 0)
			{
				UiManager.Instance.OpenView(EUiViewName.GachaMainView, weaponGachaIds[0], null);
			}
		}

		// Token: 0x06028083 RID: 163971 RVA: 0x00B35AF5 File Offset: 0x00B33CF5
		private bool OnWeaponGridCanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			return false;
		}

		// Token: 0x06028084 RID: 163972 RVA: 0x00B35AF8 File Offset: 0x00B33CF8
		private void OnClickWeaponGrid(MediumItemGridExtendCallback callback)
		{
			if (this.Data == null)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(this.Data.RecommendWeaponId, true, null, false);
		}

		// Token: 0x06028085 RID: 163973 RVA: 0x00B35B1C File Offset: 0x00B33D1C
		private void OnClickJump(int value)
		{
			if (this.Data == null)
			{
				return;
			}
			RoleDevelopProjectWeaponRecommendListItemData data = this.Data;
			if (RoleModel.Instance.IsRoleOwned(this.Data.DevelopRoleId))
			{
				this.OpenWeaponReplaceView();
			}
			else
			{
				this.OpenInventoryView();
			}
			if (data.LogRoleId != null && data.LogMainPage != null && data.LogSubPage != null)
			{
				RoleController.Instance.LogRoleDevelopClick(data.LogRoleId.Value, data.LogMainPage.Value, data.LogSubPage.Value, null);
			}
		}

		// Token: 0x06028086 RID: 163974 RVA: 0x00B35BCC File Offset: 0x00B33DCC
		private void OnClickItemAccess(int value)
		{
			if (this.Data == null)
			{
				return;
			}
			RoleDevWeaponJumpGroup? weaponJumpGroupConfigByWeaponId = RoleDevConfig.Instance.GetWeaponJumpGroupConfigByWeaponId(this.Data.RecommendWeaponId);
			if (weaponJumpGroupConfigByWeaponId == null || weaponJumpGroupConfigByWeaponId.Value.JumpType != 3)
			{
				return;
			}
			SkipTaskManager.RunByConfigId(weaponJumpGroupConfigByWeaponId.Value.JumpPath, null);
		}

		// Token: 0x04015CA1 RID: 89249
		[Nullable(2)]
		private RoleDevelopProjectWeaponRecommendListItemData Data;

		// Token: 0x04015CA2 RID: 89250
		private SmallItemGrid WeaponItemGrid;

		// Token: 0x04015CA3 RID: 89251
		private ButtonItem ButtonJump;

		// Token: 0x04015CA4 RID: 89252
		private ButtonItem ButtonItemAccess;

		// Token: 0x020098F1 RID: 39153
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FB42 RID: 195394
			WeaponItem,
			// Token: 0x0402FB43 RID: 195395
			WeaponName,
			// Token: 0x0402FB44 RID: 195396
			BtnCall,
			// Token: 0x0402FB45 RID: 195397
			BtnJump,
			// Token: 0x0402FB46 RID: 195398
			PanelNotObtained,
			// Token: 0x0402FB47 RID: 195399
			TxtNotObtained,
			// Token: 0x0402FB48 RID: 195400
			BtnItemAccess,
			// Token: 0x0402FB49 RID: 195401
			PanelStateGreen
		}
	}
}
