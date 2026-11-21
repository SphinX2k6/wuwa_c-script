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
	// Token: 0x02002FD6 RID: 12246
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TetrisGemProgressGrid : GridProxyAbstract<TetrisGemProgressData>
	{
		// Token: 0x0601D13D RID: 119101 RVA: 0x008E3104 File Offset: 0x008E1304
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D13E RID: 119102 RVA: 0x008E3233 File Offset: 0x008E1433
		protected override void OnStart()
		{
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0601D13F RID: 119103 RVA: 0x008E3248 File Offset: 0x008E1448
		[NullableContext(1)]
		public override void Refresh(TetrisGemProgressData data, bool isSelected, int gridIndex)
		{
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(data.GemId);
			if (gemConfig != null)
			{
				TetrisGem valueOrDefault = gemConfig.GetValueOrDefault();
				this.SetSpriteByPath(valueOrDefault.TargetBgPath, base.GetSprite(1), false, null, null);
				base.SetTextureByPath(valueOrDefault.TargetTextureBgPath, base.GetTexture(7), null, null);
				this.SetSpriteByPath(valueOrDefault.TargetIconPath, base.GetSprite(0), false, null, null);
			}
			int num = Math.Min(data.CurrentGemCount, data.TargetGemCount);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.TargetGemCount);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			base.GetSprite(1).SetFillAmount((float)data.CurrentGemCount / (float)data.TargetGemCount);
			int num2 = num;
			TetrisGemProgressData levelData = this.LevelData;
			if (num2 > ((levelData != null) ? levelData.CurrentGemCount : 0))
			{
				this.ViewSequencePlayer.PlayLevelSequenceByName("Up", false, null, false);
			}
			this.LevelData = data;
		}

		// Token: 0x0601D140 RID: 119104 RVA: 0x008E337C File Offset: 0x008E157C
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x0400F500 RID: 62720
		private TetrisGemProgressData LevelData;

		// Token: 0x0400F501 RID: 62721
		private LevelSequencePlayer ViewSequencePlayer;
	}
}
