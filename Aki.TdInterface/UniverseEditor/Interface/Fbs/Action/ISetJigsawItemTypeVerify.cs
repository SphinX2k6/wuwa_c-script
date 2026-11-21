using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077DE RID: 30686
	public static class ISetJigsawItemTypeVerify
	{
		// Token: 0x06035E68 RID: 220776 RVA: 0x00738946 File Offset: 0x00736B46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
