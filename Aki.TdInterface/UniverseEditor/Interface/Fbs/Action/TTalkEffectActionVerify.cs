using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FFC RID: 32764
	public static class TTalkEffectActionVerify
	{
		// Token: 0x0603AF7C RID: 241532 RVA: 0x007EB504 File Offset: 0x007E9704
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITalkEffectStopVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITalkEffectPlayVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
