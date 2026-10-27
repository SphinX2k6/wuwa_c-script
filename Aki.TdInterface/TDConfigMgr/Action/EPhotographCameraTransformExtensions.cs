using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C9 RID: 9161
	public static class EPhotographCameraTransformExtensions
	{
		// Token: 0x0600C787 RID: 51079 RVA: 0x001D3580 File Offset: 0x001D1780
		public static string ToEnumString(this EPhotographCameraTransform value)
		{
			string result;
			if (value == EPhotographCameraTransform.Absolute)
			{
				result = "Absolute";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C788 RID: 51080 RVA: 0x001D35A8 File Offset: 0x001D17A8
		public static EPhotographCameraTransform FromString(string name)
		{
			EPhotographCameraTransform result;
			if (!EPhotographCameraTransformExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhotographCameraTransform 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C789 RID: 51081 RVA: 0x001D35D1 File Offset: 0x001D17D1
		public static bool TryFromString(string name, out EPhotographCameraTransform value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPhotographCameraTransform.Absolute;
				return false;
			}
			if (name == "Absolute")
			{
				value = EPhotographCameraTransform.Absolute;
				return true;
			}
			value = EPhotographCameraTransform.Absolute;
			return false;
		}

		// Token: 0x0600C78A RID: 51082 RVA: 0x001D35F6 File Offset: 0x001D17F6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Absolute"
			};
		}

		// Token: 0x0600C78B RID: 51083 RVA: 0x001D3606 File Offset: 0x001D1806
		public static EPhotographCameraTransform[] GetValues()
		{
			return new EPhotographCameraTransform[1];
		}

		// Token: 0x0600C78C RID: 51084 RVA: 0x001D360E File Offset: 0x001D180E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Absolute"
			};
		}
	}
}
