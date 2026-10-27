using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001292 RID: 4754
	public static class ESpecialProcessExtensions
	{
		// Token: 0x06006B38 RID: 27448 RVA: 0x001015F8 File Offset: 0x000FF7F8
		public static string ToEnumString(this ESpecialProcess value)
		{
			string result;
			if (value == ESpecialProcess.LowMemorySceneSwitch)
			{
				result = "LowMemorySceneSwitch";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06006B39 RID: 27449 RVA: 0x00101620 File Offset: 0x000FF820
		public static ESpecialProcess FromString(string name)
		{
			ESpecialProcess result;
			if (!ESpecialProcessExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecialProcess 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B3A RID: 27450 RVA: 0x00101649 File Offset: 0x000FF849
		public static bool TryFromString(string name, out ESpecialProcess value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESpecialProcess.LowMemorySceneSwitch;
				return false;
			}
			if (name == "LowMemorySceneSwitch")
			{
				value = ESpecialProcess.LowMemorySceneSwitch;
				return true;
			}
			value = ESpecialProcess.LowMemorySceneSwitch;
			return false;
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x0010166E File Offset: 0x000FF86E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LowMemorySceneSwitch"
			};
		}

		// Token: 0x06006B3C RID: 27452 RVA: 0x0010167E File Offset: 0x000FF87E
		public static ESpecialProcess[] GetValues()
		{
			return new ESpecialProcess[1];
		}

		// Token: 0x06006B3D RID: 27453 RVA: 0x00101686 File Offset: 0x000FF886
		public static string[] GetNames()
		{
			return new string[]
			{
				"LowMemorySceneSwitch"
			};
		}
	}
}
