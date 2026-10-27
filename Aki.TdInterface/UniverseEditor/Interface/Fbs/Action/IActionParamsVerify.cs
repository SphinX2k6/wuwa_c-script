using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006085 RID: 24709
	public static class IActionParamsVerify
	{
		// Token: 0x06029DB0 RID: 171440 RVA: 0x005BDC7A File Offset: 0x005BBE7A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
