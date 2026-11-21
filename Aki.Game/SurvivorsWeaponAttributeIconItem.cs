using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002085 RID: 8325
public class SurvivorsWeaponAttributeIconItem : GridProxyAbstract<int>
{
	// Token: 0x060148AF RID: 84143 RVA: 0x005FCB20 File Offset: 0x005FAD20
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x060148B0 RID: 84144 RVA: 0x005FCB44 File Offset: 0x005FAD44
	public override void Refresh(int attributeId, bool isSelected, int gridIndex)
	{
		SurvivorsProperty? propertyConfig = SurvivorsRogueConfig.Instance.GetPropertyConfig(attributeId);
		if (propertyConfig == null)
		{
			return;
		}
		base.SetTextureShowUntilLoaded(propertyConfig.Value.Icon, base.GetTexture(0), null);
	}

	// Token: 0x02008357 RID: 33623
	private static class EComponents
	{
		// Token: 0x0402A6E0 RID: 173792
		public const int TexAttribute = 0;
	}
}
