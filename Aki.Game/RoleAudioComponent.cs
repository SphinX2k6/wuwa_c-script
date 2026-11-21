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

// Token: 0x020027A5 RID: 10149
[NullableContext(1)]
[Nullable(0)]
public class RoleAudioComponent : CharacterAudioComponent, IStaticVariableResetter
{
	// Token: 0x06019705 RID: 104197 RVA: 0x007C9ABF File Offset: 0x007C7CBF
	static RoleAudioComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleAudioComponent.CreateStaticDefaultValue), new Action(RoleAudioComponent.ResetStaticDefaultValue));
	}

	// Token: 0x06019706 RID: 104198 RVA: 0x007C9AE0 File Offset: 0x007C7CE0
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

	// Token: 0x06019707 RID: 104199 RVA: 0x007C9BD9 File Offset: 0x007C7DD9
	public static void ResetStaticDefaultValue()
	{
		RoleAudioComponent.FootstepVariantMap = null;
		RoleAudioComponent.FoleyVariantMap = null;
		RoleAudioComponent.LastTickTime = 0.0;
		RoleAudioComponent.LocationCache = null;
	}

	// Token: 0x06019708 RID: 104200 RVA: 0x007C9BFC File Offset: 0x007C7DFC
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

	// Token: 0x06019709 RID: 104201 RVA: 0x007C9D6C File Offset: 0x007C7F6C
	protected override bool OnEnd()
	{
		base.OnEnd();
		this.PostGoDownFinishEvent();
		return true;
	}

	// Token: 0x0601970A RID: 104202 RVA: 0x007C9D7C File Offset: 0x007C7F7C
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

	// Token: 0x0601970B RID: 104203 RVA: 0x007C9EC4 File Offset: 0x007C80C4
	protected override bool OnStart()
	{
		base.OnStart();
		this.ChangeRoleName((((this.Config != null) ? this.Config.GetValueOrDefault().Name : null) != null) ? this.Config.Value.Name : "chixia");
		this.SetAudioMoveState(EMoveState.None);
		return true;
	}

	// Token: 0x0601970C RID: 104204 RVA: 0x007C9F28 File Offset: 0x007C8128
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

	// Token: 0x0601970D RID: 104205 RVA: 0x007C9FA4 File Offset: 0x007C81A4
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

	// Token: 0x0601970E RID: 104206 RVA: 0x007CA06C File Offset: 0x007C826C
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

	// Token: 0x0601970F RID: 104207 RVA: 0x007CA0AC File Offset: 0x007C82AC
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

	// Token: 0x06019710 RID: 104208 RVA: 0x007CA0FC File Offset: 0x007C82FC
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

	// Token: 0x06019711 RID: 104209 RVA: 0x007CA184 File Offset: 0x007C8384
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

	// Token: 0x06019712 RID: 104210 RVA: 0x007CA20C File Offset: 0x007C840C
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

	// Token: 0x06019713 RID: 104211 RVA: 0x007CA2FC File Offset: 0x007C84FC
	private void OnRoleSkinChanged(int roleId)
	{
		CreatureDataComponent creatureData = this.CreatureData;
		int? num = (creatureData != null) ? new int?(creatureData.GetPbDataId()) : null;
		if (roleId == num.GetValueOrDefault() & num != null)
		{
			this.LoadConfig();
		}
	}

	// Token: 0x06019714 RID: 104212 RVA: 0x007CA344 File Offset: 0x007C8544
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

	// Token: 0x06019715 RID: 104213 RVA: 0x007CA420 File Offset: 0x007C8620
	private void OnCharPossessed(Entity entity, [Nullable(2)] AController oldController)
	{
		CharacterActorComponent actorComp = base.ActorComp;
		if (((actorComp != null) ? actorComp.Owner : null) != null)
		{
			GameAudioController.Instance.SetRolePriority(ERoleAudioPriorityType.PlayerControl, base.ActorComp.Owner);
			GameAudioController.Instance.RoleChangeController(base.Entity.Id, true);
		}
	}

	// Token: 0x06019716 RID: 104214 RVA: 0x007CA470 File Offset: 0x007C8670
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

	// Token: 0x06019717 RID: 104215 RVA: 0x007CA4C8 File Offset: 0x007C86C8
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

	// Token: 0x06019718 RID: 104216 RVA: 0x007CA528 File Offset: 0x007C8728
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

	// Token: 0x06019719 RID: 104217 RVA: 0x007CA640 File Offset: 0x007C8840
	private void SetAudioMoveState(EMoveState moveState)
	{
		if (this.LastMoveState == moveState)
		{
			return;
		}
		this.LastMoveState = moveState;
		AudioSystem.Instance.SetState("role_move", moveState.Value, true);
	}

	// Token: 0x0601971A RID: 104218 RVA: 0x007CA670 File Offset: 0x007C8870
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

	// Token: 0x0601971B RID: 104219 RVA: 0x007CA7EC File Offset: 0x007C89EC
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

	// Token: 0x0601971C RID: 104220 RVA: 0x007CA84C File Offset: 0x007C8A4C
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

	// Token: 0x0601971D RID: 104221 RVA: 0x007CA890 File Offset: 0x007C8A90
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

	// Token: 0x0601971E RID: 104222 RVA: 0x007CA952 File Offset: 0x007C8B52
	private void OnGoDownFinish()
	{
		this.PostGoDownFinishEvent();
	}

	// Token: 0x0601971F RID: 104223 RVA: 0x007CA95C File Offset: 0x007C8B5C
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

	// Token: 0x06019720 RID: 104224 RVA: 0x007CA9D0 File Offset: 0x007C8BD0
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

	// Token: 0x06019721 RID: 104225 RVA: 0x007CAA1C File Offset: 0x007C8C1C
	public bool IsConfig()
	{
		return this.Config != null;
	}

	// Token: 0x06019722 RID: 104226 RVA: 0x007CAA29 File Offset: 0x007C8C29
	public RoleSkinAudio? GetConfig()
	{
		return this.Config;
	}

	// Token: 0x06019723 RID: 104227 RVA: 0x007CAA34 File Offset: 0x007C8C34
	[NullableContext(2)]
	public string GetConfigName()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.GetValueOrDefault().Name;
	}

	// Token: 0x06019724 RID: 104228 RVA: 0x007CAA60 File Offset: 0x007C8C60
	[NullableContext(2)]
	public string GetLowStrengthEvent()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.GetValueOrDefault().LowStrengthEvent;
	}

	// Token: 0x06019725 RID: 104229 RVA: 0x007CAA8C File Offset: 0x007C8C8C
	[NullableContext(2)]
	public string GetDeathEvent()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.GetValueOrDefault().DeathEvent;
	}

	// Token: 0x06019726 RID: 104230 RVA: 0x007CAAB8 File Offset: 0x007C8CB8
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

	// Token: 0x06019727 RID: 104231 RVA: 0x007CAB44 File Offset: 0x007C8D44
	[NullableContext(2)]
	public string GetFootstepEvent()
	{
		return this.FootstepEvent;
	}

	// Token: 0x06019728 RID: 104232 RVA: 0x007CAB4C File Offset: 0x007C8D4C
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

	// Token: 0x06019729 RID: 104233 RVA: 0x007CABD8 File Offset: 0x007C8DD8
	[NullableContext(2)]
	public string GetFoleyEvent()
	{
		return this.FoleyEvent;
	}

	// Token: 0x0601972A RID: 104234 RVA: 0x007CABE0 File Offset: 0x007C8DE0
	public void UpdateIsInAudioShrubEvent(bool bIsInAudioShrub, FName audioShrubTag)
	{
		this.IsInAudioShrubOverride = bIsInAudioShrub;
		this.AudioShrubTagNameOverride = new FName?(audioShrubTag);
	}

	// Token: 0x0601972B RID: 104235 RVA: 0x007CABF8 File Offset: 0x007C8DF8
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

	// Token: 0x0601972C RID: 104236 RVA: 0x007CAC3C File Offset: 0x007C8E3C
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

	// Token: 0x0601972D RID: 104237 RVA: 0x007CACD0 File Offset: 0x007C8ED0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleAudioComponent roleAudioComponent = (RoleAudioComponent)componentTemplate;
		this.LastMoveState = roleAudioComponent.LastMoveState;
		this.Config = roleAudioComponent.Config;
		this.CurrentRoleName = roleAudioComponent.CurrentRoleName;
		this.CurrentFootstepTexture = roleAudioComponent.CurrentFootstepTexture;
		this.CurrentFootstepVariant = roleAudioComponent.CurrentFootstepVariant;
		this.CurrentFoleyVariant = roleAudioComponent.CurrentFoleyVariant;
		this.CurrentWaterType = roleAudioComponent.CurrentWaterType;
		if (roleAudioComponent.StateComp == null)
		{
			this.StateComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
		{
			return false;
		}
		if (roleAudioComponent.AttributeComponent == null)
		{
			this.AttributeComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AttributeComponent), "AttributeComponent"))
		{
			return false;
		}
		this.IsInAudioShrubOverride = roleAudioComponent.IsInAudioShrubOverride;
		this.AudioShrubTagNameOverride = roleAudioComponent.AudioShrubTagNameOverride;
		this.FootstepEvent = roleAudioComponent.FootstepEvent;
		this.FoleyEvent = roleAudioComponent.FoleyEvent;
		return true;
	}

	// Token: 0x17002889 RID: 10377
	// (get) Token: 0x0601972E RID: 104238 RVA: 0x007CADCA File Offset: 0x007C8FCA
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700288A RID: 10378
	// (get) Token: 0x0601972F RID: 104239 RVA: 0x007CADCD File Offset: 0x007C8FCD
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700288B RID: 10379
	// (get) Token: 0x06019730 RID: 104240 RVA: 0x007CADD0 File Offset: 0x007C8FD0
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700288C RID: 10380
	// (get) Token: 0x06019731 RID: 104241 RVA: 0x007CADD3 File Offset: 0x007C8FD3
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700288D RID: 10381
	// (get) Token: 0x06019732 RID: 104242 RVA: 0x007CADD6 File Offset: 0x007C8FD6
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DF02 RID: 57090
	private static Dictionary<E_FootstepVariant, string> FootstepVariantMap;

	// Token: 0x0400DF03 RID: 57091
	private static Dictionary<E_FoleyVariant, string> FoleyVariantMap;

	// Token: 0x0400DF04 RID: 57092
	private const string ROLE_GO_DOWN_FINISH_EVENT = "scene_role_switched_behind";

	// Token: 0x0400DF05 RID: 57093
	private const string ROLE_INTERACT_SHR = "play_amb_role_interact_shr";

	// Token: 0x0400DF06 RID: 57094
	private const string ROLE_MOVE = "role_move";

	// Token: 0x0400DF07 RID: 57095
	private const int TICK_INTERVAL = 250;

	// Token: 0x0400DF08 RID: 57096
	private const int LOCATION_TOLERANCE = 32;

	// Token: 0x0400DF09 RID: 57097
	private EMoveState LastMoveState = EMoveState.None;

	// Token: 0x0400DF0A RID: 57098
	private RoleSkinAudio? Config;

	// Token: 0x0400DF0B RID: 57099
	private string CurrentRoleName = "chixia";

	// Token: 0x0400DF0C RID: 57100
	private string CurrentFootstepTexture = "DirtSurface";

	// Token: 0x0400DF0D RID: 57101
	private string CurrentFootstepVariant = "walk";

	// Token: 0x0400DF0E RID: 57102
	private string CurrentFoleyVariant = "weak";

	// Token: 0x0400DF0F RID: 57103
	private string CurrentWaterType = "default";

	// Token: 0x0400DF10 RID: 57104
	private static double LastTickTime;

	// Token: 0x0400DF11 RID: 57105
	private static global::Vector LocationCache;

	// Token: 0x0400DF12 RID: 57106
	[Nullable(2)]
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x0400DF13 RID: 57107
	[Nullable(2)]
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400DF14 RID: 57108
	protected bool IsInAudioShrubOverride;

	// Token: 0x0400DF15 RID: 57109
	protected FName? AudioShrubTagNameOverride;

	// Token: 0x0400DF16 RID: 57110
	[Nullable(2)]
	private string FootstepEvent;

	// Token: 0x0400DF17 RID: 57111
	[Nullable(2)]
	private string FoleyEvent;
}
