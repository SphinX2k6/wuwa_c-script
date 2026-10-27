using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005822 RID: 22562
	public static class IRefreshContentVerify
	{
		// Token: 0x06025EFF RID: 155391 RVA: 0x0053B0F6 File Offset: 0x005392F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
