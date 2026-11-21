using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CEB RID: 7403
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerPropAvatarItem : GridProxyAbstract<RoleTowerPropAvatarData>
{
	// Token: 0x06012548 RID: 75080 RVA: 0x0056865E File Offset: 0x0056685E
	public void SetClickCallback(Action<int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06012549 RID: 75081 RVA: 0x00568668 File Offset: 0x00566868
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTog))
		};
	}

	// Token: 0x0601254A RID: 75082 RVA: 0x005686FB File Offset: 0x005668FB
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x0601254B RID: 75083 RVA: 0x0056870C File Offset: 0x0056690C
	public override void Refresh(RoleTowerPropAvatarData data, bool isSelected, int gridIndex)
	{
		this.RoleId = data.RoleId;
		UUITexture texture = base.GetTexture(1);
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(data.RoleId);
		if (texture != null && roleConfig != null)
		{
			texture.SetUIActive(true);
			base.SetRoleIcon(roleConfig.Value.RoleHeadIconCircle, texture, data.RoleId, null, null);
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(data.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0601254C RID: 75084 RVA: 0x005687BE File Offset: 0x005669BE
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

	// Token: 0x0601254D RID: 75085 RVA: 0x005687DA File Offset: 0x005669DA
	public override object GetKey(RoleTowerPropAvatarData data, int displayIndex)
	{
		return data.RoleId;
	}

	// Token: 0x04009FE0 RID: 40928
	private int RoleId;

	// Token: 0x04009FE1 RID: 40929
	[Nullable(2)]
	private Action<int> ClickCallback;

	// Token: 0x02007FF6 RID: 32758
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402965D RID: 169565
		public const int TogAvatar = 0;

		// Token: 0x0402965E RID: 169566
		public const int TexIcon = 1;

		// Token: 0x0402965F RID: 169567
		public const int PnlLock = 2;

		// Token: 0x04029660 RID: 169568
		public const int UiItemItemTagNew = 3;
	}
}
