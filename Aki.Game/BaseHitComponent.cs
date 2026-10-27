using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Module.CombatMessage;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02003032 RID: 12338
[NullableContext(1)]
[Nullable(0)]
public class BaseHitComponent : EntityComponent
{
	// Token: 0x0601A251 RID: 107089 RVA: 0x006DE0A4 File Offset: 0x006DC2A4
	protected void HitRequest(BulletEntity bulletEntity, long attackerCreatureDataId, global::HitInformation hitData, int beHitAnim = 0, bool enterFk = false, bool isHitWeakness = false, ECounterAttackType counterAttackType = ECounterAttackType.None, FRotator? victimRotation = null, bool isChangeVictimRotation = false, int? fightState = null, [Nullable(new byte[]
	{
		2,
		1
	})] Action<HitResponse> callback = null)
	{
		Aki.Protocol.HitInformation hitInformation = Aki.Protocol.HitInformation.Create();
		long creatureDataId = base.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
		hitInformation.Id = attackerCreatureDataId;
		hitInformation.TargetId = MathUtils.Instance.NumberToLong(creatureDataId);
		hitInformation.BulletId = MathUtils.Instance.NumberToLong(hitData.BulletId);
		global::Vector hitPosition = hitData.HitPosition;
		hitInformation.HitEffectPos = Aki.Protocol.Vector.Create();
		hitInformation.HitEffectPos.X = (float)hitPosition.X;
		hitInformation.HitEffectPos.Y = (float)hitPosition.Y;
		hitInformation.HitEffectPos.Z = (float)hitPosition.Z;
		hitInformation.HitEffectRotate = Aki.Protocol.Rotator.Create();
		hitInformation.HitEffectRotate.Pitch = hitData.HitEffectRotation.Pitch;
		hitInformation.HitEffectRotate.Yaw = hitData.HitEffectRotation.Yaw;
		hitInformation.HitEffectRotate.Roll = hitData.HitEffectRotation.Roll;
		hitInformation.HitPos = Aki.Protocol.Vector.Create();
		hitInformation.HitPos.X = (float)hitPosition.X;
		hitInformation.HitPos.Y = (float)hitPosition.Y;
		hitInformation.HitPos.Z = (float)hitPosition.Z;
		hitInformation.BeHitAnim = beHitAnim;
		hitInformation.EnterFk = enterFk;
		hitInformation.IsHitWeakness = isHitWeakness;
		hitInformation.IsTriggerCounterattack = (counterAttackType == ECounterAttackType.Normal);
		hitInformation.IsTriggerVisionCounterAttack = (counterAttackType == ECounterAttackType.Vision);
		hitInformation.VictimRotation = Aki.Protocol.Rotator.Create();
		hitInformation.VictimRotation.Pitch = ((victimRotation != null) ? victimRotation.GetValueOrDefault().Pitch : 0f);
		hitInformation.VictimRotation.Roll = ((victimRotation != null) ? victimRotation.GetValueOrDefault().Roll : 0f);
		hitInformation.VictimRotation.Yaw = ((victimRotation != null) ? victimRotation.GetValueOrDefault().Yaw : 0f);
		bool hasBeHitData = hitData.HitEffect != null;
		hitInformation.HasBeHitData = hasBeHitData;
		hitInformation.HitPart = (((hitData.HitPart != null) ? hitData.HitPart.GetValueOrDefault().ToString() : null) ?? "");
		hitInformation.IsChangeVictimRotation = isChangeVictimRotation;
		BulletInfo bulletInfo = bulletEntity.GetBulletInfo();
		hitInformation.SkillId = (long)bulletInfo.BulletInitParams.SkillId;
		hitInformation.Source = bulletInfo.BulletInitParams.Source;
		Aki.Protocol.HitInformation hitInformation2 = hitInformation;
		ISkillBattleContext battleContext = bulletInfo.BulletInitParams.BattleContext;
		hitInformation2.PhantomSkillIdentify = ((battleContext != null) ? battleContext.VisionId : 0);
		if (fightState != null)
		{
			hitInformation.FightState = fightState.Value;
		}
		HitRequest hitRequest = Aki.Protocol.HitRequest.Create();
		hitRequest.HitInfo = hitInformation;
		if (bulletInfo.BulletInitParams.SkillContextId != null)
		{
			hitRequest.SkillMessageId = bulletInfo.BulletInitParams.SkillContextId.Value;
		}
		this.CompressData(hitRequest);
		CombatNet.Instance.Call(ERequestMessageId.HitRequest, base.Entity, hitRequest, delegate(IMessage msg)
		{
			HitResponse obj = (HitResponse)msg;
			Action<HitResponse> callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2(obj);
		}, (bulletEntity != null) ? bulletEntity.GetBulletInfo().ContextId : null, null, null, null);
	}

