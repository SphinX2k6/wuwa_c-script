using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F1 RID: 9201
	public static class EResetPresentationTypeExtensions
	{
		// Token: 0x0600C83B RID: 51259 RVA: 0x001D4F6C File Offset: 0x001D316C
		public static string ToEnumString(this EResetPresentationType value)
		{
			string result;
			if (value == EResetPresentationType.Failure)
			{
				result = "Failure";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C83C RID: 51260 RVA: 0x001D4F94 File Offset: 0x001D3194
		public static EResetPresentationType FromString(string name)
		{
			EResetPresentationType result;
			if (!EResetPresentationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResetPresentationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C83D RID: 51261 RVA: 0x001D4FBD File Offset: 0x001D31BD
		public static bool TryFromString(string name, out EResetPresentationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EResetPresentationType.Failure;
				return false;
			}
			if (name == "Failure")
			{
				value = EResetPresentationType.Failure;
				return true;
			}
			value = EResetPresentationType.Failure;
			return false;
		}

		// Token: 0x0600C83E RID: 51262 RVA: 0x001D4FE2 File Offset: 0x001D31E2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Failure"
			};
		}

		// Token: 0x0600C83F RID: 51263 RVA: 0x001D4FF2 File Offset: 0x001D31F2
		public static EResetPresentationType[] GetValues()
		{
			return new EResetPresentationType[1];
		}

		// Token: 0x0600C840 RID: 51264 RVA: 0x001D4FFA File Offset: 0x001D31FA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Failure"
			};
		}
	}
}
