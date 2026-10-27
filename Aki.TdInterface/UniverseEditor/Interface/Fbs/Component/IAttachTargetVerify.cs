using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EBB RID: 20155
	public static class IAttachTargetVerify
	{
		// Token: 0x0601FBD9 RID: 130009 RVA: 0x0046B16A File Offset: 0x0046936A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
