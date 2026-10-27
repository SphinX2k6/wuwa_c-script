using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C4A RID: 23626
	public static class TInteractPlayerDiractionOptionVerify
	{
		// Token: 0x06028818 RID: 165912 RVA: 0x005926B8 File Offset: 0x005908B8
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
