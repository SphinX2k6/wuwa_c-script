using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007631 RID: 30257
	public static class TActorFxEmoteVerify
	{
		// Token: 0x060371B9 RID: 225721 RVA: 0x00779330 File Offset: 0x00777530
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
