using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001D03 RID: 7427
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerStarUpRoleAvatarItem : GridProxyAbstract<RoleTowerPropAvatarData>
{
	// Token: 0x06012635 RID: 75317 RVA: 0x0056EB34 File Offset: 0x0056CD34
	public void SetClickCallback(Action<int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06012636 RID: 75318 RVA: 0x0056EB40 File Offset: 0x0056CD40
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUISprite)),
			new ValueTuple<int, Type>(10, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTog))
		};
	}

	// Token: 0x06012637 RID: 75319 RVA: 0x0056EC70 File Offset: 0x0056CE70
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(7);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		UUIItem item4 = base.GetItem(8);
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
		UUISprite sprite = base.GetSprite(9);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		UUISprite sprite2 = base.GetSprite(10);
		if (sprite2 == null)
		{
			return;
		}
		sprite2.SetUIActive(false);
	}

	// Token: 0x06012638 RID: 75320 RVA: 0x0056ED10 File Offset: 0x0056CF10
	public override void Refresh(RoleTowerPropAvatarData data, bool isSelected, int gridIndex)
	{
		this.RoleId = data.RoleId;
		bool flag = data.RoleId > 0;
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		UUIItem item3 = base.GetItem(2);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		UUITexture texture = base.GetTexture(1);
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(data.RoleId);
		if (texture != null && flag && roleConfig != null)
		{
			texture.SetUIActive(true);
			base.SetRoleIcon(roleConfig.Value.RoleHeadIconCircle, texture, data.RoleId, null, null);
		}
		else if (texture != null)
		{
			texture.SetUIActive(false);
		}
		UUISprite sprite = base.GetSprite(10);
		if (sprite != null)
		{
			sprite.SetUIActive(flag && RoleUtils.IsTrialRole(data.RoleId));
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(data.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06012639 RID: 75321 RVA: 0x0056EE18 File Offset: 0x0056D018
	private void OnClickTog(EToggleState check)
	{
		if (check == EToggleState.ETT_Checked)
		{
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.RoleId);
		}
	}

	// Token: 0x0601263A RID: 75322 RVA: 0x0056EE34 File Offset: 0x0056D034
	public override object GetKey(RoleTowerPropAvatarData data, int displayIndex)
	{
		return data.RoleId;
	}

	// Token: 0x0400A03D RID: 41021
	private int RoleId;

	// Token: 0x0400A03E RID: 41022
	[Nullable(2)]
	private Action<int> ClickCallback;

	// Token: 0x0200802E RID: 32814
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402979F RID: 169887
		public const int TogAvatar = 0;

		// Token: 0x040297A0 RID: 169888
		public const int TexRole = 1;

		// Token: 0x040297A1 RID: 169889
		public const int PnlCost = 2;

		// Token: 0x040297A2 RID: 169890
		public const int TxtNum = 3;

		// Token: 0x040297A3 RID: 169891
		public const int PnlUpArrow = 4;

		// Token: 0x040297A4 RID: 169892
		public const int PnlAvatar = 5;

		// Token: 0x040297A5 RID: 169893
		public const int PnlEmpty = 6;

		// Token: 0x040297A6 RID: 169894
		public const int PnlWarning = 7;

		// Token: 0x040297A7 RID: 169895
		public const int PnlEmptyRole = 8;

		// Token: 0x040297A8 RID: 169896
		public const int SprBuff = 9;

		// Token: 0x040297A9 RID: 169897
		public const int SprRoleTrial = 10;
	}
}
