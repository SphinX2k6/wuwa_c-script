using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Audio;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02003236 RID: 12854
[NullableContext(1)]
[Nullable(0)]
public class RoleAudioComponent : CharacterAudioComponent, IStaticVariableResetter
{
	// Token: 0x0601BB7A RID: 113530 RVA: 0x007A11B3 File Offset: 0x0079F3B3
	static RoleAudioComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleAudioComponent.CreateStaticDefaultValue), new Action(RoleAudioComponent.ResetStaticDefaultValue));
	}

	// Token: 0x0601BB7B RID: 113531 RVA: 0x007A11D4 File Offset: 0x0079F3D4
	public static void CreateStaticDefaultValue()
	{
		RoleAudioComponent.FootstepVariantMap = new Dictionary<E_FootstepVariant, string>
		{
			{
				E_FootstepVariant.land,
				"land"
			},
			{
				E_FootstepVariant.run,
				"run"
			},
			{
				E_FootstepVariant.runstop,
				"runstop"
			},
			{
				E_FootstepVariant.sprint,
				"sprint"
			},
			{
				E_FootstepVariant.sprintstop,
				"sprintstop"
			},
			{
				E_FootstepVariant.walk,
				"walk"
			},
			{
				E_FootstepVariant.walkstop,
				"walkstop"
			},
			{
				E_FootstepVariant.turnback,
				"turnback"
			}
		};
		RoleAudioComponent.FoleyVariantMap = new Dictionary<E_FoleyVariant, string>
		{
			{
				E_FoleyVariant.bodyfall,
				"bodyfall"
			},
			{
				E_FoleyVariant.fly,
				"fly"
			},
			{
				E_FoleyVariant.run,
				"run"
			},
			{
				E_FoleyVariant.sprint,
				"sprint"
			},
			{
				E_FoleyVariant.hard,
				"hard"
			},
			{
				E_FoleyVariant.hardfast,
				"hardfast"
			},
			{
				E_FoleyVariant.weak,
				"weak"
			},
			{
				E_FoleyVariant.weakfast,
				"weakfast"
			}
		};
		RoleAudioComponent.LastTickTime = 0.0;
		RoleAudioComponent.LocationCache = global::Vector.Create();
	}

	// Token: 0x0601BB7C RID: 113532 RVA: 0x007A12CD File Offset: 0x0079F4CD
	public static void ResetStaticDefaultValue()
	{
		RoleAudioComponent.FootstepVariantMap = null;
		RoleAudioComponent.FoleyVariantMap = null;
		RoleAudioComponent.LastTickTime = 0.0;
		RoleAudioComponent.LocationCache = null;
	}

	// Token: 0x0601BB7D RID: 113533 RVA: 0x007A12F0 File Offset: 0x0079F4F0
	protected override bool OnInit()
	{
		base.OnInit();
		this.LoadConfig();
		this.StateComp = base.Entity.CheckGetComponent<CharacterUnifiedStateComponent>();
		this.AttributeComponent = base.Entity.CheckGetComponent<BaseAttributeComponent>();
		if (this.Config != null)
		{
			EventSystem.Instance.Add(EEventName.OnRoleSkinChange, new Action<int>(this.OnRoleSkinChanged));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnBeDamage));
			EventSystem.Instance.AddWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
			EventSystem.Instance.AddWithTarget<int, int>(base.Entity, EEventName.CharUseSkillRemote, new Action<int, int>(this.OnUseSkillRemote));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnRoleGoDownFinish, new Action(this.OnGoDownFinish));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharPossessed, new Action<Entity, AController>(this.OnCharPossessed));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharUnpossessed, new Action<Entity, AController>(this.OnCharUnpossessed));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnInteractionWaterTypeChange, new Action<EInteractionWaterType>(this.OnInteractionWaterTypeChange));
			EventSystem.Instance.AddWithTarget<int, EMovementMode, EMovementMode, byte, byte>(base.Entity, EEventName.CharMovementModeChanged, new Action<int, EMovementMode, EMovementMode, byte, byte>(this.OnCharacterMovementModeChanged));
		}
		return true;
	}

	// Token: 0x0601BB7E RID: 113534 RVA: 0x007A1460 File Offset: 0x0079F660
	protected override bool OnEnd()
	{
		base.OnEnd();
		this.PostGoDownFinishEvent();
		return true;
	}

	// Token: 0x0601BB7F RID: 113535 RVA: 0x007A1470 File Offset: 0x0079F670
	protected override bool OnClear()
	{
		base.OnClear();
		if (this.Config != null)
		{
			EventSystem.Instance.Remove(EEventName.OnRoleSkinChange, new Action<int>(this.OnRoleSkinChanged));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnBeDamage));
			EventSystem.Instance.RemoveWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharUseSkillRemote, new Action<int, int>(this.OnUseSkillRemote));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnRoleGoDownFinish, new Action(this.OnGoDownFinish));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharPossessed, new Action<Entity, AController>(this.OnCharPossessed));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharUnpossessed, new Action<Entity, AController>(this.OnCharUnpossessed));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnInteractionWaterTypeChange, new Action<EInteractionWaterType>(this.OnInteractionWaterTypeChange));
			EventSystem.Instance.RemoveWithTarget<int, EMovementMode, EMovementMode, byte, byte>(base.Entity, EEventName.CharMovementModeChanged, new Action<int, EMovementMode, EMovementMode, byte, byte>(this.OnCharacterMovementModeChanged));
		}
		return true;
	}

	// Token: 0x0601BB80 RID: 113536 RVA: 0x007A15B8 File Offset: 0x0079F7B8
	protected override bool OnStart()
	{
		base.OnStart();
		this.ChangeRoleName((((this.Config != null) ? this.Config.GetValueOrDefault().Name : null) != null) ? this.Config.Value.Name : "chixia");
		this.SetAudioMoveState(EMoveState.None);
		return true;
	}

	// Token: 0x0601BB81 RID: 113537 RVA: 0x007A161C File Offset: 0x0079F81C
	protected override void OnTick(float delta)
	{
		int id = base.Entity.Id;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		int? num = (baseCharacter != null) ? new int?(baseCharacter.EntityId) : null;
		if ((id == num.GetValueOrDefault() & num != null) && Time.Instance.Now - RoleAudioComponent.LastTickTime > 250.0)
		{
			RoleAudioComponent.LastTickTime = Time.Instance.Now;
			this.UpdateEnvironment();
		}
	}

	// Token: 0x0601BB82 RID: 113538 RVA: 0x007A1698 File Offset: 0x0079F898
	protected override void OnAkComponentCreated()
	{
		base.OnAkComponentCreated();
		CharacterActorComponent actorComp = base.ActorComp;
		if (((actorComp != null) ? actorComp.Owner : null) == null)
		{
			return;
		}
		AudioSystem.Instance.SetSwitch("role_name", this.CurrentRoleName, base.ActorComp.Owner);
		AudioSystem.Instance.SetSwitch("footstep_texture", this.CurrentFootstepTexture, base.ActorComp.Owner);
		AudioSystem.Instance.SetSwitch("footstep_variant", this.CurrentFootstepVariant, base.ActorComp.Owner);
		AudioSystem.Instance.SetSwitch("foley_variant", this.CurrentFoleyVariant, base.ActorComp.Owner);
		AudioSystem.Instance.SetSwitch("role_interact_water", this.CurrentWaterType, base.ActorComp.Owner);
	}

	// Token: 0x0601BB83 RID: 113539 RVA: 0x007A1760 File Offset: 0x0079F960
	public void ChangeRoleName(string name)
	{
		CharacterActorComponent actorComp = base.ActorComp;
		if (((actorComp != null) ? actorComp.Owner : null) == null)
		{
			return;
		}
		this.CurrentRoleName = name;
		AudioSystem.Instance.SetSwitch("role_name", this.CurrentRoleName, base.ActorComp.Owner);
	}

	// Token: 0x0601BB84 RID: 113540 RVA: 0x007A17A0 File Offset: 0x0079F9A0
	public void ChangeFootstepTexture(CharacterFootEffectComponent.EFootstepTexture texture)
	{
		CharacterActorComponent actorComp = base.ActorComp;
		if (((actorComp != null) ? actorComp.Owner : null) == null)
		{
			return;
		}
		this.CurrentFootstepTexture = texture.ToEnumString();
		AudioSystem.Instance.SetSwitch("footstep_texture", this.CurrentFootstepTexture, base.ActorComp.Owner);
	}

	// Token: 0x0601BB85 RID: 113541 RVA: 0x007A17F0 File Offset: 0x0079F9F0
	public void ChangeFootstepVariant(E_FootstepVariant variant)
	{
		CharacterActorComponent actorComp = base.ActorComp;
		if (((actorComp != null) ? actorComp.Owner : null) == null)
		{
			return;
		}
		string currentFootstepVariant;
		if (!RoleAudioComponent.FootstepVariantMap.TryGetValue(variant, out currentFootstepVariant))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[ChangeFootstepVariant] Map里不含指定枚举类型E_FootstepVariant项,需要更新Map";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Variant", variant);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.CurrentFootstepVariant = currentFootstepVariant;
		AudioSystem.Instance.SetSwitch("footstep_variant", this.CurrentFootstepVariant, base.ActorComp.Owner);
	}

	// Token: 0x0601BB86 RID: 113542 RVA: 0x007A1878 File Offset: 0x0079FA78
	public void ChangeFoleyVariant(E_FoleyVariant variant)
	{
		CharacterActorComponent actorComp = base.ActorComp;
		if (((actorComp != null) ? actorComp.Owner : null) == null)
		{
			return;
		}
		string currentFoleyVariant;
		if (!RoleAudioComponent.FoleyVariantMap.TryGetValue(variant, out currentFoleyVariant))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[ChangeFoleyVariant] Map里不含指定枚举类型E_FoleyVariant项,需要更新Map";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Variant", variant);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.CurrentFoleyVariant = currentFoleyVariant;
		AudioSystem.Instance.SetSwitch("foley_variant", this.CurrentFoleyVariant, base.ActorComp.Owner);
	}

	// Token: 0x0601BB87 RID: 113543 RVA: 0x007A1900 File Offset: 0x0079FB00
	private void LoadConfig()
	{
		CreatureDataComponent creatureData = this.CreatureData;
		if (creatureData == null || !creatureData.Valid)
		{
			return;
		}
		int pbDataId = this.CreatureData.GetPbDataId();
		int id = RoleConfig.Instance.GetBaseRoleId(pbDataId);
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(id);
		if (roleConfig != null && roleConfig.Value.RoleType != 1 && roleConfig.Value.ParentId != 0)
		{
			id = roleConfig.Value.ParentId;
			roleConfig = RoleConfig.Instance.GetRoleConfig(id);
		}
		if (roleConfig != null && roleConfig.GetValueOrDefault().RoleType == 1)
		{
			int skinId = this.CreatureData.GetSkinId();
			if (skinId == 0)
			{
				skinId = roleConfig.Value.SkinId;
			}
			this.Config = ConfigRoleSkinAudioById.GetConfig(skinId, true);
		}
		this.InitFoleyEvent();
		this.InitFootstepEvent();
	}

	// Token: 0x0601BB88 RID: 113544 RVA: 0x007A19F0 File Offset: 0x0079FBF0
	private void OnRoleSkinChanged(int roleId)
	{
		CreatureDataComponent creatureData = this.CreatureData;
		int? num = (creatureData != null) ? new int?(creatureData.GetPbDataId()) : null;
		if (roleId == num.GetValueOrDefault() & num != null)
		{
			this.LoadConfig();
		}
	}

	// Token: 0x0601BB89 RID: 113545 RVA: 0x007A1A38 File Offset: 0x0079FC38
	private void UpdateEnvironment()
	{
		CharacterActorComponent actorComp = base.ActorComp;
		if (actorComp == null || !actorComp.Valid)
		{
			return;
		}
		global::Vector actorLocationProxy = base.ActorComp.ActorLocationProxy;
		if (!actorLocationProxy.Equals(RoleAudioComponent.LocationCache, 32.0))
		{
			RoleAudioComponent.LocationCache.DeepCopy(actorLocationProxy);
			GameAudioController.Instance.UpdatePlayerLocation(actorLocationProxy);
			FVectorDouble actorLocation = base.ActorComp.ActorLocation;
			if (this.GetInAudioShr())
			{
				FName audioShrubTag = this.GetAudioShrubTag();
				if (audioShrubTag != FNameUtil.NONE)
				{
					AudioSystem.Instance.PostEvent(audioShrubTag.ToString(), new FTransformDouble?(new FTransformDouble(ref actorLocation)), null);
					return;
				}
				AudioSystem.Instance.PostEvent("play_amb_role_interact_shr", new FTransformDouble?(new FTransformDouble(ref actorLocation)), null);
			}
		}
	}

	// Token: 0x0601BB8A RID: 113546 RVA: 0x007A1B14 File Offset: 0x0079FD14
	private void OnCharPossessed(Entity entity, [Nullable(2)] AController oldController)
	{
		CharacterActorComponent actorComp = base.ActorComp;
		if (((actorComp != null) ? actorComp.Owner : null) != null)
		{
			GameAudioController.Instance.SetRolePriority(ERoleAudioPriorityType.PlayerControl, base.ActorComp.Owner);
			GameAudioController.Instance.RoleChangeController(base.Entity.Id, true);
		}
	}

	// Token: 0x0601BB8B RID: 113547 RVA: 0x007A1B64 File Offset: 0x0079FD64
	private void OnCharUnpossessed(Entity entity, [Nullable(2)] AController oldController)
	{
		CharacterActorComponent actorComp = base.ActorComp;
		if (((actorComp != null) ? actorComp.Owner : null) != null)
		{
			GameAudioController.Instance.SetRolePriority(ERoleAudioPriorityType.PlayerBackstage, base.ActorComp.Owner);
			GameAudioController.Instance.RoleChangeController(base.Entity.Id, false);
		}
		this.SetAudioMoveState(EMoveState.None);
	}

	// Token: 0x0601BB8C RID: 113548 RVA: 0x007A1BBC File Offset: 0x0079FDBC
	private void OnInteractionWaterTypeChange(EInteractionWaterType type)
	{
		CharacterActorComponent actorComp = base.ActorComp;
		if (((actorComp != null) ? actorComp.Owner : null) == null)
		{
			return;
		}
		if (type == EInteractionWaterType.CloudSea)
		{
			this.CurrentWaterType = "cloud";
		}
		else
		{
			this.CurrentWaterType = "default";
		}
		AudioSystem.Instance.SetSwitch("role_interact_water", this.CurrentWaterType, base.ActorComp.Owner);
	}

	// Token: 0x0601BB8D RID: 113549 RVA: 0x007A1C1C File Offset: 0x0079FE1C
	private void OnCharacterMovementModeChanged(int charId, EMovementMode prevMovementMode, EMovementMode newMovementMode, byte prevCustomMode, byte newCustomMode)
	{
		int id = base.Entity.Id;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		int? num = (baseCharacter != null) ? new int?(baseCharacter.EntityId) : null;
		if (!(id == num.GetValueOrDefault() & num != null) || this.StateComp == null)
		{
			return;
		}
		EMoveState audioMoveState = EMoveState.None;
		switch (newMovementMode)
		{
		case EMovementMode.MOVE_Falling:
			if (this.StateComp.MoveState != global::ECharMoveState.KnockUp && this.StateComp.MoveState != global::ECharMoveState.Captured)
			{
				audioMoveState = EMoveState.Fall;
			}
			break;
		case EMovementMode.MOVE_Flying:
			if (this.StateComp.MoveState != global::ECharMoveState.Captured)
			{
				audioMoveState = EMoveState.Hook;
			}
			break;
		case EMovementMode.MOVE_Custom:
			switch (newCustomMode)
			{
			case 0:
			case 1:
			case 5:
			case 6:
			case 7:
			case 9:
				goto IL_104;
			case 2:
				audioMoveState = EMoveState.Fly;
				goto IL_104;
			case 4:
			case 12:
				audioMoveState = EMoveState.Slide;
				goto IL_104;
			case 8:
				audioMoveState = EMoveState.Ski;
				goto IL_104;
			}
			audioMoveState = EMoveState.Fall;
			break;
		}
		IL_104:
		this.SetAudioMoveState(audioMoveState);
	}

	// Token: 0x0601BB8E RID: 113550 RVA: 0x007A1D34 File Offset: 0x0079FF34
	private void SetAudioMoveState(EMoveState moveState)
	{
		if (this.LastMoveState == moveState)
		{
			return;
		}
		this.LastMoveState = moveState;
		AudioSystem.Instance.SetState("role_move", moveState.Value, true);
	}

	// Token: 0x0601BB8F RID: 113551 RVA: 0x007A1D64 File Offset: 0x0079FF64
	private void OnBeDamage(Entity attacker, Entity victim, RequirementPayload requirements, DamageResult damageResult, FVectorDouble damagePosition)
	{
		if (attacker != victim && damageResult.ChangeLife > 0f && this.AttributeComponent != null)
		{
			int id = victim.Id;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			int? num = (baseCharacter != null) ? new int?(baseCharacter.EntityId) : null;
			if (id == num.GetValueOrDefault() & num != null)
			{
				CharacterActorComponent actorComp = base.ActorComp;
				AActor aactor = (actorComp != null) ? actorComp.Owner : null;
				float currentValue = this.AttributeComponent.GetCurrentValue(EAttributeType.LifeMax);
				float currentValue2 = this.AttributeComponent.GetCurrentValue(EAttributeType.Life);
				if (aactor != null && this.Config != null && currentValue != 0f)
				{
					float num2 = 100f * (currentValue2 / currentValue);
					float num3 = 100f * ((currentValue2 + damageResult.ChangeLife) / currentValue);
					int num4 = 100;
					string text = "";
					for (int i = 0; i < this.Config.Value.LostHealthEventMapLength; i++)
					{
						DicIntString? dicIntString = this.Config.Value.LostHealthEventMap(i);
						int key = dicIntString.Value.Key;
						string value = dicIntString.Value.Value;
						if (num2 <= (float)key && num3 >= (float)key && num4 > key)
						{
							num4 = key;
							text = value;
						}
					}
					if (text != "")
					{
						AudioSystem.Instance.PostEvent(text, aactor, null);
					}
				}
				return;
			}
		}
	}

	// Token: 0x0601BB90 RID: 113552 RVA: 0x007A1EE0 File Offset: 0x007A00E0
	private void OnUseSkillRemote(int entityId, int skillId)
	{
		if (entityId != base.Entity.Id || !RoleAudioController.Instance.CheckSkillAudioId((long)skillId))
		{
			return;
		}
		SkillAudioEvent? config = ConfigSkillAudioEventById.GetConfig(skillId, true);
		if (config != null && (config != null && config.GetValueOrDefault().Remote))
		{
			this.PlayUseSkillEvent(config);
		}
	}

	// Token: 0x0601BB91 RID: 113553 RVA: 0x007A1F40 File Offset: 0x007A0140
	private void OnUseSkill(int entityId, int skillId, bool _)
	{
		if (entityId != base.Entity.Id || !RoleAudioController.Instance.CheckSkillAudioId((long)skillId))
		{
			return;
		}
		SkillAudioEvent? config = ConfigSkillAudioEventById.GetConfig(skillId, true);
		if (config != null)
		{
			this.PlayUseSkillEvent(config);
		}
	}

	// Token: 0x0601BB92 RID: 113554 RVA: 0x007A1F84 File Offset: 0x007A0184
	private void PlayUseSkillEvent(SkillAudioEvent? skillAudioEvent)
	{
		if (skillAudioEvent == null)
		{
			return;
		}
		CharacterActorComponent actorComp = base.ActorComp;
		AActor aactor = (actorComp != null) ? actorComp.Owner : null;
		string eventName = skillAudioEvent.Value.EventName;
		if (aactor == null || !aactor.IsValid() || eventName == null || eventName == "")
		{
			return;
		}
		if (GameAudioModel.Instance.CheckAudioProbabilityInfo(base.Entity.Id, eventName, new AudioCoolDownWithTagInfo
		{
			DefaultCooldownTime = skillAudioEvent.Value.ActorColdTime,
			DefaultProbability = (double)skillAudioEvent.Value.PostProbability
		}, true, true, false))
		{
			AudioSystem.Instance.PostEvent(eventName, aactor, null);
		}
	}

	// Token: 0x0601BB93 RID: 113555 RVA: 0x007A2046 File Offset: 0x007A0246
	private void OnGoDownFinish()
	{
		this.PostGoDownFinishEvent();
	}

	// Token: 0x0601BB94 RID: 113556 RVA: 0x007A2050 File Offset: 0x007A0250
	private void PostGoDownFinishEvent()
	{
		CharacterActorComponent actorComp = base.ActorComp;
		AActor aactor = (actorComp != null) ? actorComp.Owner : null;
		BaseDeathComponent component = base.Entity.GetComponent<BaseDeathComponent>();
		if (((component != null) ? new bool?(component.IsDead()) : null).GetValueOrDefault())
		{
			return;
		}
		if (aactor != null && aactor.IsValid())
		{
			AudioSystem.Instance.PostEvent("scene_role_switched_behind", aactor, null);
		}
	}

	// Token: 0x0601BB95 RID: 113557 RVA: 0x007A20C4 File Offset: 0x007A02C4
	public void PostFootstepAudio(CharacterFootEffectComponent.EFootstepTexture texture)
	{
		this.ChangeFootstepTexture(texture);
		UAkComponent akComponent = base.GetAkComponent(null);
		string footstepEvent = this.GetFootstepEvent();
		if (akComponent != null && !string.IsNullOrEmpty(footstepEvent))
		{
			AudioSystem.Instance.PostEvent(footstepEvent, akComponent, null);
		}
	}

	// Token: 0x0601BB96 RID: 113558 RVA: 0x007A2110 File Offset: 0x007A0310
	public bool IsConfig()
	{
		return this.Config != null;
	}

	// Token: 0x0601BB97 RID: 113559 RVA: 0x007A211D File Offset: 0x007A031D
	public RoleSkinAudio? GetConfig()
	{
		return this.Config;
	}

	// Token: 0x0601BB98 RID: 113560 RVA: 0x007A2128 File Offset: 0x007A0328
	[NullableContext(2)]
	public string GetConfigName()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.GetValueOrDefault().Name;
	}

	// Token: 0x0601BB99 RID: 113561 RVA: 0x007A2154 File Offset: 0x007A0354
	[NullableContext(2)]
	public string GetLowStrengthEvent()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.GetValueOrDefault().LowStrengthEvent;
	}

	// Token: 0x0601BB9A RID: 113562 RVA: 0x007A2180 File Offset: 0x007A0380
	[NullableContext(2)]
	public string GetDeathEvent()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.GetValueOrDefault().DeathEvent;
	}

	// Token: 0x0601BB9B RID: 113563 RVA: 0x007A21AC File Offset: 0x007A03AC
	private void InitFootstepEvent()
	{
		this.FootstepEvent = ((this.Config != null) ? this.Config.GetValueOrDefault().FootstepEvent : null);
		CreatureDataComponent creatureData = this.CreatureData;
		int id = (creatureData != null) ? creatureData.GetPbDataId() : 0;
		int baseRoleId = RoleConfig.Instance.GetBaseRoleId(id);
		AudioConfig instance = AudioConfig.Instance;
		RoleInfoAudio? roleInfoAudio;
		string text = (instance != null) ? ((instance.GetRoleInfoConfig(baseRoleId) != null) ? roleInfoAudio.GetValueOrDefault().FootstepEvent : null) : null;
		if (text != null)
		{
			this.FootstepEvent = text;
		}
	}

	// Token: 0x0601BB9C RID: 113564 RVA: 0x007A2238 File Offset: 0x007A0438
	[NullableContext(2)]
	public string GetFootstepEvent()
	{
		return this.FootstepEvent;
	}

	// Token: 0x0601BB9D RID: 113565 RVA: 0x007A2240 File Offset: 0x007A0440
	private void InitFoleyEvent()
	{
		this.FoleyEvent = ((this.Config != null) ? this.Config.GetValueOrDefault().FoleyEvent : null);
		CreatureDataComponent creatureData = this.CreatureData;
		int id = (creatureData != null) ? creatureData.GetPbDataId() : 0;
		int baseRoleId = RoleConfig.Instance.GetBaseRoleId(id);
		AudioConfig instance = AudioConfig.Instance;
		RoleInfoAudio? roleInfoAudio;
		string text = (instance != null) ? ((instance.GetRoleInfoConfig(baseRoleId) != null) ? roleInfoAudio.GetValueOrDefault().FoleyEvent : null) : null;
		if (text != null)
		{
			this.FoleyEvent = text;
		}
	}

	// Token: 0x0601BB9E RID: 113566 RVA: 0x007A22CC File Offset: 0x007A04CC
	[NullableContext(2)]
	public string GetFoleyEvent()
	{
		return this.FoleyEvent;
	}

	// Token: 0x0601BB9F RID: 113567 RVA: 0x007A22D4 File Offset: 0x007A04D4
	public void UpdateIsInAudioShrubEvent(bool bIsInAudioShrub, FName audioShrubTag)
	{
		this.IsInAudioShrubOverride = bIsInAudioShrub;
		this.AudioShrubTagNameOverride = new FName?(audioShrubTag);
	}

	// Token: 0x0601BBA0 RID: 113568 RVA: 0x007A22EC File Offset: 0x007A04EC
	public bool GetInAudioShr()
	{
		bool flag = this.IsInAudioShrubOverride;
		CharacterActorComponent actorComp = base.ActorComp;
		TsBaseCharacter tsBaseCharacter = (actorComp != null) ? actorComp.Actor : null;
		CharRenderingComponent charRenderingComponent = (tsBaseCharacter != null) ? tsBaseCharacter.CharRenderingComponent : null;
		if (charRenderingComponent != null)
		{
			flag = (flag || charRenderingComponent.GetInAudioShr());
		}
		return flag;
	}

	// Token: 0x0601BBA1 RID: 113569 RVA: 0x007A2330 File Offset: 0x007A0530
	public FName GetAudioShrubTag()
	{
		FName? audioShrubTagNameOverride = this.AudioShrubTagNameOverride;
		CharacterActorComponent actorComp = base.ActorComp;
		TsBaseCharacter tsBaseCharacter = (actorComp != null) ? actorComp.Actor : null;
		CharRenderingComponent charRenderingComponent = (tsBaseCharacter != null) ? tsBaseCharacter.CharRenderingComponent : null;
		if (((charRenderingComponent != null) ? new FName?(charRenderingComponent.GetAudioShrTag()) : null) != FNameUtil.NONE)
		{
			audioShrubTagNameOverride = new FName?(charRenderingComponent.GetAudioShrTag());
		}
		if (audioShrubTagNameOverride == null)
		{
			return FNameUtil.NONE;
		}
		return audioShrubTagNameOverride.Value;
	}

	// Token: 0x0601BBA2 RID: 113570 RVA: 0x007A23C4 File Offset: 0x007A05C4
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleAudioComponent roleAudioComponent = (RoleAudioComponent)componentTemplate;
		if (base.CanResetComponentProperty("LastMoveState"))
		{
			this.LastMoveState = roleAudioComponent.LastMoveState;
		}
		if (base.CanResetComponentProperty("Config"))
		{
			this.Config = roleAudioComponent.Config;
		}
		if (base.CanResetComponentProperty("CurrentRoleName"))
		{
			this.CurrentRoleName = roleAudioComponent.CurrentRoleName;
		}
		if (base.CanResetComponentProperty("CurrentFootstepTexture"))
		{
			this.CurrentFootstepTexture = roleAudioComponent.CurrentFootstepTexture;
		}
		if (base.CanResetComponentProperty("CurrentFootstepVariant"))
		{
			this.CurrentFootstepVariant = roleAudioComponent.CurrentFootstepVariant;
		}
		if (base.CanResetComponentProperty("CurrentFoleyVariant"))
		{
			this.CurrentFoleyVariant = roleAudioComponent.CurrentFoleyVariant;
		}
		if (base.CanResetComponentProperty("CurrentWaterType"))
		{
			this.CurrentWaterType = roleAudioComponent.CurrentWaterType;
		}
		if (base.CanResetComponentProperty("StateComp"))
		{
			if (roleAudioComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.StateComp), "StateComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AttributeComponent"))
		{
			if (roleAudioComponent.AttributeComponent == null)
			{
				this.AttributeComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseAttributeComponent>(this.AttributeComponent), "AttributeComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsInAudioShrubOverride"))
		{
			this.IsInAudioShrubOverride = roleAudioComponent.IsInAudioShrubOverride;
		}
		if (base.CanResetComponentProperty("AudioShrubTagNameOverride"))
		{
			this.AudioShrubTagNameOverride = roleAudioComponent.AudioShrubTagNameOverride;
		}
		if (base.CanResetComponentProperty("FootstepEvent"))
		{
			this.FootstepEvent = roleAudioComponent.FootstepEvent;
		}
		if (base.CanResetComponentProperty("FoleyEvent"))
		{
			this.FoleyEvent = roleAudioComponent.FoleyEvent;
		}
		return true;
	}

	// Token: 0x0400DA63 RID: 55907
	private static Dictionary<E_FootstepVariant, string> FootstepVariantMap;

	// Token: 0x0400DA64 RID: 55908
	private static Dictionary<E_FoleyVariant, string> FoleyVariantMap;

	// Token: 0x0400DA65 RID: 55909
	private const string ROLE_GO_DOWN_FINISH_EVENT = "scene_role_switched_behind";

	// Token: 0x0400DA66 RID: 55910
	private const string ROLE_INTERACT_SHR = "play_amb_role_interact_shr";

	// Token: 0x0400DA67 RID: 55911
	private const string ROLE_MOVE = "role_move";

	// Token: 0x0400DA68 RID: 55912
	private const int TICK_INTERVAL = 250;

	// Token: 0x0400DA69 RID: 55913
	private const int LOCATION_TOLERANCE = 32;

	// Token: 0x0400DA6A RID: 55914
	private EMoveState LastMoveState = EMoveState.None;

	// Token: 0x0400DA6B RID: 55915
	private RoleSkinAudio? Config;

	// Token: 0x0400DA6C RID: 55916
	private string CurrentRoleName = "chixia";

	// Token: 0x0400DA6D RID: 55917
	private string CurrentFootstepTexture = "DirtSurface";

	// Token: 0x0400DA6E RID: 55918
	private string CurrentFootstepVariant = "walk";

	// Token: 0x0400DA6F RID: 55919
	private string CurrentFoleyVariant = "weak";

	// Token: 0x0400DA70 RID: 55920
	private string CurrentWaterType = "default";

	// Token: 0x0400DA71 RID: 55921
	private static double LastTickTime;

	// Token: 0x0400DA72 RID: 55922
	private static global::Vector LocationCache;

	// Token: 0x0400DA73 RID: 55923
	[Nullable(2)]
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400DA74 RID: 55924
	[Nullable(2)]
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400DA75 RID: 55925
	protected bool IsInAudioShrubOverride;

	// Token: 0x0400DA76 RID: 55926
	protected FName? AudioShrubTagNameOverride;

	// Token: 0x0400DA77 RID: 55927
	[Nullable(2)]
	private string FootstepEvent;

	// Token: 0x0400DA78 RID: 55928
	[Nullable(2)]
	private string FoleyEvent;
}
