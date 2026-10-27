using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E54 RID: 28244
	public static class IRemoveNpcGroupPerformVerify
	{
		// Token: 0x06031E8D RID: 204429 RVA: 0x006C0BE9 File Offset: 0x006BEDE9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
