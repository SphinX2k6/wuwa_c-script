using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001281 RID: 4737
public class FightPhotoRoleItem : GridProxyAbstract<int>
{
	// Token: 0x0600815D RID: 33117 RVA: 0x001B70F0 File Offset: 0x001B52F0
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

	// Token: 0x0600815E RID: 33118 RVA: 0x001B7158 File Offset: 0x001B5358
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

	// Token: 0x0600815F RID: 33119 RVA: 0x001B7207 File Offset: 0x001B5407
	private void OnBtnClick()
	{
		this.OnBtnClickCallback(base.GridIndex);
	}

	// Token: 0x04003AA0 RID: 15008
	[Nullable(1)]
	public Action<int> OnBtnClickCallback = delegate(int index)
	{
	};

	// Token: 0x02007897 RID: 30871
	private enum EComponents
	{
		// Token: 0x04027BC1 RID: 162753
		BtnRoot,
		// Token: 0x04027BC2 RID: 162754
		TextureRole
	}
}
