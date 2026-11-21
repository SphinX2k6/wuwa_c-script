using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003432 RID: 13362
	[NullableContext(1)]
	public interface INode
	{
		// Token: 0x1700469F RID: 18079
		// (get) Token: 0x06021EDC RID: 138972
		// (set) Token: 0x06021EDD RID: 138973
		ENodeType NodeType { get; set; }

		// Token: 0x170046A0 RID: 18080
		// (get) Token: 0x06021EDE RID: 138974
		// (set) Token: 0x06021EDF RID: 138975
		string Name { get; set; }

		// Token: 0x170046A1 RID: 18081
		// (get) Token: 0x06021EE0 RID: 138976
		// (set) Token: 0x06021EE1 RID: 138977
		TFormulaValue Value { get; set; }

		// Token: 0x170046A2 RID: 18082
		// (get) Token: 0x06021EE2 RID: 138978
		// (set) Token: 0x06021EE3 RID: 138979
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
