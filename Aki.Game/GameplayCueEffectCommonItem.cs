using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x020024FE RID: 9470
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueEffectCommonItem
{
	// Token: 0x06017714 RID: 96020 RVA: 0x006EA1E6 File Offset: 0x006E83E6
	private GameplayCueEffectCommonItem(ABaseCharacter owner, FVectorDouble targetPosition, string[] paths)
	{
		this.Owner = owner;
		this.TargetPosition = targetPosition;
		this.Paths = paths;
	}

	// Token: 0x06017715 RID: 96021 RVA: 0x006EA20C File Offset: 0x006E840C
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

	// Token: 0x06017716 RID: 96022 RVA: 0x006EA248 File Offset: 0x006E8448
	public void Destroy()
	{
		this.EffectActor.Clear();
		if (EffectSystem.Instance.IsValid(this.EffectViewHandle))
		{
			EffectSystem.Instance.StopEffectById(this.EffectViewHandle, "[GameplayCueEffectCommonItem.Destroy]", true, null);
		}
	}

	// Token: 0x06017717 RID: 96023 RVA: 0x006EA294 File Offset: 0x006E8494
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

	// Token: 0x06017718 RID: 96024 RVA: 0x006EA312 File Offset: 0x006E8512
	public void SetVisible(bool visible)
	{
		if (this.IsVisible == visible)
		{
			return;
		}
		this.IsVisible = visible;
		this.EffectActor.SetActorHiddenInGame(!visible);
	}

	// Token: 0x06017719 RID: 96025 RVA: 0x006EA334 File Offset: 0x006E8534
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

	// Token: 0x0400C74D RID: 51021
	private int EffectViewHandle;

	// Token: 0x0400C74E RID: 51022
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private OneOf<KuroEffectActorHandle, AActor> EffectActor;

	// Token: 0x0400C74F RID: 51023
	private bool IsVisible = true;

	// Token: 0x0400C750 RID: 51024
	private readonly ABaseCharacter Owner;

	// Token: 0x0400C751 RID: 51025
	public readonly FVectorDouble TargetPosition;

	// Token: 0x0400C752 RID: 51026
	public readonly string[] Paths;
}
