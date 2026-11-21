using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013AC RID: 5036
	public static class EProgressBarLeftTypeExtensions
	{
		// Token: 0x060070E0 RID: 28896 RVA: 0x0010D320 File Offset: 0x0010B520
		public static string ToEnumString(this EProgressBarLeftType value)
		{
			string result;
			if (value != EProgressBarLeftType.UseCount)
			{
				if (value != EProgressBarLeftType.UseVar)
				{
					result = value.ToString();
				}
				else
				{
					result = "UseVar";
				}
			}
			else
			{
				result = "UseCount";
			}
			return result;
		}

		// Token: 0x060070E1 RID: 28897 RVA: 0x0010D358 File Offset: 0x0010B558
		public static EProgressBarLeftType FromString(string name)
		{
			EProgressBarLeftType result;
			if (!EProgressBarLeftTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EProgressBarLeftType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060070E2 RID: 28898 RVA: 0x0010D381 File Offset: 0x0010B581
		public static bool TryFromString(string name, out EProgressBarLeftType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EProgressBarLeftType.UseCount;
				return false;
			}
			if (name == "UseCount")
			{
				value = EProgressBarLeftType.UseCount;
				return true;
			}
			if (!(name == "UseVar"))
			{
				value = EProgressBarLeftType.UseCount;
				return false;
			}
			value = EProgressBarLeftType.UseVar;
			return true;
		}

		// Token: 0x060070E3 RID: 28899 RVA: 0x0010D3BA File Offset: 0x0010B5BA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UseCount",
				"UseVar"
			};
		}

		// Token: 0x060070E4 RID: 28900 RVA: 0x0010D3D2 File Offset: 0x0010B5D2
		public static EProgressBarLeftType[] GetValues()
		{
			return new EProgressBarLeftType[]
			{
				EProgressBarLeftType.UseCount,
				EProgressBarLeftType.UseVar
			};
		}

		// Token: 0x060070E5 RID: 28901 RVA: 0x0010D3DE File Offset: 0x0010B5DE
		public static string[] GetNames()
		{
			return new string[]
			{
				"UseCount",
				"UseVar"
			};
		}
	}
}
