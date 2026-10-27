using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200502F RID: 20527
	public static class IConveyorBeltFieldVerify
	{
		// Token: 0x06020E3E RID: 134718 RVA: 0x00492DAE File Offset: 0x00490FAE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
