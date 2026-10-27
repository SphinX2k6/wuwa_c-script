using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006566 RID: 25958
	public static class IDelayRemoveType_UnionVerify
	{
		// Token: 0x0602D08D RID: 184461 RVA: 0x0062E124 File Offset: 0x0062C324
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDelayRemoveAfterSkillFinishVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDelayRemoveTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
