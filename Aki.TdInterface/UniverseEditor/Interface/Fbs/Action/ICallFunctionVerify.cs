using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006274 RID: 25204
	public static class ICallFunctionVerify
	{
		// Token: 0x0602B80C RID: 178188 RVA: 0x005FD6A5 File Offset: 0x005FB8A5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
