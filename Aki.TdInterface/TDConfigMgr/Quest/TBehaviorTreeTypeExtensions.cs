using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001406 RID: 5126
	public static class TBehaviorTreeTypeExtensions
	{
		// Token: 0x06007275 RID: 29301 RVA: 0x00111EE8 File Offset: 0x001100E8
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

		// Token: 0x06007276 RID: 29302 RVA: 0x00111F30 File Offset: 0x00110130
		public static TBehaviorTreeType FromString(string name)
		{
			TBehaviorTreeType result;
			if (!TBehaviorTreeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 TBehaviorTreeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x00111F5C File Offset: 0x0011015C
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

		// Token: 0x06007278 RID: 29304 RVA: 0x00111FB2 File Offset: 0x001101B2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BehaviorTreeFragment",
				"LevelPlay",
				"Quest"
			};
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x00111FD2 File Offset: 0x001101D2
		public static TBehaviorTreeType[] GetValues()
		{
			return new TBehaviorTreeType[]
			{
				TBehaviorTreeType.BehaviorTreeFragment,
				TBehaviorTreeType.LevelPlay,
				TBehaviorTreeType.Quest
			};
		}

		// Token: 0x0600727A RID: 29306 RVA: 0x00111FE2 File Offset: 0x001101E2
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
