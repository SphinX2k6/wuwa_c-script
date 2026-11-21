using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

// Token: 0x020004D7 RID: 1239
public class GuessJokerPlotAction : GuessJokerActionBase
{
	// Token: 0x06003DAE RID: 15790 RVA: 0x0015D074 File Offset: 0x0015B274
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

	// Token: 0x06003DAF RID: 15791 RVA: 0x0015D298 File Offset: 0x0015B498
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

	// Token: 0x06003DB0 RID: 15792 RVA: 0x0015D2F4 File Offset: 0x0015B4F4
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

	// Token: 0x06003DB1 RID: 15793 RVA: 0x0015D354 File Offset: 0x0015B554
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

	// Token: 0x170008A0 RID: 2208
	// (get) Token: 0x06003DB2 RID: 15794 RVA: 0x0015D3BE File Offset: 0x0015B5BE
	public EGuessJokerPlotTiming Timing
	{
		get
		{
			return this.TimingInternal;
		}
	}

	// Token: 0x170008A1 RID: 2209
	// (get) Token: 0x06003DB3 RID: 15795 RVA: 0x0015D3C6 File Offset: 0x0015B5C6
	public EGuessJokerPlayerType PlayerType
	{
		get
		{
			return this.PlayerTypeInternal;
		}
	}

	// Token: 0x170008A2 RID: 2210
	// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x0015D3D0 File Offset: 0x0015B5D0
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

	// Token: 0x170008A3 RID: 2211
	// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x0015D3FC File Offset: 0x0015B5FC
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

	// Token: 0x170008A4 RID: 2212
	// (get) Token: 0x06003DB6 RID: 15798 RVA: 0x0015D428 File Offset: 0x0015B628
	public float DelayTime
	{
		get
		{
			return (float)((this.AiPlotConfig != null) ? this.AiPlotConfig.GetValueOrDefault().DelayTime : 0);
		}
	}

	// Token: 0x170008A5 RID: 2213
	// (get) Token: 0x06003DB7 RID: 15799 RVA: 0x0015D458 File Offset: 0x0015B658
	public bool CanHardCut
	{
		get
		{
			return this.AiPlotConfig != null && this.AiPlotConfig.GetValueOrDefault().CanHardCut;
		}
	}

	// Token: 0x170008A6 RID: 2214
	// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x0015D484 File Offset: 0x0015B684
	public float WaitDeleteTime
	{
		get
		{
			return (float)((this.AiPlotConfig != null) ? this.AiPlotConfig.GetValueOrDefault().WaitDeleteTime : 0);
		}
	}

	// Token: 0x170008A7 RID: 2215
	// (get) Token: 0x06003DB9 RID: 15801 RVA: 0x0015D4B4 File Offset: 0x0015B6B4
	public float Cd
	{
		get
		{
			return (float)((this.AiPlotConfig != null) ? this.AiPlotConfig.GetValueOrDefault().Cd : 0);
		}
	}

	// Token: 0x170008A8 RID: 2216
	// (get) Token: 0x06003DBA RID: 15802 RVA: 0x0015D4E1 File Offset: 0x0015B6E1
	public bool IsInDelay
	{
		get
		{
			return this.IsDelayed;
		}
	}

	// Token: 0x06003DBB RID: 15803 RVA: 0x0015D4EC File Offset: 0x0015B6EC
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

	// Token: 0x0400317E RID: 12670
	[Nullable(2)]
	private ITalkItemDialog TalkData;

	// Token: 0x0400317F RID: 12671
	private GuessJokerPlotConfig? PlotConfig;

	// Token: 0x04003180 RID: 12672
	private GuessJokerAIPlotConfig? AiPlotConfig;

	// Token: 0x04003181 RID: 12673
	private readonly EGuessJokerPlotTiming TimingInternal;

	// Token: 0x04003182 RID: 12674
	private readonly EGuessJokerPlayerType PlayerTypeInternal;

	// Token: 0x04003183 RID: 12675
	private bool IsDelayed;

	// Token: 0x04003184 RID: 12676
	private float DelayElapsed;
}
