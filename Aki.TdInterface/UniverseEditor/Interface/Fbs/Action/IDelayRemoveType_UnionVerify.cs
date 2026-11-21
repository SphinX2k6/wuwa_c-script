using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD7 RID: 27607
	public static class IDelayRemoveType_UnionVerify
	{
		// Token: 0x0602F849 RID: 194633 RVA: 0x0067A8E8 File Offset: 0x00678AE8
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
