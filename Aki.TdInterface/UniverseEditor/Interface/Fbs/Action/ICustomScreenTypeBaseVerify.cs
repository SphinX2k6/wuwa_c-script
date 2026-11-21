using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B80 RID: 27520
	public static class ICustomScreenTypeBaseVerify
	{
		// Token: 0x0602F5BA RID: 193978 RVA: 0x0067642A File Offset: 0x0067462A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
