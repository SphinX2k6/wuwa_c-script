using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E90 RID: 32400
	public static class TClientSetSeasonStateVerify
	{
		// Token: 0x0603A7E6 RID: 239590 RVA: 0x007DF7FC File Offset: 0x007DD9FC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISwitchSeasonVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ILoopSeasonChangeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
