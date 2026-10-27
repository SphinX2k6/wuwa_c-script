using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002C99 RID: 11417
[NullableContext(1)]
[Nullable(0)]
public class UiDangoCollisionComponent : UiModelComponentBase
{
	// Token: 0x06017DD0 RID: 97744 RVA: 0x00611629 File Offset: 0x0060F829
	protected override void OnInit()
	{
		this.UiModelActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
	}

	// Token: 0x06017DD1 RID: 97745 RVA: 0x0061163C File Offset: 0x0060F83C
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x06017DD2 RID: 97746 RVA: 0x00611660 File Offset: 0x0060F860
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x06017DD3 RID: 97747 RVA: 0x00611684 File Offset: 0x0060F884
	private void OnModelLoadComplete()
	{
		this.InitCollisionComponent();
	}

	// Token: 0x06017DD4 RID: 97748 RVA: 0x0061168C File Offset: 0x0060F88C
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
		if (Info.Instance.IsPlayInEditor)
		{
			ULGUIBPLibrary.AddInstanceComponent(this.UiModelActorComponent.Actor, this.CollisionComponent);
		}
	}

	// Token: 0x0400B1E7 RID: 45543
	private const float DANGO_COLLISION_SIZE = 35f;

	// Token: 0x0400B1E8 RID: 45544
	protected UiModelActorComponent UiModelActorComponent;

	// Token: 0x0400B1E9 RID: 45545
	protected UBoxComponent CollisionComponent;
}
