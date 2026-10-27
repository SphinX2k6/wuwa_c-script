using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickTimeAction
{
	// Token: 0x02004F33 RID: 20275
	public class IQtaExtraParams
	{
		// Token: 0x0401B9F3 RID: 113139
		public long? MessageId;

		// Token: 0x0401B9F4 RID: 113140
		[Nullable(2)]
		public EntityHandle EntityHandle;

		// Token: 0x0401B9F5 RID: 113141
		public int? FromSkill;

		// Token: 0x0401B9F6 RID: 113142
		public bool? IsPendingExternalCompletion;
	}
}
