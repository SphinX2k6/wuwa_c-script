using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006177 RID: 24951
	public static class IWaySplinePointTypeVerify
	{
		// Token: 0x0602A642 RID: 173634 RVA: 0x005C8AC2 File Offset: 0x005C6CC2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
