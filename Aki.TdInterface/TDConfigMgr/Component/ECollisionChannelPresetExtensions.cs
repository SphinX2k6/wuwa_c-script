using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200090A RID: 2314
	public static class ECollisionChannelPresetExtensions
	{
		// Token: 0x0600345E RID: 13406 RVA: 0x00085B38 File Offset: 0x00083D38
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

		// Token: 0x0600345F RID: 13407 RVA: 0x00085B60 File Offset: 0x00083D60
		public static ECollisionChannelPreset FromString(string name)
		{
			ECollisionChannelPreset result;
			if (!ECollisionChannelPresetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECollisionChannelPreset 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x00085B89 File Offset: 0x00083D89
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

		// Token: 0x06003461 RID: 13409 RVA: 0x00085BAE File Offset: 0x00083DAE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CanBePassedThrough"
			};
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x00085BBE File Offset: 0x00083DBE
		public static ECollisionChannelPreset[] GetValues()
		{
			return new ECollisionChannelPreset[1];
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00085BC6 File Offset: 0x00083DC6
		public static string[] GetNames()
		{
			return new string[]
			{
				"CanBePassedThrough"
			};
		}
	}
}
