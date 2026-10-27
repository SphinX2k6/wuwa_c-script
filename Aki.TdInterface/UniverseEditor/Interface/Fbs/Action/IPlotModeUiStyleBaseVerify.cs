using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D58 RID: 27992
	public static class IPlotModeUiStyleBaseVerify
	{
		// Token: 0x060316CF RID: 202447 RVA: 0x006B3A72 File Offset: 0x006B1C72
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
