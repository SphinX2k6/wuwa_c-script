using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A2A RID: 31274
	public static class ISwitchDataLayersTransitionType_UnionVerify
	{
		// Token: 0x060371B3 RID: 225715 RVA: 0x0075CF30 File Offset: 0x0075B130
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
