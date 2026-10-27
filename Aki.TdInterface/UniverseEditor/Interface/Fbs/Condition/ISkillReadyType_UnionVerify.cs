using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CC9 RID: 19657
	public static class ISkillReadyType_UnionVerify
	{
		// Token: 0x0601F308 RID: 127752 RVA: 0x0045AADC File Offset: 0x00458CDC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISkillReadyTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IUltimateSkillReadyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IESkillReadyVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
