using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008029 RID: 32809
	public static class TTransitionPopupStyleVerify
	{
		// Token: 0x0603B06C RID: 241772 RVA: 0x007ECBE0 File Offset: 0x007EADE0
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
