using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006384 RID: 25476
	public static class IClearEntityVisibleTagVerify
	{
		// Token: 0x0602C10C RID: 180492 RVA: 0x0060D88D File Offset: 0x0060BA8D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
