using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02003088 RID: 12424
[NullableContext(1)]
[Nullable(0)]
public class CharacterSkinDamageComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x0601A899 RID: 108697 RVA: 0x0071AE34 File Offset: 0x00719034
	static CharacterSkinDamageComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterSkinDamageComponent.CreateStaticDefaultValue), new Action(CharacterSkinDamageComponent.ResetStaticDefaultValue));
	}

	// Token: 0x0601A89A RID: 108698 RVA: 0x0071AED8 File Offset: 0x007190D8
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

	// Token: 0x0601A89B RID: 108699 RVA: 0x0071B004 File Offset: 0x00719204
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

	// Token: 0x0601A89C RID: 108700 RVA: 0x0071B0F8 File Offset: 0x007192F8
	private void TryAddKuroChangeSkeletalMaterialsComponent()
	{
		this.KuroChangeSkeletalMaterialsComponent = (this.ActorComp.Actor.GetComponentByClass(UKuroChangeSkeletalMaterialsComponent.StaticClass()) as UKuroChangeSkeletalMaterialsComponent);
		UKuroChangeSkeletalMaterialsComponent kuroChangeSkeletalMaterialsComponent = this.KuroChangeSkeletalMaterialsComponent;
		if (kuroChangeSkeletalMaterialsComponent == null || !kuroChangeSkeletalMaterialsComponent.IsValid())
		{
			this.KuroChangeSkeletalMaterialsComponent = (this.ActorComp.Actor.AddComponentByClass(UKuroChangeSkeletalMaterialsComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, CharacterNameDefines.Instance.CHANGE_SKELETAL_MATERIALS_COMP_NAME) as UKuroChangeSkeletalMaterialsComponent);
		}
	}

	// Token: 0x0601A89D RID: 108701 RVA: 0x0071B17C File Offset: 0x0071937C
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

	// Token: 0x0601A89E RID: 108702 RVA: 0x0071B1E0 File Offset: 0x007193E0
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

	// Token: 0x0601A89F RID: 108703 RVA: 0x0071B248 File Offset: 0x00719448
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

	// Token: 0x0601A8A0 RID: 108704 RVA: 0x0071B344 File Offset: 0x00719544
	private void OnRevive()
	{
		if (FormationDataController.Instance.GlobalIsInFight)
		{
			this.ApplySkinDamageByType(ESkinDamageType.Damage2, false, "加载2级战损贴图（复活）", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x0601A8A1 RID: 108705 RVA: 0x0071B374 File Offset: 0x00719574
	private void OnTeleportStart(bool _)
	{
		this.ApplySkinDamageByType(ESkinDamageType.Normal, false, "战损恢复（传送）", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601A8A2 RID: 108706 RVA: 0x0071B397 File Offset: 0x00719597
	private void OnCharacterMorphTypeChanged(Entity entity, EMorphType morphType, EMorphType oldMorphType)
	{
		this.DestroyMorphTimer();
		this.MorphTimer = TimerSystem.Instance.Delay(new TTimerAction(this.OnDelayAfterMorphTypeChanged), 100f, null, null, true, 1f);
	}

	// Token: 0x0601A8A3 RID: 108707 RVA: 0x0071B3C8 File Offset: 0x007195C8
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

	// Token: 0x0601A8A4 RID: 108708 RVA: 0x0071B418 File Offset: 0x00719618
	private void DestroyMorphTimer()
	{
		if (!TimerSystem.Instance.Has(this.MorphTimer))
		{
			return;
		}
		TimerSystem.Instance.Remove(this.MorphTimer);
		this.MorphTimer = null;
	}

	// Token: 0x0601A8A5 RID: 108709 RVA: 0x0071B448 File Offset: 0x00719648
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

	// Token: 0x0601A8A6 RID: 108710 RVA: 0x0071B4A8 File Offset: 0x007196A8
	private void DestroyTimer()
	{
		if (this.EndSkinDamageTimer != null)
		{
			TimerSystem.Instance.Remove(this.EndSkinDamageTimer);
			this.EndSkinDamageTimer = null;
		}
	}

	// Token: 0x0601A8A7 RID: 108711 RVA: 0x0071B4CA File Offset: 0x007196CA
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

	// Token: 0x0601A8A8 RID: 108712 RVA: 0x0071B4F8 File Offset: 0x007196F8
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

	// Token: 0x0601A8A9 RID: 108713 RVA: 0x0071B550 File Offset: 0x00719750
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

	// Token: 0x0601A8AA RID: 108714 RVA: 0x0071B5A8 File Offset: 0x007197A8
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

	// Token: 0x0601A8AB RID: 108715 RVA: 0x0071B5F8 File Offset: 0x007197F8
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

	// Token: 0x0601A8AC RID: 108716 RVA: 0x0071B684 File Offset: 0x00719884
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

	// Token: 0x17002489 RID: 9353
	// (get) Token: 0x0601A8AD RID: 108717 RVA: 0x0071B6F1 File Offset: 0x007198F1
	// (set) Token: 0x0601A8AE RID: 108718 RVA: 0x0071B6FC File Offset: 0x007198FC
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

	// Token: 0x0601A8AF RID: 108719 RVA: 0x0071B751 File Offset: 0x00719951
	public static void CreateStaticDefaultValue()
	{
		CharacterSkinDamageComponent.EnableSkinDamage = true;
	}

	// Token: 0x0601A8B0 RID: 108720 RVA: 0x0071B759 File Offset: 0x00719959
	public static void ResetStaticDefaultValue()
	{
		CharacterSkinDamageComponent.EnableSkinDamage = true;
	}

	// Token: 0x0601A8B1 RID: 108721 RVA: 0x0071B764 File Offset: 0x00719964
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSkinDamageComponent characterSkinDamageComponent = (CharacterSkinDamageComponent)componentTemplate;
		if (base.CanResetComponentProperty("CreatureDataComp"))
		{
			if (characterSkinDamageComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterSkinDamageComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (characterSkinDamageComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("KuroChangeSkeletalMaterialsComponent"))
		{
			if (characterSkinDamageComponent.KuroChangeSkeletalMaterialsComponent == null)
			{
				this.KuroChangeSkeletalMaterialsComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroChangeSkeletalMaterialsComponent>(this.KuroChangeSkeletalMaterialsComponent), "KuroChangeSkeletalMaterialsComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkinDamageTypeInternal"))
		{
			this.SkinDamageTypeInternal = characterSkinDamageComponent.SkinDamageTypeInternal;
		}
		if (base.CanResetComponentProperty("BattleStartTime"))
		{
			this.BattleStartTime = characterSkinDamageComponent.BattleStartTime;
		}
		if (base.CanResetComponentProperty("BattleEndTime"))
		{
			this.BattleEndTime = characterSkinDamageComponent.BattleEndTime;
		}
		if (base.CanResetComponentProperty("BeHitCount"))
		{
			this.BeHitCount = characterSkinDamageComponent.BeHitCount;
		}
		if (base.CanResetComponentProperty("Path"))
		{
			this.Path = characterSkinDamageComponent.Path;
		}
		if (base.CanResetComponentProperty("EndSkinDamageTimer"))
		{
			if (characterSkinDamageComponent.EndSkinDamageTimer == null)
			{
				this.EndSkinDamageTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.EndSkinDamageTimer), "EndSkinDamageTimer"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CuePath"))
		{
			this.CuePath = characterSkinDamageComponent.CuePath;
		}
		if (base.CanResetComponentProperty("IsCueIgnoreEnableSetting"))
		{
			this.IsCueIgnoreEnableSetting = characterSkinDamageComponent.IsCueIgnoreEnableSetting;
		}
		if (base.CanResetComponentProperty("MorphTimer"))
		{
			if (characterSkinDamageComponent.MorphTimer == null)
			{
				this.MorphTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.MorphTimer), "MorphTimer"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MaterialPropertyValue"))
		{
			this.MaterialPropertyValue = characterSkinDamageComponent.MaterialPropertyValue;
		}
		return true;
	}

	// Token: 0x0400CBDC RID: 52188
	private const int SKIN_DAMAGE_TIME = 20;

	// Token: 0x0400CBDD RID: 52189
	private const int SKIN_DAMAGE_LEVEL1_COUNT = 7;

	// Token: 0x0400CBDE RID: 52190
	private const int SKIN_DAMAGE_LEVEL2_COUNT = 14;

	// Token: 0x0400CBDF RID: 52191
	[StaticVariableRuleIgnore]
	private static readonly FName newDamageIntensityName = new FName("DamageIntensity");

	// Token: 0x0400CBE0 RID: 52192
	[StaticVariableRuleIgnore]
	private static readonly FName newDamageOnName = new FName("NewDamageOn");

	// Token: 0x0400CBE1 RID: 52193
	[StaticVariableRuleIgnore]
	private static readonly FName newDamageOffName = new FName("NewDamageOff");

	// Token: 0x0400CBE2 RID: 52194
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

	// Token: 0x0400CBE3 RID: 52195
	[Nullable(2)]
	private CreatureDataComponent CreatureDataComp;

	// Token: 0x0400CBE4 RID: 52196
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CBE5 RID: 52197
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400CBE6 RID: 52198
	[Nullable(2)]
	private UKuroChangeSkeletalMaterialsComponent KuroChangeSkeletalMaterialsComponent;

	// Token: 0x0400CBE7 RID: 52199
	private ESkinDamageType SkinDamageTypeInternal;

	// Token: 0x0400CBE8 RID: 52200
	private double BattleStartTime;

	// Token: 0x0400CBE9 RID: 52201
	private double BattleEndTime;

	// Token: 0x0400CBEA RID: 52202
	private int BeHitCount;

	// Token: 0x0400CBEB RID: 52203
	private string Path = "";

	// Token: 0x0400CBEC RID: 52204
	[Nullable(2)]
	private TimerHandle EndSkinDamageTimer;

	// Token: 0x0400CBED RID: 52205
	public string CuePath = "";

	// Token: 0x0400CBEE RID: 52206
	public bool IsCueIgnoreEnableSetting;

	// Token: 0x0400CBEF RID: 52207
	[Nullable(2)]
	private TimerHandle MorphTimer;

	// Token: 0x0400CBF0 RID: 52208
	private float MaterialPropertyValue = -1f;

	// Token: 0x0400CBF1 RID: 52209
	public static bool EnableSkinDamage;
}
