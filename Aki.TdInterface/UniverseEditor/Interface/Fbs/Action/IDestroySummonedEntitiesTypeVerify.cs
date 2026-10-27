using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065A5 RID: 26021
	public static class IDestroySummonedEntitiesTypeVerify
	{
		// Token: 0x0602D23C RID: 184892 RVA: 0x00630CAF File Offset: 0x0062EEAF
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
