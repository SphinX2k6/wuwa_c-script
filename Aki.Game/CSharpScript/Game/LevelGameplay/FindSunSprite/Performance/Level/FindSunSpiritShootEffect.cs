using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.Level
{
	// Token: 0x02006E5E RID: 28254
	[NullableContext(1)]
	[Nullable(0)]
	public class FindSunSpiritShootEffect
	{
		// Token: 0x06044DB3 RID: 282035 RVA: 0x010FEAAC File Offset: 0x010FCCAC
		public void InitConfig(string lineEffectPath, string endEffectPath)
		{
			this.LineEffectPath = lineEffectPath;
			this.EndEffectPath = endEffectPath;
			this.TempTransform.SetRotation(FindSunSpiritModel.Instance.LevelQuat);
		}

		// Token: 0x06044DB4 RID: 282036 RVA: 0x010FEAD4 File Offset: 0x010FCCD4
		public void SpawnEffect(Vector targetLocation)
		{
			Vector tempVector = this.TempVector;
			Vector tempVector2 = this.TempVector2;
			Vector vector = tempVector;
			FVectorDouble fvectorDouble = Global.CharacterCameraManager.D_GetCameraLocation();
			vector.FromUeVector(fvectorDouble);
			Vector vector2 = tempVector2;
			FVector actorUpVector = Global.CharacterCameraManager.GetActorUpVector();
			vector2.FromUeVector(actorUpVector);
			tempVector.AdditionEqual(tempVector2.MultiplyEqual(-150.0));
			Transform tempTransform = this.TempTransform;
			tempTransform.SetLocation(tempVector);
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(tempTransform.ToUeTransform());
			int id = instance.SpawnEffect(world, ftransformDouble, this.LineEffectPath, "[FindSunSpiritGuideLine.SpawnShootLineEffect]", null, EEffectType.Scene, null, null, null, false, false);
			OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> niagaraComponent = EffectSystem.Instance.GetNiagaraComponent(id);
			FVector fvector = UKismetMathLibrary.WD_WorldToLocal(GlobalData.World, targetLocation.ToUeVector(false));
			niagaraComponent.SetNiagaraVariableVec3("end", fvector);
			tempTransform.SetLocation(targetLocation);
			EffectSystem instance2 = EffectSystem.Instance;
			UObject world2 = GlobalData.World;
			ftransformDouble = new FTransformDouble?(tempTransform.ToUeTransform());
			instance2.SpawnEffect(world2, ftransformDouble, this.EndEffectPath, "[FindSunSpiritGuideLine.SpawnShootEndEffect]", null, EEffectType.Scene, null, null, null, false, false);
		}

		// Token: 0x04023D44 RID: 146756
		private const float OFFSET_LENGTH = -150f;

		// Token: 0x04023D45 RID: 146757
		private string LineEffectPath = "";

		// Token: 0x04023D46 RID: 146758
		private string EndEffectPath = "";

		// Token: 0x04023D47 RID: 146759
		private readonly Transform TempTransform = Transform.Create();

		// Token: 0x04023D48 RID: 146760
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x04023D49 RID: 146761
		private readonly Vector TempVector2 = Vector.Create();
	}
}
