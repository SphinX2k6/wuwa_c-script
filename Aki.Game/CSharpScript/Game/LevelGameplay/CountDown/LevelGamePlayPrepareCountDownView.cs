using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.CountDown
{
	// Token: 0x0200609A RID: 24730
	public class LevelGamePlayPrepareCountDownView : UiViewBase
	{
		// Token: 0x0603B525 RID: 242981 RVA: 0x010CA260 File Offset: 0x010C8460
		[NullableContext(1)]
		public LevelGamePlayPrepareCountDownView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B526 RID: 242982 RVA: 0x010CA270 File Offset: 0x010C8470
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

		// Token: 0x0603B527 RID: 242983 RVA: 0x010CA2FC File Offset: 0x010C84FC
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

		// Token: 0x0603B528 RID: 242984 RVA: 0x010CA380 File Offset: 0x010C8580
		protected override void OnAfterShow()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
			}
			AudioSystem.Instance.PostEvent("play_ui_fx_com_count_number");
		}

		// Token: 0x0603B529 RID: 242985 RVA: 0x010CA3C0 File Offset: 0x010C85C0
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

		// Token: 0x0603B52A RID: 242986 RVA: 0x010CA485 File Offset: 0x010C8685
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

		// Token: 0x0401F406 RID: 128006
		private int CountDownNum = 3;

		// Token: 0x0401F407 RID: 128007
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B964 RID: 47460
		private class EViewComponent
		{
			// Token: 0x040392D0 RID: 234192
			public const int NumText = 0;

			// Token: 0x040392D1 RID: 234193
			public const int NumText2 = 1;

			// Token: 0x040392D2 RID: 234194
			public const int CustomText = 2;
		}
	}
}
