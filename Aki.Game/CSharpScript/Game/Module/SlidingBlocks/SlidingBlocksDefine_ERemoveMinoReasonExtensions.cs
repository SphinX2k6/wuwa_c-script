using System;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B34 RID: 15156
	public static class SlidingBlocksDefine_ERemoveMinoReasonExtensions
	{
		// Token: 0x06026F7F RID: 159615 RVA: 0x00AE8664 File Offset: 0x00AE6864
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

		// Token: 0x06026F80 RID: 159616 RVA: 0x00AE869C File Offset: 0x00AE689C
		public static SlidingBlocksDefine.ERemoveMinoReason FromString(string name)
		{
			SlidingBlocksDefine.ERemoveMinoReason result;
			if (!SlidingBlocksDefine_ERemoveMinoReasonExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 SlidingBlocksDefine.ERemoveMinoReason 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06026F81 RID: 159617 RVA: 0x00AE86C5 File Offset: 0x00AE68C5
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

		// Token: 0x06026F82 RID: 159618 RVA: 0x00AE86FE File Offset: 0x00AE68FE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LineClearFall",
				"LineClear"
			};
		}

		// Token: 0x06026F83 RID: 159619 RVA: 0x00AE8716 File Offset: 0x00AE6916
		public static SlidingBlocksDefine.ERemoveMinoReason[] GetValues()
		{
			return new SlidingBlocksDefine.ERemoveMinoReason[]
			{
				SlidingBlocksDefine.ERemoveMinoReason.LineClearFall,
				SlidingBlocksDefine.ERemoveMinoReason.LineClear
			};
		}

		// Token: 0x06026F84 RID: 159620 RVA: 0x00AE8722 File Offset: 0x00AE6922
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
