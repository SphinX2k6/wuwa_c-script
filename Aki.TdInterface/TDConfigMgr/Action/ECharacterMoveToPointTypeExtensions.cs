using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002548 RID: 9544
	public static class ECharacterMoveToPointTypeExtensions
	{
		// Token: 0x0600CF1E RID: 53022 RVA: 0x001E083C File Offset: 0x001DEA3C
		public static string ToEnumString(this ECharacterMoveToPointType value)
		{
			string result;
			if (value != ECharacterMoveToPointType.Walk)
			{
				if (value != ECharacterMoveToPointType.Adaptive)
				{
					result = value.ToString();
				}
				else
				{
					result = "Adaptive";
				}
			}
			else
			{
				result = "Walk";
			}
			return result;
		}

		// Token: 0x0600CF1F RID: 53023 RVA: 0x001E0874 File Offset: 0x001DEA74
		public static ECharacterMoveToPointType FromString(string name)
		{
			ECharacterMoveToPointType result;
			if (!ECharacterMoveToPointTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECharacterMoveToPointType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF20 RID: 53024 RVA: 0x001E089D File Offset: 0x001DEA9D
		public static bool TryFromString(string name, out ECharacterMoveToPointType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECharacterMoveToPointType.Walk;
				return false;
			}
			if (name == "Walk")
			{
				value = ECharacterMoveToPointType.Walk;
				return true;
			}
			if (!(name == "Adaptive"))
			{
				value = ECharacterMoveToPointType.Walk;
				return false;
			}
			value = ECharacterMoveToPointType.Adaptive;
			return true;
		}

		// Token: 0x0600CF21 RID: 53025 RVA: 0x001E08D6 File Offset: 0x001DEAD6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Walk",
				"Adaptive"
			};
		}

		// Token: 0x0600CF22 RID: 53026 RVA: 0x001E08EE File Offset: 0x001DEAEE
		public static ECharacterMoveToPointType[] GetValues()
		{
			return new ECharacterMoveToPointType[]
			{
				ECharacterMoveToPointType.Walk,
				ECharacterMoveToPointType.Adaptive
			};
		}

		// Token: 0x0600CF23 RID: 53027 RVA: 0x001E08FA File Offset: 0x001DEAFA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Walk",
				"Adaptive"
			};
		}
	}
}
