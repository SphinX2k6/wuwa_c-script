using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001362 RID: 4962
	public static class EAttributeToTargetExtensions
	{
		// Token: 0x06006F93 RID: 28563 RVA: 0x00108860 File Offset: 0x00106A60
		public static string ToEnumString(this EAttributeToTarget value)
		{
			string result;
			if (value == EAttributeToTarget.Health)
			{
				result = "Health";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06006F94 RID: 28564 RVA: 0x00108888 File Offset: 0x00106A88
		public static EAttributeToTarget FromString(string name)
		{
			EAttributeToTarget result;
			if (!EAttributeToTargetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAttributeToTarget 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006F95 RID: 28565 RVA: 0x001088B1 File Offset: 0x00106AB1
		public static bool TryFromString(string name, out EAttributeToTarget value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAttributeToTarget.Health;
				return false;
			}
			if (name == "Health")
			{
				value = EAttributeToTarget.Health;
				return true;
			}
			value = EAttributeToTarget.Health;
			return false;
		}

		// Token: 0x06006F96 RID: 28566 RVA: 0x001088D6 File Offset: 0x00106AD6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Health"
			};
		}

		// Token: 0x06006F97 RID: 28567 RVA: 0x001088E6 File Offset: 0x00106AE6
		public static EAttributeToTarget[] GetValues()
		{
			return new EAttributeToTarget[1];
		}

		// Token: 0x06006F98 RID: 28568 RVA: 0x001088EE File Offset: 0x00106AEE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Health"
			};
		}
	}
}
