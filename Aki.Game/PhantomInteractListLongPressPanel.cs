using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002482 RID: 9346
public class PhantomInteractListLongPressPanel : UiPanelBase
{
	// Token: 0x06012C0B RID: 76811 RVA: 0x004A02BE File Offset: 0x0049E4BE
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x06012C0C RID: 76812 RVA: 0x004A02E4 File Offset: 0x0049E4E4
	public void SetFillProgress(float progress)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetFillAmount(progress);
		}
	}

	// Token: 0x020089F8 RID: 35320
	private enum EComponent
	{
		// Token: 0x0402CCE3 RID: 183523
		SpriteFill
	}
}
