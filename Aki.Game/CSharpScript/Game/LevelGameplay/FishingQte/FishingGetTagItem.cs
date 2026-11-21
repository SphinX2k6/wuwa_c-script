using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FC1 RID: 24513
	public class FishingGetTagItem : UiPanelBase
	{
		// Token: 0x0603AE78 RID: 241272 RVA: 0x010A4FDC File Offset: 0x010A31DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603AE79 RID: 241273 RVA: 0x010A5048 File Offset: 0x010A3248
		public void RefreshTag(EFishingQteGetItemTagType tagType)
		{
			string text = null;
			string text2 = null;
			string text3 = null;
			if (tagType != EFishingQteGetItemTagType.Multiply)
			{
				if (tagType == EFishingQteGetItemTagType.Extra)
				{
					text = "Reward_Tag_Extra";
					text2 = ConfigCommonParamById.GetStringConfig("Reward_Tag_Extra_Bg_Color");
					text3 = ConfigCommonParamById.GetStringConfig("Reward_Tag_Extra_Text_Color");
				}
			}
			else
			{
				text = "Reward_Tag_Magnification";
				text2 = ConfigCommonParamById.GetStringConfig("Reward_Tag_Magnification_Bg_Color");
				text3 = ConfigCommonParamById.GetStringConfig("Reward_Tag_Magnification_Text_Color");
			}
			if (!string.IsNullOrEmpty(text))
			{
				base.GetText(1).ShowTextNew(text);
			}
			if (!string.IsNullOrEmpty(text3))
			{
				base.GetText(1).SetColor(FColor.FromHex(text3));
			}
			if (!string.IsNullOrEmpty(text2))
			{
				base.GetSprite(0).SetColor(FColor.FromHex(text2));
			}
		}

		// Token: 0x0200B8E6 RID: 47334
		private class ETagComponents
		{
			// Token: 0x0403910A RID: 233738
			public const int SpriteBg = 0;

			// Token: 0x0403910B RID: 233739
			public const int Txt = 1;
		}
	}
}
