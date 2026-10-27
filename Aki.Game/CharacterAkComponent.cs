using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02003046 RID: 12358
[NullableContext(1)]
[Nullable(0)]
public class CharacterAkComponent : EntityComponent, IComponentDependency
{
	// Token: 0x17002425 RID: 9253
	// (get) Token: 0x0601A3CF RID: 107471 RVA: 0x006EAD19 File Offset: 0x006E8F19
	public static Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent),
				typeof(CreatureDataComponent)
			};
		}
	}

	// Token: 0x0601A3D0 RID: 107472 RVA: 0x006EAD3B File Offset: 0x006E8F3B
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.DynamicConditionProxy = new AkComponentDynamicConditionProxy();
		this.AudioResult = new PlayResult();
		return true;
	}

	// Token: 0x0601A3D1 RID: 107473 RVA: 0x006EAD54 File Offset: 0x006E8F54
	protected override bool OnStart()
	{
		this.CreatureData = base.Entity.GetComponent<CreatureDataComponent>();
		if (this.CreatureData == null)
		{
			return false;
		}
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		CharacterActorComponent actorComp = this.ActorComp;
		if (((actorComp != null) ? actorComp.Actor : null) == null)
		{
			return false;
		}
		this.MoveComp = base.Entity.GetComponent<BaseMoveComponent>();
		if (this.MoveComp == null)
		{
			return false;
		}
		this.Debug = false;
		this.IsFirstGet = true;
		AkComponentStatic.Load();
		this.DynamicConditionProxy.Init(this.ActorComp, this.AkComponentConfig.Value);
		return true;
	}

	// Token: 0x0601A3D2 RID: 107474 RVA: 0x006EADEF File Offset: 0x006E8FEF
	protected override void OnTick(float delta)
	{
		if (this.Debug)
		{
			this.DebugText();
		}
		if (this.IsRole && this.IsP1)
		{
			this.UpdateMoveState();
			this.UpdateAudioEnvironment();
			if (this.FoleySynthController != null)
			{
				this.FoleySynthController.Tick(delta);
			}
		}
	}

	// Token: 0x0601A3D3 RID: 107475 RVA: 0x006EAE30 File Offset: 0x006E9030
	protected override void OnActivate()
	{
		CreatureDataComponent creatureData = this.CreatureData;
		this.IsRole = (creatureData != null && creatureData.GetEntityType() == EEntityType.Player);
		this.IsP1 = false;
		if (this.IsRole)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null && actorComp.IsAutonomousProxy)
			{
				this.IsP1 = true;
				goto IL_93;
			}
		}
		CreatureDataComponent creatureData2 = this.CreatureData;
		if (creatureData2 != null && creatureData2.IsConcomitantEntity)
		{
			long summonerId = this.CreatureData.GetSummonerId();
			int entityId = CreatureModel.Instance.GetEntityId(summonerId);
			CharacterAkComponent component = EntitySystem.Instance.GetComponent<CharacterAkComponent>(entityId);
			if (component != null && component.IsP1)
			{
				this.IsP1 = true;
			}
		}
		IL_93:
		if (this.IsRole)
		{
			this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
			if (this.IsP1)
			{
				this.FoleySynthController = new FoleySynthController(this.ActorComp, this, this.TagComp);
				this.FoleySynthController.Init(this.FoleySynthAllConfig);
			}
		}
		this.UpdateSwitch();
	}

	// Token: 0x0601A3D4 RID: 107476 RVA: 0x006EAF20 File Offset: 0x006E9120
	private void UpdateSwitch()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.Valid)
		{
			return;
		}
		GameAudioController.Instance.SetRolePriority(this.IsP1 ? ERoleAudioPriorityType.PlayerControl : ERoleAudioPriorityType.OtherControl, this.ActorComp.Actor);
	}

	// Token: 0x0601A3D5 RID: 107477 RVA: 0x006EAF5C File Offset: 0x006E915C
	private void UpdateMoveState()
	{
		if (AkComponentStatic.AkMoveState == EAkMoveState.Normal)
		{
			using (Dictionary<EAkMoveState, int>.Enumerator enumerator = AkComponentStatic.AkMoveStateMap.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<EAkMoveState, int> keyValuePair = enumerator.Current;
					EAkMoveState key = keyValuePair.Key;
					int value = keyValuePair.Value;
					BaseTagComponent tagComp = this.TagComp;
					if (tagComp != null && tagComp.HasTag(value))
					{
						AkComponentStatic.AkMoveState = key;
						AudioSystem.Instance.SetState("role_move", key.ToString(), true);
						break;
					}
				}
				return;
			}
		}
		int valueOrDefault = AkComponentStatic.AkMoveStateMap.GetValueOrDefault(AkComponentStatic.AkMoveState, 0);
		BaseTagComponent tagComp2 = this.TagComp;
		if (tagComp2 != null && tagComp2.HasTag(valueOrDefault))
		{
			return;
		}
		foreach (KeyValuePair<EAkMoveState, int> keyValuePair2 in AkComponentStatic.AkMoveStateMap)
		{
			EAkMoveState key2 = keyValuePair2.Key;
			int value2 = keyValuePair2.Value;
			BaseTagComponent tagComp3 = this.TagComp;
			if (tagComp3 != null && tagComp3.HasTag(value2))
			{
				AkComponentStatic.AkMoveState = key2;
				AudioSystem.Instance.SetState("role_move", key2.ToString(), true);
				return;
			}
		}
		AkComponentStatic.AkMoveState = EAkMoveState.Normal;
		AudioSystem.Instance.SetState("role_move", "Normal", true);
	}

	// Token: 0x0601A3D6 RID: 107478 RVA: 0x006EB0CC File Offset: 0x006E92CC
	private void RefreshEntityTypesVolumeControl()
	{
		CreatureDataComponent creatureData = this.CreatureData;
		EEntityType? eentityType = (creatureData != null) ? new EEntityType?(creatureData.GetEntityType()) : null;
		CharacterActorComponent actorComp = this.ActorComp;
		TsBaseCharacter tsBaseCharacter = (actorComp != null) ? actorComp.Actor : null;
		if (eentityType != null && tsBaseCharacter != null)
		{
			foreach (KeyValuePair<EEntityType, string> keyValuePair in CharacterAkComponent.AUDIO_ENTITY_TYPE_VOLUME_CONTROL)
			{
				EEntityType key = keyValuePair.Key;
				string value = keyValuePair.Value;
				EEntityType? eentityType2 = eentityType;
				EEntityType eentityType3 = key;
				if (eentityType2.GetValueOrDefault() == eentityType3 & eentityType2 != null)
				{
					AudioSystem.Instance.SetRtpcValue(value, 1f, new SetRtpcValueArgs?(new SetRtpcValueArgs
					{
						Actor = tsBaseCharacter
					}));
				}
				else
				{
					AudioSystem.Instance.SetRtpcValue(value, 0f, new SetRtpcValueArgs?(new SetRtpcValueArgs
					{
						Actor = tsBaseCharacter
					}));
				}
			}
			return;
		}
		if (eentityType == null)
		{
			throw new Exception("实体类型设置音量控制: 无法获取实体类型");
		}
		if (tsBaseCharacter == null)
		{
			Log.Instance.Warn(ELogModule.Audio, ELogAuthor.YJY, "实体类型设置音量控制: 无法获取角色Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x0601A3D7 RID: 107479 RVA: 0x006EB210 File Offset: 0x006E9410
	protected override bool OnEnd()
	{
		this.DynamicConditionProxy.Clear();
		if (this.FoleySynthController != null)
		{
			this.FoleySynthController.Clear();
		}
		this.IsFirstGet = true;
		return true;
	}

	// Token: 0x0601A3D8 RID: 107480 RVA: 0x006EB238 File Offset: 0x006E9438
	public void PostAudioEvent(string action)
	{
		int roleId = base.Entity.GetComponent<CreatureDataComponent>().GetRoleId();
		RoleAnimAudioData audioPathByName = RoleModel.Instance.GetRoleDataById(roleId, true).GetAudioData().GetAudioPathByName(action);
		if (audioPathByName == null)
		{
			return;
		}
		if (!string.IsNullOrEmpty(this.AudioResult.EventPath) && !audioPathByName.CanInterrupt)
		{
			return;
		}
		string audioPath = audioPathByName.AudioPath;
		if (this.AudioResult.EventPath == audioPath)
		{
			return;
		}
		AudioController.Instance.StopEvent(this.AudioResult, true, null);
		if (!string.IsNullOrEmpty(audioPath))
		{
			AudioController.Instance.PostEvent(audioPath, this.ActorComp.Actor, this.AudioResult, null, null, null, true, "");
		}
	}

	// Token: 0x0601A3D9 RID: 107481 RVA: 0x006EB300 File Offset: 0x006E9500
	public unsafe void SetSwitchByData(UAkComponent charAkComponent, string[] switchData)
	{
		for (int i = 0; i < switchData.Length; i++)
		{
			string[] array = switchData[i].Split('.', StringSplitOptions.None);
			if (array.Length == 2)
			{
				charAkComponent.SetSwitch(null, array[0], array[1]);
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[PostAkEvent] switchData配置无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActorName:", this.ActorComp.Actor.GetName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("switchArray:", array);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
	}

	// Token: 0x0601A3DA RID: 107482 RVA: 0x006EB3A8 File Offset: 0x006E95A8
	public unsafe void SetSwitchByUeData(UAkComponent charAkComponent, TArray<string> switchData)
	{
		for (int i = 0; i < switchData.Num(); i++)
		{
			string[] array = switchData.Get(i).Split('.', StringSplitOptions.None);
			if (array.Length == 2)
			{
				charAkComponent.SetSwitch(null, array[0], array[1]);
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[PostAkEvent] switchData配置无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActorName:", this.ActorComp.Actor.GetName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("switchArray:", array);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
	}

	// Token: 0x0601A3DB RID: 107483 RVA: 0x006EB454 File Offset: 0x006E9654
	public int PostAkEvent(UAkComponent charAkComponent, [Nullable(2)] UAkAudioEvent eventPtr, string attachName, TArray<string> switchData, bool bFollow)
	{
		if (eventPtr == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[PostAkEvent] eventPtr无效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActorName:", this.ActorComp.Actor.GetName());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return -1;
		}
		this.SetSwitchByUeData(charAkComponent, switchData);
		this.DynamicConditionProxy.Do(this.ActorComp);
		if (bFollow)
		{
			int callbackMask = 0;
			FOnAkPostEventCallback fonAkPostEventCallback = null;
			return charAkComponent.PostAkEvent(eventPtr, callbackMask, fonAkPostEventCallback, eventPtr.GetName());
		}
		return UAkGameplayStatics.D_PostEventAtLocation(eventPtr, this.ActorComp.ActorLocation, global::Rotator.ZeroRotator, eventPtr.GetName(), this.ActorComp.Actor);
	}

	// Token: 0x0601A3DC RID: 107484 RVA: 0x006EB4F4 File Offset: 0x006E96F4
	public void SetDebug(bool bDebug)
	{
		this.Debug = bDebug;
	}

	// Token: 0x0601A3DD RID: 107485 RVA: 0x006EB4FD File Offset: 0x006E96FD
	public bool GetDebug()
	{
		return this.Debug;
	}

	// Token: 0x0601A3DE RID: 107486 RVA: 0x006EB508 File Offset: 0x006E9708
	private unsafe void DebugText()
	{
		TsBaseCharacter actor = this.ActorComp.Actor;
		string name = actor.GetName();
		TArray<UActorComponent> tarray = actor.K2_GetComponentsByClass(UAkComponent.StaticClass());
		Log.Instance.Info(ELogModule.Audio, ELogAuthor.LJM, "---------------------------------------------", default(ReadOnlySpan<ValueTuple<string, object>>));
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "CharacterAkComponent Tick Debug;";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor:", name);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		for (int i = 0; i < tarray.Num(); i++)
		{
			UAkComponent uakComponent = tarray.Get(i) as UAkComponent;
			if (uakComponent != null)
			{
				FVectorDouble center = uakComponent.D_K2_GetComponentLocation();
				UKismetSystemLibrary.D_DrawDebugSphere(actor, center, 15f, 12, new FLinearColor?(ColorUtils.LinearRed), 0f, 0f);
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Audio;
				ELogAuthor author2 = ELogAuthor.LJM;
				string message2 = "-----------AkComponent信息:";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Comp:", uakComponent);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AttachSocketName:", uakComponent.AttachSocketName);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.Audio;
		ELogAuthor author3 = ELogAuthor.LJM;
		string message3 = "-----------AkStatic信息:";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("State:", AkComponentStatic.AkMoveState);
		instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
	}

	// Token: 0x0601A3DF RID: 107487 RVA: 0x006EB66C File Offset: 0x006E986C
	public UAkComponent GetAkComponentBySocketName(FName socketName)
	{
		FName fname = socketName;
		if (FNameUtil.IsEmpty(new FName?(fname)))
		{
			fname = CharacterNameDefines.Instance.HIT_CASE_NAME;
		}
		TsBaseCharacter actor = this.ActorComp.Actor;
		UAkComponent uakComponent;
		if (this.IsFirstGet)
		{
			uakComponent = (actor.GetComponentByClass(UAkComponent.StaticClass()) as UAkComponent);
			this.IsFirstGet = false;
			if (uakComponent == null)
			{
				uakComponent = (actor.AddComponentByClass(UAkComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UAkComponent);
			}
		}
		else
		{
			uakComponent = (actor.AddComponentByClass(UAkComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UAkComponent);
		}
		uakComponent.K2_AttachToComponent(this.ActorComp.Actor.Mesh, fname, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, true, true);
		CreatureDataComponent creatureData = this.CreatureData;
		EEntityType? eentityType = (creatureData != null) ? new EEntityType?(creatureData.GetEntityType()) : null;
		if (eentityType.GetValueOrDefault() == EEntityType.Npc || eentityType.GetValueOrDefault() == EEntityType.Monster)
		{
			uakComponent.bEnableOcclusion = true;
		}
		this.UpdateSwitch();
		this.DynamicConditionProxy.Init(this.ActorComp, this.AkComponentConfig.Value);
		this.RefreshEntityTypesVolumeControl();
		return uakComponent;
	}

	// Token: 0x0601A3E0 RID: 107488 RVA: 0x006EB7A4 File Offset: 0x006E99A4
	private void UpdateAudioEnvironment()
	{
		if (Time.Instance.Now - this.LastUpdateEnvironmentAudioTime > 500.0)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp == null || !actorComp.Valid)
			{
				this.LastUpdateEnvironmentAudioTime = Time.Instance.Now;
				return;
			}
			if (global::Vector.DistSquared(this.LastUpdateEnvironmentAudioLocation, this.ActorComp.ActorLocationProxy) > 4.0)
			{
				this.LastUpdateEnvironmentAudioLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
				this.LastUpdateEnvironmentAudioTime = Time.Instance.Now;
			}
		}
	}

	// Token: 0x0601A3E1 RID: 107489 RVA: 0x006EB83C File Offset: 0x006E9A3C
	public void SetFoleySynthFileDebug(bool debug, int[] models)
	{
		FoleySynthController foleySynthController = this.FoleySynthController;
		if (foleySynthController == null)
		{
			return;
		}
		foleySynthController.SetDebug(debug, models);
	}

	// Token: 0x0601A3E2 RID: 107490 RVA: 0x006EB850 File Offset: 0x006E9A50
	public static void SetGlobalCharacterFoleySynthFileDebug(bool debug, int[] models)
	{
		if (Global.BaseCharacter == null)
		{
			return;
		}
		CharacterAkComponent component = Global.BaseCharacter.CharacterActorComponent.Entity.GetComponent<CharacterAkComponent>();
		if (component == null)
		{
			return;
		}
		if (models.Length != 0)
		{
			component.SetFoleySynthFileDebug(debug, models);
			return;
		}
		component.SetDebug(debug);
	}

	// Token: 0x0601A3E3 RID: 107491 RVA: 0x006EB894 File Offset: 0x006E9A94
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterAkComponent characterAkComponent = (CharacterAkComponent)componentTemplate;
		if (base.CanResetComponentProperty("CreatureData"))
		{
			if (characterAkComponent.CreatureData == null)
			{
				this.CreatureData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureData), "CreatureData"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterAkComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (characterAkComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (characterAkComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsFirstGet"))
		{
			this.IsFirstGet = characterAkComponent.IsFirstGet;
		}
		if (base.CanResetComponentProperty("IsRole"))
		{
			this.IsRole = characterAkComponent.IsRole;
		}
		if (base.CanResetComponentProperty("IsP1"))
		{
			this.IsP1 = characterAkComponent.IsP1;
		}
		if (base.CanResetComponentProperty("AkComponentConfig"))
		{
			this.AkComponentConfig = characterAkComponent.AkComponentConfig;
		}
		if (base.CanResetComponentProperty("FoleySynthAllConfig") && characterAkComponent.FoleySynthAllConfig != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<FoleySynthAllConfig>(this.FoleySynthAllConfig), "FoleySynthAllConfig"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("Debug"))
		{
			this.Debug = characterAkComponent.Debug;
		}
		if (base.CanResetComponentProperty("WaterDepth"))
		{
			this.WaterDepth = characterAkComponent.WaterDepth;
		}
		if (base.CanResetComponentProperty("FoleySynthController"))
		{
			if (characterAkComponent.FoleySynthController == null)
			{
				this.FoleySynthController = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<FoleySynthController>(this.FoleySynthController), "FoleySynthController"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DynamicConditionProxy"))
		{
			if (characterAkComponent.DynamicConditionProxy == null)
			{
				this.DynamicConditionProxy = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AkComponentDynamicConditionProxy>(this.DynamicConditionProxy), "DynamicConditionProxy"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("FootSwitch"))
		{
			this.FootSwitch = characterAkComponent.FootSwitch;
		}
		if (base.CanResetComponentProperty("LastUpdateEnvironmentAudioTime"))
		{
			this.LastUpdateEnvironmentAudioTime = characterAkComponent.LastUpdateEnvironmentAudioTime;
		}
		if (base.CanResetComponentProperty("LastUpdateEnvironmentAudioLocation") && characterAkComponent.LastUpdateEnvironmentAudioLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.LastUpdateEnvironmentAudioLocation), "LastUpdateEnvironmentAudioLocation"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("AudioResult"))
		{
			if (characterAkComponent.AudioResult == null)
			{
				this.AudioResult = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PlayResult>(this.AudioResult), "AudioResult"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601A3E5 RID: 107493 RVA: 0x006EBB80 File Offset: 0x006E9D80
	// Note: this type is marked as 'beforefieldinit'.
	static CharacterAkComponent()
	{
		Dictionary<EEntityType, string> dictionary = new Dictionary<EEntityType, string>();
		dictionary[EEntityType.Animal] = "entity_type_volume_control_animal";
		dictionary[EEntityType.Custom] = "entity_type_volume_control_custom_other";
		dictionary[EEntityType.Monster] = "entity_type_volume_control_monster";
		dictionary[EEntityType.Npc] = "entity_type_volume_control_npc";
		dictionary[EEntityType.Player] = "entity_type_volume_control_player_role";
		dictionary[EEntityType.SceneItem] = "entity_type_volume_control_scene_item";
		dictionary[EEntityType.Vision] = "entity_type_volume_control_vision";
		CharacterAkComponent.AUDIO_ENTITY_TYPE_VOLUME_CONTROL = dictionary;
	}

	// Token: 0x0400C7A2 RID: 51106
	private const int DEBUG_RADIUS = 15;

	// Token: 0x0400C7A3 RID: 51107
	private const int DEBUG_SEG = 12;

	// Token: 0x0400C7A4 RID: 51108
	public const string ROLE_MOVE_GROUP = "role_move";

	// Token: 0x0400C7A5 RID: 51109
	private const int ENVIRONMENT_AUDIO_UPDATE_INTERVAL = 500;

	// Token: 0x0400C7A6 RID: 51110
	private const int ENVIRONMENT_AUDIO_UPDATE_DIST_SQUARED = 4;

	// Token: 0x0400C7A7 RID: 51111
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<EEntityType, string> AUDIO_ENTITY_TYPE_VOLUME_CONTROL;

	// Token: 0x0400C7A8 RID: 51112
	[Nullable(2)]
	private CreatureDataComponent CreatureData;

	// Token: 0x0400C7A9 RID: 51113
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400C7AA RID: 51114
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x0400C7AB RID: 51115
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400C7AC RID: 51116
	private bool IsFirstGet;

	// Token: 0x0400C7AD RID: 51117
	public bool IsRole;

	// Token: 0x0400C7AE RID: 51118
	public bool IsP1;

	// Token: 0x0400C7AF RID: 51119
	public EntityAudioConfig? AkComponentConfig;

	// Token: 0x0400C7B0 RID: 51120
	[Nullable(2)]
	private readonly FoleySynthAllConfig FoleySynthAllConfig;

	// Token: 0x0400C7B1 RID: 51121
	private bool Debug;

	// Token: 0x0400C7B2 RID: 51122
	public double WaterDepth;

	// Token: 0x0400C7B3 RID: 51123
	[Nullable(2)]
	private FoleySynthController FoleySynthController;

	// Token: 0x0400C7B4 RID: 51124
	public AkComponentDynamicConditionProxy DynamicConditionProxy;

	// Token: 0x0400C7B5 RID: 51125
	public string FootSwitch = "";

	// Token: 0x0400C7B6 RID: 51126
	private double LastUpdateEnvironmentAudioTime;

	// Token: 0x0400C7B7 RID: 51127
	private readonly global::Vector LastUpdateEnvironmentAudioLocation = global::Vector.Create();

	// Token: 0x0400C7B8 RID: 51128
	private PlayResult AudioResult;
}
