using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A39 RID: 2617
	public static class ELevelAIBehaviourTypeExtensions
	{
		// Token: 0x06003A13 RID: 14867 RVA: 0x00096190 File Offset: 0x00094390
		public static string ToEnumString(this ELevelAIBehaviourType value)
		{
			string result;
			if (value != ELevelAIBehaviourType.Spline)
			{
				if (value != ELevelAIBehaviourType.Actions)
				{
					result = value.ToString();
				}
				else
				{
					result = "Actions";
				}
			}
			else
			{
				result = "Spline";
			}
			return result;
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x000961C8 File Offset: 0x000943C8
		public static ELevelAIBehaviourType FromString(string name)
		{
			ELevelAIBehaviourType result;
			if (!ELevelAIBehaviourTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELevelAIBehaviourType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x000961F1 File Offset: 0x000943F1
		public static bool TryFromString(string name, out ELevelAIBehaviourType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELevelAIBehaviourType.Spline;
				return false;
			}
			if (name == "Spline")
			{
				value = ELevelAIBehaviourType.Spline;
				return true;
			}
			if (!(name == "Actions"))
			{
				value = ELevelAIBehaviourType.Spline;
				return false;
			}
			value = ELevelAIBehaviourType.Actions;
			return true;
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x0009622A File Offset: 0x0009442A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Spline",
				"Actions"
			};
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x00096242 File Offset: 0x00094442
		public static ELevelAIBehaviourType[] GetValues()
		{
			return new ELevelAIBehaviourType[]
			{
				ELevelAIBehaviourType.Spline,
				ELevelAIBehaviourType.Actions
			};
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x0009624E File Offset: 0x0009444E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Spline",
				"Actions"
			};
		}
	}
}
