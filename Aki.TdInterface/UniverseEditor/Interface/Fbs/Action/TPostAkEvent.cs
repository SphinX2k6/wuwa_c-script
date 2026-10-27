using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007759 RID: 30553
	public enum TPostAkEvent : byte
	{
		// Token: 0x040128C8 RID: 75976
		NONE,
		// Token: 0x040128C9 RID: 75977
		IPostAkEventGlobal,
		// Token: 0x040128CA RID: 75978
		IPostAkEventMap,
		// Token: 0x040128CB RID: 75979
		IPostAkEventMusicSubtitle,
		// Token: 0x040128CC RID: 75980
		IPostAkEventTargeted
	}
}
