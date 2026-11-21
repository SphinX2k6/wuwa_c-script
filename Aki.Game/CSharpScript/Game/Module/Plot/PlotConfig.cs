using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FC5 RID: 16325
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotConfig
	{
		// Token: 0x06029489 RID: 169097 RVA: 0x00B98B88 File Offset: 0x00B96D88
		public void SetMode(SetPlotMode plotMode, bool isInInteraction = false)
		{
			this.SkipHiddenBlackScreenAtEnd = plotMode.DisableAutoFadeOut.GetValueOrDefault();
			if (this.IsGmPlayPlotOnce)
			{
				this.IsGmPlayPlotOnce = false;
				this.SkipHiddenBlackScreenAtEnd = false;
			}
			if (!string.IsNullOrEmpty(plotMode.Mode))
			{
				EPlotMode eplotMode = EPlotModeExtensions.FromString(plotMode.Mode);
				if (eplotMode != EPlotMode.ControlEntity)
				{
					this.EntityControlOptions = null;
				}
				switch (eplotMode)
				{
				case EPlotMode.LevelA:
					this.HandleLevelA(plotMode);
					break;
				case EPlotMode.LevelB:
					this.HandleLevelB(plotMode);
					break;
				case EPlotMode.LevelC:
				case EPlotMode.Avg:
					this.HandleLevelC(plotMode, isInInteraction);
					break;
				case EPlotMode.LevelD:
					this.HandleLevelD(plotMode);
					break;
				case EPlotMode.Prompt:
					this.HandleLevelE(plotMode);
					break;
				case EPlotMode.ControlEntity:
					this.HandleLevelControlEntity(plotMode);
					break;
				}
			}
			this.SetPlotViewName(plotMode);
			if (plotMode.SubtitleStyle != null)
			{
				if (plotMode.SubtitleStyle.Type == ESubtitleStyle.LevelA)
				{
					this.SubtitleLevel = new EPlotLevel?(EPlotLevel.LevelA);
				}
				else if (plotMode.SubtitleStyle.Type == ESubtitleStyle.NewLevelB)
				{
					this.SubtitleLevel = this.PlotLevel;
				}
			}
			else
			{
				this.SubtitleLevel = this.PlotLevel;
			}
			string key = (plotMode.MainCharacterSkin != null) ? plotMode.MainCharacterSkin.ToString() : "Default";
			int playerSkinId;
			if (PlotConfig.SkinMap.TryGetValue(key, out playerSkinId))
			{
				this.PlayerSkinId = playerSkinId;
			}
			else
			{
				this.PlayerSkinId = PlotConfig.SkinMap["Default"];
			}
			this.OverrideAudioLevel = plotMode.OverrideAudioLevel;
			this.PlotModeUiStyle = plotMode.UiStyle;
			this.AudioConfig = plotMode.AudioConfig;
			if (string.IsNullOrEmpty(plotMode.Mode) && this.PlotLevel.GetValueOrDefault() == EPlotLevel.ControlEntity && plotMode.EntityControlConfig != null)
			{
				this.ApplyEntityControlOptions(plotMode);
			}
		}

		// Token: 0x0602948A RID: 169098 RVA: 0x00B98D40 File Offset: 0x00B96F40
		public void ResetForPlotLifecycle()
		{
			this.DisableInput = false;
			this.CanSkip = false;
			this.CanInteractive = false;
			this.CanPause = false;
			this.CameraMode = null;
			this.EntityControlOptions = null;
			this.AutoPlayState = EAutoPlayState.Manual;
			this.PlotLevel = null;
			this.SubtitleLevel = null;
			this.PlotViewName = null;
			this.ShouldSwitchMainRole = false;
			this.PauseTime = false;
			this.SkipTalkWhenFighting = false;
			this.SkipHiddenBlackScreenAtEnd = false;
			this.IsPreStreaming = false;
			this.ActivityGamePlayPlotConfig = null;
			this.PlayerSkinId = -1;
			this.OverrideAudioLevel = null;
			this.PlotModeUiStyle = null;
			this.AudioConfig = null;
		}

		// Token: 0x0602948B RID: 169099 RVA: 0x00B98DF8 File Offset: 0x00B96FF8
		private void HandleLevelA(SetPlotMode plotMode)
		{
			this.CameraMode = new EPlotCameraMode?(EPlotCameraMode.Plot);
			this.CanInteractive = false;
			bool isTeleportTransitionSeq = PlotModel.Instance.IsTeleportTransitionSeq;
			this.CanSkip = ((!plotMode.NoSkip.GetValueOrDefault() && !isTeleportTransitionSeq) || this.CanSkipDebug);
			this.DisableInput = true;
			this.CanPause = false;
			this.PlotLevel = new EPlotLevel?(EPlotLevel.LevelA);
			this.AutoPlayState = EAutoPlayState.Auto;
			this.ShouldSwitchMainRole = false;
			this.PauseTime = true;
			this.SkipTalkWhenFighting = false;
			PlotController.Instance.TogglePlotProtect(true);
			PlotController.Instance.EnableViewControl(false);
		}

		// Token: 0x0602948C RID: 169100 RVA: 0x00B98E94 File Offset: 0x00B97094
		private void HandleLevelB(SetPlotMode plotMode)
		{
			this.CameraMode = new EPlotCameraMode?(EPlotCameraMode.Plot);
			this.CanInteractive = true;
			bool isTeleportTransitionSeq = PlotModel.Instance.IsTeleportTransitionSeq;
			this.CanSkip = ((!plotMode.NoSkip.GetValueOrDefault() && !isTeleportTransitionSeq) || this.CanSkipDebug);
			this.DisableInput = true;
			this.CanPause = true;
			this.AutoPlayState = this.AutoPlayStateCache;
			this.PlotLevel = new EPlotLevel?(EPlotLevel.LevelB);
			this.ShouldSwitchMainRole = false;
			this.PauseTime = true;
			this.SkipTalkWhenFighting = false;
			PlotController.Instance.TogglePlotProtect(true);
			PlotController.Instance.EnableViewControl(false);
		}

		// Token: 0x0602948D RID: 169101 RVA: 0x00B98F34 File Offset: 0x00B97134
		private void HandleLevelC(SetPlotMode plotMode, bool isInInteraction = false)
		{
			if (plotMode.UseFlowCamera == null)
			{
				this.CameraMode = new EPlotCameraMode?(EPlotCameraMode.MainPlot);
			}
			else
			{
				this.CameraMode = new EPlotCameraMode?(plotMode.UseFlowCamera.Value ? EPlotCameraMode.MainPlot : EPlotCameraMode.Main);
			}
			this.CanInteractive = true;
			this.CanSkip = (!plotMode.NoSkip.GetValueOrDefault() || this.CanSkipDebug);
			this.DisableInput = true;
			this.CanPause = !isInInteraction;
			this.AutoPlayState = this.AutoPlayStateCache;
			this.PlotLevel = new EPlotLevel?(EPlotLevel.LevelC);
			this.ShouldSwitchMainRole = plotMode.IsSwitchMainRole.GetValueOrDefault();
			this.PauseTime = !isInInteraction;
			this.SkipTalkWhenFighting = false;
			this.ActivityGamePlayPlotConfig = plotMode.SystemGameDialogConfigId;
			PlotController.Instance.TogglePlotProtect(true);
			PlotController.Instance.EnableViewControl(FlowController.Instance.CheckViewControlBeginForC());
			PlotController.Instance.HideSummonedEntity();
		}

		// Token: 0x0602948E RID: 169102 RVA: 0x00B99028 File Offset: 0x00B97228
		private void HandleLevelD(SetPlotMode plotMode)
		{
			this.CameraMode = new EPlotCameraMode?(EPlotCameraMode.Main);
			this.CanInteractive = false;
			this.CanSkip = false;
			this.DisableInput = false;
			this.CanPause = false;
			this.AutoPlayState = EAutoPlayState.Auto;
			this.ShouldSwitchMainRole = false;
			this.PlotLevel = new EPlotLevel?(EPlotLevel.LevelD);
			this.PauseTime = false;
			this.SkipTalkWhenFighting = plotMode.Interruptible.GetValueOrDefault(false);
			this.SkipHiddenBlackScreenAtEnd = true;
			PlotController.Instance.EnableViewControl(false);
		}

		// Token: 0x0602948F RID: 169103 RVA: 0x00B990A8 File Offset: 0x00B972A8
		private void HandleLevelE(SetPlotMode plotMode)
		{
			this.CameraMode = new EPlotCameraMode?(EPlotCameraMode.Main);
			this.CanInteractive = false;
			this.CanSkip = false;
			this.DisableInput = false;
			this.CanPause = false;
			this.AutoPlayState = this.AutoPlayStateCache;
			this.PlotLevel = new EPlotLevel?(EPlotLevel.LevelE);
			this.PauseTime = false;
			this.SkipTalkWhenFighting = plotMode.Interruptible.GetValueOrDefault();
			this.SkipHiddenBlackScreenAtEnd = true;
			PlotController.Instance.EnableViewControl(false);
		}

		// Token: 0x06029490 RID: 169104 RVA: 0x00B99124 File Offset: 0x00B97324
		private void HandleLevelControlEntity(SetPlotMode plotMode)
		{
			this.ApplyEntityControlOptions(plotMode);
			this.CanInteractive = false;
			this.CanSkip = false;
			this.CanPause = false;
			this.AutoPlayState = EAutoPlayState.Auto;
			this.ShouldSwitchMainRole = false;
			this.PlotLevel = new EPlotLevel?(EPlotLevel.ControlEntity);
			this.PauseTime = false;
			this.SkipTalkWhenFighting = false;
			PlotController.Instance.EnableViewControl(false);
		}

		// Token: 0x06029491 RID: 169105 RVA: 0x00B99180 File Offset: 0x00B97380
		private void ApplyEntityControlOptions(SetPlotMode plotMode)
		{
			EntityControlRuntimeOptions entityControlRuntimeOptions = new EntityControlRuntimeOptions();
			entityControlRuntimeOptions.IsEnabled = true;
			IEntityControlConfig entityControlConfig = plotMode.EntityControlConfig;
			entityControlRuntimeOptions.CameraMode = ((entityControlConfig != null) ? entityControlConfig.CameraMode : null);
			IEntityControlConfig entityControlConfig2 = plotMode.EntityControlConfig;
			entityControlRuntimeOptions.HandlePlayer = ((entityControlConfig2 != null) ? entityControlConfig2.IsControlPlayer : null).GetValueOrDefault();
			IEntityControlConfig entityControlConfig3 = plotMode.EntityControlConfig;
			entityControlRuntimeOptions.HideSkipButton = ((entityControlConfig3 != null) ? entityControlConfig3.HideSkipButton : null).GetValueOrDefault();
			this.EntityControlOptions = entityControlRuntimeOptions;
			this.CameraMode = new EPlotCameraMode?(this.EntityControlOptions.UseSequenceCamera ? EPlotCameraMode.Plot : EPlotCameraMode.Main);
			this.DisableInput = this.EntityControlOptions.HandlePlayer;
		}

		// Token: 0x06029492 RID: 169106 RVA: 0x00B9923C File Offset: 0x00B9743C
		public EUiViewName? GetPlotViewNameByMode(SetPlotMode plotMode)
		{
			if (plotMode.Mp4Mode.GetValueOrDefault())
			{
				return null;
			}
			if (!string.IsNullOrEmpty(plotMode.Mode))
			{
				switch (EPlotModeExtensions.FromString(plotMode.Mode))
				{
				case EPlotMode.LevelA:
				case EPlotMode.LevelB:
					return new EUiViewName?(EUiViewName.PlotSubtitleView);
				case EPlotMode.LevelC:
				{
					int? systemGameDialogConfigId = plotMode.SystemGameDialogConfigId;
					if (systemGameDialogConfigId != null && systemGameDialogConfigId.GetValueOrDefault() != 0)
					{
						return new EUiViewName?(EUiViewName.ActivityGamePlayPlotView);
					}
					return new EUiViewName?(EUiViewName.PlotView);
				}
				case EPlotMode.LevelD:
				{
					IPlotModeUiStyleLevelD uiStyle = plotMode.UiStyle;
					if (uiStyle != null && uiStyle.Type == EPlotModeUiStyleType.LevelD)
					{
						IUiStyleBaseOfLevelD uiStyle2 = plotMode.UiStyle.UiStyle;
						if (uiStyle2 != null && uiStyle2.Type == EUiStyleTypeOfLevelD.GiantSubtitle)
						{
							return new EUiViewName?(EUiViewName.PlotGiantSubtitleView);
						}
					}
					return new EUiViewName?(EUiViewName.PlotViewHUD);
				}
				case EPlotMode.Avg:
					return new EUiViewName?(EUiViewName.PinballPlotView);
				case EPlotMode.ControlEntity:
					return new EUiViewName?(EUiViewName.PlotViewHUD);
				}
				return null;
			}
			return null;
		}

		// Token: 0x06029493 RID: 169107 RVA: 0x00B9935A File Offset: 0x00B9755A
		private void SetPlotViewName(SetPlotMode plotMode)
		{
			this.PlotViewName = this.GetPlotViewNameByMode(plotMode);
		}

		// Token: 0x040167D7 RID: 92119
		public const string AUDIO_STATE_PLOT_LEVEL_GROUP = "plot_level";

		// Token: 0x040167D8 RID: 92120
		public const string AUDIO_STATE_NOT_PLOT = "none";

		// Token: 0x040167D9 RID: 92121
		public const string PLOT_END_AUDIO_EVENT = "plot_controller_end_plot";

		// Token: 0x040167DA RID: 92122
		private const bool CAN_SKIP = true;

		// Token: 0x040167DB RID: 92123
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EPlotLevel, string> AudioStatePlotLevel = new Dictionary<EPlotLevel, string>
		{
			{
				EPlotLevel.LevelA,
				"level_a"
			},
			{
				EPlotLevel.LevelB,
				"level_b"
			},
			{
				EPlotLevel.LevelC,
				"level_c"
			},
			{
				EPlotLevel.LevelD,
				"level_d"
			},
			{
				EPlotLevel.LevelE,
				"level_d"
			},
			{
				EPlotLevel.ControlEntity,
				"level_d"
			}
		};

		// Token: 0x040167DC RID: 92124
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EOverrideAudioLevel, string> AudioStateOverrideAudioLevel = new Dictionary<EOverrideAudioLevel, string>
		{
			{
				EOverrideAudioLevel.LevelA,
				"level_a"
			},
			{
				EOverrideAudioLevel.LevelB,
				"level_b"
			},
			{
				EOverrideAudioLevel.LevelC,
				"level_c"
			},
			{
				EOverrideAudioLevel.LevelD,
				"level_d"
			}
		};

		// Token: 0x040167DD RID: 92125
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<string, int> SkinMap = new Dictionary<string, int>
		{
			{
				"Default",
				1000
			},
			{
				"Uniform",
				2000
			}
		};

		// Token: 0x040167DE RID: 92126
		public bool DisableInput;

		// Token: 0x040167DF RID: 92127
		public bool CanSkip;

		// Token: 0x040167E0 RID: 92128
		public bool CanSkipDebug;

		// Token: 0x040167E1 RID: 92129
		public bool CanInteractive;

		// Token: 0x040167E2 RID: 92130
		public bool CanPause;

		// Token: 0x040167E3 RID: 92131
		public EPlotCameraMode? CameraMode;

		// Token: 0x040167E4 RID: 92132
		[Nullable(2)]
		public EntityControlRuntimeOptions EntityControlOptions;

		// Token: 0x040167E5 RID: 92133
		public EAutoPlayState AutoPlayState;

		// Token: 0x040167E6 RID: 92134
		public EAutoPlayState AutoPlayStateCache;

		// Token: 0x040167E7 RID: 92135
		public EPlotLevel? PlotLevel;

		// Token: 0x040167E8 RID: 92136
		public EPlotLevel? SubtitleLevel;

		// Token: 0x040167E9 RID: 92137
		public EUiViewName? PlotViewName;

		// Token: 0x040167EA RID: 92138
		public bool ShouldSwitchMainRole;

		// Token: 0x040167EB RID: 92139
		public bool PauseTime;

		// Token: 0x040167EC RID: 92140
		public bool SkipTalkWhenFighting;

		// Token: 0x040167ED RID: 92141
		public bool SkipHiddenBlackScreenAtEnd;

		// Token: 0x040167EE RID: 92142
		public bool IsGmPlayPlotOnce;

		// Token: 0x040167EF RID: 92143
		public bool IsPreStreaming;

		// Token: 0x040167F0 RID: 92144
		public bool IsSkipConfirmBoxShow = true;

		// Token: 0x040167F1 RID: 92145
		public int? ActivityGamePlayPlotConfig;

		// Token: 0x040167F2 RID: 92146
		public int PlayerSkinId = -1;

		// Token: 0x040167F3 RID: 92147
		public EOverrideAudioLevel? OverrideAudioLevel;

		// Token: 0x040167F4 RID: 92148
		[Nullable(2)]
		public IPlotModeUiStyleLevelD PlotModeUiStyle;

		// Token: 0x040167F5 RID: 92149
		[Nullable(2)]
		public IPlotAudioConfig AudioConfig;
	}
}
