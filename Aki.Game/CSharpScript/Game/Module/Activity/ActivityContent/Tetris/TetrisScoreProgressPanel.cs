using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x0200600F RID: 24591
	public class TetrisScoreProgressPanel : UiPanelBase
	{
		// Token: 0x0603E47D RID: 255101 RVA: 0x00F0A388 File Offset: 0x00F08588
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

		// Token: 0x0603E47E RID: 255102 RVA: 0x00F0A450 File Offset: 0x00F08650
		protected override void OnStart()
		{
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603E47F RID: 255103 RVA: 0x00F0A463 File Offset: 0x00F08663
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x0603E480 RID: 255104 RVA: 0x00F0A480 File Offset: 0x00F08680
		public void RefreshInfinite(int currentScore)
		{
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(0);
			this.SetSpriteByPath(gemConfig.Value.TargetBgPath, base.GetSprite(1), false, null, null);
			base.SetTextureByPath(gemConfig.Value.TargetTextureBgPath, base.GetTexture(7), null, null);
			this.SetSpriteByPath(gemConfig.Value.TargetIconPath, base.GetSprite(0), false, null, null);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(currentScore.ToString(), true);
			}
			base.GetSprite(1).SetFillAmount(1f);
			base.GetItem(3).SetUIActive((long)currentScore > TetrisController.Instance.GetHighestScore());
			if (currentScore > this.CurrentScore)
			{
				base.GetItem(5).SetUIActive(false);
				base.GetItem(5).SetUIActive(true);
				this.ViewSequencePlayer.PlayLevelSequenceByName("Up", false, null, false);
			}
			else
			{
				base.GetItem(5).SetUIActive(false);
			}
			this.CurrentScore = currentScore;
		}

		// Token: 0x0603E481 RID: 255105 RVA: 0x00F0A5A8 File Offset: 0x00F087A8
		public void Refresh(int currentScore, int targetScore)
		{
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(0);
			this.SetSpriteByPath(gemConfig.Value.TargetBgPath, base.GetSprite(1), false, null, null);
			base.SetTextureByPath(gemConfig.Value.TargetTextureBgPath, base.GetTexture(7), null, null);
			this.SetSpriteByPath(gemConfig.Value.TargetIconPath, base.GetSprite(0), false, null, null);
			int value = Math.Min(currentScore, targetScore);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(targetScore);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			base.GetSprite(1).SetFillAmount((float)currentScore / (float)targetScore);
			if (currentScore > this.CurrentScore)
			{
				base.GetItem(5).SetUIActive(false);
				base.GetItem(5).SetUIActive(true);
				this.ViewSequencePlayer.PlayLevelSequenceByName("Up", false, null, false);
			}
			else
			{
				base.GetItem(5).SetUIActive(false);
			}
			this.CurrentScore = currentScore;
		}

		// Token: 0x040208B8 RID: 133304
		private int CurrentScore;

		// Token: 0x040208B9 RID: 133305
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;
	}
}
