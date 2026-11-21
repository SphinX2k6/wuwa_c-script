using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B15 RID: 2837
	public static class EWuWaGoHintStepTypeExtensions
	{
		// Token: 0x06003DF1 RID: 15857 RVA: 0x0009E818 File Offset: 0x0009CA18
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

		// Token: 0x06003DF2 RID: 15858 RVA: 0x0009E850 File Offset: 0x0009CA50
		public static EWuWaGoHintStepType FromString(string name)
		{
			EWuWaGoHintStepType result;
			if (!EWuWaGoHintStepTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWuWaGoHintStepType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x0009E879 File Offset: 0x0009CA79
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

		// Token: 0x06003DF4 RID: 15860 RVA: 0x0009E8B2 File Offset: 0x0009CAB2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Move",
				"Interact"
			};
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x0009E8CA File Offset: 0x0009CACA
		public static EWuWaGoHintStepType[] GetValues()
		{
			return new EWuWaGoHintStepType[]
			{
				EWuWaGoHintStepType.Move,
				EWuWaGoHintStepType.Interact
			};
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x0009E8D6 File Offset: 0x0009CAD6
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
