using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000972 RID: 2418
	public static class EInteractDefaultIconExtensions
	{
		// Token: 0x06003632 RID: 13874 RVA: 0x0008D5FC File Offset: 0x0008B7FC
		public static string ToEnumString(this EInteractDefaultIcon value)
		{
			string result;
			switch (value)
			{
			case EInteractDefaultIcon.Collect:
				result = "Collect";
				break;
			case EInteractDefaultIcon.BigTeleporter:
				result = "BigTeleporter";
				break;
			case EInteractDefaultIcon.SmallTeleporter:
				result = "SmallTeleporter";
				break;
			case EInteractDefaultIcon.TreasureBox:
				result = "TreasureBox";
				break;
			case EInteractDefaultIcon.UnknownCollect:
				result = "UnknownCollect";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x0008D65C File Offset: 0x0008B85C
		public static EInteractDefaultIcon FromString(string name)
		{
			EInteractDefaultIcon result;
			if (!EInteractDefaultIconExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractDefaultIcon 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x0008D688 File Offset: 0x0008B888
		public static bool TryFromString(string name, out EInteractDefaultIcon value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInteractDefaultIcon.Collect;
				return false;
			}
			if (name == "Collect")
			{
				value = EInteractDefaultIcon.Collect;
				return true;
			}
			if (name == "BigTeleporter")
			{
				value = EInteractDefaultIcon.BigTeleporter;
				return true;
			}
			if (name == "SmallTeleporter")
			{
				value = EInteractDefaultIcon.SmallTeleporter;
				return true;
			}
			if (name == "TreasureBox")
			{
				value = EInteractDefaultIcon.TreasureBox;
				return true;
			}
			if (!(name == "UnknownCollect"))
			{
				value = EInteractDefaultIcon.Collect;
				return false;
			}
			value = EInteractDefaultIcon.UnknownCollect;
			return true;
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x0008D702 File Offset: 0x0008B902
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Collect",
				"BigTeleporter",
				"SmallTeleporter",
				"TreasureBox",
				"UnknownCollect"
			};
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x0008D732 File Offset: 0x0008B932
		public static EInteractDefaultIcon[] GetValues()
		{
			return new EInteractDefaultIcon[]
			{
				EInteractDefaultIcon.Collect,
				EInteractDefaultIcon.BigTeleporter,
				EInteractDefaultIcon.SmallTeleporter,
				EInteractDefaultIcon.TreasureBox,
				EInteractDefaultIcon.UnknownCollect
			};
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x0008D745 File Offset: 0x0008B945
		public static string[] GetNames()
		{
			return new string[]
			{
				"Collect",
				"BigTeleporter",
				"SmallTeleporter",
				"TreasureBox",
				"UnknownCollect"
			};
		}
	}
}
