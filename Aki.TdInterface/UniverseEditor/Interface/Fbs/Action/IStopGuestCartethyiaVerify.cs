using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079A3 RID: 31139
	public static class IStopGuestCartethyiaVerify
	{
		// Token: 0x06036DEC RID: 224748 RVA: 0x00756BE2 File Offset: 0x00754DE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
