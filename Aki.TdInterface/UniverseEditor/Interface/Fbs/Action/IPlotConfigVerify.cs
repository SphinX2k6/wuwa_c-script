using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D52 RID: 27986
	public static class IPlotConfigVerify
	{
		// Token: 0x060316A7 RID: 202407 RVA: 0x006B3706 File Offset: 0x006B1906
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
