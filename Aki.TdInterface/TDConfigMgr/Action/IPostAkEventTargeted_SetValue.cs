using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D3D RID: 7485
	public class IPostAkEventTargeted_SetValue
	{
		// Token: 0x040060C8 RID: 24776
		public EPostAkEvent Type;

		// Token: 0x040060C9 RID: 24777
		public int EntityId;

		// Token: 0x040060CA RID: 24778
		[Nullable(1)]
		public string AkEvent;
	}
}
