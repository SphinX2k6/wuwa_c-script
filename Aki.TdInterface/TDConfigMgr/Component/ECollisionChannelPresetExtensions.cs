using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B7 RID: 2487
	public static class ECollisionChannelPresetExtensions
	{
		// Token: 0x060037CA RID: 14282 RVA: 0x0008D644 File Offset: 0x0008B844
		public static string ToEnumString(this ECollisionChannelPreset value)
		{
			string result;
			if (value == ECollisionChannelPreset.CanBePassedThrough)
			{
				result = "CanBePassedThrough";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x0008D66C File Offset: 0x0008B86C
		public static ECollisionChannelPreset FromString(string name)
		{
			ECollisionChannelPreset result;
			if (!ECollisionChannelPresetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECollisionChannelPreset 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x0008D695 File Offset: 0x0008B895
		public static bool TryFromString(string name, out ECollisionChannelPreset value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECollisionChannelPreset.CanBePassedThrough;
				return false;
			}
			if (name == "CanBePassedThrough")
			{
				value = ECollisionChannelPreset.CanBePassedThrough;
				return true;
			}
			value = ECollisionChannelPreset.CanBePassedThrough;
			return false;
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x0008D6BA File Offset: 0x0008B8BA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CanBePassedThrough"
			};
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x0008D6CA File Offset: 0x0008B8CA
		public static ECollisionChannelPreset[] GetValues()
		{
			return new ECollisionChannelPreset[1];
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x0008D6D2 File Offset: 0x0008B8D2
		public static string[] GetNames()
		{
			return new string[]
			{
				"CanBePassedThrough"
			};
		}
	}
}
