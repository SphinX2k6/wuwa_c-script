using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200536C RID: 21356
	public class GuqinKeyItem : MusicalInstrumentKeyItem
	{
		// Token: 0x06036917 RID: 223511 RVA: 0x00CEC1C4 File Offset: 0x00CEA3C4
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

		// Token: 0x06036918 RID: 223512 RVA: 0x00CEC2B4 File Offset: 0x00CEA4B4
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.OnPointDownCallBack.Bind(new Action(this.OnPointerDown));
			}
			this.LevelSequencePlayer = new UiSequencePlayer(base.GetButton(0).RootUIComp);
		}

		// Token: 0x06036919 RID: 223513 RVA: 0x00CEC300 File Offset: 0x00CEA500
		protected override void OnBeforeDestroy()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.OnPointDownCallBack.Unbind();
		}

		// Token: 0x0603691A RID: 223514 RVA: 0x00CEC318 File Offset: 0x00CEA518
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

		// Token: 0x0603691B RID: 223515 RVA: 0x00CEC345 File Offset: 0x00CEA545
		public override void OnQteFocus(bool isFocus)
		{
			UUIItem item = base.GetItem(8);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isFocus);
		}

		// Token: 0x0603691C RID: 223516 RVA: 0x00CEC35C File Offset: 0x00CEA55C
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

		// Token: 0x0603691D RID: 223517 RVA: 0x00CEC3A8 File Offset: 0x00CEA5A8
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

		// Token: 0x0603691E RID: 223518 RVA: 0x00CEC3F1 File Offset: 0x00CEA5F1
		public void SetInteractive(bool isInteractive)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(isInteractive);
		}

		// Token: 0x0401CD87 RID: 118151
		[Nullable(2)]
		private UiSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B5E7 RID: 46567
		private enum EGuqinKeyItemComponent
		{
			// Token: 0x0403719B RID: 225691
			Button,
			// Token: 0x0403719C RID: 225692
			PnlFundamentalTone,
			// Token: 0x0403719D RID: 225693
			PnlOverTone,
			// Token: 0x0403719E RID: 225694
			SprPoint,
			// Token: 0x0403719F RID: 225695
			SprNum,
			// Token: 0x040371A0 RID: 225696
			TextNote,
			// Token: 0x040371A1 RID: 225697
			PnlErrorState,
			// Token: 0x040371A2 RID: 225698
			PnlSuccessState,
			// Token: 0x040371A3 RID: 225699
			PnlQte
		}
	}
}
