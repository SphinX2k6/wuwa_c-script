using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066CE RID: 26318
	public static class IEnterPatrolStateVerify
	{
		// Token: 0x0602DBFA RID: 187386 RVA: 0x00642052 File Offset: 0x00640252
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
