using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006789 RID: 26505
	public static class IAddBuffToTriggeredEntityVerify
	{
		// Token: 0x0602CF15 RID: 184085 RVA: 0x00624B41 File Offset: 0x00622D41
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
