using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200623C RID: 25148
	public static class TExploreSkillSearchTargetCfgVerify
	{
		// Token: 0x0602AD12 RID: 175378 RVA: 0x005D8E6C File Offset: 0x005D706C
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
