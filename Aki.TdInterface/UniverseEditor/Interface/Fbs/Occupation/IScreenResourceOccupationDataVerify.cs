using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004829 RID: 18473
	public static class IScreenResourceOccupationDataVerify
	{
		// Token: 0x0601B58C RID: 112012 RVA: 0x003DFB42 File Offset: 0x003DDD42
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
