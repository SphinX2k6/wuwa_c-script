using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060DB RID: 24795
	public static class ITrampleRayDetectionVerify
	{
		// Token: 0x06029FD7 RID: 171991 RVA: 0x005BB5DA File Offset: 0x005B97DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
