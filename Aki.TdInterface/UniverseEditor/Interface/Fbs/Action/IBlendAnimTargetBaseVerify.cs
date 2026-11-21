using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006879 RID: 26745
	public static class IBlendAnimTargetBaseVerify
	{
		// Token: 0x0602DB8F RID: 187279 RVA: 0x00640772 File Offset: 0x0063E972
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