	// Token: 0x0601A252 RID: 107090 RVA: 0x006DE3DC File Offset: 0x006DC5DC
	private void CompressData(HitRequest data)
	{
		if (!GameModeModel.Instance.IsMulti)
		{
			data.HitInfo.Originator = 0L;
			data.HitInfo.TargetId = 0L;
			data.HitInfo.HasBeHitData = false;
			data.HitInfo.HitEffectPos = null;
			data.HitInfo.HitEffectRotate = null;
			data.HitInfo.IsShake = false;
			data.HitInfo.EnterFk = false;
			data.HitInfo.IsHitWeakness = false;
			data.HitInfo.VictimRotation = null;
			data.HitInfo.IsChangeVictimRotation = false;
			data.HitInfo.HitPart = "";
			data.HitInfo.BeHitAnim = 0;
		}
	}

	// Token: 0x0601A253 RID: 107091 RVA: 0x006DE490 File Offset: 0x006DC690
	public static void HitEndRequest(Entity entity)
	{
		HitEndPush message = HitEndPush.Create();
		CombatNet.Instance.Send(EPushMessageId.HitEndPush, entity, message, null, null, null);
	}

	// Token: 0x0601A254 RID: 107092 RVA: 0x006DE4D0 File Offset: 0x006DC6D0
	[NullableContext(2)]
	[CombatPreprocess(ENotifyMessageId.HitNotify)]
	public static bool PreHitNotify(Entity entity, [Nullable(1)] HitNotify notify, CombatCommon combatCommon = null)
	{
		Aki.Protocol.HitInformation hitInfo = notify.HitInfo;
		if (hitInfo != null && hitInfo.HasBeHitData && !notify.HitInfo.EnterFk)
		{
			CharacterFightStateComponent component = entity.GetComponent<CharacterFightStateComponent>();
			if (component != null && !component.PreSwitchRemoteFightState(notify.HitInfo.FightState))
			{
				notify.HitInfo.EnterFk = true;
				notify.HitInfo.FightState = 0;
			}
		}
		return true;
	}

