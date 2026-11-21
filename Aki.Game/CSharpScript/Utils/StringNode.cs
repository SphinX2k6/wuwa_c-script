using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003421 RID: 13345
	[NullableContext(1)]
	[Nullable(0)]
	public class StringNode : IAstNode, IStringNode
	{
		// Token: 0x17004686 RID: 18054
		// (get) Token: 0x06021E79 RID: 138873 RVA: 0x0096F9A5 File Offset: 0x0096DBA5
		// (set) Token: 0x06021E7A RID: 138874 RVA: 0x0096F9AD File Offset: 0x0096DBAD
		public EAstNodeType NodeType { get; set; }

		// Token: 0x17004687 RID: 18055
		// (get) Token: 0x06021E7B RID: 138875 RVA: 0x0096F9B6 File Offset: 0x0096DBB6
		// (set) Token: 0x06021E7C RID: 138876 RVA: 0x0096F9BE File Offset: 0x0096DBBE
		public string Value { get; set; }
	}
}
