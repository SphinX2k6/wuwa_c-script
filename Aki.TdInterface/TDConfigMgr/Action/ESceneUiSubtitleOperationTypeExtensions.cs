using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002696 RID: 9878
	public static class ESceneUiSubtitleOperationTypeExtensions
	{
		// Token: 0x0600D4FD RID: 54525 RVA: 0x001EEEB4 File Offset: 0x001ED0B4
		public static string ToEnumString(this ESceneUiSubtitleOperationType value)
		{
			string result;
			if (value != ESceneUiSubtitleOperationType.Spawn)
			{
				if (value != ESceneUiSubtitleOperationType.Remove)
				{
					result = value.ToString();
				}
				else
				{
					result = "Remove";
				}
			}
			else
			{
				result = "Spawn";
			}
			return result;
		}

		// Token: 0x0600D4FE RID: 54526 RVA: 0x001EEEEC File Offset: 0x001ED0EC
		public static ESceneUiSubtitleOperationType FromString(string name)
		{
			ESceneUiSubtitleOperationType result;
			if (!ESceneUiSubtitleOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneUiSubtitleOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D4FF RID: 54527 RVA: 0x001EEF15 File Offset: 0x001ED115
		public static bool TryFromString(string name, out ESceneUiSubtitleOperationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESceneUiSubtitleOperationType.Spawn;
				return false;
			}
			if (name == "Spawn")
			{
				value = ESceneUiSubtitleOperationType.Spawn;
				return true;
			}
			if (!(name == "Remove"))
			{
				value = ESceneUiSubtitleOperationType.Spawn;
				return false;
			}
			value = ESceneUiSubtitleOperationType.Remove;
			return true;
		}

		// Token: 0x0600D500 RID: 54528 RVA: 0x001EEF4E File Offset: 0x001ED14E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Spawn",
				"Remove"
			};
		}

		// Token: 0x0600D501 RID: 54529 RVA: 0x001EEF66 File Offset: 0x001ED166
		public static ESceneUiSubtitleOperationType[] GetValues()
		{
			return new ESceneUiSubtitleOperationType[]
			{
				ESceneUiSubtitleOperationType.Spawn,
				ESceneUiSubtitleOperationType.Remove
			};
		}

		// Token: 0x0600D502 RID: 54530 RVA: 0x001EEF72 File Offset: 0x001ED172
		public static string[] GetNames()
		{
			return new string[]
			{
				"Spawn",
				"Remove"
			};
		}
	}
}
