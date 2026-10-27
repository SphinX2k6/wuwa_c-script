using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C0 RID: 2496
	public static class EPasserbyNpcSpawnTypeExtensions
	{
		// Token: 0x06003791 RID: 14225 RVA: 0x00090874 File Offset: 0x0008EA74
		public static string ToEnumString(this EPasserbyNpcSpawnType value)
		{
			string result;
			if (value == EPasserbyNpcSpawnType.FixInterval)
			{
				result = "FixInterval";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x0009089C File Offset: 0x0008EA9C
		public static EPasserbyNpcSpawnType FromString(string name)
		{
			EPasserbyNpcSpawnType result;
			if (!EPasserbyNpcSpawnTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPasserbyNpcSpawnType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x000908C5 File Offset: 0x0008EAC5
		public static bool TryFromString(string name, out EPasserbyNpcSpawnType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPasserbyNpcSpawnType.FixInterval;
				return false;
			}
			if (name == "FixInterval")
			{
				value = EPasserbyNpcSpawnType.FixInterval;
				return true;
			}
			value = EPasserbyNpcSpawnType.FixInterval;
			return false;
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x000908EA File Offset: 0x0008EAEA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FixInterval"
			};
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x000908FA File Offset: 0x0008EAFA
		public static EPasserbyNpcSpawnType[] GetValues()
		{
			return new EPasserbyNpcSpawnType[1];
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x00090902 File Offset: 0x0008EB02
		public static string[] GetNames()
		{
			return new string[]
			{
				"FixInterval"
			};
		}
	}
}
