using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002B0C RID: 11020
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsWeaponAttributeItem : GridProxyAbstract<ISurvivorsWeaponAttributeData>
{
	// Token: 0x06016E86 RID: 93830 RVA: 0x005D010C File Offset: 0x005CE30C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06016E87 RID: 93831 RVA: 0x005D0168 File Offset: 0x005CE368
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

	// Token: 0x02009115 RID: 37141
	private static class EAttributeComponents
	{
		// Token: 0x0402EFDC RID: 192476
		public const int TexIcon = 0;

		// Token: 0x0402EFDD RID: 192477
		public const int TxtDesc = 1;

		// Token: 0x0402EFDE RID: 192478
		public const int BgItem = 2;
	}
}
