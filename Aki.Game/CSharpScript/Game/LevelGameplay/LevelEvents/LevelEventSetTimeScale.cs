using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CF7 RID: 23799
	public class LevelEventSetTimeScale : LevelEventBase, IStaticVariableResetter
	{
		// Token: 0x0603A3B6 RID: 238518 RVA: 0x01074150 File Offset: 0x01072350
		public LevelEventSetTimeScale(int Id) : base(Id)
		{
		}

		// Token: 0x0603A3B7 RID: 238519 RVA: 0x01074159 File Offset: 0x01072359
		static LevelEventSetTimeScale()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelEventSetTimeScale.CreateStaticDefaultValue), new Action(LevelEventSetTimeScale.ResetStaticDefaultValue));
		}

		// Token: 0x0603A3B8 RID: 238520 RVA: 0x01074178 File Offset: 0x01072378
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.LJM, "[LevelEventSetTimeScale]", default(ReadOnlySpan<ValueTuple<string, object>>));
			SetTimeScale setTimeScale = inParams as SetTimeScale;
			if (setTimeScale == null)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			ISetGlobalTimeScale config = setTimeScale.Config;
			if (config != null)
			{
				ISetGlobalTimeScaleType config2 = config.Config;
				TimerHandle resumeTimerHandle = LevelEventSetTimeScale.ResumeTimerHandle;
				if (resumeTimerHandle != null && resumeTimerHandle.Valid())
				{
					LevelEventSetTimeScale.ResumeTimerHandle.Remove();
					LevelEventSetTimeScale.ResumeTimerHandle = null;
				}
				IOpenGlobalTimeScale openGlobalTimeScale = config2 as IOpenGlobalTimeScale;
				if (openGlobalTimeScale != null)
				{
					float interval = openGlobalTimeScale.Duration * (float)TimeUtil.Instance.InverseMillisecond;
					if (interval > 0f)
					{
						CharacterController.Instance.EnterSelfCenteredMode(ESelfCenteredMode.LevelEvent, openGlobalTimeScale.TimeScale, openGlobalTimeScale.Duration);
						LevelEventSetTimeScale.ResumeTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
						{
							CharacterController.Instance.ExitSelfCenteredMode(ESelfCenteredMode.LevelEvent);
							global::Log instance3 = global::Log.Instance;
							ELogModule module3 = ELogModule.LevelEvent;
							ELogAuthor author3 = ELogAuthor.LJM;
							string message3 = "[LevelEventSetTimeScale] AutoClose";
							ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("interval(ms)", interval);
							instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
						}, (float)((int)interval), null, null, true, 1f);
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.LevelEvent;
						ELogAuthor author = ELogAuthor.LJM;
						string message = "[LevelEventSetTimeScale] Open";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("interval(ms)", interval);
						instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
				}
				else
				{
					ICloseGlobalTimeScale closeGlobalTimeScale = config2 as ICloseGlobalTimeScale;
					if (closeGlobalTimeScale != null)
					{
						if (closeGlobalTimeScale.TimeScaleCloseSource.GetValueOrDefault() == ETimeScaleCloseSource.Level)
						{
							CharacterController.Instance.ExitSelfCenteredMode(ESelfCenteredMode.LevelEvent);
						}
						else if (closeGlobalTimeScale.TimeScaleCloseSource.GetValueOrDefault() == ETimeScaleCloseSource.Skill)
						{
							CharacterController.Instance.ExitSkillSelfCenteredMode();
						}
						else
						{
							CharacterController.Instance.ExitAllSelfCenteredMode();
						}
						global::Log instance2 = global::Log.Instance;
						ELogModule module2 = ELogModule.LevelEvent;
						ELogAuthor author2 = ELogAuthor.LJM;
						string message2 = "[LevelEventSetTimeScale] Close";
						string item = "TimeScaleCloseSource";
						ETimeScaleCloseSource? timeScaleCloseSource = closeGlobalTimeScale.TimeScaleCloseSource;
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item, ((timeScaleCloseSource != null) ? new int?((int)timeScaleCloseSource.GetValueOrDefault()) : null).GetValueOrDefault(-1));
						instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					}
				}
			}
		}

		// Token: 0x0603A3B9 RID: 238521 RVA: 0x01074362 File Offset: 0x01072562
		public static void CreateStaticDefaultValue()
		{
			LevelEventSetTimeScale.ResumeTimerHandle = null;
		}

		// Token: 0x0603A3BA RID: 238522 RVA: 0x0107436A File Offset: 0x0107256A
		public static void ResetStaticDefaultValue()
		{
			LevelEventSetTimeScale.ResumeTimerHandle = null;
		}

		// Token: 0x0401EBF8 RID: 125944
		[Nullable(2)]
		private static TimerHandle ResumeTimerHandle;
	}
}
