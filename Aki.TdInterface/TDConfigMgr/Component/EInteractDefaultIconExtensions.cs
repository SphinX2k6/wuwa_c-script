using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A25 RID: 2597
	public static class EInteractDefaultIconExtensions
	{
		// Token: 0x060039B9 RID: 14777 RVA: 0x00095568 File Offset: 0x00093768
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

		// Token: 0x060039BA RID: 14778 RVA: 0x000955C8 File Offset: 0x000937C8
		public static EInteractDefaultIcon FromString(string name)
		{
			EInteractDefaultIcon result;
			if (!EInteractDefaultIconExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractDefaultIcon 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x000955F4 File Offset: 0x000937F4
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

		// Token: 0x060039BC RID: 14780 RVA: 0x0009566E File Offset: 0x0009386E
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

		// Token: 0x060039BD RID: 14781 RVA: 0x0009569E File Offset: 0x0009389E
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

		// Token: 0x060039BE RID: 14782 RVA: 0x000956B1 File Offset: 0x000938B1
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
