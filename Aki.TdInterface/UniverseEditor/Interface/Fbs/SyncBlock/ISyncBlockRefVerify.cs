using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B89 RID: 15241
	public static class ISyncBlockRefVerify
	{
		// Token: 0x06014E21 RID: 85537 RVA: 0x00307E5A File Offset: 0x0030605A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
