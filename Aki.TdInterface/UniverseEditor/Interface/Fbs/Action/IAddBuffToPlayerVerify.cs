using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006124 RID: 24868
	public static class IAddBuffToPlayerVerify
	{
		// Token: 0x0602A81A RID: 174106 RVA: 0x005DA8DA File Offset: 0x005D8ADA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 8UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 8UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
