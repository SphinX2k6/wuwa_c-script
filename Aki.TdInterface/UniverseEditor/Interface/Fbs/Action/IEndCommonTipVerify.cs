using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066A1 RID: 26273
	public static class IEndCommonTipVerify
	{
		// Token: 0x0602DAA4 RID: 187044 RVA: 0x0063FB51 File Offset: 0x0063DD51
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
