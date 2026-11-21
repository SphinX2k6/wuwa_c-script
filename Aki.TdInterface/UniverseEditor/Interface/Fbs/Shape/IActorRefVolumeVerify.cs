using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FF7 RID: 16375
	public static class IActorRefVolumeVerify
	{
		// Token: 0x0601666E RID: 91758 RVA: 0x00335232 File Offset: 0x00333432
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
