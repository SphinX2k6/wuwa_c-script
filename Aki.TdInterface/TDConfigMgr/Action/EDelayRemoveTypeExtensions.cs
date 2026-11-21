using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200256A RID: 9578
	public static class EDelayRemoveTypeExtensions
	{
		// Token: 0x0600CFB7 RID: 53175 RVA: 0x001E1B3C File Offset: 0x001DFD3C
		public static string ToEnumString(this EDelayRemoveType value)
		{
			string result;
			if (value == EDelayRemoveType.DelayRemoveAfterSkillFinish)
			{
				result = "DelayRemoveAfterSkillFinish";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CFB8 RID: 53176 RVA: 0x001E1B64 File Offset: 0x001DFD64
		public static EDelayRemoveType FromString(string name)
		{
			EDelayRemoveType result;
			if (!EDelayRemoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDelayRemoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CFB9 RID: 53177 RVA: 0x001E1B8D File Offset: 0x001DFD8D
		public static bool TryFromString(string name, out EDelayRemoveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDelayRemoveType.DelayRemoveAfterSkillFinish;
				return false;
			}
			if (name == "DelayRemoveAfterSkillFinish")
			{
				value = EDelayRemoveType.DelayRemoveAfterSkillFinish;
				return true;
			}
			value = EDelayRemoveType.DelayRemoveAfterSkillFinish;
			return false;
		}

		// Token: 0x0600CFBA RID: 53178 RVA: 0x001E1BB2 File Offset: 0x001DFDB2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DelayRemoveAfterSkillFinish"
			};
		}

		// Token: 0x0600CFBB RID: 53179 RVA: 0x001E1BC2 File Offset: 0x001DFDC2
		public static EDelayRemoveType[] GetValues()
		{
			return new EDelayRemoveType[1];
		}

		// Token: 0x0600CFBC RID: 53180 RVA: 0x001E1BCA File Offset: 0x001DFDCA
		public static string[] GetNames()
		{
			return new string[]
			{
				"DelayRemoveAfterSkillFinish"
			};
		}
	}
}
