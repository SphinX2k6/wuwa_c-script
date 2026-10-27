using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200534F RID: 21327
	public static class IGroupFinishConfigVerify
	{
		// Token: 0x06022E37 RID: 142903 RVA: 0x004D531E File Offset: 0x004D351E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
