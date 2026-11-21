using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007874 RID: 30836
	public static class ISetVehicleSpeedImmediatelyTypeVerify
	{
		// Token: 0x060363C2 RID: 222146 RVA: 0x00743CB6 File Offset: 0x00741EB6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
