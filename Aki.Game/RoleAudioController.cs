using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020027CA RID: 10186
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class RoleAudioController : ControllerBase
{
	// Token: 0x060198C1 RID: 104641 RVA: 0x007D7678 File Offset: 0x007D5878
	private void InitCoolDownMap()
	{
		foreach (ERoleAudioType eroleAudioType in new ERoleAudioType[]
		{
			ERoleAudioType.Global,
			ERoleAudioType.FastClimb,
			ERoleAudioType.Glide,
			ERoleAudioType.ClimbLeap,
			ERoleAudioType.StrengthChangeTired,
			ERoleAudioType.StrengthChangeTiredLow,
			ERoleAudioType.UseHookSkill,
			ERoleAudioType.ScanTreasureBox,
			ERoleAudioType.OpenTreasureBox,
			ERoleAudioType.VisionMorph,
			ERoleAudioType.VisionSummon,
			ERoleAudioType.Dodge,
			ERoleAudioType.Parry,
			ERoleAudioType.EnterBattle,
			ERoleAudioType.UnderAttack,
			ERoleAudioType.KnockUp,
			ERoleAudioType.Accelerate
		})
		{
			this.IntervalCoolDownTimeMap[eroleAudioType] = new RoleAudioCoolDownTime(eroleAudioType);
		}
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("FixHookSkillList");
		if (intArrayConfig != null)
		{
			this.FixHookSkillList = new List<int>();
			this.FixHookSkillList.AddRange(intArrayConfig);
		}
		IReadOnlyList<int> intArrayConfig2 = ConfigCommonParamById.GetIntArrayConfig("SuperSprintStartSkillList");
		if (intArrayConfig2 != null)
		{
			this.SuperSprintStartSkillList = new List<int>();
			this.SuperSprintStartSkillList.AddRange(intArrayConfig2);
		}
		IReadOnlyList<int> intArrayConfig3 = ConfigCommonParamById.GetIntArrayConfig("SuperSprintEndSkillList");
		if (intArrayConfig3 != null)
		{
			this.SuperSprintEndSkillList = new List<int>();
			this.SuperSprintEndSkillList.AddRange(intArrayConfig3);
		}
		IReadOnlyList<SkillAudioEvent> configList = ConfigSkillAudioEventAll.GetConfigList(true);
		if (configList != null && configList.Count > 0)
		{
			foreach (SkillAudioEvent skillAudioEvent in configList)
			{
				this.SkillAudioId.Add(skillAudioEvent.Id);
			}
		}
	}

	// Token: 0x060198C2 RID: 104642 RVA: 0x007D7798 File Offset: 0x007D5998
	protected override bool OnInit()
	{
		this.InitCoolDownMap();
		this.InitDodgeProgressionParams();
		this.LowStrengthPercentage = (double)ConfigCommonParamById.GetIntConfig("LowEndurancePercent").GetValueOrDefault() / 10000.0;
		EventSystem.Instance.Add<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Add<int>(EEventName.OpenTreasureBox, new Action<int>(this.OnOpenTreasureBox));
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		FormationAttributeController.Instance.AddValueListener(EFormationAttributeId.Strength, new TValueListener(this.OnStrengthChanged), null);
		Net.Instance.Register(ENotifyMessageId.RoleSceneVoiceSwitchNotify, new Action<IMessage, Net.CallbackStatus>(this.OnUpdateAudioIgnoreNotify));
		return true;
	}

	// Token: 0x060198C3 RID: 104643 RVA: 0x007D7878 File Offset: 0x007D5A78
	protected override void OnTick(float delta)
	{
		if (this.UpdateDynamicTrace)
		{
			this.UpdateAudioDynamicTrace();
			this.LastTime = Time.Instance.Now;
			return;
		}
		if (Global.BaseCharacter == null || this.ActorComponent == null || !GameModeModel.Instance.WorldDone || GameModeModel.Instance.IsTeleport)
		{
			return;
		}
		BaseMoveComponent moveComp = this.ActorComponent.MoveComp;
		if (moveComp != null && moveComp.IsMoving)
		{
			this.IntervalTime = 50;
		}
		else
		{
			this.IntervalTime = 500;
		}
		if (Time.Instance.Now - this.LastTime < (double)this.IntervalTime)
		{
			return;
		}
		this.LastTime = Time.Instance.Now;
		this.SetUpdateAudioDynamicTrace(false);
	}

	// Token: 0x060198C4 RID: 104644 RVA: 0x007D792C File Offset: 0x007D5B2C
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnUseSkill));
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Remove(EEventName.OpenTreasureBox, new Action<int>(this.OnOpenTreasureBox));
		EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnUpdateSceneTeam));
		FormationAttributeController.Instance.RemoveValueListener(EFormationAttributeId.Strength, new TValueListener(this.OnStrengthChanged));
		Net.Instance.UnRegister(ENotifyMessageId.RoleSceneVoiceSwitchNotify);
		return true;
	}

	// Token: 0x060198C5 RID: 104645 RVA: 0x007D79CE File Offset: 0x007D5BCE
	public void SetUpdateAudioDynamicTrace(bool force = false)
	{
		this.ForceUpdateDynamicTrace = force;
		if (this.UpdateDynamicTrace)
		{
			return;
		}
		this.UpdateDynamicTrace = true;
		this.LastSetDynamicTrace = false;
	}

	// Token: 0x060198C6 RID: 104646 RVA: 0x007D79F0 File Offset: 0x007D5BF0
	private void UpdateAudioDynamicTrace()
	{
		UKuroAudioEnvironmentSubsystem audioEnvironmentSubsystem = UKuroAudioStatics.GetAudioEnvironmentSubsystem(Info.Instance.World);
		if (audioEnvironmentSubsystem == null)
		{
			this.LastSetDynamicTrace = false;
			this.UpdateDynamicTrace = false;
			return;
		}
		if (this.LastSetDynamicTrace)
		{
			audioEnvironmentSubsystem.DynamicReverbApply();
			this.LastSetDynamicTrace = false;
			this.UpdateDynamicTrace = false;
			if (this.ForceUpdateDynamicTrace)
			{
				this.SetUpdateAudioDynamicTrace(true);
			}
			return;
		}
		if (this.ActorComponent != null)
		{
			UKuroAudioEnvironmentSubsystem ukuroAudioEnvironmentSubsystem = audioEnvironmentSubsystem;
			FVectorDouble actorLocation = this.ActorComponent.ActorLocation;
			ukuroAudioEnvironmentSubsystem.D_DynamicReverbTrace(actorLocation, this.ForceUpdateDynamicTrace);
			this.ForceUpdateDynamicTrace = false;
			this.LastSetDynamicTrace = true;
			return;
		}
		this.UpdateDynamicTrace = false;
	}

	// Token: 0x060198C7 RID: 104647 RVA: 0x007D7A84 File Offset: 0x007D5C84
	public int PlayRoleAudio(Entity entity, ERoleAudioType type, [Nullable(2)] Action<EAkCallbackType, UAkCallbackInfo> callback = null)
	{
		CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
		RoleAudioComponent roleAudioComponent = (entity != null) ? entity.GetComponent<RoleAudioComponent>() : null;
		UAkComponent uakComponent = (roleAudioComponent != null) ? roleAudioComponent.GetAkComponent(null) : null;
		if (entity == null || characterActorComponent == null || roleAudioComponent == null || uakComponent == null || !roleAudioComponent.IsConfig())
		{
			return 0;
		}
		BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
		if (component != null && component.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.禁止播放功能语音"]))
		{
			return 0;
		}
		if (type == ERoleAudioType.Dodge)
		{
			this.UpdateDodgeAudioEvent(entity);
		}
		if (type == ERoleAudioType.VisionMorph || type == ERoleAudioType.VisionSummon)
		{
			BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
			if (component2 != null && component2.HasTag(GameplayTagDefine.EGameplayTagId["幻象.Common.禁止播放语音"]))
			{
				return 0;
			}
		}
		return this.OnPlayRoleAudio(characterActorComponent.CreatureData.GetPbDataId(), entity.Id, uakComponent, type, this.GetRoleAudioConfig(type, roleAudioComponent.GetConfig()), callback);
	}

	// Token: 0x060198C8 RID: 104648 RVA: 0x007D7B68 File Offset: 0x007D5D68
	private unsafe int OnPlayRoleAudio(int roleId, int entityId, UAkComponent akComponent, ERoleAudioType type, string eventName, [Nullable(2)] Action<EAkCallbackType, UAkCallbackInfo> callback = null)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		bool flag;
		if (entity == null)
		{
			flag = false;
		}
		else
		{
			BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
			flag = ((component != null) ? new bool?(component.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.禁止播放功能语音"])) : null).GetValueOrDefault();
		}
		if (flag)
		{
			return 0;
		}
		RoleAudioCoolDownTime roleAudioCoolDownTime;
		if (!this.IntervalCoolDownTimeMap.TryGetValue(ERoleAudioType.Global, out roleAudioCoolDownTime) || !roleAudioCoolDownTime.CheckCoolDownTime(roleId, entityId, false, false))
		{
			return 0;
		}
		CharacterActorComponent actorComponent = this.ActorComponent;
		bool flag2;
		if (actorComponent == null)
		{
			flag2 = false;
		}
		else
		{
			BaseMoveComponent component2 = actorComponent.Entity.GetComponent<BaseMoveComponent>();
			flag2 = ((component2 != null) ? new bool?(component2.IsInRoll()) : null).GetValueOrDefault();
		}
		if (flag2)
		{
			return 0;
		}
		RoleAudioCoolDownTime roleAudioCoolDownTime2;
		if (!this.IntervalCoolDownTimeMap.TryGetValue(type, out roleAudioCoolDownTime2))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[RoleAudio] IntervalCoolDownTimeMap没注册音频配置数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AudioType", this.GetRoleAudioTypeDesc(type));
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0;
		}
		if ((roleAudioCoolDownTime2.GroupId & this.RoleAudioIgnoreType) != 0)
		{
			return 0;
		}
		if (string.IsNullOrEmpty(eventName))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Audio;
			ELogAuthor author2 = ELogAuthor.CWZ;
			string message2 = "[RoleAudio] event为空 在尝试播放角色未配置的语音";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RoleId", roleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Event", eventName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Owner", akComponent.GetOwner());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("AudioType", this.GetRoleAudioTypeDesc(type));
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return 0;
		}
		if (!roleAudioCoolDownTime2.CheckCoolDownTime(roleId, entityId, true, true))
		{
			return 0;
		}
		roleAudioCoolDownTime.RefreshCoolDownTime(entityId, true);
		if (callback != null)
		{
			return AudioSystem.Instance.PostEvent(eventName, akComponent, new PostEventArgs?(new PostEventArgs
			{
				CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					callback(callbackType, callbackInfo);
				}
			}));
		}
		return AudioSystem.Instance.PostEvent(eventName, akComponent, null);
	}

	// Token: 0x060198C9 RID: 104649 RVA: 0x007D7D94 File Offset: 0x007D5F94
	public void RefreshPlayAudioCooldownTime(ERoleAudioType type, int entityId)
	{
		RoleAudioCoolDownTime roleAudioCoolDownTime;
		if (!this.IntervalCoolDownTimeMap.TryGetValue(type, out roleAudioCoolDownTime))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[RoleAudio] IntervalCoolDownTimeMap没注册音频配置数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AudioType", this.GetRoleAudioTypeDesc(type));
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		roleAudioCoolDownTime.RefreshCoolDownTime(entityId, true);
	}

	// Token: 0x060198CA RID: 104650 RVA: 0x007D7DE8 File Offset: 0x007D5FE8
	[NullableContext(2)]
	private void OnUpdateAudioIgnoreNotify(IMessage msg, Net.CallbackStatus _)
	{
		RoleSceneVoiceSwitchNotify roleSceneVoiceSwitchNotify = (RoleSceneVoiceSwitchNotify)msg;
		this.RoleAudioIgnoreType = roleSceneVoiceSwitchNotify.VoiceGroupData;
	}

	// Token: 0x060198CB RID: 104651 RVA: 0x007D7E08 File Offset: 0x007D6008
	private void OnUseSkill(int charId, int skillId, bool isAutonomousProxy)
	{
		Entity entity = EntitySystem.Instance.Get(charId);
		if (entity == null)
		{
			return;
		}
		List<int> fixHookSkillList = this.FixHookSkillList;
		if ((fixHookSkillList != null && fixHookSkillList.Contains(skillId)) || skillId == 210001)
		{
			this.PlayRoleAudio(entity, ERoleAudioType.UseHookSkill, null);
		}
		List<int> superSprintStartSkillList = this.SuperSprintStartSkillList;
		if (superSprintStartSkillList != null && superSprintStartSkillList.Contains(skillId))
		{
			this.OnPlayAccelerateAudio(entity, global::ECharMoveState.Sprint, global::ECharPositionState.Ground, null, null);
		}
		List<int> superSprintEndSkillList = this.SuperSprintEndSkillList;
		if (superSprintEndSkillList != null && superSprintEndSkillList.Contains(skillId))
		{
			this.RefreshPlayAudioCooldownTime(ERoleAudioType.Global, entity.Id);
		}
	}

	// Token: 0x060198CC RID: 104652 RVA: 0x007D7EA4 File Offset: 0x007D60A4
	private void OnUpdateSceneTeam()
	{
		this.CacheList.Clear();
		this.CacheList.AddRange(this.LastAudioEvents);
		this.LastAudioEvents.Clear();
		foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(false))
		{
			WorldEntity entity = entityHandle.Entity;
			RoleAudioComponent roleAudioComponent = (entity != null) ? entity.CheckGetComponent<RoleAudioComponent>() : null;
			if (roleAudioComponent != null && roleAudioComponent.IsConfig())
			{
				string text = (roleAudioComponent != null) ? roleAudioComponent.GetFootstepEvent() : null;
				if (text != null && !this.LastAudioEvents.Contains(text))
				{
					this.LastAudioEvents.Add(text);
				}
				string text2 = (roleAudioComponent != null) ? roleAudioComponent.GetFoleyEvent() : null;
				if (text2 != null && !this.LastAudioEvents.Contains(text2))
				{
					this.LastAudioEvents.Add(text2);
				}
			}
		}
		foreach (string text3 in this.CacheList)
		{
			if (!this.LastAudioEvents.Contains(text3))
			{
				AudioSystem.Instance.ReleaseAudioEvent(text3);
			}
		}
		foreach (string text4 in this.LastAudioEvents)
		{
			if (!this.CacheList.Contains(text4))
			{
				AudioSystem.Instance.PreloadAudioEvent(text4);
			}
		}
	}

	// Token: 0x060198CD RID: 104653 RVA: 0x007D8048 File Offset: 0x007D6248
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		WorldEntity entity = newEntity.Entity;
		this.ActorComponent = ((entity != null) ? entity.CheckGetComponent<CharacterActorComponent>() : null);
		WorldEntity entity2 = newEntity.Entity;
		this.AudioComponent = ((entity2 != null) ? entity2.CheckGetComponent<RoleAudioComponent>() : null);
		RoleAudioComponent audioComponent = this.AudioComponent;
		if (audioComponent != null && audioComponent.IsConfig())
		{
			AudioSystem.Instance.SetState("role_name", this.AudioComponent.GetConfigName(), true);
		}
		RoleAudioComponent audioComponent2 = this.AudioComponent;
		UAkComponent uakComponent = (audioComponent2 != null) ? audioComponent2.GetAkComponent(null) : null;
		if (uakComponent != null)
		{
			AudioSystem.Instance.PostEvent("scene_role_switched_front", uakComponent, null);
		}
	}

	// Token: 0x060198CE RID: 104654 RVA: 0x007D80ED File Offset: 0x007D62ED
	private void OnOpenTreasureBox(int entityId)
	{
		if (this.ActorComponent == null)
		{
			return;
		}
		this.PlayRoleAudio(this.ActorComponent.Entity, ERoleAudioType.OpenTreasureBox, null);
	}

	// Token: 0x060198CF RID: 104655 RVA: 0x007D8110 File Offset: 0x007D6310
	private void OnStrengthChanged(EFormationAttributeId attrId, float newValue, float oldValue)
	{
		if (attrId != EFormationAttributeId.Strength || newValue > oldValue)
		{
			return;
		}
		SceneTeamModel instance = SceneTeamModel.Instance;
		if (instance != null && instance.ChangingRole)
		{
			return;
		}
		double num = (double)FormationAttributeController.Instance.GetMax(EFormationAttributeId.Strength);
		if ((double)newValue / num > this.LowStrengthPercentage)
		{
			return;
		}
		RoleAudioComponent audioComponent = this.AudioComponent;
		UAkComponent uakComponent = (audioComponent != null) ? audioComponent.GetAkComponent(null) : null;
		RoleAudioComponent audioComponent2 = this.AudioComponent;
		string text = (audioComponent2 != null) ? audioComponent2.GetLowStrengthEvent() : null;
		if (this.ActorComponent == null || uakComponent == null || text == null)
		{
			return;
		}
		RoleAudioCoolDownTime roleAudioCoolDownTime;
		RoleAudioCoolDownTime roleAudioCoolDownTime2;
		if (!this.IntervalCoolDownTimeMap.TryGetValue(ERoleAudioType.StrengthChangeTired, out roleAudioCoolDownTime) || !this.IntervalCoolDownTimeMap.TryGetValue(ERoleAudioType.StrengthChangeTiredLow, out roleAudioCoolDownTime2))
		{
			return;
		}
		int pbDataId = this.ActorComponent.CreatureData.GetPbDataId();
		int id = this.ActorComponent.Entity.Id;
		if (!roleAudioCoolDownTime.CheckCoolDownTime(pbDataId, id, false, false) || !roleAudioCoolDownTime2.CheckCoolDownTime(pbDataId, id, false, false))
		{
			return;
		}
		bool flag;
		if ((double)oldValue / num > this.LowStrengthPercentage)
		{
			flag = roleAudioCoolDownTime.CheckCoolDownTime(pbDataId, id, true, true);
		}
		else
		{
			flag = roleAudioCoolDownTime2.CheckCoolDownTime(pbDataId, id, true, true);
		}
		if (!flag)
		{
			return;
		}
		this.OnPlayRoleAudio(this.ActorComponent.CreatureData.GetPbDataId(), id, uakComponent, ERoleAudioType.StrengthChangeTired, text, null);
	}

	// Token: 0x060198D0 RID: 104656 RVA: 0x007D8254 File Offset: 0x007D6454
	public void OnPlayerIsHit(Entity entity)
	{
		this.ResetDodgeAudioLevel();
		TimerSystem.Instance.Next(delegate(float _)
		{
			this.PlayRoleAudio(entity, ERoleAudioType.UnderAttack, null);
		}, null, null);
	}

	// Token: 0x060198D1 RID: 104657 RVA: 0x007D8294 File Offset: 0x007D6494
	public void OnPlayerEnterFight(Entity entity, double distance)
	{
		if (distance >= 1000.0)
		{
			int id = entity.Id;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			int? num = (baseCharacter != null) ? new int?(baseCharacter.EntityId) : null;
			if (id == num.GetValueOrDefault() & num != null)
			{
				this.PlayRoleAudio(entity, ERoleAudioType.EnterBattle, null);
				return;
			}
		}
	}

	// Token: 0x060198D2 RID: 104658 RVA: 0x007D82F4 File Offset: 0x007D64F4
	public void OnMoveStateChange(global::ECharMoveState state, Entity entity)
	{
		switch (state)
		{
		case global::ECharMoveState.FastClimb:
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.PlayRoleAudio(entity, ERoleAudioType.FastClimb, null);
			}, null, null);
			break;
		case global::ECharMoveState.Glide:
			this.PlayRoleAudio(entity, ERoleAudioType.Glide, null);
			break;
		case global::ECharMoveState.KnockUp:
			this.PlayRoleAudio(entity, ERoleAudioType.KnockUp, null);
			break;
		}
		this.InterruptAccelerateAudio(state, entity);
	}

	// Token: 0x060198D3 RID: 104659 RVA: 0x007D837C File Offset: 0x007D657C
	public void OnPlayerDies(Entity entity)
	{
		CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
		RoleAudioComponent roleAudioComponent = (entity != null) ? entity.GetComponent<RoleAudioComponent>() : null;
		UAkComponent uakComponent = (roleAudioComponent != null) ? roleAudioComponent.GetAkComponent(null) : null;
		if (entity != null && characterActorComponent != null && roleAudioComponent != null && uakComponent != null && roleAudioComponent.IsConfig())
		{
			int id = entity.Id;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			int? num = (baseCharacter != null) ? new int?(baseCharacter.EntityId) : null;
			if (id == num.GetValueOrDefault() & num != null)
			{
				AudioSystem.Instance.PostEvent(roleAudioComponent.GetDeathEvent(), uakComponent, null);
				return;
			}
		}
	}

	// Token: 0x060198D4 RID: 104660 RVA: 0x007D8424 File Offset: 0x007D6624
	public void OnPlayAccelerateAudio(Entity entity, global::ECharMoveState moveState, global::ECharPositionState positionState, int? movementMode = null, int? customMode = null)
	{
		if (!FormationDataController.Instance.GlobalIsInFight && moveState == global::ECharMoveState.Sprint)
		{
			this.AccelerateAudioHandle = this.PlayRoleAudio(entity, ERoleAudioType.Accelerate, delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
			{
				this.AccelerateAudioHandle = 0;
			});
		}
	}

	// Token: 0x060198D5 RID: 104661 RVA: 0x007D8454 File Offset: 0x007D6654
	private void InterruptAccelerateAudio(global::ECharMoveState state, Entity entity)
	{
		if (this.AccelerateAudioHandle == 0 || this.AccelerateAudioHandle != 0)
		{
			return;
		}
		global::ECharPositionState positionState = entity.GetComponent<BaseUnifiedStateComponent>().PositionState;
		if (state == global::ECharMoveState.Sprint)
		{
			return;
		}
		AudioSystem.Instance.ExecuteAction(this.AccelerateAudioHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
		{
			TransitionDuration = new int?(1000)
		}));
		this.AccelerateAudioHandle = 0;
	}

	// Token: 0x060198D6 RID: 104662 RVA: 0x007D84BC File Offset: 0x007D66BC
	private void InitDodgeProgressionParams()
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("DodgeProgressionAudioResetList");
		IReadOnlyList<string> stringArrayConfig = ConfigCommonParamById.GetStringArrayConfig("DodgeProgressionAudioEventList");
		IReadOnlyList<int> intArrayConfig2 = ConfigCommonParamById.GetIntArrayConfig("DodgeProgressionAudioTimesList");
		if (stringArrayConfig != null && intArrayConfig2 != null && intArrayConfig != null)
		{
			this.DodgeProgressionAudioResetList = new List<int>();
			this.DodgeProgressionAudioEventList = new List<string>();
			this.DodgeProgressionAudioTimesList = new List<int>();
			this.DodgeProgressionAudioResetList.AddRange(intArrayConfig);
			this.DodgeProgressionAudioEventList.AddRange(stringArrayConfig);
			this.DodgeProgressionAudioTimesList.AddRange(intArrayConfig2);
		}
	}

	// Token: 0x060198D7 RID: 104663 RVA: 0x007D8538 File Offset: 0x007D6738
	private void UpdateDodgeAudioEvent(Entity entity)
	{
		if (this.DodgeProgressionAudioResetList == null || this.DodgeProgressionAudioResetList.Count == 0 || this.DodgeProgressionAudioEventList == null || this.DodgeProgressionAudioEventList.Count == 0 || this.DodgeProgressionAudioTimesList == null || this.DodgeProgressionAudioTimesList.Count == 0)
		{
			return;
		}
		RoleAudioComponent roleAudioComponent = (entity != null) ? entity.GetComponent<RoleAudioComponent>() : null;
		UAkComponent uakComponent = (roleAudioComponent != null) ? roleAudioComponent.GetAkComponent(null) : null;
		if (entity == null || roleAudioComponent == null || uakComponent == null)
		{
			return;
		}
		double now = Time.Instance.Now;
		double num = now - this.LastDodgeTime;
		int num2 = (this.LastDodgeLevelIndex < this.DodgeProgressionAudioResetList.Count) ? this.DodgeProgressionAudioResetList[this.LastDodgeLevelIndex] : this.DodgeProgressionAudioResetList[0];
		if (this.LastDodgeTime > 0.0 && num >= (double)num2)
		{
			this.CurrentDodgeTimes = 0;
		}
		int num3 = 0;
		for (int i = this.DodgeProgressionAudioTimesList.Count - 1; i >= 0; i--)
		{
			if (this.CurrentDodgeTimes >= this.DodgeProgressionAudioTimesList[i])
			{
				num3 = i;
				break;
			}
		}
		string @event = this.DodgeProgressionAudioEventList[num3];
		AudioSystem.Instance.PostEvent(@event, uakComponent, null);
		this.CurrentDodgeTimes++;
		this.LastDodgeLevelIndex = num3;
		this.LastDodgeTime = now;
	}

	// Token: 0x060198D8 RID: 104664 RVA: 0x007D8697 File Offset: 0x007D6897
	public void ResetDodgeAudioLevel()
	{
		this.CurrentDodgeTimes = 0;
	}

	// Token: 0x060198D9 RID: 104665 RVA: 0x007D86A0 File Offset: 0x007D68A0
	public bool CheckSkillAudioId(long id)
	{
		return this.SkillAudioId.Contains((int)id);
	}

	// Token: 0x060198DA RID: 104666 RVA: 0x007D86B0 File Offset: 0x007D68B0
	public string GetRoleAudioConfig(ERoleAudioType type, RoleSkinAudio? config)
	{
		if (config == null)
		{
			return "";
		}
		switch (type)
		{
		case ERoleAudioType.FastClimb:
			return config.Value.FastClimbEvent;
		case ERoleAudioType.Glide:
			return config.Value.EnterGlideEvent;
		case ERoleAudioType.ClimbLeap:
			return config.Value.ClimbLeapEvent;
		case (ERoleAudioType)1004:
			break;
		case ERoleAudioType.UseHookSkill:
			return config.Value.UseExploreHookEvent;
		case ERoleAudioType.ScanTreasureBox:
			return config.Value.ScanTreasureBoxEvent;
		case ERoleAudioType.OpenTreasureBox:
			return config.Value.OpenTreasureBoxEvent;
		case ERoleAudioType.Accelerate:
			return config.Value.AccelerateEvent;
		default:
			switch (type)
			{
			case ERoleAudioType.VisionMorph:
				return config.Value.VisionMorphEvent;
			case ERoleAudioType.VisionSummon:
				return config.Value.VisionSummonEvent;
			case ERoleAudioType.Dodge:
				return config.Value.ExtremeDodgeEvent;
			case ERoleAudioType.Parry:
				return config.Value.ParryEvent;
			case ERoleAudioType.EnterBattle:
				return config.Value.EnterBattleEvent;
			case ERoleAudioType.UnderAttack:
				return config.Value.UnderAttackEvent;
			case ERoleAudioType.KnockUp:
				return config.Value.KnockUpEvent;
			}
			break;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.CWZ;
		string message = "[RoleAudio] 错误的类型";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return "";
	}

	// Token: 0x060198DB RID: 104667 RVA: 0x007D883C File Offset: 0x007D6A3C
	public string GetRoleAudioTypeDesc(ERoleAudioType type)
	{
		if (type <= ERoleAudioType.Accelerate)
		{
			if (type == ERoleAudioType.Global)
			{
				return "全局";
			}
			switch (type)
			{
			case ERoleAudioType.FastClimb:
				return "快速攀爬";
			case ERoleAudioType.Glide:
				return "滑翔";
			case ERoleAudioType.ClimbLeap:
				return "跨越";
			case ERoleAudioType.UseHookSkill:
				return "使用钩锁技能";
			case ERoleAudioType.ScanTreasureBox:
				return "扫描到宝箱";
			case ERoleAudioType.OpenTreasureBox:
				return "开宝箱";
			case ERoleAudioType.Accelerate:
				return "加速";
			}
		}
		else
		{
			switch (type)
			{
			case ERoleAudioType.VisionMorph:
				return "幻象变身";
			case ERoleAudioType.VisionSummon:
				return "幻象召唤";
			case (ERoleAudioType)2003:
				break;
			case ERoleAudioType.Dodge:
				return "闪避";
			case ERoleAudioType.Parry:
				return "弹反";
			case ERoleAudioType.EnterBattle:
				return "进战";
			case ERoleAudioType.UnderAttack:
				return "受击";
			case ERoleAudioType.KnockUp:
				return "被击飞";
			default:
				if (type - ERoleAudioType.StrengthChangeTired <= 1)
				{
					return "体力变化";
				}
				break;
			}
		}
		return "未定义";
	}

	// Token: 0x170028C9 RID: 10441
	// (get) Token: 0x060198DC RID: 104668 RVA: 0x007D8922 File Offset: 0x007D6B22
	public static RoleAudioController Instance
	{
		get
		{
			return RoleAudioController._Instance;
		}
	}

	// Token: 0x060198DD RID: 104669 RVA: 0x007D8929 File Offset: 0x007D6B29
	public static RoleAudioController GetOrCreateInstance()
	{
		if (RoleAudioController._Instance == null)
		{
			RoleAudioController.CreateInstance();
		}
		return RoleAudioController._Instance;
	}

	// Token: 0x060198DE RID: 104670 RVA: 0x007D893D File Offset: 0x007D6B3D
	public static bool CreateInstance()
	{
		if (RoleAudioController._Instance != null)
		{
			return true;
		}
		RoleAudioController._Instance = new RoleAudioController();
		return true;
	}

	// Token: 0x060198DF RID: 104671 RVA: 0x007D8953 File Offset: 0x007D6B53
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060198E0 RID: 104672 RVA: 0x007D8955 File Offset: 0x007D6B55
	public static void ResetStaticDefaultValue()
	{
		RoleAudioController._Instance = null;
	}

	// Token: 0x060198E1 RID: 104673 RVA: 0x007D895D File Offset: 0x007D6B5D
	static RoleAudioController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleAudioController.CreateStaticDefaultValue), new Action(RoleAudioController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E014 RID: 57364
	[Nullable(2)]
	private List<int> FixHookSkillList;

	// Token: 0x0400E015 RID: 57365
	[Nullable(2)]
	private List<int> SuperSprintStartSkillList;

	// Token: 0x0400E016 RID: 57366
	[Nullable(2)]
	private List<int> SuperSprintEndSkillList;

	// Token: 0x0400E017 RID: 57367
	[Nullable(2)]
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400E018 RID: 57368
	[Nullable(2)]
	private RoleAudioComponent AudioComponent;

	// Token: 0x0400E019 RID: 57369
	private double LowStrengthPercentage;

	// Token: 0x0400E01A RID: 57370
	private readonly HashSet<int> SkillAudioId = new HashSet<int>();

	// Token: 0x0400E01B RID: 57371
	private readonly Dictionary<ERoleAudioType, RoleAudioCoolDownTime> IntervalCoolDownTimeMap = new Dictionary<ERoleAudioType, RoleAudioCoolDownTime>();

	// Token: 0x0400E01C RID: 57372
	private int IntervalTime = 500;

	// Token: 0x0400E01D RID: 57373
	private double LastTime;

	// Token: 0x0400E01E RID: 57374
	private bool LastSetDynamicTrace;

	// Token: 0x0400E01F RID: 57375
	private bool UpdateDynamicTrace;

	// Token: 0x0400E020 RID: 57376
	private bool ForceUpdateDynamicTrace;

	// Token: 0x0400E021 RID: 57377
	private int RoleAudioIgnoreType;

	// Token: 0x0400E022 RID: 57378
	private readonly List<string> LastAudioEvents = new List<string>();

	// Token: 0x0400E023 RID: 57379
	private readonly List<string> CacheList = new List<string>();

	// Token: 0x0400E024 RID: 57380
	private int AccelerateAudioHandle;

	// Token: 0x0400E025 RID: 57381
	[Nullable(2)]
	private List<int> DodgeProgressionAudioResetList;

	// Token: 0x0400E026 RID: 57382
	[Nullable(2)]
	private List<int> DodgeProgressionAudioTimesList;

	// Token: 0x0400E027 RID: 57383
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> DodgeProgressionAudioEventList;

	// Token: 0x0400E028 RID: 57384
	private double LastDodgeTime;

	// Token: 0x0400E029 RID: 57385
	private int LastDodgeLevelIndex;

	// Token: 0x0400E02A RID: 57386
	private int CurrentDodgeTimes;

	// Token: 0x0400E02B RID: 57387
	[Nullable(2)]
	private static RoleAudioController _Instance;
}
