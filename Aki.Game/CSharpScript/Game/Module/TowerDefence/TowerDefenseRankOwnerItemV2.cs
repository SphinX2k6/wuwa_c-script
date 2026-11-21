using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AD3 RID: 15059
	public class TowerDefenseRankOwnerItemV2 : TowerDefenseRankItemV2
	{
		// Token: 0x06026AFE RID: 158462 RVA: 0x00AD6584 File Offset: 0x00AD4784
		protected override void RefreshRankBg()
		{
			UUITexture texture = base.GetTexture(0);
			texture.SetUIActive(true);
			string resourceId = this.RankItemData.IsTopThree ? this.RankItemData.RankBg : "T_oNlineLordGymRankBgNor";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}

		// Token: 0x040152D4 RID: 86740
		[Nullable(1)]
		private const string OwnerNormalRankBg = "T_oNlineLordGymRankBgNor";
	}
}
