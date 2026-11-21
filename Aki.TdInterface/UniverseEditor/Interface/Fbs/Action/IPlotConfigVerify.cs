using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074CD RID: 29901
	public static class IPlotConfigVerify
	{
		// Token: 0x060346A3 RID: 214691 RVA: 0x0070EDEE File Offset: 0x0070CFEE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
