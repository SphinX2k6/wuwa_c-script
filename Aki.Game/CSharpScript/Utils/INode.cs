using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004510 RID: 17680
	[NullableContext(1)]
	public interface INode
	{
		// Token: 0x170073E7 RID: 29671
		// (get) Token: 0x0602D80C RID: 186380
		// (set) Token: 0x0602D80D RID: 186381
		ENodeType NodeType { get; set; }

		// Token: 0x170073E8 RID: 29672
		// (get) Token: 0x0602D80E RID: 186382
		// (set) Token: 0x0602D80F RID: 186383
		string Name { get; set; }

		// Token: 0x170073E9 RID: 29673
		// (get) Token: 0x0602D810 RID: 186384
		// (set) Token: 0x0602D811 RID: 186385
		TFormulaValue Value { get; set; }

		// Token: 0x170073EA RID: 29674
		// (get) Token: 0x0602D812 RID: 186386
		// (set) Token: 0x0602D813 RID: 186387
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<INode> Children { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
