using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006171 RID: 24945
	public static class IWaySplineCommonPointVerify
	{
		// Token: 0x0602A606 RID: 173574 RVA: 0x005C8182 File Offset: 0x005C6382
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
