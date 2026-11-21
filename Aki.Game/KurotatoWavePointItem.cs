using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001175 RID: 4469
public class KurotatoWavePointItem : UiPanelBase
{
	// Token: 0x0600B221 RID: 45601 RVA: 0x00349E62 File Offset: 0x00348062
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600B222 RID: 45602 RVA: 0x00349E85 File Offset: 0x00348085
	public void SetLightVisible(bool visible)
	{
		base.GetSprite(0).SetUIActive(visible);
	}

	// Token: 0x02007424 RID: 29732
	private static class EComponentDefine
	{
		// Token: 0x04025CDD RID: 154845
		public const int SpriteLight = 0;
	}
}
