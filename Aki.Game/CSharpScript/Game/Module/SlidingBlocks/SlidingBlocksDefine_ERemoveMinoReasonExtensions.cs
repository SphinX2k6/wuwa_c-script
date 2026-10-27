using System;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B8A RID: 19338
	public static class SlidingBlocksDefine_ERemoveMinoReasonExtensions
	{
		// Token: 0x060321EF RID: 205295 RVA: 0x00BA4518 File Offset: 0x00BA2718
		public static string ToEnumString(this SlidingBlocksDefine.ERemoveMinoReason value)
		{
			string result;
			if (value != SlidingBlocksDefine.ERemoveMinoReason.LineClearFall)
			{
				if (value != SlidingBlocksDefine.ERemoveMinoReason.LineClear)
				{
					result = value.ToString();
				}
				else
				{
					result = "LineClear";
				}
			}
			else
			{
				result = "LineClearFall";
			}
			return result;
		}

		// Token: 0x060321F0 RID: 205296 RVA: 0x00BA4550 File Offset: 0x00BA2750
		public static SlidingBlocksDefine.ERemoveMinoReason FromString(string name)
		{
			SlidingBlocksDefine.ERemoveMinoReason result;
			if (!SlidingBlocksDefine_ERemoveMinoReasonExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 SlidingBlocksDefine.ERemoveMinoReason 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060321F1 RID: 205297 RVA: 0x00BA4579 File Offset: 0x00BA2779
		public static bool TryFromString(string name, out SlidingBlocksDefine.ERemoveMinoReason value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = SlidingBlocksDefine.ERemoveMinoReason.LineClearFall;
				return false;
			}
			if (name == "LineClearFall")
			{
				value = SlidingBlocksDefine.ERemoveMinoReason.LineClearFall;
				return true;
			}
			if (!(name == "LineClear"))
			{
				value = SlidingBlocksDefine.ERemoveMinoReason.LineClearFall;
				return false;
			}
			value = SlidingBlocksDefine.ERemoveMinoReason.LineClear;
			return true;
		}

		// Token: 0x060321F2 RID: 205298 RVA: 0x00BA45B2 File Offset: 0x00BA27B2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LineClearFall",
				"LineClear"
			};
		}

		// Token: 0x060321F3 RID: 205299 RVA: 0x00BA45CA File Offset: 0x00BA27CA
		public static SlidingBlocksDefine.ERemoveMinoReason[] GetValues()
		{
			return new SlidingBlocksDefine.ERemoveMinoReason[]
			{
				SlidingBlocksDefine.ERemoveMinoReason.LineClearFall,
				SlidingBlocksDefine.ERemoveMinoReason.LineClear
			};
		}

		// Token: 0x060321F4 RID: 205300 RVA: 0x00BA45D6 File Offset: 0x00BA27D6
		public static string[] GetNames()
		{
			return new string[]
			{
				"LineClearFall",
				"LineClear"
			};
		}
	}
}
