using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A61 RID: 10849
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeaponSkinGridItem : LoopScrollSmallItemGrid<WeaponSkinData>
{
	// Token: 0x060169CE RID: 92622 RVA: 0x005BB514 File Offset: 0x005B9714
	public override void OnSelected(bool fireEvent)
	{
		if (fireEvent)
		{
			this.SetSelected(true, true);
		}
		WeaponSkinData weaponSkinData = this.Data as WeaponSkinData;
		if (weaponSkinData.IsNew)
		{
			NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.WeaponSkinRedDot, weaponSkinData.SkinId);
			base.SetNewFlagVisible(new bool?(false));
		}
	}

	// Token: 0x060169CF RID: 92623 RVA: 0x005BB55F File Offset: 0x005B975F
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x060169D0 RID: 92624 RVA: 0x005BB56C File Offset: 0x005B976C
	protected override void OnRefresh(WeaponSkinData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			IconPath = (data.IsEmptyData ? SkinConfig.Instance.GetDefaultWeaponSkinIconPath() : null),
			ItemConfigId = (data.IsEmptyData ? null : new int?(data.SkinId)),
			IsNewVisible = new bool?(data.IsNew)
		};
		base.Apply<PropSmallItemGrid>(parameters);
		this.SetSelected(isSelected, false);
		base.SetLockBlackVisible(data.GetIsLock());
		this.RefreshVisible();
	}

	// Token: 0x060169D1 RID: 92625 RVA: 0x005BB600 File Offset: 0x005B9800
	public void RefreshVisible()
	{
		WeaponSkinData weaponSkinData = this.Data as WeaponSkinData;
		base.SetSelectVisible(weaponSkinData.IsCurrentEquipSkinId());
		if (weaponSkinData.IsCurrentEquipSkinId())
		{
			base.SetRoleHead(null);
			return;
		}
		WeaponSkinModel instance = WeaponSkinModel.Instance;
		int? num = (instance != null) ? instance.GetRoleIdBySkinId(weaponSkinData.SkinId) : null;
		if (num == null)
		{
			base.SetRoleHead(null);
			return;
		}
		RoleSkinModel instance2 = RoleSkinModel.Instance;
		RoleSkinData roleSkinData = (instance2 != null) ? instance2.GetRoleSkinDataByRoleId(num.Value) : null;
		base.SetRoleHead((roleSkinData != null) ? new int?(roleSkinData.GetItemId()) : null);
	}
}
