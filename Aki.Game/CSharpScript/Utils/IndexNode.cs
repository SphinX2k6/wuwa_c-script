using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004506 RID: 17670
	[NullableContext(1)]
	[Nullable(0)]
	public class IndexNode : IAstNode, IIndexNode
	{
		// Token: 0x170073DF RID: 29663
		// (get) Token: 0x0602D7D2 RID: 186322 RVA: 0x00A43CEE File Offset: 0x00A41EEE
		// (set) Token: 0x0602D7D3 RID: 186323 RVA: 0x00A43CF6 File Offset: 0x00A41EF6
		public EAstNodeType NodeType { get; set; }

		// Token: 0x170073E0 RID: 29664
		// (get) Token: 0x0602D7D4 RID: 186324 RVA: 0x00A43CFF File Offset: 0x00A41EFF
		// (set) Token: 0x0602D7D5 RID: 186325 RVA: 0x00A43D07 File Offset: 0x00A41F07
		public IAstNode Value { get; set; }

		// Token: 0x170073E1 RID: 29665
		// (get) Token: 0x0602D7D6 RID: 186326 RVA: 0x00A43D10 File Offset: 0x00A41F10
		// (set) Token: 0x0602D7D7 RID: 186327 RVA: 0x00A43D18 File Offset: 0x00A41F18
		public IAstNode Index { get; set; }
	}
}
