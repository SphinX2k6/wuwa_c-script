using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A9B RID: 2715
	public static class EPointChooseTypeExtensions
	{
		// Token: 0x06003BCC RID: 15308 RVA: 0x00099CC4 File Offset: 0x00097EC4
		public static string ToEnumString(this EPointChooseType value)
		{
			string result;
			if (value == EPointChooseType.SpawnMonsterPoint)
			{
				result = "SpawnMonsterPoint";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x00099CEC File Offset: 0x00097EEC
		public static EPointChooseType FromString(string name)
		{
			EPointChooseType result;
			if (!EPointChooseTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPointChooseType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x00099D15 File Offset: 0x00097F15
		public static bool TryFromString(string name, out EPointChooseType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPointChooseType.SpawnMonsterPoint;
				return false;
			}
			if (name == "SpawnMonsterPoint")
			{
				value = EPointChooseType.SpawnMonsterPoint;
				return true;
			}
			value = EPointChooseType.SpawnMonsterPoint;
			return false;
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x00099D3A File Offset: 0x00097F3A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SpawnMonsterPoint"
			};
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x00099D4A File Offset: 0x00097F4A
		public static EPointChooseType[] GetValues()
		{
			return new EPointChooseType[1];
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x00099D52 File Offset: 0x00097F52
		public static string[] GetNames()
		{
			return new string[]
			{
				"SpawnMonsterPoint"
			};
		}
	}
}
