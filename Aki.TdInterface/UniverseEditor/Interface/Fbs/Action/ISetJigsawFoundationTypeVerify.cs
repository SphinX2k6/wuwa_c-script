using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200700C RID: 28684
	public static class ISetJigsawFoundationTypeVerify
	{
		// Token: 0x06032BD2 RID: 207826 RVA: 0x006D8892 File Offset: 0x006D6A92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
