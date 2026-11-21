using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.Level
{
	// Token: 0x02005FDF RID: 24543
	[NullableContext(1)]
	[Nullable(0)]
	public class FindSunSpiritShootEffect
	{
		// Token: 0x0603AF40 RID: 241472 RVA: 0x010A900C File Offset: 0x010A720C
		public void InitConfig(string lineEffectPath, string endEffectPath)
		{
			this.LineEffectPath = lineEffectPath;
			this.EndEffectPath = endEffectPath;
			this.TempTransform.SetRotation(FindSunSpiritModel.Instance.LevelQuat);
		}

		// Token: 0x0603AF41 RID: 241473 RVA: 0x010A9034 File Offset: 0x010A7234
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

		// Token: 0x0401EFF9 RID: 126969
		private const float OFFSET_LENGTH = -150f;

		// Token: 0x0401EFFA RID: 126970
		private string LineEffectPath = "";

		// Token: 0x0401EFFB RID: 126971
		private string EndEffectPath = "";

		// Token: 0x0401EFFC RID: 126972
		private readonly Transform TempTransform = Transform.Create();

		// Token: 0x0401EFFD RID: 126973
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x0401EFFE RID: 126974
		private readonly Vector TempVector2 = Vector.Create();
	}
}
