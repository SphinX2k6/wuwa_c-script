using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020025DF RID: 9695
[NullableContext(1)]
[Nullable(0)]
public class CharacterSkinDamageComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x0601827E RID: 98942 RVA: 0x0074129C File Offset: 0x0073F49C
	static CharacterSkinDamageComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterSkinDamageComponent.CreateStaticDefaultValue), new Action(CharacterSkinDamageComponent.ResetStaticDefaultValue));
	}

	// Token: 0x0601827F RID: 98943 RVA: 0x00741340 File Offset: 0x0073F540
	protected override bool OnStart()
	{
		this.CreatureDataComp = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.ActorComp = base.Entity.CheckGetComponent<CharacterActorComponent>();
		this.TagComp = base.Entity.CheckGetComponent<BaseTagComponent>();
		this.MaterialPropertyValue = -1f;
		this.SkinDamageType = ESkinDamageType.Normal;
		EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		EventSystem.Instance.Add(EEventName.OnRoleGoDown, new Action<int>(this.OnRoleGoDown));
		EventSystem.Instance.Add(EEventName.OnResetSkinDamageMode, new Action(this.OnResetSkinDamageMode));
		EventSystem.Instance.AddWithTarget<HitInformation, HitContext>(base.Entity, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnBeHit));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnRevive, new Action(this.OnRevive));
		EventSystem.Instance.AddWithTarget<bool>(base.Entity, EEventName.TeleportStartEntity, new Action<bool>(this.OnTeleportStart));
		EventSystem.Instance.AddWithTarget<Entity, EMorphType, EMorphType>(base.Entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
		return true;
	}

	// Token: 0x06018280 RID: 98944 RVA: 0x0074146C File Offset: 0x0073F66C
	protected override bool OnEnd()
	{
		EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
		EventSystem.Instance.Remove(EEventName.OnRoleGoDown, new Action<int>(this.OnRoleGoDown));
		EventSystem.Instance.Remove(EEventName.OnResetSkinDamageMode, new Action(this.OnResetSkinDamageMode));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnBeHit));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnRevive, new Action(this.OnRevive));
		EventSystem.Instance.RemoveWithTarget<bool>(base.Entity, EEventName.TeleportStartEntity, new Action<bool>(this.OnTeleportStart));
		EventSystem.Instance.RemoveWithTarget<Entity, EMorphType, EMorphType>(base.Entity, EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
		this.DestroyTimer();
		this.DestroyMorphTimer();
		return true;
	}

	// Token: 0x06018281 RID: 98945 RVA: 0x00741560 File Offset: 0x0073F760
	private void TryAddKuroChangeSkeletalMaterialsComponent()
	{
		this.KuroChangeSkeletalMaterialsComponent = (this.ActorComp.Actor.GetComponentByClass(UKuroChangeSkeletalMaterialsComponent.StaticClass()) as UKuroChangeSkeletalMaterialsComponent);
		UKuroChangeSkeletalMaterialsComponent kuroChangeSkeletalMaterialsComponent = this.KuroChangeSkeletalMaterialsComponent;
		if (kuroChangeSkeletalMaterialsComponent == null || !kuroChangeSkeletalMaterialsComponent.IsValid())
		{
			this.KuroChangeSkeletalMaterialsComponent = (this.ActorComp.Actor.AddComponentByClass(UKuroChangeSkeletalMaterialsComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, CharacterNameDefines.Instance.CHANGE_SKELETAL_MATERIALS_COMP_NAME) as UKuroChangeSkeletalMaterialsComponent);
		}
	}

	// Token: 0x06018282 RID: 98946 RVA: 0x007415E4 File Offset: 0x0073F7E4
	private void OnBattleStateChanged(bool inFight)
	{
		this.DestroyTimer();
		if (inFight)
		{
			this.BattleStartTime = Time.Instance.WorldTimeSeconds;
			this.BattleEndTime = 0.0;
		}
		else
		{
			this.BattleStartTime = 0.0;
			this.BattleEndTime = Time.Instance.WorldTimeSeconds;
			this.SetTimer();
		}
		this.BeHitCount = 0;
	}

	// Token: 0x06018283 RID: 98947 RVA: 0x00741648 File Offset: 0x0073F848
	private void OnBeHit(HitInformation hitData, HitContext _)
	{
		if (this.BattleStartTime == 0.0)
		{
			return;
		}
		CharacterActorComponent component = hitData.Attacker.GetComponent<CharacterActorComponent>();
		if (component != null && CampUtils.GetCampRelationship(component.Actor.Camp, this.ActorComp.Actor.Camp) != ERelation.Enemy)
		{
			return;
		}
		this.BeHitCount++;
		this.ApplyBeHitCount();
	}

	// Token: 0x06018284 RID: 98948 RVA: 0x007416B0 File Offset: 0x0073F8B0
	private unsafe void ApplyBeHitCount()
	{
		double num = Time.Instance.WorldTimeSeconds - this.BattleStartTime;
		if (num > 20.0)
		{
			if (this.BeHitCount > 14)
			{
				ESkinDamageType type = ESkinDamageType.Damage2;
				bool force = false;
				string message = "加载2级战损贴图（受击）";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("battleStartDuration", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BeHitCount", this.BeHitCount);
				this.ApplySkinDamageByType(type, force, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (this.BeHitCount > 7)
			{
				ESkinDamageType type2 = ESkinDamageType.Damage1;
				bool force2 = false;
				string message2 = "加载1级战损贴图（受击）";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("battleStartDuration", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("BeHitCount", this.BeHitCount);
				this.ApplySkinDamageByType(type2, force2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}
		}
	}

	// Token: 0x06018285 RID: 98949 RVA: 0x007417AC File Offset: 0x0073F9AC
	private void OnRevive()
	{
		if (FormationDataController.Instance.GlobalIsInFight)
		{
			this.ApplySkinDamageByType(ESkinDamageType.Damage2, false, "加载2级战损贴图（复活）", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x06018286 RID: 98950 RVA: 0x007417DC File Offset: 0x0073F9DC
	private void OnTeleportStart(bool _)
	{
		this.ApplySkinDamageByType(ESkinDamageType.Normal, false, "战损恢复（传送）", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06018287 RID: 98951 RVA: 0x007417FF File Offset: 0x0073F9FF
	private void OnCharacterMorphTypeChanged(Entity entity, EMorphType morphType, EMorphType oldMorphType)
	{
		this.DestroyMorphTimer();
		this.MorphTimer = TimerSystem.Instance.Delay(new TTimerAction(this.OnDelayAfterMorphTypeChanged), 100f, null, null, true, 1f);
	}

	// Token: 0x06018288 RID: 98952 RVA: 0x00741830 File Offset: 0x0073FA30
	private void OnDelayAfterMorphTypeChanged(float delta)
	{
		this.MorphTimer = null;
		if (this.MaterialPropertyValue < 0f)
		{
			return;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null)
		{
			return;
		}
		CharRenderingComponent charRenderingComponent = actorComp.Actor.CharRenderingComponent;
		if (charRenderingComponent == null)
		{
			return;
		}
		charRenderingComponent.SetMaterialPropertyFloatV2(CharacterSkinDamageComponent.newDamageIntensityName, this.MaterialPropertyValue, EKuroCharBodySpecifiedType.Body, EKuroCharSlotSpecifiedType.Body, EKuroCharMeshPart.ECharacterMeshPart_Max);
	}

	// Token: 0x06018289 RID: 98953 RVA: 0x00741880 File Offset: 0x0073FA80
	private void DestroyMorphTimer()
	{
		if (!TimerSystem.Instance.Has(this.MorphTimer))
		{
			return;
		}
		TimerSystem.Instance.Remove(this.MorphTimer);
		this.MorphTimer = null;
	}

	// Token: 0x0601828A RID: 98954 RVA: 0x007418B0 File Offset: 0x0073FAB0
	private void OnRoleGoDown(int entityId)
	{
		if (entityId != base.Entity.Id)
		{
			return;
		}
		if (this.BattleEndTime == 0.0)
		{
			return;
		}
		if (Time.Instance.WorldTimeSeconds - this.BattleEndTime > 20.0)
		{
			this.ApplySkinDamageByType(ESkinDamageType.Normal, false, "战损恢复（下场）", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x0601828B RID: 98955 RVA: 0x00741910 File Offset: 0x0073FB10
	private void DestroyTimer()
	{
		if (this.EndSkinDamageTimer != null)
		{
			TimerSystem.Instance.Remove(this.EndSkinDamageTimer);
			this.EndSkinDamageTimer = null;
		}
	}

	// Token: 0x0601828C RID: 98956 RVA: 0x00741932 File Offset: 0x0073FB32
	private void SetTimer()
	{
		this.EndSkinDamageTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.EndSkinDamageTimer = null;
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			int? num = (getCurrentEntity != null) ? new int?(getCurrentEntity.Id) : null;
			int id = base.Entity.Id;
			if (!(num.GetValueOrDefault() == id & num != null))
			{
				this.ApplySkinDamageByType(ESkinDamageType.Normal, false, "战损恢复（定时器）", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}, 20f, null, null, true, 1f);
	}

	// Token: 0x0601828D RID: 98957 RVA: 0x00741960 File Offset: 0x0073FB60
	[NullableContext(2)]
	private string GetSkinDamagePath(ESkinDamageType type)
	{
		RoleInfo? roleConfig = this.CreatureDataComp.GetRoleConfig();
		string text = (roleConfig != null) ? roleConfig.GetValueOrDefault().SkinDamage((int)type) : null;
		string text2 = null;
		if (!string.IsNullOrEmpty(text))
		{
			text2 = this.ActorComp.GetReplaceEffect(text);
		}
		if (string.IsNullOrEmpty(text2))
		{
			return text;
		}
		return text2;
	}

	// Token: 0x0601828E RID: 98958 RVA: 0x007419B8 File Offset: 0x0073FBB8
	public void ApplySkinDamageByType(ESkinDamageType type, bool force, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		if (this.SkinDamageType == type && !force)
		{
			return;
		}
		if (!CharacterSkinDamageComponent.EnableSkinDamage && !force)
		{
			return;
		}
		this.SkinDamageType = type;
		if (!string.IsNullOrEmpty(this.CuePath) && !force)
		{
			return;
		}
		string skinDamagePath = this.GetSkinDamagePath(type);
		if (!string.IsNullOrEmpty(skinDamagePath))
		{
			this.ApplySkinDamage(skinDamagePath, force, message, pairs);
		}
	}

	// Token: 0x0601828F RID: 98959 RVA: 0x00741A10 File Offset: 0x0073FC10
	public void ApplySkinDamage(string damagePath, bool force, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		if (!CharacterSkinDamageComponent.EnableSkinDamage && !force)
		{
			return;
		}
		if (this.Path == damagePath)
		{
			return;
		}
		this.Path = damagePath;
		ResourceSystem.Instance.LoadAsync<UKuroChangeMaterialsTextures>(damagePath, delegate([Nullable(2)] UKuroChangeMaterialsTextures res, string path)
		{
			if (res == null)
			{
				return;
			}
			Entity entity = base.Entity;
			if (entity == null || !entity.Valid)
			{
				return;
			}
			TsBaseCharacter actor = this.ActorComp.Actor;
			if (actor == null || !actor.IsValid())
			{
				return;
			}
			if (path != this.Path)
			{
				return;
			}
			UKuroChangeSkeletalMaterialsComponent kuroChangeSkeletalMaterialsComponent = this.KuroChangeSkeletalMaterialsComponent;
			if (kuroChangeSkeletalMaterialsComponent == null || !kuroChangeSkeletalMaterialsComponent.IsValid())
			{
				this.TryAddKuroChangeSkeletalMaterialsComponent();
			}
			if (res.ParameterName == CharacterSkinDamageComponent.newDamageOnName)
			{
				this.MaterialPropertyValue = 1f;
				CharRenderingComponent charRenderingComponent = this.ActorComp.Actor.CharRenderingComponent;
				if (charRenderingComponent == null)
				{
					return;
				}
				charRenderingComponent.SetMaterialPropertyFloatV2(CharacterSkinDamageComponent.newDamageIntensityName, 1f, EKuroCharBodySpecifiedType.Body, EKuroCharSlotSpecifiedType.Body, EKuroCharMeshPart.ECharacterMeshPart_Max);
				return;
			}
			else if (res.ParameterName == CharacterSkinDamageComponent.newDamageOffName)
			{
				this.MaterialPropertyValue = 0f;
				CharRenderingComponent charRenderingComponent2 = this.ActorComp.Actor.CharRenderingComponent;
				if (charRenderingComponent2 == null)
				{
					return;
				}
				charRenderingComponent2.SetMaterialPropertyFloatV2(CharacterSkinDamageComponent.newDamageIntensityName, 0f, EKuroCharBodySpecifiedType.Body, EKuroCharSlotSpecifiedType.Body, EKuroCharMeshPart.ECharacterMeshPart_Max);
				return;
			}
			else
			{
				this.MaterialPropertyValue = -1f;
				UKuroChangeSkeletalMaterialsComponent kuroChangeSkeletalMaterialsComponent2 = this.KuroChangeSkeletalMaterialsComponent;
				if (kuroChangeSkeletalMaterialsComponent2 == null)
				{
					return;
				}
				kuroChangeSkeletalMaterialsComponent2.ChangeMaterialsWithDataAsset(res);
				return;
			}
		}, 100, "js_undefined");
	}

	// Token: 0x06018290 RID: 98960 RVA: 0x00741A60 File Offset: 0x0073FC60
	private void OnResetSkinDamageMode()
	{
		if (!string.IsNullOrEmpty(this.CuePath) && this.IsCueIgnoreEnableSetting)
		{
			this.ApplySkinDamage(this.CuePath, true, "战损开关改变, 存在无视开关的Cue战损", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!CharacterSkinDamageComponent.EnableSkinDamage)
		{
			this.ApplySkinDamageByType(ESkinDamageType.Normal, true, "战损开关设置为关闭", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!string.IsNullOrEmpty(this.CuePath))
		{
			this.ApplySkinDamage(this.CuePath, false, "战损开关设置为开启, Cue战损重新生效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.ApplyBeHitCount();
	}

	// Token: 0x06018291 RID: 98961 RVA: 0x00741AEC File Offset: 0x0073FCEC
	public void ResetCueSkinDamage()
	{
		if (string.IsNullOrEmpty(this.CuePath))
		{
			return;
		}
		this.CuePath = string.Empty;
		bool isCueIgnoreEnableSetting = this.IsCueIgnoreEnableSetting;
		this.IsCueIgnoreEnableSetting = false;
		if (CharacterSkinDamageComponent.EnableSkinDamage)
		{
			this.ApplySkinDamageByType(this.SkinDamageType, isCueIgnoreEnableSetting, "GameplayCueSkinDamage销毁", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.ApplySkinDamageByType(ESkinDamageType.Normal, isCueIgnoreEnableSetting, "GameplayCueSkinDamage销毁", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x170025E2 RID: 9698
	// (get) Token: 0x06018292 RID: 98962 RVA: 0x00741B59 File Offset: 0x0073FD59
	// (set) Token: 0x06018293 RID: 98963 RVA: 0x00741B64 File Offset: 0x0073FD64
	public ESkinDamageType SkinDamageType
	{
		get
		{
			return this.SkinDamageTypeInternal;
		}
		set
		{
			this.TagComp.RemoveTag(new int?(CharacterSkinDamageComponent.skinDamageTagMap[this.SkinDamageTypeInternal]));
			this.SkinDamageTypeInternal = value;
			this.TagComp.AddTag(new int?(CharacterSkinDamageComponent.skinDamageTagMap[this.SkinDamageTypeInternal]));
		}
	}

	// Token: 0x06018294 RID: 98964 RVA: 0x00741BB9 File Offset: 0x0073FDB9
	public static void CreateStaticDefaultValue()
	{
		CharacterSkinDamageComponent.EnableSkinDamage = true;
	}

	// Token: 0x06018295 RID: 98965 RVA: 0x00741BC1 File Offset: 0x0073FDC1
	public static void ResetStaticDefaultValue()
	{
		CharacterSkinDamageComponent.EnableSkinDamage = true;
	}

	// Token: 0x06018296 RID: 98966 RVA: 0x00741BCC File Offset: 0x0073FDCC
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSkinDamageComponent characterSkinDamageComponent = (CharacterSkinDamageComponent)componentTemplate;
		if (characterSkinDamageComponent.CreatureDataComp == null)
		{
			this.CreatureDataComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
		{
			return false;
		}
		if (characterSkinDamageComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterSkinDamageComponent.TagComp == null)
		{
			this.TagComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
		{
			return false;
		}
		if (characterSkinDamageComponent.KuroChangeSkeletalMaterialsComponent == null)
		{
			this.KuroChangeSkeletalMaterialsComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.KuroChangeSkeletalMaterialsComponent), "KuroChangeSkeletalMaterialsComponent"))
		{
			return false;
		}
		this.SkinDamageTypeInternal = characterSkinDamageComponent.SkinDamageTypeInternal;
		this.BattleStartTime = characterSkinDamageComponent.BattleStartTime;
		this.BattleEndTime = characterSkinDamageComponent.BattleEndTime;
		this.BeHitCount = characterSkinDamageComponent.BeHitCount;
		this.Path = characterSkinDamageComponent.Path;
		if (characterSkinDamageComponent.EndSkinDamageTimer == null)
		{
			this.EndSkinDamageTimer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.EndSkinDamageTimer), "EndSkinDamageTimer"))
		{
			return false;
		}
		this.CuePath = characterSkinDamageComponent.CuePath;
		this.IsCueIgnoreEnableSetting = characterSkinDamageComponent.IsCueIgnoreEnableSetting;
		if (characterSkinDamageComponent.MorphTimer == null)
		{
			this.MorphTimer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MorphTimer), "MorphTimer"))
		{
			return false;
		}
		this.MaterialPropertyValue = characterSkinDamageComponent.MaterialPropertyValue;
		return true;
	}

	// Token: 0x170025E3 RID: 9699
	// (get) Token: 0x06018297 RID: 98967 RVA: 0x00741D4E File Offset: 0x0073FF4E
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025E4 RID: 9700
	// (get) Token: 0x06018298 RID: 98968 RVA: 0x00741D51 File Offset: 0x0073FF51
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CFBF RID: 53183
	private const int SKIN_DAMAGE_TIME = 20;

	// Token: 0x0400CFC0 RID: 53184
	private const int SKIN_DAMAGE_LEVEL1_COUNT = 7;

	// Token: 0x0400CFC1 RID: 53185
	private const int SKIN_DAMAGE_LEVEL2_COUNT = 14;

	// Token: 0x0400CFC2 RID: 53186
	[StaticVariableRuleIgnore]
	private static readonly FName newDamageIntensityName = new FName("DamageIntensity");

	// Token: 0x0400CFC3 RID: 53187
	[StaticVariableRuleIgnore]
	private static readonly FName newDamageOnName = new FName("NewDamageOn");

	// Token: 0x0400CFC4 RID: 53188
	[StaticVariableRuleIgnore]
	private static readonly FName newDamageOffName = new FName("NewDamageOff");

	// Token: 0x0400CFC5 RID: 53189
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<ESkinDamageType, int> skinDamageTagMap = new Dictionary<ESkinDamageType, int>
	{
		{
			ESkinDamageType.Normal,
			GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.无战损"]
		},
		{
			ESkinDamageType.Damage1,
			GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.战损.一级战损"]
		},
		{
			ESkinDamageType.Damage2,
			GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.战损.二级战损"]
		}
	};

	// Token: 0x0400CFC6 RID: 53190
	[Nullable(2)]
	private CreatureDataComponent CreatureDataComp;

	// Token: 0x0400CFC7 RID: 53191
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CFC8 RID: 53192
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400CFC9 RID: 53193
	[Nullable(2)]
	private UKuroChangeSkeletalMaterialsComponent KuroChangeSkeletalMaterialsComponent;

	// Token: 0x0400CFCA RID: 53194
	private ESkinDamageType SkinDamageTypeInternal;

	// Token: 0x0400CFCB RID: 53195
	private double BattleStartTime;

	// Token: 0x0400CFCC RID: 53196
	private double BattleEndTime;

	// Token: 0x0400CFCD RID: 53197
	private int BeHitCount;

	// Token: 0x0400CFCE RID: 53198
	private string Path = "";

	// Token: 0x0400CFCF RID: 53199
	[Nullable(2)]
	private TimerHandle EndSkinDamageTimer;

	// Token: 0x0400CFD0 RID: 53200
	public string CuePath = "";

	// Token: 0x0400CFD1 RID: 53201
	public bool IsCueIgnoreEnableSetting;

	// Token: 0x0400CFD2 RID: 53202
	[Nullable(2)]
	private TimerHandle MorphTimer;

	// Token: 0x0400CFD3 RID: 53203
	private float MaterialPropertyValue = -1f;

	// Token: 0x0400CFD4 RID: 53204
	public static bool EnableSkinDamage;
}
