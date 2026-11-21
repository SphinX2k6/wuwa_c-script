using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049BB RID: 18875
	public static class IRollBlockBase_UnionVerify
	{
		// Token: 0x0601C32B RID: 115499 RVA: 0x003FB2C4 File Offset: 0x003F94C4
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
