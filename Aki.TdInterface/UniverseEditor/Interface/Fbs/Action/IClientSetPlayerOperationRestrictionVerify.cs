using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063E7 RID: 25575
	public static class IClientSetPlayerOperationRestrictionVerify
	{
		// Token: 0x0602C3F4 RID: 181236 RVA: 0x00612D02 File Offset: 0x00610F02
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
