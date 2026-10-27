using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001254 RID: 4692
	public static class ELogicProgramSpecialProcessExtensions
	{
		// Token: 0x06006A21 RID: 27169 RVA: 0x000FE748 File Offset: 0x000FC948
		public static string ToEnumString(this ELogicProgramSpecialProcess value)
		{
			string result;
			if (value == ELogicProgramSpecialProcess.DisableURO)
			{
				result = "DisableURO";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x000FE770 File Offset: 0x000FC970
		public static ELogicProgramSpecialProcess FromString(string name)
		{
			ELogicProgramSpecialProcess result;
			if (!ELogicProgramSpecialProcessExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELogicProgramSpecialProcess 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A23 RID: 27171 RVA: 0x000FE799 File Offset: 0x000FC999
		public static bool TryFromString(string name, out ELogicProgramSpecialProcess value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELogicProgramSpecialProcess.DisableURO;
				return false;
			}
			if (name == "DisableURO")
			{
				value = ELogicProgramSpecialProcess.DisableURO;
				return true;
			}
			value = ELogicProgramSpecialProcess.DisableURO;
			return false;
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x000FE7BE File Offset: 0x000FC9BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DisableURO"
			};
		}

		// Token: 0x06006A25 RID: 27173 RVA: 0x000FE7CE File Offset: 0x000FC9CE
		public static ELogicProgramSpecialProcess[] GetValues()
		{
			return new ELogicProgramSpecialProcess[1];
		}

		// Token: 0x06006A26 RID: 27174 RVA: 0x000FE7D6 File Offset: 0x000FC9D6
		public static string[] GetNames()
		{
			return new string[]
			{
				"DisableURO"
			};
		}
	}
}
