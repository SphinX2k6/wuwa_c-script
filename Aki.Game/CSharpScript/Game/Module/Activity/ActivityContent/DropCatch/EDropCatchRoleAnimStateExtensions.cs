using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x0200561A RID: 22042
	public static class EDropCatchRoleAnimStateExtensions
	{
		// Token: 0x0603682C RID: 223276 RVA: 0x00F36F20 File Offset: 0x00F35120
		public static string ToEnumString(this EDropCatchRoleAnimState value)
		{
			string result;
			switch (value)
			{
			case EDropCatchRoleAnimState.IdleBowlLeft:
				result = "idle_bowl_R";
				break;
			case EDropCatchRoleAnimState.IdleBowlRight:
				result = "idle_bowl_L";
				break;
			case EDropCatchRoleAnimState.WalkBowlLeft:
				result = "walk_bowl_R";
				break;
			case EDropCatchRoleAnimState.WalkBowlRight:
				result = "walk_bowl_L";
				break;
			case EDropCatchRoleAnimState.IdleLeft:
				result = "idle_R";
				break;
			case EDropCatchRoleAnimState.IdleRight:
				result = "idle_L";
				break;
			case EDropCatchRoleAnimState.WalkLeft:
				result = "walk_R";
				break;
			case EDropCatchRoleAnimState.WalkRight:
				result = "walk_L";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0603682D RID: 223277 RVA: 0x00F36FA4 File Offset: 0x00F351A4
		public static EDropCatchRoleAnimState FromString(string name)
		{
			EDropCatchRoleAnimState result;
			if (!EDropCatchRoleAnimStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchRoleAnimState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603682E RID: 223278 RVA: 0x00F36FD0 File Offset: 0x00F351D0
		public static bool TryFromString(string name, out EDropCatchRoleAnimState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDropCatchRoleAnimState.IdleBowlLeft;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				if (length != 6)
				{
					if (length == 11)
					{
						char c = name[0];
						if (c != 'i')
						{
							if (c == 'w')
							{
								if (name == "walk_bowl_R")
								{
									value = EDropCatchRoleAnimState.WalkBowlLeft;
									return true;
								}
								if (name == "walk_bowl_L")
								{
									value = EDropCatchRoleAnimState.WalkBowlRight;
									return true;
								}
							}
						}
						else
						{
							if (name == "idle_bowl_R")
							{
								value = EDropCatchRoleAnimState.IdleBowlLeft;
								return true;
							}
							if (name == "idle_bowl_L")
							{
								value = EDropCatchRoleAnimState.IdleBowlRight;
								return true;
							}
						}
					}
				}
				else
				{
					char c = name[0];
					if (c != 'i')
					{
						if (c == 'w')
						{
							if (name == "walk_R")
							{
								value = EDropCatchRoleAnimState.WalkLeft;
								return true;
							}
							if (name == "walk_L")
							{
								value = EDropCatchRoleAnimState.WalkRight;
								return true;
							}
						}
					}
					else
					{
						if (name == "idle_R")
						{
							value = EDropCatchRoleAnimState.IdleLeft;
							return true;
						}
						if (name == "idle_L")
						{
							value = EDropCatchRoleAnimState.IdleRight;
							return true;
						}
					}
				}
			}
			value = EDropCatchRoleAnimState.IdleBowlLeft;
			return false;
		}

		// Token: 0x0603682F RID: 223279 RVA: 0x00F370D0 File Offset: 0x00F352D0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"idle_bowl_R",
				"idle_bowl_L",
				"walk_bowl_R",
				"walk_bowl_L",
				"idle_R",
				"idle_L",
				"walk_R",
				"walk_L"
			};
		}

		// Token: 0x06036830 RID: 223280 RVA: 0x00F37123 File Offset: 0x00F35323
		public static EDropCatchRoleAnimState[] GetValues()
		{
			return new EDropCatchRoleAnimState[]
			{
				EDropCatchRoleAnimState.IdleBowlLeft,
				EDropCatchRoleAnimState.IdleBowlRight,
				EDropCatchRoleAnimState.WalkBowlLeft,
				EDropCatchRoleAnimState.WalkBowlRight,
				EDropCatchRoleAnimState.IdleLeft,
				EDropCatchRoleAnimState.IdleRight,
				EDropCatchRoleAnimState.WalkLeft,
				EDropCatchRoleAnimState.WalkRight
			};
		}

		// Token: 0x06036831 RID: 223281 RVA: 0x00F37138 File Offset: 0x00F35338
		public static string[] GetNames()
		{
			return new string[]
			{
				"IdleBowlLeft",
				"IdleBowlRight",
				"WalkBowlLeft",
				"WalkBowlRight",
				"IdleLeft",
				"IdleRight",
				"WalkLeft",
				"WalkRight"
			};
		}
	}
}
