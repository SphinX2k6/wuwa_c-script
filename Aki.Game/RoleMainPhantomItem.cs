using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020028DD RID: 10461
public class RoleMainPhantomItem : RolePhantomItem
{
	// Token: 0x0601597B RID: 88443 RVA: 0x0057304E File Offset: 0x0057124E
	[NullableContext(1)]
	public RoleMainPhantomItem(UUIItem uiItem, Action<int> onFunction, EPhantomItemIndex index) : base(uiItem, onFunction, index)
	{
	}

	// Token: 0x0601597C RID: 88444 RVA: 0x0057305C File Offset: 0x0057125C
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

	// Token: 0x0601597D RID: 88445 RVA: 0x0057311B File Offset: 0x0057131B
	protected override void OnStart()
	{
		this.SkillButtonCompose = new SkillButtonCompose(base.GetItem(3), new Action(base.OnClickSkillButton));
	}

	// Token: 0x0601597E RID: 88446 RVA: 0x0057313B File Offset: 0x0057133B
	public override void UpdateItem(int id)
	{
		base.UpdateItem(id);
		this.SkillButtonCompose.Update(id);
	}

	// Token: 0x0400A0B6 RID: 41142
	[Nullable(2)]
	private SkillButtonCompose SkillButtonCompose;

	// Token: 0x02008EEB RID: 36587
	private enum EPhantomItemDefine
	{
		// Token: 0x0402E57E RID: 189822
		ItemButton,
		// Token: 0x0402E57F RID: 189823
		PhantomIconTexture,
		// Token: 0x0402E580 RID: 189824
		QualitySprite,
		// Token: 0x0402E581 RID: 189825
		EquipSkillItem,
		// Token: 0x0402E582 RID: 189826
		LevelItem,
		// Token: 0x0402E583 RID: 189827
		LevelText
	}
}
