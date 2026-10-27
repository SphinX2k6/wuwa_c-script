using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023CF RID: 9167
	public static class EPlayerMoveTagExtensions
	{
		// Token: 0x0600C7A2 RID: 51106 RVA: 0x001D3954 File Offset: 0x001D1B54
		public static string ToEnumString(this EPlayerMoveTag value)
		{
			string result;
			switch (value)
			{
			case EPlayerMoveTag.VehicleMotorHighSpeed:
				result = "载具.摩托.移动.高速行驶";
				break;
			case EPlayerMoveTag.VehicleMotorLowSpeed:
				result = "载具.摩托.移动.低速行驶";
				break;
			case EPlayerMoveTag.VehicleMotorPanoramaLowSpeed:
				result = "载具.摩托.移动.环视.低速行驶";
				break;
			case EPlayerMoveTag.VehicleMotorPanoramaLowSpeed2:
				result = "载具.摩托.移动.环视.低速行驶2";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C7A3 RID: 51107 RVA: 0x001D39A8 File Offset: 0x001D1BA8
		public static EPlayerMoveTag FromString(string name)
		{
			EPlayerMoveTag result;
			if (!EPlayerMoveTagExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerMoveTag 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C7A4 RID: 51108 RVA: 0x001D39D4 File Offset: 0x001D1BD4
		public static bool TryFromString(string name, out EPlayerMoveTag value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlayerMoveTag.VehicleMotorHighSpeed;
				return false;
			}
			if (name == "载具.摩托.移动.高速行驶")
			{
				value = EPlayerMoveTag.VehicleMotorHighSpeed;
				return true;
			}
			if (name == "载具.摩托.移动.低速行驶")
			{
				value = EPlayerMoveTag.VehicleMotorLowSpeed;
				return true;
			}
			if (name == "载具.摩托.移动.环视.低速行驶")
			{
				value = EPlayerMoveTag.VehicleMotorPanoramaLowSpeed;
				return true;
			}
			if (!(name == "载具.摩托.移动.环视.低速行驶2"))
			{
				value = EPlayerMoveTag.VehicleMotorHighSpeed;
				return false;
			}
			value = EPlayerMoveTag.VehicleMotorPanoramaLowSpeed2;
			return true;
		}

		// Token: 0x0600C7A5 RID: 51109 RVA: 0x001D3A3C File Offset: 0x001D1C3C
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"载具.摩托.移动.高速行驶",
				"载具.摩托.移动.低速行驶",
				"载具.摩托.移动.环视.低速行驶",
				"载具.摩托.移动.环视.低速行驶2"
			};
		}

		// Token: 0x0600C7A6 RID: 51110 RVA: 0x001D3A64 File Offset: 0x001D1C64
		public static EPlayerMoveTag[] GetValues()
		{
			return new EPlayerMoveTag[]
			{
				EPlayerMoveTag.VehicleMotorHighSpeed,
				EPlayerMoveTag.VehicleMotorLowSpeed,
				EPlayerMoveTag.VehicleMotorPanoramaLowSpeed,
				EPlayerMoveTag.VehicleMotorPanoramaLowSpeed2
			};
		}

		// Token: 0x0600C7A7 RID: 51111 RVA: 0x001D3A77 File Offset: 0x001D1C77
		public static string[] GetNames()
		{
			return new string[]
			{
				"VehicleMotorHighSpeed",
				"VehicleMotorLowSpeed",
				"VehicleMotorPanoramaLowSpeed",
				"VehicleMotorPanoramaLowSpeed2"
			};
		}
	}
}
