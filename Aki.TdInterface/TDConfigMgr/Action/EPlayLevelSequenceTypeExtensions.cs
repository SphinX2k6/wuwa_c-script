using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023D5 RID: 9173
	public static class EPlayLevelSequenceTypeExtensions
	{
		// Token: 0x0600C7BD RID: 51133 RVA: 0x001D3D8C File Offset: 0x001D1F8C
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

		// Token: 0x0600C7BE RID: 51134 RVA: 0x001D3DE0 File Offset: 0x001D1FE0
		public static EPlayLevelSequenceType FromString(string name)
		{
			EPlayLevelSequenceType result;
			if (!EPlayLevelSequenceTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayLevelSequenceType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C7BF RID: 51135 RVA: 0x001D3E0C File Offset: 0x001D200C
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

		// Token: 0x0600C7C0 RID: 51136 RVA: 0x001D3E74 File Offset: 0x001D2074
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

		// Token: 0x0600C7C1 RID: 51137 RVA: 0x001D3E9C File Offset: 0x001D209C
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

		// Token: 0x0600C7C2 RID: 51138 RVA: 0x001D3EAF File Offset: 0x001D20AF
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
