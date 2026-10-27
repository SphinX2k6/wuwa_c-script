using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EB0 RID: 16048
	public static class IInformationViewTypeVerify
	{
		// Token: 0x06016AA4 RID: 92836 RVA: 0x00345CAA File Offset: 0x00343EAA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
