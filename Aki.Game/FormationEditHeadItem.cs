using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020010C2 RID: 4290
public class FormationEditHeadItem : GridProxyAbstract<int>
{
	// Token: 0x0600AA56 RID: 43606 RVA: 0x00323D48 File Offset: 0x00321F48
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600AA57 RID: 43607 RVA: 0x00323E14 File Offset: 0x00322014
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		RoleInfo? roleInfo = (roleId > 0) ? RoleConfig.Instance.GetRoleConfig(roleId) : null;
		UUISprite sprite = base.GetSprite(0);
		UUITexture texture = base.GetTexture(1);
		UUISprite sprite2 = base.GetSprite(2);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(roleInfo == null);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(roleInfo != null);
		}
		if (roleInfo == null)
		{
			sprite.SetUIActive(false);
			texture.SetUIActive(false);
			sprite2.SetUIActive(false);
			return;
		}
		sprite.SetUIActive(true);
		RoleQualityInfo? roleQualityInfo = RoleConfig.Instance.GetRoleQualityInfo(roleInfo.Value.QualityId);
		if (roleQualityInfo != null)
		{
			sprite.SetColor(FColor.FromHex(roleQualityInfo.Value.QualityColor));
		}
		texture.SetUIActive(true);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		int num = (roleDataById != null) ? roleDataById.GetRoleSkinId() : 0;
		RoleSkin? roleSkin = (num != 0) ? SkinConfig.Instance.GetRoleSkinConfig(num) : null;
		string path = (roleSkin != null) ? roleSkin.Value.RoleHeadIcon : roleInfo.Value.RoleHeadIcon;
		base.SetTextureByPath(path, texture, null, null);
		int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(roleId);
		bool flag = roleSkillBranchIndexInCurrentGamePlay > -1;
		sprite2.SetUIActive(flag);
		if (flag)
		{
			UUIItem uuiitem = sprite2;
			FRotator frotator = new FRotator(0f, (float)((roleSkillBranchIndexInCurrentGamePlay == 0) ? 0 : 180), 0f);
			uuiitem.SetUIRelativeRotation(frotator);
		}
	}

	// Token: 0x02007339 RID: 29497
	private enum EHeadChildType
	{
		// Token: 0x0402583C RID: 153660
		SpriteQuality,
		// Token: 0x0402583D RID: 153661
		TexRoleIcon,
		// Token: 0x0402583E RID: 153662
		SpriteTagIcon,
		// Token: 0x0402583F RID: 153663
		PanelRoleHead,
		// Token: 0x04025840 RID: 153664
		SpriteEmpty
	}
}
