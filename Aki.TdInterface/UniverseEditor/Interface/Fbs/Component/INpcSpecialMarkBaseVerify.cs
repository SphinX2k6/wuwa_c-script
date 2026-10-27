using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200564F RID: 22095
	public static class INpcSpecialMarkBaseVerify
	{
		// Token: 0x06024BB6 RID: 150454 RVA: 0x005118EE File Offset: 0x0050FAEE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
