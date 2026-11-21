using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200721B RID: 29211
	public static class IMonsterNpcInteractConfigBaseVerify
	{
		// Token: 0x06032D45 RID: 208197 RVA: 0x006DD1DA File Offset: 0x006DB3DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
