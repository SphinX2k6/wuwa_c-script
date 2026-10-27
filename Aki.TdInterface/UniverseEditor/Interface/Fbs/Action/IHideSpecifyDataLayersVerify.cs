using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068FF RID: 26879
	public static class IHideSpecifyDataLayersVerify
	{
		// Token: 0x0602EE4C RID: 192076 RVA: 0x006656E7 File Offset: 0x006638E7
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
