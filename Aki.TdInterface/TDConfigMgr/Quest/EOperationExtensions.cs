using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200125C RID: 4700
	public static class EOperationExtensions
	{
		// Token: 0x06006A45 RID: 27205 RVA: 0x000FEC10 File Offset: 0x000FCE10
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

		// Token: 0x06006A46 RID: 27206 RVA: 0x000FEC48 File Offset: 0x000FCE48
		public static EOperation FromString(string name)
		{
			EOperation result;
			if (!EOperationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EOperation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x000FEC71 File Offset: 0x000FCE71
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

		// Token: 0x06006A48 RID: 27208 RVA: 0x000FECAA File Offset: 0x000FCEAA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DisableHLOD",
				"AssignLoadingBackground"
			};
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x000FECC2 File Offset: 0x000FCEC2
		public static EOperation[] GetValues()
		{
			return new EOperation[]
			{
				EOperation.DisableHLOD,
				EOperation.AssignLoadingBackground
			};
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x000FECCE File Offset: 0x000FCECE
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
