using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069FB RID: 27131
	public static class ILifePointColorBoardVerify
	{
		// Token: 0x0602F7A0 RID: 194464 RVA: 0x00677525 File Offset: 0x00675725
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
