using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005902 RID: 22786
	public static class ISequenceTrackControlPointVerify
	{
		// Token: 0x0602681D RID: 157725 RVA: 0x0054E371 File Offset: 0x0054C571
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
