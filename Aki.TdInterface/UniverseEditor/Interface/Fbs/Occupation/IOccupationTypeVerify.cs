using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043B8 RID: 17336
	public static class IOccupationTypeVerify
	{
		// Token: 0x06019D77 RID: 105847 RVA: 0x003B2FC6 File Offset: 0x003B11C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
