using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;

// Token: 0x020031A6 RID: 12710
[NullableContext(1)]
[Nullable(0)]
public abstract class GameplayAbilityVisionBase
{
	// Token: 0x0601B636 RID: 112182 RVA: 0x0077D157 File Offset: 0x0077B357
	protected GameplayAbilityVisionBase(CharacterVisionComponent visionComponent)
	{
		this.VisionComponent = visionComponent;
	}

	// Token: 0x0601B637 RID: 112183 RVA: 0x0077D166 File Offset: 0x0077B366
	public static GameplayAbilityVisionBase Spawn(Func<CharacterVisionComponent, GameplayAbilityVisionBase> visionCtor, CharacterVisionComponent visionComponent)
	{
		GameplayAbilityVisionBase gameplayAbilityVisionBase = visionCtor(visionComponent);
		gameplayAbilityVisionBase.Create();
		return gameplayAbilityVisionBase;
	}

	// Token: 0x0601B638 RID: 112184 RVA: 0x0077D175 File Offset: 0x0077B375
	public void Create()
	{
		this.OnCreate();
	}

	// Token: 0x0601B639 RID: 112185 RVA: 0x0077D17D File Offset: 0x0077B37D
	public void Destroy()
	{
		this.OnDestroy();
	}

	// Token: 0x0601B63A RID: 112186 RVA: 0x0077D185 File Offset: 0x0077B385
	public void Tick(float delta)
	{
		this.OnTick(delta);
	}

	// Token: 0x0601B63B RID: 112187 RVA: 0x0077D18E File Offset: 0x0077B38E
	public bool ActivateAbility()
	{
		return this.OnActivateAbility();
	}

	// Token: 0x0601B63C RID: 112188 RVA: 0x0077D196 File Offset: 0x0077B396
	public bool EndAbility()
	{
		return this.OnEndAbility();
	}

	// Token: 0x0601B63D RID: 112189 RVA: 0x0077D19E File Offset: 0x0077B39E
	public virtual bool HandlePress(EInputAction action, float time)
	{
		return false;
	}

	// Token: 0x0601B63E RID: 112190 RVA: 0x0077D1A1 File Offset: 0x0077B3A1
	public void TeleportStart()
	{
		this.OnTeleportStart();
	}

	// Token: 0x0601B63F RID: 112191 RVA: 0x0077D1A9 File Offset: 0x0077B3A9
	protected virtual void OnCreate()
	{
	}

	// Token: 0x0601B640 RID: 112192 RVA: 0x0077D1AB File Offset: 0x0077B3AB
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x0601B641 RID: 112193 RVA: 0x0077D1AD File Offset: 0x0077B3AD
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x0601B642 RID: 112194 RVA: 0x0077D1AF File Offset: 0x0077B3AF
	protected virtual bool OnActivateAbility()
	{
		return true;
	}

	// Token: 0x0601B643 RID: 112195 RVA: 0x0077D1B2 File Offset: 0x0077B3B2
	protected virtual bool OnEndAbility()
	{
		return true;
	}

	// Token: 0x0601B644 RID: 112196 RVA: 0x0077D1B5 File Offset: 0x0077B3B5
	protected virtual void OnTeleportStart()
	{
	}

	// Token: 0x170025D9 RID: 9689
	// (get) Token: 0x0601B645 RID: 112197 RVA: 0x0077D1B7 File Offset: 0x0077B3B7
	protected Entity Entity
	{
		get
		{
			return this.VisionComponent.Entity;
		}
	}

	// Token: 0x170025DA RID: 9690
	// (get) Token: 0x0601B646 RID: 112198 RVA: 0x0077D1C4 File Offset: 0x0077B3C4
	[Nullable(2)]
	protected EntityHandle EntityHandle
	{
		[NullableContext(2)]
		get
		{
			return CreatureModel.Instance.GetEntityById(this.VisionComponent.Entity.Id);
		}
	}

	// Token: 0x170025DB RID: 9691
	// (get) Token: 0x0601B647 RID: 112199 RVA: 0x0077D1E0 File Offset: 0x0077B3E0
	protected CreatureDataComponent CreatureDataComponent
	{
		get
		{
			return this.Entity.GetComponent<CreatureDataComponent>();
		}
	}

	// Token: 0x170025DC RID: 9692
	// (get) Token: 0x0601B648 RID: 112200 RVA: 0x0077D1ED File Offset: 0x0077B3ED
	protected CharacterActorComponent ActorComponent
	{
		get
		{
			return this.Entity.GetComponent<CharacterActorComponent>();
		}
	}

	// Token: 0x170025DD RID: 9693
	// (get) Token: 0x0601B649 RID: 112201 RVA: 0x0077D1FA File Offset: 0x0077B3FA
	protected BaseAttributeComponent AttributeComponent
	{
		get
		{
			return this.Entity.GetComponent<BaseAttributeComponent>();
		}
	}

	// Token: 0x170025DE RID: 9694
	// (get) Token: 0x0601B64A RID: 112202 RVA: 0x0077D207 File Offset: 0x0077B407
	protected BaseTagComponent GameplayTagComponent
	{
		get
		{
			return this.Entity.GetComponent<BaseTagComponent>();
		}
	}

	// Token: 0x170025DF RID: 9695
	// (get) Token: 0x0601B64B RID: 112203 RVA: 0x0077D214 File Offset: 0x0077B414
	protected CharacterSkillComponent SkillComponent
	{
		get
		{
			return this.Entity.GetComponent<CharacterSkillComponent>();
		}
	}

	// Token: 0x170025E0 RID: 9696
	// (get) Token: 0x0601B64C RID: 112204 RVA: 0x0077D221 File Offset: 0x0077B421
	protected CharacterBuffComponent BuffComponent
	{
		get
		{
			return this.Entity.GetComponent<CharacterBuffComponent>();
		}
	}

	// Token: 0x170025E1 RID: 9697
	// (get) Token: 0x0601B64D RID: 112205 RVA: 0x0077D22E File Offset: 0x0077B42E
	protected CharacterMoveComponent MoveComponent
	{
		get
		{
			return this.Entity.GetComponent<CharacterMoveComponent>();
		}
	}

	// Token: 0x170025E2 RID: 9698
	// (get) Token: 0x0601B64E RID: 112206 RVA: 0x0077D23B File Offset: 0x0077B43B
	protected CharacterAudioComponent AudioComponent
	{
		get
		{
			return this.Entity.GetComponent<CharacterAudioComponent>();
		}
	}

	// Token: 0x170025E3 RID: 9699
	// (get) Token: 0x0601B64F RID: 112207 RVA: 0x0077D248 File Offset: 0x0077B448
	protected RoleTeamComponent TeamComponent
	{
		get
		{
			return this.Entity.GetComponent<RoleTeamComponent>();
		}
	}

	// Token: 0x170025E4 RID: 9700
	// (get) Token: 0x0601B650 RID: 112208 RVA: 0x0077D255 File Offset: 0x0077B455
	protected CharacterGameplayCueComponent CueComponent
	{
		get
		{
			return this.Entity.GetComponent<CharacterGameplayCueComponent>();
		}
	}

	// Token: 0x0400D68A RID: 54922
	protected readonly CharacterVisionComponent VisionComponent;
}
