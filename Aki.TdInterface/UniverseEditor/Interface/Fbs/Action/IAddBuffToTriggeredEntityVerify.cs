using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006127 RID: 24871
	public static class IAddBuffToTriggeredEntityVerify
	{
		// Token: 0x0602A834 RID: 174132 RVA: 0x005DAB99 File Offset: 0x005D8D99
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
