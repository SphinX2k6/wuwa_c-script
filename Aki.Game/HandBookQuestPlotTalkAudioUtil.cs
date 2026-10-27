using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.PlotView;

// Token: 0x02001E25 RID: 7717
[NullableContext(2)]
[Nullable(0)]
public class HandBookQuestPlotTalkAudioUtil : IStaticVariableResetter
{
	// Token: 0x0600EA74 RID: 60020 RVA: 0x00377986 File Offset: 0x00375B86
	static HandBookQuestPlotTalkAudioUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HandBookQuestPlotTalkAudioUtil.CreateStaticDefaultValue), new Action(HandBookQuestPlotTalkAudioUtil.ResetStaticDefaultValue));
	}

	// Token: 0x0600EA75 RID: 60021 RVA: 0x003779C1 File Offset: 0x00375BC1
	public static void CreateStaticDefaultValue()
	{
		HandBookQuestPlotTalkAudioUtil.PlotPlayEventResult = new PlayResult();
		HandBookQuestPlotTalkAudioUtil.AudioDelegate = new PlotAudioDelegate();
	}

	// Token: 0x0600EA76 RID: 60022 RVA: 0x003779D7 File Offset: 0x00375BD7
	public static void ResetStaticDefaultValue()
	{
		HandBookQuestPlotTalkAudioUtil.PlotPlayEventResult = null;
		HandBookQuestPlotTalkAudioUtil.AudioDelegate = null;
		HandBookQuestPlotTalkAudioUtil.WaitAudioLoadTimerId = null;
		HandBookQuestPlotTalkAudioUtil.PlayEndCallBackTimerId = null;
		HandBookQuestPlotTalkAudioUtil.CurrentPlayAudio = "";
		HandBookQuestPlotTalkAudioUtil.LastCallBack = null;
	}

	// Token: 0x0600EA77 RID: 60023 RVA: 0x00377A04 File Offset: 0x00375C04
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

	// Token: 0x0600EA78 RID: 60024 RVA: 0x00377AE2 File Offset: 0x00375CE2
	public static void ClearCurPlayAudio()
	{
		HandBookQuestPlotTalkAudioUtil.CurrentPlayAudio = "";
		HandBookQuestPlotTalkAudioUtil.AudioDelegate.Disable();
		AudioController.Instance.StopEvent(HandBookQuestPlotTalkAudioUtil.PlotPlayEventResult, true, new int?(1000));
		HandBookQuestPlotTalkAudioUtil.RemoveWaitAudioLoadTimer();
		HandBookQuestPlotTalkAudioUtil.RemovePlayEndCallBackTimer(false, null);
	}

	// Token: 0x0600EA79 RID: 60025 RVA: 0x00377B1E File Offset: 0x00375D1E
	private static void RemoveWaitAudioLoadTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(HandBookQuestPlotTalkAudioUtil.WaitAudioLoadTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(HandBookQuestPlotTalkAudioUtil.WaitAudioLoadTimerId);
		}
		HandBookQuestPlotTalkAudioUtil.WaitAudioLoadTimerId = null;
	}

	// Token: 0x0600EA7A RID: 60026 RVA: 0x00377B48 File Offset: 0x00375D48
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

	// Token: 0x0600EA7B RID: 60027 RVA: 0x00377BA3 File Offset: 0x00375DA3
	public static bool IsPlayingAudio(string audioId)
	{
		return HandBookQuestPlotTalkAudioUtil.CurrentPlayAudio == audioId;
	}

	// Token: 0x0600EA7C RID: 60028 RVA: 0x00377BB0 File Offset: 0x00375DB0
	public static void ResetPlayEndCallBack([Nullable(new byte[]
	{
		1,
		2
	})] Action<string> callback)
	{
		HandBookQuestPlotTalkAudioUtil.LastCallBack = callback;
	}

	// Token: 0x04006CD1 RID: 27857
	private const int BREAK_TIME = 1000;

	// Token: 0x04006CD2 RID: 27858
	private const int MAX_LOAD_AUDIO_TIME = 3000;

	// Token: 0x04006CD3 RID: 27859
	private const int PLAY_FLAG = 8;

	// Token: 0x04006CD4 RID: 27860
	[Nullable(1)]
	private static PlayResult PlotPlayEventResult;

	// Token: 0x04006CD5 RID: 27861
	[Nullable(1)]
	private static PlotAudioDelegate AudioDelegate;

	// Token: 0x04006CD6 RID: 27862
	private static TimerHandle WaitAudioLoadTimerId = null;

	// Token: 0x04006CD7 RID: 27863
	private static TimerHandle PlayEndCallBackTimerId = null;

	// Token: 0x04006CD8 RID: 27864
	[Nullable(1)]
	private static string CurrentPlayAudio = "";

	// Token: 0x04006CD9 RID: 27865
	private static Action<string> LastCallBack = null;
}
