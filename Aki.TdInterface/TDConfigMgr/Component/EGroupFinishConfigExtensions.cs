using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200095E RID: 2398
	public static class EGroupFinishConfigExtensions
	{
		// Token: 0x060035D8 RID: 13784 RVA: 0x0008C42C File Offset: 0x0008A62C
		public static string ToEnumString(this EGroupFinishConfig value)
		{
			string result;
			if (value != EGroupFinishConfig.Silence)
			{
				if (value != EGroupFinishConfig.Destroy)
				{
					result = value.ToString();
				}
				else
				{
					result = "Destroy";
				}
			}
			else
			{
				result = "Silence";
			}
			return result;
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x0008C464 File Offset: 0x0008A664
		public static EGroupFinishConfig FromString(string name)
		{
			EGroupFinishConfig result;
			if (!EGroupFinishConfigExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGroupFinishConfig 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x0008C48D File Offset: 0x0008A68D
		public static bool TryFromString(string name, out EGroupFinishConfig value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGroupFinishConfig.Silence;
				return false;
			}
			if (name == "Silence")
			{
				value = EGroupFinishConfig.Silence;
				return true;
			}
			if (!(name == "Destroy"))
			{
				value = EGroupFinishConfig.Silence;
				return false;
			}
			value = EGroupFinishConfig.Destroy;
			return true;
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x0008C4C6 File Offset: 0x0008A6C6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Silence",
				"Destroy"
			};
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x0008C4DE File Offset: 0x0008A6DE
		public static EGroupFinishConfig[] GetValues()
		{
			return new EGroupFinishConfig[]
			{
				EGroupFinishConfig.Silence,
				EGroupFinishConfig.Destroy
			};
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x0008C4EA File Offset: 0x0008A6EA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Silence",
				"Destroy"
			};
		}
	}
}
