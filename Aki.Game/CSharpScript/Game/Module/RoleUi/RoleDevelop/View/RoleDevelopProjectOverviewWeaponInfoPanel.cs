using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D02 RID: 15618
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectOverviewWeaponInfoPanel : RoleDevelopProjectOverviewBaseInfoPanel
	{
		// Token: 0x06027FAC RID: 163756 RVA: 0x00B2F7F0 File Offset: 0x00B2D9F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
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
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickJumpButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027FAD RID: 163757 RVA: 0x00B2F8FC File Offset: 0x00B2DAFC
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectOverviewWeaponInfoPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectOverviewWeaponInfoPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027FAE RID: 163758 RVA: 0x00B2F93F File Offset: 0x00B2DB3F
		protected override void OnRefreshPanel(bool forceRefresh)
		{
			this.RefreshEquipWeapon();
			this.RefreshRecommendWeapon();
		}

		// Token: 0x06027FAF RID: 163759 RVA: 0x00B2F950 File Offset: 0x00B2DB50
		private void RefreshEquipWeapon()
		{
			RoleDevelopRoleBaseData developRoleData = this.Data.GetDevelopRoleData();
			WeaponInstance weaponInstance = developRoleData.GetWeaponInstance();
			this.EquipWeaponGrid.SetToggleInteractive(weaponInstance != null);
			if (weaponInstance != null)
			{
				this.EquipWeaponGrid.Apply<WeaponSmallItemGrid>(new WeaponSmallItemGrid
				{
					ItemConfigId = new int?(weaponInstance.GetItemId()),
					Level = new int?(developRoleData.GetWeaponLevel()),
					ResonanceLevel = new int?(weaponInstance.GetResonanceLevel()),
					Data = this.Data
				});
				return;
			}
			int weaponType = this.Data.GetProjectData().GetWeaponType();
			RoleDevWeaponItem? roleDevWeaponItemConfig = RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(weaponType);
			this.EquipWeaponGrid.SetIconByPath(roleDevWeaponItemConfig.Value.WeaponTypeIcon);
			this.EquipWeaponGrid.SetBottomTextVisible(false);
			this.EquipWeaponGrid.SetQuality(null);
		}

		// Token: 0x06027FB0 RID: 163760 RVA: 0x00B2FA2C File Offset: 0x00B2DC2C
		private void RefreshRecommendWeapon()
		{
			this.RecommendWeaponIds.Clear();
			this.RecommendWeaponIds.AddRange(RoleDevConfig.Instance.GetWeaponRecommendListConfig(this.Data.GetId()));
			WeaponInstance weaponInstance = this.Data.GetDevelopRoleData().GetWeaponInstance();
			int? num = (weaponInstance != null) ? new int?(weaponInstance.GetItemId()) : null;
			for (int i = 0; i < this.RecommendWeaponGrids.Count; i++)
			{
				SmallItemGrid smallItemGrid = this.RecommendWeaponGrids[i];
				if (i >= this.RecommendWeaponIds.Count)
				{
					smallItemGrid.SetUiActive(false);
				}
				else
				{
					smallItemGrid.SetUiActive(true);
					int num2 = this.RecommendWeaponIds[i];
					SmallItemGrid smallItemGrid2 = smallItemGrid;
					WeaponSmallItemGrid weaponSmallItemGrid = new WeaponSmallItemGrid();
					weaponSmallItemGrid.ItemConfigId = new int?(num2);
					int num3 = num2;
					int? num4 = num;
					weaponSmallItemGrid.IsWeaponFlagVisible = new bool?(num3 == num4.GetValueOrDefault() & num4 != null);
					weaponSmallItemGrid.Data = this.Data;
					smallItemGrid2.Apply<WeaponSmallItemGrid>(weaponSmallItemGrid);
				}
			}
		}

		// Token: 0x06027FB1 RID: 163761 RVA: 0x00B2FB27 File Offset: 0x00B2DD27
		[NullableContext(2)]
		private bool OnWeaponGridCanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			return false;
		}

		// Token: 0x06027FB2 RID: 163762 RVA: 0x00B2FB2C File Offset: 0x00B2DD2C
		private void OnClickEquipWeaponGrid(MediumItemGridExtendCallback callbackParameter)
		{
			RoleDevelopData data = this.Data;
			WeaponInstance weaponInstance = (data != null) ? data.GetDevelopRoleData().GetWeaponInstance() : null;
			if (weaponInstance == null)
			{
				return;
			}
			int valueOrDefault = weaponInstance.GetIncId().GetValueOrDefault();
			if (valueOrDefault > 0)
			{
				ItemController.Instance.OpenItemTipsByItemUid(valueOrDefault, weaponInstance.GetItemId(), true, null);
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(weaponInstance.GetItemId(), true, null, false);
		}

		// Token: 0x06027FB3 RID: 163763 RVA: 0x00B2FB8F File Offset: 0x00B2DD8F
		private void OnClickRecommendWeaponGrid(int index)
		{
			if (index >= this.RecommendWeaponIds.Count)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(this.RecommendWeaponIds[index], true, null, false);
		}

		// Token: 0x06027FB4 RID: 163764 RVA: 0x00B2FBBC File Offset: 0x00B2DDBC
		private void OnClickJumpButton()
		{
			base.SwitchCategory(ERoleDevelopCategoryType.Weapon);
			RoleController.Instance.LogRoleDevelopClick(this.Data.GetId(), ERoleDevelopCategoryType.Overview, ERoleDevelopLogSubPage.OverviewWeaponPageJump, null);
		}

		// Token: 0x04015C5C RID: 89180
		private SmallItemGrid EquipWeaponGrid;

		// Token: 0x04015C5D RID: 89181
		private readonly List<SmallItemGrid> RecommendWeaponGrids = new List<SmallItemGrid>();

		// Token: 0x04015C5E RID: 89182
		private readonly List<int> RecommendWeaponIds = new List<int>();

		// Token: 0x020098C2 RID: 39106
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FA30 RID: 195120
			JumpButton,
			// Token: 0x0402FA31 RID: 195121
			EquipWeaponItem,
			// Token: 0x0402FA32 RID: 195122
			RecommendWeaponItem1,
			// Token: 0x0402FA33 RID: 195123
			RecommendWeaponItem2,
			// Token: 0x0402FA34 RID: 195124
			RecommendWeaponItem3
		}
	}
}
