using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020043A1 RID: 17313
	[NullableContext(2)]
	[Nullable(0)]
	public class MoraleTickPromiseParams
	{
		// Token: 0x04017920 RID: 96544
		public Action StartCallback;

		// Token: 0x04017921 RID: 96545
		public Action<float> TickCallback;

		// Token: 0x04017922 RID: 96546
		public Action EndCallback;
	}
}
