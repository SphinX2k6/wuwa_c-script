using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062C5 RID: 25285
	public static class IChangeActorMPCVerify
	{
		// Token: 0x0602BB38 RID: 179000 RVA: 0x00603B07 File Offset: 0x00601D07
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
