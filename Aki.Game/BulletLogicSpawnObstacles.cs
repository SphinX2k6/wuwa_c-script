using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.TypeScript.Game.NewWorld.Bullet.LogicDataClass;
using CSharpScript.Game.NewWorld.SceneItem.RefCompController;
using UnrealEngine;

// Token: 0x02002333 RID: 9011
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicSpawnObstacles : BulletLogicController<LogicDataSpawnObstacles, object>
{
	// Token: 0x060162EF RID: 90863 RVA: 0x00674A7E File Offset: 0x00672C7E
	public BulletLogicSpawnObstacles(LogicDataSpawnObstacles data, Entity entity) : base(data, entity)
	{
	}

	// Token: 0x060162F0 RID: 90864 RVA: 0x00674A88 File Offset: 0x00672C88
	public override void OnInit()
	{
		LogicDataSpawnObstacles logicController = this.LogicController;
		FTransformDouble defaultTransformDouble = MathUtils.Instance.DefaultTransformDouble;
		this.Actor = ActorSystem.Instance.Get(AActor.StaticClass(), defaultTransformDouble, null, true);
		EBulletLogicObstacles model = logicController.Model;
		UPrimitiveComponent uprimitiveComponent = null;
		BulletInfo bulletInfo = this.Bullet.GetBulletInfo();
		if (model == EBulletLogicObstacles.圆柱)
		{
			UStaticMeshComponent ustaticMeshComponent = this.Actor.AddComponentByClass(UStaticMeshComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, true, default(FName)) as UStaticMeshComponent;
			ustaticMeshComponent.SetStaticMesh(logicController.Mesh);
			uprimitiveComponent = ustaticMeshComponent;
		}
		else if (model == EBulletLogicObstacles.长方体)
		{
			uprimitiveComponent = (this.Actor.AddComponentByClass(UBoxComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, true, default(FName)) as UBoxComponent);
		}
		if (uprimitiveComponent != null)
		{
			uprimitiveComponent.SetCollisionProfileName(logicController.ProfileName, false);
			uprimitiveComponent.bCanCharacterStandOn = logicController.CanStandOn;
			this.Actor.Tags.Add(CharacterNameDefines.Instance.NO_SLIDE);
			uprimitiveComponent.SetGenerateOverlapEvents(false);
			uprimitiveComponent.CreationMethod = EComponentCreationMethod.Instance;
			uprimitiveComponent.SetVisibility(logicController.ShowModel, false);
			this.Actor.FinishAddComponent(uprimitiveComponent, false, MathUtils.Instance.DefaultTransform);
			if (logicController.NeedAttach)
			{
				EAttachmentRule eattachmentRule = EAttachmentRule.SnapToTarget;
				this.Actor.K2_AttachToActor(bulletInfo.Actor, FNameUtil.NONE, eattachmentRule, eattachmentRule, EAttachmentRule.KeepWorld, false, true);
			}
			else
			{
				FHitResult fhitResult = null;
				AActor actor = this.Actor;
				FTransformDouble ftransformDouble = bulletInfo.Actor.D_GetTransform();
				actor.D_K2_SetActorTransform(ftransformDouble, false, ref fhitResult, true);
			}
			if (model == EBulletLogicObstacles.圆柱)
			{
				Vector vector = BulletPool.CreateVector(false);
				Vector vector2 = vector;
				FVector size = logicController.Size;
				vector2.FromUeVector(size);
				vector.MultiplyEqual(0.019999999552965164);
				uprimitiveComponent.D_SetRelativeScale3D(vector.ToUeVector(false));
				BulletPool.RecycleVector(vector);
			}
			else if (model == EBulletLogicObstacles.长方体)
			{
				(uprimitiveComponent as UBoxComponent).D_SetBoxExtent(UKismetMathLibrary.Conv_VectorToVectorDouble(logicController.Size), true);
			}
		}
		if (logicController.IsAirWall)
		{
			this.Actor.Tags.Add(RefCompAirWallController.AIR_WALL);
		}
	}

	// Token: 0x060162F1 RID: 90865 RVA: 0x00674C84 File Offset: 0x00672E84
	public override void OnBulletDestroy()
	{
		if (this.LogicController.NeedAttach)
		{
			this.Actor.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
		}
		ActorSystem.Instance.Put("BulletLogicSpawnObstacles.OnBulletDestroy", this.Actor, null);
	}

	// Token: 0x0400BB0B RID: 47883
	[Nullable(2)]
	private AActor Actor;
}
