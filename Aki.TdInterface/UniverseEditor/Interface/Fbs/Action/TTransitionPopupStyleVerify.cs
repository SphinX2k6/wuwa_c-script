using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077EB RID: 30699
	public static class TTransitionPopupStyleVerify
	{
		// Token: 0x06037ACD RID: 228045 RVA: 0x00787334 File Offset: 0x00785534
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITransitionPopupArtTextVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITransitionPopupLeftBottomTransitionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITransitionPopupLeftTopTipVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
