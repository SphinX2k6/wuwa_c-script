using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005436 RID: 21558
	public static class IInteractAdditionalInfo_UnionVerify
	{
		// Token: 0x0602369C RID: 145052 RVA: 0x004E6298 File Offset: 0x004E4498
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFishingPointAdditionalInfoVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInteractAdditionalInfoVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
