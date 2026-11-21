using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200630E RID: 25358
	public static class TWorldLevelBonusVerify
	{
		// Token: 0x0602B11E RID: 176414 RVA: 0x005DEE04 File Offset: 0x005DD004
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IWorldLevelTableVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAreaBounsVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
