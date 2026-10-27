using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050D4 RID: 20692
	public static class IDynamicAttachTargetVerify
	{
		// Token: 0x060214A6 RID: 136358 RVA: 0x0049FA06 File Offset: 0x0049DC06
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
