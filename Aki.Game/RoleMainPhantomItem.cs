using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001E58 RID: 7768
public class RoleMainPhantomItem : RolePhantomItem
{
	// Token: 0x0601337F RID: 78719 RVA: 0x0059DF16 File Offset: 0x0059C116
	[NullableContext(1)]
	public RoleMainPhantomItem(UUIItem uiItem, Action<int> onFunction, EPhantomItemIndex index) : base(uiItem, onFunction, index)
	{
	}

	// Token: 0x06013380 RID: 78720 RVA: 0x0059DF24 File Offset: 0x0059C124
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(base.OnClick))
		};
	}

	// Token: 0x06013381 RID: 78721 RVA: 0x0059DFE3 File Offset: 0x0059C1E3
	protected override void OnStart()
	{
		this.SkillButtonCompose = new SkillButtonCompose(base.GetItem(3), new Action(base.OnClickSkillButton));
	}

	// Token: 0x06013382 RID: 78722 RVA: 0x0059E003 File Offset: 0x0059C203
	public override void UpdateItem(int id)
	{
		base.UpdateItem(id);
		this.SkillButtonCompose.Update(id);
	}

	// Token: 0x0400A4A0 RID: 42144
	[Nullable(2)]
	private SkillButtonCompose SkillButtonCompose;

	// Token: 0x02008133 RID: 33075
	private enum EPhantomItemDefine
	{
		// Token: 0x04029C79 RID: 171129
		ItemButton,
		// Token: 0x04029C7A RID: 171130
		PhantomIconTexture,
		// Token: 0x04029C7B RID: 171131
		QualitySprite,
		// Token: 0x04029C7C RID: 171132
		EquipSkillItem,
		// Token: 0x04029C7D RID: 171133
		LevelItem,
		// Token: 0x04029C7E RID: 171134
		LevelText
	}
}
