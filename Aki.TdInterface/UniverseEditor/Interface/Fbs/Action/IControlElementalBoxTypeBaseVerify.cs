using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064D3 RID: 25811
	public static class IControlElementalBoxTypeBaseVerify
	{
		// Token: 0x0602CC67 RID: 183399 RVA: 0x00627486 File Offset: 0x00625686
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
