using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D3 RID: 29907
	public static class IPlotModeUiStyleBaseVerify
	{
		// Token: 0x060346CB RID: 214731 RVA: 0x0070F15A File Offset: 0x0070D35A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
