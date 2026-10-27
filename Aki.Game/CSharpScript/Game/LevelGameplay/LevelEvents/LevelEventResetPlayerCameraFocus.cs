using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B62 RID: 27490
	public class LevelEventResetPlayerCameraFocus : LevelEventBase, IStaticVariableResetter
	{
		// Token: 0x060441F1 RID: 279025 RVA: 0x010C4D41 File Offset: 0x010C2F41
		static LevelEventResetPlayerCameraFocus()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelEventResetPlayerCameraFocus.CreateStaticDefaultValue), new Action(LevelEventResetPlayerCameraFocus.ResetStaticDefaultValue));
		}

		// Token: 0x060441F2 RID: 279026 RVA: 0x010C4D60 File Offset: 0x010C2F60
		public LevelEventResetPlayerCameraFocus(int id) : base(id)
		{
		}

		// Token: 0x060441F3 RID: 279027 RVA: 0x010C4D6C File Offset: 0x010C2F6C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			global::Log.Instance.Info(ELogModule.Event, ELogAuthor.LJM, "进入恢复相机调整", default(ReadOnlySpan<ValueTuple<string, object>>));
			ResetPlayerCameraFocus resetPlayerCameraFocus = inParams as ResetPlayerCameraFocus;
			if (resetPlayerCameraFocus == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null || !baseCharacter.IsValid())
			{
				base.FinishExecute(false, false, true);
				return;
			}
			float fadeInTime = resetPlayerCameraFocus.FadeInTime;
			bool canBreakByInput = !resetPlayerCameraFocus.CannotInterrupt.GetValueOrDefault();
			float valueOrDefault = resetPlayerCameraFocus.Duration.GetValueOrDefault();
			EResetPlayerFocusType type = resetPlayerCameraFocus.ResetType.Type;
			if (type != EResetPlayerFocusType.ResetToDefaultDirection)
			{
				if (type == EResetPlayerFocusType.ResetToFixedDirection)
				{
					IResetPlayerFocusToFixedDirection resetPlayerFocusToFixedDirection = resetPlayerCameraFocus.ResetType as IResetPlayerFocusToFixedDirection;
					LevelEventResetPlayerCameraFocus._desRotator.Set(resetPlayerFocusToFixedDirection.Direction.Y.GetValueOrDefault(), resetPlayerFocusToFixedDirection.Direction.Z.GetValueOrDefault(), resetPlayerFocusToFixedDirection.Direction.X.GetValueOrDefault());
					CameraController.Instance.MainModel.FightCamera.LogicComponent.PlayCameraEulerRotatorWithCurve(LevelEventResetPlayerCameraFocus._desRotator, fadeInTime, null, canBreakByInput, valueOrDefault);
				}
			}
			else
			{
				CameraUtility.ResetFocus(fadeInTime, null, canBreakByInput, valueOrDefault);
			}
			if (Global.BaseCharacter != null)
			{
				EntityHandle entityById = CreatureModel.Instance.GetEntityById(Global.BaseCharacter.EntityId);
				if (entityById != null)
				{
					WorldEntity entity = entityById.Entity;
					if (entity != null)
					{
						CharacterInputComponent component = entity.GetComponent<CharacterInputComponent>();
						if (component != null)
						{
							component.InterruptAutoMoving("进入相机调整ResetPlayerCameraFocus", true);
						}
					}
				}
			}
			global::Log.Instance.Info(ELogModule.Event, ELogAuthor.LJM, "结束恢复相机调整", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060441F4 RID: 279028 RVA: 0x010C4EF2 File Offset: 0x010C30F2
		public static void CreateStaticDefaultValue()
		{
			LevelEventResetPlayerCameraFocus._desRotator = Rotator.Create();
		}

		// Token: 0x060441F5 RID: 279029 RVA: 0x010C4EFE File Offset: 0x010C30FE
		public static void ResetStaticDefaultValue()
		{
			LevelEventResetPlayerCameraFocus._desRotator = null;
		}

		// Token: 0x0402393F RID: 145727
		[Nullable(2)]
		private static Rotator _desRotator;
	}
}
