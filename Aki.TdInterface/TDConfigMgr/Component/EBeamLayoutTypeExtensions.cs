using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000900 RID: 2304
	public static class EBeamLayoutTypeExtensions
	{
		// Token: 0x06003431 RID: 13361 RVA: 0x00085594 File Offset: 0x00083794
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

		// Token: 0x06003432 RID: 13362 RVA: 0x000855BC File Offset: 0x000837BC
		public static EBeamLayoutType FromString(string name)
		{
			EBeamLayoutType result;
			if (!EBeamLayoutTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBeamLayoutType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x000855E5 File Offset: 0x000837E5
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

		// Token: 0x06003434 RID: 13364 RVA: 0x0008560A File Offset: 0x0008380A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BeamWall"
			};
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x0008561A File Offset: 0x0008381A
		public static EBeamLayoutType[] GetValues()
		{
			return new EBeamLayoutType[1];
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x00085622 File Offset: 0x00083822
		public static string[] GetNames()
		{
			return new string[]
			{
				"BeamWall"
			};
		}
	}
}
