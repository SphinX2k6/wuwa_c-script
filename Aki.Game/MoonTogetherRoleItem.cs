using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020029FF RID: 10751
public class MoonTogetherRoleItem : UiPanelBase
{
	// Token: 0x060164EB RID: 91371 RVA: 0x005A5294 File Offset: 0x005A3494
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

	// Token: 0x060164EC RID: 91372 RVA: 0x005A531A File Offset: 0x005A351A
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

	// Token: 0x060164ED RID: 91373 RVA: 0x005A5340 File Offset: 0x005A3540
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

	// Token: 0x060164EE RID: 91374 RVA: 0x005A53EF File Offset: 0x005A35EF
	private void OnSetRoleSkinIcon(bool success)
	{
		UUITexture texture = base.GetTexture(2);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(true);
	}

	// Token: 0x0200903C RID: 36924
	private class EMoonTogetherRoleItem
	{
		// Token: 0x0402EB3F RID: 191295
		public const int Toggle = 0;

		// Token: 0x0402EB40 RID: 191296
		public const int EmptyTexture = 1;

		// Token: 0x0402EB41 RID: 191297
		public const int RoleIconTexture = 2;

		// Token: 0x0402EB42 RID: 191298
		public const int BathNumPanel = 3;

		// Token: 0x0402EB43 RID: 191299
		public const int BathNumText = 4;
	}
}
