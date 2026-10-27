using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043C7 RID: 17351
	public static class IScreenResourceOccupationDataVerify
	{
		// Token: 0x06019DF1 RID: 105969 RVA: 0x003B3EAA File Offset: 0x003B20AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
