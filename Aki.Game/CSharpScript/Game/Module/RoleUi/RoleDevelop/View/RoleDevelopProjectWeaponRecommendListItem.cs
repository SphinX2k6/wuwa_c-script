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
	// Token: 0x02004D4E RID: 19790
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopProjectWeaponRecommendListItem : GridProxyAbstract<RoleDevelopProjectWeaponRecommendListItemData>
	{
		// Token: 0x06033219 RID: 209433 RVA: 0x00BEC050 File Offset: 0x00BEA250
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

		// Token: 0x0603321A RID: 209434 RVA: 0x00BEC1BC File Offset: 0x00BEA3BC
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectWeaponRecommendListItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectWeaponRecommendListItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603321B RID: 209435 RVA: 0x00BEC200 File Offset: 0x00BEA400
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

		// Token: 0x0603321C RID: 209436 RVA: 0x00BEC41C File Offset: 0x00BEA61C
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

		// Token: 0x0603321D RID: 209437 RVA: 0x00BEC46C File Offset: 0x00BEA66C
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

		// Token: 0x0603321E RID: 209438 RVA: 0x00BEC5EC File Offset: 0x00BEA7EC
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

		// Token: 0x0603321F RID: 209439 RVA: 0x00BEC734 File Offset: 0x00BEA934
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

		// Token: 0x06033220 RID: 209440 RVA: 0x00BEC781 File Offset: 0x00BEA981
		private bool OnWeaponGridCanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			return false;
		}

		// Token: 0x06033221 RID: 209441 RVA: 0x00BEC784 File Offset: 0x00BEA984
		private void OnClickWeaponGrid(MediumItemGridExtendCallback callback)
		{
			if (this.Data == null)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(this.Data.RecommendWeaponId, true, null);
		}

		// Token: 0x06033222 RID: 209442 RVA: 0x00BEC7A8 File Offset: 0x00BEA9A8
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

		// Token: 0x06033223 RID: 209443 RVA: 0x00BEC858 File Offset: 0x00BEAA58
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

		// Token: 0x0401B2CF RID: 111311
		[Nullable(2)]
		private RoleDevelopProjectWeaponRecommendListItemData Data;

		// Token: 0x0401B2D0 RID: 111312
		private SmallItemGrid WeaponItemGrid;

		// Token: 0x0401B2D1 RID: 111313
		private ButtonItem ButtonJump;

		// Token: 0x0401B2D2 RID: 111314
		private ButtonItem ButtonItemAccess;

		// Token: 0x0200AEBD RID: 44733
		[NullableContext(0)]
		public static class EComponentType
		{
			// Token: 0x04035119 RID: 217369
			public const int WeaponItem = 0;

			// Token: 0x0403511A RID: 217370
			public const int WeaponName = 1;

			// Token: 0x0403511B RID: 217371
			public const int BtnCall = 2;

			// Token: 0x0403511C RID: 217372
			public const int BtnJump = 3;

			// Token: 0x0403511D RID: 217373
			public const int PanelNotObtained = 4;

			// Token: 0x0403511E RID: 217374
			public const int TxtNotObtained = 5;

			// Token: 0x0403511F RID: 217375
			public const int BtnItemAccess = 6;

			// Token: 0x04035120 RID: 217376
			public const int PanelStateGreen = 7;
		}
	}
}
