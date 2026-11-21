using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200698D RID: 27021
	public static class IChangeRandomStateVerify
	{
		// Token: 0x0602E599 RID: 189849 RVA: 0x00653C69 File Offset: 0x00651E69
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
