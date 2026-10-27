using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D0 RID: 22224
	public static class IPasserbyNpcSourceVerify
	{
		// Token: 0x06025203 RID: 152067 RVA: 0x00520042 File Offset: 0x0051E242
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
