using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CC6 RID: 23750
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventPlayerLoockAt : LevelEventBase
	{
		// Token: 0x0603A303 RID: 238339 RVA: 0x0106C047 File Offset: 0x0106A247
		public LevelEventPlayerLoockAt(int id) : base(id)
		{
		}

		// Token: 0x0603A304 RID: 238340 RVA: 0x0106C050 File Offset: 0x0106A250
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			PlayerLookAt playerLookAt = inParams as PlayerLookAt;
			if (playerLookAt == null)
			{
				return;
			}
			float? x = playerLookAt.Pos.X;
			float? y = playerLookAt.Pos.Y;
			float? z = playerLookAt.Pos.Z;
			bool? cameraMove = playerLookAt.CameraMove;
			Vector vector = Vector.Create((double)x.GetValueOrDefault(), (double)y.GetValueOrDefault(), (double)z.GetValueOrDefault());
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return;
			}
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			vector.Subtraction(characterActorComponent.ActorLocationProxy, LevelEventPlayerLoockAt.tmpVector);
			MathUtils.Instance.LookRotationUpFirst(LevelEventPlayerLoockAt.tmpVector, characterActorComponent.ActorUpProxy, LevelEventPlayerLoockAt.tmpQuat);
			if (LevelEventPlayerLoockAt.tmpQuat.IsNearZero(1E-06f))
			{
				return;
			}
			LevelEventPlayerLoockAt.tmpQuat.Rotator(LevelEventPlayerLoockAt.tmpRotator);
			if (!playerLookAt.PlayAnimation.GetValueOrDefault())
			{
				characterActorComponent.SetActorRotation(LevelEventPlayerLoockAt.tmpRotator.ToUeRotator(), "LevelEventPlayerLoockAt", false);
			}
			characterActorComponent.SetInputRotator(LevelEventPlayerLoockAt.tmpRotator);
			if (cameraMove.GetValueOrDefault())
			{
				CameraBlueprintFunctionLibrary.SetCameraRotation(LevelEventPlayerLoockAt.tmpRotator.ToUeRotator());
			}
		}

		// Token: 0x0603A305 RID: 238341 RVA: 0x0106C166 File Offset: 0x0106A366
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0401EBCC RID: 125900
		[StaticVariableRuleIgnore]
		private static readonly Vector tmpVector = Vector.Create();

		// Token: 0x0401EBCD RID: 125901
		[StaticVariableRuleIgnore]
		private static readonly Quat tmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401EBCE RID: 125902
		[StaticVariableRuleIgnore]
		private static readonly Rotator tmpRotator = Rotator.Create();
	}
}
