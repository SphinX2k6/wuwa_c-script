using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FFB RID: 20475
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotConfig
	{
		// Token: 0x060345FE RID: 214526 RVA: 0x00C4EB28 File Offset: 0x00C4CD28
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
			if (string.IsNullOrEmpty(plotMode.Mode) && this.PlotLevel.GetValueOrDefault() == EPlotLevel.ControlEntity && plotMode.EntityControlConfig != null)
			{
				this.ApplyEntityControlOptions(plotMode);
			}
		}

		// Token: 0x060345FF RID: 214527 RVA: 0x00C4ECD4 File Offset: 0x00C4CED4
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
		}

		// Token: 0x06034600 RID: 214528 RVA: 0x00C4ED84 File Offset: 0x00C4CF84
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

		// Token: 0x06034601 RID: 214529 RVA: 0x00C4EE20 File Offset: 0x00C4D020
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

		// Token: 0x06034602 RID: 214530 RVA: 0x00C4EEC0 File Offset: 0x00C4D0C0
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

		// Token: 0x06034603 RID: 214531 RVA: 0x00C4EFB4 File Offset: 0x00C4D1B4
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

		// Token: 0x06034604 RID: 214532 RVA: 0x00C4F034 File Offset: 0x00C4D234
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

		// Token: 0x06034605 RID: 214533 RVA: 0x00C4F0B0 File Offset: 0x00C4D2B0
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

		// Token: 0x06034606 RID: 214534 RVA: 0x00C4F10C File Offset: 0x00C4D30C
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

		// Token: 0x06034607 RID: 214535 RVA: 0x00C4F1C8 File Offset: 0x00C4D3C8
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

		// Token: 0x06034608 RID: 214536 RVA: 0x00C4F2E6 File Offset: 0x00C4D4E6
		private void SetPlotViewName(SetPlotMode plotMode)
		{
			this.PlotViewName = this.GetPlotViewNameByMode(plotMode);
		}

		// Token: 0x0401BDFB RID: 114171
		public const string AUDIO_STATE_PLOT_LEVEL_GROUP = "plot_level";

		// Token: 0x0401BDFC RID: 114172
		public const string AUDIO_STATE_NOT_PLOT = "none";

		// Token: 0x0401BDFD RID: 114173
		public const string PLOT_END_AUDIO_EVENT = "plot_controller_end_plot";

		// Token: 0x0401BDFE RID: 114174
		private const bool CAN_SKIP = true;

		// Token: 0x0401BDFF RID: 114175
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

		// Token: 0x0401BE00 RID: 114176
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

		// Token: 0x0401BE01 RID: 114177
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

		// Token: 0x0401BE02 RID: 114178
		public bool DisableInput;

		// Token: 0x0401BE03 RID: 114179
		public bool CanSkip;

		// Token: 0x0401BE04 RID: 114180
		public bool CanSkipDebug;

		// Token: 0x0401BE05 RID: 114181
		public bool CanInteractive;

		// Token: 0x0401BE06 RID: 114182
		public bool CanPause;

		// Token: 0x0401BE07 RID: 114183
		public EPlotCameraMode? CameraMode;

		// Token: 0x0401BE08 RID: 114184
		[Nullable(2)]
		public EntityControlRuntimeOptions EntityControlOptions;

		// Token: 0x0401BE09 RID: 114185
		public EAutoPlayState AutoPlayState;

		// Token: 0x0401BE0A RID: 114186
		public EAutoPlayState AutoPlayStateCache;

		// Token: 0x0401BE0B RID: 114187
		public EPlotLevel? PlotLevel;

		// Token: 0x0401BE0C RID: 114188
		public EPlotLevel? SubtitleLevel;

		// Token: 0x0401BE0D RID: 114189
		public EUiViewName? PlotViewName;

		// Token: 0x0401BE0E RID: 114190
		public bool ShouldSwitchMainRole;

		// Token: 0x0401BE0F RID: 114191
		public bool PauseTime;

		// Token: 0x0401BE10 RID: 114192
		public bool SkipTalkWhenFighting;

		// Token: 0x0401BE11 RID: 114193
		public bool SkipHiddenBlackScreenAtEnd;

		// Token: 0x0401BE12 RID: 114194
		public bool IsGmPlayPlotOnce;

		// Token: 0x0401BE13 RID: 114195
		public bool IsPreStreaming;

		// Token: 0x0401BE14 RID: 114196
		public bool IsSkipConfirmBoxShow = true;

		// Token: 0x0401BE15 RID: 114197
		public int? ActivityGamePlayPlotConfig;

		// Token: 0x0401BE16 RID: 114198
		public int PlayerSkinId = -1;

		// Token: 0x0401BE17 RID: 114199
		public EOverrideAudioLevel? OverrideAudioLevel;

		// Token: 0x0401BE18 RID: 114200
		[Nullable(2)]
		public IPlotModeUiStyleLevelD PlotModeUiStyle;
	}
}
