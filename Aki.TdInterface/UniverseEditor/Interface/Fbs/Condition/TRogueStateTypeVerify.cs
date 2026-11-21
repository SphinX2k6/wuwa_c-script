using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005252 RID: 21074
	public static class TRogueStateTypeVerify
	{
		// Token: 0x060212E8 RID: 135912 RVA: 0x00494718 File Offset: 0x00492918
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckRogueTalentVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckRogueMiracleCreationVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
