using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013BC RID: 5052
	public static class ERhythmSpaceshipConditionStepExtensions
	{
		// Token: 0x06007128 RID: 28968 RVA: 0x0010DF38 File Offset: 0x0010C138
		public static string ToEnumString(this ERhythmSpaceshipConditionStep value)
		{
			string result;
			if (value == ERhythmSpaceshipConditionStep.Interact)
			{
				result = "Interact";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06007129 RID: 28969 RVA: 0x0010DF60 File Offset: 0x0010C160
		public static ERhythmSpaceshipConditionStep FromString(string name)
		{
			ERhythmSpaceshipConditionStep result;
			if (!ERhythmSpaceshipConditionStepExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERhythmSpaceshipConditionStep 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600712A RID: 28970 RVA: 0x0010DF89 File Offset: 0x0010C189
		public static bool TryFromString(string name, out ERhythmSpaceshipConditionStep value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERhythmSpaceshipConditionStep.Interact;
				return false;
			}
			if (name == "Interact")
			{
				value = ERhythmSpaceshipConditionStep.Interact;
				return true;
			}
			value = ERhythmSpaceshipConditionStep.Interact;
			return false;
		}

		// Token: 0x0600712B RID: 28971 RVA: 0x0010DFAE File Offset: 0x0010C1AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Interact"
			};
		}

		// Token: 0x0600712C RID: 28972 RVA: 0x0010DFBE File Offset: 0x0010C1BE
		public static ERhythmSpaceshipConditionStep[] GetValues()
		{
			return new ERhythmSpaceshipConditionStep[1];
		}

		// Token: 0x0600712D RID: 28973 RVA: 0x0010DFC6 File Offset: 0x0010C1C6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Interact"
			};
		}
	}
}
