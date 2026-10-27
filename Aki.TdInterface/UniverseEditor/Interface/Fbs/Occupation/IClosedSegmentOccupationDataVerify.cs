using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004397 RID: 17303
	public static class IClosedSegmentOccupationDataVerify
	{
		// Token: 0x06019BF2 RID: 105458 RVA: 0x003AFAE2 File Offset: 0x003ADCE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
