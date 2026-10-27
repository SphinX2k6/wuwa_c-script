using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D6 RID: 2518
	public static class EPointChooseTypeExtensions
	{
		// Token: 0x060037F4 RID: 14324 RVA: 0x00091404 File Offset: 0x0008F604
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

		// Token: 0x060037F5 RID: 14325 RVA: 0x0009142C File Offset: 0x0008F62C
		public static EPointChooseType FromString(string name)
		{
			EPointChooseType result;
			if (!EPointChooseTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPointChooseType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x00091455 File Offset: 0x0008F655
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

		// Token: 0x060037F7 RID: 14327 RVA: 0x0009147A File Offset: 0x0008F67A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SpawnMonsterPoint"
			};
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x0009148A File Offset: 0x0008F68A
		public static EPointChooseType[] GetValues()
		{
			return new EPointChooseType[1];
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x00091492 File Offset: 0x0008F692
		public static string[] GetNames()
		{
			return new string[]
			{
				"SpawnMonsterPoint"
			};
		}
	}
}
