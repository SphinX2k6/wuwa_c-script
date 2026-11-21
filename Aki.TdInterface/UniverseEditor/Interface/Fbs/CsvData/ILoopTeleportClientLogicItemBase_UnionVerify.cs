using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D9F RID: 19871
	public static class ILoopTeleportClientLogicItemBase_UnionVerify
	{
		// Token: 0x0601ED1C RID: 126236 RVA: 0x0044ED08 File Offset: 0x0044CF08
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ILoopTeleportClientPlayEffectLogicVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ILoopTeleportClientLogicItemBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
