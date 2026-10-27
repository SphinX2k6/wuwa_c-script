using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002323 RID: 8995
	public static class EEntityControlCameraModeExtensions
	{
		// Token: 0x0600C49C RID: 50332 RVA: 0x001CB1B8 File Offset: 0x001C93B8
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

		// Token: 0x0600C49D RID: 50333 RVA: 0x001CB1F0 File Offset: 0x001C93F0
		public static EEntityControlCameraMode FromString(string name)
		{
			EEntityControlCameraMode result;
			if (!EEntityControlCameraModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityControlCameraMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C49E RID: 50334 RVA: 0x001CB219 File Offset: 0x001C9419
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

		// Token: 0x0600C49F RID: 50335 RVA: 0x001CB252 File Offset: 0x001C9452
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UseSequenceCamera",
				"FollowSequencePlayer"
			};
		}

		// Token: 0x0600C4A0 RID: 50336 RVA: 0x001CB26A File Offset: 0x001C946A
		public static EEntityControlCameraMode[] GetValues()
		{
			return new EEntityControlCameraMode[]
			{
				EEntityControlCameraMode.UseSequenceCamera,
				EEntityControlCameraMode.FollowSequencePlayer
			};
		}

		// Token: 0x0600C4A1 RID: 50337 RVA: 0x001CB276 File Offset: 0x001C9476
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
