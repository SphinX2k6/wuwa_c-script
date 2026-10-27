using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A8 RID: 28840
	public static class ISetVehicleSpeedImmediatelyTypeVerify
	{
		// Token: 0x06033120 RID: 209184 RVA: 0x006E36AA File Offset: 0x006E18AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
