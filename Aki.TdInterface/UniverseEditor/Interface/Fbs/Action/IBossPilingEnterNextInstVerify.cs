using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006217 RID: 25111
	public static class IBossPilingEnterNextInstVerify
	{
		// Token: 0x0602B48B RID: 177291 RVA: 0x005F6302 File Offset: 0x005F4502
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
