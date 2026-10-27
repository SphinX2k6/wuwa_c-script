using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200238D RID: 9101
	public static class EMoraleUiTypeExtensions
	{
		// Token: 0x0600C679 RID: 50809 RVA: 0x001D1234 File Offset: 0x001CF434
		public static string ToEnumString(this EMoraleUiType value)
		{
			string result;
			if (value != EMoraleUiType.MoraleUi24)
			{
				if (value != EMoraleUiType.MoraleUi32)
				{
					result = value.ToString();
				}
				else
				{
					result = "MoraleUi3_2";
				}
			}
			else
			{
				result = "MoraleUi2_4";
			}
			return result;
		}

		// Token: 0x0600C67A RID: 50810 RVA: 0x001D126C File Offset: 0x001CF46C
		public static EMoraleUiType FromString(string name)
		{
			EMoraleUiType result;
			if (!EMoraleUiTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMoraleUiType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C67B RID: 50811 RVA: 0x001D1295 File Offset: 0x001CF495
		public static bool TryFromString(string name, out EMoraleUiType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMoraleUiType.MoraleUi24;
				return false;
			}
			if (name == "MoraleUi2_4")
			{
				value = EMoraleUiType.MoraleUi24;
				return true;
			}
			if (!(name == "MoraleUi3_2"))
			{
				value = EMoraleUiType.MoraleUi24;
				return false;
			}
			value = EMoraleUiType.MoraleUi32;
			return true;
		}

		// Token: 0x0600C67C RID: 50812 RVA: 0x001D12CE File Offset: 0x001CF4CE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MoraleUi2_4",
				"MoraleUi3_2"
			};
		}

		// Token: 0x0600C67D RID: 50813 RVA: 0x001D12E6 File Offset: 0x001CF4E6
		public static EMoraleUiType[] GetValues()
		{
			return new EMoraleUiType[]
			{
				EMoraleUiType.MoraleUi24,
				EMoraleUiType.MoraleUi32
			};
		}

		// Token: 0x0600C67E RID: 50814 RVA: 0x001D12F2 File Offset: 0x001CF4F2
		public static string[] GetNames()
		{
			return new string[]
			{
				"MoraleUi24",
				"MoraleUi32"
			};
		}
	}
}
