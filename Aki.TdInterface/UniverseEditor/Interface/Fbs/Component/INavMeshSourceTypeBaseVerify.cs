using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B8A RID: 23434
	public static class INavMeshSourceTypeBaseVerify
	{
		// Token: 0x060269F1 RID: 158193 RVA: 0x00549D8E File Offset: 0x00547F8E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
