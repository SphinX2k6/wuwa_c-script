using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B25 RID: 15141
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class TetrominoConfig : ITetrominoConfig
	{
		// Token: 0x17004FDF RID: 20447
		// (get) Token: 0x06026ED0 RID: 159440 RVA: 0x00AE53AD File Offset: 0x00AE35AD
		// (set) Token: 0x06026ED1 RID: 159441 RVA: 0x00AE53B5 File Offset: 0x00AE35B5
		[RequiredMember]
		public string ShapeName { get; set; }

		// Token: 0x17004FE0 RID: 20448
		// (get) Token: 0x06026ED2 RID: 159442 RVA: 0x00AE53BE File Offset: 0x00AE35BE
		// (set) Token: 0x06026ED3 RID: 159443 RVA: 0x00AE53C6 File Offset: 0x00AE35C6
		[RequiredMember]
		public SlidingBlocksDefine.ETetrominoType Type { get; set; }

		// Token: 0x17004FE1 RID: 20449
		// (get) Token: 0x06026ED4 RID: 159444 RVA: 0x00AE53CF File Offset: 0x00AE35CF
		// (set) Token: 0x06026ED5 RID: 159445 RVA: 0x00AE53D7 File Offset: 0x00AE35D7
		[RequiredMember]
		public ITetrisBoard Board { get; set; }

		// Token: 0x06026ED6 RID: 159446 RVA: 0x00AE53E0 File Offset: 0x00AE35E0
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public TetrominoConfig()
		{
		}
	}
}
