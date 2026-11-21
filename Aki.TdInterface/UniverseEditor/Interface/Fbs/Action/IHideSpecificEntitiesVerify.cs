using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FAF RID: 28591
	public static class IHideSpecificEntitiesVerify
	{
		// Token: 0x060317FE RID: 202750 RVA: 0x006B58B1 File Offset: 0x006B3AB1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
