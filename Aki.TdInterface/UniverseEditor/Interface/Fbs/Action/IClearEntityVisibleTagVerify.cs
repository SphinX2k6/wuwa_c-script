using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F5 RID: 27125
	public static class IClearEntityVisibleTagVerify
	{
		// Token: 0x0602E876 RID: 190582 RVA: 0x006589E1 File Offset: 0x00656BE1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
