using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E42 RID: 32322
	public static class TActorFxEmoteStopSubTypeVerify
	{
		// Token: 0x0603A66A RID: 239210 RVA: 0x007DD528 File Offset: 0x007DB728
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IActorFxEmoteStopSocketsVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IActorFxEmoteStopAllVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
