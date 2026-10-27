using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001244 RID: 4676
	public static class EFlipperSystemVarExtensions
	{
		// Token: 0x060069D9 RID: 27097 RVA: 0x000FD928 File Offset: 0x000FBB28
		public static string ToEnumString(this EFlipperSystemVar value)
		{
			string result;
			if (value == EFlipperSystemVar.LifeRemain)
			{
				result = "LifeRemain";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060069DA RID: 27098 RVA: 0x000FD950 File Offset: 0x000FBB50
		public static EFlipperSystemVar FromString(string name)
		{
			EFlipperSystemVar result;
			if (!EFlipperSystemVarExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFlipperSystemVar 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060069DB RID: 27099 RVA: 0x000FD979 File Offset: 0x000FBB79
		public static bool TryFromString(string name, out EFlipperSystemVar value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFlipperSystemVar.LifeRemain;
				return false;
			}
			if (name == "LifeRemain")
			{
				value = EFlipperSystemVar.LifeRemain;
				return true;
			}
			value = EFlipperSystemVar.LifeRemain;
			return false;
		}

		// Token: 0x060069DC RID: 27100 RVA: 0x000FD99E File Offset: 0x000FBB9E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LifeRemain"
			};
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x000FD9AE File Offset: 0x000FBBAE
		public static EFlipperSystemVar[] GetValues()
		{
			return new EFlipperSystemVar[1];
		}

		// Token: 0x060069DE RID: 27102 RVA: 0x000FD9B6 File Offset: 0x000FBBB6
		public static string[] GetNames()
		{
			return new string[]
			{
				"LifeRemain"
			};
		}
	}
}
