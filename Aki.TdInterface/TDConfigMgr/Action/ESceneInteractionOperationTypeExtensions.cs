using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023FD RID: 9213
	public static class ESceneInteractionOperationTypeExtensions
	{
		// Token: 0x0600C871 RID: 51313 RVA: 0x001D55F4 File Offset: 0x001D37F4
		public static string ToEnumString(this ESceneInteractionOperationType value)
		{
			string result;
			if (value != ESceneInteractionOperationType.Enable)
			{
				if (value != ESceneInteractionOperationType.Disable)
				{
					result = value.ToString();
				}
				else
				{
					result = "Disable";
				}
			}
			else
			{
				result = "Enable";
			}
			return result;
		}

		// Token: 0x0600C872 RID: 51314 RVA: 0x001D562C File Offset: 0x001D382C
		public static ESceneInteractionOperationType FromString(string name)
		{
			ESceneInteractionOperationType result;
			if (!ESceneInteractionOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneInteractionOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C873 RID: 51315 RVA: 0x001D5655 File Offset: 0x001D3855
		public static bool TryFromString(string name, out ESceneInteractionOperationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESceneInteractionOperationType.Enable;
				return false;
			}
			if (name == "Enable")
			{
				value = ESceneInteractionOperationType.Enable;
				return true;
			}
			if (!(name == "Disable"))
			{
				value = ESceneInteractionOperationType.Enable;
				return false;
			}
			value = ESceneInteractionOperationType.Disable;
			return true;
		}

		// Token: 0x0600C874 RID: 51316 RVA: 0x001D568E File Offset: 0x001D388E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}

		// Token: 0x0600C875 RID: 51317 RVA: 0x001D56A6 File Offset: 0x001D38A6
		public static ESceneInteractionOperationType[] GetValues()
		{
			return new ESceneInteractionOperationType[]
			{
				ESceneInteractionOperationType.Enable,
				ESceneInteractionOperationType.Disable
			};
		}

		// Token: 0x0600C876 RID: 51318 RVA: 0x001D56B2 File Offset: 0x001D38B2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}
	}
}
