using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F7D RID: 28541
	public static class ISeqEventAddTagToSelfVerify
	{
		// Token: 0x060326D1 RID: 206545 RVA: 0x006CE7E9 File Offset: 0x006CC9E9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
