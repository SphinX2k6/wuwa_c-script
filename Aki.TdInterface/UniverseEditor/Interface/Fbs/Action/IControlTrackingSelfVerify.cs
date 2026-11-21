using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B47 RID: 27463
	public static class IControlTrackingSelfVerify
	{
		// Token: 0x0602F429 RID: 193577 RVA: 0x00673B9A File Offset: 0x00671D9A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
