using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A15 RID: 2581
	public static class EHitLogicTypeExtensions
	{
		// Token: 0x06003971 RID: 14705 RVA: 0x00094678 File Offset: 0x00092878
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

		// Token: 0x06003972 RID: 14706 RVA: 0x000946F0 File Offset: 0x000928F0
		public static EHitLogicType FromString(string name)
		{
			EHitLogicType result;
			if (!EHitLogicTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHitLogicType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x0009471C File Offset: 0x0009291C
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

		// Token: 0x06003974 RID: 14708 RVA: 0x00094822 File Offset: 0x00092A22
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

		// Token: 0x06003975 RID: 14709 RVA: 0x00094862 File Offset: 0x00092A62
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

		// Token: 0x06003976 RID: 14710 RVA: 0x00094875 File Offset: 0x00092A75
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
