using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000962 RID: 2402
	public static class EHitLogicTypeExtensions
	{
		// Token: 0x060035EA RID: 13802 RVA: 0x0008C724 File Offset: 0x0008A924
		public static string ToEnumString(this EHitLogicType value)
		{
			string result;
			switch (value)
			{
			case EHitLogicType.ChangeNextState:
				result = "ChangeNextState";
				break;
			case EHitLogicType.ChangeCountDownState:
				result = "ChangeCountDownState";
				break;
			case EHitLogicType.ChangeLockState:
				result = "ChangeLockState";
				break;
			case EHitLogicType.ChangeNextAndLockTargetState:
				result = "ChangeNextAndLockTargetState";
				break;
			case EHitLogicType.ChangeTargetState:
				result = "ChangeTargetState";
				break;
			case EHitLogicType.ChangeByPartHit:
				result = "ChangeByPartHit";
				break;
			case EHitLogicType.ActionByHitType:
				result = "ActionByHitType";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x0008C79C File Offset: 0x0008A99C
		public static EHitLogicType FromString(string name)
		{
			EHitLogicType result;
			if (!EHitLogicTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHitLogicType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x0008C7C8 File Offset: 0x0008A9C8
		public static bool TryFromString(string name, out EHitLogicType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EHitLogicType.ChangeNextState;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				if (length <= 17)
				{
					if (length != 15)
					{
						if (length == 17)
						{
							if (name == "ChangeTargetState")
							{
								value = EHitLogicType.ChangeTargetState;
								return true;
							}
						}
					}
					else
					{
						char c = name[8];
						if (c <= 'P')
						{
							if (c != 'H')
							{
								if (c == 'P')
								{
									if (name == "ChangeByPartHit")
									{
										value = EHitLogicType.ChangeByPartHit;
										return true;
									}
								}
							}
							else if (name == "ActionByHitType")
							{
								value = EHitLogicType.ActionByHitType;
								return true;
							}
						}
						else if (c != 'c')
						{
							if (c == 'x')
							{
								if (name == "ChangeNextState")
								{
									value = EHitLogicType.ChangeNextState;
									return true;
								}
							}
						}
						else if (name == "ChangeLockState")
						{
							value = EHitLogicType.ChangeLockState;
							return true;
						}
					}
				}
				else if (length != 20)
				{
					if (length == 28)
					{
						if (name == "ChangeNextAndLockTargetState")
						{
							value = EHitLogicType.ChangeNextAndLockTargetState;
							return true;
						}
					}
				}
				else if (name == "ChangeCountDownState")
				{
					value = EHitLogicType.ChangeCountDownState;
					return true;
				}
			}
			value = EHitLogicType.ChangeNextState;
			return false;
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x0008C8CE File Offset: 0x0008AACE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChangeNextState",
				"ChangeCountDownState",
				"ChangeLockState",
				"ChangeNextAndLockTargetState",
				"ChangeTargetState",
				"ChangeByPartHit",
				"ActionByHitType"
			};
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x0008C90E File Offset: 0x0008AB0E
		public static EHitLogicType[] GetValues()
		{
			return new EHitLogicType[]
			{
				EHitLogicType.ChangeNextState,
				EHitLogicType.ChangeCountDownState,
				EHitLogicType.ChangeLockState,
				EHitLogicType.ChangeNextAndLockTargetState,
				EHitLogicType.ChangeTargetState,
				EHitLogicType.ChangeByPartHit,
				EHitLogicType.ActionByHitType
			};
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x0008C921 File Offset: 0x0008AB21
		public static string[] GetNames()
		{
			return new string[]
			{
				"ChangeNextState",
				"ChangeCountDownState",
				"ChangeLockState",
				"ChangeNextAndLockTargetState",
				"ChangeTargetState",
				"ChangeByPartHit",
				"ActionByHitType"
			};
		}
	}
}
