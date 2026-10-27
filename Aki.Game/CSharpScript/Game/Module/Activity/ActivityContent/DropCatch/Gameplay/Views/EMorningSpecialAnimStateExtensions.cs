using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x02006713 RID: 26387
	public static class EMorningSpecialAnimStateExtensions
	{
		// Token: 0x06041E70 RID: 269936 RVA: 0x00FFC628 File Offset: 0x00FFA828
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

		// Token: 0x06041E71 RID: 269937 RVA: 0x00FFC67C File Offset: 0x00FFA87C
		public static EMorningSpecialAnimState FromString(string name)
		{
			EMorningSpecialAnimState result;
			if (!EMorningSpecialAnimStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMorningSpecialAnimState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06041E72 RID: 269938 RVA: 0x00FFC6A8 File Offset: 0x00FFA8A8
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

		// Token: 0x06041E73 RID: 269939 RVA: 0x00FFC710 File Offset: 0x00FFA910
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

		// Token: 0x06041E74 RID: 269940 RVA: 0x00FFC738 File Offset: 0x00FFA938
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

		// Token: 0x06041E75 RID: 269941 RVA: 0x00FFC74B File Offset: 0x00FFA94B
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
