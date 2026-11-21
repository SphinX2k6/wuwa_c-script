using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F04 RID: 28420
	public static class IFrequencyPaintVerify
	{
		// Token: 0x060312E0 RID: 201440 RVA: 0x006AA4EA File Offset: 0x006A86EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
