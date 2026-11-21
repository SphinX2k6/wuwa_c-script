using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E8A RID: 32394
	public static class TClientModifyTargetVerify
	{
		// Token: 0x0603A7CC RID: 239564 RVA: 0x007DF5B8 File Offset: 0x007DD7B8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IClientModifySelfTargetVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IClientModifyPlayerTargetVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
