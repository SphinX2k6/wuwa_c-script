using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001188 RID: 4488
public class BabelTowerSettlementRoleItem : GridProxyAbstract<int>
{
	// Token: 0x060076AE RID: 30382 RVA: 0x0018B24C File Offset: 0x0018944C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060076AF RID: 30383 RVA: 0x0018B294 File Offset: 0x00189494
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		RoleInfo value = RoleConfig.Instance.GetRoleConfig(data).Value;
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(data, true);
		int num = (roleDataById != null) ? roleDataById.GetRoleSkinId() : value.SkinId;
		RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(num);
		UUITexture texture = base.GetTexture(0);
		if (roleSkinConfig != null)
		{
			base.SetTextureByPath(roleSkinConfig.GetValueOrDefault().Card, texture, null, null);
			return;
		}
		base.SetRoleSkinIcon(value.Card, texture, num, null, null);
	}

	// Token: 0x02007764 RID: 30564
	private class EComponent
	{
		// Token: 0x0402761B RID: 161307
		public const int IconTexture = 0;
	}
}
