using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E09 RID: 3593
public class MiniElementReactionItem : UiPanelBase
{
	// Token: 0x06009125 RID: 37157 RVA: 0x002B77DE File Offset: 0x002B59DE
	[NullableContext(1)]
	public MiniElementReactionItem(AActor rootActor)
	{
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x06009126 RID: 37158 RVA: 0x002B77EE File Offset: 0x002B59EE
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x06009127 RID: 37159 RVA: 0x002B7828 File Offset: 0x002B5A28
	public void SetReactionActivated(bool bActivated)
	{
		UUISprite sprite = base.GetSprite(0);
		UUIItem texture = base.GetTexture(1);
		sprite.SetUIActive(!bActivated);
		texture.SetUIActive(bActivated);
	}

	// Token: 0x02007038 RID: 28728
	private enum EChildType
	{
		// Token: 0x040249DD RID: 149981
		DeactivateSprite,
		// Token: 0x040249DE RID: 149982
		ReactionTexture
	}
}
