using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004613 RID: 17939
	public static class TRollBlockVerify
	{
		// Token: 0x0601B2D0 RID: 111312 RVA: 0x003DEF90 File Offset: 0x003DD190
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRollBlock2Verify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRollBlock1Verify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
