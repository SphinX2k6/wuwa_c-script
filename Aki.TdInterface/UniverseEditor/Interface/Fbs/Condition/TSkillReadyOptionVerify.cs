using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005255 RID: 21077
	public static class TSkillReadyOptionVerify
	{
		// Token: 0x060212F6 RID: 135926 RVA: 0x0049484C File Offset: 0x00492A4C
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
