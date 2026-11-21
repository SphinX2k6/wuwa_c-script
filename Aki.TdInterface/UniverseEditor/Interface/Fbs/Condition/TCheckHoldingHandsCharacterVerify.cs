using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005231 RID: 21041
	public static class TCheckHoldingHandsCharacterVerify
	{
		// Token: 0x0602123C RID: 135740 RVA: 0x004936E4 File Offset: 0x004918E4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckIsPlayerHoldingHandsVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckIsEntityHoldingHandsVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
