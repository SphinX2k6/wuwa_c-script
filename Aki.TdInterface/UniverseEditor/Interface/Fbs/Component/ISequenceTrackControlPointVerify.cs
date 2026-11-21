using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F0F RID: 24335
	public static class ISequenceTrackControlPointVerify
	{
		// Token: 0x06028D87 RID: 167303 RVA: 0x00594FDD File Offset: 0x005931DD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
