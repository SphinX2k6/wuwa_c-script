using System;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x020001A6 RID: 422
	public static class EPsActivityEndActivityOutcomeExtensions
	{
		// Token: 0x06000BB9 RID: 3001 RVA: 0x0004B524 File Offset: 0x00049724
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

		// Token: 0x06000BBA RID: 3002 RVA: 0x0004B56C File Offset: 0x0004976C
		public static EPsActivityEndActivityOutcome FromString(string name)
		{
			EPsActivityEndActivityOutcome result;
			if (!EPsActivityEndActivityOutcomeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPsActivityEndActivityOutcome 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0004B598 File Offset: 0x00049798
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

		// Token: 0x06000BBC RID: 3004 RVA: 0x0004B5EE File Offset: 0x000497EE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"completed",
				"failed",
				"abandoned"
			};
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0004B60E File Offset: 0x0004980E
		public static EPsActivityEndActivityOutcome[] GetValues()
		{
			return new EPsActivityEndActivityOutcome[]
			{
				EPsActivityEndActivityOutcome.Completed,
				EPsActivityEndActivityOutcome.Failed,
				EPsActivityEndActivityOutcome.Abandoned
			};
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0004B61E File Offset: 0x0004981E
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
