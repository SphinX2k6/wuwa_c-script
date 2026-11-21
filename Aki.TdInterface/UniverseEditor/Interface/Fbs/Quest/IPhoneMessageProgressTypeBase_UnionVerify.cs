using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043C0 RID: 17344
	public static class IPhoneMessageProgressTypeBase_UnionVerify
	{
		// Token: 0x060189CA RID: 100810 RVA: 0x00382B90 File Offset: 0x00380D90
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICompleteMessageQuestConditionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPhoneMessageProgressTypeBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
