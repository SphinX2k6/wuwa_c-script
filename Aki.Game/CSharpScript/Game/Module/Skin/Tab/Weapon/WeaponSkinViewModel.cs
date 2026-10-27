using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Skin.Tab.Weapon
{
	// Token: 0x02004BE9 RID: 19433
	[NullableContext(1)]
	[Nullable(0)]
	public class WeaponSkinViewModel : ViewModelBase<EWeaponSkinTabViewData>
	{
		// Token: 0x17007C6B RID: 31851
		// (get) Token: 0x06032405 RID: 205829 RVA: 0x00BAC7D6 File Offset: 0x00BAA9D6
		public int PrevEquipSkinId
		{
			get
			{
				return this.PrevEquipSkinIdInternal;
			}
		}

		// Token: 0x06032406 RID: 205830 RVA: 0x00BAC7E0 File Offset: 0x00BAA9E0
		public WeaponSkinViewModel()
		{
			List<WeaponSkinData> value = new List<WeaponSkinData>();
			this.DataMap[EWeaponSkinTabViewData.SkinDataList] = value;
			this.DataMap[EWeaponSkinTabViewData.IsInShowWeapon] = false;
			this.DataMap[EWeaponSkinTabViewData.EquipSkinId] = null;
			this.DataMap[EWeaponSkinTabViewData.SelectedSkinId] = null;
			this.DataMap[EWeaponSkinTabViewData.WeaponUiVisible] = true;
		}

		// Token: 0x06032407 RID: 205831 RVA: 0x00BAC84B File Offset: 0x00BAAA4B
		public void Init(ISkinViewData viewData)
		{
			this.ViewData = viewData;
			this.InitSkinWeaponGridDataList();
			this.InitSelectedWeaponSkinId();
		}

		// Token: 0x06032408 RID: 205832 RVA: 0x00BAC860 File Offset: 0x00BAAA60
		public void SetIsInShowWeapon(bool showWeapon, bool notNotify = false)
		{
			base.SetData(EWeaponSkinTabViewData.IsInShowWeapon, showWeapon, notNotify);
		}

		// Token: 0x06032409 RID: 205833 RVA: 0x00BAC870 File Offset: 0x00BAAA70
		public bool GetIsInShowWeapon()
		{
			return (bool)base.GetData(EWeaponSkinTabViewData.IsInShowWeapon);
		}

		// Token: 0x0603240A RID: 205834 RVA: 0x00BAC87E File Offset: 0x00BAAA7E
		public void SetEquipSkinId(int equipSkinId, bool notNotify = false)
		{
			base.SetData(EWeaponSkinTabViewData.EquipSkinId, equipSkinId, notNotify);
		}

		// Token: 0x0603240B RID: 205835 RVA: 0x00BAC88E File Offset: 0x00BAAA8E
		public int GetEquipSkinId()
		{
			return (int)base.GetData(EWeaponSkinTabViewData.EquipSkinId);
		}

		// Token: 0x0603240C RID: 205836 RVA: 0x00BAC89C File Offset: 0x00BAAA9C
		public void SetSelectedSkinId(int skinId, bool notNotify = false)
		{
			base.SetData(EWeaponSkinTabViewData.SelectedSkinId, skinId, notNotify);
		}

		// Token: 0x0603240D RID: 205837 RVA: 0x00BAC8AC File Offset: 0x00BAAAAC
		public int GetSelectedSkinId()
		{
			return (int)base.GetData(EWeaponSkinTabViewData.SelectedSkinId);
		}

		// Token: 0x0603240E RID: 205838 RVA: 0x00BAC8BA File Offset: 0x00BAAABA
		public List<WeaponSkinData> GetSkinDataList()
		{
			return (List<WeaponSkinData>)base.GetData(EWeaponSkinTabViewData.SkinDataList);
		}

		// Token: 0x0603240F RID: 205839 RVA: 0x00BAC8C8 File Offset: 0x00BAAAC8
		public void SetWeaponUiVisible(bool visible, bool notNotify = false)
		{
			base.SetData(EWeaponSkinTabViewData.WeaponUiVisible, visible, notNotify);
		}

		// Token: 0x06032410 RID: 205840 RVA: 0x00BAC8D8 File Offset: 0x00BAAAD8
		public bool GetWeaponUiVisible()
		{
			return (bool)base.GetData(EWeaponSkinTabViewData.WeaponUiVisible);
		}

		// Token: 0x06032411 RID: 205841 RVA: 0x00BAC8E6 File Offset: 0x00BAAAE6
		public void AddEventListener()
		{
			EventSystem.Instance.Add<int, int>(EEventName.EquipWeaponSkin, new Action<int, int>(this.OnEquipWeaponSkin));
			EventSystem.Instance.Add<int>(EEventName.UninstallWeaponSkin, new Action<int>(this.OnUninstallWeaponSkin));
		}

		// Token: 0x06032412 RID: 205842 RVA: 0x00BAC920 File Offset: 0x00BAAB20
		public void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.EquipWeaponSkin, new Action<int, int>(this.OnEquipWeaponSkin));
			EventSystem.Instance.Remove(EEventName.UninstallWeaponSkin, new Action<int>(this.OnUninstallWeaponSkin));
		}

		// Token: 0x06032413 RID: 205843 RVA: 0x00BAC95A File Offset: 0x00BAAB5A
		private void OnEquipWeaponSkin(int roleId, int skinId)
		{
			if (this.ViewData.RoleId != roleId)
			{
				return;
			}
			this.PrevEquipSkinIdInternal = this.GetEquipSkinId();
			this.SetEquipSkinId(skinId, false);
		}

		// Token: 0x06032414 RID: 205844 RVA: 0x00BAC97F File Offset: 0x00BAAB7F
		private void OnUninstallWeaponSkin(int roleId)
		{
			if (this.ViewData.RoleId != roleId)
			{
				return;
			}
			this.PrevEquipSkinIdInternal = this.GetEquipSkinId();
			this.SetEquipSkinId(-1, false);
		}

		// Token: 0x06032415 RID: 205845 RVA: 0x00BAC9A4 File Offset: 0x00BAABA4
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

		// Token: 0x06032416 RID: 205846 RVA: 0x00BACA68 File Offset: 0x00BAAC68
		private WeaponSkinData CreateWeaponSkinGridData(int skinId, int roleId)
		{
			return new WeaponSkinData(skinId, roleId);
		}

		// Token: 0x06032417 RID: 205847 RVA: 0x00BACA74 File Offset: 0x00BAAC74
		public void InitSelectedWeaponSkinId()
		{
			int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(this.ViewData.RoleId);
			this.SetEquipSkinId(skinIdByRoleId, false);
			int dataIndexBySkinId = this.GetDataIndexBySkinId(skinIdByRoleId);
			List<WeaponSkinData> skinDataList = this.GetSkinDataList();
			this.SetSelectedSkinId(skinDataList[dataIndexBySkinId].SkinId, false);
		}

		// Token: 0x06032418 RID: 205848 RVA: 0x00BACAC4 File Offset: 0x00BAACC4
		public void RefreshEquipSkinId()
		{
			int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(this.ViewData.RoleId);
			if (this.GetEquipSkinId() != skinIdByRoleId)
			{
				this.SetEquipSkinId(skinIdByRoleId, true);
			}
		}

		// Token: 0x06032419 RID: 205849 RVA: 0x00BACAF8 File Offset: 0x00BAACF8
		public int GetDataIndexBySkinId(int skinId)
		{
			int num = this.GetSkinDataList().FindIndex((WeaponSkinData data) => data.SkinId == skinId);
			return (num < 0) ? 0 : num;
		}

		// Token: 0x0603241A RID: 205850 RVA: 0x00BACB34 File Offset: 0x00BAAD34
		public bool GridItemCanExecuteChange(object parameters)
		{
			int skinId = ((WeaponSkinData)parameters).SkinId;
			return this.GetSelectedSkinId() != skinId;
		}

		// Token: 0x0401ABC7 RID: 109511
		private ISkinViewData ViewData;

		// Token: 0x0401ABC8 RID: 109512
		private int PrevEquipSkinIdInternal = -1;
	}
}
