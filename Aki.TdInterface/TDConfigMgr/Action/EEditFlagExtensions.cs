using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002311 RID: 8977
	public static class EEditFlagExtensions
	{
		// Token: 0x0600C44B RID: 50251 RVA: 0x001CA780 File Offset: 0x001C8980
		public static string ToEnumString(this EEditFlag value)
		{
			string result;
			switch (value)
			{
			case EEditFlag.Add:
				result = "新增";
				break;
			case EEditFlag.Modify:
				result = "修改";
				break;
			case EEditFlag.Delete:
				result = "删除";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C44C RID: 50252 RVA: 0x001CA7C8 File Offset: 0x001C89C8
		public static EEditFlag FromString(string name)
		{
			EEditFlag result;
			if (!EEditFlagExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEditFlag 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C44D RID: 50253 RVA: 0x001CA7F4 File Offset: 0x001C89F4
		public static bool TryFromString(string name, out EEditFlag value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEditFlag.Add;
				return false;
			}
			if (name == "新增")
			{
				value = EEditFlag.Add;
				return true;
			}
			if (name == "修改")
			{
				value = EEditFlag.Modify;
				return true;
			}
			if (!(name == "删除"))
			{
				value = EEditFlag.Add;
				return false;
			}
			value = EEditFlag.Delete;
			return true;
		}

		// Token: 0x0600C44E RID: 50254 RVA: 0x001CA84A File Offset: 0x001C8A4A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"新增",
				"修改",
				"删除"
			};
		}

		// Token: 0x0600C44F RID: 50255 RVA: 0x001CA86A File Offset: 0x001C8A6A
		public static EEditFlag[] GetValues()
		{
			return new EEditFlag[]
			{
				EEditFlag.Add,
				EEditFlag.Modify,
				EEditFlag.Delete
			};
		}

		// Token: 0x0600C450 RID: 50256 RVA: 0x001CA87A File Offset: 0x001C8A7A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Add",
				"Modify",
				"Delete"
			};
		}
	}
}
