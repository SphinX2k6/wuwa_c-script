using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071EC RID: 29164
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemManipulablePrecastState : SceneItemManipulableBaseState
	{
		// Token: 0x0604761E RID: 292382 RVA: 0x01228DBA File Offset: 0x01226FBA
		public SceneItemManipulablePrecastState(SceneItemManipulatableComponent sceneItem) : base(sceneItem)
		{
		}

		// Token: 0x0604761F RID: 292383 RVA: 0x01228DD9 File Offset: 0x01226FD9
		public void SetDirection(int newValue)
		{
			this.Direction = newValue;
		}

		// Token: 0x06047620 RID: 292384 RVA: 0x01228DE2 File Offset: 0x01226FE2
		protected override void OnEnter()
		{
			this.Timer = 0f;
			this.CurrentPrecastSpline = ManipulateConfig.Instance.ManipulatePrecastLines[this.Direction];
			this.StartActorLoc = Vector.Create(this.SceneItem.ActorComp.ActorLocationProxy);
		}

		// Token: 0x06047621 RID: 292385 RVA: 0x01228E24 File Offset: 0x01227024
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

		// Token: 0x06047622 RID: 292386 RVA: 0x01228EE4 File Offset: 0x012270E4
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

		// Token: 0x06047623 RID: 292387 RVA: 0x01228FBC File Offset: 0x012271BC
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

		// Token: 0x0402589C RID: 153756
		private int Direction;

		// Token: 0x0402589D RID: 153757
		private string CurrentPrecastSpline = "";

		// Token: 0x0402589E RID: 153758
		[Nullable(2)]
		private Vector CharacterDir;

		// Token: 0x0402589F RID: 153759
		private readonly Vector CharacterVerticalDir = Vector.Create();

		// Token: 0x040258A0 RID: 153760
		[Nullable(2)]
		private Vector StartActorLoc;
	}
}
