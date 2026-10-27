using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004683 RID: 18051
	public static class IRecordCombatOperationCaptureCheckpointVerify
	{
		// Token: 0x0601B67E RID: 112254 RVA: 0x003E4F7A File Offset: 0x003E317A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
