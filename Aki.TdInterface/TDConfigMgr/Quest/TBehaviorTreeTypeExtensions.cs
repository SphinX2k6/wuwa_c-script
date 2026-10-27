using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012C0 RID: 4800
	public static class TBehaviorTreeTypeExtensions
	{
		// Token: 0x06006C07 RID: 27655 RVA: 0x00103F20 File Offset: 0x00102120
		public static string ToEnumString(this TBehaviorTreeType value)
		{
			string result;
			switch (value)
			{
			case TBehaviorTreeType.BehaviorTreeFragment:
				result = "BehaviorTreeFragment";
				break;
			case TBehaviorTreeType.LevelPlay:
				result = "LevelPlay";
				break;
			case TBehaviorTreeType.Quest:
				result = "Quest";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x00103F68 File Offset: 0x00102168
		public static TBehaviorTreeType FromString(string name)
		{
			TBehaviorTreeType result;
			if (!TBehaviorTreeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 TBehaviorTreeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x00103F94 File Offset: 0x00102194
		public static bool TryFromString(string name, out TBehaviorTreeType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = TBehaviorTreeType.BehaviorTreeFragment;
				return false;
			}
			if (name == "BehaviorTreeFragment")
			{
				value = TBehaviorTreeType.BehaviorTreeFragment;
				return true;
			}
			if (name == "LevelPlay")
			{
				value = TBehaviorTreeType.LevelPlay;
				return true;
			}
			if (!(name == "Quest"))
			{
				value = TBehaviorTreeType.BehaviorTreeFragment;
				return false;
			}
			value = TBehaviorTreeType.Quest;
			return true;
		}

		// Token: 0x06006C0A RID: 27658 RVA: 0x00103FEA File Offset: 0x001021EA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BehaviorTreeFragment",
				"LevelPlay",
				"Quest"
			};
		}

		// Token: 0x06006C0B RID: 27659 RVA: 0x0010400A File Offset: 0x0010220A
		public static TBehaviorTreeType[] GetValues()
		{
			return new TBehaviorTreeType[]
			{
				TBehaviorTreeType.BehaviorTreeFragment,
				TBehaviorTreeType.LevelPlay,
				TBehaviorTreeType.Quest
			};
		}

		// Token: 0x06006C0C RID: 27660 RVA: 0x0010401A File Offset: 0x0010221A
		public static string[] GetNames()
		{
			return new string[]
			{
				"BehaviorTreeFragment",
				"LevelPlay",
				"Quest"
			};
		}
	}
}
