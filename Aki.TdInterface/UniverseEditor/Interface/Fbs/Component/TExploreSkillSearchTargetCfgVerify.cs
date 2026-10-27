using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C1D RID: 23581
	public static class TExploreSkillSearchTargetCfgVerify
	{
		// Token: 0x06028720 RID: 165664 RVA: 0x00590EDC File Offset: 0x0058F0DC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEnterScreenWeightVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAngleWeightVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
