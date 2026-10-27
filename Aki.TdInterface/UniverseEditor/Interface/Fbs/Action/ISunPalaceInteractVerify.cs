using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007240 RID: 29248
	public static class ISunPalaceInteractVerify
	{
		// Token: 0x06033E03 RID: 212483 RVA: 0x006FA9C6 File Offset: 0x006F8BC6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
