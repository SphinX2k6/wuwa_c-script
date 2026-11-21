using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FD5 RID: 12245
	public class TetrisScoreProgressPanel : UiPanelBase
	{
		// Token: 0x0601D137 RID: 119095 RVA: 0x008E2D94 File Offset: 0x008E0F94
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

		// Token: 0x0601D138 RID: 119096 RVA: 0x008E2EC3 File Offset: 0x008E10C3
		protected override void OnStart()
		{
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0601D139 RID: 119097 RVA: 0x008E2ED6 File Offset: 0x008E10D6
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x0601D13A RID: 119098 RVA: 0x008E2EF0 File Offset: 0x008E10F0
		public void RefreshInfinite(int currentScore, long? highestScore)
		{
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(0);
			if (gemConfig != null)
			{
				TetrisGem valueOrDefault = gemConfig.GetValueOrDefault();
				this.SetSpriteByPath(valueOrDefault.TargetBgPath, base.GetSprite(1), false, null, null);
				base.SetTextureByPath(valueOrDefault.TargetTextureBgPath, base.GetTexture(7), null, null);
				this.SetSpriteByPath(valueOrDefault.TargetIconPath, base.GetSprite(0), false, null, null);
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(currentScore.ToString(), true);
			}
			base.GetSprite(1).SetFillAmount(1f);
			UUIItem item = base.GetItem(3);
			long num = (long)currentScore;
			long? num2 = highestScore;
			item.SetUIActive(num > num2.GetValueOrDefault() & num2 != null);
			if (currentScore > this.CurrentScore)
			{
				this.ViewSequencePlayer.PlayLevelSequenceByName("Up", false, null, false);
			}
			this.CurrentScore = currentScore;
		}

		// Token: 0x0601D13B RID: 119099 RVA: 0x008E2FF0 File Offset: 0x008E11F0
		public void Refresh(int currentScore, int targetScore)
		{
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(0);
			if (gemConfig != null)
			{
				TetrisGem valueOrDefault = gemConfig.GetValueOrDefault();
				this.SetSpriteByPath(valueOrDefault.TargetBgPath, base.GetSprite(1), false, null, null);
				base.SetTextureByPath(valueOrDefault.TargetTextureBgPath, base.GetTexture(7), null, null);
				this.SetSpriteByPath(valueOrDefault.TargetIconPath, base.GetSprite(0), false, null, null);
			}
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
				this.ViewSequencePlayer.PlayLevelSequenceByName("Up", false, null, false);
			}
			this.CurrentScore = currentScore;
		}

		// Token: 0x0400F4FE RID: 62718
		private int CurrentScore;

		// Token: 0x0400F4FF RID: 62719
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;
	}
}
