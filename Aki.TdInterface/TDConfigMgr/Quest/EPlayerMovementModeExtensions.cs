using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013A8 RID: 5032
	public static class EPlayerMovementModeExtensions
	{
		// Token: 0x060070CE RID: 28878 RVA: 0x0010CE7C File Offset: 0x0010B07C
		public static string ToEnumString(this EPlayerMovementMode value)
		{
			string result;
			switch (value)
			{
			case EPlayerMovementMode.Ski:
				result = "Ski";
				break;
			case EPlayerMovementMode.WingSuitFly:
				result = "WingSuitFly";
				break;
			case EPlayerMovementMode.Rail:
				result = "Rail";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x0010CEC4 File Offset: 0x0010B0C4
		public static EPlayerMovementMode FromString(string name)
		{
			EPlayerMovementMode result;
			if (!EPlayerMovementModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerMovementMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x0010CEF0 File Offset: 0x0010B0F0
		public static bool TryFromString(string name, out EPlayerMovementMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlayerMovementMode.Ski;
				return false;
			}
			if (name == "Ski")
			{
				value = EPlayerMovementMode.Ski;
				return true;
			}
			if (name == "WingSuitFly")
			{
				value = EPlayerMovementMode.WingSuitFly;
				return true;
			}
			if (!(name == "Rail"))
			{
				value = EPlayerMovementMode.Ski;
				return false;
			}
			value = EPlayerMovementMode.Rail;
			return true;
		}

		// Token: 0x060070D1 RID: 28881 RVA: 0x0010CF46 File Offset: 0x0010B146
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Ski",
				"WingSuitFly",
				"Rail"
			};
		}

		// Token: 0x060070D2 RID: 28882 RVA: 0x0010CF66 File Offset: 0x0010B166
		public static EPlayerMovementMode[] GetValues()
		{
			return new EPlayerMovementMode[]
			{
				EPlayerMovementMode.Ski,
				EPlayerMovementMode.WingSuitFly,
				EPlayerMovementMode.Rail
			};
		}

		// Token: 0x060070D3 RID: 28883 RVA: 0x0010CF76 File Offset: 0x0010B176
		public static string[] GetNames()
		{
			return new string[]
			{
				"Ski",
				"WingSuitFly",
				"Rail"
			};
		}
	}
}
