using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200626F RID: 25199
	public static class TInteractPlayerDiractionOptionVerify
	{
		// Token: 0x0602AE26 RID: 175654 RVA: 0x005DA8D0 File Offset: 0x005D8AD0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IInteractPlayerDiractionToNpcVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInteractPlayerDiractionToLeisureVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
