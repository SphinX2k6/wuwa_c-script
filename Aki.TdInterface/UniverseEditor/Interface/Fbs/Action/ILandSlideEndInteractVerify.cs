using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069DD RID: 27101
	public static class ILandSlideEndInteractVerify
	{
		// Token: 0x0602F604 RID: 194052 RVA: 0x00673782 File Offset: 0x00671982
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
