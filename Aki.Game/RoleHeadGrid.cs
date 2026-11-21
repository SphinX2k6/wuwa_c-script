using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E21 RID: 3617
public class RoleHeadGrid : UiPanelBase
{
	// Token: 0x0600922C RID: 37420 RVA: 0x002BB142 File Offset: 0x002B9342
	[NullableContext(1)]
	public RoleHeadGrid(AActor actor)
	{
		base.CreateThenShowByActor(actor, null);
	}

	// Token: 0x1700100A RID: 4106
	// (get) Token: 0x0600922D RID: 37421 RVA: 0x002BB154 File Offset: 0x002B9354
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

	// Token: 0x0600922E RID: 37422 RVA: 0x002BB183 File Offset: 0x002B9383
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x0600922F RID: 37423 RVA: 0x002BB1A8 File Offset: 0x002B93A8
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

	// Token: 0x06009230 RID: 37424 RVA: 0x002BB204 File Offset: 0x002B9404
	public void Refresh(int roleId)
	{
		this.RoleId = roleId;
		this.UpdateHeadTexture();
	}

	// Token: 0x04005667 RID: 22119
	private int RoleId;

	// Token: 0x02007049 RID: 28745
	private enum EChildType
	{
		// Token: 0x04024A20 RID: 150048
		RoleHeadTexture
	}
}
