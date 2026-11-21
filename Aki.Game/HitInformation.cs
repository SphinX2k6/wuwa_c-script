using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002345 RID: 9029
[NullableContext(1)]
[Nullable(0)]
public class HitInformation
{
	// Token: 0x0601637A RID: 91002 RVA: 0x0067A3B8 File Offset: 0x006785B8
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

	// Token: 0x0601637B RID: 91003 RVA: 0x0067A4AC File Offset: 0x006786AC
	public static HitInformation FromUeHitInformation(SHitInformation hitInfo)
	{
		return new HitInformation(CharacterController.Instance.GetEntityByUeTsBaseCharacter(hitInfo.攻击者), CharacterController.Instance.GetEntityByUeTsBaseCharacter(hitInfo.受击者), hitInfo.被击效果, (long)hitInfo.子弹ID, new FRotator?(hitInfo.受击特效旋转), hitInfo.是否震动, new FName?(hitInfo.受击部位), hitInfo.受击位置, hitInfo.技能等级, new BulletDataMain(hitInfo.重构子弹数据, "", null), hitInfo.子弹表ID, hitInfo.伤害ID, hitInfo.子弹逻辑预设, hitInfo.子弹ID, hitInfo.伤害类型, false);
	}

	// Token: 0x0601637C RID: 91004 RVA: 0x0067A548 File Offset: 0x00678748
	public SHitInformation ToUeHitInformation()
	{
		SHitEffect 被击效果 = this.HitEffect ?? new SHitEffect();
		int 子弹ID = (this.BulletId >= -2147483648L && this.BulletId <= 2147483647L) ? ((int)this.BulletId) : int.MinValue;
		return new SHitInformation
		{
			攻击者 = CharacterController.Instance.GetUeTsBaseCharacterByEntity(this.Attacker),
			受击者 = CharacterController.Instance.GetUeTsBaseCharacterByEntity(this.Target),
			被击效果 = 被击效果,
			子弹ID = 子弹ID,
			受击特效位置 = this.HitPosition.ToUeVectorOld(),
			受击特效旋转 = this.HitEffectRotation.ToUeRotator(),
			是否震动 = this.IsShaking,
			受击部位 = this.HitPart.Value,
			受击位置 = this.HitPosition.ToUeVectorOld(),
			技能等级 = this.SkillLevel,
			重构子弹数据 = this.ReBulletData.Data,
			子弹逻辑预设 = this.BulletDataPreset,
			子弹表ID = this.BulletRowName,
			伤害类型 = this.CalculateType,
			伤害ID = this.DamageId
		};
	}

	// Token: 0x0400BB72 RID: 47986
	public readonly Vector HitPosition = Vector.Create();

	// Token: 0x0400BB73 RID: 47987
	public readonly Rotator HitEffectRotation = Rotator.Create();

	// Token: 0x0400BB74 RID: 47988
	[Nullable(2)]
	public Entity Target;

	// Token: 0x0400BB75 RID: 47989
	public FName? HitPart;

	// Token: 0x0400BB76 RID: 47990
	public long BulletId;

	// Token: 0x0400BB77 RID: 47991
	public string BulletRowName;

	// Token: 0x0400BB78 RID: 47992
	public int SkillLevel;

	// Token: 0x0400BB79 RID: 47993
	public Entity Attacker;

	// Token: 0x0400BB7A RID: 47994
	public bool IsShaking;

	// Token: 0x0400BB7B RID: 47995
	[Nullable(2)]
	public SHitEffect HitEffect;

	// Token: 0x0400BB7C RID: 47996
	public BulletDataMain ReBulletData;

	// Token: 0x0400BB7D RID: 47997
	[Nullable(2)]
	public BulletLogicType_C BulletDataPreset;

	// Token: 0x0400BB7E RID: 47998
	public int BulletEntityId;

	// Token: 0x0400BB7F RID: 47999
	public int CalculateType = -1;

	// Token: 0x0400BB80 RID: 48000
	public long DamageId;

	// Token: 0x0400BB81 RID: 48001
	[Nullable(2)]
	public Entity DirectTarget;

	// Token: 0x0400BB82 RID: 48002
	public bool ShouldOptimize;

	// Token: 0x0400BB83 RID: 48003
	public bool IsAddEnergy;
}
