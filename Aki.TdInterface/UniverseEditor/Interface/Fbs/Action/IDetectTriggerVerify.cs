using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065C3 RID: 26051
	public static class IDetectTriggerVerify
	{
		// Token: 0x0602D2EB RID: 185067 RVA: 0x00631C6A File Offset: 0x0062FE6A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
