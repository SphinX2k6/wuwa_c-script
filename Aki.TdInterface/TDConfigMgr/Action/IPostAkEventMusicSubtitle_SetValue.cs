using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D3B RID: 7483
	[NullableContext(1)]
	[Nullable(0)]
	public class IPostAkEventMusicSubtitle_SetValue
	{
		// Token: 0x040060C1 RID: 24769
		public EPostAkEvent Type;

		// Token: 0x040060C2 RID: 24770
		public string MusicSubtitleGroupTag;

		// Token: 0x040060C3 RID: 24771
		public string AkEvent;

		// Token: 0x040060C4 RID: 24772
		public bool? IsLoop;

		// Token: 0x040060C5 RID: 24773
		public bool? IsEndAkEvent;
	}
}
