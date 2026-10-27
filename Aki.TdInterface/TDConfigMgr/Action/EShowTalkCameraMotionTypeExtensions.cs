using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002415 RID: 9237
	public static class EShowTalkCameraMotionTypeExtensions
	{
		// Token: 0x0600C8DD RID: 51421 RVA: 0x001D62C4 File Offset: 0x001D44C4
		public static string ToEnumString(this EShowTalkCameraMotionType value)
		{
			string result;
			if (value != EShowTalkCameraMotionType.Preset)
			{
				if (value != EShowTalkCameraMotionType.Tween)
				{
					result = value.ToString();
				}
				else
				{
					result = "Tween";
				}
			}
			else
			{
				result = "Preset";
			}
			return result;
		}

		// Token: 0x0600C8DE RID: 51422 RVA: 0x001D62FC File Offset: 0x001D44FC
		public static EShowTalkCameraMotionType FromString(string name)
		{
			EShowTalkCameraMotionType result;
			if (!EShowTalkCameraMotionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EShowTalkCameraMotionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C8DF RID: 51423 RVA: 0x001D6325 File Offset: 0x001D4525
		public static bool TryFromString(string name, out EShowTalkCameraMotionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EShowTalkCameraMotionType.Preset;
				return false;
			}
			if (name == "Preset")
			{
				value = EShowTalkCameraMotionType.Preset;
				return true;
			}
			if (!(name == "Tween"))
			{
				value = EShowTalkCameraMotionType.Preset;
				return false;
			}
			value = EShowTalkCameraMotionType.Tween;
			return true;
		}

		// Token: 0x0600C8E0 RID: 51424 RVA: 0x001D635E File Offset: 0x001D455E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Preset",
				"Tween"
			};
		}

		// Token: 0x0600C8E1 RID: 51425 RVA: 0x001D6376 File Offset: 0x001D4576
		public static EShowTalkCameraMotionType[] GetValues()
		{
			return new EShowTalkCameraMotionType[]
			{
				EShowTalkCameraMotionType.Preset,
				EShowTalkCameraMotionType.Tween
			};
		}

		// Token: 0x0600C8E2 RID: 51426 RVA: 0x001D6382 File Offset: 0x001D4582
		public static string[] GetNames()
		{
			return new string[]
			{
				"Preset",
				"Tween"
			};
		}
	}
}
