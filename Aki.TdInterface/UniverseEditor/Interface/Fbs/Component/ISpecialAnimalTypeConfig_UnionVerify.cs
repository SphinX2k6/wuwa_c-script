using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005970 RID: 22896
	public static class ISpecialAnimalTypeConfig_UnionVerify
	{
		// Token: 0x06026C20 RID: 158752 RVA: 0x00555F90 File Offset: 0x00554190
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICollectAnimalConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISpecialAnimalTypeConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
