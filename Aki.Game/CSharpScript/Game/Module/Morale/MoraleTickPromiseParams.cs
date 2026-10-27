using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053BE RID: 21438
	[NullableContext(2)]
	[Nullable(0)]
	public class MoraleTickPromiseParams
	{
		// Token: 0x0401CE88 RID: 118408
		public Action StartCallback;

		// Token: 0x0401CE89 RID: 118409
		public Action<float> TickCallback;

		// Token: 0x0401CE8A RID: 118410
		public Action EndCallback;
	}
}
