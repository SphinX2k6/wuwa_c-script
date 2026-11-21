using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F85 RID: 32645
	public enum TPostAkEvent : byte
	{
		// Token: 0x04013964 RID: 80228
		NONE,
		// Token: 0x04013965 RID: 80229
		IPostAkEventGlobal,
		// Token: 0x04013966 RID: 80230
		IPostAkEventMap,
		// Token: 0x04013967 RID: 80231
		IPostAkEventMusicSubtitle,
		// Token: 0x04013968 RID: 80232
		IPostAkEventTargeted
	}
}
