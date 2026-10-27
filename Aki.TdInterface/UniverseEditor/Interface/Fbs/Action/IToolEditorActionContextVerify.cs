using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007420 RID: 29728
	public static class IToolEditorActionContextVerify
	{
		// Token: 0x06036006 RID: 221190 RVA: 0x00758991 File Offset: 0x00756B91
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
