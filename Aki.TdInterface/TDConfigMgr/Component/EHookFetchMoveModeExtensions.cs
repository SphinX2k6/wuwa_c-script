using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A17 RID: 2583
	public static class EHookFetchMoveModeExtensions
	{
		// Token: 0x0600397A RID: 14714 RVA: 0x000948F4 File Offset: 0x00092AF4
		public static string ToEnumString(this EHookFetchMoveMode value)
		{
			string result;
			if (value == EHookFetchMoveMode.Uniform)
			{
				result = "Uniform";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x0009491C File Offset: 0x00092B1C
		public static EHookFetchMoveMode FromString(string name)
		{
			EHookFetchMoveMode result;
			if (!EHookFetchMoveModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHookFetchMoveMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x00094945 File Offset: 0x00092B45
		public static bool TryFromString(string name, out EHookFetchMoveMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EHookFetchMoveMode.Uniform;
				return false;
			}
			if (name == "Uniform")
			{
				value = EHookFetchMoveMode.Uniform;
				return true;
			}
			value = EHookFetchMoveMode.Uniform;
			return false;
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x0009496A File Offset: 0x00092B6A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Uniform"
			};
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x0009497A File Offset: 0x00092B7A
		public static EHookFetchMoveMode[] GetValues()
		{
			return new EHookFetchMoveMode[1];
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x00094982 File Offset: 0x00092B82
		public static string[] GetNames()
		{
			return new string[]
			{
				"Uniform"
			};
		}
	}
}
