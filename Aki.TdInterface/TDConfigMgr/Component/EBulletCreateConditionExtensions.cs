using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009AF RID: 2479
	public static class EBulletCreateConditionExtensions
	{
		// Token: 0x060037A6 RID: 14246 RVA: 0x0008D114 File Offset: 0x0008B314
		public static string ToEnumString(this EBulletCreateCondition value)
		{
			string result;
			switch (value)
			{
			case EBulletCreateCondition.OnHit:
				result = "OnHit";
				break;
			case EBulletCreateCondition.OnMatching:
				result = "OnMatching";
				break;
			case EBulletCreateCondition.OnCollision:
				result = "OnCollision";
				break;
			case EBulletCreateCondition.OnThrowTriggerTime:
				result = "OnThrowDelayTime";
				break;
			case EBulletCreateCondition.OpenGravityCollision:
				result = "OpenGravityCollision";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x0008D174 File Offset: 0x0008B374
		public static EBulletCreateCondition FromString(string name)
		{
			EBulletCreateCondition result;
			if (!EBulletCreateConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBulletCreateCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x0008D1A0 File Offset: 0x0008B3A0
		public static bool TryFromString(string name, out EBulletCreateCondition value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBulletCreateCondition.OnHit;
				return false;
			}
			if (name == "OnHit")
			{
				value = EBulletCreateCondition.OnHit;
				return true;
			}
			if (name == "OnMatching")
			{
				value = EBulletCreateCondition.OnMatching;
				return true;
			}
			if (name == "OnCollision")
			{
				value = EBulletCreateCondition.OnCollision;
				return true;
			}
			if (name == "OnThrowDelayTime")
			{
				value = EBulletCreateCondition.OnThrowTriggerTime;
				return true;
			}
			if (!(name == "OpenGravityCollision"))
			{
				value = EBulletCreateCondition.OnHit;
				return false;
			}
			value = EBulletCreateCondition.OpenGravityCollision;
			return true;
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x0008D21A File Offset: 0x0008B41A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OnHit",
				"OnMatching",
				"OnCollision",
				"OnThrowDelayTime",
				"OpenGravityCollision"
			};
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x0008D24A File Offset: 0x0008B44A
		public static EBulletCreateCondition[] GetValues()
		{
			return new EBulletCreateCondition[]
			{
				EBulletCreateCondition.OnHit,
				EBulletCreateCondition.OnMatching,
				EBulletCreateCondition.OnCollision,
				EBulletCreateCondition.OnThrowTriggerTime,
				EBulletCreateCondition.OpenGravityCollision
			};
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x0008D25D File Offset: 0x0008B45D
		public static string[] GetNames()
		{
			return new string[]
			{
				"OnHit",
				"OnMatching",
				"OnCollision",
				"OnThrowTriggerTime",
				"OpenGravityCollision"
			};
		}
	}
}
