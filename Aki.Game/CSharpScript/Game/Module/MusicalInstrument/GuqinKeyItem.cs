using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200434F RID: 17231
	public class GuqinKeyItem : MusicalInstrumentKeyItem
	{
		// Token: 0x0602B85D RID: 178269 RVA: 0x00C3B050 File Offset: 0x00C39250
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602B85E RID: 178270 RVA: 0x00C3B140 File Offset: 0x00C39340
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.OnPointDownCallBack.Bind(new Action(this.OnPointerDown));
			}
			this.LevelSequencePlayer = new UiSequencePlayer(base.GetButton(0).RootUIComp);
		}

		// Token: 0x0602B85F RID: 178271 RVA: 0x00C3B18C File Offset: 0x00C3938C
		protected override void OnBeforeDestroy()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.OnPointDownCallBack.Unbind();
		}

		// Token: 0x0602B860 RID: 178272 RVA: 0x00C3B1A4 File Offset: 0x00C393A4
		public void RefreshMode(EZitherAudioType audioType)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(audioType == EZitherAudioType.FundamentalTone);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(audioType == EZitherAudioType.OverTone);
		}

		// Token: 0x0602B861 RID: 178273 RVA: 0x00C3B1D1 File Offset: 0x00C393D1
		public override void OnQteFocus(bool isFocus)
		{
			UUIItem item = base.GetItem(8);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isFocus);
		}

		// Token: 0x0602B862 RID: 178274 RVA: 0x00C3B1E8 File Offset: 0x00C393E8
		public override void OnQtePerformance(bool success)
		{
			UiSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopPrevSequence(false, true);
			}
			UiSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlayOrReplaySequenceByName(success ? "Right" : "Wrong", false, null);
		}

		// Token: 0x0602B863 RID: 178275 RVA: 0x00C3B234 File Offset: 0x00C39434
		private void OnPointerDown()
		{
			Action<int, int> onPointerDownCallback = this.OnPointerDownCallback;
			if (onPointerDownCallback != null)
			{
				onPointerDownCallback(this.RowIndex, this.ColumnIndex);
			}
			UiSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName("Aftermath", false, null);
		}

		// Token: 0x0602B864 RID: 178276 RVA: 0x00C3B27D File Offset: 0x00C3947D
		public void SetInteractive(bool isInteractive)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(isInteractive);
		}

		// Token: 0x0401781D RID: 96285
		[Nullable(2)]
		private UiSequencePlayer LevelSequencePlayer;

		// Token: 0x0200A01E RID: 40990
		private enum EGuqinKeyItemComponent
		{
			// Token: 0x04031BEE RID: 203758
			Button,
			// Token: 0x04031BEF RID: 203759
			PnlFundamentalTone,
			// Token: 0x04031BF0 RID: 203760
			PnlOverTone,
			// Token: 0x04031BF1 RID: 203761
			SprPoint,
			// Token: 0x04031BF2 RID: 203762
			SprNum,
			// Token: 0x04031BF3 RID: 203763
			TextNote,
			// Token: 0x04031BF4 RID: 203764
			PnlErrorState,
			// Token: 0x04031BF5 RID: 203765
			PnlSuccessState,
			// Token: 0x04031BF6 RID: 203766
			PnlQte
		}
	}
}
