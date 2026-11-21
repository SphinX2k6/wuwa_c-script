using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E77 RID: 28279
	public static class IFlowCameraShakeVerify
	{
		// Token: 0x06030DC8 RID: 200136 RVA: 0x006A0F3D File Offset: 0x0069F13D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
