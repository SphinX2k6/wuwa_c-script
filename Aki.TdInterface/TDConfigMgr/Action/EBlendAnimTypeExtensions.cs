using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022C1 RID: 8897
	public static class EBlendAnimTypeExtensions
	{
		// Token: 0x0600C2E3 RID: 49891 RVA: 0x001C7980 File Offset: 0x001C5B80
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

		// Token: 0x0600C2E4 RID: 49892 RVA: 0x001C79B8 File Offset: 0x001C5BB8
		public static EBlendAnimType FromString(string name)
		{
			EBlendAnimType result;
			if (!EBlendAnimTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBlendAnimType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C2E5 RID: 49893 RVA: 0x001C79E1 File Offset: 0x001C5BE1
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

		// Token: 0x0600C2E6 RID: 49894 RVA: 0x001C7A1A File Offset: 0x001C5C1A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SetStateMachine",
				"AnimSequence"
			};
		}

		// Token: 0x0600C2E7 RID: 49895 RVA: 0x001C7A32 File Offset: 0x001C5C32
		public static EBlendAnimType[] GetValues()
		{
			return new EBlendAnimType[]
			{
				EBlendAnimType.StateMachine,
				EBlendAnimType.AnimSequence
			};
		}

		// Token: 0x0600C2E8 RID: 49896 RVA: 0x001C7A3E File Offset: 0x001C5C3E
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
