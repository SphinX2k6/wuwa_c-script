using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047BF RID: 18367
	public static class IEntityOwnerInfoVerify
	{
		// Token: 0x0601C5C6 RID: 116166 RVA: 0x0040384E File Offset: 0x00401A4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
