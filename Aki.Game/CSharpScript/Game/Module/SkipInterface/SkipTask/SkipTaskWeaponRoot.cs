using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BBB RID: 19387
	public class SkipTaskWeaponRoot : SkipTask
	{
		// Token: 0x06032305 RID: 205573 RVA: 0x00BA989C File Offset: 0x00BA7A9C
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
