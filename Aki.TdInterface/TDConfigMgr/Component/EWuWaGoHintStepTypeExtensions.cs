using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A4C RID: 2636
	public static class EWuWaGoHintStepTypeExtensions
	{
		// Token: 0x06003A07 RID: 14855 RVA: 0x00095C48 File Offset: 0x00093E48
		public static string ToEnumString(this EWuWaGoHintStepType value)
		{
			string result;
			if (value != EWuWaGoHintStepType.Move)
			{
				if (value != EWuWaGoHintStepType.Interact)
				{
					result = value.ToString();
				}
				else
				{
					result = "Interact";
				}
			}
			else
			{
				result = "Move";
			}
			return result;
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x00095C80 File Offset: 0x00093E80
		public static EWuWaGoHintStepType FromString(string name)
		{
			EWuWaGoHintStepType result;
			if (!EWuWaGoHintStepTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWuWaGoHintStepType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A09 RID: 14857 RVA: 0x00095CA9 File Offset: 0x00093EA9
		public static bool TryFromString(string name, out EWuWaGoHintStepType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EWuWaGoHintStepType.Move;
				return false;
			}
			if (name == "Move")
			{
				value = EWuWaGoHintStepType.Move;
				return true;
			}
			if (!(name == "Interact"))
			{
				value = EWuWaGoHintStepType.Move;
				return false;
			}
			value = EWuWaGoHintStepType.Interact;
			return true;
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x00095CE2 File Offset: 0x00093EE2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Move",
				"Interact"
			};
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x00095CFA File Offset: 0x00093EFA
		public static EWuWaGoHintStepType[] GetValues()
		{
			return new EWuWaGoHintStepType[]
			{
				EWuWaGoHintStepType.Move,
				EWuWaGoHintStepType.Interact
			};
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x00095D06 File Offset: 0x00093F06
		public static string[] GetNames()
		{
			return new string[]
			{
				"Move",
				"Interact"
			};
		}
	}
}
