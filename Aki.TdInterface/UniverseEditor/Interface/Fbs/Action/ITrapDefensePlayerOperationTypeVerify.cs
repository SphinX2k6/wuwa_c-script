using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C5B RID: 31835
	public static class ITrapDefensePlayerOperationTypeVerify
	{
		// Token: 0x06039622 RID: 235042 RVA: 0x007BF3DA File Offset: 0x007BD5DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
