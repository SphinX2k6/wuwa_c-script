using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FC5 RID: 12229
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TetrisComboGemGrid : GridProxyAbstract<TetrisGemGetData>
	{
		// Token: 0x0601D084 RID: 118916 RVA: 0x008DE220 File Offset: 0x008DC420
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D085 RID: 118917 RVA: 0x008DE2AC File Offset: 0x008DC4AC
		[NullableContext(1)]
		public override void Refresh(TetrisGemGetData data, bool isSelected, int gridIndex)
		{
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(data.GemId);
			if (gemConfig == null)
			{
				return;
			}
			TetrisGem valueOrDefault = gemConfig.GetValueOrDefault();
			this.SetSpriteByPath(valueOrDefault.BgPath, base.GetSprite(0), false, null, null);
			this.SetSpriteByPath(valueOrDefault.GemPath, base.GetSprite(1), false, null, null);
			base.GetArtText(2).SetText("+" + data.GetGemCount.ToString());
			UUIArtText artText = base.GetArtText(2);
			if (artText == null)
			{
				return;
			}
			artText.SetColor(FColor.FromHex(TetrisComboPanel.CurrentComboColorHex.ToEnumString()));
		}

		// Token: 0x02008C4D RID: 35917
		private static class EComponents
		{
			// Token: 0x0402C679 RID: 181881
			public const int SpriteBg = 0;

			// Token: 0x0402C67A RID: 181882
			public const int SpriteIcon = 1;

			// Token: 0x0402C67B RID: 181883
			public const int Count = 2;
		}
	}
}
