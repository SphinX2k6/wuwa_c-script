using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A36 RID: 2614
	public static class EThrowMotionExtensions
	{
		// Token: 0x060039A4 RID: 14756 RVA: 0x00094C5C File Offset: 0x00092E5C
		public static string ToEnumString(this EThrowMotion value)
		{
			string result;
			switch (value)
			{
			case EThrowMotion.Projectile:
				result = "Projectile";
				break;
			case EThrowMotion.Circumnutation:
				result = "Circumnutation";
				break;
			case EThrowMotion.TrackTarget:
				result = "TrackTarget";
				break;
			case EThrowMotion.Levitate:
				result = "Levitate";
				break;
			case EThrowMotion.FreeFall:
				result = "FreeFall";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x00094CBC File Offset: 0x00092EBC
		public static EThrowMotion FromString(string name)
		{
			EThrowMotion result;
			if (!EThrowMotionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EThrowMotion 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x00094CE8 File Offset: 0x00092EE8
		public static bool TryFromString(string name, out EThrowMotion value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EThrowMotion.Projectile;
				return false;
			}
			if (name == "Projectile")
			{
				value = EThrowMotion.Projectile;
				return true;
			}
			if (name == "Circumnutation")
			{
				value = EThrowMotion.Circumnutation;
				return true;
			}
			if (name == "TrackTarget")
			{
				value = EThrowMotion.TrackTarget;
				return true;
			}
			if (name == "Levitate")
			{
				value = EThrowMotion.Levitate;
				return true;
			}
			if (!(name == "FreeFall"))
			{
				value = EThrowMotion.Projectile;
				return false;
			}
			value = EThrowMotion.FreeFall;
			return true;
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x00094D62 File Offset: 0x00092F62
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Projectile",
				"Circumnutation",
				"TrackTarget",
				"Levitate",
				"FreeFall"
			};
		}

		// Token: 0x060039A8 RID: 14760 RVA: 0x00094D92 File Offset: 0x00092F92
		public static EThrowMotion[] GetValues()
		{
			return new EThrowMotion[]
			{
				EThrowMotion.Projectile,
				EThrowMotion.Circumnutation,
				EThrowMotion.TrackTarget,
				EThrowMotion.Levitate,
				EThrowMotion.FreeFall
			};
		}

		// Token: 0x060039A9 RID: 14761 RVA: 0x00094DA5 File Offset: 0x00092FA5
		public static string[] GetNames()
		{
			return new string[]
			{
				"Projectile",
				"Circumnutation",
				"TrackTarget",
				"Levitate",
				"FreeFall"
			};
		}
	}
}
