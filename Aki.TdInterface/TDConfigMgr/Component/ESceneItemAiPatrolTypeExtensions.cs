using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009FE RID: 2558
	public static class ESceneItemAiPatrolTypeExtensions
	{
		// Token: 0x060038A8 RID: 14504 RVA: 0x000929C8 File Offset: 0x00090BC8
		public static string ToEnumString(this ESceneItemAiPatrolType value)
		{
			string result;
			if (value == ESceneItemAiPatrolType.ByGameTime)
			{
				result = "ByGameTime";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x000929F0 File Offset: 0x00090BF0
		public static ESceneItemAiPatrolType FromString(string name)
		{
			ESceneItemAiPatrolType result;
			if (!ESceneItemAiPatrolTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneItemAiPatrolType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x00092A19 File Offset: 0x00090C19
		public static bool TryFromString(string name, out ESceneItemAiPatrolType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESceneItemAiPatrolType.ByGameTime;
				return false;
			}
			if (name == "ByGameTime")
			{
				value = ESceneItemAiPatrolType.ByGameTime;
				return true;
			}
			value = ESceneItemAiPatrolType.ByGameTime;
			return false;
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x00092A3E File Offset: 0x00090C3E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ByGameTime"
			};
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x00092A4E File Offset: 0x00090C4E
		public static ESceneItemAiPatrolType[] GetValues()
		{
			return new ESceneItemAiPatrolType[1];
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x00092A56 File Offset: 0x00090C56
		public static string[] GetNames()
		{
			return new string[]
			{
				"ByGameTime"
			};
		}
	}
}
