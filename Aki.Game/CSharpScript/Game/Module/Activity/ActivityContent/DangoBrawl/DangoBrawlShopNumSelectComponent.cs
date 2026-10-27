using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.NumberSelect;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006843 RID: 26691
	public class DangoBrawlShopNumSelectComponent : NumberSelectComponent
	{
		// Token: 0x060429E3 RID: 272867 RVA: 0x01032AE3 File Offset: 0x01030CE3
		[NullableContext(1)]
		public DangoBrawlShopNumSelectComponent(UUIItem uiItem) : base(uiItem)
		{
		}

		// Token: 0x060429E4 RID: 272868 RVA: 0x01032AEC File Offset: 0x01030CEC
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(8, typeof(UUISprite)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUISprite)));
		}

		// Token: 0x060429E5 RID: 272869 RVA: 0x01032B2B File Offset: 0x01030D2B
		public override void SetComponentLimitState(bool isLimit)
		{
			base.SetComponentLimitState(isLimit);
			this.RefreshFillSprites(isLimit);
		}

		// Token: 0x060429E6 RID: 272870 RVA: 0x01032B3B File Offset: 0x01030D3B
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

		// Token: 0x0200CA04 RID: 51716
		private enum ENumComponents
		{
			// Token: 0x0403D0C9 RID: 250057
			SprFillNormal = 8,
			// Token: 0x0403D0CA RID: 250058
			SprFillBan
		}
	}
}
