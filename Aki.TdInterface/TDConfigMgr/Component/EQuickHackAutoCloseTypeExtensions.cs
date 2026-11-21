using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AAD RID: 2733
	public static class EQuickHackAutoCloseTypeExtensions
	{
		// Token: 0x06003C1D RID: 15389 RVA: 0x0009A604 File Offset: 0x00098804
		public static string ToEnumString(this EQuickHackAutoCloseType value)
		{
			string result;
			if (value != EQuickHackAutoCloseType.OnSkillSelected)
			{
				if (value != EQuickHackAutoCloseType.OnUploadComplete)
				{
					result = value.ToString();
				}
				else
				{
					result = "OnUploadComplete";
				}
			}
			else
			{
				result = "OnSkillSelected";
			}
			return result;
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x0009A63C File Offset: 0x0009883C
		public static EQuickHackAutoCloseType FromString(string name)
		{
			EQuickHackAutoCloseType result;
			if (!EQuickHackAutoCloseTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EQuickHackAutoCloseType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x0009A665 File Offset: 0x00098865
		public static bool TryFromString(string name, out EQuickHackAutoCloseType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EQuickHackAutoCloseType.OnSkillSelected;
				return false;
			}
			if (name == "OnSkillSelected")
			{
				value = EQuickHackAutoCloseType.OnSkillSelected;
				return true;
			}
			if (!(name == "OnUploadComplete"))
			{
				value = EQuickHackAutoCloseType.OnSkillSelected;
				return false;
			}
			value = EQuickHackAutoCloseType.OnUploadComplete;
			return true;
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x0009A69E File Offset: 0x0009889E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OnSkillSelected",
				"OnUploadComplete"
			};
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x0009A6B6 File Offset: 0x000988B6
		public static EQuickHackAutoCloseType[] GetValues()
		{
			return new EQuickHackAutoCloseType[]
			{
				EQuickHackAutoCloseType.OnSkillSelected,
				EQuickHackAutoCloseType.OnUploadComplete
			};
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x0009A6C2 File Offset: 0x000988C2
		public static string[] GetNames()
		{
			return new string[]
			{
				"OnSkillSelected",
				"OnUploadComplete"
			};
		}
	}
}
