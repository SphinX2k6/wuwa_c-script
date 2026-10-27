using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075DC RID: 30172
	public static class IVisualNovelRoleIntroductionConfigBase_UnionVerify
	{
		// Token: 0x06036F5F RID: 225119 RVA: 0x007756C4 File Offset: 0x007738C4
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
