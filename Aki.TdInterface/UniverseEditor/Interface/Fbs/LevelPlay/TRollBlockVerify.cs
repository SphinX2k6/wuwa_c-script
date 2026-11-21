using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A7B RID: 19067
	public static class TRollBlockVerify
	{
		// Token: 0x0601CAA5 RID: 117413 RVA: 0x0040B22C File Offset: 0x0040942C
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
