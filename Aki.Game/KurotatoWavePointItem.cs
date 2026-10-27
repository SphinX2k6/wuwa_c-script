using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CB3 RID: 7347
public class KurotatoWavePointItem : UiPanelBase
{
	// Token: 0x0600DE04 RID: 56836 RVA: 0x0033E426 File Offset: 0x0033C626
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600DE05 RID: 56837 RVA: 0x0033E449 File Offset: 0x0033C649
	public void SetLightVisible(bool visible)
	{
		base.GetSprite(0).SetUIActive(visible);
	}

	// Token: 0x0200829A RID: 33434
	private static class EComponentDefine
	{
		// Token: 0x0402A9B2 RID: 174514
		public const int SpriteLight = 0;
	}
}
