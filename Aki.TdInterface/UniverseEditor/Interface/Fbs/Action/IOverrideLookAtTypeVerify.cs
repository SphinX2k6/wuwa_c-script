using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C59 RID: 27737
	public static class IOverrideLookAtTypeVerify
	{
		// Token: 0x06030DF8 RID: 200184 RVA: 0x006A36DA File Offset: 0x006A18DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
