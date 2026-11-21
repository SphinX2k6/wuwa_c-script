using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025AC RID: 9644
	public static class EFireBulletTypeExtensions
	{
		// Token: 0x0600D0E0 RID: 53472 RVA: 0x001E43C0 File Offset: 0x001E25C0
		public static string ToEnumString(this EFireBulletType value)
		{
			string result;
			switch (value)
			{
			case EFireBulletType.TrackTarget:
				result = "TrackTarget";
				break;
			case EFireBulletType.ForwardFront:
				result = "ForwardFront";
				break;
			case EFireBulletType.TrackPosition:
				result = "TrackPosition";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D0E1 RID: 53473 RVA: 0x001E4408 File Offset: 0x001E2608
		public static EFireBulletType FromString(string name)
		{
			EFireBulletType result;
			if (!EFireBulletTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFireBulletType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D0E2 RID: 53474 RVA: 0x001E4434 File Offset: 0x001E2634
		public static bool TryFromString(string name, out EFireBulletType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFireBulletType.TrackTarget;
				return false;
			}
			if (name == "TrackTarget")
			{
				value = EFireBulletType.TrackTarget;
				return true;
			}
			if (name == "ForwardFront")
			{
				value = EFireBulletType.ForwardFront;
				return true;
			}
			if (!(name == "TrackPosition"))
			{
				value = EFireBulletType.TrackTarget;
				return false;
			}
			value = EFireBulletType.TrackPosition;
			return true;
		}

		// Token: 0x0600D0E3 RID: 53475 RVA: 0x001E448A File Offset: 0x001E268A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TrackTarget",
				"ForwardFront",
				"TrackPosition"
			};
		}

		// Token: 0x0600D0E4 RID: 53476 RVA: 0x001E44AA File Offset: 0x001E26AA
		public static EFireBulletType[] GetValues()
		{
			return new EFireBulletType[]
			{
				EFireBulletType.TrackTarget,
				EFireBulletType.ForwardFront,
				EFireBulletType.TrackPosition
			};
		}

		// Token: 0x0600D0E5 RID: 53477 RVA: 0x001E44BA File Offset: 0x001E26BA
		public static string[] GetNames()
		{
			return new string[]
			{
				"TrackTarget",
				"ForwardFront",
				"TrackPosition"
			};
		}
	}
}
