using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025BE RID: 9662
	public static class EGroupAiCommunicateTypeExtensions
	{
		// Token: 0x0600D131 RID: 53553 RVA: 0x001E4EE0 File Offset: 0x001E30E0
		public static string ToEnumString(this EGroupAiCommunicateType value)
		{
			string result;
			if (value != EGroupAiCommunicateType.AddTag)
			{
				if (value != EGroupAiCommunicateType.RemoveTag)
				{
					result = value.ToString();
				}
				else
				{
					result = "RemoveTag";
				}
			}
			else
			{
				result = "AddTag";
			}
			return result;
		}

		// Token: 0x0600D132 RID: 53554 RVA: 0x001E4F18 File Offset: 0x001E3118
		public static EGroupAiCommunicateType FromString(string name)
		{
			EGroupAiCommunicateType result;
			if (!EGroupAiCommunicateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGroupAiCommunicateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D133 RID: 53555 RVA: 0x001E4F41 File Offset: 0x001E3141
		public static bool TryFromString(string name, out EGroupAiCommunicateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGroupAiCommunicateType.AddTag;
				return false;
			}
			if (name == "AddTag")
			{
				value = EGroupAiCommunicateType.AddTag;
				return true;
			}
			if (!(name == "RemoveTag"))
			{
				value = EGroupAiCommunicateType.AddTag;
				return false;
			}
			value = EGroupAiCommunicateType.RemoveTag;
			return true;
		}

		// Token: 0x0600D134 RID: 53556 RVA: 0x001E4F7A File Offset: 0x001E317A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AddTag",
				"RemoveTag"
			};
		}

		// Token: 0x0600D135 RID: 53557 RVA: 0x001E4F92 File Offset: 0x001E3192
		public static EGroupAiCommunicateType[] GetValues()
		{
			return new EGroupAiCommunicateType[]
			{
				EGroupAiCommunicateType.AddTag,
				EGroupAiCommunicateType.RemoveTag
			};
		}

		// Token: 0x0600D136 RID: 53558 RVA: 0x001E4F9E File Offset: 0x001E319E
		public static string[] GetNames()
		{
			return new string[]
			{
				"AddTag",
				"RemoveTag"
			};
		}
	}
}
