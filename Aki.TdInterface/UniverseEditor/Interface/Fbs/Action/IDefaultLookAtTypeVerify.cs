using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200655A RID: 25946
	public static class IDefaultLookAtTypeVerify
	{
		// Token: 0x0602D04F RID: 184399 RVA: 0x0062DBFE File Offset: 0x0062BDFE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
