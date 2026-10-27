using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B79 RID: 23417
	public static class IWellStreamingRenderSelfConfigVerify
	{
		// Token: 0x0602815A RID: 164186 RVA: 0x00582A2E File Offset: 0x00580C2E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
