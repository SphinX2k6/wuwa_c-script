using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EF9 RID: 32505
	public static class THandInHandInitiatorVerify
	{
		// Token: 0x0603AA38 RID: 240184 RVA: 0x007E34F0 File Offset: 0x007E16F0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlayerHandInHandInitiatorVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEntityHandInHandInitiatorVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
