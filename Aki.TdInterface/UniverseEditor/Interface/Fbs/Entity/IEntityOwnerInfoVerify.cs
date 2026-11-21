using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C27 RID: 19495
	public static class IEntityOwnerInfoVerify
	{
		// Token: 0x0601DD9B RID: 122267 RVA: 0x0042FAEA File Offset: 0x0042DCEA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
