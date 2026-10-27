using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022ED RID: 8941
	public static class EControlElementalBoxTypeExtensions
	{
		// Token: 0x0600C3A9 RID: 50089 RVA: 0x001C948C File Offset: 0x001C768C
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

		// Token: 0x0600C3AA RID: 50090 RVA: 0x001C94C4 File Offset: 0x001C76C4
		public static EControlElementalBoxType FromString(string name)
		{
			EControlElementalBoxType result;
			if (!EControlElementalBoxTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EControlElementalBoxType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C3AB RID: 50091 RVA: 0x001C94ED File Offset: 0x001C76ED
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

		// Token: 0x0600C3AC RID: 50092 RVA: 0x001C9526 File Offset: 0x001C7726
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Capture",
				"Return"
			};
		}

		// Token: 0x0600C3AD RID: 50093 RVA: 0x001C953E File Offset: 0x001C773E
		public static EControlElementalBoxType[] GetValues()
		{
			return new EControlElementalBoxType[]
			{
				EControlElementalBoxType.Capture,
				EControlElementalBoxType.Return
			};
		}

		// Token: 0x0600C3AE RID: 50094 RVA: 0x001C954A File Offset: 0x001C774A
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
