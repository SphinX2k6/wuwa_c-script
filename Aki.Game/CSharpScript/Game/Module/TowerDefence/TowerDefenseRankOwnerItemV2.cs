using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B2B RID: 19243
	public class TowerDefenseRankOwnerItemV2 : TowerDefenseRankItemV2
	{
		// Token: 0x06031D6E RID: 204142 RVA: 0x00B92520 File Offset: 0x00B90720
		protected override void RefreshRankBg()
		{
			UUITexture texture = base.GetTexture(0);
			texture.SetUIActive(true);
			string resourceId = this.RankItemData.IsTopThree ? this.RankItemData.RankBg : "T_oNlineLordGymRankBgNor";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}

		// Token: 0x0401A982 RID: 108930
		[Nullable(1)]
		private const string OwnerNormalRankBg = "T_oNlineLordGymRankBgNor";
	}
}
