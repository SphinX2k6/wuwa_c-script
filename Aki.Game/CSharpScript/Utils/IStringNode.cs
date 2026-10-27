using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x020044F3 RID: 17651
	[NullableContext(1)]
	public interface IStringNode
	{
		// Token: 0x170073B6 RID: 29622
		// (get) Token: 0x0602D762 RID: 186210
		// (set) Token: 0x0602D763 RID: 186211
		EAstNodeType NodeType { get; set; }

		// Token: 0x170073B7 RID: 29623
		// (get) Token: 0x0602D764 RID: 186212
		// (set) Token: 0x0602D765 RID: 186213
		string Value { get; set; }
	}
}
