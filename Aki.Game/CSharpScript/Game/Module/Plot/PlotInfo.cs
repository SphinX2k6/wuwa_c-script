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
	// Token: 0x02004FE2 RID: 20450
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotInfo : IStaticVariableResetter
	{
		// Token: 0x06034588 RID: 214408 RVA: 0x00C4CD41 File Offset: 0x00C4AF41
		static PlotInfo()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlotInfo.CreateStaticDefaultValue), new Action(PlotInfo.ResetStaticDefaultValue));
		}

		// Token: 0x17007FC3 RID: 32707
		// (get) Token: 0x06034589 RID: 214409 RVA: 0x00C4CD60 File Offset: 0x00C4AF60
		[Nullable(1)]
		private static Pool<PlotInfo> Pool
		{
			[NullableContext(1)]
			get
			{
				return PlotInfo._pool;
			}
		}

		// Token: 0x0603458A RID: 214410 RVA: 0x00C4CD68 File Offset: 0x00C4AF68
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

		// Token: 0x0603458B RID: 214411 RVA: 0x00C4CE28 File Offset: 0x00C4B028
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

		// Token: 0x0603458C RID: 214412 RVA: 0x00C4CEE0 File Offset: 0x00C4B0E0
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

		// Token: 0x0603458D RID: 214413 RVA: 0x00C4D180 File Offset: 0x00C4B380
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

		// Token: 0x0603458E RID: 214414 RVA: 0x00C4D1DF File Offset: 0x00C4B3DF
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

		// Token: 0x0603458F RID: 214415 RVA: 0x00C4D210 File Offset: 0x00C4B410
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

		// Token: 0x06034590 RID: 214416 RVA: 0x00C4D488 File Offset: 0x00C4B688
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

		// Token: 0x06034591 RID: 214417 RVA: 0x00C4D554 File Offset: 0x00C4B754
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

		// Token: 0x06034592 RID: 214418 RVA: 0x00C4D57B File Offset: 0x00C4B77B
		public void Recycle()
		{
			this.Clear();
			PlotInfo.Pool.Put(this);
		}

		// Token: 0x17007FC4 RID: 32708
		// (get) Token: 0x06034593 RID: 214419 RVA: 0x00C4D590 File Offset: 0x00C4B790
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

		// Token: 0x06034594 RID: 214420 RVA: 0x00C4D600 File Offset: 0x00C4B800
		public static void CreateStaticDefaultValue()
		{
			PlotInfo._pool = new Pool<PlotInfo>(20, () => new PlotInfo(), null);
		}

		// Token: 0x06034595 RID: 214421 RVA: 0x00C4D62E File Offset: 0x00C4B82E
		public static void ResetStaticDefaultValue()
		{
			PlotInfo._pool = null;
		}

		// Token: 0x0401BD53 RID: 114003
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Pool<PlotInfo> _pool;

		// Token: 0x0401BD54 RID: 114004
		public string FlowListName;

		// Token: 0x0401BD55 RID: 114005
		public int FlowId;

		// Token: 0x0401BD56 RID: 114006
		public int? StateId;

		// Token: 0x0401BD57 RID: 114007
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> StateActions;

		// Token: 0x0401BD58 RID: 114008
		public bool KeepMusic;

		// Token: 0x0401BD59 RID: 114009
		public GeneralContext Context;

		// Token: 0x0401BD5A RID: 114010
		public bool IsServerNotify;

		// Token: 0x0401BD5B RID: 114011
		public long FlowIncId;

		// Token: 0x0401BD5C RID: 114012
		public bool IsBackground;

		// Token: 0x0401BD5D RID: 114013
		public bool IsBreakdown;

		// Token: 0x0401BD5E RID: 114014
		public bool IsServerEnd;

		// Token: 0x0401BD5F RID: 114015
		public bool IsAsync;

		// Token: 0x0401BD60 RID: 114016
		public EPlotLevel PlotLevel;

		// Token: 0x0401BD61 RID: 114017
		public bool IsWaitAnim;

		// Token: 0x0401BD62 RID: 114018
		public UiParam UiParam;

		// Token: 0x0401BD63 RID: 114019
		public bool CanBeAbandoned;

		// Token: 0x0401BD64 RID: 114020
		public EFadeInScreenShowType? FadeBegin;

		// Token: 0x0401BD65 RID: 114021
		public global::Vector Pos;

		// Token: 0x0401BD66 RID: 114022
		public bool KeepMainRolePose;

		// Token: 0x0401BD67 RID: 114023
		public bool CheckPreload;

		// Token: 0x0401BD68 RID: 114024
		public bool Seamless;

		// Token: 0x0401BD69 RID: 114025
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> PreloadSequenceUiData;

		// Token: 0x0401BD6A RID: 114026
		public EPromptStyle? PromptStyle;

		// Token: 0x0401BD6B RID: 114027
		public string BlockAudio;

		// Token: 0x0401BD6C RID: 114028
		public Action Callback;

		// Token: 0x0401BD6D RID: 114029
		public bool IsTeleportTransition;

		// Token: 0x0401BD6E RID: 114030
		public IStateProgramSpecialProcessChangeTeamOptimization ProgramSpecialProcess;

		// Token: 0x0401BD6F RID: 114031
		private string FormatIdInner;
	}
}
