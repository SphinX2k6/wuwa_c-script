using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E3F RID: 32319
	public static class TActorFxEmoteVerify
	{
		// Token: 0x0603A65E RID: 239198 RVA: 0x007DD42C File Offset: 0x007DB62C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IActorFxEmoteStopVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IActorFxEmotePlayVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
