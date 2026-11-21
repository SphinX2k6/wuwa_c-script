using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005992 RID: 22930
	public static class IInhaledDestroySelfVerify
	{
		// Token: 0x06025618 RID: 153112 RVA: 0x005211A6 File Offset: 0x0051F3A6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
