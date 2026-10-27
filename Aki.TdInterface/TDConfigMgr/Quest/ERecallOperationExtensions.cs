using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200127A RID: 4730
	public static class ERecallOperationExtensions
	{
		// Token: 0x06006ACC RID: 27340 RVA: 0x001001F8 File Offset: 0x000FE3F8
		public static string ToEnumString(this ERecallOperation value)
		{
			string result;
			if (value != ERecallOperation.Include)
			{
				if (value != ERecallOperation.Exclude)
				{
					result = value.ToString();
				}
				else
				{
					result = "Exclude";
				}
			}
			else
			{
				result = "Include";
			}
			return result;
		}

		// Token: 0x06006ACD RID: 27341 RVA: 0x00100230 File Offset: 0x000FE430
		public static ERecallOperation FromString(string name)
		{
			ERecallOperation result;
			if (!ERecallOperationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERecallOperation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x00100259 File Offset: 0x000FE459
		public static bool TryFromString(string name, out ERecallOperation value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERecallOperation.Include;
				return false;
			}
			if (name == "Include")
			{
				value = ERecallOperation.Include;
				return true;
			}
			if (!(name == "Exclude"))
			{
				value = ERecallOperation.Include;
				return false;
			}
			value = ERecallOperation.Exclude;
			return true;
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x00100292 File Offset: 0x000FE492
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Include",
				"Exclude"
			};
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x001002AA File Offset: 0x000FE4AA
		public static ERecallOperation[] GetValues()
		{
			return new ERecallOperation[]
			{
				ERecallOperation.Include,
				ERecallOperation.Exclude
			};
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x001002B6 File Offset: 0x000FE4B6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Include",
				"Exclude"
			};
		}
	}
}
