using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051C5 RID: 20933
	public static class ISkillReadyType_UnionVerify
	{
		// Token: 0x06020F4C RID: 134988 RVA: 0x0048E9D4 File Offset: 0x0048CBD4
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
