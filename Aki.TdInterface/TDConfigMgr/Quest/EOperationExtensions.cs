using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200139C RID: 5020
	public static class EOperationExtensions
	{
		// Token: 0x06007098 RID: 28824 RVA: 0x0010C83C File Offset: 0x0010AA3C
		public static string ToEnumString(this EOperation value)
		{
			string result;
			if (value != EOperation.DisableHLOD)
			{
				if (value != EOperation.AssignLoadingBackground)
				{
					result = value.ToString();
				}
				else
				{
					result = "AssignLoadingBackground";
				}
			}
			else
			{
				result = "DisableHLOD";
			}
			return result;
		}

		// Token: 0x06007099 RID: 28825 RVA: 0x0010C874 File Offset: 0x0010AA74
		public static EOperation FromString(string name)
		{
			EOperation result;
			if (!EOperationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EOperation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600709A RID: 28826 RVA: 0x0010C89D File Offset: 0x0010AA9D
		public static bool TryFromString(string name, out EOperation value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EOperation.DisableHLOD;
				return false;
			}
			if (name == "DisableHLOD")
			{
				value = EOperation.DisableHLOD;
				return true;
			}
			if (!(name == "AssignLoadingBackground"))
			{
				value = EOperation.DisableHLOD;
				return false;
			}
			value = EOperation.AssignLoadingBackground;
			return true;
		}

		// Token: 0x0600709B RID: 28827 RVA: 0x0010C8D6 File Offset: 0x0010AAD6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DisableHLOD",
				"AssignLoadingBackground"
			};
		}

		// Token: 0x0600709C RID: 28828 RVA: 0x0010C8EE File Offset: 0x0010AAEE
		public static EOperation[] GetValues()
		{
			return new EOperation[]
			{
				EOperation.DisableHLOD,
				EOperation.AssignLoadingBackground
			};
		}

		// Token: 0x0600709D RID: 28829 RVA: 0x0010C8FA File Offset: 0x0010AAFA
		public static string[] GetNames()
		{
			return new string[]
			{
				"DisableHLOD",
				"AssignLoadingBackground"
			};
		}
	}
}
