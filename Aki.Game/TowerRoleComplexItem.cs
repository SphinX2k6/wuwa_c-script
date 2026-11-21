using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002181 RID: 8577
public class TowerRoleComplexItem : UiPanelBase
{
	// Token: 0x060150B5 RID: 86197 RVA: 0x00622770 File Offset: 0x00620970
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

	// Token: 0x060150B6 RID: 86198 RVA: 0x0062283C File Offset: 0x00620A3C
	protected override void OnStart()
	{
		base.GetItem(2).SetUIActive(true);
		base.GetText(3).SetUIActive(false);
		base.GetSprite(4).SetUIActive(false);
	}

	// Token: 0x060150B7 RID: 86199 RVA: 0x00622868 File Offset: 0x00620A68
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

	// Token: 0x02008414 RID: 33812
	private enum EChildType
	{
		// Token: 0x0402A9D9 RID: 174553
		BgQualitySprite,
		// Token: 0x0402A9DA RID: 174554
		RoleIcon,
		// Token: 0x0402A9DB RID: 174555
		RoleLevelItem,
		// Token: 0x0402A9DC RID: 174556
		RoleLevelText,
		// Token: 0x0402A9DD RID: 174557
		BgRoleLevelText
	}
}
