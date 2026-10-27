using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006470 RID: 25712
	public static class ICommonBtOverrideTaskInfoBaseVerify
	{
		// Token: 0x0602C890 RID: 182416 RVA: 0x0061D596 File Offset: 0x0061B796
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
