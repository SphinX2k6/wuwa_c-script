using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E5 RID: 21477
	public static class IIgnoreEntityIdsCollisionVerify
	{
		// Token: 0x06023446 RID: 144454 RVA: 0x004E22ED File Offset: 0x004E04ED
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
