using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A9 RID: 2473
	public static class EBeamLayoutTypeExtensions
	{
		// Token: 0x0600378B RID: 14219 RVA: 0x0008CE04 File Offset: 0x0008B004
		public static string ToEnumString(this EBeamLayoutType value)
		{
			string result;
			if (value == EBeamLayoutType.BeamWall)
			{
				result = "BeamWall";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x0008CE2C File Offset: 0x0008B02C
		public static EBeamLayoutType FromString(string name)
		{
			EBeamLayoutType result;
			if (!EBeamLayoutTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBeamLayoutType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x0008CE55 File Offset: 0x0008B055
		public static bool TryFromString(string name, out EBeamLayoutType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBeamLayoutType.BeamWall;
				return false;
			}
			if (name == "BeamWall")
			{
				value = EBeamLayoutType.BeamWall;
				return true;
			}
			value = EBeamLayoutType.BeamWall;
			return false;
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x0008CE7A File Offset: 0x0008B07A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BeamWall"
			};
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x0008CE8A File Offset: 0x0008B08A
		public static EBeamLayoutType[] GetValues()
		{
			return new EBeamLayoutType[1];
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x0008CE92 File Offset: 0x0008B092
		public static string[] GetNames()
		{
			return new string[]
			{
				"BeamWall"
			};
		}
	}
}
