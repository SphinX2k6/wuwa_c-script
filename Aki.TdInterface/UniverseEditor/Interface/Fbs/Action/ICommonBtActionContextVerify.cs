using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC6 RID: 27334
	public static class ICommonBtActionContextVerify
	{
		// Token: 0x0602EEB0 RID: 192176 RVA: 0x006641F5 File Offset: 0x006623F5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
