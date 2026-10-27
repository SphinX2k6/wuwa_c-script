using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E8 RID: 2536
	public static class EQuickHackAutoCloseTypeExtensions
	{
		// Token: 0x06003845 RID: 14405 RVA: 0x00091D44 File Offset: 0x0008FF44
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

		// Token: 0x06003846 RID: 14406 RVA: 0x00091D7C File Offset: 0x0008FF7C
		public static EQuickHackAutoCloseType FromString(string name)
		{
			EQuickHackAutoCloseType result;
			if (!EQuickHackAutoCloseTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EQuickHackAutoCloseType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x00091DA5 File Offset: 0x0008FFA5
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

		// Token: 0x06003848 RID: 14408 RVA: 0x00091DDE File Offset: 0x0008FFDE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OnSkillSelected",
				"OnUploadComplete"
			};
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x00091DF6 File Offset: 0x0008FFF6
		public static EQuickHackAutoCloseType[] GetValues()
		{
			return new EQuickHackAutoCloseType[]
			{
				EQuickHackAutoCloseType.OnSkillSelected,
				EQuickHackAutoCloseType.OnUploadComplete
			};
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x00091E02 File Offset: 0x00090002
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
