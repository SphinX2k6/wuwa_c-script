using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickTimeAction
{
	// Token: 0x02003EFC RID: 16124
	public class IQtaExtraParams
	{
		// Token: 0x040163C8 RID: 91080
		public long? MessageId;

		// Token: 0x040163C9 RID: 91081
		[Nullable(2)]
		public EntityHandle EntityHandle;

		// Token: 0x040163CA RID: 91082
		public int? FromSkill;

		// Token: 0x040163CB RID: 91083
		public bool? IsPendingExternalCompletion;
	}
}
