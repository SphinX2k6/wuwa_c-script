using System;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x0200704F RID: 28751
	public static class EMotorcycleRailMoveDataTypeExtensions
	{
		// Token: 0x06045FA2 RID: 286626 RVA: 0x01170D78 File Offset: 0x0116EF78
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

		// Token: 0x06045FA3 RID: 286627 RVA: 0x01170DE4 File Offset: 0x0116EFE4
		public static EMotorcycleRailMoveDataType FromString(string name)
		{
			EMotorcycleRailMoveDataType result;
			if (!EMotorcycleRailMoveDataTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorcycleRailMoveDataType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06045FA4 RID: 286628 RVA: 0x01170E10 File Offset: 0x0116F010
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

		// Token: 0x06045FA5 RID: 286629 RVA: 0x01170E9C File Offset: 0x0116F09C
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

		// Token: 0x06045FA6 RID: 286630 RVA: 0x01170ED4 File Offset: 0x0116F0D4
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

		// Token: 0x06045FA7 RID: 286631 RVA: 0x01170EE7 File Offset: 0x0116F0E7
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
