using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200139A RID: 5018
	public static class ENewHandInItemsTypeExtensions
	{
		// Token: 0x0600708F RID: 28815 RVA: 0x0010C760 File Offset: 0x0010A960
		public static string ToEnumString(this ENewHandInItemsType value)
		{
			string result;
			if (value == ENewHandInItemsType.ProjectionMachine)
			{
				result = "ProjectionMachine";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06007090 RID: 28816 RVA: 0x0010C788 File Offset: 0x0010A988
		public static ENewHandInItemsType FromString(string name)
		{
			ENewHandInItemsType result;
			if (!ENewHandInItemsTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENewHandInItemsType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007091 RID: 28817 RVA: 0x0010C7B1 File Offset: 0x0010A9B1
		public static bool TryFromString(string name, out ENewHandInItemsType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENewHandInItemsType.ProjectionMachine;
				return false;
			}
			if (name == "ProjectionMachine")
			{
				value = ENewHandInItemsType.ProjectionMachine;
				return true;
			}
			value = ENewHandInItemsType.ProjectionMachine;
			return false;
		}

		// Token: 0x06007092 RID: 28818 RVA: 0x0010C7D6 File Offset: 0x0010A9D6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ProjectionMachine"
			};
		}

		// Token: 0x06007093 RID: 28819 RVA: 0x0010C7E6 File Offset: 0x0010A9E6
		public static ENewHandInItemsType[] GetValues()
		{
			return new ENewHandInItemsType[1];
		}

		// Token: 0x06007094 RID: 28820 RVA: 0x0010C7EE File Offset: 0x0010A9EE
		public static string[] GetNames()
		{
			return new string[]
			{
				"ProjectionMachine"
			};
		}
	}
}
