using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005420 RID: 21536
	public static class IBaseRoleNpcPerformVerify
	{
		// Token: 0x06021BCC RID: 138188 RVA: 0x004A69A2 File Offset: 0x004A4BA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
