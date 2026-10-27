using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047DD RID: 18397
	public static class IEntityTransientDataVerify
	{
		// Token: 0x0601C717 RID: 116503 RVA: 0x00406426 File Offset: 0x00404626
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
