using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DE1 RID: 32225
	public static class IVisualNovelRoleIntroductionConfigBase_UnionVerify
	{
		// Token: 0x0603A3CE RID: 238542 RVA: 0x007D9318 File Offset: 0x007D7518
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IVisualNovelRoleIntroductionSolarSchoolVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IVisualNovelRoleIntroductionConfigBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
