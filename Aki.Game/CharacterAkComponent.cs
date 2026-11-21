using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x0200259C RID: 9628
[NullableContext(1)]
[Nullable(0)]
public class CharacterAkComponent : EntityComponent
{
	// Token: 0x17002523 RID: 9507
	// (get) Token: 0x06017D4B RID: 97611 RVA: 0x007124D1 File Offset: 0x007106D1
	public override Type[] Dependencies
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

	// Token: 0x06017D4C RID: 97612 RVA: 0x007124F3 File Offset: 0x007106F3
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.DynamicConditionProxy = new AkComponentDynamicConditionProxy();
		this.AudioResult = new PlayResult();
		return true;
	}

	// Token: 0x06017D4D RID: 97613 RVA: 0x0071250C File Offset: 0x0071070C
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

	// Token: 0x06017D4E RID: 97614 RVA: 0x007125A7 File Offset: 0x007107A7
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

	// Token: 0x06017D4F RID: 97615 RVA: 0x007125E8 File Offset: 0x007107E8
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

	// Token: 0x06017D50 RID: 97616 RVA: 0x007126D8 File Offset: 0x007108D8
	private void UpdateSwitch()
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.Valid)
		{
			return;
		}
		GameAudioController.Instance.SetRolePriority(this.IsP1 ? ERoleAudioPriorityType.PlayerControl : ERoleAudioPriorityType.OtherControl, this.ActorComp.Actor);
	}

	// Token: 0x06017D51 RID: 97617 RVA: 0x00712714 File Offset: 0x00710914
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

	// Token: 0x06017D52 RID: 97618 RVA: 0x00712884 File Offset: 0x00710A84
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

	// Token: 0x06017D53 RID: 97619 RVA: 0x007129C8 File Offset: 0x00710BC8
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

	// Token: 0x06017D54 RID: 97620 RVA: 0x007129F0 File Offset: 0x00710BF0
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

	// Token: 0x06017D55 RID: 97621 RVA: 0x00712AB8 File Offset: 0x00710CB8
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

	// Token: 0x06017D56 RID: 97622 RVA: 0x00712B60 File Offset: 0x00710D60
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

	// Token: 0x06017D57 RID: 97623 RVA: 0x00712C0C File Offset: 0x00710E0C
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

	// Token: 0x06017D58 RID: 97624 RVA: 0x00712CAC File Offset: 0x00710EAC
	public void SetDebug(bool bDebug)
	{
		this.Debug = bDebug;
	}

	// Token: 0x06017D59 RID: 97625 RVA: 0x00712CB5 File Offset: 0x00710EB5
	public bool GetDebug()
	{
		return this.Debug;
	}

	// Token: 0x06017D5A RID: 97626 RVA: 0x00712CC0 File Offset: 0x00710EC0
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

	// Token: 0x06017D5B RID: 97627 RVA: 0x00712E24 File Offset: 0x00711024
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

	// Token: 0x06017D5C RID: 97628 RVA: 0x00712F5C File Offset: 0x0071115C
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

	// Token: 0x06017D5D RID: 97629 RVA: 0x00712FF4 File Offset: 0x007111F4
	public void SetFoleySynthFileDebug(bool debug, int[] models)
	{
		FoleySynthController foleySynthController = this.FoleySynthController;
		if (foleySynthController == null)
		{
			return;
		}
		foleySynthController.SetDebug(debug, models);
	}

	// Token: 0x06017D5E RID: 97630 RVA: 0x00713008 File Offset: 0x00711208
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

	// Token: 0x06017D5F RID: 97631 RVA: 0x0071304C File Offset: 0x0071124C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterAkComponent characterAkComponent = (CharacterAkComponent)componentTemplate;
		if (characterAkComponent.CreatureData == null)
		{
			this.CreatureData = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureData), "CreatureData"))
		{
			return false;
		}
		if (characterAkComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterAkComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (characterAkComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		this.IsFirstGet = characterAkComponent.IsFirstGet;
		this.IsRole = characterAkComponent.IsRole;
		this.IsP1 = characterAkComponent.IsP1;
		this.AkComponentConfig = characterAkComponent.AkComponentConfig;
		if (characterAkComponent.FoleySynthAllConfig != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.FoleySynthAllConfig), "FoleySynthAllConfig"))
		{
			return false;
		}
		this.Debug = characterAkComponent.Debug;
		this.WaterDepth = characterAkComponent.WaterDepth;
		if (characterAkComponent.FoleySynthController == null)
		{
			this.FoleySynthController = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FoleySynthController), "FoleySynthController"))
		{
			return false;
		}
		if (characterAkComponent.DynamicConditionProxy == null)
		{
			this.DynamicConditionProxy = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DynamicConditionProxy), "DynamicConditionProxy"))
		{
			return false;
		}
		this.FootSwitch = characterAkComponent.FootSwitch;
		this.LastUpdateEnvironmentAudioTime = characterAkComponent.LastUpdateEnvironmentAudioTime;
		if (characterAkComponent.LastUpdateEnvironmentAudioLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastUpdateEnvironmentAudioLocation), "LastUpdateEnvironmentAudioLocation"))
		{
			return false;
		}
		if (characterAkComponent.AudioResult == null)
		{
			this.AudioResult = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AudioResult), "AudioResult"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002524 RID: 9508
	// (get) Token: 0x06017D60 RID: 97632 RVA: 0x0071323D File Offset: 0x0071143D
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002525 RID: 9509
	// (get) Token: 0x06017D61 RID: 97633 RVA: 0x00713240 File Offset: 0x00711440
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002526 RID: 9510
	// (get) Token: 0x06017D62 RID: 97634 RVA: 0x00713243 File Offset: 0x00711443
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002527 RID: 9511
	// (get) Token: 0x06017D63 RID: 97635 RVA: 0x00713246 File Offset: 0x00711446
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06017D65 RID: 97637 RVA: 0x00713268 File Offset: 0x00711468
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

	// Token: 0x0400CB7C RID: 52092
	private const int DEBUG_RADIUS = 15;

	// Token: 0x0400CB7D RID: 52093
	private const int DEBUG_SEG = 12;

	// Token: 0x0400CB7E RID: 52094
	public const string ROLE_MOVE_GROUP = "role_move";

	// Token: 0x0400CB7F RID: 52095
	private const int ENVIRONMENT_AUDIO_UPDATE_INTERVAL = 500;

	// Token: 0x0400CB80 RID: 52096
	private const int ENVIRONMENT_AUDIO_UPDATE_DIST_SQUARED = 4;

	// Token: 0x0400CB81 RID: 52097
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<EEntityType, string> AUDIO_ENTITY_TYPE_VOLUME_CONTROL;

	// Token: 0x0400CB82 RID: 52098
	[Nullable(2)]
	private CreatureDataComponent CreatureData;

	// Token: 0x0400CB83 RID: 52099
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CB84 RID: 52100
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x0400CB85 RID: 52101
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400CB86 RID: 52102
	private bool IsFirstGet;

	// Token: 0x0400CB87 RID: 52103
	public bool IsRole;

	// Token: 0x0400CB88 RID: 52104
	public bool IsP1;

	// Token: 0x0400CB89 RID: 52105
	public EntityAudioConfig? AkComponentConfig;

	// Token: 0x0400CB8A RID: 52106
	[Nullable(2)]
	private readonly FoleySynthAllConfig FoleySynthAllConfig;

	// Token: 0x0400CB8B RID: 52107
	private bool Debug;

	// Token: 0x0400CB8C RID: 52108
	public double WaterDepth;

	// Token: 0x0400CB8D RID: 52109
	[Nullable(2)]
	private FoleySynthController FoleySynthController;

	// Token: 0x0400CB8E RID: 52110
	public AkComponentDynamicConditionProxy DynamicConditionProxy;

	// Token: 0x0400CB8F RID: 52111
	public string FootSwitch = "";

	// Token: 0x0400CB90 RID: 52112
	private double LastUpdateEnvironmentAudioTime;

	// Token: 0x0400CB91 RID: 52113
	private readonly global::Vector LastUpdateEnvironmentAudioLocation = global::Vector.Create();

	// Token: 0x0400CB92 RID: 52114
	private PlayResult AudioResult;
}
