using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA6 RID: 28070
	public static class IPreprocessOperationConfigVerify
	{
		// Token: 0x0603196C RID: 203116 RVA: 0x006B860E File Offset: 0x006B680E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
