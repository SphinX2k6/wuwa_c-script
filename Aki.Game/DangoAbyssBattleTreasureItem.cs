using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A2E RID: 6702
public class DangoAbyssBattleTreasureItem : UiPanelBase
{
	// Token: 0x0600C524 RID: 50468 RVA: 0x002CB7C2 File Offset: 0x002C99C2
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x0600C525 RID: 50469 RVA: 0x002CB7E5 File Offset: 0x002C99E5
	public void RefreshByCurrentPercentage(float currentPercentage)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(this.NeedPercentage <= currentPercentage);
	}

	// Token: 0x04005ADE RID: 23262
	public float NeedPercentage;

	// Token: 0x04005ADF RID: 23263
	public int RewardId;

	// Token: 0x02007F76 RID: 32630
	private enum ERewardTreasureItemComponent
	{
		// Token: 0x040299C4 RID: 170436
		LightSprite
	}
}
