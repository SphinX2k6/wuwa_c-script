using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007743 RID: 30531
	public static class ISeqEventAddTagToSelfVerify
	{
		// Token: 0x06035921 RID: 219425 RVA: 0x0072E1A1 File Offset: 0x0072C3A1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
