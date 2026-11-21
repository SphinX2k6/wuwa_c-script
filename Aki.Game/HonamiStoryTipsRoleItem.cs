using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001377 RID: 4983
public class HonamiStoryTipsRoleItem : UiPanelBase
{
	// Token: 0x0600C5E3 RID: 50659 RVA: 0x003AECDC File Offset: 0x003ACEDC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x0600C5E4 RID: 50660 RVA: 0x003AED36 File Offset: 0x003ACF36
	protected override void OnStart()
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetPivot(new FVector2D(0f, 0f));
	}

	// Token: 0x0600C5E5 RID: 50661 RVA: 0x003AED58 File Offset: 0x003ACF58
	public void Refresh(int id)
	{
		base.SetRoleIcon(RoleConfig.Instance.GetRoleConfig(id).Value.RoleHeadIconCircle, base.GetTexture(0), id, null, null);
	}

	// Token: 0x02007616 RID: 30230
	private enum ERole
	{
		// Token: 0x04026595 RID: 157077
		Icon,
		// Token: 0x04026596 RID: 157078
		Sprite,
		// Token: 0x04026597 RID: 157079
		SpriteBg
	}
}
