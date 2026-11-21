using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000EED RID: 3821
public class DangoAbyssBattleTreasureItem : UiPanelBase
{
	// Token: 0x06009934 RID: 39220 RVA: 0x002D68E2 File Offset: 0x002D4AE2
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x06009935 RID: 39221 RVA: 0x002D6905 File Offset: 0x002D4B05
	public void RefreshByCurrentPercentage(float currentPercentage)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(this.NeedPercentage <= currentPercentage);
	}

	// Token: 0x04005BAD RID: 23469
	public float NeedPercentage;

	// Token: 0x04005BAE RID: 23470
	public int RewardId;

	// Token: 0x02007105 RID: 28933
	private enum ERewardTreasureItemComponent
	{
		// Token: 0x04024D01 RID: 150785
		LightSprite
	}
}
