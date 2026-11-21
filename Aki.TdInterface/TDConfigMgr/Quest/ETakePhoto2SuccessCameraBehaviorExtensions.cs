using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013E0 RID: 5088
	public static class ETakePhoto2SuccessCameraBehaviorExtensions
	{
		// Token: 0x060071CA RID: 29130 RVA: 0x0010FF24 File Offset: 0x0010E124
		public static string ToEnumString(this ETakePhoto2SuccessCameraBehavior value)
		{
			string result;
			if (value != ETakePhoto2SuccessCameraBehavior.KeepOpen)
			{
				if (value != ETakePhoto2SuccessCameraBehavior.CloseAfterFinishActions)
				{
					result = value.ToString();
				}
				else
				{
					result = "CloseAfterFinishActions";
				}
			}
			else
			{
				result = "KeepOpen";
			}
			return result;
		}

		// Token: 0x060071CB RID: 29131 RVA: 0x0010FF5C File Offset: 0x0010E15C
		public static ETakePhoto2SuccessCameraBehavior FromString(string name)
		{
			ETakePhoto2SuccessCameraBehavior result;
			if (!ETakePhoto2SuccessCameraBehaviorExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETakePhoto2SuccessCameraBehavior 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060071CC RID: 29132 RVA: 0x0010FF85 File Offset: 0x0010E185
		public static bool TryFromString(string name, out ETakePhoto2SuccessCameraBehavior value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETakePhoto2SuccessCameraBehavior.KeepOpen;
				return false;
			}
			if (name == "KeepOpen")
			{
				value = ETakePhoto2SuccessCameraBehavior.KeepOpen;
				return true;
			}
			if (!(name == "CloseAfterFinishActions"))
			{
				value = ETakePhoto2SuccessCameraBehavior.KeepOpen;
				return false;
			}
			value = ETakePhoto2SuccessCameraBehavior.CloseAfterFinishActions;
			return true;
		}

		// Token: 0x060071CD RID: 29133 RVA: 0x0010FFBE File Offset: 0x0010E1BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"KeepOpen",
				"CloseAfterFinishActions"
			};
		}

		// Token: 0x060071CE RID: 29134 RVA: 0x0010FFD6 File Offset: 0x0010E1D6
		public static ETakePhoto2SuccessCameraBehavior[] GetValues()
		{
			return new ETakePhoto2SuccessCameraBehavior[]
			{
				ETakePhoto2SuccessCameraBehavior.KeepOpen,
				ETakePhoto2SuccessCameraBehavior.CloseAfterFinishActions
			};
		}

		// Token: 0x060071CF RID: 29135 RVA: 0x0010FFE2 File Offset: 0x0010E1E2
		public static string[] GetNames()
		{
			return new string[]
			{
				"KeepOpen",
				"CloseAfterFinishActions"
			};
		}
	}
}
