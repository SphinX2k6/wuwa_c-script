using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009DA RID: 2522
	public static class EPortalModelExtensions
	{
		// Token: 0x06003806 RID: 14342 RVA: 0x000915BC File Offset: 0x0008F7BC
		public static string ToEnumString(this EPortalModel value)
		{
			string result;
			if (value != EPortalModel.A)
			{
				if (value != EPortalModel.B)
				{
					result = value.ToString();
				}
				else
				{
					result = "B";
				}
			}
			else
			{
				result = "A";
			}
			return result;
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x000915F4 File Offset: 0x0008F7F4
		public static EPortalModel FromString(string name)
		{
			EPortalModel result;
			if (!EPortalModelExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPortalModel 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x0009161D File Offset: 0x0008F81D
		public static bool TryFromString(string name, out EPortalModel value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPortalModel.A;
				return false;
			}
			if (name == "A")
			{
				value = EPortalModel.A;
				return true;
			}
			if (!(name == "B"))
			{
				value = EPortalModel.A;
				return false;
			}
			value = EPortalModel.B;
			return true;
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x00091656 File Offset: 0x0008F856
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"A",
				"B"
			};
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x0009166E File Offset: 0x0008F86E
		public static EPortalModel[] GetValues()
		{
			return new EPortalModel[]
			{
				EPortalModel.A,
				EPortalModel.B
			};
		}

		// Token: 0x0600380B RID: 14347 RVA: 0x0009167A File Offset: 0x0008F87A
		public static string[] GetNames()
		{
			return new string[]
			{
				"A",
				"B"
			};
		}
	}
}
