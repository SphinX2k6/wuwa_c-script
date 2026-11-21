using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200267C RID: 9852
	public static class ERandomPrefabTypeExtensions
	{
		// Token: 0x0600D488 RID: 54408 RVA: 0x001EE09C File Offset: 0x001EC29C
		public static string ToEnumString(this ERandomPrefabType value)
		{
			string result;
			if (value == ERandomPrefabType.Rogue)
			{
				result = "Rogue";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D489 RID: 54409 RVA: 0x001EE0C4 File Offset: 0x001EC2C4
		public static ERandomPrefabType FromString(string name)
		{
			ERandomPrefabType result;
			if (!ERandomPrefabTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERandomPrefabType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D48A RID: 54410 RVA: 0x001EE0ED File Offset: 0x001EC2ED
		public static bool TryFromString(string name, out ERandomPrefabType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERandomPrefabType.Rogue;
				return false;
			}
			if (name == "Rogue")
			{
				value = ERandomPrefabType.Rogue;
				return true;
			}
			value = ERandomPrefabType.Rogue;
			return false;
		}

		// Token: 0x0600D48B RID: 54411 RVA: 0x001EE112 File Offset: 0x001EC312
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Rogue"
			};
		}

		// Token: 0x0600D48C RID: 54412 RVA: 0x001EE122 File Offset: 0x001EC322
		public static ERandomPrefabType[] GetValues()
		{
			return new ERandomPrefabType[1];
		}

		// Token: 0x0600D48D RID: 54413 RVA: 0x001EE12A File Offset: 0x001EC32A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Rogue"
			};
		}
	}
}
