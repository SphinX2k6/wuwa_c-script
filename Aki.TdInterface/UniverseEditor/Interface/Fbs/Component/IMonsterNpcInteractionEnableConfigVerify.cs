using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B27 RID: 23335
	public static class IMonsterNpcInteractionEnableConfigVerify
	{
		// Token: 0x06026617 RID: 157207 RVA: 0x00541FD5 File Offset: 0x005401D5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
