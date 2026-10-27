using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002DEA RID: 11754
[NullableContext(1)]
[Nullable(0)]
public class HitInformation
{
	// Token: 0x06018ACD RID: 101069 RVA: 0x006542D8 File Offset: 0x006524D8
	[NullableContext(2)]
	public HitInformation([Nullable(1)] Entity attacker, Entity target, SHitEffect hitEffect, long bulletId, FRotator? hitEffectRotation, bool isShaking, FName? hitPart, IVector hitPosition, int skillLevel, [Nullable(1)] BulletDataMain reBulletData, [Nullable(1)] string bulletRowName, long damageId, BulletLogicType_C bulletDataPreset, int bulletEntityId, int calculateType, bool ShouldOptimize)
	{
		if (hitPosition != null)
		{
			this.HitPosition.FromUeVector(hitPosition);
		}
		else
		{
			this.HitPosition.Reset();
		}
		if (hitEffectRotation != null)
		{
			Rotator hitEffectRotation2 = this.HitEffectRotation;
			FRotator value = hitEffectRotation.Value;
			hitEffectRotation2.FromUeRotator(value);
		}
		else
		{
			this.HitEffectRotation.Reset();
		}
		this.Target = target;
		this.HitPart = hitPart;
		this.BulletId = bulletId;
		this.SkillLevel = skillLevel;
		this.Attacker = attacker;
		this.IsShaking = isShaking;
		this.HitEffect = hitEffect;
		this.ReBulletData = reBulletData;
		this.BulletDataPreset = bulletDataPreset;
		this.BulletEntityId = bulletEntityId;
		this.BulletRowName = bulletRowName;
		this.CalculateType = calculateType;
		this.DamageId = damageId;
		this.DirectTarget = target;
		this.ShouldOptimize = ShouldOptimize;
		this.IsAddEnergy = false;
	}

	// Token: 0x06018ACE RID: 101070 RVA: 0x006543CC File Offset: 0x006525CC
	public static HitInformation FromUeHitInformation(SHitInformation hitInfo)
	{
		return new HitInformation(CharacterController.Instance.GetEntityByUeTsBaseCharacter(hitInfo.攻击者), CharacterController.Instance.GetEntityByUeTsBaseCharacter(hitInfo.受击者), hitInfo.被击效果, (long)hitInfo.子弹ID, new FRotator?(hitInfo.受击特效旋转), hitInfo.是否震动, new FName?(hitInfo.受击部位), hitInfo.受击位置, hitInfo.技能等级, new BulletDataMain(hitInfo.重构子弹数据, "", null), hitInfo.子弹表ID, hitInfo.伤害ID, hitInfo.子弹逻辑预设, hitInfo.子弹ID, hitInfo.伤害类型, false);
	}

	// Token: 0x06018ACF RID: 101071 RVA: 0x00654468 File Offset: 0x00652668
	public SHitInformation ToUeHitInformation()
	{
		SHitEffect 被击效果 = this.HitEffect ?? new SHitEffect();
		int 子弹ID = (this.BulletId >= -2147483648L && this.BulletId <= 2147483647L) ? ((int)this.BulletId) : int.MinValue;
		return new SHitInformation(CharacterController.Instance.GetUeTsBaseCharacterByEntity(this.Attacker), CharacterController.Instance.GetUeTsBaseCharacterByEntity(this.Target), 被击效果, 子弹ID, this.HitPosition.ToUeVectorOld(), this.HitEffectRotation.ToUeRotator(), this.IsShaking, this.HitPart.Value, this.HitPosition.ToUeVectorOld(), this.SkillLevel, this.ReBulletData.Data, this.BulletDataPreset, this.BulletRowName, this.CalculateType, this.DamageId);
	}

	// Token: 0x0400B7EC RID: 47084
	public readonly Vector HitPosition = Vector.Create();

	// Token: 0x0400B7ED RID: 47085
	public readonly Rotator HitEffectRotation = Rotator.Create();

	// Token: 0x0400B7EE RID: 47086
	[Nullable(2)]
	public Entity Target;

	// Token: 0x0400B7EF RID: 47087
	public FName? HitPart;

	// Token: 0x0400B7F0 RID: 47088
	public long BulletId;

	// Token: 0x0400B7F1 RID: 47089
	public string BulletRowName;

	// Token: 0x0400B7F2 RID: 47090
	public int SkillLevel;

	// Token: 0x0400B7F3 RID: 47091
	public Entity Attacker;

	// Token: 0x0400B7F4 RID: 47092
	public bool IsShaking;

	// Token: 0x0400B7F5 RID: 47093
	[Nullable(2)]
	public SHitEffect HitEffect;

	// Token: 0x0400B7F6 RID: 47094
	public BulletDataMain ReBulletData;

	// Token: 0x0400B7F7 RID: 47095
	[Nullable(2)]
	public BulletLogicType_C BulletDataPreset;

	// Token: 0x0400B7F8 RID: 47096
	public int BulletEntityId;

	// Token: 0x0400B7F9 RID: 47097
	public int CalculateType = -1;

	// Token: 0x0400B7FA RID: 47098
	public long DamageId;

	// Token: 0x0400B7FB RID: 47099
	[Nullable(2)]
	public Entity DirectTarget;

	// Token: 0x0400B7FC RID: 47100
	public bool ShouldOptimize;

	// Token: 0x0400B7FD RID: 47101
	public bool IsAddEnergy;
}
