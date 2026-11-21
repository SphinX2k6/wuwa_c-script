using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C45 RID: 19525
	public static class IEntityTransientDataVerify
	{
		// Token: 0x0601DF14 RID: 122644 RVA: 0x00432D76 File Offset: 0x00430F76
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
