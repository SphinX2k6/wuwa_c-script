using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005993 RID: 22931
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolDateItem : UiPanelBase
	{
		// Token: 0x060388AC RID: 231596 RVA: 0x00FD1B60 File Offset: 0x00FCFD60
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060388AD RID: 231597 RVA: 0x00FD1C50 File Offset: 0x00FCFE50
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceFinish), false);
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnSequencePlayEvent));
			}
			this.SetTimeText(string.Empty);
		}

		// Token: 0x060388AE RID: 231598 RVA: 0x00FD1CB3 File Offset: 0x00FCFEB3
		protected override void OnBeforeDestroy()
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor == null)
			{
				return;
			}
			rootActor.OnSequencePlayEvent.Unbind();
		}

		// Token: 0x060388AF RID: 231599 RVA: 0x00FD1CCC File Offset: 0x00FCFECC
		public void Refresh()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (!instance.IsInGamePlay)
			{
				this.SetTimeText(string.Empty);
				return;
			}
			SolarSchoolTimeData timeData = instance.TimeData;
			ESolarSchoolMapTimePhase displayMapTimePhase = timeData.DisplayMapTimePhase;
			ESolarSchoolMapTimePhase? timePhase = this.TimePhase;
			ESolarSchoolMapTimePhase esolarSchoolMapTimePhase = displayMapTimePhase;
			if (!(timePhase.GetValueOrDefault() == esolarSchoolMapTimePhase & timePhase != null) && instance.HasDaySmallTransitionUnplayed)
			{
				this.DateChangePending = true;
				instance.ClearDaySmallTransitionUnplayed();
				this.PlayPhaseAnim(displayMapTimePhase);
				return;
			}
			this.RefreshTimeText(timeData);
			this.PlayPhaseAnim(displayMapTimePhase);
		}

		// Token: 0x060388B0 RID: 231600 RVA: 0x00FD1D4B File Offset: 0x00FCFF4B
		private void RefreshTimeText(SolarSchoolTimeData time)
		{
			this.DateChangePending = false;
			this.RefreshDate(time.Month, time.Day);
			this.RefreshWeekday(new DayOfWeek?(time.DayOfWeek));
			this.SetTimeText(this.GetDayIndexText(time.DayIndex));
		}

		// Token: 0x060388B1 RID: 231601 RVA: 0x00FD1D89 File Offset: 0x00FCFF89
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			if (eventName != "Sequence_Date_Change" || !this.DateChangePending)
			{
				return;
			}
			this.RefreshTimeText(SolarSchoolGamePlayModel.Instance.TimeData);
		}

		// Token: 0x060388B2 RID: 231602 RVA: 0x00FD1DB4 File Offset: 0x00FCFFB4
		private void PlayPhaseAnim(ESolarSchoolMapTimePhase phase)
		{
			ESolarSchoolMapTimePhase? timePhase = this.TimePhase;
			if (!(timePhase.GetValueOrDefault() == phase & timePhase != null) && SolarSchoolGamePlayModel.Instance.GetSlotTransitionUnplayed())
			{
				this.PlayTimeSlotTransition(phase, null);
				return;
			}
			this.SnapBgIfNeeded(phase);
		}

		// Token: 0x060388B3 RID: 231603 RVA: 0x00FD1DFC File Offset: 0x00FCFFFC
		[NullableContext(2)]
		public bool PlayTimeSlotTransition(ESolarSchoolMapTimePhase phase, Action onFinish)
		{
			ESolarSchoolMapTimePhase? timePhase = this.TimePhase;
			if ((timePhase.GetValueOrDefault() == phase & timePhase != null) || this.SequencePlayer == null)
			{
				return false;
			}
			this.FinishTransition();
			this.TimePhase = new ESolarSchoolMapTimePhase?(phase);
			this.TransitionFinish = onFinish;
			this.PlayingAnim = ((phase == ESolarSchoolMapTimePhase.Dusk) ? "ToDusk" : "ToDay");
			this.SequencePlayer.StopCurrentSequence(false, true);
			this.SequencePlayer.PlaySequencePurely(this.PlayingAnim, true, false, null, null, false);
			return true;
		}

		// Token: 0x060388B4 RID: 231604 RVA: 0x00FD1E8B File Offset: 0x00FD008B
		public void StopTimeSlotTransition()
		{
			if (this.PlayingAnim == null)
			{
				return;
			}
			this.TransitionFinish = null;
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.StopCurrentSequence(false, true);
			}
			this.PlayingAnim = null;
			this.FlushDateChangeIfPending();
		}

		// Token: 0x060388B5 RID: 231605 RVA: 0x00FD1EC0 File Offset: 0x00FD00C0
		private void SnapBgIfNeeded(ESolarSchoolMapTimePhase phase)
		{
			ESolarSchoolMapTimePhase? timePhase = this.TimePhase;
			if ((timePhase.GetValueOrDefault() == phase & timePhase != null) || this.PlayingAnim != null)
			{
				return;
			}
			this.TimePhase = new ESolarSchoolMapTimePhase?(phase);
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.StopCurrentSequence(false, true);
			}
			LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 == null)
			{
				return;
			}
			sequencePlayer2.PlaySequencePurely((phase == ESolarSchoolMapTimePhase.Dusk) ? "Dusk" : "Day", false, false, null, null, true);
		}

		// Token: 0x060388B6 RID: 231606 RVA: 0x00FD1F3F File Offset: 0x00FD013F
		private void OnSequenceFinish(string sequenceName)
		{
			if (sequenceName != this.PlayingAnim)
			{
				return;
			}
			this.PlayingAnim = null;
			this.FlushDateChangeIfPending();
			this.FinishTransition();
		}

		// Token: 0x060388B7 RID: 231607 RVA: 0x00FD1F63 File Offset: 0x00FD0163
		private void FlushDateChangeIfPending()
		{
			if (!this.DateChangePending)
			{
				return;
			}
			this.RefreshTimeText(SolarSchoolGamePlayModel.Instance.TimeData);
		}

		// Token: 0x060388B8 RID: 231608 RVA: 0x00FD1F7E File Offset: 0x00FD017E
		private void FinishTransition()
		{
			Action transitionFinish = this.TransitionFinish;
			this.TransitionFinish = null;
			if (transitionFinish == null)
			{
				return;
			}
			transitionFinish();
		}

		// Token: 0x060388B9 RID: 231609 RVA: 0x00FD1F98 File Offset: 0x00FD0198
		public void SetDate(int month, int day, int periodId)
		{
			this.RefreshDate(month, day);
			this.RefreshWeekday(SolarSchoolUtils.GetDayOfWeek(month, day));
			base.SetUiActive(true);
			this.SetTimeText(string.Empty);
			this.PlayPhaseAnim(SolarSchoolTimeData.GetMapTimePhase((ESolarSchoolTimeSlot)periodId));
		}

		// Token: 0x060388BA RID: 231610 RVA: 0x00FD1FDA File Offset: 0x00FD01DA
		public void SetDateByDayIndex(int dayIndex, ESolarSchoolTimeSlot slot)
		{
			this.RefreshDateByDayIndex(dayIndex);
			this.SnapBgIfNeeded(SolarSchoolTimeData.GetMapTimePhase(slot));
		}

		// Token: 0x060388BB RID: 231611 RVA: 0x00FD1FEF File Offset: 0x00FD01EF
		public void SetDateByDayIndexDuringDayTransition(int dayIndex, ESolarSchoolTimeSlot slot)
		{
			this.RefreshDateByDayIndex(dayIndex);
			this.TimePhase = new ESolarSchoolMapTimePhase?(SolarSchoolTimeData.GetMapTimePhase(slot));
		}

		// Token: 0x060388BC RID: 231612 RVA: 0x00FD200C File Offset: 0x00FD020C
		private void RefreshDateByDayIndex(int dayIndex)
		{
			ValueTuple<int, int> monthDay = SolarSchoolUtils.GetMonthDay(dayIndex);
			int item = monthDay.Item1;
			int item2 = monthDay.Item2;
			this.RefreshDate(item, item2);
			this.RefreshWeekday(new DayOfWeek?(SolarSchoolUtils.GetDate(dayIndex).DayOfWeek));
			this.SetTimeText(this.GetDayIndexText(dayIndex));
		}

		// Token: 0x060388BD RID: 231613 RVA: 0x00FD205A File Offset: 0x00FD025A
		private void SetTimeText(string text)
		{
			UUIText text2 = base.GetText(2);
			if (text2 != null)
			{
				text2.SetText(text, true);
			}
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!string.IsNullOrEmpty(text));
		}

		// Token: 0x060388BE RID: 231614 RVA: 0x00FD208C File Offset: 0x00FD028C
		private void RefreshDate(int month, int day)
		{
			UUIArtText artText = base.GetArtText(3);
			if (artText != null)
			{
				artText.SetText(month.ToString("D2") + "/");
			}
			UUIArtText artText2 = base.GetArtText(4);
			if (artText2 == null)
			{
				return;
			}
			artText2.SetText(day.ToString("D2"));
		}

		// Token: 0x060388BF RID: 231615 RVA: 0x00FD20DE File Offset: 0x00FD02DE
		private void RefreshWeekday(DayOfWeek? dayOfWeek)
		{
			if (dayOfWeek == null)
			{
				return;
			}
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(SolarSchoolUtils.GetWeekdayText(dayOfWeek.Value), true);
		}

		// Token: 0x060388C0 RID: 231616 RVA: 0x00FD2108 File Offset: 0x00FD0308
		private string GetDayIndexText(int dayIndex)
		{
			return string.Empty;
		}

		// Token: 0x0401DC82 RID: 121986
		private const string ANIM_TO_DAY = "ToDay";

		// Token: 0x0401DC83 RID: 121987
		private const string ANIM_TO_DUSK = "ToDusk";

		// Token: 0x0401DC84 RID: 121988
		private const string ANIM_DAY = "Day";

		// Token: 0x0401DC85 RID: 121989
		private const string ANIM_DUSK = "Dusk";

		// Token: 0x0401DC86 RID: 121990
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401DC87 RID: 121991
		private ESolarSchoolMapTimePhase? TimePhase;

		// Token: 0x0401DC88 RID: 121992
		[Nullable(2)]
		private Action TransitionFinish;

		// Token: 0x0401DC89 RID: 121993
		[Nullable(2)]
		private string PlayingAnim;

		// Token: 0x0401DC8A RID: 121994
		private bool DateChangePending;

		// Token: 0x0200B539 RID: 46393
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038082 RID: 229506
			public const int TexBg = 0;

			// Token: 0x04038083 RID: 229507
			public const int TxtWeek = 1;

			// Token: 0x04038084 RID: 229508
			public const int TxtTime = 2;

			// Token: 0x04038085 RID: 229509
			public const int ArtTxtMonth = 3;

			// Token: 0x04038086 RID: 229510
			public const int ArtTxtDay = 4;

			// Token: 0x04038087 RID: 229511
			public const int PnlTxtTime = 5;
		}
	}
}
