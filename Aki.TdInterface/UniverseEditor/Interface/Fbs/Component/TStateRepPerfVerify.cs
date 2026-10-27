using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB0 RID: 23728
	public static class TStateRepPerfVerify
	{
		// Token: 0x06028A0C RID: 166412 RVA: 0x005954A8 File Offset: 0x005936A8
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
