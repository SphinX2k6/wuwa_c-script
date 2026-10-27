using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

// Token: 0x02001023 RID: 4131
public class GuessJokerPlotAction : GuessJokerActionBase
{
	// Token: 0x06006A19 RID: 27161 RVA: 0x0015474C File Offset: 0x0015294C
	public unsafe GuessJokerPlotAction(EGuessJokerPlayerType playerType, EGuessJokerPlotTiming timing, int? extraParam = null)
	{
		this.TimingInternal = timing;
		this.PlayerTypeInternal = playerType;
		GuessJokerPlotConfig? plotConfig = GuessJokerUtils.GetPlotConfig(playerType, timing, extraParam);
		if (plotConfig == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GuessJokerPlotAction Fail：PlotConfig is undefined";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("playerType", playerType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("timing", timing);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("extraParam", extraParam);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.Done = true;
			return;
		}
		GuessJokerAIPlotConfig? jokerAiPlotConfig = GuessJokerConfig.Instance.GetJokerAiPlotConfig(playerType, timing, extraParam.GetValueOrDefault());
		if (jokerAiPlotConfig == null)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.GuessJokerCard;
			ELogAuthor author2 = ELogAuthor.LRC;
			string message2 = "GuessJokerPlotAction Fail：AiPlotConfig is undefined";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("playerType", playerType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("timing", timing);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			this.Done = true;
			return;
		}
		ITalkItemDialog talkItemDialog = null;
		List<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(plotConfig.Value.FlowListName, plotConfig.Value.FlowId, plotConfig.Value.StateId);
		if (flowStateActions != null)
		{
			ActionInfo actionInfo = null;
			for (int i = 0; i < flowStateActions.Count; i++)
			{
				if (flowStateActions[i].Name == EAction.ShowTalk)
				{
					actionInfo = flowStateActions[i];
					break;
				}
			}
			if (actionInfo != null)
			{
				ITalkItem talkItem = ((ShowTalk)actionInfo.Params).TalkItems[0];
				ETalkItemType? type = talkItem.Type;
				ETalkItemType etalkItemType = ETalkItemType.Talk;
				if (type.GetValueOrDefault() == etalkItemType & type != null)
				{
					talkItemDialog = (ITalkItemDialog)talkItem;
				}
			}
		}
		if (talkItemDialog == null)
		{
			this.Done = true;
			return;
		}
		this.TalkData = talkItemDialog;
		this.PlotConfig = plotConfig;
		this.AiPlotConfig = jokerAiPlotConfig;
	}

	// Token: 0x06006A1A RID: 27162 RVA: 0x00154970 File Offset: 0x00152B70
	protected override void OnStart()
	{
		if (this.TalkData == null)
		{
			this.Done = true;
			return;
		}
		if (this.DelayTime > 0f)
		{
			this.IsDelayed = true;
			this.DelayElapsed = 0f;
			return;
		}
		GuessJokerGamePlayModel.Instance.SetLastUsedPlotId(this.AiPlotId, this.PlotId);
		this.StartActualPlayback();
	}

	// Token: 0x06006A1B RID: 27163 RVA: 0x001549CC File Offset: 0x00152BCC
	protected override void OnTick(float delta)
	{
		if (this.IsDelayed)
		{
			this.DelayElapsed += delta;
			if (this.DelayElapsed >= this.DelayTime)
			{
				this.IsDelayed = false;
				this.DelayElapsed = 0f;
				GuessJokerGamePlayModel.Instance.SetLastUsedPlotId(this.AiPlotId, this.PlotId);
				this.StartActualPlayback();
			}
		}
	}

