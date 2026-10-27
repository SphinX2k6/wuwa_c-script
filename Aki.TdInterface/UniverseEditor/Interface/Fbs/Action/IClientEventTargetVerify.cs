using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063AE RID: 25518
	public static class IClientEventTargetVerify
	{
		// Token: 0x0602C250 RID: 180816 RVA: 0x0060FE8A File Offset: 0x0060E08A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
