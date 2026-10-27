using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000986 RID: 2438
	public static class ELevelAIBehaviourTypeExtensions
	{
		// Token: 0x0600368C RID: 13964 RVA: 0x0008E224 File Offset: 0x0008C424
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

		// Token: 0x0600368D RID: 13965 RVA: 0x0008E25C File Offset: 0x0008C45C
		public static ELevelAIBehaviourType FromString(string name)
		{
			ELevelAIBehaviourType result;
			if (!ELevelAIBehaviourTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELevelAIBehaviourType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x0008E285 File Offset: 0x0008C485
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

		// Token: 0x0600368F RID: 13967 RVA: 0x0008E2BE File Offset: 0x0008C4BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Spline",
				"Actions"
			};
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x0008E2D6 File Offset: 0x0008C4D6
		public static ELevelAIBehaviourType[] GetValues()
		{
			return new ELevelAIBehaviourType[]
			{
				ELevelAIBehaviourType.Spline,
				ELevelAIBehaviourType.Actions
			};
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x0008E2E2 File Offset: 0x0008C4E2
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
