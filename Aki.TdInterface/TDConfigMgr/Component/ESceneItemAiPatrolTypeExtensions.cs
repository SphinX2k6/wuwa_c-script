using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AC3 RID: 2755
	public static class ESceneItemAiPatrolTypeExtensions
	{
		// Token: 0x06003C80 RID: 15488 RVA: 0x0009B2B8 File Offset: 0x000994B8
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

		// Token: 0x06003C81 RID: 15489 RVA: 0x0009B2E0 File Offset: 0x000994E0
		public static ESceneItemAiPatrolType FromString(string name)
		{
			ESceneItemAiPatrolType result;
			if (!ESceneItemAiPatrolTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneItemAiPatrolType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x0009B309 File Offset: 0x00099509
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

		// Token: 0x06003C83 RID: 15491 RVA: 0x0009B32E File Offset: 0x0009952E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ByGameTime"
			};
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x0009B33E File Offset: 0x0009953E
		public static ESceneItemAiPatrolType[] GetValues()
		{
			return new ESceneItemAiPatrolType[1];
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x0009B346 File Offset: 0x00099546
		public static string[] GetNames()
		{
			return new string[]
			{
				"ByGameTime"
			};
		}
	}
}
