using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002666 RID: 9830
	public static class EPlayerMoveTagExtensions
	{
		// Token: 0x0600D425 RID: 54309 RVA: 0x001ED100 File Offset: 0x001EB300
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

		// Token: 0x0600D426 RID: 54310 RVA: 0x001ED154 File Offset: 0x001EB354
		public static EPlayerMoveTag FromString(string name)
		{
			EPlayerMoveTag result;
			if (!EPlayerMoveTagExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerMoveTag 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D427 RID: 54311 RVA: 0x001ED180 File Offset: 0x001EB380
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

		// Token: 0x0600D428 RID: 54312 RVA: 0x001ED1E8 File Offset: 0x001EB3E8
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

		// Token: 0x0600D429 RID: 54313 RVA: 0x001ED210 File Offset: 0x001EB410
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

		// Token: 0x0600D42A RID: 54314 RVA: 0x001ED223 File Offset: 0x001EB423
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
