using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D22 RID: 27938
	public static class IPlayGuestUiAnimationType_UnionVerify
	{
		// Token: 0x06031437 RID: 201783 RVA: 0x006AE4E4 File Offset: 0x006AC6E4
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
