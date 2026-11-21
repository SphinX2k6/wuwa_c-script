using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006852 RID: 26706
	public static class IBasePos2Verify
	{
		// Token: 0x0602DA67 RID: 186983 RVA: 0x0063EA5A File Offset: 0x0063CC5A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
