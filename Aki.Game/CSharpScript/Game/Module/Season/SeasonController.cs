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
	// Token: 0x02004C79 RID: 19577
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	[TickController(0)]
	public class SeasonController : ControllerBase
	{
		// Token: 0x06032990 RID: 207248 RVA: 0x00BCC570 File Offset: 0x00BCA770
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

		// Token: 0x06032991 RID: 207249 RVA: 0x00BCC5AB File Offset: 0x00BCA7AB
		protected override bool OnLeaveLevel()
		{
			SeasonModel.Instance.ResetRuntime();
			return true;
		}

		// Token: 0x06032992 RID: 207250 RVA: 0x00BCC5B8 File Offset: 0x00BCA7B8
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

		// Token: 0x06032993 RID: 207251 RVA: 0x00BCC635 File Offset: 0x00BCA835
		public void RegisterVolume(TsTriggerVolume volume)
		{
			SeasonModel.Instance.RegisterVolume(volume);
		}

		// Token: 0x06032994 RID: 207252 RVA: 0x00BCC642 File Offset: 0x00BCA842
		public void UnregisterVolume(TsTriggerVolume volume)
		{
			SeasonModel.Instance.UnregisterVolume(volume);
		}

		// Token: 0x06032995 RID: 207253 RVA: 0x00BCC650 File Offset: 0x00BCA850
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

		// Token: 0x06032996 RID: 207254 RVA: 0x00BCC68C File Offset: 0x00BCA88C
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

		// Token: 0x06032997 RID: 207255 RVA: 0x00BCC6D0 File Offset: 0x00BCA8D0
		public ESeason? GetSeasonByAreaId(int areaId)
		{
			SeasonModel instance = SeasonModel.Instance;
			if (!instance.IsAreaActive(areaId))
			{
				return null;
			}
			return new ESeason?(this.LocateLoopPosition(instance.CurrentValue).Season);
		}

		// Token: 0x06032998 RID: 207256 RVA: 0x00BCC70C File Offset: 0x00BCA90C
		private void StopLoop(SeasonModel model)
		{
			model.LoopConfig = null;
			model.LoopState = null;
			if (model.DriverPhase == ESeasonDriverPhase.Looping)
			{
				this.SetDriverPhase(model, ESeasonDriverPhase.Idle);
			}
		}

		// Token: 0x06032999 RID: 207257 RVA: 0x00BCC72D File Offset: 0x00BCA92D
		private void StartOrReplaceLoop(SeasonModel model, ILoopSeasonChange config)
		{
			model.LoopConfig = config;
			if (model.DriverPhase == ESeasonDriverPhase.Switching)
			{
				return;
			}
			this.EnterLoopFromCurrentValue(model);
		}

		// Token: 0x0603299A RID: 207258 RVA: 0x00BCC748 File Offset: 0x00BCA948
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

		// Token: 0x0603299B RID: 207259 RVA: 0x00BCC7B4 File Offset: 0x00BCA9B4
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

		// Token: 0x0603299C RID: 207260 RVA: 0x00BCC7E4 File Offset: 0x00BCA9E4
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

		// Token: 0x0603299D RID: 207261 RVA: 0x00BCC814 File Offset: 0x00BCAA14
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

		// Token: 0x0603299E RID: 207262 RVA: 0x00BCC858 File Offset: 0x00BCAA58
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

		// Token: 0x0603299F RID: 207263 RVA: 0x00BCC8C4 File Offset: 0x00BCAAC4
		private void SetDriverPhase(SeasonModel model, ESeasonDriverPhase next)
		{
			if (model.DriverPhase == next)
			{
				return;
			}
			model.DriverPhase = next;
		}

		// Token: 0x060329A0 RID: 207264 RVA: 0x00BCC8D8 File Offset: 0x00BCAAD8
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

		// Token: 0x060329A1 RID: 207265 RVA: 0x00BCC910 File Offset: 0x00BCAB10
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

		// Token: 0x060329A2 RID: 207266 RVA: 0x00BCC991 File Offset: 0x00BCAB91
		private void LeaveSwitching(SeasonModel model)
		{
			if (model.LoopConfig != null)
			{
				this.EnterLoopFromCurrentValue(model);
				return;
			}
			this.SetDriverPhase(model, ESeasonDriverPhase.Idle);
		}

		// Token: 0x060329A3 RID: 207267 RVA: 0x00BCC9AC File Offset: 0x00BCABAC
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

		// Token: 0x060329A4 RID: 207268 RVA: 0x00BCCA30 File Offset: 0x00BCAC30
		private double GetPhaseDuration(SeasonModel model, ESeason season, ESeasonLoopPhase phase)
		{
			ISeasonLoopConfig seasonConfig = this.GetSeasonConfig(model, season);
			return (double)((phase == ESeasonLoopPhase.Hold) ? seasonConfig.HoldTime : seasonConfig.SwitchTime);
		}

		// Token: 0x060329A5 RID: 207269 RVA: 0x00BCCA58 File Offset: 0x00BCAC58
		private double ComputePhaseValue(ISeasonLoopState state, double duration)
		{
			if (state.Phase == ESeasonLoopPhase.Hold)
			{
				return SeasonDefine.GetSeasonTimelineValue(state.CurrentSeason);
			}
			return this.LerpForward(state.CurrentSeason, SeasonDefine.GetNextSeasonInLoop(state.CurrentSeason), state.PhaseElapsed / duration);
		}

		// Token: 0x060329A6 RID: 207270 RVA: 0x00BCCA90 File Offset: 0x00BCAC90
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

		// Token: 0x060329A7 RID: 207271 RVA: 0x00BCCAE8 File Offset: 0x00BCACE8
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

		// Token: 0x060329A8 RID: 207272 RVA: 0x00BCCB68 File Offset: 0x00BCAD68
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

		// Token: 0x060329A9 RID: 207273 RVA: 0x00BCCBF4 File Offset: 0x00BCADF4
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

		// Token: 0x060329AA RID: 207274 RVA: 0x00BCCC2C File Offset: 0x00BCAE2C
		private double ForwardDistance(double from, double to)
		{
			double num = (to - from) % 1.0;
			if (num >= 0.0)
			{
				return num;
			}
			return num + 1.0;
		}

		// Token: 0x060329AB RID: 207275 RVA: 0x00BCCC60 File Offset: 0x00BCAE60
		private double WrapValue(double v)
		{
			return v % 1.0;
		}

		// Token: 0x060329AC RID: 207276 RVA: 0x00BCCC6D File Offset: 0x00BCAE6D
		private ISeasonLoopConfig GetSeasonConfig(SeasonModel model, ESeason season)
		{
			return model.LoopConfigByIndex[(int)season];
		}

		// Token: 0x060329AD RID: 207277 RVA: 0x00BCCC7C File Offset: 0x00BCAE7C
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

		// Token: 0x060329AE RID: 207278 RVA: 0x00BCCD80 File Offset: 0x00BCAF80
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

		// Token: 0x17007CD6 RID: 31958
		// (get) Token: 0x060329AF RID: 207279 RVA: 0x00BCCDDF File Offset: 0x00BCAFDF
		public static SeasonController Instance
		{
			get
			{
				return SeasonController._Instance;
			}
		}

		// Token: 0x060329B0 RID: 207280 RVA: 0x00BCCDE6 File Offset: 0x00BCAFE6
		public static SeasonController GetOrCreateInstance()
		{
			if (SeasonController._Instance == null)
			{
				SeasonController.CreateInstance();
			}
			return SeasonController._Instance;
		}

		// Token: 0x060329B1 RID: 207281 RVA: 0x00BCCDFA File Offset: 0x00BCAFFA
		public static bool CreateInstance()
		{
			if (SeasonController._Instance != null)
			{
				return true;
			}
			SeasonController._Instance = new SeasonController();
			return true;
		}

		// Token: 0x060329B2 RID: 207282 RVA: 0x00BCCE10 File Offset: 0x00BCB010
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060329B3 RID: 207283 RVA: 0x00BCCE12 File Offset: 0x00BCB012
		public static void ResetStaticDefaultValue()
		{
			SeasonController._Instance = null;
		}

		// Token: 0x060329B4 RID: 207284 RVA: 0x00BCCE1A File Offset: 0x00BCB01A
		static SeasonController()
		{
			ESeason[] array = new ESeason[4];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.6256A4B0BE4127B6FF9FA076FE7595961BC296521BD01220F64C6F95768C1FDD).FieldHandle);
			SeasonController.SeasonByQuarter = array;
			StaticVariableRegister.RegisterAndExecute(new Action(SeasonController.CreateStaticDefaultValue), new Action(SeasonController.ResetStaticDefaultValue));
		}

		// Token: 0x0401AEBC RID: 110268
		[StaticVariableRuleIgnore]
		private static readonly ESeason[] SeasonByQuarter;

		// Token: 0x0401AEBD RID: 110269
		private const int QUARTER_COUNT = 4;

		// Token: 0x0401AEBE RID: 110270
		private const double HOLD_EPSILON = 0.0001;

		// Token: 0x0401AEBF RID: 110271
		[StaticVariableRuleIgnore]
		private static bool _writeBurstActive;

		// Token: 0x0401AEC0 RID: 110272
		[Nullable(2)]
		private static SeasonController _Instance;
	}
}
