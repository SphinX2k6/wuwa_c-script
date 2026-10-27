using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019C4 RID: 6596
public class TeamPlayerSelectionComponent : UiPanelBase
{
	// Token: 0x0600C0A3 RID: 49315 RVA: 0x002B6B39 File Offset: 0x002B4D39
	[NullableContext(1)]
	public TeamPlayerSelectionComponent(UUIItem parent)
	{
		base.CreateThenShowByActor(parent.GetOwner(), null);
	}

	// Token: 0x0600C0A4 RID: 49316 RVA: 0x002B6B4E File Offset: 0x002B4D4E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x0600C0A5 RID: 49317 RVA: 0x002B6B87 File Offset: 0x002B4D87
	protected override void OnBeforeDestroy()
	{
		this.RoleId = null;
		this.TeamNumber = null;
		this.IsSet = false;
	}

	// Token: 0x0600C0A6 RID: 49318 RVA: 0x002B6BA8 File Offset: 0x002B4DA8
	public void SetRoleId(int roleId)
	{
		this.RoleId = new int?(roleId);
	}

	// Token: 0x0600C0A7 RID: 49319 RVA: 0x002B6BB6 File Offset: 0x002B4DB6
	public void SetTeamNumber(int teamNumber)
	{
		this.TeamNumber = new int?(teamNumber);
	}

	// Token: 0x0600C0A8 RID: 49320 RVA: 0x002B6BC4 File Offset: 0x002B4DC4
	public void RefreshItem()
	{
		UUITexture texture = base.GetTexture(0);
		string roleHeadIconBig = RoleConfig.Instance.GetRoleConfig(this.RoleId.Value).Value.RoleHeadIconBig;
		base.SetTextureByPath(roleHeadIconBig, texture, null, null);
		UUISprite sprite = base.GetSprite(1);
		UiResourceConfig instance = UiResourceConfig.Instance;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SP_Online");
		defaultInterpolatedStringHandler.AppendFormatted<int?>(this.TeamNumber);
		defaultInterpolatedStringHandler.AppendLiteral("PIcon");
		string resourcePath = instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
		this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		this.IsSet = true;
	}

	// Token: 0x04005682 RID: 22146
	private int? RoleId;

	// Token: 0x04005683 RID: 22147
	private int? TeamNumber;

	// Token: 0x04005684 RID: 22148
	public bool IsSet;
}
