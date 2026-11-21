using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001FDC RID: 8156
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeaponSkinGridItem : LoopScrollSmallItemGrid<WeaponSkinData>
{
	// Token: 0x060143EF RID: 82927 RVA: 0x005E769C File Offset: 0x005E589C
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

	// Token: 0x060143F0 RID: 82928 RVA: 0x005E76E7 File Offset: 0x005E58E7
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x060143F1 RID: 82929 RVA: 0x005E76F4 File Offset: 0x005E58F4
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

	// Token: 0x060143F2 RID: 82930 RVA: 0x005E7788 File Offset: 0x005E5988
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
