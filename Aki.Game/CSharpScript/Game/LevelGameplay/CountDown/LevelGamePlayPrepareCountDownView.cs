using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.CountDown
{
	// Token: 0x02006F19 RID: 28441
	public class LevelGamePlayPrepareCountDownView : UiViewBase
	{
		// Token: 0x06045377 RID: 283511 RVA: 0x011202C0 File Offset: 0x0111E4C0
		[NullableContext(1)]
		public LevelGamePlayPrepareCountDownView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06045378 RID: 283512 RVA: 0x011202D0 File Offset: 0x0111E4D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06045379 RID: 283513 RVA: 0x0112035C File Offset: 0x0111E55C
		protected override void OnStart()
		{
			ILevelGamePlayPrepareCountDownViewParams levelGamePlayPrepareCountDownViewParams = this.OpenParam as ILevelGamePlayPrepareCountDownViewParams;
			this.CountDownNum = levelGamePlayPrepareCountDownViewParams.CountDownNum;
			this.SetNumText();
			if (levelGamePlayPrepareCountDownViewParams != null && levelGamePlayPrepareCountDownViewParams.TidText != null)
			{
				string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(levelGamePlayPrepareCountDownViewParams.TidText);
				UUIText text = base.GetText(2);
				if (text != null)
				{
					text.SetText(configTextByKey, true);
				}
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x0604537A RID: 283514 RVA: 0x011203E0 File Offset: 0x0111E5E0
		protected override void OnAfterShow()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
			}
			AudioSystem.Instance.PostEvent("play_ui_fx_com_count_number");
		}

		// Token: 0x0604537B RID: 283515 RVA: 0x01120420 File Offset: 0x0111E620
		[NullableContext(1)]
		private void OnSequenceClose(string sequenceName)
		{
			if (!(sequenceName == "Start01"))
			{
				if (!(sequenceName == "Start02"))
				{
					return;
				}
				base.CloseMe(null);
				return;
			}
			else
			{
				this.CountDownNum--;
				if (this.CountDownNum > 0)
				{
					this.SetNumText();
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer != null)
					{
						levelSequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
					}
					AudioSystem.Instance.PostEvent("play_ui_fx_com_count_number");
					return;
				}
				EventSystem.Instance.Emit(EEventName.LevelGamePlayPrepareCountDownEnd);
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null)
				{
					levelSequencePlayer2.PlayLevelSequenceByName("Start02", false, null, false);
				}
				AudioSystem.Instance.PostEvent("play_ui_fx_com_count_start");
				return;
			}
		}

		// Token: 0x0604537C RID: 283516 RVA: 0x011204E5 File Offset: 0x0111E6E5
		private void SetNumText()
		{
			UUIArtText artText = base.GetArtText(0);
			if (artText != null)
			{
				artText.SetText(this.CountDownNum.ToString());
			}
			UUIArtText artText2 = base.GetArtText(1);
			if (artText2 == null)
			{
				return;
			}
			artText2.SetText(this.CountDownNum.ToString());
		}

		// Token: 0x04024151 RID: 147793
		private int CountDownNum = 3;

		// Token: 0x04024152 RID: 147794
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200CD72 RID: 52594
		private class EViewComponent
		{
			// Token: 0x0403DEA1 RID: 253601
			public const int NumText = 0;

			// Token: 0x0403DEA2 RID: 253602
			public const int NumText2 = 1;

			// Token: 0x0403DEA3 RID: 253603
			public const int CustomText = 2;
		}
	}
}
