using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200578C RID: 22412
	public static class IProceduralMaterialTypeVerify
	{
		// Token: 0x06025938 RID: 153912 RVA: 0x0052ED9E File Offset: 0x0052CF9E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
