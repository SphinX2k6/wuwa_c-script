using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002303 RID: 8963
	public static class EDisplayModeInPlayerOpExtensions
	{
		// Token: 0x0600C40C RID: 50188 RVA: 0x001C9FE4 File Offset: 0x001C81E4
		public static string ToEnumString(this EDisplayModeInPlayerOp value)
		{
			string result;
			if (value != EDisplayModeInPlayerOp.ShowUi)
			{
				if (value != EDisplayModeInPlayerOp.HideUi)
				{
					result = value.ToString();
				}
				else
				{
					result = "HideUi";
				}
			}
			else
			{
				result = "ShowUi";
			}
			return result;
		}

		// Token: 0x0600C40D RID: 50189 RVA: 0x001CA01C File Offset: 0x001C821C
		public static EDisplayModeInPlayerOp FromString(string name)
		{
			EDisplayModeInPlayerOp result;
			if (!EDisplayModeInPlayerOpExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDisplayModeInPlayerOp 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C40E RID: 50190 RVA: 0x001CA045 File Offset: 0x001C8245
		public static bool TryFromString(string name, out EDisplayModeInPlayerOp value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDisplayModeInPlayerOp.ShowUi;
				return false;
			}
			if (name == "ShowUi")
			{
				value = EDisplayModeInPlayerOp.ShowUi;
				return true;
			}
			if (!(name == "HideUi"))
			{
				value = EDisplayModeInPlayerOp.ShowUi;
				return false;
			}
			value = EDisplayModeInPlayerOp.HideUi;
			return true;
		}

		// Token: 0x0600C40F RID: 50191 RVA: 0x001CA07E File Offset: 0x001C827E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ShowUi",
				"HideUi"
			};
		}

		// Token: 0x0600C410 RID: 50192 RVA: 0x001CA096 File Offset: 0x001C8296
		public static EDisplayModeInPlayerOp[] GetValues()
		{
			return new EDisplayModeInPlayerOp[]
			{
				EDisplayModeInPlayerOp.ShowUi,
				EDisplayModeInPlayerOp.HideUi
			};
		}

		// Token: 0x0600C411 RID: 50193 RVA: 0x001CA0A2 File Offset: 0x001C82A2
		public static string[] GetNames()
		{
			return new string[]
			{
				"ShowUi",
				"HideUi"
			};
		}
	}
}
