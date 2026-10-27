using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D56 RID: 19798
	public static class TRogueStateTypeVerify
	{
		// Token: 0x0601F69F RID: 128671 RVA: 0x00460744 File Offset: 0x0045E944
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
