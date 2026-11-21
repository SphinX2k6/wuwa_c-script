using System;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061D0 RID: 25040
	public static class EMotorcycleRailMoveDataTypeExtensions
	{
		// Token: 0x0603C188 RID: 246152 RVA: 0x0111AB14 File Offset: 0x01118D14
		public static string ToEnumString(this EMotorcycleRailMoveDataType value)
		{
			string result;
			switch (value)
			{
			case EMotorcycleRailMoveDataType.AccelerateAlongRail:
				result = "AccelerateAlongRail";
				break;
			case EMotorcycleRailMoveDataType.JumpToRail:
				result = "JumpToRail";
				break;
			case EMotorcycleRailMoveDataType.SwitchRail:
				result = "SwitchRail";
				break;
			case EMotorcycleRailMoveDataType.JumpAlongRail:
				result = "JumpAlongRail";
				break;
			case EMotorcycleRailMoveDataType.SimpleMoveToRail:
				result = "SimpleMoveToRail";
				break;
			case EMotorcycleRailMoveDataType.JumpFromRail:
				result = "JumpFromRail";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0603C189 RID: 246153 RVA: 0x0111AB80 File Offset: 0x01118D80
		public static EMotorcycleRailMoveDataType FromString(string name)
		{
			EMotorcycleRailMoveDataType result;
			if (!EMotorcycleRailMoveDataTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorcycleRailMoveDataType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603C18A RID: 246154 RVA: 0x0111ABAC File Offset: 0x01118DAC
		public static bool TryFromString(string name, out EMotorcycleRailMoveDataType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMotorcycleRailMoveDataType.AccelerateAlongRail;
				return false;
			}
			if (name == "AccelerateAlongRail")
			{
				value = EMotorcycleRailMoveDataType.AccelerateAlongRail;
				return true;
			}
			if (name == "JumpToRail")
			{
				value = EMotorcycleRailMoveDataType.JumpToRail;
				return true;
			}
			if (name == "SwitchRail")
			{
				value = EMotorcycleRailMoveDataType.SwitchRail;
				return true;
			}
			if (name == "JumpAlongRail")
			{
				value = EMotorcycleRailMoveDataType.JumpAlongRail;
				return true;
			}
			if (name == "SimpleMoveToRail")
			{
				value = EMotorcycleRailMoveDataType.SimpleMoveToRail;
				return true;
			}
			if (!(name == "JumpFromRail"))
			{
				value = EMotorcycleRailMoveDataType.AccelerateAlongRail;
				return false;
			}
			value = EMotorcycleRailMoveDataType.JumpFromRail;
			return true;
		}

		// Token: 0x0603C18B RID: 246155 RVA: 0x0111AC38 File Offset: 0x01118E38
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AccelerateAlongRail",
				"JumpToRail",
				"SwitchRail",
				"JumpAlongRail",
				"SimpleMoveToRail",
				"JumpFromRail"
			};
		}

		// Token: 0x0603C18C RID: 246156 RVA: 0x0111AC70 File Offset: 0x01118E70
		public static EMotorcycleRailMoveDataType[] GetValues()
		{
			return new EMotorcycleRailMoveDataType[]
			{
				EMotorcycleRailMoveDataType.AccelerateAlongRail,
				EMotorcycleRailMoveDataType.JumpToRail,
				EMotorcycleRailMoveDataType.SwitchRail,
				EMotorcycleRailMoveDataType.JumpAlongRail,
				EMotorcycleRailMoveDataType.SimpleMoveToRail,
				EMotorcycleRailMoveDataType.JumpFromRail
			};
		}

		// Token: 0x0603C18D RID: 246157 RVA: 0x0111AC83 File Offset: 0x01118E83
		public static string[] GetNames()
		{
			return new string[]
			{
				"AccelerateAlongRail",
				"JumpToRail",
				"SwitchRail",
				"JumpAlongRail",
				"SimpleMoveToRail",
				"JumpFromRail"
			};
		}
	}
}
