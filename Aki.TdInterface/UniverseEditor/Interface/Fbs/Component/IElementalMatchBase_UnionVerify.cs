using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200569C RID: 22172
	public static class IElementalMatchBase_UnionVerify
	{
		// Token: 0x060237E3 RID: 145379 RVA: 0x004E1E6C File Offset: 0x004E006C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IElementalMatchBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFireElementalMatchVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IWaterElementalMatchVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IWoodElementalMatchVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
