using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F7D RID: 24445
	public static class ISpecialAnimalTypeConfig_UnionVerify
	{
		// Token: 0x0602918A RID: 168330 RVA: 0x0059CBFC File Offset: 0x0059ADFC
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
