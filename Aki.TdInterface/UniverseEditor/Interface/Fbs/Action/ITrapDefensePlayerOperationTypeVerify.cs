using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007468 RID: 29800
	public static class ITrapDefensePlayerOperationTypeVerify
	{
		// Token: 0x06036239 RID: 221753 RVA: 0x0075C6AE File Offset: 0x0075A8AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
