using System;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020031AA RID: 12714
[NullableContext(2)]
[Nullable(0)]
public class GameplayAbilityVisionMorph : GameplayAbilityVisionBase
{
	// Token: 0x0601B664 RID: 112228 RVA: 0x0077DA19 File Offset: 0x0077BC19
	[NullableContext(1)]
	public GameplayAbilityVisionMorph(CharacterVisionComponent visionComponent) : base(visionComponent)
	{
	}

	// Token: 0x0601B665 RID: 112229 RVA: 0x0077DA22 File Offset: 0x0077BC22
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

	// Token: 0x0601B666 RID: 112230 RVA: 0x0077DA4C File Offset: 0x0077BC4C
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

	// Token: 0x0601B667 RID: 112231 RVA: 0x0077DA78 File Offset: 0x0077BC78
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

	// Token: 0x0601B668 RID: 112232 RVA: 0x0077DBF0 File Offset: 0x0077BDF0
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

	// Token: 0x0601B669 RID: 112233 RVA: 0x0077DD0C File Offset: 0x0077BF0C
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

	// Token: 0x0601B66A RID: 112234 RVA: 0x0077DD5E File Offset: 0x0077BF5E
	public override bool HandlePress(EInputAction action, float time)
	{
		return this.VisionSkillComponent != null && this.VisionSkillComponent.HandlePress(action, time);
	}

	// Token: 0x0601B66B RID: 112235 RVA: 0x0077DD78 File Offset: 0x0077BF78
	private bool Init()
	{
		this.PreInit();
		if (!this.VisionEntity.IsInit)
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
		this.VisionSkillComponent.InitVisionSkill(base.EntityHandle, true);
		return true;
	}

	// Token: 0x0601B66C RID: 112236 RVA: 0x0077DE9C File Offset: 0x0077C09C
	private void SetCollision(bool enable, EntityHandle visionEntity = null)
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

	// Token: 0x0601B66D RID: 112237 RVA: 0x0077DF2C File Offset: 0x0077C12C
	private unsafe void MorphBegin()
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

	// Token: 0x0601B66E RID: 112238 RVA: 0x0077E1C0 File Offset: 0x0077C3C0
	private void MorphEnd(bool playMontage)
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

	// Token: 0x0601B66F RID: 112239 RVA: 0x0077E2A8 File Offset: 0x0077C4A8
	private void SetCharacterHidden(bool hidden)
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

	// Token: 0x0601B670 RID: 112240 RVA: 0x0077E350 File Offset: 0x0077C550
	private void EndAllTask()
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

	// Token: 0x0601B671 RID: 112241 RVA: 0x0077E3B0 File Offset: 0x0077C5B0
	private bool FixMovementMode()
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

	// Token: 0x0601B672 RID: 112242 RVA: 0x0077E43C File Offset: 0x0077C63C
	private void PlayEndEffect()
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

	// Token: 0x0601B673 RID: 112243 RVA: 0x0077E544 File Offset: 0x0077C744
	[NullableContext(1)]
	private bool IsHit(Vector startLocation, Vector endLocation)
	{
		UTraceLineElement staticLineTrace = SkillUtils.GetStaticLineTrace();
		TraceElementCommon.Instance.SetStartLocation(staticLineTrace, startLocation);
		TraceElementCommon.Instance.SetEndLocation(staticLineTrace, endLocation);
		return TraceElementCommon.Instance.LineTrace(staticLineTrace, "GameplayAbilityVisionMorph.FixLocation") && staticLineTrace.HitResult.bBlockingHit;
	}

