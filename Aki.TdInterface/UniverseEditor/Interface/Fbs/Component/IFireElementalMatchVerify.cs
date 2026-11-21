using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C8 RID: 22472
	public static class IFireElementalMatchVerify
	{
		// Token: 0x06024478 RID: 148600 RVA: 0x004FC426 File Offset: 0x004FA626
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
