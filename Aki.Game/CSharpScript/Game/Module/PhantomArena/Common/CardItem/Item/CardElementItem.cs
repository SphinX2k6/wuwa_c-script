using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020051D1 RID: 20945
	public class CardElementItem : GridProxyAbstract<ECardElement>
	{
		// Token: 0x060359CC RID: 219596 RVA: 0x00CB3B24 File Offset: 0x00CB1D24
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUITexture))
			};
		}

		// Token: 0x060359CD RID: 219597 RVA: 0x00CB3B5D File Offset: 0x00CB1D5D
		public override void Refresh(ECardElement data, bool isSelected = false, int gridIndex = 0)
		{
			this.RefreshElement(data);
		}

		// Token: 0x060359CE RID: 219598 RVA: 0x00CB3B68 File Offset: 0x00CB1D68
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

		// Token: 0x060359CF RID: 219599 RVA: 0x00CB3BD4 File Offset: 0x00CB1DD4
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

		// Token: 0x0200B361 RID: 45921
		private static class EElementItem
		{
			// Token: 0x040365ED RID: 222701
			public const int BgSprite = 0;

			// Token: 0x040365EE RID: 222702
			public const int ElementTexture = 1;
		}
	}
}
