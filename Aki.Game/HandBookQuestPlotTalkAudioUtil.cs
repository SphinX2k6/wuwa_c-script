using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.PlotView;

// Token: 0x020012E7 RID: 4839
[NullableContext(2)]
[Nullable(0)]
public class HandBookQuestPlotTalkAudioUtil : IStaticVariableResetter
{
	// Token: 0x0600BE93 RID: 48787 RVA: 0x0038368E File Offset: 0x0038188E
	static HandBookQuestPlotTalkAudioUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HandBookQuestPlotTalkAudioUtil.CreateStaticDefaultValue), new Action(HandBookQuestPlotTalkAudioUtil.ResetStaticDefaultValue));
	}

	// Token: 0x0600BE94 RID: 48788 RVA: 0x003836C9 File Offset: 0x003818C9
	public static void CreateStaticDefaultValue()
	{
		HandBookQuestPlotTalkAudioUtil.PlotPlayEventResult = new PlayResult();
		HandBookQuestPlotTalkAudioUtil.AudioDelegate = new PlotAudioDelegate();
	}

	// Token: 0x0600BE95 RID: 48789 RVA: 0x003836DF File Offset: 0x003818DF
	public static void ResetStaticDefaultValue()
	{
		HandBookQuestPlotTalkAudioUtil.PlotPlayEventResult = null;
		HandBookQuestPlotTalkAudioUtil.AudioDelegate = null;
		HandBookQuestPlotTalkAudioUtil.WaitAudioLoadTimerId = null;
		HandBookQuestPlotTalkAudioUtil.PlayEndCallBackTimerId = null;
		HandBookQuestPlotTalkAudioUtil.CurrentPlayAudio = "";
		HandBookQuestPlotTalkAudioUtil.LastCallBack = null;
	}

	// Token: 0x0600BE96 RID: 48790 RVA: 0x0038370C File Offset: 0x0038190C
	public static void PlayAudio(PlotAudio config, [Nullable(new byte[]
	{
		1,
		2
	})] Action<string> callback)
	{
		HandBookQuestPlotTalkAudioUtil.AudioDelegate.Init(delegate(float duration)
		{
			HandBookQuestPlotTalkAudioUtil.RemoveWaitAudioLoadTimer();
			if (HandBookQuestPlotTalkAudioUtil.PlayEndCallBackTimerId != null)
			{
				HandBookQuestPlotTalkAudioUtil.RemovePlayEndCallBackTimer(true, config.Id);
			}
			HandBookQuestPlotTalkAudioUtil.LastCallBack = callback;
			HandBookQuestPlotTalkAudioUtil.CurrentPlayAudio = config.Id;
			HandBookQuestPlotTalkAudioUtil.PlayEndCallBackTimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				HandBookQuestPlotTalkAudioUtil.RemovePlayEndCallBackTimer(true, null);
			}, duration, null, null, true, 1f);
		});
		HandBookQuestPlotTalkAudioUtil.AudioDelegate.Enable();
		ExternalSourceSetting? config2 = ConfigExternalSourceSettingById.GetConfig(config.ExternalSourceSetting, true);
		string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(config);
		AudioController.Instance.PostEventByExternalSourcesByUi(config2.Value.SubtitleEvent, externalSourcesMediaName, config2.Value.SubtitleSrc, HandBookQuestPlotTalkAudioUtil.PlotPlayEventResult, null, new int?(8), HandBookQuestPlotTalkAudioUtil.AudioDelegate.AudioDelegate);
		HandBookQuestPlotTalkAudioUtil.WaitAudioLoadTimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			Log.Instance.Warn(ELogModule.Plot, ELogAuthor.LJQ, "加载剧情音频超时", default(ReadOnlySpan<ValueTuple<string, object>>));
			HandBookQuestPlotTalkAudioUtil.ClearCurPlayAudio();
		}, 3000f, null, null, true, 1f);
	}

	// Token: 0x0600BE97 RID: 48791 RVA: 0x003837EA File Offset: 0x003819EA
	public static void ClearCurPlayAudio()
	{
		HandBookQuestPlotTalkAudioUtil.CurrentPlayAudio = "";
		HandBookQuestPlotTalkAudioUtil.AudioDelegate.Disable();
		AudioController.Instance.StopEvent(HandBookQuestPlotTalkAudioUtil.PlotPlayEventResult, true, new int?(1000));
		HandBookQuestPlotTalkAudioUtil.RemoveWaitAudioLoadTimer();
		HandBookQuestPlotTalkAudioUtil.RemovePlayEndCallBackTimer(false, null);
	}

	// Token: 0x0600BE98 RID: 48792 RVA: 0x00383826 File Offset: 0x00381A26
	private static void RemoveWaitAudioLoadTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(HandBookQuestPlotTalkAudioUtil.WaitAudioLoadTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(HandBookQuestPlotTalkAudioUtil.WaitAudioLoadTimerId);
		}
		HandBookQuestPlotTalkAudioUtil.WaitAudioLoadTimerId = null;
	}

	// Token: 0x0600BE99 RID: 48793 RVA: 0x00383850 File Offset: 0x00381A50
	private static void RemovePlayEndCallBackTimer(bool callBack = true, string nextAudio = null)
	{
		if (HandBookQuestPlotTalkAudioUtil.LastCallBack != null && callBack)
		{
			HandBookQuestPlotTalkAudioUtil.LastCallBack(nextAudio);
			HandBookQuestPlotTalkAudioUtil.LastCallBack = null;
		}
		if (TimerSystem.GameplayTimeInstance.Has(HandBookQuestPlotTalkAudioUtil.PlayEndCallBackTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(HandBookQuestPlotTalkAudioUtil.PlayEndCallBackTimerId);
		}
		HandBookQuestPlotTalkAudioUtil.CurrentPlayAudio = "";
		HandBookQuestPlotTalkAudioUtil.PlayEndCallBackTimerId = null;
	}

	// Token: 0x0600BE9A RID: 48794 RVA: 0x003838AB File Offset: 0x00381AAB
	public static bool IsPlayingAudio(string audioId)
	{
		return HandBookQuestPlotTalkAudioUtil.CurrentPlayAudio == audioId;
	}

	// Token: 0x0600BE9B RID: 48795 RVA: 0x003838B8 File Offset: 0x00381AB8
	public static void ResetPlayEndCallBack([Nullable(new byte[]
	{
		1,
		2
	})] Action<string> callback)
	{
		HandBookQuestPlotTalkAudioUtil.LastCallBack = callback;
	}

	// Token: 0x04006DB2 RID: 28082
	private const int BREAK_TIME = 1000;

	// Token: 0x04006DB3 RID: 28083
	private const int MAX_LOAD_AUDIO_TIME = 3000;

	// Token: 0x04006DB4 RID: 28084
	private const int PLAY_FLAG = 8;

	// Token: 0x04006DB5 RID: 28085
	[Nullable(1)]
	private static PlayResult PlotPlayEventResult;

	// Token: 0x04006DB6 RID: 28086
	[Nullable(1)]
	private static PlotAudioDelegate AudioDelegate;

	// Token: 0x04006DB7 RID: 28087
	private static TimerHandle WaitAudioLoadTimerId = null;

	// Token: 0x04006DB8 RID: 28088
	private static TimerHandle PlayEndCallBackTimerId = null;

	// Token: 0x04006DB9 RID: 28089
	[Nullable(1)]
	private static string CurrentPlayAudio = "";

	// Token: 0x04006DBA RID: 28090
	private static Action<string> LastCallBack = null;
}
