using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A0 RID: 2464
	public static class EMonsterNpcInteractionTypeExtensions
	{
		// Token: 0x06003701 RID: 14081 RVA: 0x0008F0E4 File Offset: 0x0008D2E4
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

		// Token: 0x06003702 RID: 14082 RVA: 0x0008F138 File Offset: 0x0008D338
		public static EMonsterNpcInteractionType FromString(string name)
		{
			EMonsterNpcInteractionType result;
			if (!EMonsterNpcInteractionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMonsterNpcInteractionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x0008F164 File Offset: 0x0008D364
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

		// Token: 0x06003704 RID: 14084 RVA: 0x0008F1CC File Offset: 0x0008D3CC
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

		// Token: 0x06003705 RID: 14085 RVA: 0x0008F1F4 File Offset: 0x0008D3F4
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

		// Token: 0x06003706 RID: 14086 RVA: 0x0008F207 File Offset: 0x0008D407
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
