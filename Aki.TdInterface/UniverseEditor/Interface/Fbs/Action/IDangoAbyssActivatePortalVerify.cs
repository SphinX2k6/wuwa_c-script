using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200652A RID: 25898
	public static class IDangoAbyssActivatePortalVerify
	{
		// Token: 0x0602CEF3 RID: 184051 RVA: 0x0062BA9E File Offset: 0x00629C9E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
