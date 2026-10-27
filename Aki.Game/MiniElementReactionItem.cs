using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200194C RID: 6476
public class MiniElementReactionItem : UiPanelBase
{
	// Token: 0x0600BD22 RID: 48418 RVA: 0x002AC99A File Offset: 0x002AAB9A
	[NullableContext(1)]
	public MiniElementReactionItem(AActor rootActor)
	{
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x0600BD23 RID: 48419 RVA: 0x002AC9AA File Offset: 0x002AABAA
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x0600BD24 RID: 48420 RVA: 0x002AC9E4 File Offset: 0x002AABE4
	public void SetReactionActivated(bool bActivated)
	{
		UUISprite sprite = base.GetSprite(0);
		UUIItem texture = base.GetTexture(1);
		sprite.SetUIActive(!bActivated);
		texture.SetUIActive(bActivated);
	}

	// Token: 0x02007EA9 RID: 32425
	private enum EChildType
	{
		// Token: 0x040296A0 RID: 169632
		DeactivateSprite,
		// Token: 0x040296A1 RID: 169633
		ReactionTexture
	}
}
