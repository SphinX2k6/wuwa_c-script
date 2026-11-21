using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CC7 RID: 31943
	public static class IUnlockCookSystemType_UnionVerify
	{
		// Token: 0x060399F3 RID: 236019 RVA: 0x007C64C4 File Offset: 0x007C46C4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IUnlockCookSystemCookBookVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IUnlockCookSystemTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
