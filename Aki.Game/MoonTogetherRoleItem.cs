using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F7A RID: 8058
public class MoonTogetherRoleItem : UiPanelBase
{
	// Token: 0x06013EF2 RID: 81650 RVA: 0x005D026C File Offset: 0x005CE46C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
	}

	// Token: 0x06013EF3 RID: 81651 RVA: 0x005D02F2 File Offset: 0x005CE4F2
	protected override void OnStart()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06013EF4 RID: 81652 RVA: 0x005D0318 File Offset: 0x005CE518
	public void RefreshRoleInfo(int roleId)
	{
		if (roleId > 0)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			UUITexture texture2 = base.GetTexture(2);
			if (texture2 != null)
			{
				texture2.SetUIActive(true);
			}
			int roleSkinId = RoleModel.Instance.GetRoleInstanceById(roleId).GetRoleSkinId();
			string roleHeadIconCircle = SkinConfig.Instance.GetRoleSkinConfig(roleSkinId).Value.RoleHeadIconCircle;
			base.SetRoleSkinIcon(roleHeadIconCircle, base.GetTexture(2), roleSkinId, null, new Action<bool>(this.OnSetRoleSkinIcon));
			return;
		}
		UUITexture texture3 = base.GetTexture(1);
		if (texture3 != null)
		{
			texture3.SetUIActive(true);
		}
		UUITexture texture4 = base.GetTexture(2);
		if (texture4 == null)
		{
			return;
		}
		texture4.SetUIActive(false);
	}

	// Token: 0x06013EF5 RID: 81653 RVA: 0x005D03C7 File Offset: 0x005CE5C7
	private void OnSetRoleSkinIcon(bool success)
	{
		UUITexture texture = base.GetTexture(2);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(true);
	}

	// Token: 0x02008283 RID: 33411
	private class EMoonTogetherRoleItem
	{
		// Token: 0x0402A237 RID: 172599
		public const int Toggle = 0;

		// Token: 0x0402A238 RID: 172600
		public const int EmptyTexture = 1;

		// Token: 0x0402A239 RID: 172601
		public const int RoleIconTexture = 2;

		// Token: 0x0402A23A RID: 172602
		public const int BathNumPanel = 3;

		// Token: 0x0402A23B RID: 172603
		public const int BathNumText = 4;
	}
}
