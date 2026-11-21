using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200265E RID: 9822
	public static class EPhotographCameraTransformExtensions
	{
		// Token: 0x0600D401 RID: 54273 RVA: 0x001ECC18 File Offset: 0x001EAE18
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

		// Token: 0x0600D402 RID: 54274 RVA: 0x001ECC40 File Offset: 0x001EAE40
		public static EPhotographCameraTransform FromString(string name)
		{
			EPhotographCameraTransform result;
			if (!EPhotographCameraTransformExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhotographCameraTransform 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D403 RID: 54275 RVA: 0x001ECC69 File Offset: 0x001EAE69
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

		// Token: 0x0600D404 RID: 54276 RVA: 0x001ECC8E File Offset: 0x001EAE8E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Absolute"
			};
		}

		// Token: 0x0600D405 RID: 54277 RVA: 0x001ECC9E File Offset: 0x001EAE9E
		public static EPhotographCameraTransform[] GetValues()
		{
			return new EPhotographCameraTransform[1];
		}

		// Token: 0x0600D406 RID: 54278 RVA: 0x001ECCA6 File Offset: 0x001EAEA6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Absolute"
			};
		}
	}
}