	// Token: 0x0601B674 RID: 112244 RVA: 0x0077E590 File Offset: 0x0077C790
	private void VisionDisable(int cueHandle, EntityHandle visionEntity, CharacterGameplayCueComponent visionCueComponent)
	{
		if (this.IsActivating)
		{
			base.GameplayTagComponent.RemoveTag(new int?(GameplayAbilityVisionMisc.invincibleTag));
		}
		if (visionEntity != null && visionEntity.Valid)
		{
			BulletController.Instance.CreateBulletCustomTarget(visionEntity.Entity, "210000004", null, null, null, EBulletCreateSource.Others);
			if (visionCueComponent != null)
			{
				visionCueComponent.RemoveCueByHandle((long)cueHandle);
			}
			this.SetVisionEnable(false, visionEntity);
			this.SetCollision(true, visionEntity);
		}
	}

	// Token: 0x0601B675 RID: 112245 RVA: 0x0077E60B File Offset: 0x0077C80B
	protected virtual void SetVisionEnable(bool enable, EntityHandle visionEntity = null)
	{
		if (visionEntity == null)
		{
			visionEntity = this.VisionEntity;
		}
		CreatureController.Instance.SetEntityEnable(visionEntity.Entity, enable, "GameplayAbilityVisionMorph.SetVisionEnable", true);
		EventSystem.Instance.Emit<bool>(EEventName.OnPhantomEnableStateChange, enable);
	}

	// Token: 0x0601B676 RID: 112246 RVA: 0x0077E640 File Offset: 0x0077C840
	protected virtual void PreInit()
	{
		this.VisionEntity = PhantomUtil.GetSummonedEntity(this.VisionComponent.Entity, ESummonType.ConcomitantVision, 1);
		this.VisionData = PhantomUtil.GetVisionData(this.VisionComponent.GetVisionId(null));
	}

	// Token: 0x0601B677 RID: 112247 RVA: 0x0077E684 File Offset: 0x0077C884
	protected virtual bool NeedNoAi()
	{
		return true;
	}

	// Token: 0x0601B678 RID: 112248 RVA: 0x0077E687 File Offset: 0x0077C887
	protected virtual bool NeedNoActive()
	{
		return true;
	}

	// Token: 0x0601B67C RID: 112252 RVA: 0x0077E6DA File Offset: 0x0077C8DA
	[CompilerGenerated]
	private void <MorphEnd>g__endSkill|25_0()
	{
		BaseSkillComponent skillComponent = base.SkillComponent;
		Skill currentSkill = base.SkillComponent.CurrentSkill;
		skillComponent.EndSkill((currentSkill != null) ? currentSkill.SkillId : 0, "GameplayAbilityVisionMorph.MorphEnd");
	}

	// Token: 0x0400D6A8 RID: 54952
	protected EntityHandle VisionEntity;

	// Token: 0x0400D6A9 RID: 54953
	protected SVisionData VisionData;

	// Token: 0x0400D6AA RID: 54954
	protected CharacterActorComponent VisionActorComponent;

	// Token: 0x0400D6AB RID: 54955
	private BaseTagComponent VisionTagComponent;

	// Token: 0x0400D6AC RID: 54956
	protected CharacterBuffComponent VisionBuffComponent;

	// Token: 0x0400D6AD RID: 54957
	private CharacterGameplayCueComponent VisionCueComponent;

	// Token: 0x0400D6AE RID: 54958
	private CharacterMoveComponent VisionMoveComponent;

	// Token: 0x0400D6AF RID: 54959
	protected VisionSkillComponent VisionSkillComponent;

	// Token: 0x0400D6B0 RID: 54960
	private ITagTask WaitMorphTagRemoveTask;

	// Token: 0x0400D6B1 RID: 54961
	private ITagTask StealthTagTask;

	// Token: 0x0400D6B2 RID: 54962
	private TimerHandle CharacterHiddenTimer;

	// Token: 0x0400D6B3 RID: 54963
	private bool IsActivating;

	// Token: 0x0400D6B4 RID: 54964
	private bool IsMorphing;

	// Token: 0x0400D6B5 RID: 54965
	private bool Synchronized;

	// Token: 0x0400D6B6 RID: 54966
	private bool PrintLog;
}
