using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;

// Token: 0x020030A2 RID: 12450
[NullableContext(2)]
[Nullable(0)]
public class CharacterDitherEffectController
{
	// Token: 0x170024A2 RID: 9378
	// (get) Token: 0x0601AACD RID: 109261 RVA: 0x0072EE4B File Offset: 0x0072D04B
	private bool IsHiddenInGame
	{
		get
		{
			return this.Actor == null || !this.Actor.IsValid() || this.Actor.bHidden;
		}
	}

	// Token: 0x170024A3 RID: 9379
	// (get) Token: 0x0601AACE RID: 109262 RVA: 0x0072EE6F File Offset: 0x0072D06F
	public double CurrentDitherValue
	{
		get
		{
			return (double)this.CurrentDither;
		}
	}

	// Token: 0x170024A4 RID: 9380
	// (get) Token: 0x0601AACF RID: 109263 RVA: 0x0072EE78 File Offset: 0x0072D078
	public bool IsInAutoAnimationValue
	{
		get
		{
			return this.IsInAutoAnimation;
		}
	}

	// Token: 0x170024A5 RID: 9381
	// (get) Token: 0x0601AAD0 RID: 109264 RVA: 0x0072EE80 File Offset: 0x0072D080
	public float DitherSpeedRateValue
	{
		get
		{
			return this.DitherSpeedRate;
		}
	}

	// Token: 0x170024A6 RID: 9382
	// (get) Token: 0x0601AAD1 RID: 109265 RVA: 0x0072EE88 File Offset: 0x0072D088
	public bool IsDisableValue
	{
		get
		{
			return this.IsDisable;
		}
	}

	// Token: 0x0601AAD2 RID: 109266 RVA: 0x0072EE90 File Offset: 0x0072D090
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

	// Token: 0x0601AAD3 RID: 109267 RVA: 0x0072EF0C File Offset: 0x0072D10C
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

	// Token: 0x0601AAD4 RID: 109268 RVA: 0x0072EF98 File Offset: 0x0072D198
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

	// Token: 0x0601AAD5 RID: 109269 RVA: 0x0072EFFC File Offset: 0x0072D1FC
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

	// Token: 0x0601AAD6 RID: 109270 RVA: 0x0072F06C File Offset: 0x0072D26C
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

	// Token: 0x0601AAD7 RID: 109271 RVA: 0x0072F0FC File Offset: 0x0072D2FC
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

	// Token: 0x0601AAD8 RID: 109272 RVA: 0x0072F238 File Offset: 0x0072D438
	public void Update(float deltaTime)
	{
		if (!this.IsDisable && this.IsInAutoAnimation)
		{
			float ditherDelta = deltaTime * 0.001f * this.DitherSpeedRate;
			this.AddDitherEffectInternal(ditherDelta, this.CurrentDitherType);
		}
	}

	// Token: 0x0601AAD9 RID: 109273 RVA: 0x0072F274 File Offset: 0x0072D474
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

	// Token: 0x0601AADA RID: 109274 RVA: 0x0072F2E4 File Offset: 0x0072D4E4
	public void ForceResetDither()
	{
		this.CurrentDither = 0f;
		this.CurrentDitherType = ECharacterDitherType.Fight;
		this.ForceUpdate();
	}

	// Token: 0x0601AADB RID: 109275 RVA: 0x0072F300 File Offset: 0x0072D500
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

	// Token: 0x0601AADC RID: 109276 RVA: 0x0072F388 File Offset: 0x0072D588
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

	// Token: 0x0400CDC2 RID: 52674
	private const float MILLISECOND_TO_SECOND = 0.001f;

	// Token: 0x0400CDC3 RID: 52675
	private AActor Actor;

	// Token: 0x0400CDC4 RID: 52676
	private Entity Entity;

	// Token: 0x0400CDC5 RID: 52677
	private CharRenderingComponent CharRenderingComponent;

	// Token: 0x0400CDC6 RID: 52678
	private bool IsInAutoAnimation;

	// Token: 0x0400CDC7 RID: 52679
	private float CurrentDither = 1f;

	// Token: 0x0400CDC8 RID: 52680
	private ECharacterDitherType CurrentDitherType;

	// Token: 0x0400CDC9 RID: 52681
	private float DitherSpeedRate = 1f;

	// Token: 0x0400CDCA RID: 52682
	private bool IsDisable;

	// Token: 0x0400CDCB RID: 52683
	private int? DisableActorHandle;

	// Token: 0x0400CDCC RID: 52684
	private int? DisableCollisionHandle;

	// Token: 0x0400CDCD RID: 52685
	private bool HasForceUpdated;
}
