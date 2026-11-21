using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F1A RID: 32538
	public static class TLevelSequenceTransitionVerify
	{
		// Token: 0x0603AB3A RID: 240442 RVA: 0x007E50D0 File Offset: 0x007E32D0
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
