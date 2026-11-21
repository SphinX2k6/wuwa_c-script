using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B24 RID: 15140
	[NullableContext(1)]
	public interface ITetrominoConfig
	{
		// Token: 0x17004FDC RID: 20444
		// (get) Token: 0x06026ECA RID: 159434
		// (set) Token: 0x06026ECB RID: 159435
		string ShapeName { get; set; }

		// Token: 0x17004FDD RID: 20445
		// (get) Token: 0x06026ECC RID: 159436
		// (set) Token: 0x06026ECD RID: 159437
		SlidingBlocksDefine.ETetrominoType Type { get; set; }

		// Token: 0x17004FDE RID: 20446
		// (get) Token: 0x06026ECE RID: 159438
		// (set) Token: 0x06026ECF RID: 159439
		ITetrisBoard Board { get; set; }
	}
}
