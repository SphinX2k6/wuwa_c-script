using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02005663 RID: 22115
	public static class EMorningSpecialAnimStateExtensions
	{
		// Token: 0x060369BC RID: 223676 RVA: 0x00F3D9F4 File Offset: 0x00F3BBF4
		public static string ToEnumString(this EMorningSpecialAnimState value)
		{
			string result;
			switch (value)
			{
			case EMorningSpecialAnimState.IdleNothingLeft:
				result = "idle_nothing_R";
				break;
			case EMorningSpecialAnimState.IdleNothingRight:
				result = "idle_nothing_L";
				break;
			case EMorningSpecialAnimState.WalkNothingLeft:
				result = "walk_nothing_R";
				break;
			case EMorningSpecialAnimState.WalkNothingRight:
				result = "walk_nothing_L";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060369BD RID: 223677 RVA: 0x00F3DA48 File Offset: 0x00F3BC48
		public static EMorningSpecialAnimState FromString(string name)
		{
			EMorningSpecialAnimState result;
			if (!EMorningSpecialAnimStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMorningSpecialAnimState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060369BE RID: 223678 RVA: 0x00F3DA74 File Offset: 0x00F3BC74
		public static bool TryFromString(string name, out EMorningSpecialAnimState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMorningSpecialAnimState.IdleNothingLeft;
				return false;
			}
			if (name == "idle_nothing_R")
			{
				value = EMorningSpecialAnimState.IdleNothingLeft;
				return true;
			}
			if (name == "idle_nothing_L")
			{
				value = EMorningSpecialAnimState.IdleNothingRight;
				return true;
			}
			if (name == "walk_nothing_R")
			{
				value = EMorningSpecialAnimState.WalkNothingLeft;
				return true;
			}
			if (!(name == "walk_nothing_L"))
			{
				value = EMorningSpecialAnimState.IdleNothingLeft;
				return false;
			}
			value = EMorningSpecialAnimState.WalkNothingRight;
			return true;
		}

		// Token: 0x060369BF RID: 223679 RVA: 0x00F3DADC File Offset: 0x00F3BCDC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"idle_nothing_R",
				"idle_nothing_L",
				"walk_nothing_R",
				"walk_nothing_L"
			};
		}

		// Token: 0x060369C0 RID: 223680 RVA: 0x00F3DB04 File Offset: 0x00F3BD04
		public static EMorningSpecialAnimState[] GetValues()
		{
			return new EMorningSpecialAnimState[]
			{
				EMorningSpecialAnimState.IdleNothingLeft,
				EMorningSpecialAnimState.IdleNothingRight,
				EMorningSpecialAnimState.WalkNothingLeft,
				EMorningSpecialAnimState.WalkNothingRight
			};
		}

		// Token: 0x060369C1 RID: 223681 RVA: 0x00F3DB17 File Offset: 0x00F3BD17
		public static string[] GetNames()
		{
			return new string[]
			{
				"IdleNothingLeft",
				"IdleNothingRight",
				"WalkNothingLeft",
				"WalkNothingRight"
			};
		}
	}
}
