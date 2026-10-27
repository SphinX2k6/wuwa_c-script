using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D59 RID: 19801
	public static class TSkillReadyOptionVerify
	{
		// Token: 0x0601F6AD RID: 128685 RVA: 0x00460878 File Offset: 0x0045EA78
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IESkillReadyVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IUltimateSkillReadyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisionSkillReadyVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
