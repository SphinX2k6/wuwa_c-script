using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005450 RID: 21584
	public static class IBossStateViewStyleVerify
	{
		// Token: 0x06021DFD RID: 138749 RVA: 0x004AB642 File Offset: 0x004A9842
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
