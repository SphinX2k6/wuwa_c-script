using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200135E RID: 4958
	public static class EArcadeGameplayTypeExtensions
	{
		// Token: 0x06006F81 RID: 28545 RVA: 0x00108670 File Offset: 0x00106870
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

		// Token: 0x06006F82 RID: 28546 RVA: 0x001086A8 File Offset: 0x001068A8
		public static EArcadeGameplayType FromString(string name)
		{
			EArcadeGameplayType result;
			if (!EArcadeGameplayTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EArcadeGameplayType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006F83 RID: 28547 RVA: 0x001086D1 File Offset: 0x001068D1
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

		// Token: 0x06006F84 RID: 28548 RVA: 0x0010870A File Offset: 0x0010690A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DropCatch",
				"TetrisBoardGame"
			};
		}

		// Token: 0x06006F85 RID: 28549 RVA: 0x00108722 File Offset: 0x00106922
		public static EArcadeGameplayType[] GetValues()
		{
			return new EArcadeGameplayType[]
			{
				EArcadeGameplayType.DropCatch,
				EArcadeGameplayType.TetrisBoardGame
			};
		}

		// Token: 0x06006F86 RID: 28550 RVA: 0x0010872E File Offset: 0x0010692E
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
