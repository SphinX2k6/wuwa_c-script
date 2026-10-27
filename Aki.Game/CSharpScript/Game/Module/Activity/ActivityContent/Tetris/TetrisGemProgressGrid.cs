using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006010 RID: 24592
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TetrisGemProgressGrid : GridProxyAbstract<ITetrisGemProgressData>
	{
		// Token: 0x0603E483 RID: 255107 RVA: 0x00F0A6EC File Offset: 0x00F088EC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUITexture))
			};
		}

		// Token: 0x0603E484 RID: 255108 RVA: 0x00F0A7B4 File Offset: 0x00F089B4
		protected override void OnStart()
		{
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603E485 RID: 255109 RVA: 0x00F0A7C8 File Offset: 0x00F089C8
		[NullableContext(1)]
		public override void Refresh(ITetrisGemProgressData data, bool isSelected, int gridIndex)
		{
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(data.GemId);
			this.SetSpriteByPath(gemConfig.Value.TargetBgPath, base.GetSprite(1), false, null, null);
			base.SetTextureByPath(gemConfig.Value.TargetTextureBgPath, base.GetTexture(7), null, null);
			this.SetSpriteByPath(gemConfig.Value.TargetIconPath, base.GetSprite(0), false, null, null);
			int num = Math.Min(data.CurrentGemCount, data.TargetGemCount);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int?>((data != null) ? new int?(data.TargetGemCount) : null);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			base.GetSprite(1).SetFillAmount((float)data.CurrentGemCount / (float)data.TargetGemCount);
			int num2 = num;
			ITetrisGemProgressData levelData = this.LevelData;
			if (num2 > ((levelData != null) ? levelData.CurrentGemCount : 0))
			{
				base.GetItem(5).SetUIActive(false);
				base.GetItem(5).SetUIActive(true);
				this.ViewSequencePlayer.PlayLevelSequenceByName("Up", false, null, false);
			}
			else
			{
				base.GetItem(5).SetUIActive(false);
			}
			this.LevelData = data;
		}

		// Token: 0x0603E486 RID: 255110 RVA: 0x00F0A940 File Offset: 0x00F08B40
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x040208BA RID: 133306
		private ITetrisGemProgressData LevelData;

		// Token: 0x040208BB RID: 133307
		private LevelSequencePlayer ViewSequencePlayer;
	}
}
