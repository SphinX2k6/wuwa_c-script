using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200266C RID: 9836
	public static class EPlayLevelSequenceTypeExtensions
	{
		// Token: 0x0600D440 RID: 54336 RVA: 0x001ED538 File Offset: 0x001EB738
		public static string ToEnumString(this EPlayLevelSequenceType value)
		{
			string result;
			switch (value)
			{
			case EPlayLevelSequenceType.Direct:
				result = "direct";
				break;
			case EPlayLevelSequenceType.ShortestPath:
				result = "shortestPath";
				break;
			case EPlayLevelSequenceType.Loop:
				result = "loop";
				break;
			case EPlayLevelSequenceType.Instant:
				result = "instant";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D441 RID: 54337 RVA: 0x001ED58C File Offset: 0x001EB78C
		public static EPlayLevelSequenceType FromString(string name)
		{
			EPlayLevelSequenceType result;
			if (!EPlayLevelSequenceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayLevelSequenceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D442 RID: 54338 RVA: 0x001ED5B8 File Offset: 0x001EB7B8
		public static bool TryFromString(string name, out EPlayLevelSequenceType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlayLevelSequenceType.Direct;
				return false;
			}
			if (name == "direct")
			{
				value = EPlayLevelSequenceType.Direct;
				return true;
			}
			if (name == "shortestPath")
			{
				value = EPlayLevelSequenceType.ShortestPath;
				return true;
			}
			if (name == "loop")
			{
				value = EPlayLevelSequenceType.Loop;
				return true;
			}
			if (!(name == "instant"))
			{
				value = EPlayLevelSequenceType.Direct;
				return false;
			}
			value = EPlayLevelSequenceType.Instant;
			return true;
		}

		// Token: 0x0600D443 RID: 54339 RVA: 0x001ED620 File Offset: 0x001EB820
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"direct",
				"shortestPath",
				"loop",
				"instant"
			};
		}

		// Token: 0x0600D444 RID: 54340 RVA: 0x001ED648 File Offset: 0x001EB848
		public static EPlayLevelSequenceType[] GetValues()
		{
			return new EPlayLevelSequenceType[]
			{
				EPlayLevelSequenceType.Direct,
				EPlayLevelSequenceType.ShortestPath,
				EPlayLevelSequenceType.Loop,
				EPlayLevelSequenceType.Instant
			};
		}

		// Token: 0x0600D445 RID: 54341 RVA: 0x001ED65B File Offset: 0x001EB85B
		public static string[] GetNames()
		{
			return new string[]
			{
				"Direct",
				"ShortestPath",
				"Loop",
				"Instant"
			};
		}
	}
}
