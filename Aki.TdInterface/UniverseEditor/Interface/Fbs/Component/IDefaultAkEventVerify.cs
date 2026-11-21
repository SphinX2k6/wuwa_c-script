using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055DF RID: 21983
	public static class IDefaultAkEventVerify
	{
		// Token: 0x06022FC4 RID: 143300 RVA: 0x004D0732 File Offset: 0x004CE932
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
