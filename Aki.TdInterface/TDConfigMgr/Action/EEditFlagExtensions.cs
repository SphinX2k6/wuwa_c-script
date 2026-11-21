using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002580 RID: 9600
	public static class EEditFlagExtensions
	{
		// Token: 0x0600D01A RID: 53274 RVA: 0x001E2648 File Offset: 0x001E0848
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

		// Token: 0x0600D01B RID: 53275 RVA: 0x001E2690 File Offset: 0x001E0890
		public static EEditFlag FromString(string name)
		{
			EEditFlag result;
			if (!EEditFlagExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEditFlag 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D01C RID: 53276 RVA: 0x001E26BC File Offset: 0x001E08BC
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

		// Token: 0x0600D01D RID: 53277 RVA: 0x001E2712 File Offset: 0x001E0912
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"新增",
				"修改",
				"删除"
			};
		}

		// Token: 0x0600D01E RID: 53278 RVA: 0x001E2732 File Offset: 0x001E0932
		public static EEditFlag[] GetValues()
		{
			return new EEditFlag[]
			{
				EEditFlag.Add,
				EEditFlag.Modify,
				EEditFlag.Delete
			};
		}

		// Token: 0x0600D01F RID: 53279 RVA: 0x001E2742 File Offset: 0x001E0942
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
