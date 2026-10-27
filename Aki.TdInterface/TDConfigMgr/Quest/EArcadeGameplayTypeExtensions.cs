using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001222 RID: 4642
	public static class EArcadeGameplayTypeExtensions
	{
		// Token: 0x06006940 RID: 26944 RVA: 0x000FAD64 File Offset: 0x000F8F64
		public static string ToEnumString(this EArcadeGameplayType value)
		{
			string result;
			if (value != EArcadeGameplayType.DropCatch)
			{
				if (value != EArcadeGameplayType.TetrisBoardGame)
				{
					result = value.ToString();
				}
				else
				{
					result = "TetrisBoardGame";
				}
			}
			else
			{
				result = "DropCatch";
			}
			return result;
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x000FAD9C File Offset: 0x000F8F9C
		public static EArcadeGameplayType FromString(string name)
		{
			EArcadeGameplayType result;
			if (!EArcadeGameplayTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EArcadeGameplayType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x000FADC5 File Offset: 0x000F8FC5
		public static bool TryFromString(string name, out EArcadeGameplayType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EArcadeGameplayType.DropCatch;
				return false;
			}
			if (name == "DropCatch")
			{
				value = EArcadeGameplayType.DropCatch;
				return true;
			}
			if (!(name == "TetrisBoardGame"))
			{
				value = EArcadeGameplayType.DropCatch;
				return false;
			}
			value = EArcadeGameplayType.TetrisBoardGame;
			return true;
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x000FADFE File Offset: 0x000F8FFE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DropCatch",
				"TetrisBoardGame"
			};
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x000FAE16 File Offset: 0x000F9016
		public static EArcadeGameplayType[] GetValues()
		{
			return new EArcadeGameplayType[]
			{
				EArcadeGameplayType.DropCatch,
				EArcadeGameplayType.TetrisBoardGame
			};
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x000FAE22 File Offset: 0x000F9022
		public static string[] GetNames()
		{
			return new string[]
			{
				"DropCatch",
				"TetrisBoardGame"
			};
		}
	}
}
