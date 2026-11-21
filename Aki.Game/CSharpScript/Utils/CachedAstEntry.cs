using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003429 RID: 13353
	public class CachedAstEntry
	{
		// Token: 0x04012B32 RID: 76594
		[Nullable(1)]
		public IAstNode Ast;

		// Token: 0x04012B33 RID: 76595
		public int RefCount;
	}
}
