using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006587 RID: 25991
	public static class IDestroyDynamicEntitiesTypeVerify
	{
		// Token: 0x0602D15A RID: 184666 RVA: 0x0062F526 File Offset: 0x0062D726
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
