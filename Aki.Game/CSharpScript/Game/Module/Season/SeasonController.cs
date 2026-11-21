using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Core;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02003C2A RID: 15402
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	[TickController(0)]
	public class SeasonController : ControllerBase
	{
		// Token: 0x06027743 RID: 161603 RVA: 0x00B111D4 File Offset: 0x00B0F3D4
		protected override void OnTick(float delta)
		{
			SeasonModel instance = SeasonModel.Instance;
			if (!instance.IsMaterialReady)
			{
				return;
			}
			float num = delta * 0.001f;
			this.AdvanceDriver(instance, (double)num);
			this.WriteSeasonScalar(instance);
			this.WriteSeasonAudioState(instance);
		}

		// Token: 0x06027744 RID: 161604 RVA: 0x00B1120F File Offset: 0x00B0F40F
		protected override bool OnLeaveLevel()
		{
			SeasonModel.Instance.ResetRuntime();
			return true;
		}

		// Token: 0x06027745 RID: 161605 RVA: 0x00B1121C File Offset: 0x00B0F41C
		public void ApplyConfig(int volumeId, IClientSetSeasonStateConfig config, [Nullable(2)] TSeasonSwitchCallback onComplete = null)
		{
			SeasonModel instance = SeasonModel.Instance;
			EClientSetSeasonStateType type = config.Type;
			if (type != EClientSetSeasonStateType.SwitchSeason)
			{
				if (type == EClientSetSeasonStateType.LoopSeasonChange)
				{
					ILoopSeasonChange loopSeasonChange = (ILoopSeasonChange)config;
					if (!loopSeasonChange.EnableLoop)
					{
						this.DeactivateAreaWithEvents(instance, volumeId);
						this.StopLoop(instance);
					}
					else
					{
						this.ActivateAreaWithEvents(instance, volumeId);
						this.StartOrReplaceLoop(instance, loopSeasonChange);
					}
					if (onComplete != null)
					{
						onComplete(true);
						return;
					}
				}
				else if (onComplete != null)
				{
					onComplete(true);
				}
				return;
			}
			this.ActivateAreaWithEvents(instance, volumeId);
			this.PushSwitchJob(instance, (ISwitchSeason)config, onComplete);
		}

		// Token: 0x06027746 RID: 161606 RVA: 0x00B11299 File Offset: 0x00B0F499
		public void RegisterVolume(TsTriggerVolume volume)
		{
			SeasonModel.Instance.RegisterVolume(volume);
		}

		// Token: 0x06027747 RID: 161607 RVA: 0x00B112A6 File Offset: 0x00B0F4A6
		public void UnregisterVolume(TsTriggerVolume volume)
		{
			SeasonModel.Instance.UnregisterVolume(volume);
		}

		// Token: 0x06027748 RID: 161608 RVA: 0x00B112B4 File Offset: 0x00B0F4B4
		public void HandleVolumeEnter(TsTriggerVolume volume)
		{
			SeasonModel instance = SeasonModel.Instance;
			int seasonAreaId = volume.SeasonAreaId;
			instance.MarkPlayerInside(seasonAreaId);
			if (instance.IsAreaActive(seasonAreaId))
			{
				EventSystem.Instance.Emit<int>(EEventName.OnSeasonAreaEffectBegin, seasonAreaId);
			}
		}

		// Token: 0x06027749 RID: 161609 RVA: 0x00B112F0 File Offset: 0x00B0F4F0
		public void HandleVolumeExit(TsTriggerVolume volume)
		{
			SeasonModel instance = SeasonModel.Instance;
			int seasonAreaId = volume.SeasonAreaId;
			bool flag = instance.IsPlayerInside(seasonAreaId);
			instance.MarkPlayerOutside(seasonAreaId);
			if (flag && instance.IsAreaActive(seasonAreaId))
			{
				EventSystem.Instance.Emit<int>(EEventName.OnSeasonAreaEffectEnd, seasonAreaId);
			}
		}

		// Token: 0x0602774A RID: 161610 RVA: 0x00B11334 File Offset: 0x00B0F534
		public ESeason? GetSeasonByAreaId(int areaId)
		{
			SeasonModel instance = SeasonModel.Instance;
			if (!instance.IsAreaActive(areaId))
			{
				return null;
			}
			return new ESeason?(this.LocateLoopPosition(instance.CurrentValue).Season);
		}

		// Token: 0x0602774B RID: 161611 RVA: 0x00B11370 File Offset: 0x00B0F570
		private void StopLoop(SeasonModel model)
		{
			model.LoopConfig = null;
			model.LoopState = null;
			if (model.DriverPhase == ESeasonDriverPhase.Looping)
			{
				this.SetDriverPhase(model, ESeasonDriverPhase.Idle);
			}
		}

		// Token: 0x0602774C RID: 161612 RVA: 0x00B11391 File Offset: 0x00B0F591
		private void StartOrReplaceLoop(SeasonModel model, ILoopSeasonChange config)
		{
			model.LoopConfig = config;
			if (model.DriverPhase == ESeasonDriverPhase.Switching)
			{
				return;
			}
			this.EnterLoopFromCurrentValue(model);
		}

		// Token: 0x0602774D RID: 161613 RVA: 0x00B113AC File Offset: 0x00B0F5AC
		private void EnterLoopFromCurrentValue(SeasonModel model)
		{
			if (model.LoopConfig == null)
			{
				this.SetDriverPhase(model, ESeasonDriverPhase.Idle);
				return;
			}
			ILocatedLoopPosition locatedLoopPosition = this.LocateLoopPosition(model.CurrentValue);
			double phaseElapsed = this.ComputePhaseElapsed(model.CurrentValue, locatedLoopPosition, model);
			model.LoopState = new SeasonLoopState
			{
				CurrentSeason = locatedLoopPosition.Season,
				Phase = locatedLoopPosition.Phase,
				PhaseElapsed = phaseElapsed
			};
			this.SetDriverPhase(model, ESeasonDriverPhase.Looping);
		}

		// Token: 0x0602774E RID: 161614 RVA: 0x00B11418 File Offset: 0x00B0F618
		private void ActivateAreaWithEvents(SeasonModel model, int areaId)
		{
			if (areaId == 0 || model.IsAreaActive(areaId))
			{
				return;
			}
			model.ActivateArea(areaId);
			if (model.IsPlayerInside(areaId))
			{
				EventSystem.Instance.Emit<int>(EEventName.OnSeasonAreaEffectBegin, areaId);
			}
		}

		// Token: 0x0602774F RID: 161615 RVA: 0x00B11448 File Offset: 0x00B0F648
		private void DeactivateAreaWithEvents(SeasonModel model, int areaId)
		{
			if (areaId == 0 || !model.IsAreaActive(areaId))
			{
				return;
			}
			if (model.IsPlayerInside(areaId))
			{
				EventSystem.Instance.Emit<int>(EEventName.OnSeasonAreaEffectEnd, areaId);
			}
			model.DeactivateArea(areaId);
		}

		// Token: 0x06027750 RID: 161616 RVA: 0x00B11478 File Offset: 0x00B0F678
		private void PushSwitchJob(SeasonModel model, ISwitchSeason job, [Nullable(2)] TSeasonSwitchCallback onComplete = null)
		{
			double seasonTimelineValue = SeasonDefine.GetSeasonTimelineValue(job.Season);
			double forwardDistance = this.ForwardDistance(model.CurrentValue, seasonTimelineValue);
			model.PushSwitchJob(job, seasonTimelineValue, forwardDistance, onComplete);
			if (model.DriverPhase != ESeasonDriverPhase.Switching)
			{
				this.SetDriverPhase(model, ESeasonDriverPhase.Switching);
			}
		}

		// Token: 0x06027751 RID: 161617 RVA: 0x00B114BC File Offset: 0x00B0F6BC
		private void InvokeJobComplete(ISeasonSwitchJob job, bool success)
		{
			TSeasonSwitchCallback onComplete = job.OnComplete;
			if (onComplete == null)
			{
				return;
			}
			job.OnComplete = null;
			try
			{
				onComplete(success);
			}
			catch (Exception ex)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Season;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "切换回调抛异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06027752 RID: 161618 RVA: 0x00B11528 File Offset: 0x00B0F728
		private void SetDriverPhase(SeasonModel model, ESeasonDriverPhase next)
		{
			if (model.DriverPhase == next)
			{
				return;
			}
			model.DriverPhase = next;
		}

		// Token: 0x06027753 RID: 161619 RVA: 0x00B1153C File Offset: 0x00B0F73C
		private void AdvanceDriver(SeasonModel model, double delta)
		{
			switch (model.DriverPhase)
			{
			case ESeasonDriverPhase.Idle:
				break;
			case ESeasonDriverPhase.Looping:
				this.AdvanceLooping(model, delta);
				break;
			case ESeasonDriverPhase.Switching:
				this.AdvanceSwitching(model, delta);
				return;
			default:
				return;
			}
		}

		// Token: 0x06027754 RID: 161620 RVA: 0x00B11574 File Offset: 0x00B0F774
		private void AdvanceSwitching(SeasonModel model, double delta)
		{
			ISeasonSwitchJob seasonSwitchJob = model.PeekSwitchHead();
			if (seasonSwitchJob == null)
			{
				this.LeaveSwitching(model);
				return;
			}
			double num = seasonSwitchJob.Speed * delta;
			if (num < seasonSwitchJob.RemainDistance)
			{
				model.CurrentValue = this.WrapValue(model.CurrentValue + num);
				seasonSwitchJob.RemainDistance -= num;
				return;
			}
			model.CurrentValue = seasonSwitchJob.TargetValue;
			ISeasonSwitchJob seasonSwitchJob2 = model.PopSwitchHead();
			if (seasonSwitchJob2 != null)
			{
				this.InvokeJobComplete(seasonSwitchJob2, true);
			}
			if (model.PeekSwitchHead() == null)
			{
				this.LeaveSwitching(model);
			}
		}

		// Token: 0x06027755 RID: 161621 RVA: 0x00B115F5 File Offset: 0x00B0F7F5
		private void LeaveSwitching(SeasonModel model)
		{
			if (model.LoopConfig != null)
			{
				this.EnterLoopFromCurrentValue(model);
				return;
			}
			this.SetDriverPhase(model, ESeasonDriverPhase.Idle);
		}

		// Token: 0x06027756 RID: 161622 RVA: 0x00B11610 File Offset: 0x00B0F810
		private void AdvanceLooping(SeasonModel model, double delta)
		{
			bool loopConfig = model.LoopConfig != null;
			ISeasonLoopState loopState = model.LoopState;
			if (!loopConfig || loopState == null)
			{
				this.SetDriverPhase(model, ESeasonDriverPhase.Idle);
				return;
			}
			double phaseDuration = this.GetPhaseDuration(model, loopState.CurrentSeason, loopState.Phase);
			if (phaseDuration <= 0.0)
			{
				this.CompletePhase(model, loopState);
				return;
			}
			double num = phaseDuration - loopState.PhaseElapsed;
			if (delta < num)
			{
				loopState.PhaseElapsed += delta;
				model.CurrentValue = this.ComputePhaseValue(loopState, phaseDuration);
				return;
			}
			this.CompletePhase(model, loopState);
		}

		// Token: 0x06027757 RID: 161623 RVA: 0x00B11694 File Offset: 0x00B0F894
		private double GetPhaseDuration(SeasonModel model, ESeason season, ESeasonLoopPhase phase)
		{
			ISeasonLoopConfig seasonConfig = this.GetSeasonConfig(model, season);
			return (double)((phase == ESeasonLoopPhase.Hold) ? seasonConfig.HoldTime : seasonConfig.SwitchTime);
		}

		// Token: 0x06027758 RID: 161624 RVA: 0x00B116BC File Offset: 0x00B0F8BC
		private double ComputePhaseValue(ISeasonLoopState state, double duration)
		{
			if (state.Phase == ESeasonLoopPhase.Hold)
			{
				return SeasonDefine.GetSeasonTimelineValue(state.CurrentSeason);
			}
			return this.LerpForward(state.CurrentSeason, SeasonDefine.GetNextSeasonInLoop(state.CurrentSeason), state.PhaseElapsed / duration);
		}

		// Token: 0x06027759 RID: 161625 RVA: 0x00B116F4 File Offset: 0x00B0F8F4
		private void CompletePhase(SeasonModel model, ISeasonLoopState state)
		{
			if (state.Phase == ESeasonLoopPhase.Hold)
			{
				state.Phase = ESeasonLoopPhase.Transition;
			}
			else
			{
				state.CurrentSeason = SeasonDefine.GetNextSeasonInLoop(state.CurrentSeason);
				state.Phase = ESeasonLoopPhase.Hold;
			}
			state.PhaseElapsed = 0.0;
			model.CurrentValue = SeasonDefine.GetSeasonTimelineValue(state.CurrentSeason);
		}

		// Token: 0x0602775A RID: 161626 RVA: 0x00B1174C File Offset: 0x00B0F94C
		private ILocatedLoopPosition LocateLoopPosition(double value)
		{
			double num = this.WrapValue(value);
			int num2 = (int)Math.Floor(num * 4.0 + 0.0004) % 4;
			double num3 = (double)num2 / 4.0;
			double num4 = Math.Abs(num - num3);
			ESeasonLoopPhase phase = (num4 < 0.0001 || num4 > 0.9999) ? ESeasonLoopPhase.Hold : ESeasonLoopPhase.Transition;
			return new LocatedLoopPosition
			{
				Season = SeasonController.SeasonByQuarter[num2],
				Phase = phase
			};
		}

		// Token: 0x0602775B RID: 161627 RVA: 0x00B117CC File Offset: 0x00B0F9CC
		private double ComputePhaseElapsed(double value, ILocatedLoopPosition located, SeasonModel model)
		{
			if (located.Phase == ESeasonLoopPhase.Hold)
			{
				return 0.0;
			}
			float switchTime = this.GetSeasonConfig(model, located.Season).SwitchTime;
			if (switchTime <= 0f)
			{
				return 0.0;
			}
			double seasonTimelineValue = SeasonDefine.GetSeasonTimelineValue(located.Season);
			double num = SeasonDefine.GetSeasonTimelineValue(SeasonDefine.GetNextSeasonInLoop(located.Season));
			if (num <= seasonTimelineValue)
			{
				num += 1.0;
			}
			return (((value < seasonTimelineValue) ? (value + 1.0) : value) - seasonTimelineValue) / (num - seasonTimelineValue) * (double)switchTime;
		}

		// Token: 0x0602775C RID: 161628 RVA: 0x00B11858 File Offset: 0x00B0FA58
		private double LerpForward(ESeason from, ESeason to, double t)
		{
			double seasonTimelineValue = SeasonDefine.GetSeasonTimelineValue(from);
			double num = SeasonDefine.GetSeasonTimelineValue(to);
			if (num <= seasonTimelineValue)
			{
				num += 1.0;
			}
			return this.WrapValue(seasonTimelineValue + (num - seasonTimelineValue) * t);
		}

		// Token: 0x0602775D RID: 161629 RVA: 0x00B11890 File Offset: 0x00B0FA90
		private double ForwardDistance(double from, double to)
		{
			double num = (to - from) % 1.0;
			if (num >= 0.0)
			{
				return num;
			}
			return num + 1.0;
		}

		// Token: 0x0602775E RID: 161630 RVA: 0x00B118C4 File Offset: 0x00B0FAC4
		private double WrapValue(double v)
		{
			return v % 1.0;
		}

		// Token: 0x0602775F RID: 161631 RVA: 0x00B118D1 File Offset: 0x00B0FAD1
		private ISeasonLoopConfig GetSeasonConfig(SeasonModel model, ESeason season)
		{
			return model.LoopConfigByIndex[(int)season];
		}

		// Token: 0x06027760 RID: 161632 RVA: 0x00B118E0 File Offset: 0x00B0FAE0
		private void WriteSeasonScalar(SeasonModel model)
		{
			if (object.Equals(model.LastWrittenValue, model.CurrentValue))
			{
				if (SeasonController._writeBurstActive)
				{
					SeasonController._writeBurstActive = false;
				}
				return;
			}
			UMaterialParameterCollection materialAsset = model.MaterialAsset;
			FName? timelineParamName = model.TimelineParamName;
			BP_MainGameInstance_C gameInstance = GlobalData.GameInstance;
			UWorld uworld = (gameInstance != null) ? gameInstance.GetWorld() : null;
			if (materialAsset == null || timelineParamName == null || uworld == null)
			{
				return;
			}
			try
			{
				UKismetMaterialLibrary.SetScalarParameterValue(uworld, materialAsset, timelineParamName.Value, (float)model.CurrentValue);
				AudioSystem.Instance.SetRtpcValue("season_mpc_value", (float)model.CurrentValue, null);
				if (!SeasonController._writeBurstActive)
				{
					SeasonController._writeBurstActive = true;
				}
				model.LastWrittenValue = new double?(model.CurrentValue);
			}
			catch (Exception ex)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Season;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "写 MPC 失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06027761 RID: 161633 RVA: 0x00B119E4 File Offset: 0x00B0FBE4
		private void WriteSeasonAudioState(SeasonModel model)
		{
			ESeason season = this.LocateLoopPosition(model.CurrentValue).Season;
			ESeason? lastReportedSeason = model.LastReportedSeason;
			ESeason eseason = season;
			if (lastReportedSeason.GetValueOrDefault() == eseason & lastReportedSeason != null)
			{
				return;
			}
			model.LastReportedSeason = new ESeason?(season);
			AudioSystem.Instance.SetState("game_scene_season", SeasonDefine.GetSeasonAudioName(season), true);
		}

		// Token: 0x17005080 RID: 20608
		// (get) Token: 0x06027762 RID: 161634 RVA: 0x00B11A43 File Offset: 0x00B0FC43
		public static SeasonController Instance
		{
			get
			{
				return SeasonController._Instance;
			}
		}

		// Token: 0x06027763 RID: 161635 RVA: 0x00B11A4A File Offset: 0x00B0FC4A
		public static SeasonController GetOrCreateInstance()
		{
			if (SeasonController._Instance == null)
			{
				SeasonController.CreateInstance();
			}
			return SeasonController._Instance;
		}

		// Token: 0x06027764 RID: 161636 RVA: 0x00B11A5E File Offset: 0x00B0FC5E
		public static bool CreateInstance()
		{
			if (SeasonController._Instance != null)
			{
				return true;
			}
			SeasonController._Instance = new SeasonController();
			return true;
		}

		// Token: 0x06027765 RID: 161637 RVA: 0x00B11A74 File Offset: 0x00B0FC74
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06027766 RID: 161638 RVA: 0x00B11A76 File Offset: 0x00B0FC76
		public static void ResetStaticDefaultValue()
		{
			SeasonController._Instance = null;
		}

		// Token: 0x06027767 RID: 161639 RVA: 0x00B11A7E File Offset: 0x00B0FC7E
		static SeasonController()
		{
			ESeason[] array = new ESeason[4];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.6256A4B0BE4127B6FF9FA076FE7595961BC296521BD01220F64C6F95768C1FDD).FieldHandle);
			SeasonController.SeasonByQuarter = array;
			StaticVariableRegister.RegisterAndExecute(new Action(SeasonController.CreateStaticDefaultValue), new Action(SeasonController.ResetStaticDefaultValue));
		}

		// Token: 0x04015819 RID: 88089
		[StaticVariableRuleIgnore]
		private static readonly ESeason[] SeasonByQuarter;

		// Token: 0x0401581A RID: 88090
		private const int QUARTER_COUNT = 4;

		// Token: 0x0401581B RID: 88091
		private const double HOLD_EPSILON = 0.0001;

		// Token: 0x0401581C RID: 88092
		[StaticVariableRuleIgnore]
		private static bool _writeBurstActive;

		// Token: 0x0401581D RID: 88093
		[Nullable(2)]
		private static SeasonController _Instance;
	}
}
