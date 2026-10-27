using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200127C RID: 4732
	public static class ERhythmSpaceshipConditionStepExtensions
	{
		// Token: 0x06006AD5 RID: 27349 RVA: 0x0010030C File Offset: 0x000FE50C
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

		// Token: 0x06006AD6 RID: 27350 RVA: 0x00100334 File Offset: 0x000FE534
		public static ERhythmSpaceshipConditionStep FromString(string name)
		{
			ERhythmSpaceshipConditionStep result;
			if (!ERhythmSpaceshipConditionStepExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERhythmSpaceshipConditionStep 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x0010035D File Offset: 0x000FE55D
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

		// Token: 0x06006AD8 RID: 27352 RVA: 0x00100382 File Offset: 0x000FE582
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Interact"
			};
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x00100392 File Offset: 0x000FE592
		public static ERhythmSpaceshipConditionStep[] GetValues()
		{
			return new ERhythmSpaceshipConditionStep[1];
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x0010039A File Offset: 0x000FE59A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Interact"
			};
		}
	}
}
