using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B65 RID: 15205
	public class SkipTaskWeaponRoot : SkipTask
	{
		// Token: 0x06027096 RID: 159894 RVA: 0x00AEDB48 File Offset: 0x00AEBD48
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			int num = (int)data[0];
			WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(num);
			if (weaponDataByIncId == null)
			{
				base.Finish();
				return;
			}
			int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(weaponDataByIncId.GetRoleId());
			WeaponRootViewParam param = new WeaponRootViewParam
			{
				WeaponIncId = num,
				WeaponSkinId = skinIdByRoleId,
				IsFromRoleRootView = false
			};
			UiManager.Instance.OpenView(EUiViewName.WeaponRootView, param, null);
			base.Finish();
		}
	}
}
