using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065E1 RID: 26081
	public static class IDisableEntityLookAtVerify
	{
		// Token: 0x0602D3ED RID: 185325 RVA: 0x006336D9 File Offset: 0x006318D9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
