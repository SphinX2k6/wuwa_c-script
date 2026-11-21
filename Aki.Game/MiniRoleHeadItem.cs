using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E0A RID: 3594
public class MiniRoleHeadItem : UiPanelBase
{
	// Token: 0x06009128 RID: 37160 RVA: 0x002B7854 File Offset: 0x002B5A54
	[NullableContext(1)]
	public MiniRoleHeadItem(UUIItem parentUiItem, int roleConfigId)
	{
		base.CreateThenShowByResourceIdAsync("UiItem_MiniRoleHead_Prefab", parentUiItem, false);
		this.RoleConfigId = roleConfigId;
	}

	// Token: 0x06009129 RID: 37161 RVA: 0x002B7871 File Offset: 0x002B5A71
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x0600912A RID: 37162 RVA: 0x002B7894 File Offset: 0x002B5A94
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

	// Token: 0x04005607 RID: 22023
	private readonly int RoleConfigId;

	// Token: 0x02007039 RID: 28729
	private enum EChildType
	{
		// Token: 0x040249E0 RID: 149984
		RoleHeadTexture
	}
}
