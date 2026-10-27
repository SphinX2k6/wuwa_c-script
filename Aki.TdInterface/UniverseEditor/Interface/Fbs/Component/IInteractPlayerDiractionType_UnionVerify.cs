using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005466 RID: 21606
	public static class IInteractPlayerDiractionType_UnionVerify
	{
		// Token: 0x060238B4 RID: 145588 RVA: 0x004EA968 File Offset: 0x004E8B68
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
