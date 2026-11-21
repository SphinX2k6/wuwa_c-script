using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A55 RID: 2645
	public static class EMonsterNpcInteractionTypeExtensions
	{
		// Token: 0x06003A91 RID: 14993 RVA: 0x000971A8 File Offset: 0x000953A8
		public static string ToEnumString(this EMonsterNpcInteractionType value)
		{
			string result;
			switch (value)
			{
			case EMonsterNpcInteractionType.WallRun:
				result = "WallRun";
				break;
			case EMonsterNpcInteractionType.Hook:
				result = "Hook";
				break;
			case EMonsterNpcInteractionType.SwordRiding:
				result = "SwordRiding";
				break;
			case EMonsterNpcInteractionType.GazePerform:
				result = "GazePerform";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x000971FC File Offset: 0x000953FC
		public static EMonsterNpcInteractionType FromString(string name)
		{
			EMonsterNpcInteractionType result;
			if (!EMonsterNpcInteractionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMonsterNpcInteractionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x00097228 File Offset: 0x00095428
		public static bool TryFromString(string name, out EMonsterNpcInteractionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMonsterNpcInteractionType.WallRun;
				return false;
			}
			if (name == "WallRun")
			{
				value = EMonsterNpcInteractionType.WallRun;
				return true;
			}
			if (name == "Hook")
			{
				value = EMonsterNpcInteractionType.Hook;
				return true;
			}
			if (name == "SwordRiding")
			{
				value = EMonsterNpcInteractionType.SwordRiding;
				return true;
			}
			if (!(name == "GazePerform"))
			{
				value = EMonsterNpcInteractionType.WallRun;
				return false;
			}
			value = EMonsterNpcInteractionType.GazePerform;
			return true;
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x00097290 File Offset: 0x00095490
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"WallRun",
				"Hook",
				"SwordRiding",
				"GazePerform"
			};
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x000972B8 File Offset: 0x000954B8
		public static EMonsterNpcInteractionType[] GetValues()
		{
			return new EMonsterNpcInteractionType[]
			{
				EMonsterNpcInteractionType.WallRun,
				EMonsterNpcInteractionType.Hook,
				EMonsterNpcInteractionType.SwordRiding,
				EMonsterNpcInteractionType.GazePerform
			};
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x000972CB File Offset: 0x000954CB
		public static string[] GetNames()
		{
			return new string[]
			{
				"WallRun",
				"Hook",
				"SwordRiding",
				"GazePerform"
			};
		}
	}
}
