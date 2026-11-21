using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007662 RID: 30306
	public static class IRogueActivatePortalVerify
	{
		// Token: 0x060352B9 RID: 217785 RVA: 0x00723352 File Offset: 0x00721552
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
