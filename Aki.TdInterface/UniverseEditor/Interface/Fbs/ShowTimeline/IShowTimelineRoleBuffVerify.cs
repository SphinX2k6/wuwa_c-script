using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FD2 RID: 16338
	public static class IShowTimelineRoleBuffVerify
	{
		// Token: 0x06016552 RID: 91474 RVA: 0x00332F87 File Offset: 0x00331187
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
