using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.NumberSelect;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005793 RID: 22419
	public class DangoBrawlShopNumSelectComponent : NumberSelectComponent
	{
		// Token: 0x06037537 RID: 226615 RVA: 0x00F73FEF File Offset: 0x00F721EF
		[NullableContext(1)]
		public DangoBrawlShopNumSelectComponent(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x06037538 RID: 226616 RVA: 0x00F73FF8 File Offset: 0x00F721F8
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(8, typeof(UUISprite)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUISprite)));
		}

		// Token: 0x06037539 RID: 226617 RVA: 0x00F74037 File Offset: 0x00F72237
		public override void SetComponentLimitState(bool isLimit)
		{
			base.SetComponentLimitState(isLimit);
			this.RefreshFillSprites(isLimit);
		}

		// Token: 0x0603753A RID: 226618 RVA: 0x00F74047 File Offset: 0x00F72247
		private void RefreshFillSprites(bool isBan)
		{
			UUISprite sprite = base.GetSprite(8);
			if (sprite != null)
			{
				sprite.SetUIActive(!isBan);
			}
			UUISprite sprite2 = base.GetSprite(9);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetUIActive(isBan);
		}

		// Token: 0x0200B3D0 RID: 46032
		private enum ENumComponents
		{
			// Token: 0x040379B2 RID: 227762
			SprFillNormal = 8,
			// Token: 0x040379B3 RID: 227763
			SprFillBan
		}
	}
}
