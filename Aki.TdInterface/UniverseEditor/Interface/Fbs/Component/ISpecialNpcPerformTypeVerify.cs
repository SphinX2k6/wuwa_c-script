using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F80 RID: 24448
	public static class ISpecialNpcPerformTypeVerify
	{
		// Token: 0x0602919C RID: 168348 RVA: 0x0059CD82 File Offset: 0x0059AF82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
