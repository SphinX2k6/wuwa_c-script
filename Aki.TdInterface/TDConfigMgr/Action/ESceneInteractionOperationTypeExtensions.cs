using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002694 RID: 9876
	public static class ESceneInteractionOperationTypeExtensions
	{
		// Token: 0x0600D4F4 RID: 54516 RVA: 0x001EEDA0 File Offset: 0x001ECFA0
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

		// Token: 0x0600D4F5 RID: 54517 RVA: 0x001EEDD8 File Offset: 0x001ECFD8
		public static ESceneInteractionOperationType FromString(string name)
		{
			ESceneInteractionOperationType result;
			if (!ESceneInteractionOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneInteractionOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D4F6 RID: 54518 RVA: 0x001EEE01 File Offset: 0x001ED001
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

		// Token: 0x0600D4F7 RID: 54519 RVA: 0x001EEE3A File Offset: 0x001ED03A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}

		// Token: 0x0600D4F8 RID: 54520 RVA: 0x001EEE52 File Offset: 0x001ED052
		public static ESceneInteractionOperationType[] GetValues()
		{
			return new ESceneInteractionOperationType[]
			{
				ESceneInteractionOperationType.Enable,
				ESceneInteractionOperationType.Disable
			};
		}

		// Token: 0x0600D4F9 RID: 54521 RVA: 0x001EEE5E File Offset: 0x001ED05E
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
