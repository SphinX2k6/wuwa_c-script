using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047B9 RID: 18361
	public static class IEntityOwnerDataVerify
	{
		// Token: 0x0601C594 RID: 116116 RVA: 0x0040336D File Offset: 0x0040156D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
