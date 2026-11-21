using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Dialogue;
using CSharpScript.Game.Module.VisualNovel;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A72 RID: 23154
	[NullableContext(1)]
	[Nullable(0)]
	public static class SolarSchoolVisualNovelEntry
	{
		// Token: 0x17006CBC RID: 27836
		// (get) Token: 0x060390C3 RID: 233667 RVA: 0x00FFA31C File Offset: 0x00FF851C
		// (set) Token: 0x060390C4 RID: 233668 RVA: 0x00FFA323 File Offset: 0x00FF8523
		[StaticVariableRuleIgnore]
		public static int CurrentFlowId { get; private set; }

		// Token: 0x17006CBD RID: 27837
		// (get) Token: 0x060390C5 RID: 233669 RVA: 0x00FFA32B File Offset: 0x00FF852B
		public static bool IsPlaying
		{
			get
			{
				return SolarSchoolVisualNovelEntry.CurrentPlayer != null;
			}
		}

		// Token: 0x060390C6 RID: 233670 RVA: 0x00FFA335 File Offset: 0x00FF8535
		public static bool StopCurrent()
		{
			if (SolarSchoolVisualNovelEntry.CurrentPlayer == null)
			{
				return false;
			}
			SolarSchoolVisualNovelEntry.CurrentPlayer.Stop();
			return true;
		}

		// Token: 0x060390C7 RID: 233671 RVA: 0x00FFA34C File Offset: 0x00FF854C
		[NullableContext(0)]
		public static UniTask<bool> PlayAsync([Nullable(1)] string flowListName, int flowId, int stateId, int solarSchoolFlowId = 0)
		{
			SolarSchoolVisualNovelEntry.<PlayAsync>d__9 <PlayAsync>d__;
			<PlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlayAsync>d__.flowListName = flowListName;
			<PlayAsync>d__.flowId = flowId;
			<PlayAsync>d__.stateId = stateId;
			<PlayAsync>d__.solarSchoolFlowId = solarSchoolFlowId;
			<PlayAsync>d__.<>1__state = -1;
			<PlayAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelEntry.<PlayAsync>d__9>(ref <PlayAsync>d__);
			return <PlayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060390C8 RID: 233672 RVA: 0x00FFA3A8 File Offset: 0x00FF85A8
		private static UniTask CloseRemainedMovieViewAsync(VisualNovelContext context, bool waitClosed)
		{
			SolarSchoolVisualNovelEntry.<CloseRemainedMovieViewAsync>d__10 <CloseRemainedMovieViewAsync>d__;
			<CloseRemainedMovieViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseRemainedMovieViewAsync>d__.context = context;
			<CloseRemainedMovieViewAsync>d__.waitClosed = waitClosed;
			<CloseRemainedMovieViewAsync>d__.<>1__state = -1;
			<CloseRemainedMovieViewAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelEntry.<CloseRemainedMovieViewAsync>d__10>(ref <CloseRemainedMovieViewAsync>d__);
			return <CloseRemainedMovieViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060390C9 RID: 233673 RVA: 0x00FFA3F4 File Offset: 0x00FF85F4
		private static UniTask WaitMovieCoverAsync(UniTask task, string step)
		{
			SolarSchoolVisualNovelEntry.<WaitMovieCoverAsync>d__11 <WaitMovieCoverAsync>d__;
			<WaitMovieCoverAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitMovieCoverAsync>d__.task = task;
			<WaitMovieCoverAsync>d__.step = step;
			<WaitMovieCoverAsync>d__.<>1__state = -1;
			<WaitMovieCoverAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelEntry.<WaitMovieCoverAsync>d__11>(ref <WaitMovieCoverAsync>d__);
			return <WaitMovieCoverAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060390CA RID: 233674 RVA: 0x00FFA440 File Offset: 0x00FF8640
		private static VisualNovelContext CreateContext(DialogueScript script, int activityId, int solarSchoolFlowId)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolTimeData timeData = instance.TimeData;
			VisualNovelDate date = new VisualNovelDate(timeData.Month, timeData.Day, (int)timeData.DisplaySlot);
			if (instance.EndingVisualNovelTime != null)
			{
				date = instance.EndingVisualNovelTime.Value;
			}
			SetPlotMode plotMode = script.GetPlotMode();
			IVisualNovelConfig visualNovelConfig = (plotMode != null) ? plotMode.VisualNovelConfig : null;
			ISolarSchoolTime solarSchoolTime = (visualNovelConfig != null) ? visualNovelConfig.InitialTime : null;
			if (solarSchoolTime != null)
			{
				IVisualNovelDate date2 = solarSchoolTime.Date;
				date = ((date2 != null) ? new VisualNovelDate(date2.Month, date2.Day, solarSchoolTime.PeriodId) : new VisualNovelDate(date.Month, date.Day, solarSchoolTime.PeriodId));
			}
			SolarSchoolConfig instance2 = SolarSchoolConfig.Instance;
			float fastForwardRate = (float)instance2.GetParamInt(activityId, "VisualNovelFastForwardRate", 200) / 100f;
			int paramInt = instance2.GetParamInt(activityId, "VisualNovelUltraFastForwardRate", 1000);
			float readFastForwardRate = (float)instance2.GetParamInt(activityId, "VisualNovelReadFastForwardRate", paramInt) / 100f;
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("VisualNovelNoVoiceEndWaitTime").GetValueOrDefault(3000);
			Action<int> syncReadRecord = (solarSchoolFlowId > 0) ? delegate(int plotId)
			{
				SolarSchoolController.Instance.RecordReadPlot(solarSchoolFlowId, plotId);
			} : null;
			VisualNovelContext visualNovelContext = new VisualNovelContext(script, date, ((visualNovelConfig != null) ? visualNovelConfig.InitialBackgroundId : null).GetValueOrDefault(), new SolarSchoolVisualNovelConfigCenter())
			{
				ActionCenter = new SolarSchoolVisualNovelActionCenter(),
				SyncReadRecord = syncReadRecord,
				FastForwardRate = fastForwardRate,
				ReadFastForwardRate = readFastForwardRate,
				UltraFastForwardRate = (float)paramInt / 100f,
				NoVoiceEndWaitTime = (float)((valueOrDefault >= 0) ? valueOrDefault : 3000) / 1000f,
				RemainLastMovieView = true
			};
			SolarSchoolModel instance3 = SolarSchoolModel.Instance;
			if (instance3.VisualNovelAutoPlayEnabled)
			{
				visualNovelContext.SetPlaybackMode(EVisualNovelPlaybackMode.Auto);
			}
			VisualNovelContext visualNovelContext2 = visualNovelContext;
			Action<EVisualNovelPlaybackMode> value;
			if ((value = SolarSchoolVisualNovelEntry.<>O.<0>__OnPlaybackModeChanged) == null)
			{
				value = (SolarSchoolVisualNovelEntry.<>O.<0>__OnPlaybackModeChanged = new Action<EVisualNovelPlaybackMode>(SolarSchoolVisualNovelEntry.OnPlaybackModeChanged));
			}
			visualNovelContext2.PlaybackModeChanged += value;
			if (solarSchoolFlowId <= 0)
			{
				return visualNovelContext;
			}
			visualNovelContext.ReadRecord.Load(instance3.GetReadPlotIds(solarSchoolFlowId));
			return visualNovelContext;
		}

		// Token: 0x060390CB RID: 233675 RVA: 0x00FFA66C File Offset: 0x00FF886C
		private static void OnPlaybackModeChanged(EVisualNovelPlaybackMode playbackMode)
		{
			if (playbackMode != EVisualNovelPlaybackMode.Auto && playbackMode != EVisualNovelPlaybackMode.Manual)
			{
				return;
			}
			SolarSchoolModel.Instance.VisualNovelAutoPlayEnabled = (playbackMode == EVisualNovelPlaybackMode.Auto);
		}

		// Token: 0x0401E04B RID: 122955
		private const int MovieCoverWaitTimeoutMs = 1000;

		// Token: 0x0401E04C RID: 122956
		[Nullable(2)]
		[StaticVariableRuleIgnore]
		private static VisualNovelPlayer CurrentPlayer;

		// Token: 0x0200B66C RID: 46700
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040386FF RID: 231167
			[Nullable(0)]
			public static Action<EVisualNovelPlaybackMode> <0>__OnPlaybackModeChanged;
		}
	}
}
