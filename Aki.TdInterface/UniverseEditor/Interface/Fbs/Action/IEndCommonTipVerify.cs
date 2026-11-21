using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D1B RID: 27931
	public static class IEndCommonTipVerify
	{
		// Token: 0x060302C1 RID: 197313 RVA: 0x0068CE05 File Offset: 0x0068B005
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
