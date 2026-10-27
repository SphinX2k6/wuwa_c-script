using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066CA RID: 26314
	public static class EDropCatchRoleAnimStateExtensions
	{
		// Token: 0x06041CE0 RID: 269536 RVA: 0x00FF5B1C File Offset: 0x00FF3D1C
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

		// Token: 0x06041CE1 RID: 269537 RVA: 0x00FF5BA0 File Offset: 0x00FF3DA0
		public static EDropCatchRoleAnimState FromString(string name)
		{
			EDropCatchRoleAnimState result;
			if (!EDropCatchRoleAnimStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchRoleAnimState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06041CE2 RID: 269538 RVA: 0x00FF5BCC File Offset: 0x00FF3DCC
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

		// Token: 0x06041CE3 RID: 269539 RVA: 0x00FF5CCC File Offset: 0x00FF3ECC
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

		// Token: 0x06041CE4 RID: 269540 RVA: 0x00FF5D1F File Offset: 0x00FF3F1F
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

		// Token: 0x06041CE5 RID: 269541 RVA: 0x00FF5D34 File Offset: 0x00FF3F34
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
