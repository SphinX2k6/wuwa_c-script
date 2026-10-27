using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007634 RID: 30260
	public static class TActorFxEmoteStopSubTypeVerify
	{
		// Token: 0x060371C5 RID: 225733 RVA: 0x0077942C File Offset: 0x0077762C
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
