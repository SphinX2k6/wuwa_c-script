using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007426 RID: 29734
	public static class ITraceCurrentQuestVerify
	{
		// Token: 0x06036029 RID: 221225 RVA: 0x00758C82 File Offset: 0x00756E82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
