using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001268 RID: 4712
	public static class EPlayerMovementModeExtensions
	{
		// Token: 0x06006A7B RID: 27259 RVA: 0x000FF250 File Offset: 0x000FD450
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

		// Token: 0x06006A7C RID: 27260 RVA: 0x000FF298 File Offset: 0x000FD498
		public static EPlayerMovementMode FromString(string name)
		{
			EPlayerMovementMode result;
			if (!EPlayerMovementModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerMovementMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A7D RID: 27261 RVA: 0x000FF2C4 File Offset: 0x000FD4C4
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

		// Token: 0x06006A7E RID: 27262 RVA: 0x000FF31A File Offset: 0x000FD51A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Ski",
				"WingSuitFly",
				"Rail"
			};
		}

		// Token: 0x06006A7F RID: 27263 RVA: 0x000FF33A File Offset: 0x000FD53A
		public static EPlayerMovementMode[] GetValues()
		{
			return new EPlayerMovementMode[]
			{
				EPlayerMovementMode.Ski,
				EPlayerMovementMode.WingSuitFly,
				EPlayerMovementMode.Rail
			};
		}

		// Token: 0x06006A80 RID: 27264 RVA: 0x000FF34A File Offset: 0x000FD54A
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
