using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020021F2 RID: 8690
[NullableContext(1)]
[Nullable(0)]
public class UiDangoCollisionComponent : UiModelComponentBase
{
	// Token: 0x06015644 RID: 87620 RVA: 0x006371CD File Offset: 0x006353CD
	protected override void OnInit()
	{
		this.UiModelActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
	}

	// Token: 0x06015645 RID: 87621 RVA: 0x006371E0 File Offset: 0x006353E0
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x06015646 RID: 87622 RVA: 0x00637204 File Offset: 0x00635404
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x06015647 RID: 87623 RVA: 0x00637228 File Offset: 0x00635428
	private void OnModelLoadComplete()
	{
		this.InitCollisionComponent();
	}

	// Token: 0x06015648 RID: 87624 RVA: 0x00637230 File Offset: 0x00635430
	private void InitCollisionComponent()
	{
		AActor actor = this.UiModelActorComponent.Actor;
		TSubclassOf<UActorComponent> @class = UBoxComponent.StaticClass();
		bool bManualAttachment = true;
		FTransform transform = this.UiModelActorComponent.Actor.GetTransform();
		this.CollisionComponent = (actor.AddComponentByClass(@class, bManualAttachment, transform, false, default(FName)) as UBoxComponent);
		this.CollisionComponent.SetTickableWhenPaused(true);
		this.CollisionComponent.SetBoxExtent(new FVector(35f, 35f, 35f), false);
		FVector newLocation = this.UiModelActorComponent.Actor.K2_GetActorLocation();
		float z = this.UiModelActorComponent.Actor.GetActorScale3D().Z;
		newLocation.Z += 35f * z;
		FHitResult fhitResult = new FHitResult();
		this.CollisionComponent.K2_SetWorldLocation(newLocation, false, ref fhitResult, false);
		this.CollisionComponent.SetCollisionEnabled(ECollisionEnabled.QueryOnly);
		this.CollisionComponent.SetCollisionObjectType(ECollisionChannel.ECC_Visibility);
		this.CollisionComponent.SetCollisionResponseToAllChannels(ECollisionResponse.ECR_Block);
	}

	// Token: 0x0400B552 RID: 46418
	private const float DANGO_COLLISION_SIZE = 35f;

	// Token: 0x0400B553 RID: 46419
	protected UiModelActorComponent UiModelActorComponent;

	// Token: 0x0400B554 RID: 46420
	protected UBoxComponent CollisionComponent;
}
