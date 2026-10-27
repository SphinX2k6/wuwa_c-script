using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B80 RID: 15232
	public static class IPlaceholderRefVerify
	{
		// Token: 0x06014DDC RID: 85468 RVA: 0x003076FC File Offset: 0x003058FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
