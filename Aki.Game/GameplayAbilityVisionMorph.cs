using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002719 RID: 10009
[NullableContext(2)]
[Nullable(0)]
public class GameplayAbilityVisionMorph : GameplayAbilityVisionBase
{
	// Token: 0x06019192 RID: 102802 RVA: 0x007A5CF9 File Offset: 0x007A3EF9
	[NullableContext(1)]
	public GameplayAbilityVisionMorph(CharacterVisionComponent visionComponent) : base(visionComponent)
	{
	}

	// Token: 0x06019193 RID: 102803 RVA: 0x007A5D02 File Offset: 0x007A3F02
	protected override void OnCreate()
	{
		this.StealthTagTask = base.GameplayTagComponent.ListenForTagAddOrRemove(new int?(GameplayAbilityVisionMisc.stealthTag), delegate(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				BaseTagComponent visionTagComponent = this.VisionTagComponent;
				if (visionTagComponent == null)
				{
					return;
				}
				visionTagComponent.AddTag(new int?(GameplayAbilityVisionMisc.stealthTag));
				return;
			}
			else
			{
				BaseTagComponent visionTagComponent2 = this.VisionTagComponent;
				if (visionTagComponent2 == null)
				{
					return;
				}
				visionTagComponent2.RemoveTag(new int?(GameplayAbilityVisionMisc.stealthTag));
				return;
			}
		}, null);
	}

	// Token: 0x06019194 RID: 102804 RVA: 0x007A5D2C File Offset: 0x007A3F2C
	protected override void OnDestroy()
	{
		this.EndAllTask();
		VisionSkillComponent visionSkillComponent = this.VisionSkillComponent;
		if (visionSkillComponent != null)
		{
			visionSkillComponent.OnVisionAbilityDestroy();
		}
		ITagTask stealthTagTask = this.StealthTagTask;
		if (stealthTagTask == null)
		{
			return;
		}
		stealthTagTask.EndTask();
	}

	// Token: 0x06019195 RID: 102805 RVA: 0x007A5D58 File Offset: 0x007A3F58
	protected unsafe override void OnTick(float delta)
	{
		if (this.Synchronized)
		{
			float num = this.VisionActorComponent.ScaledHalfHeight - base.ActorComponent.ScaledHalfHeight;
			Vector tempVector = GameplayAbilityVisionMisc.tempVector1;
			tempVector.DeepCopy(this.VisionActorComponent.ActorLocationProxy);
			Vector tempVector2 = GameplayAbilityVisionMisc.tempVector2;
			base.MoveComponent.GravityUp.Multiply((double)num, tempVector2);
			tempVector.SubtractionEqual(tempVector2);
			if (this.IsHit(base.ActorComponent.ActorLocationProxy, tempVector))
			{
				Log.Instance.Info(ELogModule.Battle, ELogAuthor.HXY, "变身OnTick过程穿墙，需打断幻象变身技能", default(ReadOnlySpan<ValueTuple<string, object>>));
				EventSystem.Instance.Emit(EEventName.VisionMorphInterrupt);
				BaseSkillComponent skillComponent = base.SkillComponent;
				Skill currentSkill = base.SkillComponent.CurrentSkill;
				skillComponent.EndSkill((currentSkill != null) ? currentSkill.SkillId : 0, "GameplayAbilityVisionMorph.IsHit");
				return;
			}
			base.ActorComponent.SetActorLocationAndRotation(tempVector.ToUeVector(false), this.VisionActorComponent.ActorRotation, "GameplayAbilityVisionMorph.OnTick", false, null);
			if (this.PrintLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.HXY;
				string message = "GameplayAbilityVisionMorph.OnTick设置位置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("人的位置", base.ActorComponent.ActorLocationProxy);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("幻象的位置", this.VisionActorComponent.ActorLocationProxy);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.PrintLog = false;
			}
		}
	}

	// Token: 0x06019196 RID: 102806 RVA: 0x007A5ED0 File Offset: 0x007A40D0
	protected override bool OnActivateAbility()
	{
		if (this.IsActivating || !this.Init())
		{
			return false;
		}
		this.IsActivating = true;
		if (!this.VisionData.空中能否释放)
		{
			base.SkillComponent.PlaySkillMontage(0, "", 0f, null, null);
		}
		this.SetCollision(false, null);
		base.GameplayTagComponent.AddTag(new int?(GameplayAbilityVisionMisc.invincibleTag));
		base.BuffComponent.RemoveBuff(1101004005L, -1, "幻象变身技能激活时移除角色禁止闪避的Buff", null, null, null);
		base.CueComponent.AddCue(19000000191L, new GameplayCueParam?(new GameplayCueParam
		{
			Sync = new bool?(true),
			Instant = true
		}));
		TimerSystemInstance instance = TimerSystem.Instance;
		TTimerAction action = delegate(float _)
		{
			this.SetCharacterHidden(true);
		};
		float num = 300f;
		CharacterModel instance2 = CharacterModel.Instance;
		this.CharacterHiddenTimer = instance.Delay(action, num * ((instance2 != null) ? instance2.SelfCenteredTimeDilation : 1f), null, null, true, 1f);
		this.MorphBegin();
		return true;
	}

	// Token: 0x06019197 RID: 102807 RVA: 0x007A5FEC File Offset: 0x007A41EC
	protected override bool OnEndAbility()
	{
		if (!this.IsActivating)
		{
			return true;
		}
		this.IsActivating = false;
		this.MorphEnd(false);
		base.GameplayTagComponent.RemoveTag(new int?(GameplayAbilityVisionMisc.invincibleTag));
		base.GameplayTagComponent.RemoveTag(new int?(GameplayAbilityVisionMisc.morphTag));
		return true;
	}

	// Token: 0x06019198 RID: 102808 RVA: 0x007A603E File Offset: 0x007A423E
	public override bool HandlePress(EInputAction action, float time)
	{
		return this.VisionSkillComponent != null && this.VisionSkillComponent.HandlePress(action, time);
	}

	// Token: 0x06019199 RID: 102809 RVA: 0x007A6058 File Offset: 0x007A4258
	protected bool Init()
	{
		this.PreInit();
		if (this.VisionEntity == null || !this.VisionEntity.IsInit)
		{
			return false;
		}
		if (this.NeedNoActive() && this.VisionEntity.Entity.Active)
		{
			return false;
		}
		if (this.NeedNoAi())
		{
			CharacterAiComponent component = this.VisionEntity.Entity.GetComponent<CharacterAiComponent>();
			if (component != null && component.IsEnabled())
			{
				CombatLog.Instance.Error(CombatLog.EDebugModule.Skill, this.VisionEntity.Entity, "变身幻象不能配置AI，请检查一下AI配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
		}
		this.VisionActorComponent = this.VisionEntity.Entity.GetComponent<CharacterActorComponent>();
		this.VisionTagComponent = this.VisionEntity.Entity.GetComponent<BaseTagComponent>();
		this.VisionBuffComponent = this.VisionEntity.Entity.GetComponent<CharacterBuffComponent>();
		this.VisionCueComponent = this.VisionEntity.Entity.GetComponent<CharacterGameplayCueComponent>();
		this.VisionMoveComponent = this.VisionEntity.Entity.GetComponent<CharacterMoveComponent>();
		this.VisionSkillComponent = this.VisionEntity.Entity.GetComponent<VisionSkillComponent>();
		this.VisionSkillComponent.InitVisionSkill(base.EntityHandle, true, this.GetCheckVisionType());
		return true;
	}

	// Token: 0x0601919A RID: 102810 RVA: 0x007A6188 File Offset: 0x007A4388
	protected void SetCollision(bool enable, EntityHandle visionEntity = null)
	{
		if (visionEntity == null)
		{
			visionEntity = this.VisionEntity;
		}
		CharacterActorComponent characterActorComponent;
		if (visionEntity == null)
		{
			characterActorComponent = null;
		}
		else
		{
			WorldEntity entity = visionEntity.Entity;
			characterActorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
		}
		CharacterActorComponent characterActorComponent2 = characterActorComponent;
		if (characterActorComponent2 == null)
		{
			return;
		}
		CollisionUtils.Instance.SetCollisionResponseToPawn(characterActorComponent2.Actor.CapsuleComponent, EPawnChannel.PawnPlayer, enable ? ECollisionResponse.ECR_Block : ECollisionResponse.ECR_Ignore);
		characterActorComponent2.Actor.CapsuleComponent.IgnoreActorWhenMoving(base.ActorComponent.Actor, !enable);
		base.ActorComponent.Actor.CapsuleComponent.IgnoreActorWhenMoving(characterActorComponent2.Actor, !enable);
	}

	// Token: 0x0601919B RID: 102811 RVA: 0x007A6218 File Offset: 0x007A4418
	protected unsafe virtual void MorphBegin()
	{
		this.IsMorphing = true;
		this.VisionMoveComponent.SetForceSpeed(Vector.ZeroVectorProxy);
		this.SetVisionEnable(true, null);
		Vector tempVector = GameplayAbilityVisionMisc.tempVector1;
		base.MoveComponent.GravityUp.Multiply((double)(this.VisionActorComponent.ScaledHalfHeight - base.ActorComponent.ScaledHalfHeight), tempVector);
		BaseActorComponent visionActorComponent = this.VisionActorComponent;
		FVectorDouble actorLocation = base.ActorComponent.ActorLocation;
		FVectorDouble fvectorDouble = tempVector.ToUeVector(false);
		visionActorComponent.SetActorLocationAndRotation(actorLocation + fvectorDouble, base.ActorComponent.ActorRotation, "幻象变身出现位置", false, null);
		this.PrintLog = true;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.HXY;
		string message = "GameplayAbilityVisionMorph.MorphBegin设置位置";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("人的位置", base.ActorComponent.ActorLocationProxy);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("幻象的位置", this.VisionActorComponent.ActorLocationProxy);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.Synchronized = true;
		base.GameplayTagComponent.AddTag(new int?(GameplayAbilityVisionMisc.morphTag));
		if (this.WaitMorphTagRemoveTask == null)
		{
			this.WaitMorphTagRemoveTask = base.GameplayTagComponent.ListenForTagAddOrRemove(new int?(GameplayAbilityVisionMisc.morphTag), delegate(int tagId, bool tagExist)
			{
				if (!tagExist)
				{
					this.MorphEnd(true);
				}
			}, null);
		}
		this.VisionBuffComponent.AddBuff(1900000017L, new AddBuffParam
		{
			InstigatorId = this.VisionBuffComponent.CreatureDataId,
			Reason = "开始幻象变身时幻象自身的材质和粒子"
		});
		int 技能ID = this.VisionData.技能ID;
		if (技能ID > 0)
		{
			BaseSkillComponent visionSkillComponent = this.VisionSkillComponent;
			int skillId = 技能ID;
			SkillParam skillParam = new SkillParam();
			EntityHandle skillTarget = base.SkillComponent.SkillTarget;
			skillParam.Target = ((skillTarget != null) ? skillTarget.Entity : null);
			skillParam.SocketName = base.SkillComponent.SkillTargetSocket;
			skillParam.Reason = "VisionSkill.BeginSkill";
			skillParam.CheckMultiSkill = new bool?(true);
			visionSkillComponent.BeginSkill(skillId, skillParam);
			base.SkillComponent.SkillTarget = this.VisionSkillComponent.SkillTarget;
			base.SkillComponent.SkillTargetSocket = this.VisionSkillComponent.SkillTargetSocket;
		}
		RoleAudioController.Instance.PlayRoleAudio(base.Entity, ERoleAudioType.VisionMorph, null);
		EventSystem.Instance.Emit<EntityHandle, EntityHandle>(EEventName.VisionMorphBegin, this.VisionEntity, base.EntityHandle);
		EventSystem.Instance.EmitWithTargets<EntityHandle, EntityHandle>(new object[]
		{
			base.EntityHandle.Entity,
			this.VisionEntity.Entity
		}, EEventName.VisionMorphBegin, this.VisionEntity, base.EntityHandle);
	}

	// Token: 0x0601919C RID: 102812 RVA: 0x007A64AC File Offset: 0x007A46AC
	protected virtual void MorphEnd(bool playMontage)
	{
		if (!this.IsMorphing)
		{
			return;
		}
		this.IsMorphing = false;
		this.EndAllTask();
		this.PlayEndEffect();
		this.SetCharacterHidden(false);
		base.MoveComponent.SetForceSpeed(Vector.ZeroVectorProxy);
		bool flag = this.FixMovementMode();
		if (playMontage)
		{
			if (flag)
			{
				base.SkillComponent.PlaySkillMontage(1, "", 0f, delegate(bool _)
				{
					this.<MorphEnd>g__endSkill|25_0();
				}, null);
			}
			else
			{
				this.<MorphEnd>g__endSkill|25_0();
			}
		}
		else
		{
			this.<MorphEnd>g__endSkill|25_0();
		}
		this.VisionSkillComponent.OnMorphEnd();
		EventSystem.Instance.Emit<EntityHandle, EntityHandle>(EEventName.VisionMorphEnd, base.EntityHandle, this.VisionEntity);
		EventSystem.Instance.EmitWithTargets<EntityHandle, EntityHandle>(new object[]
		{
			base.EntityHandle.Entity,
			this.VisionEntity.Entity
		}, EEventName.VisionMorphEnd, base.EntityHandle, this.VisionEntity);
	}

	// Token: 0x0601919D RID: 102813 RVA: 0x007A6594 File Offset: 0x007A4794
	protected void SetCharacterHidden(bool hidden)
	{
		if (!hidden)
		{
			base.CueComponent.AddCue(19000000201L, new GameplayCueParam?(new GameplayCueParam
			{
				Sync = new bool?(true),
				Instant = true
			}));
			MathUtils.Instance.LookRotationUpFirst(base.ActorComponent.ActorForwardProxy, base.MoveComponent.GravityUp, GameplayAbilityVisionMisc.tempRotator);
			base.ActorComponent.SetActorRotation(GameplayAbilityVisionMisc.tempRotator.ToUeRotator(), "GameplayAbilityVisionMorph.SetCharacterHidden", false);
		}
		CreatureController.Instance.SetActorVisible(base.Entity, !hidden, true, true, "幻象变身技能隐藏角色", true);
	}

	// Token: 0x0601919E RID: 102814 RVA: 0x007A663C File Offset: 0x007A483C
	protected virtual void EndAllTask()
	{
		this.Synchronized = false;
		if (this.WaitMorphTagRemoveTask != null)
		{
			this.WaitMorphTagRemoveTask.EndTask();
			this.WaitMorphTagRemoveTask = null;
		}
		if (this.CharacterHiddenTimer != null && TimerSystem.Instance.Has(this.CharacterHiddenTimer))
		{
			TimerSystem.Instance.Remove(this.CharacterHiddenTimer);
			this.CharacterHiddenTimer = null;
		}
	}

	// Token: 0x0601919F RID: 102815 RVA: 0x007A669C File Offset: 0x007A489C
	protected bool FixMovementMode()
	{
		UTraceLineElement staticLineTrace = SkillUtils.GetStaticLineTrace();
		Vector actorLocationProxy = base.ActorComponent.ActorLocationProxy;
		float num = base.ActorComponent.ScaledHalfHeight + 20f;
		Vector tempVector = GameplayAbilityVisionMisc.tempVector1;
		base.MoveComponent.GravityDirect.Multiply((double)num, tempVector);
		tempVector.AdditionEqual(actorLocationProxy);
		TraceElementCommon.Instance.SetStartLocation(staticLineTrace, actorLocationProxy);
		TraceElementCommon.Instance.SetEndLocation(staticLineTrace, tempVector);
		return TraceElementCommon.Instance.LineTrace(staticLineTrace, "GameplayAbilityVisionMorph.FixMovementMode") && staticLineTrace.HitResult.bBlockingHit;
	}

	// Token: 0x060191A0 RID: 102816 RVA: 0x007A6728 File Offset: 0x007A4928
	protected void PlayEndEffect()
	{
		GameplayAbilityVisionMorph.<>c__DisplayClass29_0 CS$<>8__locals1 = new GameplayAbilityVisionMorph.<>c__DisplayClass29_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.capturedVisionEntity = this.VisionEntity;
		CS$<>8__locals1.capturedVisionCueComponent = this.VisionCueComponent;
		CS$<>8__locals1.capturedVisionHiddenTimer = null;
		CharacterGameplayCueComponent capturedVisionCueComponent = CS$<>8__locals1.capturedVisionCueComponent;
		if (capturedVisionCueComponent != null)
		{
			capturedVisionCueComponent.AddCue(19000000182L, new GameplayCueParam?(new GameplayCueParam
			{
				Sync = new bool?(true),
				Instant = true
			}));
		}
		CS$<>8__locals1.cueHandle = 0;
		CS$<>8__locals1.cueHandle = CS$<>8__locals1.capturedVisionCueComponent.AddCue(19000000181L, new GameplayCueParam?(new GameplayCueParam
		{
			EndCallback = delegate()
			{
				if (CS$<>8__locals1.capturedVisionHiddenTimer != null && TimerSystem.Instance.Has(CS$<>8__locals1.capturedVisionHiddenTimer))
				{
					TimerSystem.Instance.Remove(CS$<>8__locals1.capturedVisionHiddenTimer);
					CS$<>8__locals1.capturedVisionHiddenTimer = null;
					CS$<>8__locals1.<>4__this.VisionDisable(CS$<>8__locals1.cueHandle, CS$<>8__locals1.capturedVisionEntity, CS$<>8__locals1.capturedVisionCueComponent);
				}
			},
			Sync = new bool?(true)
		}));
		GameplayAbilityVisionMorph.<>c__DisplayClass29_0 CS$<>8__locals2 = CS$<>8__locals1;
		TimerSystemInstance instance = TimerSystem.Instance;
		TTimerAction action = delegate(float _)
		{
			Log.Instance.Warn(ELogModule.Battle, ELogAuthor.HXY, "幻象消失材质没有正常结束，被保底", default(ReadOnlySpan<ValueTuple<string, object>>));
			CS$<>8__locals1.capturedVisionHiddenTimer = null;
			CS$<>8__locals1.<>4__this.VisionDisable(CS$<>8__locals1.cueHandle, CS$<>8__locals1.capturedVisionEntity, CS$<>8__locals1.capturedVisionCueComponent);
		};
		float num = 1000f;
		CharacterModel instance2 = CharacterModel.Instance;
		CS$<>8__locals2.capturedVisionHiddenTimer = instance.Delay(action, num * ((instance2 != null) ? instance2.SelfCenteredTimeDilation : 1f), null, null, true, 1f);
	}

	// Token: 0x060191A1 RID: 102817 RVA: 0x007A6830 File Offset: 0x007A4A30
	[NullableContext(1)]
	private bool IsHit(Vector startLocation, Vector endLocation)
	{
		UTraceLineElement staticLineTrace = SkillUtils.GetStaticLineTrace();
		TraceElementCommon.Instance.SetStartLocation(staticLineTrace, startLocation);
		TraceElementCommon.Instance.SetEndLocation(staticLineTrace, endLocation);
		return TraceElementCommon.Instance.LineTrace(staticLineTrace, "GameplayAbilityVisionMorph.FixLocation") && staticLineTrace.HitResult.bBlockingHit;
	}

	// Token: 0x060191A2 RID: 102818 RVA: 0x007A687C File Offset: 0x007A4A7C
	private void VisionDisable(int cueHandle, EntityHandle visionEntity, CharacterGameplayCueComponent visionCueComponent)
	{
		if (this.IsActivating)
		{
			base.GameplayTagComponent.RemoveTag(new int?(GameplayAbilityVisionMisc.invincibleTag));
		}
		if (visionEntity != null && visionEntity.Valid)
		{
			if (this.NeedPlayHuluBullet())
			{
				BulletController.Instance.CreateBulletCustomTarget(visionEntity.Entity, "210000004", null, null, null, EBulletCreateSource.Others);
			}
			if (visionCueComponent != null)
			{
				visionCueComponent.RemoveCueByHandle((long)cueHandle);
			}
			this.SetVisionEnable(false, visionEntity);
			this.SetCollision(true, visionEntity);
		}
	}

	// Token: 0x060191A3 RID: 102819 RVA: 0x007A68FF File Offset: 0x007A4AFF
	protected virtual void SetVisionEnable(bool enable, EntityHandle visionEntity = null)
	{
		if (visionEntity == null)
		{
			visionEntity = this.VisionEntity;
		}
		CreatureController.Instance.SetEntityEnable(visionEntity.Entity, enable, "GameplayAbilityVisionMorph.SetVisionEnable", true);
		EventSystem.Instance.Emit<bool>(EEventName.OnPhantomEnableStateChange, enable);
	}

	// Token: 0x060191A4 RID: 102820 RVA: 0x007A6934 File Offset: 0x007A4B34
	protected virtual bool NeedPlayHuluBullet()
	{
		return true;
	}

	// Token: 0x060191A5 RID: 102821 RVA: 0x007A6938 File Offset: 0x007A4B38
	protected virtual void PreInit()
	{
		this.VisionEntity = PhantomUtil.GetSummonedEntity(this.VisionComponent.Entity, ESummonType.ConcomitantVision, 1);
		this.VisionData = PhantomUtil.GetVisionData(this.VisionComponent.GetVisionId(null));
	}

	// Token: 0x060191A6 RID: 102822 RVA: 0x007A697C File Offset: 0x007A4B7C
	protected virtual bool NeedNoAi()
	{
		return true;
	}

	// Token: 0x060191A7 RID: 102823 RVA: 0x007A697F File Offset: 0x007A4B7F
	protected virtual bool NeedNoActive()
	{
		return true;
	}

	// Token: 0x060191A8 RID: 102824 RVA: 0x007A6982 File Offset: 0x007A4B82
	protected virtual ECheckVisionType GetCheckVisionType()
	{
		return ECheckVisionType.Vision;
	}

	// Token: 0x060191A9 RID: 102825 RVA: 0x007A6985 File Offset: 0x007A4B85
	public virtual bool CanInterruptMorph()
	{
		return false;
	}

	// Token: 0x170027E1 RID: 10209
	// (get) Token: 0x060191AA RID: 102826 RVA: 0x007A6988 File Offset: 0x007A4B88
	public bool IsMorphActivating
	{
		get
		{
			return this.IsActivating;
		}
	}

	// Token: 0x060191AB RID: 102827 RVA: 0x007A6990 File Offset: 0x007A4B90
	public virtual void InterruptMorph()
	{
		BaseSkillComponent component = this.VisionComponent.Entity.GetComponent<BaseSkillComponent>();
		if (component == null)
		{
			return;
		}
		component.EndSkill(200001, "GameplayAbilityVisionMorph.InterruptMorph");
	}

	// Token: 0x060191AF RID: 102831 RVA: 0x007A6A06 File Offset: 0x007A4C06
	[CompilerGenerated]
	private void <MorphEnd>g__endSkill|25_0()
	{
		BaseSkillComponent skillComponent = base.SkillComponent;
		Skill currentSkill = base.SkillComponent.CurrentSkill;
		skillComponent.EndSkill((currentSkill != null) ? currentSkill.SkillId : 0, "GameplayAbilityVisionMorph.MorphEnd");
	}

	// Token: 0x0400DB2F RID: 56111
	protected EntityHandle VisionEntity;

	// Token: 0x0400DB30 RID: 56112
	protected SVisionData VisionData;

	// Token: 0x0400DB31 RID: 56113
	protected CharacterActorComponent VisionActorComponent;

	// Token: 0x0400DB32 RID: 56114
	private BaseTagComponent VisionTagComponent;

	// Token: 0x0400DB33 RID: 56115
	protected CharacterBuffComponent VisionBuffComponent;

	// Token: 0x0400DB34 RID: 56116
	private CharacterGameplayCueComponent VisionCueComponent;

	// Token: 0x0400DB35 RID: 56117
	protected CharacterMoveComponent VisionMoveComponent;

	// Token: 0x0400DB36 RID: 56118
	protected VisionSkillComponent VisionSkillComponent;

	// Token: 0x0400DB37 RID: 56119
	protected ITagTask WaitMorphTagRemoveTask;

	// Token: 0x0400DB38 RID: 56120
	private ITagTask StealthTagTask;

	// Token: 0x0400DB39 RID: 56121
	protected TimerHandle CharacterHiddenTimer;

	// Token: 0x0400DB3A RID: 56122
	protected bool IsActivating;

	// Token: 0x0400DB3B RID: 56123
	protected bool IsMorphing;

	// Token: 0x0400DB3C RID: 56124
	protected bool Synchronized;

	// Token: 0x0400DB3D RID: 56125
	protected bool PrintLog;
}
