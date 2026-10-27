using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007543 RID: 30019
	public static class IVillageInfrBuildOption_UnionVerify
	{
		// Token: 0x060369DD RID: 223709 RVA: 0x0076B778 File Offset: 0x00769978
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVillageInfrBuildOptionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVillageInfrVillageLevelVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVillageInfrTreeProcessVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
