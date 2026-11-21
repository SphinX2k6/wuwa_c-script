using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x0200349D RID: 13469
	[NullableContext(1)]
	public interface IValidator
	{
		// Token: 0x17004842 RID: 18498
		// (get) Token: 0x0602253E RID: 140606
		Func<bool> Validate { get; }
	}
}
