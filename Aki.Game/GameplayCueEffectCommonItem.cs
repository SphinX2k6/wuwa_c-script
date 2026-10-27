using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x02002FAA RID: 12202
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueEffectCommonItem
{
	// Token: 0x06019E02 RID: 105986 RVA: 0x006C394A File Offset: 0x006C1B4A
	private GameplayCueEffectCommonItem(ABaseCharacter owner, FVectorDouble targetPosition, string[] paths)
	{
		this.Owner = owner;
		this.TargetPosition = targetPosition;
		this.Paths = paths;
	}

	// Token: 0x06019E03 RID: 105987 RVA: 0x006C3970 File Offset: 0x006C1B70
	[return: Nullable(2)]
	public static GameplayCueEffectCommonItem Spawn(ABaseCharacter owner, FVectorDouble targetPosition, string[] paths)
	{
		GameplayCueEffectCommonItem gameplayCueEffectCommonItem = new GameplayCueEffectCommonItem(owner, targetPosition, paths);
		int num = gameplayCueEffectCommonItem.CreateEffect();
		if (EffectSystem.Instance.IsValid(num))
		{
			gameplayCueEffectCommonItem.EffectViewHandle = num;
			gameplayCueEffectCommonItem.SetVisible(false);
			return gameplayCueEffectCommonItem;
		}
		return null;
	}

	// Token: 0x06019E04 RID: 105988 RVA: 0x006C39AC File Offset: 0x006C1BAC
	public void Destroy()
	{
		this.EffectActor.Clear();
		if (EffectSystem.Instance.IsValid(this.EffectViewHandle))
		{
			EffectSystem.Instance.StopEffectById(this.EffectViewHandle, "[GameplayCueEffectCommonItem.Destroy]", true, null);
		}
	}

	// Token: 0x06019E05 RID: 105989 RVA: 0x006C39F8 File Offset: 0x006C1BF8
	[NullableContext(2)]
	public void Refresh(bool visible, Vector location = null, Rotator rotation = null)
	{
		this.SetVisible(visible);
		if (!visible)
		{
			return;
		}
		if (location != null && rotation != null)
		{
			OneOf<KuroEffectActorHandle, AActor> effectActor = this.EffectActor;
			FVectorDouble fvectorDouble = location.ToUeVector(false);
			FRotator frotator = rotation.ToUeRotator();
			effectActor.D_K2_SetActorLocationAndRotation(fvectorDouble, frotator, false, ref WorldGlobal.SweepHitResult, true);
			return;
		}
		if (location != null)
		{
			OneOf<KuroEffectActorHandle, AActor> effectActor2 = this.EffectActor;
			FVectorDouble fvectorDouble = location.ToUeVector(false);
			effectActor2.D_K2_SetActorLocation(fvectorDouble, false, ref WorldGlobal.SweepHitResult, true);
		}
		if (rotation != null)
		{
			OneOf<KuroEffectActorHandle, AActor> effectActor3 = this.EffectActor;
			FRotator frotator = rotation.ToUeRotator();
			effectActor3.K2_SetActorRotation(frotator, false);
		}
	}

	// Token: 0x06019E06 RID: 105990 RVA: 0x006C3A76 File Offset: 0x006C1C76
	public void SetVisible(bool visible)
	{
		if (this.IsVisible == visible)
		{
			return;
		}
		this.IsVisible = visible;
		this.EffectActor.SetActorHiddenInGame(!visible);
	}

	// Token: 0x06019E07 RID: 105991 RVA: 0x006C3A98 File Offset: 0x006C1C98
	private int CreateEffect()
	{
		if (this.Paths.Length == 0)
		{
			return 0;
		}
		EffectSystem instance = EffectSystem.Instance;
		UObject owner = this.Owner;
		FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref this.TargetPosition));
		string path = this.Paths[0];
		ABaseCharacter owner2 = this.Owner;
		TsBaseCharacter tsBaseCharacter = owner2 as TsBaseCharacter;
		int entityId;
		if (tsBaseCharacter == null)
		{
			TsBaseVehicle tsBaseVehicle = owner2 as TsBaseVehicle;
			if (tsBaseVehicle == null)
			{
				<PrivateImplementationDetails>.ThrowSwitchExpressionException(owner2);
			}
			else
			{
				entityId = tsBaseVehicle.EntityId;
			}
		}
		else
		{
			entityId = tsBaseCharacter.EntityId;
		}
		int num = instance.SpawnEffect(owner, ftransformDouble, path, "[GameplayCueEffectCommonItem.CreateEffect]", new EffectContext(new int?(entityId), null, false), EEffectType.Fight, null, null, null, false, false);
		this.EffectActor = EffectSystem.Instance.GetEffectActor(num);
		return num;
	}

	// Token: 0x0400C3A4 RID: 50084
	private int EffectViewHandle;

	// Token: 0x0400C3A5 RID: 50085
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private OneOf<KuroEffectActorHandle, AActor> EffectActor;

	// Token: 0x0400C3A6 RID: 50086
	private bool IsVisible = true;

	// Token: 0x0400C3A7 RID: 50087
	private readonly ABaseCharacter Owner;

	// Token: 0x0400C3A8 RID: 50088
	public readonly FVectorDouble TargetPosition;

	// Token: 0x0400C3A9 RID: 50089
	public readonly string[] Paths;
}
