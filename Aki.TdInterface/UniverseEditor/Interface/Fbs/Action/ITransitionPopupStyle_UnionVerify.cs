using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C46 RID: 31814
	public static class ITransitionPopupStyle_UnionVerify
	{
		// Token: 0x06039585 RID: 234885 RVA: 0x007BE398 File Offset: 0x007BC598
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
