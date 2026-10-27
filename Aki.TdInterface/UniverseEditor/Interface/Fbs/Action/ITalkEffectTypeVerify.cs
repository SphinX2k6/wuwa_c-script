using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B8 RID: 29368
	public static class ITalkEffectTypeVerify
	{
		// Token: 0x060341DC RID: 213468 RVA: 0x00701296 File Offset: 0x006FF496
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
