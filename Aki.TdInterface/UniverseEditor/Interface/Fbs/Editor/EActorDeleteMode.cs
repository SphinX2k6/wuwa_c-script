using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C6A RID: 19562
	public enum EActorDeleteMode : byte
	{
		// Token: 0x0400D6E3 RID: 55011
		AskUser,
		// Token: 0x0400D6E4 RID: 55012
		DontAskUserAndDeleteChild,
		// Token: 0x0400D6E5 RID: 55013
		DontAskUserAndNotDeleteChild
	}
}
