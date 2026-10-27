using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004802 RID: 18434
	public enum EActorDeleteMode : byte
	{
		// Token: 0x0400CCA9 RID: 52393
		AskUser,
		// Token: 0x0400CCAA RID: 52394
		DontAskUserAndDeleteChild,
		// Token: 0x0400CCAB RID: 52395
		DontAskUserAndNotDeleteChild
	}
}
