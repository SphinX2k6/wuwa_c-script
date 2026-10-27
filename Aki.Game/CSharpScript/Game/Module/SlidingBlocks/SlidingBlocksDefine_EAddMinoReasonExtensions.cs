using System;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B88 RID: 19336
	public static class SlidingBlocksDefine_EAddMinoReasonExtensions
	{
		// Token: 0x060321E6 RID: 205286 RVA: 0x00BA43C0 File Offset: 0x00BA25C0
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

		// Token: 0x060321E7 RID: 205287 RVA: 0x00BA4408 File Offset: 0x00BA2608
		public static SlidingBlocksDefine.EAddMinoReason FromString(string name)
		{
			SlidingBlocksDefine.EAddMinoReason result;
			if (!SlidingBlocksDefine_EAddMinoReasonExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 SlidingBlocksDefine.EAddMinoReason 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060321E8 RID: 205288 RVA: 0x00BA4434 File Offset: 0x00BA2634
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

		// Token: 0x060321E9 RID: 205289 RVA: 0x00BA448A File Offset: 0x00BA268A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LineClearFall",
				"CreatePresetMino",
				"TetrominoLock"
			};
		}

		// Token: 0x060321EA RID: 205290 RVA: 0x00BA44AA File Offset: 0x00BA26AA
		public static SlidingBlocksDefine.EAddMinoReason[] GetValues()
		{
			return new SlidingBlocksDefine.EAddMinoReason[]
			{
				SlidingBlocksDefine.EAddMinoReason.LineClearFall,
				SlidingBlocksDefine.EAddMinoReason.CreatePresetMino,
				SlidingBlocksDefine.EAddMinoReason.TetrominoLock
			};
		}

		// Token: 0x060321EB RID: 205291 RVA: 0x00BA44BA File Offset: 0x00BA26BA
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
