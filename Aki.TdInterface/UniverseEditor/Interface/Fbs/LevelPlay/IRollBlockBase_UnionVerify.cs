using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004553 RID: 17747
	public static class IRollBlockBase_UnionVerify
	{
		// Token: 0x0601AB56 RID: 109398 RVA: 0x003CF028 File Offset: 0x003CD228
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRollBlockBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRollBlock1Verify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRollBlock2Verify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
