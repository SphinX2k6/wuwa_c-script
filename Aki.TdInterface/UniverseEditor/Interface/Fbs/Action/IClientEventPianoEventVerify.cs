using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A13 RID: 27155
	public static class IClientEventPianoEventVerify
	{
		// Token: 0x0602E966 RID: 190822 RVA: 0x0065A76E File Offset: 0x0065896E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
