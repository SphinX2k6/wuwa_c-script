using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200763B RID: 30267
	public static class IRestorePhantomVerify
	{
		// Token: 0x060351C3 RID: 217539 RVA: 0x00721CB6 File Offset: 0x0071FEB6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
