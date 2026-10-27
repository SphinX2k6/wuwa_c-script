using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002B6D RID: 11117
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRogueWeaponEvolveItem : GridProxyAbstract<IWeaponEvolveData>
{
	// Token: 0x0601707B RID: 94331 RVA: 0x005D8A80 File Offset: 0x005D6C80
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x0601707C RID: 94332 RVA: 0x005D8B06 File Offset: 0x005D6D06
	protected override void OnStart()
	{
	}

	// Token: 0x0601707D RID: 94333 RVA: 0x005D8B08 File Offset: 0x005D6D08
	public override void Refresh(IWeaponEvolveData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		bool isUnlock = data.IsUnlock;
		base.GetItem(2).SetUIActive(isUnlock);
		base.GetItem(4).SetUIActive(data.ShowLine);
		base.GetItem(5).SetUIActive(data.ShowLine);
		SurvivorsWeaponEvolve? survivorsWeaponEvolve = SurvivorsRogueConfig.Instance.GetSurvivorsWeaponEvolve(data.EvolveId);
		if (survivorsWeaponEvolve == null)
		{
			return;
		}
		SurvivorsQuality? qualityConfig = SurvivorsRogueConfig.Instance.GetQualityConfig(survivorsWeaponEvolve.Value.Quality);
		if (qualityConfig == null)
		{
			return;
		}
		UUISprite sprite = base.GetSprite(1);
		UUISprite sprite2 = base.GetSprite(3);
		if (isUnlock)
		{
			sprite2.SetColor(FColor.FromHex(qualityConfig.Value.EvolveColor));
			sprite.SetUIActive(false);
			sprite2.SetUIActive(true);
			return;
		}
		sprite.SetColor(FColor.FromHex(qualityConfig.Value.EvolveColor));
		sprite.SetUIActive(true);
		sprite2.SetUIActive(false);
	}

	// Token: 0x0400AC35 RID: 44085
	public IWeaponEvolveData Data;
}
