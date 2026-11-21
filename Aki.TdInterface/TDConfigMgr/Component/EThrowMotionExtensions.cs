using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AFB RID: 2811
	public static class EThrowMotionExtensions
	{
		// Token: 0x06003D7C RID: 15740 RVA: 0x0009D590 File Offset: 0x0009B790
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

		// Token: 0x06003D7D RID: 15741 RVA: 0x0009D5F0 File Offset: 0x0009B7F0
		public static EThrowMotion FromString(string name)
		{
			EThrowMotion result;
			if (!EThrowMotionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EThrowMotion 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x0009D61C File Offset: 0x0009B81C
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

		// Token: 0x06003D7F RID: 15743 RVA: 0x0009D696 File Offset: 0x0009B896
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

		// Token: 0x06003D80 RID: 15744 RVA: 0x0009D6C6 File Offset: 0x0009B8C6
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

		// Token: 0x06003D81 RID: 15745 RVA: 0x0009D6D9 File Offset: 0x0009B8D9
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
