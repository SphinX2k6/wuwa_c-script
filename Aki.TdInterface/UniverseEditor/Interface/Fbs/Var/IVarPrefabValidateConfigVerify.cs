using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F12 RID: 16146
	public static class IVarPrefabValidateConfigVerify
	{
		// Token: 0x06015EE2 RID: 89826 RVA: 0x003274CE File Offset: 0x003256CE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
