using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002C06 RID: 11270
public class TowerRoleComplexItem : UiPanelBase
{
	// Token: 0x06017684 RID: 95876 RVA: 0x005F5C4C File Offset: 0x005F3E4C
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
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06017685 RID: 95877 RVA: 0x005F5D18 File Offset: 0x005F3F18
	protected override void OnStart()
	{
		base.GetItem(2).SetUIActive(true);
		base.GetText(3).SetUIActive(false);
		base.GetSprite(4).SetUIActive(false);
	}

	// Token: 0x06017686 RID: 95878 RVA: 0x005F5D44 File Offset: 0x005F3F44
	public void RefreshRoleId(int roleId)
	{
		UUITexture texture = base.GetTexture(1);
		UUISprite sprite = base.GetSprite(0);
		if (roleId == 0)
		{
			texture.SetUIActive(false);
			sprite.SetUIActive(false);
			return;
		}
		texture.SetUIActive(true);
		sprite.SetUIActive(true);
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		base.SetRoleIcon(roleConfig.Value.RoleHeadIconBig, texture, roleId, null, null);
		this.SetSpriteByPath(RoleConfig.Instance.GetRoleQualityInfo(roleConfig.Value.QualityId).Value.Image, sprite, false, null, null);
	}

	// Token: 0x020091D1 RID: 37329
	private enum EChildType
	{
		// Token: 0x0402F2D8 RID: 193240
		BgQualitySprite,
		// Token: 0x0402F2D9 RID: 193241
		RoleIcon,
		// Token: 0x0402F2DA RID: 193242
		RoleLevelItem,
		// Token: 0x0402F2DB RID: 193243
		RoleLevelText,
		// Token: 0x0402F2DC RID: 193244
		BgRoleLevelText
	}
}
