using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007444 RID: 29764
	public static class ITransitionPopupArtTextTypeBase_UnionVerify
	{
		// Token: 0x0603611F RID: 221471 RVA: 0x0075A92C File Offset: 0x00758B2C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITransitionPopupYuanChengArtTextVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITransitionPopupArtTextTypeBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
