using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C13 RID: 31763
	public static class IToolEditorActionContextVerify
	{
		// Token: 0x060393EF RID: 234479 RVA: 0x007BB6BD File Offset: 0x007B98BD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
