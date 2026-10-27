using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CDA RID: 23770
	public static class TWorldLevelBonusVerify
	{
		// Token: 0x06028ACA RID: 166602 RVA: 0x00596594 File Offset: 0x00594794
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
