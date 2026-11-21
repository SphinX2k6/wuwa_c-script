using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AEB RID: 19179
	public static class IRecordCombatOperationCaptureCheckpointVerify
	{
		// Token: 0x0601CE53 RID: 118355 RVA: 0x00411216 File Offset: 0x0040F416
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
