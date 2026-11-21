using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001967 RID: 6503
public class PhantomInteractListLongPressPanel : UiPanelBase
{
	// Token: 0x060100C2 RID: 65730 RVA: 0x004ADA16 File Offset: 0x004ABC16
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x060100C3 RID: 65731 RVA: 0x004ADA3C File Offset: 0x004ABC3C
	public void SetFillProgress(float progress)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetFillAmount(progress);
		}
	}

	// Token: 0x02007B7F RID: 31615
	private enum EComponent
	{
		// Token: 0x04027FF9 RID: 163833
		SpriteFill
	}
}
