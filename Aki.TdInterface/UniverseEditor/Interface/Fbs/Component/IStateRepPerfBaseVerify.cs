using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FBC RID: 24508
	public static class IStateRepPerfBaseVerify
	{
		// Token: 0x060293C5 RID: 168901 RVA: 0x005A0EC6 File Offset: 0x0059F0C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
