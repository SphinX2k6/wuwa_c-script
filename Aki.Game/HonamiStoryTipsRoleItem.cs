using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EB5 RID: 7861
public class HonamiStoryTipsRoleItem : UiPanelBase
{
	// Token: 0x0600F1C4 RID: 61892 RVA: 0x003A31DC File Offset: 0x003A13DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x0600F1C5 RID: 61893 RVA: 0x003A3236 File Offset: 0x003A1436
	protected override void OnStart()
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetPivot(new FVector2D(0f, 0f));
	}

	// Token: 0x0600F1C6 RID: 61894 RVA: 0x003A3258 File Offset: 0x003A1458
	public void Refresh(int id)
	{
		base.SetRoleIcon(RoleConfig.Instance.GetRoleConfig(id).Value.RoleHeadIconCircle, base.GetTexture(0), id, null, null);
	}

	// Token: 0x02008491 RID: 33937
	private enum ERole
	{
		// Token: 0x0402B271 RID: 176753
		Icon,
		// Token: 0x0402B272 RID: 176754
		Sprite,
		// Token: 0x0402B273 RID: 176755
		SpriteBg
	}
}
