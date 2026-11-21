using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A17 RID: 23063
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolDayChangeLoadingView : UiTickViewBase
	{
		// Token: 0x06038CB4 RID: 232628 RVA: 0x00FE5B83 File Offset: 0x00FE3D83
		public SolarSchoolDayChangeLoadingView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038CB5 RID: 232629 RVA: 0x00FE5B98 File Offset: 0x00FE3D98
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIArtText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038CB6 RID: 232630 RVA: 0x00FE5C04 File Offset: 0x00FE3E04
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolDayChangeLoadingView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolDayChangeLoadingView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038CB7 RID: 232631 RVA: 0x00FE5C48 File Offset: 0x00FE3E48
		protected override void OnBeforeShow()
		{
			GameAudioController.Instance.UpdateLoadingType(new ELoadingPerform?(ELoadingPerform.Loading));
			SolarSchoolDayChangeLoadingParam solarSchoolDayChangeLoadingParam = this.OpenParam as SolarSchoolDayChangeLoadingParam;
			if (solarSchoolDayChangeLoadingParam == null || string.IsNullOrEmpty(solarSchoolDayChangeLoadingParam.SequenceName))
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 跨天全屏动效打开参数缺失或类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CloseSelf();
				return;
			}
			this.SequenceName = solarSchoolDayChangeLoadingParam.SequenceName;
			this.TargetDayIndex = solarSchoolDayChangeLoadingParam.TargetDayIndex;
			DateTime date = SolarSchoolUtils.GetDate(solarSchoolDayChangeLoadingParam.StartDayIndex);
			this.RefreshDateText(date.Month, date.Day, date.DayOfWeek, ESolarSchoolTimeSlot.Night);
		}

		// Token: 0x06038CB8 RID: 232632 RVA: 0x00FE5CE7 File Offset: 0x00FE3EE7
		protected override void OnAfterShow()
		{
			if (string.IsNullOrEmpty(this.SequenceName))
			{
				return;
			}
			base.PlaySequence(this.SequenceName, new Action(this.OnSequenceFinished), true);
		}

		// Token: 0x06038CB9 RID: 232633 RVA: 0x00FE5D10 File Offset: 0x00FE3F10
		protected override void OnTick(float delta)
		{
			this.TryClose();
		}

		// Token: 0x06038CBA RID: 232634 RVA: 0x00FE5D18 File Offset: 0x00FE3F18
		protected override void OnBeforeHide()
		{
			GameAudioController.Instance.UpdateLoadingType(null);
		}

		// Token: 0x06038CBB RID: 232635 RVA: 0x00FE5D38 File Offset: 0x00FE3F38
		protected override void OnAfterHide()
		{
			this.NotifyCoverReadyOnce();
			this.NotifyDateChangeOnce();
			SolarSchoolModel.Instance.OnLoadingViewHidden();
		}

		// Token: 0x06038CBC RID: 232636 RVA: 0x00FE5D50 File Offset: 0x00FE3F50
		protected override void OnBeforeDestroy()
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor == null)
			{
				return;
			}
			rootActor.OnSequencePlayEvent.Unbind();
		}

		// Token: 0x06038CBD RID: 232637 RVA: 0x00FE5D67 File Offset: 0x00FE3F67
		private void OnSequenceFinished()
		{
			this.SequenceFinished = true;
			this.NotifyCoverReadyOnce();
			this.NotifyDateChangeOnce();
			this.TryClose();
		}

		// Token: 0x06038CBE RID: 232638 RVA: 0x00FE5D82 File Offset: 0x00FE3F82
		private void TryClose()
		{
			if (this.Closing || !this.SequenceFinished || !SolarSchoolModel.Instance.IsFirstScreenReady)
			{
				return;
			}
			this.Closing = true;
			this.CloseSelf();
		}

		// Token: 0x06038CBF RID: 232639 RVA: 0x00FE5DAE File Offset: 0x00FE3FAE
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Cover_Ready")
			{
				this.NotifyCoverReadyOnce();
				return;
			}
			if (eventName != "Sequence_Date_Change")
			{
				return;
			}
			this.NotifyCoverReadyOnce();
			this.PushDateToNextDay();
			this.NotifyDateChangeOnce();
		}

		// Token: 0x06038CC0 RID: 232640 RVA: 0x00FE5DE4 File Offset: 0x00FE3FE4
		private void NotifyCoverReadyOnce()
		{
			if (this.CoverReady)
			{
				return;
			}
			this.CoverReady = true;
			SolarSchoolDayChangeLoadingParam solarSchoolDayChangeLoadingParam = this.OpenParam as SolarSchoolDayChangeLoadingParam;
			if (solarSchoolDayChangeLoadingParam == null)
			{
				return;
			}
			Action coverReadyCallback = solarSchoolDayChangeLoadingParam.CoverReadyCallback;
			if (coverReadyCallback == null)
			{
				return;
			}
			coverReadyCallback();
		}

		// Token: 0x06038CC1 RID: 232641 RVA: 0x00FE5E15 File Offset: 0x00FE4015
		private void NotifyDateChangeOnce()
		{
			if (this.DateChanged)
			{
				return;
			}
			this.DateChanged = true;
			SolarSchoolDayChangeLoadingParam solarSchoolDayChangeLoadingParam = this.OpenParam as SolarSchoolDayChangeLoadingParam;
			if (solarSchoolDayChangeLoadingParam == null)
			{
				return;
			}
			Action dateChangeCallback = solarSchoolDayChangeLoadingParam.DateChangeCallback;
			if (dateChangeCallback == null)
			{
				return;
			}
			dateChangeCallback();
		}

		// Token: 0x06038CC2 RID: 232642 RVA: 0x00FE5E48 File Offset: 0x00FE4048
		private void PushDateToNextDay()
		{
			ValueTuple<int, int> monthDay = SolarSchoolUtils.GetMonthDay(this.TargetDayIndex);
			int item = monthDay.Item1;
			int item2 = monthDay.Item2;
			this.RefreshDateText(item, item2, SolarSchoolUtils.GetDate(this.TargetDayIndex).DayOfWeek, ESolarSchoolTimeSlot.Morning);
		}

		// Token: 0x06038CC3 RID: 232643 RVA: 0x00FE5E8C File Offset: 0x00FE408C
		private void RefreshDateText(int month, int day, DayOfWeek dayOfWeek, ESolarSchoolTimeSlot slot)
		{
			UUIArtText artText = base.GetArtText(1);
			if (artText != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(month, "D2");
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(day, "D2");
				artText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(SolarSchoolUtils.GetLoadingWeekdayText(dayOfWeek) ?? "", true);
		}

		// Token: 0x0401DE57 RID: 122455
		private string SequenceName = string.Empty;

		// Token: 0x0401DE58 RID: 122456
		private int TargetDayIndex;

		// Token: 0x0401DE59 RID: 122457
		private bool DateChanged;

		// Token: 0x0401DE5A RID: 122458
		private bool CoverReady;

		// Token: 0x0401DE5B RID: 122459
		private bool SequenceFinished;

		// Token: 0x0401DE5C RID: 122460
		private bool Closing;

		// Token: 0x0200B5D6 RID: 46550
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040383BD RID: 230333
			public const int TxtWeekSlot = 0;

			// Token: 0x040383BE RID: 230334
			public const int ArtTxtDate = 1;
		}
	}
}
