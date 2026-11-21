using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059EC RID: 23020
	public static class IInteractPlayerDiractionType_UnionVerify
	{
		// Token: 0x0602596C RID: 153964 RVA: 0x005279DC File Offset: 0x00525BDC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInteractPlayerDiractionTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInteractPlayerDiractionToNpcVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IInteractPlayerDiractionToLeisureVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
