using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005699 RID: 22169
	public static class IElementalMatchBaseVerify
	{
		// Token: 0x060237D3 RID: 145363 RVA: 0x004E1D12 File Offset: 0x004DFF12
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
