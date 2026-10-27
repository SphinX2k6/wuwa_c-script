using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200694D RID: 26957
	public static class IInfrActivityBuildStageOption_UnionVerify
	{
		// Token: 0x0602F117 RID: 192791 RVA: 0x0066A3E0 File Offset: 0x006685E0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInfrActivityBuildStageOptionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInfrActivityInfrastructureStageVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IInfrActivityRoadProcessVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
