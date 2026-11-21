using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020062A1 RID: 25249
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemManipulablePrecastState : SceneItemManipulableBaseState
	{
		// Token: 0x0603CF20 RID: 249632 RVA: 0x01182C0E File Offset: 0x01180E0E
		public SceneItemManipulablePrecastState(SceneItemManipulatableComponent sceneItem) : base(sceneItem)
		{
		}

		// Token: 0x0603CF21 RID: 249633 RVA: 0x01182C2D File Offset: 0x01180E2D
		public void SetDirection(int newValue)
		{
			this.Direction = newValue;
		}

		// Token: 0x0603CF22 RID: 249634 RVA: 0x01182C36 File Offset: 0x01180E36
		protected override void OnEnter()
		{
			this.Timer = 0f;
			this.CurrentPrecastSpline = ManipulateConfig.Instance.ManipulatePrecastLines[this.Direction];
			this.StartActorLoc = Vector.Create(this.SceneItem.ActorComp.ActorLocationProxy);
		}

		// Token: 0x0603CF23 RID: 249635 RVA: 0x01182C78 File Offset: 0x01180E78
		protected override void OnTick(float delta)
		{
			this.Timer += delta * 1000f;
			FVector? precastLineValue = ManipulateConfig.Instance.GetPrecastLineValue(this.CurrentPrecastSpline, this.Timer / ManipulateConfig.Instance.PrecastTime);
			Vector vector = Vector.Create();
			Vector vector2 = Vector.Create();
			Vector targetLocation = this.GetTargetLocation();
			this.CalcCharacterDirs();
			this.CharacterDir.Multiply((double)precastLineValue.Value.X, vector);
			this.CharacterVerticalDir.Multiply((double)precastLineValue.Value.Z, vector2);
			vector2.AdditionEqual(vector);
			vector2.AdditionEqual(targetLocation);
			this.SceneItem.ActorComp.SetActorLocation(vector2.ToUeVector(false), "unknown", true);
		}

		// Token: 0x0603CF24 RID: 249636 RVA: 0x01182D38 File Offset: 0x01180F38
		private Vector GetTargetLocation()
		{
			FTransformDouble actorTransform = Global.BaseCharacter.CharacterActorComponent.ActorTransform;
			FVectorDouble value = (this.SceneItem.UsingAssistantHoldOffset ? this.SceneItem.ConfigAssistantHoldOffset : this.SceneItem.ConfigHoldOffset).Value;
			Vector vector = Vector.Create(actorTransform.TransformPositionNoScale(value));
			if (this.StartActorLoc != null)
			{
				float num = MathUtils.Instance.Clamp(this.Timer / ManipulateConfig.Instance.PrecastTime, 0f, 1f);
				if (num < 1f)
				{
					Vector vector2 = Vector.Create();
					vector.Subtraction(this.StartActorLoc, vector2);
					Vector vector3 = Vector.Create();
					vector2.Multiply((double)num, vector3);
					Vector vector4 = Vector.Create(this.StartActorLoc);
					vector4.AdditionEqual(vector3);
					return vector4;
				}
			}
			return vector;
		}

		// Token: 0x0603CF25 RID: 249637 RVA: 0x01182E10 File Offset: 0x01181010
		private void CalcCharacterDirs()
		{
			Vector vector = Vector.Create();
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Vector characterDir;
			if (baseCharacter == null)
			{
				characterDir = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				characterDir = ((characterActorComponent != null) ? characterActorComponent.ActorForwardProxy : null);
			}
			this.CharacterDir = characterDir;
			TsBaseCharacter baseCharacter2 = Global.BaseCharacter;
			Vector vector2;
			if (baseCharacter2 == null)
			{
				vector2 = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent2 = baseCharacter2.CharacterActorComponent;
				vector2 = ((characterActorComponent2 != null) ? characterActorComponent2.ActorUpProxy : null);
			}
			Vector inB = vector2;
			this.CharacterDir.CrossProduct(inB, vector);
			vector.CrossProduct(this.CharacterDir, this.CharacterVerticalDir);
			this.CharacterVerticalDir.Normalize(9.99999993922529E-09);
		}

		// Token: 0x0402050B RID: 132363
		private int Direction;

		// Token: 0x0402050C RID: 132364
		private string CurrentPrecastSpline = "";

		// Token: 0x0402050D RID: 132365
		[Nullable(2)]
		private Vector CharacterDir;

		// Token: 0x0402050E RID: 132366
		private readonly Vector CharacterVerticalDir = Vector.Create();

		// Token: 0x0402050F RID: 132367
		[Nullable(2)]
		private Vector StartActorLoc;
	}
}
