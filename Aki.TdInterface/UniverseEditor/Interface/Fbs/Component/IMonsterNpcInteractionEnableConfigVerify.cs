using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005589 RID: 21897
	public static class IMonsterNpcInteractionEnableConfigVerify
	{
		// Token: 0x0602440A RID: 148490 RVA: 0x00501A5D File Offset: 0x004FFC5D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
