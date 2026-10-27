using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B6 RID: 2486
	public static class ENpcStandbyShowFinitelyPlayModeExtensions
	{
		// Token: 0x06003764 RID: 14180 RVA: 0x00090098 File Offset: 0x0008E298
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

		// Token: 0x06003765 RID: 14181 RVA: 0x000900D0 File Offset: 0x0008E2D0
		public static ENpcStandbyShowFinitelyPlayMode FromString(string name)
		{
			ENpcStandbyShowFinitelyPlayMode result;
			if (!ENpcStandbyShowFinitelyPlayModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcStandbyShowFinitelyPlayMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x000900F9 File Offset: 0x0008E2F9
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

		// Token: 0x06003767 RID: 14183 RVA: 0x00090132 File Offset: 0x0008E332
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Randomly",
				"Orderly"
			};
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x0009014A File Offset: 0x0008E34A
		public static ENpcStandbyShowFinitelyPlayMode[] GetValues()
		{
			return new ENpcStandbyShowFinitelyPlayMode[]
			{
				ENpcStandbyShowFinitelyPlayMode.Randomly,
				ENpcStandbyShowFinitelyPlayMode.Orderly
			};
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x00090156 File Offset: 0x0008E356
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
