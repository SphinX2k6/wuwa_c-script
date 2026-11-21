using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;

// Token: 0x020025F9 RID: 9721
[NullableContext(2)]
[Nullable(0)]
public class CharacterDitherEffectController
{
	// Token: 0x17002620 RID: 9760
	// (get) Token: 0x060184D6 RID: 99542 RVA: 0x00754386 File Offset: 0x00752586
	private bool IsHiddenInGame
	{
		get
		{
			return this.Actor == null || !this.Actor.IsValid() || this.Actor.bHidden;
		}
	}

	// Token: 0x17002621 RID: 9761
	// (get) Token: 0x060184D7 RID: 99543 RVA: 0x007543AA File Offset: 0x007525AA
	public double CurrentDitherValue
	{
		get
		{
			return (double)this.CurrentDither;
		}
	}

	// Token: 0x17002622 RID: 9762
	// (get) Token: 0x060184D8 RID: 99544 RVA: 0x007543B3 File Offset: 0x007525B3
	public bool IsInAutoAnimationValue
	{
		get
		{
			return this.IsInAutoAnimation;
		}
	}

	// Token: 0x17002623 RID: 9763
	// (get) Token: 0x060184D9 RID: 99545 RVA: 0x007543BB File Offset: 0x007525BB
	public float DitherSpeedRateValue
	{
		get
		{
			return this.DitherSpeedRate;
		}
	}

	// Token: 0x17002624 RID: 9764
	// (get) Token: 0x060184DA RID: 99546 RVA: 0x007543C3 File Offset: 0x007525C3
	public bool IsDisableValue
	{
		get
		{
			return this.IsDisable;
		}
	}

