using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;

// Token: 0x02002715 RID: 10005
[NullableContext(1)]
[Nullable(0)]
public abstract class GameplayAbilityVisionBase
{
	// Token: 0x06019164 RID: 102756 RVA: 0x007A5435 File Offset: 0x007A3635
	protected GameplayAbilityVisionBase(CharacterVisionComponent visionComponent)
	{
		this.VisionComponent = visionComponent;
	}

	// Token: 0x06019165 RID: 102757 RVA: 0x007A5444 File Offset: 0x007A3644
	public static GameplayAbilityVisionBase Spawn(Func<CharacterVisionComponent, GameplayAbilityVisionBase> visionCtor, CharacterVisionComponent visionComponent)
	{
		GameplayAbilityVisionBase gameplayAbilityVisionBase = visionCtor(visionComponent);
		gameplayAbilityVisionBase.Create();
		return gameplayAbilityVisionBase;
	}

	// Token: 0x06019166 RID: 102758 RVA: 0x007A5453 File Offset: 0x007A3653
	public void Create()
	{
		this.OnCreate();
	}

	// Token: 0x06019167 RID: 102759 RVA: 0x007A545B File Offset: 0x007A365B
	public void Destroy()
	{
		this.OnDestroy();
	}

	// Token: 0x06019168 RID: 102760 RVA: 0x007A5463 File Offset: 0x007A3663
	public void Tick(float delta)
	{
		this.OnTick(delta);
	}

	// Token: 0x06019169 RID: 102761 RVA: 0x007A546C File Offset: 0x007A366C
	public bool ActivateAbility()
	{
		return this.OnActivateAbility();
	}

	// Token: 0x0601916A RID: 102762 RVA: 0x007A5474 File Offset: 0x007A3674
	public bool EndAbility()
	{
		return this.OnEndAbility();
	}

	// Token: 0x0601916B RID: 102763 RVA: 0x007A547C File Offset: 0x007A367C
	public virtual bool HandlePress(EInputAction action, float time)
	{
		return false;
	}

	// Token: 0x0601916C RID: 102764 RVA: 0x007A547F File Offset: 0x007A367F
	public void TeleportStart()
	{
		this.OnTeleportStart();
	}

	// Token: 0x0601916D RID: 102765 RVA: 0x007A5487 File Offset: 0x007A3687
	protected virtual void OnCreate()
	{
	}

	// Token: 0x0601916E RID: 102766 RVA: 0x007A5489 File Offset: 0x007A3689
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x0601916F RID: 102767 RVA: 0x007A548B File Offset: 0x007A368B
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x06019170 RID: 102768 RVA: 0x007A548D File Offset: 0x007A368D
	protected virtual bool OnActivateAbility()
	{
		return true;
	}

	// Token: 0x06019171 RID: 102769 RVA: 0x007A5490 File Offset: 0x007A3690
	protected virtual bool OnEndAbility()
	{
		return true;
	}

	// Token: 0x06019172 RID: 102770 RVA: 0x007A5493 File Offset: 0x007A3693
	protected virtual void OnTeleportStart()
	{
	}

	// Token: 0x170027D5 RID: 10197
	// (get) Token: 0x06019173 RID: 102771 RVA: 0x007A5495 File Offset: 0x007A3695
	protected Entity Entity
	{
		get
		{
			return this.VisionComponent.Entity;
		}
	}

	// Token: 0x170027D6 RID: 10198
	// (get) Token: 0x06019174 RID: 102772 RVA: 0x007A54A2 File Offset: 0x007A36A2
	[Nullable(2)]
	protected EntityHandle EntityHandle
	{
		[NullableContext(2)]
		get
		{
			return CreatureModel.Instance.GetEntityById(this.VisionComponent.Entity.Id);
		}
	}

	// Token: 0x170027D7 RID: 10199
	// (get) Token: 0x06019175 RID: 102773 RVA: 0x007A54BE File Offset: 0x007A36BE
	protected CreatureDataComponent CreatureDataComponent
	{
		get
		{
			return this.Entity.GetComponent<CreatureDataComponent>();
		}
	}

	// Token: 0x170027D8 RID: 10200
	// (get) Token: 0x06019176 RID: 102774 RVA: 0x007A54CB File Offset: 0x007A36CB
	protected CharacterActorComponent ActorComponent
	{
		get
		{
			return this.Entity.GetComponent<CharacterActorComponent>();
		}
	}

	// Token: 0x170027D9 RID: 10201
	// (get) Token: 0x06019177 RID: 102775 RVA: 0x007A54D8 File Offset: 0x007A36D8
	protected BaseAttributeComponent AttributeComponent
	{
		get
		{
			return this.Entity.GetComponent<BaseAttributeComponent>();
		}
	}

	// Token: 0x170027DA RID: 10202
	// (get) Token: 0x06019178 RID: 102776 RVA: 0x007A54E5 File Offset: 0x007A36E5
	protected BaseTagComponent GameplayTagComponent
	{
		get
		{
			return this.Entity.GetComponent<BaseTagComponent>();
		}
	}

	// Token: 0x170027DB RID: 10203
	// (get) Token: 0x06019179 RID: 102777 RVA: 0x007A54F2 File Offset: 0x007A36F2
	protected CharacterSkillComponent SkillComponent
	{
		get
		{
			return this.Entity.GetComponent<CharacterSkillComponent>();
		}
	}

	// Token: 0x170027DC RID: 10204
	// (get) Token: 0x0601917A RID: 102778 RVA: 0x007A54FF File Offset: 0x007A36FF
	protected CharacterBuffComponent BuffComponent
	{
		get
		{
			return this.Entity.GetComponent<CharacterBuffComponent>();
		}
	}

	// Token: 0x170027DD RID: 10205
	// (get) Token: 0x0601917B RID: 102779 RVA: 0x007A550C File Offset: 0x007A370C
	protected CharacterMoveComponent MoveComponent
	{
		get
		{
			return this.Entity.GetComponent<CharacterMoveComponent>();
		}
	}

	// Token: 0x170027DE RID: 10206
	// (get) Token: 0x0601917C RID: 102780 RVA: 0x007A5519 File Offset: 0x007A3719
	protected CharacterAudioComponent AudioComponent
	{
		get
		{
			return this.Entity.GetComponent<CharacterAudioComponent>();
		}
	}

	// Token: 0x170027DF RID: 10207
	// (get) Token: 0x0601917D RID: 102781 RVA: 0x007A5526 File Offset: 0x007A3726
	protected RoleTeamComponent TeamComponent
	{
		get
		{
			return this.Entity.GetComponent<RoleTeamComponent>();
		}
	}

	// Token: 0x170027E0 RID: 10208
	// (get) Token: 0x0601917E RID: 102782 RVA: 0x007A5533 File Offset: 0x007A3733
	protected CharacterGameplayCueComponent CueComponent
	{
		get
		{
			return this.Entity.GetComponent<CharacterGameplayCueComponent>();
		}
	}

	// Token: 0x0400DB10 RID: 56080
	protected readonly CharacterVisionComponent VisionComponent;
}
