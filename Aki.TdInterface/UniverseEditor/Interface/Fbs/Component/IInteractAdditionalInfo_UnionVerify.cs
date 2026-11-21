using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059BC RID: 22972
	public static class IInteractAdditionalInfo_UnionVerify
	{
		// Token: 0x06025754 RID: 153428 RVA: 0x005232C4 File Offset: 0x005214C4
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
