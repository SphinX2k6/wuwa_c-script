using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C4 RID: 30660
	public static class TTalkEffectActionVerify
	{
		// Token: 0x060379F9 RID: 227833 RVA: 0x00785EF0 File Offset: 0x007840F0
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
