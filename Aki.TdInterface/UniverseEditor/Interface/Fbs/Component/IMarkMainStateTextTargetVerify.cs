using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA6 RID: 23206
	public static class IMarkMainStateTextTargetVerify
	{
		// Token: 0x0602609C RID: 155804 RVA: 0x00536595 File Offset: 0x00534795
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
