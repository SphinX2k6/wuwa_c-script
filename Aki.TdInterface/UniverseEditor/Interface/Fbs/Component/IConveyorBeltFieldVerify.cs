using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200558E RID: 21902
	public static class IConveyorBeltFieldVerify
	{
		// Token: 0x06022D5E RID: 142686 RVA: 0x004CC7FE File Offset: 0x004CA9FE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
