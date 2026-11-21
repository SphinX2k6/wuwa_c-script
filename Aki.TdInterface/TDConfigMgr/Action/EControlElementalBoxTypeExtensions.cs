using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200255C RID: 9564
	public static class EControlElementalBoxTypeExtensions
	{
		// Token: 0x0600CF78 RID: 53112 RVA: 0x001E12D8 File Offset: 0x001DF4D8
		public static string ToEnumString(this EControlElementalBoxType value)
		{
			string result;
			if (value != EControlElementalBoxType.Capture)
			{
				if (value != EControlElementalBoxType.Return)
				{
					result = value.ToString();
				}
				else
				{
					result = "Return";
				}
			}
			else
			{
				result = "Capture";
			}
			return result;
		}

		// Token: 0x0600CF79 RID: 53113 RVA: 0x001E1310 File Offset: 0x001DF510
		public static EControlElementalBoxType FromString(string name)
		{
			EControlElementalBoxType result;
			if (!EControlElementalBoxTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EControlElementalBoxType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF7A RID: 53114 RVA: 0x001E1339 File Offset: 0x001DF539
		public static bool TryFromString(string name, out EControlElementalBoxType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EControlElementalBoxType.Capture;
				return false;
			}
			if (name == "Capture")
			{
				value = EControlElementalBoxType.Capture;
				return true;
			}
			if (!(name == "Return"))
			{
				value = EControlElementalBoxType.Capture;
				return false;
			}
			value = EControlElementalBoxType.Return;
			return true;
		}

		// Token: 0x0600CF7B RID: 53115 RVA: 0x001E1372 File Offset: 0x001DF572
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Capture",
				"Return"
			};
		}

		// Token: 0x0600CF7C RID: 53116 RVA: 0x001E138A File Offset: 0x001DF58A
		public static EControlElementalBoxType[] GetValues()
		{
			return new EControlElementalBoxType[]
			{
				EControlElementalBoxType.Capture,
				EControlElementalBoxType.Return
			};
		}

		// Token: 0x0600CF7D RID: 53117 RVA: 0x001E1396 File Offset: 0x001DF596
		public static string[] GetNames()
		{
			return new string[]
			{
				"Capture",
				"Return"
			};
		}
	}
}
