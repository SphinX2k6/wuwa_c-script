using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B2A RID: 23338
	public static class IMonsterNpcInteractionGazePerformVerify
	{
		// Token: 0x06026629 RID: 157225 RVA: 0x0054214A File Offset: 0x0054034A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
