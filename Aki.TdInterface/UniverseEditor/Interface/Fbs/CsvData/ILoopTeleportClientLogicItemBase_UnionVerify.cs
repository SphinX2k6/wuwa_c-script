using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004904 RID: 18692
	public static class ILoopTeleportClientLogicItemBase_UnionVerify
	{
		// Token: 0x0601D383 RID: 119683 RVA: 0x0041F5A8 File Offset: 0x0041D7A8
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
