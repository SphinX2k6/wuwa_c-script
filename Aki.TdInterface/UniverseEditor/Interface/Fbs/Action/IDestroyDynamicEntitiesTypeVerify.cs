using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BEF RID: 27631
	public static class IDestroyDynamicEntitiesTypeVerify
	{
		// Token: 0x0602F8DE RID: 194782 RVA: 0x0067B6EA File Offset: 0x006798EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
