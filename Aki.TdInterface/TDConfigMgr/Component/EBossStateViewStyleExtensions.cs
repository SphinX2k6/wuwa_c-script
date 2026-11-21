using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009AB RID: 2475
	public static class EBossStateViewStyleExtensions
	{
		// Token: 0x06003794 RID: 14228 RVA: 0x0008CEE0 File Offset: 0x0008B0E0
		public static string ToEnumString(this EBossStateViewStyle value)
		{
			string result;
			if (value == EBossStateViewStyle.DoubleView)
			{
				result = "DoubleView";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x0008CF08 File Offset: 0x0008B108
		public static EBossStateViewStyle FromString(string name)
		{
			EBossStateViewStyle result;
			if (!EBossStateViewStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBossStateViewStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x0008CF31 File Offset: 0x0008B131
		public static bool TryFromString(string name, out EBossStateViewStyle value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBossStateViewStyle.DoubleView;
				return false;
			}
			if (name == "DoubleView")
			{
				value = EBossStateViewStyle.DoubleView;
				return true;
			}
			value = EBossStateViewStyle.DoubleView;
			return false;
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x0008CF56 File Offset: 0x0008B156
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DoubleView"
			};
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x0008CF66 File Offset: 0x0008B166
		public static EBossStateViewStyle[] GetValues()
		{
			return new EBossStateViewStyle[1];
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x0008CF6E File Offset: 0x0008B16E
		public static string[] GetNames()
		{
			return new string[]
			{
				"DoubleView"
			};
		}
	}
}
