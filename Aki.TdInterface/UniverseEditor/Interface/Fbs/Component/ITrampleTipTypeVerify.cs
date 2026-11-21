using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060DE RID: 24798
	public static class ITrampleTipTypeVerify
	{
		// Token: 0x06029FE9 RID: 172009 RVA: 0x005BB742 File Offset: 0x005B9942
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
