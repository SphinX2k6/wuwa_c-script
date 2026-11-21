using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200266A RID: 9834
	public static class EPlayerTypeExtensions
	{
		// Token: 0x0600D437 RID: 54327 RVA: 0x001ED3E0 File Offset: 0x001EB5E0
		public static string ToEnumString(this EPlayerType value)
		{
			string result;
			switch (value)
			{
			case EPlayerType.P1:
				result = "P1";
				break;
			case EPlayerType.P2:
				result = "P2";
				break;
			case EPlayerType.P3:
				result = "P3";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D438 RID: 54328 RVA: 0x001ED428 File Offset: 0x001EB628
		public static EPlayerType FromString(string name)
		{
			EPlayerType result;
			if (!EPlayerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D439 RID: 54329 RVA: 0x001ED454 File Offset: 0x001EB654
		public static bool TryFromString(string name, out EPlayerType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlayerType.P1;
				return false;
			}
			if (name == "P1")
			{
				value = EPlayerType.P1;
				return true;
			}
			if (name == "P2")
			{
				value = EPlayerType.P2;
				return true;
			}
			if (!(name == "P3"))
			{
				value = EPlayerType.P1;
				return false;
			}
			value = EPlayerType.P3;
			return true;
		}

		// Token: 0x0600D43A RID: 54330 RVA: 0x001ED4AA File Offset: 0x001EB6AA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"P1",
				"P2",
				"P3"
			};
		}

		// Token: 0x0600D43B RID: 54331 RVA: 0x001ED4CA File Offset: 0x001EB6CA
		public static EPlayerType[] GetValues()
		{
			return new EPlayerType[]
			{
				EPlayerType.P1,
				EPlayerType.P2,
				EPlayerType.P3
			};
		}

		// Token: 0x0600D43C RID: 54332 RVA: 0x001ED4DA File Offset: 0x001EB6DA
		public static string[] GetNames()
		{
			return new string[]
			{
				"P1",
				"P2",
				"P3"
			};
		}
	}
}
