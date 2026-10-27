using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EFC RID: 28412
	public static class IRoleTowerGotoNextFloorVerify
	{
		// Token: 0x0603233F RID: 205631 RVA: 0x006C892A File Offset: 0x006C6B2A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
