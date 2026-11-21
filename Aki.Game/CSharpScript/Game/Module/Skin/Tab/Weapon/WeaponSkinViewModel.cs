using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Skin.Tab.Weapon
{
	// Token: 0x02003B9A RID: 15258
	[NullableContext(1)]
	[Nullable(0)]
	public class WeaponSkinViewModel : ViewModelBase<EWeaponSkinTabViewData>
	{
		// Token: 0x17005015 RID: 20501
		// (get) Token: 0x060271A9 RID: 160169 RVA: 0x00AF0D56 File Offset: 0x00AEEF56
		public int PrevEquipSkinId
		{
			get
			{
				return this.PrevEquipSkinIdInternal;
			}
		}

		// Token: 0x060271AA RID: 160170 RVA: 0x00AF0D60 File Offset: 0x00AEEF60
		public WeaponSkinViewModel()
		{
			List<WeaponSkinData> value = new List<WeaponSkinData>();
			this.DataMap[EWeaponSkinTabViewData.SkinDataList] = value;
			this.DataMap[EWeaponSkinTabViewData.IsInShowWeapon] = false;
			this.DataMap[EWeaponSkinTabViewData.EquipSkinId] = null;
			this.DataMap[EWeaponSkinTabViewData.SelectedSkinId] = null;
			this.DataMap[EWeaponSkinTabViewData.WeaponUiVisible] = true;
		}

		// Token: 0x060271AB RID: 160171 RVA: 0x00AF0DCB File Offset: 0x00AEEFCB
		public void Init(ISkinViewData viewData)
		{
			this.ViewData = viewData;
			this.InitSkinWeaponGridDataList();
			this.InitSelectedWeaponSkinId();
		}

		// Token: 0x060271AC RID: 160172 RVA: 0x00AF0DE0 File Offset: 0x00AEEFE0
		public void SetIsInShowWeapon(bool showWeapon, bool notNotify = false)
		{
			base.SetData(EWeaponSkinTabViewData.IsInShowWeapon, showWeapon, notNotify);
		}

		// Token: 0x060271AD RID: 160173 RVA: 0x00AF0DF0 File Offset: 0x00AEEFF0
		public bool GetIsInShowWeapon()
		{
			return (bool)base.GetData(EWeaponSkinTabViewData.IsInShowWeapon);
		}

		// Token: 0x060271AE RID: 160174 RVA: 0x00AF0DFE File Offset: 0x00AEEFFE
		public void SetEquipSkinId(int equipSkinId, bool notNotify = false)
		{
			base.SetData(EWeaponSkinTabViewData.EquipSkinId, equipSkinId, notNotify);
		}

		// Token: 0x060271AF RID: 160175 RVA: 0x00AF0E0E File Offset: 0x00AEF00E
		public int GetEquipSkinId()
		{
			return (int)base.GetData(EWeaponSkinTabViewData.EquipSkinId);
		}

		// Token: 0x060271B0 RID: 160176 RVA: 0x00AF0E1C File Offset: 0x00AEF01C
		public void SetSelectedSkinId(int skinId, bool notNotify = false)
		{
			base.SetData(EWeaponSkinTabViewData.SelectedSkinId, skinId, notNotify);
		}

		// Token: 0x060271B1 RID: 160177 RVA: 0x00AF0E2C File Offset: 0x00AEF02C
		public int GetSelectedSkinId()
		{
			return (int)base.GetData(EWeaponSkinTabViewData.SelectedSkinId);
		}

		// Token: 0x060271B2 RID: 160178 RVA: 0x00AF0E3A File Offset: 0x00AEF03A
		public List<WeaponSkinData> GetSkinDataList()
		{
			return (List<WeaponSkinData>)base.GetData(EWeaponSkinTabViewData.SkinDataList);
		}

		// Token: 0x060271B3 RID: 160179 RVA: 0x00AF0E48 File Offset: 0x00AEF048
		public void SetWeaponUiVisible(bool visible, bool notNotify = false)
		{
			base.SetData(EWeaponSkinTabViewData.WeaponUiVisible, visible, notNotify);
		}

		// Token: 0x060271B4 RID: 160180 RVA: 0x00AF0E58 File Offset: 0x00AEF058
		public bool GetWeaponUiVisible()
		{
			return (bool)base.GetData(EWeaponSkinTabViewData.WeaponUiVisible);
		}

		// Token: 0x060271B5 RID: 160181 RVA: 0x00AF0E66 File Offset: 0x00AEF066
		public void AddEventListener()
		{
			EventSystem.Instance.Add<int, int>(EEventName.EquipWeaponSkin, new Action<int, int>(this.OnEquipWeaponSkin));
			EventSystem.Instance.Add<int>(EEventName.UninstallWeaponSkin, new Action<int>(this.OnUninstallWeaponSkin));
		}

		// Token: 0x060271B6 RID: 160182 RVA: 0x00AF0EA0 File Offset: 0x00AEF0A0
		public void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.EquipWeaponSkin, new Action<int, int>(this.OnEquipWeaponSkin));
			EventSystem.Instance.Remove(EEventName.UninstallWeaponSkin, new Action<int>(this.OnUninstallWeaponSkin));
		}

		// Token: 0x060271B7 RID: 160183 RVA: 0x00AF0EDA File Offset: 0x00AEF0DA
		private void OnEquipWeaponSkin(int roleId, int skinId)
		{
			if (this.ViewData.RoleId != roleId)
			{
				return;
			}
			this.PrevEquipSkinIdInternal = this.GetEquipSkinId();
			this.SetEquipSkinId(skinId, false);
		}

		// Token: 0x060271B8 RID: 160184 RVA: 0x00AF0EFF File Offset: 0x00AEF0FF
		private void OnUninstallWeaponSkin(int roleId)
		{
			if (this.ViewData.RoleId != roleId)
			{
				return;
			}
			this.PrevEquipSkinIdInternal = this.GetEquipSkinId();
			this.SetEquipSkinId(-1, false);
		}

		// Token: 0x060271B9 RID: 160185 RVA: 0x00AF0F24 File Offset: 0x00AEF124
		private void InitSkinWeaponGridDataList()
		{
			int weaponType = WeaponModel.Instance.GetWeaponDataByIncId(this.ViewData.WeaponId).GetWeaponConfig().Value.WeaponType;
			IEnumerable<WeaponSkin> weaponSkinConfigListByType = SkinConfig.Instance.GetWeaponSkinConfigListByType(weaponType);
			int roleId = this.ViewData.RoleId;
			WeaponSkinData item = this.CreateWeaponSkinGridData(-1, roleId);
			List<WeaponSkinData> skinDataList = this.GetSkinDataList();
			skinDataList.Add(item);
			foreach (WeaponSkin weaponSkin in weaponSkinConfigListByType)
			{
				if (!weaponSkin.HideInSkinView)
				{
					WeaponSkinData item2 = this.CreateWeaponSkinGridData(weaponSkin.Id, roleId);
					skinDataList.Add(item2);
				}
			}
		}

		// Token: 0x060271BA RID: 160186 RVA: 0x00AF0FE8 File Offset: 0x00AEF1E8
		private WeaponSkinData CreateWeaponSkinGridData(int skinId, int roleId)
		{
			return new WeaponSkinData(skinId, roleId);
		}

		// Token: 0x060271BB RID: 160187 RVA: 0x00AF0FF4 File Offset: 0x00AEF1F4
		public void InitSelectedWeaponSkinId()
		{
			int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(this.ViewData.RoleId);
			this.SetEquipSkinId(skinIdByRoleId, false);
			int dataIndexBySkinId = this.GetDataIndexBySkinId(skinIdByRoleId);
			List<WeaponSkinData> skinDataList = this.GetSkinDataList();
			this.SetSelectedSkinId(skinDataList[dataIndexBySkinId].SkinId, false);
		}

		// Token: 0x060271BC RID: 160188 RVA: 0x00AF1044 File Offset: 0x00AEF244
		public void RefreshEquipSkinId()
		{
			int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(this.ViewData.RoleId);
			if (this.GetEquipSkinId() != skinIdByRoleId)
			{
				this.SetEquipSkinId(skinIdByRoleId, true);
			}
		}

		// Token: 0x060271BD RID: 160189 RVA: 0x00AF1078 File Offset: 0x00AEF278
		public int GetDataIndexBySkinId(int skinId)
		{
			int num = this.GetSkinDataList().FindIndex((WeaponSkinData data) => data.SkinId == skinId);
			return (num < 0) ? 0 : num;
		}

		// Token: 0x060271BE RID: 160190 RVA: 0x00AF10B4 File Offset: 0x00AEF2B4
		public bool GridItemCanExecuteChange(object parameters)
		{
			int skinId = ((WeaponSkinData)parameters).SkinId;
			return this.GetSelectedSkinId() != skinId;
		}

		// Token: 0x04015522 RID: 87330
		private ISkinViewData ViewData;

		// Token: 0x04015523 RID: 87331
		private int PrevEquipSkinIdInternal = -1;
	}
}
