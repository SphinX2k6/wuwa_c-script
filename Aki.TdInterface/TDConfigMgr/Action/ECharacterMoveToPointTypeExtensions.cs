using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D9 RID: 8921
	public static class ECharacterMoveToPointTypeExtensions
	{
		// Token: 0x0600C34F RID: 49999 RVA: 0x001C8A34 File Offset: 0x001C6C34
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

		// Token: 0x0600C350 RID: 50000 RVA: 0x001C8A6C File Offset: 0x001C6C6C
		public static ECharacterMoveToPointType FromString(string name)
		{
			ECharacterMoveToPointType result;
			if (!ECharacterMoveToPointTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECharacterMoveToPointType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C351 RID: 50001 RVA: 0x001C8A95 File Offset: 0x001C6C95
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

		// Token: 0x0600C352 RID: 50002 RVA: 0x001C8ACE File Offset: 0x001C6CCE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Walk",
				"Adaptive"
			};
		}

		// Token: 0x0600C353 RID: 50003 RVA: 0x001C8AE6 File Offset: 0x001C6CE6
		public static ECharacterMoveToPointType[] GetValues()
		{
			return new ECharacterMoveToPointType[]
			{
				ECharacterMoveToPointType.Walk,
				ECharacterMoveToPointType.Adaptive
			};
		}

		// Token: 0x0600C354 RID: 50004 RVA: 0x001C8AF2 File Offset: 0x001C6CF2
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
