using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E5B RID: 24155
	public static class IRenderSpecifiedRangeTypeVerify
	{
		// Token: 0x06028626 RID: 165414 RVA: 0x00585BA6 File Offset: 0x00583DA6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
