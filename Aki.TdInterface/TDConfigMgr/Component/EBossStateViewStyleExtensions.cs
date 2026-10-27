using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000902 RID: 2306
	public static class EBossStateViewStyleExtensions
	{
		// Token: 0x0600343A RID: 13370 RVA: 0x00085670 File Offset: 0x00083870
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

		// Token: 0x0600343B RID: 13371 RVA: 0x00085698 File Offset: 0x00083898
		public static EBossStateViewStyle FromString(string name)
		{
			EBossStateViewStyle result;
			if (!EBossStateViewStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBossStateViewStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x000856C1 File Offset: 0x000838C1
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

		// Token: 0x0600343D RID: 13373 RVA: 0x000856E6 File Offset: 0x000838E6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DoubleView"
			};
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x000856F6 File Offset: 0x000838F6
		public static EBossStateViewStyle[] GetValues()
		{
			return new EBossStateViewStyle[1];
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x000856FE File Offset: 0x000838FE
		public static string[] GetNames()
		{
			return new string[]
			{
				"DoubleView"
			};
		}
	}
}
