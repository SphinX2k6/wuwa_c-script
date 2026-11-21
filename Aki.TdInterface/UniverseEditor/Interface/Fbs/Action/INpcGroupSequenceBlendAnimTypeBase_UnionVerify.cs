using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007318 RID: 29464
	public static class INpcGroupSequenceBlendAnimTypeBase_UnionVerify
	{
		// Token: 0x06033602 RID: 210434 RVA: 0x006ED680 File Offset: 0x006EB880
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || INpcGroupSequenceMontageBlendAnimTypeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = INpcGroupSequenceBlendAnimTypeBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
