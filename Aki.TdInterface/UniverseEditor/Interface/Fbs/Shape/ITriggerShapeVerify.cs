using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004078 RID: 16504
	public static class ITriggerShapeVerify
	{
		// Token: 0x06016B82 RID: 93058 RVA: 0x0033F14A File Offset: 0x0033D34A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
