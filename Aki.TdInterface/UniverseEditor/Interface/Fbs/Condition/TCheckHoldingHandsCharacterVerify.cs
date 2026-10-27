using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D35 RID: 19765
	public static class TCheckHoldingHandsCharacterVerify
	{
		// Token: 0x0601F5F5 RID: 128501 RVA: 0x0045F754 File Offset: 0x0045D954
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
