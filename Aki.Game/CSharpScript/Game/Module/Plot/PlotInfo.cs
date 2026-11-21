using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.SlidingBlocks;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FAC RID: 16300
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotInfo : IStaticVariableResetter
	{
		// Token: 0x06029411 RID: 168977 RVA: 0x00B96D89 File Offset: 0x00B94F89
		static PlotInfo()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotInfo.CreateStaticDefaultValue), new Action(PlotInfo.ResetStaticDefaultValue));
		}

		// Token: 0x17005377 RID: 21367
		// (get) Token: 0x06029412 RID: 168978 RVA: 0x00B96DA8 File Offset: 0x00B94FA8
		[Nullable(1)]
		private static Pool<PlotInfo> Pool
		{
			[NullableContext(1)]
			get
			{
				return PlotInfo._pool;
			}
		}

		// Token: 0x06029413 RID: 168979 RVA: 0x00B96DB0 File Offset: 0x00B94FB0
		public PlotInfo()
		{
			this.FlowListName = "";
			this.FlowId = 0;
			this.StateId = new int?(0);
			this.StateActions = null;
			this.KeepMusic = false;
			this.Context = null;
			this.IsServerNotify = false;
			this.FlowIncId = 0L;
			this.IsBackground = false;
			this.IsBreakdown = false;
			this.IsServerEnd = false;
			this.IsAsync = false;
			this.PlotLevel = EPlotLevel.LevelC;
			this.IsWaitAnim = false;
			this.UiParam = null;
			this.CanBeAbandoned = false;
			this.FadeBegin = null;
			this.Pos = null;
			this.KeepMainRolePose = false;
			this.CheckPreload = false;
			this.Seamless = false;
			this.PreloadSequenceUiData = new List<string>();
		}

		// Token: 0x06029414 RID: 168980 RVA: 0x00B96E70 File Offset: 0x00B95070
		public void Init(bool isServerNotify, long flowIncId, [Nullable(1)] string flowListName, int flowId, int stateId, [Nullable(1)] List<ActionInfo> stateActions, bool keepMusic, GeneralContext context, bool isAsync, UiParam uiParam = null, bool canBeAbandoned = false, bool isSkip = false, global::Vector pos = null, bool checkPreload = false, Action callback = null, bool isTeleportTransition = false, IStateProgramSpecialProcessChangeTeamOptimization programSpecialProcess = null)
		{
			this.FlowListName = flowListName;
			this.FlowId = flowId;
			this.StateId = new int?(stateId);
			this.StateActions = stateActions;
			this.KeepMusic = keepMusic;
			this.IsServerNotify = isServerNotify;
			this.Context = context;
			this.FlowIncId = flowIncId;
			this.IsBackground = isSkip;
			this.IsBreakdown = false;
			this.IsAsync = isAsync;
			this.UiParam = (uiParam ?? new UiParam());
			this.CanBeAbandoned = canBeAbandoned;
			this.Pos = pos;
			this.CheckPreload = checkPreload;
			this.Callback = callback;
			this.IsTeleportTransition = isTeleportTransition;
			this.ProgramSpecialProcess = programSpecialProcess;
			this.Seamless = checkPreload;
			PlotInfo.AnalyzeLevel(this, stateActions);
		}

		// Token: 0x06029415 RID: 168981 RVA: 0x00B96F28 File Offset: 0x00B95128
		[NullableContext(1)]
		public static void AnalyzeLevel(PlotInfo plotInfo, List<ActionInfo> actions)
		{
			EPlotLevel eplotLevel = EPlotLevel.LevelC;
			EPromptStyle? epromptStyle = null;
			bool isWaitAnim = false;
			bool value = false;
			EFadeInScreenShowType? fadeBegin = null;
			bool keepMainRolePose = false;
			if (actions.Count > 0)
			{
				ActionInfo actionInfo = actions[0];
				if (actionInfo.Name == EAction.SetPlotMode)
				{
					SetPlotMode setPlotMode = actionInfo.Params as SetPlotMode;
					eplotLevel = PlotInfo.GetPlotLevelByMode(setPlotMode.Mode);
					IPromptStyleBase promptStyle = setPlotMode.PromptStyle;
					epromptStyle = ((promptStyle != null) ? new EPromptStyle?(promptStyle.Type) : null);
					isWaitAnim = setPlotMode.WaitForPlayerMotionEnd.GetValueOrDefault();
					value = (setPlotMode.NoUiEnterAnimation.GetValueOrDefault() || plotInfo.Seamless);
					if (setPlotMode.FastFadeIn != null)
					{
						fadeBegin = new EFadeInScreenShowType?(setPlotMode.FastFadeIn.ScreenType.GetValueOrDefault(EFadeInScreenShowType.Black));
					}
					if (setPlotMode.KeepMainRolePose != null && setPlotMode.KeepMainRolePose.Value)
					{
						keepMainRolePose = true;
					}
				}
			}
			if (fadeBegin == null && actions.Count > 1)
			{
				ActionInfo actionInfo2 = actions[1];
				if (actionInfo2.Name == EAction.FadeInScreen)
				{
					FadeInScreen fadeInScreen = actionInfo2.Params as FadeInScreen;
					fadeBegin = new EFadeInScreenShowType?(fadeInScreen.ScreenType.GetValueOrDefault(EFadeInScreenShowType.Black));
				}
			}
			if (plotInfo.Seamless)
			{
				string a = "";
				foreach (ActionInfo actionInfo3 in actions)
				{
					if (actionInfo3.Name == EAction.SetPlotMode)
					{
						a = (actionInfo3.Params as SetPlotMode).Mode;
					}
					else if (actionInfo3.Name == EAction.ShowTalk && (a == EPlotLevel.LevelB.ToEnumString() || a == EPlotLevel.LevelA.ToEnumString()))
					{
						ShowTalk showTalk = actionInfo3.Params as ShowTalk;
						plotInfo.PreloadSequenceUiData.Add(showTalk.SequenceDataAsset);
					}
				}
			}
			plotInfo.PlotLevel = eplotLevel;
			plotInfo.IsWaitAnim = isWaitAnim;
			if (plotInfo.UiParam != null)
			{
				plotInfo.UiParam.DisableAnim = new bool?(value);
			}
			plotInfo.FadeBegin = fadeBegin;
			plotInfo.KeepMainRolePose = keepMainRolePose;
			if (eplotLevel == EPlotLevel.LevelD || eplotLevel == EPlotLevel.LevelE)
			{
				UiParam uiParam = plotInfo.UiParam;
				if ((uiParam == null || uiParam.ViewName == null) && plotInfo.UiParam != null)
				{
					plotInfo.UiParam.ViewName = new EUiViewName?(PlotInfo.GetViewName());
				}
			}
			if (eplotLevel == EPlotLevel.LevelE)
			{
				PlotInfo.ExtractIconTexturePathAndFirstAudio(actions, plotInfo);
				plotInfo.PromptStyle = new EPromptStyle?(epromptStyle.GetValueOrDefault());
			}
		}

		// Token: 0x06029416 RID: 168982 RVA: 0x00B971C8 File Offset: 0x00B953C8
		[NullableContext(1)]
		private static EPlotLevel GetPlotLevelByMode(string mode)
		{
			switch (EPlotModeExtensions.FromString(mode))
			{
			case EPlotMode.LevelA:
				return EPlotLevel.LevelA;
			case EPlotMode.LevelB:
				return EPlotLevel.LevelB;
			case EPlotMode.LevelC:
				return EPlotLevel.LevelC;
			case EPlotMode.LevelD:
				return EPlotLevel.LevelD;
			case EPlotMode.Prompt:
				return EPlotLevel.LevelE;
			case EPlotMode.Avg:
				return EPlotLevel.LevelC;
			case EPlotMode.ControlEntity:
				return EPlotLevel.ControlEntity;
			}
			return EPlotLevel.LevelC;
		}

		// Token: 0x06029417 RID: 168983 RVA: 0x00B97227 File Offset: 0x00B95427
		private static EUiViewName GetViewName()
		{
			if (SlidingBlocksModel.Instance.IsInGame)
			{
				return EUiViewName.TetrisGameView;
			}
			if (SplineConstrainedDragModel.Instance.GetDragActorPlayActive())
			{
				return EUiViewName.SplineConstrainedDrag;
			}
			return UiModel.Instance.MainViewName;
		}

		// Token: 0x06029418 RID: 168984 RVA: 0x00B97258 File Offset: 0x00B95458
		[NullableContext(1)]
		private unsafe static void ExtractIconTexturePathAndFirstAudio(List<ActionInfo> actions, PlotInfo plotInfo)
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			foreach (ActionInfo actionInfo in actions)
			{
				if (actionInfo.Name == EAction.ShowTalk)
				{
					foreach (ITalkItem talkItem in (actionInfo.Params as ShowTalk).TalkItems)
					{
						if (string.IsNullOrEmpty(plotInfo.BlockAudio) && talkItem.PlayVoice.GetValueOrDefault())
						{
							plotInfo.BlockAudio = talkItem.TidTalk;
						}
						if (talkItem.WhoId != null)
						{
							Speaker? config = ConfigSpeakerById.GetConfig(talkItem.WhoId.Value, true);
							if (!string.IsNullOrEmpty((config != null) ? config.GetValueOrDefault().HeadRoundIconAsset : null))
							{
								PlayerInfoModel instance = PlayerInfoModel.Instance;
								bool flag = instance != null && instance.GetPlayerGender() == EPlayerGender.Male && !string.IsNullOrEmpty(config.Value.HeadRoundIconAssetMaleVariant);
								dictionary[config.Value.Id] = (flag ? config.Value.HeadRoundIconAssetMaleVariant : config.Value.HeadRoundIconAsset);
							}
							else
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
								defaultInterpolatedStringHandler.AppendFormatted(plotInfo.FlowListName);
								defaultInterpolatedStringHandler.AppendLiteral(",");
								defaultInterpolatedStringHandler.AppendFormatted<int>(plotInfo.FlowId);
								defaultInterpolatedStringHandler.AppendLiteral(",");
								defaultInterpolatedStringHandler.AppendFormatted<int?>(plotInfo.StateId);
								string item = defaultInterpolatedStringHandler.ToStringAndClear();
								FlowController instance2 = FlowController.Instance;
								string text = "[PlotTips]  没有头像路径，检查对话人配置";
								<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", talkItem.WhoId);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("flow", item);
								instance2.LogError(text, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
							}
						}
					}
				}
			}
			if (plotInfo.UiParam != null)
			{
				plotInfo.UiParam.TipsTalkTexturePaths = dictionary;
			}
		}

		// Token: 0x06029419 RID: 168985 RVA: 0x00B974D0 File Offset: 0x00B956D0
		public void Clear()
		{
			this.FlowListName = null;
			this.StateId = null;
			this.StateActions = null;
			this.KeepMusic = false;
			this.FlowId = 0;
			this.Context = null;
			this.IsServerNotify = false;
			this.FlowIncId = 0L;
			this.IsBackground = false;
			this.IsBreakdown = false;
			this.IsServerEnd = false;
			this.IsAsync = false;
			this.UiParam = null;
			this.CanBeAbandoned = false;
			this.FadeBegin = null;
			this.Pos = null;
			this.Seamless = false;
			this.PreloadSequenceUiData.Clear();
			this.PromptStyle = null;
			this.BlockAudio = null;
			this.FormatIdInner = null;
			this.Callback = null;
			this.IsTeleportTransition = false;
			this.ProgramSpecialProcess = null;
		}

		// Token: 0x0602941A RID: 168986 RVA: 0x00B9759C File Offset: 0x00B9579C
		[NullableContext(1)]
		public static PlotInfo Create()
		{
			PlotInfo plotInfo = PlotInfo.Pool.Get();
			if (plotInfo == null)
			{
				plotInfo = PlotInfo.Pool.Create();
			}
			return plotInfo;
		}

		// Token: 0x0602941B RID: 168987 RVA: 0x00B975C3 File Offset: 0x00B957C3
		public void Recycle()
		{
			this.Clear();
			PlotInfo.Pool.Put(this);
		}

		// Token: 0x17005378 RID: 21368
		// (get) Token: 0x0602941C RID: 168988 RVA: 0x00B975D8 File Offset: 0x00B957D8
		[Nullable(1)]
		public string FormatId
		{
			[NullableContext(1)]
			get
			{
				if (this.FormatIdInner == null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
					defaultInterpolatedStringHandler.AppendFormatted(this.FlowListName);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<int>(this.FlowId);
					defaultInterpolatedStringHandler.AppendLiteral(",");
					defaultInterpolatedStringHandler.AppendFormatted<int?>(this.StateId);
					this.FormatIdInner = defaultInterpolatedStringHandler.ToStringAndClear();
				}
				return this.FormatIdInner;
			}
		}

		// Token: 0x0602941D RID: 168989 RVA: 0x00B97648 File Offset: 0x00B95848
		public static void CreateStaticDefaultValue()
		{
			PlotInfo._pool = new Pool<PlotInfo>(20, () => new PlotInfo(), null);
		}

		// Token: 0x0602941E RID: 168990 RVA: 0x00B97676 File Offset: 0x00B95876
		public static void ResetStaticDefaultValue()
		{
			PlotInfo._pool = null;
		}

		// Token: 0x0401672E RID: 91950
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Pool<PlotInfo> _pool;

		// Token: 0x0401672F RID: 91951
		public string FlowListName;

		// Token: 0x04016730 RID: 91952
		public int FlowId;

		// Token: 0x04016731 RID: 91953
		public int? StateId;

		// Token: 0x04016732 RID: 91954
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> StateActions;

		// Token: 0x04016733 RID: 91955
		public bool KeepMusic;

		// Token: 0x04016734 RID: 91956
		public GeneralContext Context;

		// Token: 0x04016735 RID: 91957
		public bool IsServerNotify;

		// Token: 0x04016736 RID: 91958
		public long FlowIncId;

		// Token: 0x04016737 RID: 91959
		public bool IsBackground;

		// Token: 0x04016738 RID: 91960
		public bool IsBreakdown;

		// Token: 0x04016739 RID: 91961
		public bool IsServerEnd;

		// Token: 0x0401673A RID: 91962
		public bool IsAsync;

		// Token: 0x0401673B RID: 91963
		public EPlotLevel PlotLevel;

		// Token: 0x0401673C RID: 91964
		public bool IsWaitAnim;

		// Token: 0x0401673D RID: 91965
		public UiParam UiParam;

		// Token: 0x0401673E RID: 91966
		public bool CanBeAbandoned;

		// Token: 0x0401673F RID: 91967
		public EFadeInScreenShowType? FadeBegin;

		// Token: 0x04016740 RID: 91968
		public global::Vector Pos;

		// Token: 0x04016741 RID: 91969
		public bool KeepMainRolePose;

		// Token: 0x04016742 RID: 91970
		public bool CheckPreload;

		// Token: 0x04016743 RID: 91971
		public bool Seamless;

		// Token: 0x04016744 RID: 91972
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> PreloadSequenceUiData;

		// Token: 0x04016745 RID: 91973
		public EPromptStyle? PromptStyle;

		// Token: 0x04016746 RID: 91974
		public string BlockAudio;

		// Token: 0x04016747 RID: 91975
		public Action Callback;

		// Token: 0x04016748 RID: 91976
		public bool IsTeleportTransition;

		// Token: 0x04016749 RID: 91977
		public IStateProgramSpecialProcessChangeTeamOptimization ProgramSpecialProcess;

		// Token: 0x0401674A RID: 91978
		private string FormatIdInner;
	}
}
