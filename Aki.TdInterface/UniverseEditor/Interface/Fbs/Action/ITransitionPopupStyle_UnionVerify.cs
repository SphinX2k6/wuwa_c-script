using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007453 RID: 29779
	public static class ITransitionPopupStyle_UnionVerify
	{
		// Token: 0x0603619C RID: 221596 RVA: 0x0075B66C File Offset: 0x0075986C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITransitionPopupStyleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITransitionPopupLeftTopTipVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITransitionPopupLeftBottomTransitionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITransitionPopupArtTextVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