	// Token: 0x0601A255 RID: 107093 RVA: 0x006DE534 File Offset: 0x006DC734
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.HitNotify, true, false)]
	public static void HitNotify(Entity entity, [Nullable(1)] HitNotify notify, CombatCommon combatCommon = null)
	{
		long id = notify.HitInfo.Id;
		EntityHandle entity2 = CreatureModel.Instance.GetEntity(id);
		if (entity2 == null || !entity2.Valid)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.WCL;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(62, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[ControllerHolder.CreatureController.HitNotify] 攻击者为空，不存在动态实体:");
			defaultInterpolatedStringHandler.AppendFormatted<long>(id);
			instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		WorldEntity entity3 = entity2.Entity;
		string text = notify.HitInfo.BulletId.ToString();
		BulletDataMain bulletData = BulletConfig.Instance.GetBulletData(entity3, text, true);
		if (bulletData == null)
		{
			Log.Instance.Error(ELogModule.World, ELogAuthor.WCL, "[ControllerHolder.CreatureController.HitNotify] 子弹数据不存在;" + text + "。", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		global::HitInformation hitInformation = new global::HitInformation(entity3, entity, null, 0L, null, notify.HitInfo.IsShake, null, null, 0, bulletData, text, bulletData.Base.DamageId, null, 0, 0, false);
		if (notify.HitInfo.HitEffectRotate != null)
		{
			hitInformation.HitEffectRotation.Set(notify.HitInfo.HitEffectRotate.Pitch, notify.HitInfo.HitEffectRotate.Yaw, notify.HitInfo.HitEffectRotate.Roll);
		}
		if (notify.HitInfo.HitPos != null)
		{
			hitInformation.HitPosition.Set((double)notify.HitInfo.HitPos.X, (double)notify.HitInfo.HitPos.Y, (double)notify.HitInfo.HitPos.Z);
		}
		if (!string.IsNullOrEmpty(notify.HitInfo.HitPart))
		{
			hitInformation.HitPart = FNameUtil.GetDynamicFName(notify.HitInfo.HitPart);
		}
		FRotator victimRotation = WorldGlobal.ToUeRotator(notify.HitInfo.VictimRotation);
		BaseHitComponent baseHitComponent = (entity != null) ? entity.GetComponent<BaseHitComponent>() : null;
		if (baseHitComponent != null)
		{
			baseHitComponent.ReceiveOnHit(hitInformation, entity3, notify.HitInfo.HasBeHitData, notify.HitInfo.IsChangeVictimRotation, notify.HitInfo.EnterFk, notify.HitInfo.IsHitWeakness, notify.HitInfo.IsTriggerCounterattack, notify.HitInfo.IsTriggerVisionCounterAttack, victimRotation, notify.HitInfo.FightState, (EHitAnim)notify.HitInfo.BeHitAnim);
		}
		if (baseHitComponent == null)
		{
			return;
		}
		baseHitComponent.BroadcastRemoteEvent(entity3, notify.HitInfo);
	}

	// Token: 0x0601A256 RID: 107094 RVA: 0x006DE797 File Offset: 0x006DC997
	protected virtual void ReceiveOnHit(global::HitInformation hitData, Entity attackEntity, bool hasBeHitData, bool isChangeVictimRotation, bool enterFk, bool isHitWeakness, bool isTriggerCounterattack, bool isTriggerVisionCounterAttack, FRotator victimRotation, int fightState, EHitAnim beHitAnim)
	{
	}

	// Token: 0x0601A257 RID: 107095 RVA: 0x006DE79C File Offset: 0x006DC99C
	protected virtual void BroadcastEvent(global::HitInformation hitData)
	{
		Entity entity = EntitySystem.Instance.Get<Entity>(hitData.Attacker.Id);
		BulletInfo bulletInfo = EntitySystem.Instance.Get<BulletEntity>(hitData.BulletEntityId).GetBulletInfo();
		int skillId = bulletInfo.BulletInitParams.SkillId;
		long? skillContextId = bulletInfo.BulletInitParams.SkillContextId;
		BaseSkillComponent baseSkillComponent = (entity != null) ? entity.GetComponent<BaseSkillComponent>() : null;
		Skill skill = (baseSkillComponent != null) ? baseSkillComponent.GetSkill(skillId) : null;
		List<string> list;
		if (skill == null)
		{
			list = null;
		}
		else
		{
			ISkillBattleContext battleContext = skill.BattleContext;
			list = ((battleContext != null) ? battleContext.BattleFlags : null);
		}
		List<string> list2 = list;
		HitContext p = new HitContext
		{
			Attacker = entity,
			Target = base.Entity,
			BulletId = hitData.BulletId,
			HasBeHitAnim = false,
			BeHitAnim = EHitAnim.轻左,
			VisionCounterAttackId = 0,
			CounterAttackType = ECounterAttackType.None,
			SkillId = skillId,
			SkillHitCount = CombatMessageModel.Instance.AddSkillHitCount(skillContextId),
			SkillHitCountByVictim = CombatMessageModel.Instance.AddSkillHitCountByVictim(skillContextId, base.Entity.Id),
			BulletHitCount = new int?(bulletInfo.HitNumberAll),
			BulletHitCountByVictim = new int?(BulletHitCountUtil.GetHitCountByVictim(bulletInfo, base.Entity.Id)),
			SkillGenres = (((baseSkillComponent != null) ? baseSkillComponent.GetSkillGenres(skillId) : null) ?? Array.Empty<ESkillGenre>()),
			BattleFlags = ((list2 != null) ? list2.ToArray() : Array.Empty<string>())
		};
		if (entity != null)
		{
			SceneTeamController.Instance.EmitEvent<global::HitInformation, HitContext>(entity, EEventName.CharHitLocal, hitData, p);
		}
		SceneTeamController.Instance.EmitEvent<global::HitInformation, HitContext>(base.Entity, EEventName.CharBeHitLocal, hitData, p);
	}

	// Token: 0x0601A258 RID: 107096 RVA: 0x006DE928 File Offset: 0x006DCB28
	[NullableContext(2)]
	protected void BroadcastRemoteEvent(Entity attackEntity, Aki.Protocol.HitInformation hitInfo)
	{
		if (attackEntity == null || hitInfo == null)
		{
			return;
		}
		if (attackEntity != null)
		{
			int skillId = (int)hitInfo.SkillId;
			BaseSkillComponent component = attackEntity.GetComponent<BaseSkillComponent>();
			Skill skill = (component != null) ? component.GetSkill(skillId) : null;
			List<string> list;
			if (skill == null)
			{
				list = null;
			}
			else
			{
				ISkillBattleContext battleContext = skill.BattleContext;
				list = ((battleContext != null) ? battleContext.BattleFlags : null);
			}
			List<string> list2 = list;
			HitContext p = new HitContext
			{
				Attacker = attackEntity,
				Target = base.Entity,
				BulletId = hitInfo.BulletId,
				HasBeHitAnim = false,
				BeHitAnim = (EHitAnim)hitInfo.BeHitAnim,
				VisionCounterAttackId = 0,
				CounterAttackType = (hitInfo.IsTriggerVisionCounterAttack ? ECounterAttackType.Vision : (hitInfo.IsTriggerCounterattack ? ECounterAttackType.Normal : ECounterAttackType.None)),
				SkillId = skillId,
				SkillHitCount = null,
				SkillHitCountByVictim = null,
				BulletHitCount = null,
				BulletHitCountByVictim = null,
				SkillGenres = (((component != null) ? component.GetSkillGenres(skillId) : null) ?? Array.Empty<ESkillGenre>()),
				BattleFlags = ((list2 != null) ? list2.ToArray() : Array.Empty<string>())
			};
			SceneTeamController.Instance.EmitEvent<HitContext>(attackEntity, EEventName.CharHitRemote, p);
			SceneTeamController.Instance.EmitEvent<HitContext>(base.Entity, EEventName.CharBeHitRemote, p);
		}
	}

	// Token: 0x0601A259 RID: 107097 RVA: 0x006DEA5E File Offset: 0x006DCC5E
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseHitComponent baseHitComponent = (BaseHitComponent)componentTemplate;
		return true;
	}
}
