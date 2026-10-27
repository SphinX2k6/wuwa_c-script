using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B7B RID: 19323
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class TetrominoConfig : ITetrominoConfig
	{
		// Token: 0x17007C35 RID: 31797
		// (get) Token: 0x0603213F RID: 205119 RVA: 0x00BA121D File Offset: 0x00B9F41D
		// (set) Token: 0x06032140 RID: 205120 RVA: 0x00BA1225 File Offset: 0x00B9F425
		[RequiredMember]
		public string ShapeName { get; set; }

		// Token: 0x17007C36 RID: 31798
		// (get) Token: 0x06032141 RID: 205121 RVA: 0x00BA122E File Offset: 0x00B9F42E
		// (set) Token: 0x06032142 RID: 205122 RVA: 0x00BA1236 File Offset: 0x00B9F436
		[RequiredMember]
		public SlidingBlocksDefine.ETetrominoType Type { get; set; }

		// Token: 0x17007C37 RID: 31799
		// (get) Token: 0x06032143 RID: 205123 RVA: 0x00BA123F File Offset: 0x00B9F43F
		// (set) Token: 0x06032144 RID: 205124 RVA: 0x00BA1247 File Offset: 0x00B9F447
		[RequiredMember]
		public ITetrisBoard Board { get; set; }

		// Token: 0x06032145 RID: 205125 RVA: 0x00BA1250 File Offset: 0x00B9F450
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public TetrominoConfig()
		{
		}
	}
}
