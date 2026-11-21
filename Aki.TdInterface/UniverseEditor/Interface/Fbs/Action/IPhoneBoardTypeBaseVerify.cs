using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007414 RID: 29716
	public static class IPhoneBoardTypeBaseVerify
	{
		// Token: 0x06033FE7 RID: 212967 RVA: 0x00702186 File Offset: 0x00700386
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
