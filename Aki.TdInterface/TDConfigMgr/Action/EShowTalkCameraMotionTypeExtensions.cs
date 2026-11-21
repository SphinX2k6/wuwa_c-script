using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026B4 RID: 9908
	public static class EShowTalkCameraMotionTypeExtensions
	{
		// Token: 0x0600D584 RID: 54660 RVA: 0x001EFEC0 File Offset: 0x001EE0C0
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

		// Token: 0x0600D585 RID: 54661 RVA: 0x001EFEF8 File Offset: 0x001EE0F8
		public static EShowTalkCameraMotionType FromString(string name)
		{
			EShowTalkCameraMotionType result;
			if (!EShowTalkCameraMotionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EShowTalkCameraMotionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D586 RID: 54662 RVA: 0x001EFF21 File Offset: 0x001EE121
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

		// Token: 0x0600D587 RID: 54663 RVA: 0x001EFF5A File Offset: 0x001EE15A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Preset",
				"Tween"
			};
		}

		// Token: 0x0600D588 RID: 54664 RVA: 0x001EFF72 File Offset: 0x001EE172
		public static EShowTalkCameraMotionType[] GetValues()
		{
			return new EShowTalkCameraMotionType[]
			{
				EShowTalkCameraMotionType.Preset,
				EShowTalkCameraMotionType.Tween
			};
		}

		// Token: 0x0600D589 RID: 54665 RVA: 0x001EFF7E File Offset: 0x001EE17E
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
