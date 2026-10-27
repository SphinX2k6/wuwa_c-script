using System;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x020001A2 RID: 418
	public static class EPsActivityEndActivityOutcomeExtensions
	{
		// Token: 0x06000B82 RID: 2946 RVA: 0x00048D34 File Offset: 0x00046F34
		public static string ToEnumString(this EPsActivityEndActivityOutcome value)
		{
			string result;
			switch (value)
			{
			case EPsActivityEndActivityOutcome.Completed:
				result = "completed";
				break;
			case EPsActivityEndActivityOutcome.Failed:
				result = "failed";
				break;
			case EPsActivityEndActivityOutcome.Abandoned:
				result = "abandoned";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00048D7C File Offset: 0x00046F7C
		public static EPsActivityEndActivityOutcome FromString(string name)
		{
			EPsActivityEndActivityOutcome result;
			if (!EPsActivityEndActivityOutcomeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPsActivityEndActivityOutcome 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00048DA8 File Offset: 0x00046FA8
		public static bool TryFromString(string name, out EPsActivityEndActivityOutcome value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPsActivityEndActivityOutcome.Completed;
				return false;
			}
			if (name == "completed")
			{
				value = EPsActivityEndActivityOutcome.Completed;
				return true;
			}
			if (name == "failed")
			{
				value = EPsActivityEndActivityOutcome.Failed;
				return true;
			}
			if (!(name == "abandoned"))
			{
				value = EPsActivityEndActivityOutcome.Completed;
				return false;
			}
			value = EPsActivityEndActivityOutcome.Abandoned;
			return true;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00048DFE File Offset: 0x00046FFE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"completed",
				"failed",
				"abandoned"
			};
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00048E1E File Offset: 0x0004701E
		public static EPsActivityEndActivityOutcome[] GetValues()
		{
			return new EPsActivityEndActivityOutcome[]
			{
				EPsActivityEndActivityOutcome.Completed,
				EPsActivityEndActivityOutcome.Failed,
				EPsActivityEndActivityOutcome.Abandoned
			};
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00048E2E File Offset: 0x0004702E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Completed",
				"Failed",
				"Abandoned"
			};
		}
	}
}
