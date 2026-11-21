using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200749D RID: 29853
	public static class IPlayGuestUiAnimationType_UnionVerify
	{
		// Token: 0x0603442F RID: 214063 RVA: 0x00709B28 File Offset: 0x00707D28
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlayGuestCartethyiaVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPlayGuestUiAnimationTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
