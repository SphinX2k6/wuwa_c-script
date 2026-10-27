using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006902 RID: 26882
	public static class IHideSpecifyEntityVerify
	{
		// Token: 0x0602EE6A RID: 192106 RVA: 0x00665A13 File Offset: 0x00663C13
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
