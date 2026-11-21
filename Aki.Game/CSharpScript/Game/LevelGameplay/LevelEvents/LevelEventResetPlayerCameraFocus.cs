using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CDA RID: 23770
	public class LevelEventResetPlayerCameraFocus : LevelEventBase, IStaticVariableResetter
	{
		// Token: 0x0603A343 RID: 238403 RVA: 0x0106E911 File Offset: 0x0106CB11
		static LevelEventResetPlayerCameraFocus()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelEventResetPlayerCameraFocus.CreateStaticDefaultValue), new Action(LevelEventResetPlayerCameraFocus.ResetStaticDefaultValue));
		}

		// Token: 0x0603A344 RID: 238404 RVA: 0x0106E930 File Offset: 0x0106CB30
		public LevelEventResetPlayerCameraFocus(int id) : base(id)
		{
		}

		// Token: 0x0603A345 RID: 238405 RVA: 0x0106E93C File Offset: 0x0106CB3C
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

		// Token: 0x0603A346 RID: 238406 RVA: 0x0106EAC2 File Offset: 0x0106CCC2
		public static void CreateStaticDefaultValue()
		{
			LevelEventResetPlayerCameraFocus._desRotator = Rotator.Create();
		}

		// Token: 0x0603A347 RID: 238407 RVA: 0x0106EACE File Offset: 0x0106CCCE
		public static void ResetStaticDefaultValue()
		{
			LevelEventResetPlayerCameraFocus._desRotator = null;
		}

		// Token: 0x0401EBE1 RID: 125921
		[Nullable(2)]
		private static Rotator _desRotator;
	}
}
