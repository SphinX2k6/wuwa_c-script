using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006091 RID: 24721
	public static class IActivateGiantTotalProgressNodeVerify
	{
		// Token: 0x0602A325 RID: 172837 RVA: 0x005D1802 File Offset: 0x005CFA02
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
