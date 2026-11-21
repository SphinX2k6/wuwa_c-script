using System;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B32 RID: 15154
	public static class SlidingBlocksDefine_EAddMinoReasonExtensions
	{
		// Token: 0x06026F76 RID: 159606 RVA: 0x00AE850C File Offset: 0x00AE670C
		public static string ToEnumString(this SlidingBlocksDefine.EAddMinoReason value)
		{
			string result;
			switch (value)
			{
			case SlidingBlocksDefine.EAddMinoReason.LineClearFall:
				result = "LineClearFall";
				break;
			case SlidingBlocksDefine.EAddMinoReason.CreatePresetMino:
				result = "CreatePresetMino";
				break;
			case SlidingBlocksDefine.EAddMinoReason.TetrominoLock:
				result = "TetrominoLock";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06026F77 RID: 159607 RVA: 0x00AE8554 File Offset: 0x00AE6754
		public static SlidingBlocksDefine.EAddMinoReason FromString(string name)
		{
			SlidingBlocksDefine.EAddMinoReason result;
			if (!SlidingBlocksDefine_EAddMinoReasonExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 SlidingBlocksDefine.EAddMinoReason 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06026F78 RID: 159608 RVA: 0x00AE8580 File Offset: 0x00AE6780
		public static bool TryFromString(string name, out SlidingBlocksDefine.EAddMinoReason value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = SlidingBlocksDefine.EAddMinoReason.LineClearFall;
				return false;
			}
			if (name == "LineClearFall")
			{
				value = SlidingBlocksDefine.EAddMinoReason.LineClearFall;
				return true;
			}
			if (name == "CreatePresetMino")
			{
				value = SlidingBlocksDefine.EAddMinoReason.CreatePresetMino;
				return true;
			}
			if (!(name == "TetrominoLock"))
			{
				value = SlidingBlocksDefine.EAddMinoReason.LineClearFall;
				return false;
			}
			value = SlidingBlocksDefine.EAddMinoReason.TetrominoLock;
			return true;
		}

		// Token: 0x06026F79 RID: 159609 RVA: 0x00AE85D6 File Offset: 0x00AE67D6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LineClearFall",
				"CreatePresetMino",
				"TetrominoLock"
			};
		}

		// Token: 0x06026F7A RID: 159610 RVA: 0x00AE85F6 File Offset: 0x00AE67F6
		public static SlidingBlocksDefine.EAddMinoReason[] GetValues()
		{
			return new SlidingBlocksDefine.EAddMinoReason[]
			{
				SlidingBlocksDefine.EAddMinoReason.LineClearFall,
				SlidingBlocksDefine.EAddMinoReason.CreatePresetMino,
				SlidingBlocksDefine.EAddMinoReason.TetrominoLock
			};
		}

		// Token: 0x06026F7B RID: 159611 RVA: 0x00AE8606 File Offset: 0x00AE6806
		public static string[] GetNames()
		{
			return new string[]
			{
				"LineClearFall",
				"CreatePresetMino",
				"TetrominoLock"
			};
		}
	}
}
