using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007255 RID: 29269
	public static class ISwitchDataLayersTransitionType_UnionVerify
	{
		// Token: 0x06033EB1 RID: 212657 RVA: 0x006FBBD0 File Offset: 0x006F9DD0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISwitchDataLayersTransitionWithSequenceVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISwitchDataLayersTransitionTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
