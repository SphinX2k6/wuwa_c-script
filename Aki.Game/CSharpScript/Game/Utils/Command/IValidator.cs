using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x02004575 RID: 17781
	[NullableContext(1)]
	public interface IValidator
	{
		// Token: 0x1700758B RID: 30091
		// (get) Token: 0x0602DE5C RID: 187996
		Func<bool> Validate { get; }
	}
}
