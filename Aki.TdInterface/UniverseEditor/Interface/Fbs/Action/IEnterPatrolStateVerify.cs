using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D48 RID: 27976
	public static class IEnterPatrolStateVerify
	{
		// Token: 0x06030417 RID: 197655 RVA: 0x0068F306 File Offset: 0x0068D506
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
