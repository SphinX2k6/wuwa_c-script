using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200125A RID: 4698
	public static class ENewHandInItemsTypeExtensions
	{
		// Token: 0x06006A3C RID: 27196 RVA: 0x000FEB34 File Offset: 0x000FCD34
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

		// Token: 0x06006A3D RID: 27197 RVA: 0x000FEB5C File Offset: 0x000FCD5C
		public static ENewHandInItemsType FromString(string name)
		{
			ENewHandInItemsType result;
			if (!ENewHandInItemsTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENewHandInItemsType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A3E RID: 27198 RVA: 0x000FEB85 File Offset: 0x000FCD85
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

		// Token: 0x06006A3F RID: 27199 RVA: 0x000FEBAA File Offset: 0x000FCDAA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ProjectionMachine"
			};
		}

		// Token: 0x06006A40 RID: 27200 RVA: 0x000FEBBA File Offset: 0x000FCDBA
		public static ENewHandInItemsType[] GetValues()
		{
			return new ENewHandInItemsType[1];
		}

		// Token: 0x06006A41 RID: 27201 RVA: 0x000FEBC2 File Offset: 0x000FCDC2
		public static string[] GetNames()
		{
			return new string[]
			{
				"ProjectionMachine"
			};
		}
	}
}
