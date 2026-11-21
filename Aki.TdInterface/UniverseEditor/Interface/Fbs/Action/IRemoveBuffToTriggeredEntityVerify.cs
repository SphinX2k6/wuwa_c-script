using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C0 RID: 30144
	public static class IRemoveBuffToTriggeredEntityVerify
	{
		// Token: 0x06034E2B RID: 216619 RVA: 0x0071B9D1 File Offset: 0x00719BD1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
