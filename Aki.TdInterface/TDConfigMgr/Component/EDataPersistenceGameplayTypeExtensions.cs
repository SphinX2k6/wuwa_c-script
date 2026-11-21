using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009CB RID: 2507
	public static class EDataPersistenceGameplayTypeExtensions
	{
		// Token: 0x06003824 RID: 14372 RVA: 0x00091A30 File Offset: 0x0008FC30
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

		// Token: 0x06003825 RID: 14373 RVA: 0x00091A58 File Offset: 0x0008FC58
		public static EDataPersistenceGameplayType FromString(string name)
		{
			EDataPersistenceGameplayType result;
			if (!EDataPersistenceGameplayTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDataPersistenceGameplayType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x00091A81 File Offset: 0x0008FC81
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

		// Token: 0x06003827 RID: 14375 RVA: 0x00091AA6 File Offset: 0x0008FCA6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TetrisBoardGame"
			};
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x00091AB6 File Offset: 0x0008FCB6
		public static EDataPersistenceGameplayType[] GetValues()
		{
			return new EDataPersistenceGameplayType[1];
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x00091ABE File Offset: 0x0008FCBE
		public static string[] GetNames()
		{
			return new string[]
			{
				"TetrisBoardGame"
			};
		}
	}
}
