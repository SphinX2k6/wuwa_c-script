using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001964 RID: 6500
public class RoleHeadGrid : UiPanelBase
{
	// Token: 0x0600BE29 RID: 48681 RVA: 0x002B02FE File Offset: 0x002AE4FE
	[NullableContext(1)]
	public RoleHeadGrid(AActor actor)
	{
		base.CreateThenShowByActor(actor, null);
	}

	// Token: 0x17000FE6 RID: 4070
	// (get) Token: 0x0600BE2A RID: 48682 RVA: 0x002B0310 File Offset: 0x002AE510
	private RoleInfo? Config
	{
		get
		{
			if (this.RoleId == 0)
			{
				return null;
			}
			return RoleConfig.Instance.GetRoleConfig(this.RoleId);
		}
	}

	// Token: 0x0600BE2B RID: 48683 RVA: 0x002B033F File Offset: 0x002AE53F
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x0600BE2C RID: 48684 RVA: 0x002B0364 File Offset: 0x002AE564
	private void UpdateHeadTexture()
	{
		RoleInfo? config = this.Config;
		if (config == null)
		{
			return;
		}
		UUITexture texture = base.GetTexture(0);
		if (texture == null)
		{
			return;
		}
		string roleHeadIconBig = config.Value.RoleHeadIconBig;
		if (string.IsNullOrEmpty(roleHeadIconBig))
		{
			return;
		}
		base.SetRoleIcon(roleHeadIconBig, texture, this.RoleId, null, null);
	}

	// Token: 0x0600BE2D RID: 48685 RVA: 0x002B03C0 File Offset: 0x002AE5C0
	public void Refresh(int roleId)
	{
		this.RoleId = roleId;
		this.UpdateHeadTexture();
	}

	// Token: 0x040055BA RID: 21946
	private int RoleId;

	// Token: 0x02007EBA RID: 32442
	private enum EChildType
	{
		// Token: 0x040296E3 RID: 169699
		RoleHeadTexture
	}
}
