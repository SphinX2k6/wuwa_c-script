using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E83 RID: 3715
public class TeamPlayerSelectionComponent : UiPanelBase
{
	// Token: 0x060094B0 RID: 38064 RVA: 0x002C1AE3 File Offset: 0x002BFCE3
	[NullableContext(1)]
	public TeamPlayerSelectionComponent(UUIItem parent)
	{
		base.CreateThenShowByActor(parent.GetOwner(), null);
	}

	// Token: 0x060094B1 RID: 38065 RVA: 0x002C1AF8 File Offset: 0x002BFCF8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x060094B2 RID: 38066 RVA: 0x002C1B31 File Offset: 0x002BFD31
	protected override void OnBeforeDestroy()
	{
		this.RoleId = null;
		this.TeamNumber = null;
		this.IsSet = false;
	}

	// Token: 0x060094B3 RID: 38067 RVA: 0x002C1B52 File Offset: 0x002BFD52
	public void SetRoleId(int roleId)
	{
		this.RoleId = new int?(roleId);
	}

	// Token: 0x060094B4 RID: 38068 RVA: 0x002C1B60 File Offset: 0x002BFD60
	public void SetTeamNumber(int teamNumber)
	{
		this.TeamNumber = new int?(teamNumber);
	}

	// Token: 0x060094B5 RID: 38069 RVA: 0x002C1B70 File Offset: 0x002BFD70
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

	// Token: 0x04005734 RID: 22324
	private int? RoleId;

	// Token: 0x04005735 RID: 22325
	private int? TeamNumber;

	// Token: 0x04005736 RID: 22326
	public bool IsSet;
}
