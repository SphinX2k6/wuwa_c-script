using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200520C RID: 21004
	public static class IExploreSkillSearchTargetCfg_UnionVerify
	{
		// Token: 0x06022205 RID: 139781 RVA: 0x004BC390 File Offset: 0x004BA590
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IExploreSkillSearchTargetCfgVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAngleWeightVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEnterScreenWeightVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
