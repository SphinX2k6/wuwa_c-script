using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025EE RID: 9710
	public static class ELiveDanmakuOperationTypeExtensions
	{
		// Token: 0x0600D209 RID: 53769 RVA: 0x001E8900 File Offset: 0x001E6B00
		public static string ToEnumString(this ELiveDanmakuOperationType value)
		{
			string result;
			switch (value)
			{
			case ELiveDanmakuOperationType.Load:
				result = "Load";
				break;
			case ELiveDanmakuOperationType.Unload:
				result = "Unload";
				break;
			case ELiveDanmakuOperationType.StartInteract:
				result = "StartInteract";
				break;
			case ELiveDanmakuOperationType.StopInteract:
				result = "StopInteract";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D20A RID: 53770 RVA: 0x001E8954 File Offset: 0x001E6B54
		public static ELiveDanmakuOperationType FromString(string name)
		{
			ELiveDanmakuOperationType result;
			if (!ELiveDanmakuOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELiveDanmakuOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D20B RID: 53771 RVA: 0x001E8980 File Offset: 0x001E6B80
		public static bool TryFromString(string name, out ELiveDanmakuOperationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELiveDanmakuOperationType.Load;
				return false;
			}
			if (name == "Load")
			{
				value = ELiveDanmakuOperationType.Load;
				return true;
			}
			if (name == "Unload")
			{
				value = ELiveDanmakuOperationType.Unload;
				return true;
			}
			if (name == "StartInteract")
			{
				value = ELiveDanmakuOperationType.StartInteract;
				return true;
			}
			if (!(name == "StopInteract"))
			{
				value = ELiveDanmakuOperationType.Load;
				return false;
			}
			value = ELiveDanmakuOperationType.StopInteract;
			return true;
		}

		// Token: 0x0600D20C RID: 53772 RVA: 0x001E89E8 File Offset: 0x001E6BE8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Load",
				"Unload",
				"StartInteract",
				"StopInteract"
			};
		}

		// Token: 0x0600D20D RID: 53773 RVA: 0x001E8A10 File Offset: 0x001E6C10
		public static ELiveDanmakuOperationType[] GetValues()
		{
			return new ELiveDanmakuOperationType[]
			{
				ELiveDanmakuOperationType.Load,
				ELiveDanmakuOperationType.Unload,
				ELiveDanmakuOperationType.StartInteract,
				ELiveDanmakuOperationType.StopInteract
			};
		}

		// Token: 0x0600D20E RID: 53774 RVA: 0x001E8A23 File Offset: 0x001E6C23
		public static string[] GetNames()
		{
			return new string[]
			{
				"Load",
				"Unload",
				"StartInteract",
				"StopInteract"
			};
		}
	}
}
