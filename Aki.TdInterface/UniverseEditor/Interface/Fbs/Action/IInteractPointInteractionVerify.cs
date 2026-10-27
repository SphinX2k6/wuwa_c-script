using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A4 RID: 27044
	public static class IInteractPointInteractionVerify
	{
		// Token: 0x0602F40C RID: 193548 RVA: 0x0066FC6A File Offset: 0x0066DE6A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
