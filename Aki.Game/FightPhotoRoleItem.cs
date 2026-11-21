using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000735 RID: 1845
public class FightPhotoRoleItem : GridProxyAbstract<int>
{
	// Token: 0x060054F4 RID: 21748 RVA: 0x001BFDC0 File Offset: 0x001BDFC0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClick))
		};
	}

	// Token: 0x060054F5 RID: 21749 RVA: 0x001BFE28 File Offset: 0x001BE028
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		UUITexture texture = base.GetTexture(1);
		if (roleId == 0)
		{
			texture.SetUIActive(false);
			return;
		}
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		int? num = (roleDataById != null) ? new int?(roleDataById.GetRoleSkinId()) : null;
		if (num == null || num.Value == 0)
		{
			num = new int?(ConfigRoleInfoById.GetConfig(roleId, true).Value.SkinId);
		}
		base.SetTextureByPath(ConfigRoleSkinById.GetConfig(num.Value, true).Value.RoleHeadIcon, texture, null, null);
		texture.SetUIActive(true);
	}

	// Token: 0x060054F6 RID: 21750 RVA: 0x001BFED7 File Offset: 0x001BE0D7
	private void OnBtnClick()
	{
		this.OnBtnClickCallback(base.GridIndex);
	}

	// Token: 0x04003B38 RID: 15160
	[Nullable(1)]
	public Action<int> OnBtnClickCallback = delegate(int index)
	{
	};

	// Token: 0x02006A22 RID: 27170
	private enum EComponents
	{
		// Token: 0x04022EF2 RID: 143090
		BtnRoot,
		// Token: 0x04022EF3 RID: 143091
		TextureRole
	}
}
