using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200732A RID: 29482
	public static class ITalkOptionConditionSystemConfigBaseVerify
	{
		// Token: 0x0603581F RID: 219167 RVA: 0x0074A316 File Offset: 0x00748516
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
