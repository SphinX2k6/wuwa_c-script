using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A6B RID: 2667
	public static class ENpcStandbyShowFinitelyPlayModeExtensions
	{
		// Token: 0x06003AF4 RID: 15092 RVA: 0x000981D0 File Offset: 0x000963D0
		public static string ToEnumString(this ENpcStandbyShowFinitelyPlayMode value)
		{
			string result;
			if (value != ENpcStandbyShowFinitelyPlayMode.Randomly)
			{
				if (value != ENpcStandbyShowFinitelyPlayMode.Orderly)
				{
					result = value.ToString();
				}
				else
				{
					result = "Orderly";
				}
			}
			else
			{
				result = "Randomly";
			}
			return result;
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x00098208 File Offset: 0x00096408
		public static ENpcStandbyShowFinitelyPlayMode FromString(string name)
		{
			ENpcStandbyShowFinitelyPlayMode result;
			if (!ENpcStandbyShowFinitelyPlayModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcStandbyShowFinitelyPlayMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x00098231 File Offset: 0x00096431
		public static bool TryFromString(string name, out ENpcStandbyShowFinitelyPlayMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENpcStandbyShowFinitelyPlayMode.Randomly;
				return false;
			}
			if (name == "Randomly")
			{
				value = ENpcStandbyShowFinitelyPlayMode.Randomly;
				return true;
			}
			if (!(name == "Orderly"))
			{
				value = ENpcStandbyShowFinitelyPlayMode.Randomly;
				return false;
			}
			value = ENpcStandbyShowFinitelyPlayMode.Orderly;
			return true;
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x0009826A File Offset: 0x0009646A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Randomly",
				"Orderly"
			};
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x00098282 File Offset: 0x00096482
		public static ENpcStandbyShowFinitelyPlayMode[] GetValues()
		{
			return new ENpcStandbyShowFinitelyPlayMode[]
			{
				ENpcStandbyShowFinitelyPlayMode.Randomly,
				ENpcStandbyShowFinitelyPlayMode.Orderly
			};
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x0009828E File Offset: 0x0009648E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Randomly",
				"Orderly"
			};
		}
	}
}
