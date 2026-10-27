using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200233B RID: 9019
	public static class EFireBulletTypeExtensions
	{
		// Token: 0x0600C508 RID: 50440 RVA: 0x001CC308 File Offset: 0x001CA508
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

		// Token: 0x0600C509 RID: 50441 RVA: 0x001CC350 File Offset: 0x001CA550
		public static EFireBulletType FromString(string name)
		{
			EFireBulletType result;
			if (!EFireBulletTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFireBulletType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C50A RID: 50442 RVA: 0x001CC37C File Offset: 0x001CA57C
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

		// Token: 0x0600C50B RID: 50443 RVA: 0x001CC3D2 File Offset: 0x001CA5D2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TrackTarget",
				"ForwardFront",
				"TrackPosition"
			};
		}

		// Token: 0x0600C50C RID: 50444 RVA: 0x001CC3F2 File Offset: 0x001CA5F2
		public static EFireBulletType[] GetValues()
		{
			return new EFireBulletType[]
			{
				EFireBulletType.TrackTarget,
				EFireBulletType.ForwardFront,
				EFireBulletType.TrackPosition
			};
		}

		// Token: 0x0600C50D RID: 50445 RVA: 0x001CC402 File Offset: 0x001CA602
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
