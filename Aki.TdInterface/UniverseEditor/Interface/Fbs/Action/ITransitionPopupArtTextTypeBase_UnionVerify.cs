using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C37 RID: 31799
	public static class ITransitionPopupArtTextTypeBase_UnionVerify
	{
		// Token: 0x06039508 RID: 234760 RVA: 0x007BD658 File Offset: 0x007BB858
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
