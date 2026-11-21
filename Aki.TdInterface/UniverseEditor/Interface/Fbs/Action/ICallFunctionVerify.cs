using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E5 RID: 26853
	public static class ICallFunctionVerify
	{
		// Token: 0x0602DF6D RID: 188269 RVA: 0x006484AD File Offset: 0x006466AD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
