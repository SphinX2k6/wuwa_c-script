using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007060 RID: 28768
	public static class ISetRegionConfigVerify
	{
		// Token: 0x06032F07 RID: 208647 RVA: 0x006DF5AE File Offset: 0x006DD7AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