	// Token: 0x06006A1C RID: 27164 RVA: 0x00154A2C File Offset: 0x00152C2C
	private void StartActualPlayback()
	{
		if (this.TalkData == null)
		{
			this.Done = true;
			return;
		}
		GuessJokerDialogLogic activeDialogLogic = GuessJokerGamePlayModel.Instance.GetActiveDialogLogic();
		if (activeDialogLogic != null)
		{
			activeDialogLogic.PlayDialog(this.TalkData, delegate
			{
				this.Done = true;
			});
			return;
		}
		global::Log.Instance.Warn(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJokerPlotAction：未找到活跃的对话逻辑", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.Done = true;
	}

	// Token: 0x17000880 RID: 2176
	// (get) Token: 0x06006A1D RID: 27165 RVA: 0x00154A96 File Offset: 0x00152C96
	public EGuessJokerPlotTiming Timing
	{
		get
		{
			return this.TimingInternal;
		}
	}

	// Token: 0x17000881 RID: 2177
	// (get) Token: 0x06006A1E RID: 27166 RVA: 0x00154A9E File Offset: 0x00152C9E
	public EGuessJokerPlayerType PlayerType
	{
		get
		{
			return this.PlayerTypeInternal;
		}
	}

	// Token: 0x17000882 RID: 2178
	// (get) Token: 0x06006A1F RID: 27167 RVA: 0x00154AA8 File Offset: 0x00152CA8
	public int AiPlotId
	{
		get
		{
			if (this.AiPlotConfig == null)
			{
				return 0;
			}
			return this.AiPlotConfig.GetValueOrDefault().Id;
		}
	}

	// Token: 0x17000883 RID: 2179
	// (get) Token: 0x06006A20 RID: 27168 RVA: 0x00154AD4 File Offset: 0x00152CD4
	public int PlotId
	{
		get
		{
			if (this.PlotConfig == null)
			{
				return 0;
			}
			return this.PlotConfig.GetValueOrDefault().Id;
		}
	}

	// Token: 0x17000884 RID: 2180
	// (get) Token: 0x06006A21 RID: 27169 RVA: 0x00154B00 File Offset: 0x00152D00
	public float DelayTime
	{
		get
		{
			return (float)((this.AiPlotConfig != null) ? this.AiPlotConfig.GetValueOrDefault().DelayTime : 0);
		}
	}

	// Token: 0x17000885 RID: 2181
	// (get) Token: 0x06006A22 RID: 27170 RVA: 0x00154B30 File Offset: 0x00152D30
	public bool CanHardCut
	{
		get
		{
			return this.AiPlotConfig != null && this.AiPlotConfig.GetValueOrDefault().CanHardCut;
		}
	}

	// Token: 0x17000886 RID: 2182
	// (get) Token: 0x06006A23 RID: 27171 RVA: 0x00154B5C File Offset: 0x00152D5C
	public float WaitDeleteTime
	{
		get
		{
			return (float)((this.AiPlotConfig != null) ? this.AiPlotConfig.GetValueOrDefault().WaitDeleteTime : 0);
		}
	}

	// Token: 0x17000887 RID: 2183
	// (get) Token: 0x06006A24 RID: 27172 RVA: 0x00154B8C File Offset: 0x00152D8C
	public float Cd
	{
		get
		{
			return (float)((this.AiPlotConfig != null) ? this.AiPlotConfig.GetValueOrDefault().Cd : 0);
		}
	}

	// Token: 0x17000888 RID: 2184
	// (get) Token: 0x06006A25 RID: 27173 RVA: 0x00154BB9 File Offset: 0x00152DB9
	public bool IsInDelay
	{
		get
		{
			return this.IsDelayed;
		}
	}

	// Token: 0x06006A26 RID: 27174 RVA: 0x00154BC4 File Offset: 0x00152DC4
	protected override void OnFinish()
	{
		GuessJokerDialogLogic activeDialogLogic = GuessJokerGamePlayModel.Instance.GetActiveDialogLogic();
		if (activeDialogLogic != null)
		{
			activeDialogLogic.Clear();
		}
		this.IsDelayed = false;
		this.DelayElapsed = 0f;
		this.PlotConfig = null;
		this.TalkData = null;
		this.AiPlotConfig = null;
	}

	// Token: 0x040030E5 RID: 12517
	[Nullable(2)]
	private ITalkItemDialog TalkData;

	// Token: 0x040030E6 RID: 12518
	private GuessJokerPlotConfig? PlotConfig;

	// Token: 0x040030E7 RID: 12519
	private GuessJokerAIPlotConfig? AiPlotConfig;

	// Token: 0x040030E8 RID: 12520
	private readonly EGuessJokerPlotTiming TimingInternal;

	// Token: 0x040030E9 RID: 12521
	private readonly EGuessJokerPlayerType PlayerTypeInternal;

	// Token: 0x040030EA RID: 12522
	private bool IsDelayed;

	// Token: 0x040030EB RID: 12523
	private float DelayElapsed;
}
