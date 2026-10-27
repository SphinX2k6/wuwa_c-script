using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200091E RID: 2334
	public static class EDataPersistenceGameplayTypeExtensions
	{
		// Token: 0x060034B8 RID: 13496 RVA: 0x00089EB0 File Offset: 0x000880B0
		public static string ToEnumString(this EDataPersistenceGameplayType value)
		{
			string result;
			if (value == EDataPersistenceGameplayType.TetrisBoardGame)
			{
				result = "TetrisBoardGame";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00089ED8 File Offset: 0x000880D8
		public static EDataPersistenceGameplayType FromString(string name)
		{
			EDataPersistenceGameplayType result;
			if (!EDataPersistenceGameplayTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDataPersistenceGameplayType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00089F01 File Offset: 0x00088101
		public static bool TryFromString(string name, out EDataPersistenceGameplayType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDataPersistenceGameplayType.TetrisBoardGame;
				return false;
			}
			if (name == "TetrisBoardGame")
			{
				value = EDataPersistenceGameplayType.TetrisBoardGame;
				return true;
			}
			value = EDataPersistenceGameplayType.TetrisBoardGame;
			return false;
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x00089F26 File Offset: 0x00088126
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TetrisBoardGame"
			};
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x00089F36 File Offset: 0x00088136
		public static EDataPersistenceGameplayType[] GetValues()
		{
			return new EDataPersistenceGameplayType[1];
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x00089F3E File Offset: 0x0008813E
		public static string[] GetNames()
		{
			return new string[]
			{
				"TetrisBoardGame"
			};
		}
	}
}
