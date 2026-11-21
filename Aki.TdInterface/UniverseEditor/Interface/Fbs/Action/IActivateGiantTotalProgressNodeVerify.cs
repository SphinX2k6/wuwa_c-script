using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F3 RID: 26355
	public static class IActivateGiantTotalProgressNodeVerify
	{
		// Token: 0x0602CA06 RID: 182790 RVA: 0x0061B7AA File Offset: 0x006199AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
