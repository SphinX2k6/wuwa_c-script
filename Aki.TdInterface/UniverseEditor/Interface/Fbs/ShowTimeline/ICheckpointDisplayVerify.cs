using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003B91 RID: 15249
	public static class ICheckpointDisplayVerify
	{
		// Token: 0x06014E33 RID: 85555 RVA: 0x00307FC2 File Offset: 0x003061C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
