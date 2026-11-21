using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002530 RID: 9520
	public static class EBlendAnimTypeExtensions
	{
		// Token: 0x0600CEB2 RID: 52914 RVA: 0x001DF788 File Offset: 0x001DD988
		public static string ToEnumString(this EBlendAnimType value)
		{
			string result;
			if (value != EBlendAnimType.StateMachine)
			{
				if (value != EBlendAnimType.AnimSequence)
				{
					result = value.ToString();
				}
				else
				{
					result = "AnimSequence";
				}
			}
			else
			{
				result = "SetStateMachine";
			}
			return result;
		}

		// Token: 0x0600CEB3 RID: 52915 RVA: 0x001DF7C0 File Offset: 0x001DD9C0
		public static EBlendAnimType FromString(string name)
		{
			EBlendAnimType result;
			if (!EBlendAnimTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBlendAnimType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CEB4 RID: 52916 RVA: 0x001DF7E9 File Offset: 0x001DD9E9
		public static bool TryFromString(string name, out EBlendAnimType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBlendAnimType.StateMachine;
				return false;
			}
			if (name == "SetStateMachine")
			{
				value = EBlendAnimType.StateMachine;
				return true;
			}
			if (!(name == "AnimSequence"))
			{
				value = EBlendAnimType.StateMachine;
				return false;
			}
			value = EBlendAnimType.AnimSequence;
			return true;
		}

		// Token: 0x0600CEB5 RID: 52917 RVA: 0x001DF822 File Offset: 0x001DDA22
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SetStateMachine",
				"AnimSequence"
			};
		}

		// Token: 0x0600CEB6 RID: 52918 RVA: 0x001DF83A File Offset: 0x001DDA3A
		public static EBlendAnimType[] GetValues()
		{
			return new EBlendAnimType[]
			{
				EBlendAnimType.StateMachine,
				EBlendAnimType.AnimSequence
			};
		}

		// Token: 0x0600CEB7 RID: 52919 RVA: 0x001DF846 File Offset: 0x001DDA46
		public static string[] GetNames()
		{
			return new string[]
			{
				"StateMachine",
				"AnimSequence"
			};
		}
	}
}
