using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F7F RID: 16255
	public static class IPhoneMessageProgressTypeBase_UnionVerify
	{
		// Token: 0x0601733B RID: 95035 RVA: 0x00358F78 File Offset: 0x00357178
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
