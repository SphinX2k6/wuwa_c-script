using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006581 RID: 25985
	public static class IDestroyAllChildVerify
	{
		// Token: 0x0602D136 RID: 184630 RVA: 0x0062F1C2 File Offset: 0x0062D3C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
