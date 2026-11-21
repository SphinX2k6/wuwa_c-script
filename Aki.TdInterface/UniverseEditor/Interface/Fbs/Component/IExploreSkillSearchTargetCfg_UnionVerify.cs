using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005774 RID: 22388
	public static class IExploreSkillSearchTargetCfg_UnionVerify
	{
		// Token: 0x0602419B RID: 147867 RVA: 0x004F6E54 File Offset: 0x004F5054
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
