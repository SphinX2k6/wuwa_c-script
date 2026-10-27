using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B4E RID: 27470
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventPlayerLoockAt : LevelEventBase
	{
		// Token: 0x060441B1 RID: 278961 RVA: 0x010C2493 File Offset: 0x010C0693
		public LevelEventPlayerLoockAt(int id) : base(id)
		{
		}

		// Token: 0x060441B2 RID: 278962 RVA: 0x010C249C File Offset: 0x010C069C
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

		// Token: 0x060441B3 RID: 278963 RVA: 0x010C25B2 File Offset: 0x010C07B2
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0402392A RID: 145706
		[StaticVariableRuleIgnore]
		private static readonly Vector tmpVector = Vector.Create();

		// Token: 0x0402392B RID: 145707
		[StaticVariableRuleIgnore]
		private static readonly Quat tmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0402392C RID: 145708
		[StaticVariableRuleIgnore]
		private static readonly Rotator tmpRotator = Rotator.Create();
	}
}
