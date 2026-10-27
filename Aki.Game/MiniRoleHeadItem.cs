using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200194D RID: 6477
public class MiniRoleHeadItem : UiPanelBase
{
	// Token: 0x0600BD25 RID: 48421 RVA: 0x002ACA10 File Offset: 0x002AAC10
	[NullableContext(1)]
	public MiniRoleHeadItem(UUIItem parentUiItem, int roleConfigId)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_MiniRoleHead_Prefab", parentUiItem, false);
		this.RoleConfigId = roleConfigId;
	}

	// Token: 0x0600BD26 RID: 48422 RVA: 0x002ACA2D File Offset: 0x002AAC2D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x0600BD27 RID: 48423 RVA: 0x002ACA50 File Offset: 0x002AAC50
	protected override void OnStart()
	{
		UUITexture texture = base.GetTexture(0);
		if (texture == null)
		{
			return;
		}
		RoleInfo? config = ConfigRoleInfoById.GetConfig(this.RoleConfigId, true);
		if (config == null)
		{
			return;
		}
		string roleHeadIconBig = config.Value.RoleHeadIconBig;
		if (string.IsNullOrEmpty(roleHeadIconBig))
		{
			return;
		}
		base.SetRoleIcon(roleHeadIconBig, texture, this.RoleConfigId, null, null);
	}

	// Token: 0x0400555A RID: 21850
	private readonly int RoleConfigId;

	// Token: 0x02007EAA RID: 32426
	private enum EChildType
	{
		// Token: 0x040296A3 RID: 169635
		RoleHeadTexture
	}
}
