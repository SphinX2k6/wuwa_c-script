using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using CSharpScript.Game.NewWorld.Vehicle.Motorcycle;

namespace CSharpScript.Game.NewWorld.SceneItem.Util
{
	// Token: 0x02006253 RID: 25171
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemHitUtils
	{
		// Token: 0x0603CBA3 RID: 248739 RVA: 0x0116F374 File Offset: 0x0116D574
		public static bool CheckHitDataMatchBulletType(IHitBulletType matchedBullet, HitInformation hitData, Entity victim)
		{
			switch (matchedBullet.Type)
			{
			case EHitBulletType.OnlyDropAttack:
				return SceneItemHitUtils.CheckHitDataMatchOnlyDropAttack(hitData, victim);
			case EHitBulletType.CrystalAttack:
				return SceneItemHitUtils.CheckHitDataMatchCrystalAttack(hitData);
			case EHitBulletType.PlayerAttack:
				return SceneItemHitUtils.CheckHitDataMatchPlayerAttack(hitData);
			case EHitBulletType.FixedBulletId:
				return SceneItemHitUtils.CheckHitDataMatchFixedBulletId((IHitBulletTypeFixedBulletId)matchedBullet, hitData);
			default:
				return true;
			}
		}

		// Token: 0x0603CBA4 RID: 248740 RVA: 0x0116F3C4 File Offset: 0x0116D5C4
		public static bool CheckHitDataMatchOnlyDropAttack(HitInformation hitData, Entity victim)
		{
			if (Array.IndexOf<int>(hitData.ReBulletData.Logic.PresentTagIds, GameplayTagDefine.EGameplayTagId["子弹.机关触发.下落攻击触发"]) < 0)
			{
				return false;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			BaseActorComponent component = victim.GetComponent<BaseActorComponent>();
			return characterActorComponent != null && component != null && Vector.DistSquared2D(component.ActorLocationProxy, characterActorComponent.ActorLocationProxy) <= 28900.0;
		}

		// Token: 0x0603CBA5 RID: 248741 RVA: 0x0116F43A File Offset: 0x0116D63A
		public static bool CheckHitDataMatchCrystalAttack(HitInformation hitData)
		{
			return Array.IndexOf<int>(hitData.ReBulletData.Logic.PresentTagIds, GameplayTagDefine.EGameplayTagId["子弹.机关触发.鸣晶爆炸触发"]) >= 0;
		}

		// Token: 0x0603CBA6 RID: 248742 RVA: 0x0116F468 File Offset: 0x0116D668
		public static bool CheckHitDataMatchGundamBossOrPlayerAttack(HitInformation hitData)
		{
			Entity attacker = hitData.Attacker;
			if (attacker == null || !attacker.Valid)
			{
				return false;
			}
			CreatureDataComponent component = hitData.Attacker.GetComponent<CreatureDataComponent>();
			return component != null && (component.GetTemplateId() == 672000001 || SceneItemHitUtils.CheckHitDataMatchPlayerAttack(hitData));
		}

		// Token: 0x0603CBA7 RID: 248743 RVA: 0x0116F4B0 File Offset: 0x0116D6B0
		public static bool CheckHitDataMatchPlayerAttack(HitInformation hitData)
		{
			if (hitData.Attacker == null || !hitData.Attacker.Valid)
			{
				return false;
			}
			CreatureDataComponent component = hitData.Attacker.GetComponent<CreatureDataComponent>();
			if ((component != null && component.IsRole()) || (component != null && component.IsVision()))
			{
				return true;
			}
			EntityHandle entity = CreatureModel.Instance.GetEntity(component.GetSummonerId());
			WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
			CreatureDataComponent creatureDataComponent = (worldEntity != null) ? worldEntity.GetComponent<CreatureDataComponent>() : null;
			if (creatureDataComponent != null && creatureDataComponent.IsRole())
			{
				return true;
			}
			VehiclePerformComponent component2 = hitData.Attacker.GetComponent<VehiclePerformComponent>();
			bool flag;
			if (component2 == null)
			{
				flag = false;
			}
			else
			{
				Entity driver = component2.Driver;
				bool? flag2;
				if (driver == null)
				{
					flag2 = null;
				}
				else
				{
					CreatureDataComponent component3 = driver.GetComponent<CreatureDataComponent>();
					flag2 = ((component3 != null) ? new bool?(component3.IsRole()) : null);
				}
				bool? flag3 = flag2;
				flag = flag3.GetValueOrDefault();
			}
			if (flag)
			{
				return true;
			}
			if (hitData.Attacker.GetComponent<MotorcycleConfigComponent>() != null)
			{
				return true;
			}
			CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow.FollowShooterComponent component4 = hitData.Attacker.GetComponent<CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow.FollowShooterComponent>();
			return component4 != null && component4.Valid;
		}

		// Token: 0x0603CBA8 RID: 248744 RVA: 0x0116F5AC File Offset: 0x0116D7AC
		public static bool CheckHitDataMatchFixedBulletId(IHitBulletTypeFixedBulletId matchedBullet, HitInformation hitData)
		{
			return hitData.Attacker != null && hitData.Attacker.Valid && (matchedBullet.BulletId == null || matchedBullet.BulletId.Count == 0 || matchedBullet.BulletId.Contains(hitData.BulletId) || (matchedBullet.PlayerAttack.GetValueOrDefault() && SceneItemHitUtils.CheckHitDataMatchPlayerAttack(hitData)));
		}

		// Token: 0x0402033B RID: 131899
		private const int DROP_ATTACK_VALID_RANGE = 28900;

		// Token: 0x0402033C RID: 131900
		private const int GUNDAM_BOSS_TEMPLATE_ID = 672000001;
	}
}
