using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002088 RID: 8328
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsWeaponAttributeItem : GridProxyAbstract<ISurvivorsWeaponAttributeData>
{
	// Token: 0x060148B7 RID: 84151 RVA: 0x005FCC8C File Offset: 0x005FAE8C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x060148B8 RID: 84152 RVA: 0x005FCCE8 File Offset: 0x005FAEE8
	[NullableContext(1)]
	public override void Refresh(ISurvivorsWeaponAttributeData data, bool isSelected, int gridIndex)
	{
		SurvivorsWeaponLv? survivorsWeaponLv = SurvivorsRogueConfig.Instance.GetSurvivorsWeaponLv(data.WeaponLvId);
		SurvivorsProperty? propertyConfig = SurvivorsRogueConfig.Instance.GetPropertyConfig(data.AttrId);
		if (propertyConfig == null || survivorsWeaponLv == null)
		{
			return;
		}
		base.SetTextureShowUntilLoaded(propertyConfig.Value.Icon, base.GetTexture(0), null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), survivorsWeaponLv.Value.Describe, Array.Empty<object>());
		base.GetItem(2).SetUIActive(gridIndex % 2 == 0);
	}

	// Token: 0x02008358 RID: 33624
	private static class EAttributeComponents
	{
		// Token: 0x0402A6E1 RID: 173793
		public const int TexIcon = 0;

		// Token: 0x0402A6E2 RID: 173794
		public const int TxtDesc = 1;

		// Token: 0x0402A6E3 RID: 173795
		public const int BgItem = 2;
	}
}
