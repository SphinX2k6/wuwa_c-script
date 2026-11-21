using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020041A1 RID: 16801
	public class CardElementItem : GridProxyAbstract<ECardElement>
	{
		// Token: 0x0602A8C7 RID: 174279 RVA: 0x00C01160 File Offset: 0x00BFF360
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUITexture))
			};
		}

		// Token: 0x0602A8C8 RID: 174280 RVA: 0x00C01199 File Offset: 0x00BFF399
		public override void Refresh(ECardElement data, bool isSelected = false, int gridIndex = 0)
		{
			this.RefreshElement(data);
		}

		// Token: 0x0602A8C9 RID: 174281 RVA: 0x00C011A4 File Offset: 0x00BFF3A4
		public void RefreshElement(ECardElement elementId)
		{
			if (elementId == ECardElement.Physical)
			{
				this.SetActive(false);
				return;
			}
			this.SetActive(true);
			UUITexture texture = base.GetTexture(1);
			if (texture == null)
			{
				return;
			}
			PhantomBattleCardElement phantomBattleElementConfig = PhantomArenaConfig.Instance.GetPhantomBattleElementConfig((int)elementId);
			FColor color = FColor.FromHex(phantomBattleElementConfig.TabElementColor);
			base.GetSprite(0).SetColor(color);
			base.SetTextureByPath(phantomBattleElementConfig.CardElementIcon, texture, null, null);
		}

		// Token: 0x0602A8CA RID: 174282 RVA: 0x00C01210 File Offset: 0x00BFF410
		public void RefreshElementTabIcon(ECardElement elementId)
		{
			if (elementId == ECardElement.Physical)
			{
				this.SetActive(false);
				return;
			}
			this.SetActive(true);
			UUITexture texture = base.GetTexture(1);
			if (texture == null)
			{
				return;
			}
			PhantomBattleCardElement phantomBattleElementConfig = PhantomArenaConfig.Instance.GetPhantomBattleElementConfig((int)elementId);
			FColor color = FColor.FromHex(phantomBattleElementConfig.TabElementColor);
			base.GetSprite(0).SetColor(color);
			base.SetTextureByPath(phantomBattleElementConfig.TabIcon, texture, null, null);
		}

		// Token: 0x02009D99 RID: 40345
		private static class EElementItem
		{
			// Token: 0x04031040 RID: 200768
			public const int BgSprite = 0;

			// Token: 0x04031041 RID: 200769
			public const int ElementTexture = 1;
		}
	}
}
