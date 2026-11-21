using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001384 RID: 4996
	public static class EFlipperSystemVarExtensions
	{
		// Token: 0x0600702C RID: 28716 RVA: 0x0010B554 File Offset: 0x00109754
		public static string ToEnumString(this EFlipperSystemVar value)
		{
			string result;
			if (value == EFlipperSystemVar.LifeRemain)
			{
				result = "LifeRemain";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600702D RID: 28717 RVA: 0x0010B57C File Offset: 0x0010977C
		public static EFlipperSystemVar FromString(string name)
		{
			EFlipperSystemVar result;
			if (!EFlipperSystemVarExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFlipperSystemVar 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600702E RID: 28718 RVA: 0x0010B5A5 File Offset: 0x001097A5
		public static bool TryFromString(string name, out EFlipperSystemVar value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFlipperSystemVar.LifeRemain;
				return false;
			}
			if (name == "LifeRemain")
			{
				value = EFlipperSystemVar.LifeRemain;
				return true;
			}
			value = EFlipperSystemVar.LifeRemain;
			return false;
		}

		// Token: 0x0600702F RID: 28719 RVA: 0x0010B5CA File Offset: 0x001097CA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LifeRemain"
			};
		}

		// Token: 0x06007030 RID: 28720 RVA: 0x0010B5DA File Offset: 0x001097DA
		public static EFlipperSystemVar[] GetValues()
		{
			return new EFlipperSystemVar[1];
		}

		// Token: 0x06007031 RID: 28721 RVA: 0x0010B5E2 File Offset: 0x001097E2
		public static string[] GetNames()
		{
			return new string[]
			{
				"LifeRemain"
			};
		}
	}
}