	// Token: 0x060184DB RID: 99547 RVA: 0x007543CC File Offset: 0x007525CC
	[NullableContext(1)]
	public CharacterDitherEffectController(AActor actor, CharRenderingComponent charRenderingComponent)
	{
		this.Actor = actor;
		TsBaseCharacter tsBaseCharacter = actor as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			this.Entity = tsBaseCharacter.GetEntityNoBlueprint();
		}
		else
		{
			TsBaseVehicle tsBaseVehicle = actor as TsBaseVehicle;
			if (tsBaseVehicle != null)
			{
				this.Entity = tsBaseVehicle.GetEntityNoBlueprint();
			}
		}
		this.CharRenderingComponent = charRenderingComponent;
		if (!ObjectUtils.IsValid(this.CharRenderingComponent))
		{
			this.IsDisable = false;
		}
	}

	// Token: 0x060184DC RID: 99548 RVA: 0x00754448 File Offset: 0x00752648
	public void SetIsDisable(bool isDisable, ECharacterDitherType ditherType = ECharacterDitherType.Temporary)
	{
		if (this.IsDisable == isDisable)
		{
			return;
		}
		this.IsDisable = isDisable;
		if (isDisable)
		{
			this.SetHiddenInGame(true, false);
			return;
		}
		if (!this.IsInAutoAnimation && MathUtils.Instance.IsNearlyZero((double)this.CurrentDither, new double?(0.0001)))
		{
			this.SetHiddenInGame(true, false);
		}
		else
		{
			this.SetHiddenInGame(false, false);
		}
		if (this.CurrentDitherType != ECharacterDitherType.UnDefined)
		{
			CharRenderingComponent charRenderingComponent = this.CharRenderingComponent;
			if (charRenderingComponent == null)
			{
				return;
			}
			charRenderingComponent.SetDitherEffect(this.CurrentDither, this.CurrentDitherType);
		}
	}

	// Token: 0x060184DD RID: 99549 RVA: 0x007544D4 File Offset: 0x007526D4
	public void EnterAppearEffect(float ditherSpeedRate = 1f, ECharacterDitherType ditherType = ECharacterDitherType.Temporary, bool replay = true)
	{
		if (this.IsHiddenInGame)
		{
			this.SetHiddenInGame(false, true);
		}
		this.HasForceUpdated = false;
		this.IsInAutoAnimation = true;
		this.CurrentDitherType = ditherType;
		this.DitherSpeedRate = ditherSpeedRate;
		if (replay)
		{
			this.CurrentDither = 0f;
			CharRenderingComponent charRenderingComponent = this.CharRenderingComponent;
			if (charRenderingComponent == null)
			{
				return;
			}
			charRenderingComponent.SetDitherEffect(this.CurrentDither, this.CurrentDitherType);
		}
	}

	// Token: 0x060184DE RID: 99550 RVA: 0x00754538 File Offset: 0x00752738
	public void EnterDisappearEffect(float ditherSpeedRate = 1f, ECharacterDitherType ditherType = ECharacterDitherType.Temporary, bool replay = true)
	{
		if (this.IsHiddenInGame)
		{
			this.CurrentDither = 0f;
			this.CurrentDitherType = ditherType;
			this.ForceUpdate();
			return;
		}
		this.IsInAutoAnimation = true;
		this.CurrentDitherType = ditherType;
		this.DitherSpeedRate = -ditherSpeedRate;
		if (replay)
		{
			this.CurrentDither = 1f;
			CharRenderingComponent charRenderingComponent = this.CharRenderingComponent;
			if (charRenderingComponent == null)
			{
				return;
			}
			charRenderingComponent.SetDitherEffect(this.CurrentDither, this.CurrentDitherType);
		}
	}

	// Token: 0x060184DF RID: 99551 RVA: 0x007545A8 File Offset: 0x007527A8
	public void SetDitherEffect(double dither, ECharacterDitherType ditherType = ECharacterDitherType.Temporary, bool clearAnimationState = true)
	{
		if (this.IsInAutoAnimation && ditherType < this.CurrentDitherType)
		{
			return;
		}
		this.CurrentDither = (float)MathUtils.Instance.Clamp(dither, 0.0, 1.0);
		this.CurrentDitherType = ditherType;
		if (this.IsDisable)
		{
			return;
		}
		this.SetHiddenInGame(MathUtils.Instance.IsNearlyZero((double)this.CurrentDither, new double?(0.0001)), clearAnimationState);
		CharRenderingComponent charRenderingComponent = this.CharRenderingComponent;
		if (charRenderingComponent == null)
		{
			return;
		}
		charRenderingComponent.SetDitherEffect(this.CurrentDither, ditherType);
	}

	// Token: 0x060184E0 RID: 99552 RVA: 0x00754638 File Offset: 0x00752838
	public void SetHiddenInGame(bool isHiddenInGame, bool clearAnimationState)
	{
		if (this.Actor == null)
		{
			return;
		}
		if (this.Entity != null)
		{
			BaseActorComponent component = this.Entity.GetComponent<BaseActorComponent>();
			if (component == null)
			{
				return;
			}
			if (isHiddenInGame)
			{
				if (this.DisableActorHandle != null)
				{
					return;
				}
				this.DisableActorHandle = new int?(component.DisableActor("[CharacterDitherEffectController.SetHiddenInGame]"));
				NpcPerformComponent component2 = this.Entity.GetComponent<NpcPerformComponent>();
				if (component2 == null || !component2.IsNpcOutShowRange)
				{
					this.DisableCollisionHandle = new int?(component.DisableCollision("[CharacterDitherEffectController.SetHiddenInGame]"));
				}
			}
			else
			{
				if (this.DisableActorHandle != null)
				{
					component.EnableActor(this.DisableActorHandle.Value);
					this.DisableActorHandle = null;
				}
				if (this.DisableCollisionHandle != null)
				{
					component.EnableCollision(this.DisableCollisionHandle.Value);
					this.DisableCollisionHandle = null;
				}
			}
		}
		else if (this.Actor.IsValid())
		{
			if (this.IsHiddenInGame == isHiddenInGame)
			{
				return;
			}
			this.Actor.SetActorHiddenInGame(isHiddenInGame);
			this.Actor.SetActorEnableCollision(!isHiddenInGame);
		}
		if (isHiddenInGame && clearAnimationState && this.IsInAutoAnimation)
		{
			this.IsInAutoAnimation = false;
			this.CurrentDither = 0f;
		}
	}

	// Token: 0x060184E1 RID: 99553 RVA: 0x00754774 File Offset: 0x00752974
	public void Update(float deltaTime)
	{
		if (!this.IsDisable && this.IsInAutoAnimation)
		{
			float ditherDelta = deltaTime * 0.001f * this.DitherSpeedRate;
			this.AddDitherEffectInternal(ditherDelta, this.CurrentDitherType);
		}
	}

	// Token: 0x060184E2 RID: 99554 RVA: 0x007547B0 File Offset: 0x007529B0
	private void ForceUpdate()
	{
		if (this.HasForceUpdated)
		{
			return;
		}
		this.HasForceUpdated = true;
		this.SetHiddenInGame(MathUtils.Instance.IsNearlyZero((double)this.CurrentDither, new double?(0.0001)), true);
		CharRenderingComponent charRenderingComponent = this.CharRenderingComponent;
		if (charRenderingComponent != null)
		{
			charRenderingComponent.SetDitherEffect(this.CurrentDither, this.CurrentDitherType);
		}
		CharRenderingComponent charRenderingComponent2 = this.CharRenderingComponent;
		if (charRenderingComponent2 == null)
		{
			return;
		}
		charRenderingComponent2.UpdateMaterialEffectsOnly();
	}

	// Token: 0x060184E3 RID: 99555 RVA: 0x00754820 File Offset: 0x00752A20
	public void ForceResetDither()
	{
		this.CurrentDither = 0f;
		this.CurrentDitherType = ECharacterDitherType.Fight;
		this.ForceUpdate();
	}

	// Token: 0x060184E4 RID: 99556 RVA: 0x0075483C File Offset: 0x00752A3C
	private void AddDitherEffectInternal(float ditherDelta, ECharacterDitherType ditherType)
	{
		this.CurrentDither = MathUtils.Instance.Clamp(this.CurrentDither + ditherDelta, 0f, 1f);
		if (this.CurrentDither == 0f && ditherDelta < 0f)
		{
			this.IsInAutoAnimation = false;
			this.SetHiddenInGame(true, true);
		}
		else if (this.CurrentDither == 1f && ditherDelta > 0f)
		{
			this.IsInAutoAnimation = false;
		}
		CharRenderingComponent charRenderingComponent = this.CharRenderingComponent;
		if (charRenderingComponent == null)
		{
			return;
		}
		charRenderingComponent.SetDitherEffect(this.CurrentDither, ditherType);
	}

	// Token: 0x060184E5 RID: 99557 RVA: 0x007548C4 File Offset: 0x00752AC4
	public void Clear()
	{
		this.Actor = null;
		if (this.CharRenderingComponent != null)
		{
			this.CharRenderingComponent.ResetAllRenderingState();
		}
		this.CharRenderingComponent = null;
		this.DisableActorHandle = null;
		this.DisableCollisionHandle = null;
	}

	// Token: 0x0400D1A5 RID: 53669
	private const float MILLISECOND_TO_SECOND = 0.001f;

	// Token: 0x0400D1A6 RID: 53670
	private AActor Actor;

	// Token: 0x0400D1A7 RID: 53671
	private Entity Entity;

	// Token: 0x0400D1A8 RID: 53672
	private CharRenderingComponent CharRenderingComponent;

	// Token: 0x0400D1A9 RID: 53673
	private bool IsInAutoAnimation;

	// Token: 0x0400D1AA RID: 53674
	private float CurrentDither = 1f;

	// Token: 0x0400D1AB RID: 53675
	private ECharacterDitherType CurrentDitherType;

	// Token: 0x0400D1AC RID: 53676
	private float DitherSpeedRate = 1f;

	// Token: 0x0400D1AD RID: 53677
	private bool IsDisable;

	// Token: 0x0400D1AE RID: 53678
	private int? DisableActorHandle;

	// Token: 0x0400D1AF RID: 53679
	private int? DisableCollisionHandle;

	// Token: 0x0400D1B0 RID: 53680
	private bool HasForceUpdated;
}
