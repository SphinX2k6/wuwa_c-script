using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C0D RID: 27661
	public static class IDestroySummonedEntitiesTypeVerify
	{
		// Token: 0x0602F9C0 RID: 195008 RVA: 0x0067CE73 File Offset: 0x0067B073
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
