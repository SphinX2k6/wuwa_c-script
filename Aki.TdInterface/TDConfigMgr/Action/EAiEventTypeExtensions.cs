using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002508 RID: 9480
	public static class EAiEventTypeExtensions
	{
		// Token: 0x0600CDFE RID: 52734 RVA: 0x001DDDE0 File Offset: 0x001DBFE0
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

		// Token: 0x0600CDFF RID: 52735 RVA: 0x001DDE34 File Offset: 0x001DC034
		public static EAiEventType FromString(string name)
		{
			EAiEventType result;
			if (!EAiEventTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAiEventType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE00 RID: 52736 RVA: 0x001DDE60 File Offset: 0x001DC060
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

		// Token: 0x0600CE01 RID: 52737 RVA: 0x001DDEC8 File Offset: 0x001DC0C8
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

		// Token: 0x0600CE02 RID: 52738 RVA: 0x001DDEF0 File Offset: 0x001DC0F0
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

		// Token: 0x0600CE03 RID: 52739 RVA: 0x001DDF03 File Offset: 0x001DC103
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
