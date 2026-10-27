using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B7A RID: 19322
	[NullableContext(1)]
	public interface ITetrominoConfig
	{
		// Token: 0x17007C32 RID: 31794
		// (get) Token: 0x06032139 RID: 205113
		// (set) Token: 0x0603213A RID: 205114
		string ShapeName { get; set; }

		// Token: 0x17007C33 RID: 31795
		// (get) Token: 0x0603213B RID: 205115
		// (set) Token: 0x0603213C RID: 205116
		SlidingBlocksDefine.ETetrominoType Type { get; set; }

		// Token: 0x17007C34 RID: 31796
		// (get) Token: 0x0603213D RID: 205117
		// (set) Token: 0x0603213E RID: 205118
		ITetrisBoard Board { get; set; }
	}
}
