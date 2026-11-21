using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001D07 RID: 7431
public class RoleTowerRecordRoleItem : GridProxyAbstract<int>
{
	// Token: 0x0601264D RID: 75341 RVA: 0x0056F48C File Offset: 0x0056D68C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x0601264E RID: 75342 RVA: 0x0056F4E8 File Offset: 0x0056D6E8
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(1);
		AActor aactor = (item != null) ? item.GetOwner() : null;
		if (aactor == null)
		{
			return;
		}
		this.RoleGrid = new SmallItemGrid();
		this.RoleGrid.CreateThenShowByActor(aactor, null);
	}

	// Token: 0x0601264F RID: 75343 RVA: 0x0056F528 File Offset: 0x0056D728
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		bool flag = roleId > 0;
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		UUISprite sprite = base.GetSprite(2);
		if (sprite != null)
		{
			sprite.SetUIActive(flag && RoleUtils.IsTrialRole(roleId));
		}
		if (this.RoleGrid == null)
		{
			return;
		}
		if (flag)
		{
			RoleConfig instance = RoleConfig.Instance;
			RoleInfo? roleInfo = (instance != null) ? instance.GetRoleConfig(roleId) : null;
			this.RoleGrid.ApplyCharacterSmallItemGrid(new CharacterSmallItemGrid
			{
				ItemConfigId = new int?(roleId),
				ElementId = new int?((roleInfo != null) ? roleInfo.GetValueOrDefault().ElementId : 0)
			});
			UUIExtendToggle itemGridExtendToggle = this.RoleGrid.GetItemGridExtendToggle();
			if (itemGridExtendToggle != null)
			{
				itemGridExtendToggle.SetActive(false, false);
			}
			this.RoleGrid.SetExtendToggleEnable(false, false);
			return;
		}
		this.RoleGrid.ApplyEmptyWithoutAddSmallItemGrid(new EmptySmallItemGrid());
		this.RoleGrid.SetExtendToggleEnable(false, false);
	}

	// Token: 0x06012650 RID: 75344 RVA: 0x0056F630 File Offset: 0x0056D830
	[NullableContext(1)]
	public override object GetKey(int roleId, int displayIndex)
	{
		return displayIndex;
	}

	// Token: 0x0400A045 RID: 41029
	[Nullable(2)]
	private SmallItemGrid RoleGrid;

	// Token: 0x02008035 RID: 32821
	private static class EChildType
	{
		// Token: 0x040297C4 RID: 169924
		public const int PnlEmpty = 0;

		// Token: 0x040297C5 RID: 169925
		public const int UiItemItemBaseB = 1;

		// Token: 0x040297C6 RID: 169926
		public const int SprRoleTrial = 2;
	}
}
