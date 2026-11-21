using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062E1 RID: 25313
	public static class TStateRepPerfVerify
	{
		// Token: 0x0602B054 RID: 176212 RVA: 0x005DDC1C File Offset: 0x005DBE1C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IStateRepPerfEffectsVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IStateRepPerfMontagePathVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IStateRepPerfSkillIdVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
