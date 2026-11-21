using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B5F RID: 27487
	public static class ICurrentVehicleVerify
	{
		// Token: 0x0602F4D2 RID: 193746 RVA: 0x00674EC6 File Offset: 0x006730C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
