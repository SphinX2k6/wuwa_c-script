using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000906 RID: 2310
	public static class EBulletCreateConditionExtensions
	{
		// Token: 0x0600344C RID: 13388 RVA: 0x000858A4 File Offset: 0x00083AA4
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

		// Token: 0x0600344D RID: 13389 RVA: 0x00085904 File Offset: 0x00083B04
		public static EBulletCreateCondition FromString(string name)
		{
			EBulletCreateCondition result;
			if (!EBulletCreateConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBulletCreateCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x00085930 File Offset: 0x00083B30
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

		// Token: 0x0600344F RID: 13391 RVA: 0x000859AA File Offset: 0x00083BAA
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

		// Token: 0x06003450 RID: 13392 RVA: 0x000859DA File Offset: 0x00083BDA
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

		// Token: 0x06003451 RID: 13393 RVA: 0x000859ED File Offset: 0x00083BED
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
