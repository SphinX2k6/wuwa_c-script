using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025EC RID: 9708
	public static class ELiveDanmakuLoopTypeExtensions
	{
		// Token: 0x0600D200 RID: 53760 RVA: 0x001E87EC File Offset: 0x001E69EC
		public static string ToEnumString(this ELiveDanmakuLoopType value)
		{
			string result;
			if (value != ELiveDanmakuLoopType.OrderOnce)
			{
				if (value != ELiveDanmakuLoopType.RandomLoop)
				{
					result = value.ToString();
				}
				else
				{
					result = "RandomLoop";
				}
			}
			else
			{
				result = "OrderOnce";
			}
			return result;
		}

		// Token: 0x0600D201 RID: 53761 RVA: 0x001E8824 File Offset: 0x001E6A24
		public static ELiveDanmakuLoopType FromString(string name)
		{
			ELiveDanmakuLoopType result;
			if (!ELiveDanmakuLoopTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELiveDanmakuLoopType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D202 RID: 53762 RVA: 0x001E884D File Offset: 0x001E6A4D
		public static bool TryFromString(string name, out ELiveDanmakuLoopType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELiveDanmakuLoopType.OrderOnce;
				return false;
			}
			if (name == "OrderOnce")
			{
				value = ELiveDanmakuLoopType.OrderOnce;
				return true;
			}
			if (!(name == "RandomLoop"))
			{
				value = ELiveDanmakuLoopType.OrderOnce;
				return false;
			}
			value = ELiveDanmakuLoopType.RandomLoop;
			return true;
		}

		// Token: 0x0600D203 RID: 53763 RVA: 0x001E8886 File Offset: 0x001E6A86
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OrderOnce",
				"RandomLoop"
			};
		}

		// Token: 0x0600D204 RID: 53764 RVA: 0x001E889E File Offset: 0x001E6A9E
		public static ELiveDanmakuLoopType[] GetValues()
		{
			return new ELiveDanmakuLoopType[]
			{
				ELiveDanmakuLoopType.OrderOnce,
				ELiveDanmakuLoopType.RandomLoop
			};
		}

		// Token: 0x0600D205 RID: 53765 RVA: 0x001E88AA File Offset: 0x001E6AAA
		public static string[] GetNames()
		{
			return new string[]
			{
				"OrderOnce",
				"RandomLoop"
			};
		}
	}
}
