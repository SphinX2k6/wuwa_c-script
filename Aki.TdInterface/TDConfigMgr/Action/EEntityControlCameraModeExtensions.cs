using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002592 RID: 9618
	public static class EEntityControlCameraModeExtensions
	{
		// Token: 0x0600D06B RID: 53355 RVA: 0x001E3080 File Offset: 0x001E1280
		public static string ToEnumString(this EEntityControlCameraMode value)
		{
			string result;
			if (value != EEntityControlCameraMode.UseSequenceCamera)
			{
				if (value != EEntityControlCameraMode.FollowSequencePlayer)
				{
					result = value.ToString();
				}
				else
				{
					result = "FollowSequencePlayer";
				}
			}
			else
			{
				result = "UseSequenceCamera";
			}
			return result;
		}

		// Token: 0x0600D06C RID: 53356 RVA: 0x001E30B8 File Offset: 0x001E12B8
		public static EEntityControlCameraMode FromString(string name)
		{
			EEntityControlCameraMode result;
			if (!EEntityControlCameraModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityControlCameraMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D06D RID: 53357 RVA: 0x001E30E1 File Offset: 0x001E12E1
		public static bool TryFromString(string name, out EEntityControlCameraMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEntityControlCameraMode.UseSequenceCamera;
				return false;
			}
			if (name == "UseSequenceCamera")
			{
				value = EEntityControlCameraMode.UseSequenceCamera;
				return true;
			}
			if (!(name == "FollowSequencePlayer"))
			{
				value = EEntityControlCameraMode.UseSequenceCamera;
				return false;
			}
			value = EEntityControlCameraMode.FollowSequencePlayer;
			return true;
		}

		// Token: 0x0600D06E RID: 53358 RVA: 0x001E311A File Offset: 0x001E131A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UseSequenceCamera",
				"FollowSequencePlayer"
			};
		}

		// Token: 0x0600D06F RID: 53359 RVA: 0x001E3132 File Offset: 0x001E1332
		public static EEntityControlCameraMode[] GetValues()
		{
			return new EEntityControlCameraMode[]
			{
				EEntityControlCameraMode.UseSequenceCamera,
				EEntityControlCameraMode.FollowSequencePlayer
			};
		}

		// Token: 0x0600D070 RID: 53360 RVA: 0x001E313E File Offset: 0x001E133E
		public static string[] GetNames()
		{
			return new string[]
			{
				"UseSequenceCamera",
				"FollowSequencePlayer"
			};
		}
	}
}
