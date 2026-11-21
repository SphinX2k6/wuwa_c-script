using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F6 RID: 26358
	public static class IActivateResetPointVerify
	{
		// Token: 0x0602CA13 RID: 182803 RVA: 0x0061B892 File Offset: 0x00619A92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
