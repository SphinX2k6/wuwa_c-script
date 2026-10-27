using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004894 RID: 18580
	public static class IP4SyncDataVerify
	{
		// Token: 0x0601CFED RID: 118765 RVA: 0x00418B16 File Offset: 0x00416D16
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
