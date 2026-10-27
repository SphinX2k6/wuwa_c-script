using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007706 RID: 30470
	public static class TLevelSequenceTransitionVerify
	{
		// Token: 0x0603766D RID: 226925 RVA: 0x00780BC4 File Offset: 0x0077EDC4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMaskTransitionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICameraTransitionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
