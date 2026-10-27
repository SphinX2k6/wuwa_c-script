using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004507 RID: 17671
	public class CachedAstEntry
	{
		// Token: 0x0401850A RID: 99594
		[Nullable(1)]
		public IAstNode Ast;

		// Token: 0x0401850B RID: 99595
		public int RefCount;
	}
}
