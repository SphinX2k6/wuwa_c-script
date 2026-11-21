using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075BD RID: 30141
	public static class IRemoveBuffFromPlayerVerify
	{
		// Token: 0x06034E11 RID: 216593 RVA: 0x0071B72D File Offset: 0x0071992D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
