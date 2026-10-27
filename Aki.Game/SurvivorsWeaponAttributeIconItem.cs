using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002B09 RID: 11017
public class SurvivorsWeaponAttributeIconItem : GridProxyAbstract<int>
{
	// Token: 0x06016E7E RID: 93822 RVA: 0x005CFFA0 File Offset: 0x005CE1A0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x06016E7F RID: 93823 RVA: 0x005CFFC4 File Offset: 0x005CE1C4
	public override void Refresh(int attributeId, bool isSelected, int gridIndex)
	{
		SurvivorsProperty? propertyConfig = SurvivorsRogueConfig.Instance.GetPropertyConfig(attributeId);
		if (propertyConfig == null)
		{
			return;
		}
		base.SetTextureShowUntilLoaded(propertyConfig.Value.Icon, base.GetTexture(0), null);
	}

	// Token: 0x02009114 RID: 37140
	private static class EComponents
	{
		// Token: 0x0402EFDB RID: 192475
		public const int TexAttribute = 0;
	}
}
