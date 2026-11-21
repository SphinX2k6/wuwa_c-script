using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A11 RID: 2577
	public static class EGroupFinishConfigExtensions
	{
		// Token: 0x0600395F RID: 14687 RVA: 0x00094380 File Offset: 0x00092580
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

		// Token: 0x06003960 RID: 14688 RVA: 0x000943B8 File Offset: 0x000925B8
		public static EGroupFinishConfig FromString(string name)
		{
			EGroupFinishConfig result;
			if (!EGroupFinishConfigExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGroupFinishConfig 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x000943E1 File Offset: 0x000925E1
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

		// Token: 0x06003962 RID: 14690 RVA: 0x0009441A File Offset: 0x0009261A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Silence",
				"Destroy"
			};
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x00094432 File Offset: 0x00092632
		public static EGroupFinishConfig[] GetValues()
		{
			return new EGroupFinishConfig[]
			{
				EGroupFinishConfig.Silence,
				EGroupFinishConfig.Destroy
			};
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x0009443E File Offset: 0x0009263E
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
