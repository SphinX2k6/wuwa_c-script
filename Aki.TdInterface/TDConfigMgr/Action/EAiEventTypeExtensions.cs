using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200229B RID: 8859
	public static class EAiEventTypeExtensions
	{
		// Token: 0x0600C238 RID: 49720 RVA: 0x001C60EC File Offset: 0x001C42EC
		public static string ToEnumString(this EAiEventType value)
		{
			string result;
			switch (value)
			{
			case EAiEventType.CatAndDogPlayFlow:
				result = "CatAndDogPlayFlow";
				break;
			case EAiEventType.AnimalStandUp:
				result = "AnimalStandUp";
				break;
			case EAiEventType.AnimalSitDown:
				result = "AnimalSitDown";
				break;
			case EAiEventType.AnimalRandomAction:
				result = "AnimalRandomAction";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C239 RID: 49721 RVA: 0x001C6140 File Offset: 0x001C4340
		public static EAiEventType FromString(string name)
		{
			EAiEventType result;
			if (!EAiEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAiEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C23A RID: 49722 RVA: 0x001C616C File Offset: 0x001C436C
		public static bool TryFromString(string name, out EAiEventType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAiEventType.CatAndDogPlayFlow;
				return false;
			}
			if (name == "CatAndDogPlayFlow")
			{
				value = EAiEventType.CatAndDogPlayFlow;
				return true;
			}
			if (name == "AnimalStandUp")
			{
				value = EAiEventType.AnimalStandUp;
				return true;
			}
			if (name == "AnimalSitDown")
			{
				value = EAiEventType.AnimalSitDown;
				return true;
			}
			if (!(name == "AnimalRandomAction"))
			{
				value = EAiEventType.CatAndDogPlayFlow;
				return false;
			}
			value = EAiEventType.AnimalRandomAction;
			return true;
		}

		// Token: 0x0600C23B RID: 49723 RVA: 0x001C61D4 File Offset: 0x001C43D4
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CatAndDogPlayFlow",
				"AnimalStandUp",
				"AnimalSitDown",
				"AnimalRandomAction"
			};
		}

		// Token: 0x0600C23C RID: 49724 RVA: 0x001C61FC File Offset: 0x001C43FC
		public static EAiEventType[] GetValues()
		{
			return new EAiEventType[]
			{
				EAiEventType.CatAndDogPlayFlow,
				EAiEventType.AnimalStandUp,
				EAiEventType.AnimalSitDown,
				EAiEventType.AnimalRandomAction
			};
		}

		// Token: 0x0600C23D RID: 49725 RVA: 0x001C620F File Offset: 0x001C440F
		public static string[] GetNames()
		{
			return new string[]
			{
				"CatAndDogPlayFlow",
				"AnimalStandUp",
				"AnimalSitDown",
				"AnimalRandomAction"
			};
		}
	}
}
