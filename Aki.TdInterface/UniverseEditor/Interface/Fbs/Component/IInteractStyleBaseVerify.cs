using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005478 RID: 21624
	public static class IInteractStyleBaseVerify
	{
		// Token: 0x06023926 RID: 145702 RVA: 0x004EB442 File Offset: 0x004E9642
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
